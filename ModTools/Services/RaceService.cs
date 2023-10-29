using ModTools.Model.Race;
using ModTools.Model.String;
using ModTools.Services.Contracts;

namespace ModTools.Services;

public class RaceService : IRaceService
{
    private readonly IGameFileCacheService _gameFileCache;
    private GameUsedProperties _gameUsedProperties;

    
    public RaceService(IGameFileCacheService gameFileCache)
    {
        _gameFileCache = gameFileCache;
    }


    public CitizenRaceList? LoadGameRaceList(string gamePlayFolderPath)
    {
        var list = LoadRaceList_private(
            $"{gamePlayFolderPath}{Path.DirectorySeparatorChar}{Constants.Race.RACES_INSTALLED_FILENAME}");
        AnalyzeRaces(list);
        return list;
    }

    private CitizenRaceList? LoadRaceList_private(string path)
    {
        var raceList = (CitizenRaceList) null;
        try
        {
            try
            {
                raceList = _gameFileCache.GetGameFile<CitizenRaceList>(path);
                raceList.BasePath = Path.GetDirectoryName(path) + Path.DirectorySeparatorChar;

                var races = raceList.CitizenRaces;
                
                var tfn = raceList.BasePath + Constants.RELATIVE_FROM_GAMEPLAY_TEXT_FOLDER +
                          Constants.Race.RACES_TEXT_INSTALLED_FILENAME;
                var stringList = _gameFileCache.GetGameFile<StringTableList>(tfn);
                races.ForEach(race =>
                {
                    race.Name_Parsed = stringList.StringTables
                        .FirstOrDefault(name => name.Label.Equals(race.DisplayName)).String;
                    race.Description_Desired = stringList.StringTables
                        .FirstOrDefault(desc => desc.Label.Equals(race.Description)).String;
                    race.IsDefaultRace = true;
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR!!!!! : " + ex.Message);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return raceList;
    }

    public CitizenRaceList? LoadRaceList(string path)
    {
        return LoadRaceList_private(path);
    }
    
    
    public void SaveRace(IRaceService.SaveRaceObject saveRaceObject)
    {
        // Copy images to mod folder
        var citizenPortraits = CopyCitizenPortraits(saveRaceObject);

        // Update CurrentRace name and description properties
        var internalName = $"{Constants.Race.PREFIX}{saveRaceObject.race.Name_Parsed}";
        saveRaceObject.race.InternalName = internalName;
        var displayName = $"{internalName}{Constants.DISPLAYNAME_SUFFIX}";
        saveRaceObject.race.DisplayName = displayName;
        var description = $"{internalName}{Constants.DESCRIPTION_SUFFIX}";
        saveRaceObject.race.Description = description;
        var textDir = Utils.GetModPath(saveRaceObject.modFolderPath, "Text");
        if (!Directory.Exists(textDir))
        {
            Directory.CreateDirectory(textDir);
        }
        
        if (saveRaceObject.IsReplaceMod)
        {
            AppendInGameRaceText(saveRaceObject, description, displayName, textDir);
        }
        else
        {
            saveRaceObject.race.Description = saveRaceObject.race.Description_Desired;
            saveRaceObject.race.DisplayName = saveRaceObject.race.Name_Desired;    
        }

        var citizenPortraitsFlavorTextDefsXml = new CitizenPortraitsFlavorTextDefs
        {
            CitizenPortraits = new CitizenPortraits
            {
                CitizenPortraitLists = new List<CitizenPortraitList> { new()
                {
                    Requirements = new Requirements { CitizenRace = saveRaceObject.race.InternalName },
                    Portraits = citizenPortraits.ToList()
                }}
            }
        };
        
        var modFilePath = $"{textDir}UnitPortraits_{saveRaceObject.race.Name_Parsed}.xml";
        citizenPortraitsFlavorTextDefsXml.SerializeToXml(modFilePath);

        // Now save the race def        
        var gamePlayPath = Utils.GetModPath(saveRaceObject.modFolderPath, "Gameplay");
        if (!Directory.Exists(gamePlayPath))
        {
            Directory.CreateDirectory(gamePlayPath);
        }

        modFilePath = $"{gamePlayPath}UnitRaceDef_{saveRaceObject.race.Name_Parsed}.xml";
        var newRaceList = saveRaceObject.raceList.DeepCopy();
        newRaceList.CitizenRaces.Clear();
        newRaceList.CitizenRaces.Add(saveRaceObject.race);
        
        // Write out citizen race list xml file
        newRaceList.SerializeToXml(modFilePath);
    }

    public GameUsedProperties GetGameUsedProperties()
    {
        return _gameUsedProperties;
    }

    private void AnalyzeRaces(CitizenRaceList? raceList)
    {
        _gameUsedProperties = new GameUsedProperties();
        var globalStats = new HashSet<GlobalStats>();
        var colonyStats = new HashSet<ColonyStats>();
        var approvalModifiers = new HashSet<ApprovalModifiers>();
        var specialValues = new HashSet<SpecialValue?>();
        var targets = new HashSet<string>();
        var bonusTypes = new HashSet<string>();
        var approvalTypes = new HashSet<string>();
        var effectTypes = new HashSet<string>();
        var approvalTags = new HashSet<string>();
        var colonyValueTypes = new HashSet<string>();
        var defaultTraits = new HashSet<string>();
        var consumedTraits = new HashSet<string>();
        raceList.CitizenRaces.ForEach(race =>
        {
            race.GlobalStats.ForEach(stat =>
            {
                globalStats.Add(stat);
                effectTypes.Add(stat.EffectType);
                bonusTypes.Add(stat.BonusType);
                targets.Add(stat.Target.TargetType);
            });
            race.ColonyStats.ForEach(stat =>
            {
                colonyStats.Add(stat);
                effectTypes.Add(stat.EffectType);
                bonusTypes.Add(stat.BonusType.ToString());
                specialValues.Add(stat.SpecialValue);
                targets.Add(stat.Target.TargetType);
                colonyValueTypes.Add(stat.ValueType);
            });
            race.ApprovalModifiers.ForEach(mod =>
            {
                approvalModifiers.Add(mod);
                bonusTypes.Add(mod.BonusType);
                approvalTypes.Add(mod.Type);
                approvalTags.Add(mod.Tag);
            });
            defaultTraits.Add(race.DefaultTraits);
            consumedTraits.Add(race.ConsumedTrait);
        });
        specialValues.Remove(null);
        approvalTags.Remove(null);
        if (defaultTraits.Contains(null))
        {
            defaultTraits.Remove(null);
            defaultTraits.Add("");
        }
        if (consumedTraits.Contains(null))
        {
            consumedTraits.Remove(null);
            consumedTraits.Add("");
        }
        _gameUsedProperties.ApprovalTags = approvalTags;
        _gameUsedProperties.ApprovalTypes = approvalTypes;
        _gameUsedProperties.BonusTypes = bonusTypes;
        _gameUsedProperties.ConsumedTraits = consumedTraits;
        _gameUsedProperties.DefaultTraits = defaultTraits;
        _gameUsedProperties.EffectTypes = effectTypes;
        _gameUsedProperties.TargetTypes = targets;
        _gameUsedProperties.SpecialValues = specialValues;
    }
    
    private void AppendInGameRaceText(IRaceService.SaveRaceObject saveRaceObject, string description, string displayName, string textDir)
    {
        var gameTextPath = $"{saveRaceObject.gamePlayFolderPath}{Constants.RELATIVE_FROM_GAMEPLAY_TEXT_FOLDER}{Constants.Race.RACES_TEXT_INSTALLED_FILENAME}";
        var racetextList = _gameFileCache.GetGameFile<StringTableList>(gameTextPath);
        var nameTable = new StringTable
        {
            Label = displayName,
            String = saveRaceObject.race.Name_Desired
        };
        var decTable = new StringTable
        {
            Label = description,
            String = saveRaceObject.race.Description_Desired
        };
        racetextList.StringTables.Add(nameTable);
        racetextList.StringTables.Add(decTable);
        var path = $"{textDir}{Path.DirectorySeparatorChar}{Constants.Race.RACES_TEXT_INSTALLED_FILENAME}";
        // Write out string list xml file
        racetextList.SerializeToXml(path);
    }
    
    private static HashSet<string> CopyCitizenPortraits(IRaceService.SaveRaceObject saveRaceObject)
    {
        var citizenDir = GetCitizenDir(saveRaceObject.modFolderPath) + "{0}";
        var citizenPortraits = new HashSet<string>();
        var modFilePath = string.Format(citizenDir, saveRaceObject.race.GenericImage);
        File.Copy(saveRaceObject.race.GenericImageFullPath, modFilePath, true);
        modFilePath = string.Format(citizenDir, saveRaceObject.race.MilitaryAdvisorPortrait);
        File.Copy(saveRaceObject.race.MilitaryAdvisorPortraitFullPath, modFilePath, true);
        modFilePath = string.Format(citizenDir, saveRaceObject.race.ColonizationAdvisorPortrait);
        File.Copy(saveRaceObject.race.ColonizationAdvisorPortraitFullPath, modFilePath, true);
        modFilePath = string.Format(citizenDir, saveRaceObject.race.ScienceAdvisorPortrait);
        File.Copy(saveRaceObject.race.ScienceAdvisorPortraitFullPath, modFilePath, true);
        modFilePath = string.Format(citizenDir, saveRaceObject.race.PoliticalAdvisorPortrait);
        File.Copy(saveRaceObject.race.PoliticalAdvisorPortraitFullPath, modFilePath, true);

        citizenPortraits.Add(saveRaceObject.race.GenericImage);
        citizenPortraits.Add(saveRaceObject.race.MilitaryAdvisorPortrait);
        citizenPortraits.Add(saveRaceObject.race.ColonizationAdvisorPortrait);
        citizenPortraits.Add(saveRaceObject.race.ScienceAdvisorPortrait);
        citizenPortraits.Add(saveRaceObject.race.PoliticalAdvisorPortrait);
        
        foreach (var portraitPath in saveRaceObject.citizenPortraitPaths)
        {
            var filename = Path.GetFileName(portraitPath);
            
            if (!citizenPortraits.Add(filename)) continue;
            
            modFilePath = string.Format(citizenDir, filename);
            File.Copy(portraitPath, modFilePath, true);
        }

        return citizenPortraits;
    }
    
    
    private static string GetCitizenDir(string? modFolderPath)
    {
        var dir = Utils.GetModPath(modFolderPath, "Gfx", "Citizens");
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        return dir;
    }
}