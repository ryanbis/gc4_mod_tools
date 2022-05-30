using System.Xml;
using System.Xml.Serialization;
using ModTools.Model.Space;
using ModTools.Model.String;
using ModTools.Services.Contracts;

namespace ModTools.Services;

public class SpaceService : ISpaceService
{
    private readonly IGameFileCacheService _gameFileCacheService;


    public SpaceService(IGameFileCacheService gameFileCacheService)
    {
        _gameFileCacheService = gameFileCacheService;
    }

    public ISpaceService.StarsAndPlanets? LoadStarSystemsAndPlanets(string path)
    {
        var starsAndPlanets = new ISpaceService.StarsAndPlanets();

        try
        {
            var starSystemList = _gameFileCacheService.GetGameFile<StarSystemList>(path);
            starSystemList.BasePath = Path.GetDirectoryName(path) + Path.DirectorySeparatorChar;

            starsAndPlanets.StarSystemList = starSystemList;

            // Looks like 2 different groups here. One is the faction start systems, and the other are templates
            // for all the star systems in game it seems

            // Now load the star system strings
            var starSystemStringList = _gameFileCacheService.GetGameFile<StringTableList>(starSystemList.BasePath +
                Constants.RELATIVE_FROM_GAMEPLAY_TEXT_FOLDER +
                Constants.Space.STAR_SYSTEM_TEXT_INSTALLED_FILENAME);

            // Add the strings into the system objects for easier access
            foreach (var starSystemGroup in starSystemList.StarSystemGroups)
            {
                starSystemGroup.StarSystems.ForEach(system =>
                {
                    if (!string.IsNullOrWhiteSpace(system.DisplayName))
                    {
                        system.Name_Parsed = starSystemStringList.StringTables
                            .FirstOrDefault(name => name.Label.Equals(system.DisplayName)).String;
                    }

                    if (!string.IsNullOrWhiteSpace(system.Description))
                    {
                        system.Description_Desired = starSystemStringList.StringTables
                            .FirstOrDefault(desc => desc.Label.Equals(system.Description)).String;
                    }
                });
            }

            // Now load the planet defs from the installed game
            var planetList =
                _gameFileCacheService.GetGameFile<PlanetList>(starSystemList.BasePath +
                                                              Constants.Space.PLANET_DEFS_INSTALLED_FILENAME);
            starsAndPlanets.PlanetList = planetList;

            var planets = planetList.Planets;

            // Now load the planet def strings
            var planetsStringList = _gameFileCacheService.GetGameFile<StringTableList>(starSystemList.BasePath +
                Constants.RELATIVE_FROM_GAMEPLAY_TEXT_FOLDER +
                Constants.Space.PLANET_TEXT_INSTALLED_FILENAME);
            var gameTermStringList = _gameFileCacheService.GetGameFile<StringTableList>(starSystemList.BasePath +
                Constants.RELATIVE_FROM_GAMEPLAY_TEXT_FOLDER +
                Constants.Space.GAME_TERM_TEXT_FILENAME);

            // Parse the strings into the planet objects for easier access
            planetList.Planets.ForEach(planet =>
            {
                if (!string.IsNullOrWhiteSpace(planet.DisplayName))
                {
                    var thething = planetsStringList.StringTables
                        .FirstOrDefault(name => name.Label.Equals(planet.DisplayName));
                    if (thething != null)
                    {
                        planet.Name_Desired = thething.String;
                        planet.Name_Parsed = planet.Name_Desired.Replace(" ", "_");
                    }
                    else
                    {
                        var theotherthing = gameTermStringList.StringTables
                            .FirstOrDefault(name => name.Label.Equals(planet.DisplayName));
                        if (theotherthing != null)
                        {
                            planet.Name_Desired = theotherthing.String;
                            planet.Name_Parsed = planet.Name_Desired.Replace(" ", "_");
                        }
                        else
                        {
                            int i = 0;
                            i++;
                        }
                    }
                }
            });

            // Now load the star defs from the installed game
            var starList =
                _gameFileCacheService.GetGameFile<StarList>(starSystemList.BasePath +
                                                            Constants.Space.STAR_DEFS_INSTALLED_FILENAME);
            starsAndPlanets.StarList = starList;

            // Get the star def strings
            var starDefStringList = _gameFileCacheService.GetGameFile<StringTableList>(starSystemList.BasePath +
                Constants.RELATIVE_FROM_GAMEPLAY_TEXT_FOLDER +
                Constants.Space.STELLAR_OBJECT_TEXT_FILENAME);

            // apply strings to star objects for easier access
            starList.Stars.ForEach(star =>
            {
                if (!string.IsNullOrWhiteSpace(star.DisplayName))
                {
                    var text = starDefStringList.StringTables
                        .FirstOrDefault(name => name.Label.Equals(star.DisplayName));
                    if (text != null)
                    {
                        star.Name_Desired = text.String;
                        star.Name_Parsed = star.Name_Desired.Replace(" ", "_");
                    }
                    else
                    {
                        text = planetsStringList.StringTables.FirstOrDefault(name =>
                            name.Label.Equals(star.DisplayName));
                        if (text != null)
                        {
                            star.Name_Desired = text.String;
                            star.Name_Parsed = star.Name_Desired.Replace(" ", "_");
                        }
                        else
                        {
                            star.Name_Desired = text.String;
                            star.Name_Parsed = star.Name_Desired.Replace(" ", "_");
                        }
                    }
                }

                if (!string.IsNullOrWhiteSpace(star.TypeDisplayName))
                {
                    var text = starDefStringList.StringTables
                        .FirstOrDefault(name => name.Label.Equals(star.TypeDisplayName));
                    if (text != null)
                    {
                        star.TypeDisplayName_Parsed = text.String;
                    }
                }
            });
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return starsAndPlanets;
    }

    public ISpaceService.AnalyzeResult AnalyzeStarSystemsAndPlanets(ISpaceService.StarsAndPlanets starsAndPlanets)
    {
        var results = new ISpaceService.AnalyzeResult();
        var laneTypes = new HashSet<string>();
        var bodyTypes = new HashSet<string>();
        var bodyDefs = new HashSet<string>();
        var planetTypes = new HashSet<string>();
        var planetTraits = new HashSet<string>();
        var planetArtDefines = new HashSet<string>();
        var layoutAtlases = new HashSet<string>();
        var objectTypes = new HashSet<string>();
        var types = new HashSet<string>();
        var starArtDefines = new HashSet<string>();
        var starSfxDefines = new HashSet<string>();

        starsAndPlanets.StarSystemList.StarSystemGroups.ForEach(ssg =>
        {
            ssg.StarSystems.ForEach(system =>
            {
                system.OrbitLanes.ForEach(ol =>
                {
                    laneTypes.Add(ol.LaneType);
                    ol.Bodies?.ForEach(body =>
                    {
                        bodyTypes.Add(body.BodyType);
                        bodyDefs.Add(body.BodyDef);
                    });
                });
            });
        });

        starsAndPlanets.PlanetList.Planets.ForEach(planet =>
        {
            planetTypes.Add(planet.PlanetType);
            planetTraits.Add(planet.PlanetTrait);
            planetArtDefines.Add(planet.ArtDefine);
            if (!string.IsNullOrWhiteSpace(planet.LayoutAtlas))
            {
                layoutAtlases.Add(planet.LayoutAtlas);
            }
        });

        starsAndPlanets.StarList.Stars.ForEach(star =>
        {
            objectTypes.Add(star.ObjectType);
            types.Add(star.Type);
            starArtDefines.Add(star.ArtDefine);
            if (!string.IsNullOrWhiteSpace(star.SFXDefine))
            {
                starSfxDefines.Add(star.SFXDefine);
            }
        });

        if (planetArtDefines.Contains(null))
        {
            planetArtDefines.Remove(null);
            planetArtDefines.Add("");
        }

        results.PlanetArtDefines = planetArtDefines;
        results.BodyDefs = bodyDefs;
        results.BodyTypes = bodyTypes;
        results.LaneTypes = laneTypes;
        results.LayoutAtlases = layoutAtlases;

        if (planetTraits.Contains(null))
        {
            planetTraits.Remove(null);
            planetTraits.Add("");
        }

        results.PlanetTraits = planetTraits;
        results.PlanetTypes = planetTypes;

        results.ObjectTypes = objectTypes;
        results.Types = types;
        results.StarArtDefines = starArtDefines;
        results.SFXDefines = starSfxDefines;

        return results;
    }

    public void SaveStarSystemList(ISpaceService.SaveObject saveObject)
    {
        var modTextDir = $"{saveObject.modFolderPath}{Path.DirectorySeparatorChar}Text{Path.DirectorySeparatorChar}";
        if (!Directory.Exists(modTextDir))
        {
            Directory.CreateDirectory(modTextDir);
        }

        var modGamePlayPath = $"{saveObject.modFolderPath}{Path.DirectorySeparatorChar}Gameplay{Path.DirectorySeparatorChar}";
        if (!Directory.Exists(modGamePlayPath))
        {
            Directory.CreateDirectory(modGamePlayPath);
        }

        var modFilePath = "";
        if (saveObject.planetList?.Planets?.Count > 0)
        {
            // Extract text to string tables, or embed in def file depending on replace mod or not
            var gameTextPath =
                $"{saveObject.gameplayFolderPath}{Constants.RELATIVE_FROM_GAMEPLAY_TEXT_FOLDER}{Constants.Space.PLANET_TEXT_INSTALLED_FILENAME}";
            var planetTextList = _gameFileCacheService.GetGameFile<StringTableList>(gameTextPath);
            foreach (var planet in saveObject.planetList.Planets)
            {
                if (saveObject.IsReplaceMod)
                {
                    var text = new StringTable
                    {
                        Label = planet.DisplayName,
                        String = planet.Name_Desired
                    };
                    planetTextList.StringTables.Add(text);
                }
                else
                {
                    planet.DisplayName = planet.Name_Desired;
                }
            }

            if (saveObject.IsReplaceMod)
            {
                modFilePath = $"{modTextDir}{Constants.Space.PLANET_TEXT_INSTALLED_FILENAME}";
                planetTextList.SerializeToXml(modFilePath);
            }

            var planetList = saveObject.planetList;
            // Now save the planet defs
            if (saveObject.IsReplaceMod)
            {
                modFilePath = $"{modGamePlayPath}{Constants.Space.PLANET_DEFS_INSTALLED_FILENAME}";
                var gamePlanetDefsPath =
                    $"{saveObject.gameplayFolderPath}{Constants.Space.PLANET_DEFS_INSTALLED_FILENAME}";
                planetList = _gameFileCacheService.GetGameFile<PlanetList>(gamePlanetDefsPath);
                planetList.Planets.AddRange(saveObject.planetList.Planets);
            }
            else
            {
                modFilePath = $"{modGamePlayPath}Mod_{Constants.Space.PLANET_DEFS_INSTALLED_FILENAME}";
            }

            planetList.SerializeToXml(modFilePath);
        }

        // Stars
        if (saveObject.starList.Stars.Count > 0)
        {
            // Extract text to string tables, or embed in def file depending on replace mod or not
            var gameTextPath =
                $"{saveObject.gameplayFolderPath}{Constants.RELATIVE_FROM_GAMEPLAY_TEXT_FOLDER}{Constants.Space.STELLAR_OBJECT_TEXT_FILENAME}";
            var starTextList = _gameFileCacheService.GetGameFile<StringTableList>(gameTextPath);
            foreach (var star in saveObject.starList.Stars)
            {
                if (saveObject.IsReplaceMod)
                {
                    var text = new StringTable
                    {
                        Label = star.DisplayName,
                        String = star.Name_Desired
                    };
                    starTextList.StringTables.Add(text);
                }
                else
                {
                    star.DisplayName = star.Name_Desired;
                }
            }

            if (saveObject.IsReplaceMod)
            {
                modFilePath = $"{modTextDir}{Constants.Space.STELLAR_OBJECT_TEXT_FILENAME}";
                starTextList.SerializeToXml(modFilePath);
            }

            // Now save the star defs
            var starList = saveObject.starList;
            if (saveObject.IsReplaceMod)
            {
                modFilePath = $"{modGamePlayPath}{Constants.Space.STAR_DEFS_INSTALLED_FILENAME}";
                var starListGamePath = $"{saveObject.gameplayFolderPath}{Constants.Space.STAR_DEFS_INSTALLED_FILENAME}";
                starList = _gameFileCacheService.GetGameFile<StarList>(starListGamePath);
                starList.Stars.AddRange(saveObject.starList.Stars);
            }
            else
            {
                modFilePath = $"{modGamePlayPath}Mod_{Constants.Space.STAR_DEFS_INSTALLED_FILENAME}";
            }

            starList.SerializeToXml(modFilePath);
        }

        // Extract text to string tables, or embed in def file depending on replace mod or not
        var gameSystemTextPath =
            $"{saveObject.gameplayFolderPath}{Constants.RELATIVE_FROM_GAMEPLAY_TEXT_FOLDER}{Constants.Space.STAR_SYSTEM_TEXT_INSTALLED_FILENAME}";
        var starSystemTextList = _gameFileCacheService.GetGameFile<StringTableList>(gameSystemTextPath);
        foreach (var starSystemGroup in saveObject.starSystemList.StarSystemGroups)
        {
            starSystemGroup.StarSystems.ForEach(ss =>
            {
                if (saveObject.IsReplaceMod)
                {
                    var nameText = new StringTable
                    {
                        Label = ss.DisplayName,
                        String = ss.Name_Desired
                    };
                    starSystemTextList.StringTables.Add(nameText);
                    if (ss.Description != null)
                    {
                        var descText = new StringTable
                        {
                            Label = ss.Description,
                            String = ss.Description_Desired
                        };
                        starSystemTextList.StringTables.Add(descText);
                    }
                }
                else
                {
                    ss.DisplayName = ss.Name_Desired;
                    ss.Description = ss.Description_Desired;
                }
            });
        }

        if (saveObject.IsReplaceMod)
        {
            modFilePath = $"{modTextDir}{Constants.Space.STAR_SYSTEM_TEXT_INSTALLED_FILENAME}";
            starSystemTextList.SerializeToXml(modFilePath);
        }


        // Now finally save the star system defs
        var starSystemList = saveObject.starSystemList;
        if (saveObject.IsReplaceMod)
        {
            modFilePath = $"{modGamePlayPath}{Constants.Space.STAR_SYSTEM_INSTALLED_FILENAME}";
            var gameListGamePath = $"{saveObject.gameplayFolderPath}{Constants.Space.STAR_SYSTEM_INSTALLED_FILENAME}";
            starSystemList = _gameFileCacheService.GetGameFile<StarSystemList>(gameListGamePath);
            var group = starSystemList.StarSystemGroups.Find(ssg =>
                ssg.InternalName.Equals(Constants.Space.FACTION_START_STAR_SYSTEMS));
            var newstarSystems = saveObject.starSystemList.StarSystemGroups
                .Find(ssg => ssg.InternalName.Equals(Constants.Space.FACTION_START_STAR_SYSTEMS))?.StarSystems;
            if (newstarSystems != null && newstarSystems.Count > 0)
            {
                group.StarSystems.AddRange(newstarSystems);
            }

            group = starSystemList.StarSystemGroups.Find(ssg =>
                ssg.InternalName.Equals(Constants.Space.SYSTEM_TEMPLATE_STAR_GROUP));
            newstarSystems = saveObject.starSystemList.StarSystemGroups
                .Find(ssg => ssg.InternalName.Equals(Constants.Space.SYSTEM_TEMPLATE_STAR_GROUP))?.StarSystems;
            if (newstarSystems != null && newstarSystems.Count > 0)
            {
                group.StarSystems.AddRange(newstarSystems);
            }
        }
        else
        {
            modFilePath = $"{modGamePlayPath}Mod_{Constants.Space.STAR_SYSTEM_INSTALLED_FILENAME}";
        }

        starSystemList.SerializeToXml(modFilePath);
    }
}