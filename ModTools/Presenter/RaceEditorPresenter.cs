using Hanssens.Net;
using Microsoft.Extensions.DependencyInjection;
using ModTools.Event;
using ModTools.Model.Race;
using ModTools.Presenter.Contracts;
using ModTools.Services.Contracts;
using ModTools.View.Contracts;


namespace ModTools.Presenter;

public class RaceEditorPresenter : IRaceEditorPresenter
{
    private readonly IRaceEditorView _view;
    IRaceEditorView IPresenter<IRaceEditorView>.View => _view;

    public bool IsDestroyed => _view == null || _view.IsDisposed;
    
    private CitizenRaceList? RaceList { get; set; }
    private string? ModFolderPath { get; set; }
    private string? GamePlayFolderPath { get; set; }
    private string? GameInstallFolderPath { get; set; }
    
    private readonly ISettingsService _settingsService;
    private readonly IServiceProvider _serviceProvider;
    private readonly IImageService _imageService;
    private readonly IRaceService _raceService;
    private readonly IGenericDialogView _dialogView;
    
    private CitizenRace CurrentRace { get; set; } = new();
    private HashSet<string> CitizenPortraitList { get; set; } = new();


    public RaceEditorPresenter(IRaceEditorView view, ISettingsService settingsService, IImageService imageService,
        IRaceService raceService, IGenericDialogView dialogView, IServiceProvider serviceProvider)
    {
        _view = view;
        _settingsService = settingsService;
        _serviceProvider = serviceProvider;
        _imageService = imageService;
        _raceService = raceService;
        _dialogView = dialogView;
    }

    public void Init()
    {
        var gameInstallFolderPath = _settingsService.GetGameInstallPath();
        if (!string.IsNullOrWhiteSpace(gameInstallFolderPath))
        {
            GameInstallFolderPath = gameInstallFolderPath;
            GamePlayFolderPath = $"{gameInstallFolderPath}{Constants.GAMEPLAY_PATH}";
        }

        ModFolderPath = _settingsService.GetModFolderPath();

        if (GamePlayFolderPath != null)
        {
            LoadRaceDefs();
        }

        _view.RaceDropDownSelected += OnRaceDropDownSelected;
        _view.GenericImagePortraitClicked += OnGenericImagePortraitClicked;
        _view.MilitaryAdvisorPortraitClicked += OnMilitaryAdvisorPortraitClicked;
        _view.ScienceAdvisorPortraitClicked += OnScienceAdvisorPortraitClicked;
        _view.ColonizationAdvisorPortraitClicked += OnColonizationAdvisorPortraitClicked;
        _view.PoliticalAdvisorPortraitClicked += OnPoliticalAdvisorPortraitClicked;
        _view.AddGlobalStatClicked += OnAddGlobalStatClicked;
        _view.RemoveGlobalStatClicked += OnRemoveGlobalStatClicked;
        _view.AddColonyStatClicked += OnAddColonyStatClicked;
        _view.RemoveColonyStatClicked += OnRemoveColonyStatClicked;
        _view.AddApprovalModifiersClicked += OnAddApprovalModifiersClicked;
        _view.RemoveApprovalModifiersClicked += OnRemoveApprovalModifiersClicked;
        _view.NameTextChanged += OnNameTextChanged;
        _view.DescriptionTextChanged += OnDescriptionTextChanged;
        _view.CriminalChanceTextChanged += OnCriminalChanceTextChanged;
        _view.ProtestingApprovalThresholdTextChanged += OnProtestingApprovalThresholdTextChanged;
        _view.EmporiumChanceTextChanged += OnEmporiumChanceTextChanged;
        _view.IdeologyChanceTextChanged += OnIdeologyChanceTextChanged;
        _view.PacifistChanceTextChanged += OnPacifistChanceTextChanged;
        _view.WarforgedChanceTextChanged += OnWarforgedChanceTextChanged;
        _view.NaturalLeagueChanceTextChanged += OnNaturalLeagueChanceTextChanged;
        _view.IsMinorRaceCheckChanged += OnIsMinorRaceCheckChanged;
        _view.HasGenderCheckChanged += OnHasGenderCheckChanged;
        _view.SaveRaceClicked += OnSaveRaceClicked;
        _view.GlobalStatsDoubleClicked += OnGlobalStatsDoubleClicked;
        _view.ColonyStatsDoubleClicked += OnColonyStatsDoubleClicked;
        _view.ApprovalModifiersDoubleClicked += OnApprovalModifiersDoubleClicked;
        _view.ManagePortraitsButtonClicked += OnManagePortraitsButtonClicked;
        _view.DefaultTraitSelected += OnDefaultTraitSelected;
        _view.ConsumedTraitComboSelected += OnConsumedTraitSelected;
    }

    private void OnConsumedTraitSelected(object? sender, DataArg<string> e)
    {
        if (e.Value == null) return;
        CurrentRace.ConsumedTrait = e.Value;
        _view.SetConsumedTrait(e.Value);
    }

    private void OnDefaultTraitSelected(object? sender, DataArg<string> e)
    {
        if (e.Value == null) return;
        CurrentRace.DefaultTraits = e.Value;
        _view.SetDefaultTrait(e.Value);
    }

    private void OnManagePortraitsButtonClicked(object? sender, EventArgs e)
    {
        if (CitizenPortraitList.Count == 0)
        {            
            PopulateCitizenPortraitPaths();
        }
        var manageForm = _serviceProvider.GetRequiredService<IManageCitizenPortraitsPresenter>();
        manageForm.Init();
        manageForm.RefreshPaths(new HashSet<string>(CitizenPortraitList));
        manageForm.OnSaveCitizenImages += OnSaveCitizenImages;
        manageForm.Show();
    }

    private void PopulateCitizenPortraitPaths()
    {
        if (!string.IsNullOrWhiteSpace(CurrentRace.GenericImageFullPath)) CitizenPortraitList.Add(CurrentRace.GenericImageFullPath);
        if (!string.IsNullOrWhiteSpace(CurrentRace.MilitaryAdvisorPortraitFullPath)) CitizenPortraitList.Add(CurrentRace.MilitaryAdvisorPortraitFullPath);
        if (!string.IsNullOrWhiteSpace(CurrentRace.ColonizationAdvisorPortraitFullPath)) CitizenPortraitList.Add(CurrentRace.ColonizationAdvisorPortraitFullPath);
        if (!string.IsNullOrWhiteSpace(CurrentRace.ScienceAdvisorPortraitFullPath)) CitizenPortraitList.Add(CurrentRace.ScienceAdvisorPortraitFullPath);
        if (!string.IsNullOrWhiteSpace(CurrentRace.PoliticalAdvisorPortraitFullPath)) CitizenPortraitList.Add(CurrentRace.PoliticalAdvisorPortraitFullPath);

        var shortname = CurrentRace.InternalName.Replace("Race_", "");
        if (!shortname.Contains("_"))
        {
            var citizenDir = $"{_settingsService.GetGameInstallPath()}Gfx{Path.DirectorySeparatorChar}Citizens{Path.DirectorySeparatorChar}{shortname}";
            if (Directory.Exists(citizenDir))
            {
                foreach (string file in Directory.EnumerateFiles(citizenDir)) {
                    var extension = Path.GetExtension(file);
                    if (!CitizenPortraitList.Contains(file) &&
                        extension.Equals(".png", StringComparison.OrdinalIgnoreCase) ||
                        extension.Equals(".jpg", StringComparison.OrdinalIgnoreCase) ||
                        extension.Equals(".dds", StringComparison.OrdinalIgnoreCase)                        
                        )
                    {
                        CitizenPortraitList.Add(_imageService.LoadImage(file).Path);
                    }
                }
            }
        }
    }

    private void OnSaveCitizenImages(object? o, DataArg<IEnumerable<string>> arg)
    {
        CitizenPortraitList.Clear();
        foreach (var updatedPath in arg.Value)
        {
            CitizenPortraitList.Add(updatedPath);
        }
    }

    private void OnApprovalModifiersDoubleClicked(object? sender, DataArg<string> e)
    {
        var approvalModView = _serviceProvider.GetRequiredService<IApprovalModifierView>();
        var currentMod = CurrentRace.ApprovalModifiers.FirstOrDefault(am => am.Type.Equals(e.Value));
        if (currentMod != null)
        {
            var props = _raceService.GetGameUsedProperties();
            approvalModView.ShowAddApprovalModifierDialog(
                props.ApprovalTypes,
                props.BonusTypes, 
                props.ApprovalTags,
                currentMod, 
                stat =>
            {
                CurrentRace.ApprovalModifiers.Remove(currentMod);
                CurrentRace.ApprovalModifiers.Add(stat);
                UpdateUi();
            });
        }
    }

    private void OnColonyStatsDoubleClicked(object? sender, DataArg<string> e)
    {
        var colonyStatsView = _serviceProvider.GetRequiredService<IColonyStatView>();
        var currentStat = CurrentRace.ColonyStats.FirstOrDefault(cs => cs.EffectType.Equals(e.Value));
        if (currentStat != null)
        {
            var props = _raceService.GetGameUsedProperties();
            colonyStatsView.ShowAddColonyStatDialog(
                props.TargetTypes, 
                props.BonusTypes,
                props.EffectTypes, currentStat,
                stat =>
                {
                    CurrentRace.ColonyStats.Remove(currentStat);
                    CurrentRace.ColonyStats.Add(stat);
                    UpdateUi();
                });
        }
    }

    private void OnGlobalStatsDoubleClicked(object? sender, DataArg<string> e)
    {
        var globalStatsView = _serviceProvider.GetRequiredService<IGlobalStatView>();
        var currentStat = CurrentRace.GlobalStats.FirstOrDefault(gs => gs.EffectType.Equals(e.Value));
        if (currentStat != null)
        {
            var props = _raceService.GetGameUsedProperties();
            globalStatsView.ShowAddGlobalStatDialog(
                props.TargetTypes, 
                props.BonusTypes, 
                props.EffectTypes, currentStat, stat =>
            {
                CurrentRace.GlobalStats.Remove(currentStat);
                CurrentRace.GlobalStats.Add(stat);
                UpdateUi();
            });
        }
    }

    private void OnHasGenderCheckChanged(object? sender, DataArg<bool> e)
    {
        CurrentRace.HasGender = e.Value;
    }

    private void OnIsMinorRaceCheckChanged(object? sender, DataArg<bool> e)
    {
        CurrentRace.IsMinorRace = e.Value;
    }

    private void OnNaturalLeagueChanceTextChanged(object? sender, DataArg<double?> e)
    {
        CurrentRace.NaturalLeagueChance = e.Value != null ? e.Value.Value.ToString() : "";
    }

    private void OnWarforgedChanceTextChanged(object? sender, DataArg<double?> e)
    {
        CurrentRace.WarforgedChance = e.Value != null ? e.Value.Value.ToString() : "";
    }

    private void OnPacifistChanceTextChanged(object? sender, DataArg<double?> e)
    {
        CurrentRace.PacifistChance = e.Value != null ? e.Value.Value.ToString() : "";
    }

    private void OnIdeologyChanceTextChanged(object? sender, DataArg<double?> e)
    {
        CurrentRace.IdeologyChance = e.Value != null ? e.Value.Value.ToString() : "";
    }

    private void OnEmporiumChanceTextChanged(object? sender, DataArg<double?> e)
    {
        CurrentRace.EmporiumChance = e.Value != null ? e.Value.Value.ToString() : "";
    }

    private void OnProtestingApprovalThresholdTextChanged(object? sender, DataArg<double?> e)
    {
        CurrentRace.ProtestingApprovalThreshold = e.Value != null ? e.Value.Value.ToString() : "";
    }

    private void OnCriminalChanceTextChanged(object? sender, DataArg<double?> e)
    {
        CurrentRace.CriminalChance = e.Value != null ? e.Value.Value.ToString() : "";
    }

    private void OnDescriptionTextChanged(object? sender, DataArg<string> e)
    {
        CurrentRace.Description_Desired = e.Value ?? "";
    }

    private void OnNameTextChanged(object? sender, DataArg<string> e)
    {
        CurrentRace.Name_Desired = e.Value ?? "";
        CurrentRace.Name_Parsed = CurrentRace.Name_Desired.Replace(" ", "_");
    }

    private void OnSaveRaceClicked(object? sender, EventArgs e)
    {
        // Early out
        if (ModFolderPath == null || !Directory.Exists(ModFolderPath))
        {
            _dialogView.Show_Ok("You need to provide a mod folder path before saving.", "Error saving");
            return;
        }

        var saveObject = new IRaceService.SaveRaceObject
        {
            IsReplaceMod = _view.IsReplaceMod,
            gamePlayFolderPath = GamePlayFolderPath,
            modFolderPath = ModFolderPath,
            race = CurrentRace,
            raceList = RaceList,
            citizenPortraitPaths = CitizenPortraitList
        };
        _raceService.SaveRace(saveObject);
        _dialogView.Show_Ok("Your race has been saved!", "Saved");
        UpdateUi();
    }

    private void OnRemoveApprovalModifiersClicked(object? sender, EventArgs e)
    {
        var selectedMod = _view.ApprovalModifierSelected;
        if (selectedMod == null) return;

        var item = CurrentRace.ApprovalModifiers.FirstOrDefault(am => am.Type.Equals(selectedMod));
        if (item != null)
        {
            CurrentRace.ApprovalModifiers.Remove(item);
            UpdateUi();    
        }
    }

    private void OnAddApprovalModifiersClicked(object? sender, EventArgs e)
    {
        var approvalModifierView = _serviceProvider.GetRequiredService<IApprovalModifierView>();
        var props = _raceService.GetGameUsedProperties();
        approvalModifierView.ShowAddApprovalModifierDialog(
            props.ApprovalTypes, 
            props.BonusTypes,
            props.ApprovalTags,
            mod =>
        {
            CurrentRace.ApprovalModifiers.Add(mod);
            UpdateUi();
        });
    }

    private void OnRemoveColonyStatClicked(object? sender, EventArgs e)
    {
        var selectedStat = _view.ColonyStatSelected;
        if (string.IsNullOrWhiteSpace(selectedStat))
        {
            return;
        }

        var item = CurrentRace.ColonyStats.FirstOrDefault(stat => stat.EffectType.Equals(selectedStat));
        if (item != null)
        {
            CurrentRace.ColonyStats.Remove(item);
            UpdateUi();            
        }
    }

    private void OnAddColonyStatClicked(object? sender, EventArgs e)
    {
        var colonyStatsView = _serviceProvider.GetRequiredService<IColonyStatView>();
        var props = _raceService.GetGameUsedProperties();
        colonyStatsView.ShowAddColonyStatDialog(
            props.TargetTypes, 
            props.BonusTypes, 
            props.EffectTypes, stat =>
        {
            CurrentRace.ColonyStats.Add(stat);
            UpdateUi();
        });
    }

    private void OnRemoveGlobalStatClicked(object? sender, EventArgs e)
    {
        var selected = _view.GlobalStatSelected;
        if (string.IsNullOrWhiteSpace(selected))
        {
            return;
        }

        var item = CurrentRace.GlobalStats.FirstOrDefault(gs => gs.EffectType.Equals(selected));

        if (item != null)
        {
            CurrentRace.GlobalStats.Remove(item);
            UpdateUi();
        }
    }

    private void OnAddGlobalStatClicked(object? sender, EventArgs e)
    {
        var globalStatsView = _serviceProvider.GetRequiredService<IGlobalStatView>();
        var props = _raceService.GetGameUsedProperties();
        globalStatsView.ShowAddGlobalStatDialog(
            props.TargetTypes, 
            props.BonusTypes, 
            props.EffectTypes, stat =>
        {
            CurrentRace.GlobalStats.Add(stat);
            UpdateUi();
        });
    }

    private void OnPoliticalAdvisorPortraitClicked(object? sender, EventArgs e)
    {
        var requestDialog = _serviceProvider.GetRequiredService<IRequestImageFileView>();
        var politicalAdvisorPortraitFileRequest = requestDialog.RequestImageFile();
        if (politicalAdvisorPortraitFileRequest.Canceled)
        {
            return;
        }

        CurrentRace.PoliticalAdvisorPortraitFullPath = politicalAdvisorPortraitFileRequest.Path;
        CurrentRace.PoliticalAdvisorPortrait = Path.GetFileName(CurrentRace.PoliticalAdvisorPortraitFullPath);
        var moddedPath = CheckImageSize(CurrentRace.PoliticalAdvisorPortraitFullPath);
        if (moddedPath != null)
        {
            CurrentRace.PoliticalAdvisorPortraitFullPath= moddedPath;
            CurrentRace.PoliticalAdvisorPortrait = Path.GetFileName(moddedPath);
        }
        UpdateUi();
    }

    private void OnColonizationAdvisorPortraitClicked(object? sender, EventArgs e)
    {
        var requestDialog = _serviceProvider.GetRequiredService<IRequestImageFileView>();
        var colonizationAdvisorPortraitFileRequest = requestDialog.RequestImageFile();
        if (colonizationAdvisorPortraitFileRequest.Canceled)
        {
            return;
        }

        CurrentRace.ColonizationAdvisorPortraitFullPath = colonizationAdvisorPortraitFileRequest.Path;
        CurrentRace.ColonizationAdvisorPortrait = Path.GetFileName(CurrentRace.ColonizationAdvisorPortraitFullPath);
        var moddedPath = CheckImageSize(CurrentRace.ColonizationAdvisorPortraitFullPath);
        if (moddedPath != null)
        {
            CurrentRace.ColonizationAdvisorPortraitFullPath = moddedPath;
            CurrentRace.ColonizationAdvisorPortrait = Path.GetFileName(moddedPath);
        }
        UpdateUi();
    }

    private void OnScienceAdvisorPortraitClicked(object? sender, EventArgs e)
    {
        var requestDialog = _serviceProvider.GetRequiredService<IRequestImageFileView>();
        var scienceAdvisorPortraitFileRequest = requestDialog.RequestImageFile();
        if (scienceAdvisorPortraitFileRequest.Canceled)
        {
            return;
        }

        CurrentRace.ScienceAdvisorPortraitFullPath = scienceAdvisorPortraitFileRequest.Path;
        CurrentRace.ScienceAdvisorPortrait = Path.GetFileName(CurrentRace.ScienceAdvisorPortraitFullPath);
        var moddedPath = CheckImageSize(CurrentRace.ScienceAdvisorPortraitFullPath);
        if (moddedPath != null)
        {
            CurrentRace.ScienceAdvisorPortraitFullPath = moddedPath;
            CurrentRace.ScienceAdvisorPortrait = Path.GetFileName(moddedPath);
        }
        UpdateUi();
    }

    private void OnMilitaryAdvisorPortraitClicked(object? sender, EventArgs e)
    {
        var requestDialog = _serviceProvider.GetRequiredService<IRequestImageFileView>();
        var militaryAdvisorPortraitFileRequest = requestDialog.RequestImageFile();
        if (militaryAdvisorPortraitFileRequest.Canceled)
        {
            return;
        }

        CurrentRace.MilitaryAdvisorPortraitFullPath = militaryAdvisorPortraitFileRequest.Path;
        CurrentRace.MilitaryAdvisorPortrait = Path.GetFileName(CurrentRace.MilitaryAdvisorPortraitFullPath);
        var moddedPath = CheckImageSize(CurrentRace.MilitaryAdvisorPortraitFullPath);
        if (moddedPath != null)
        {
            CurrentRace.MilitaryAdvisorPortraitFullPath = moddedPath;
            CurrentRace.MilitaryAdvisorPortrait = Path.GetFileName(moddedPath);
        }
        UpdateUi();
    }

    private void OnGenericImagePortraitClicked(object? sender, EventArgs e)
    {
        var requestDialog = _serviceProvider.GetRequiredService<IRequestImageFileView>();
        var genericImageFileRequest = requestDialog.RequestImageFile();
        if (genericImageFileRequest.Canceled)
        {
            return;
        }

        CurrentRace.GenericImageFullPath = genericImageFileRequest.Path;
        CurrentRace.GenericImage = Path.GetFileName(CurrentRace.GenericImageFullPath);

        var moddedPath = CheckImageSize(CurrentRace.GenericImageFullPath);
        if (moddedPath != null)
        {
            CurrentRace.GenericImageFullPath = moddedPath;
            CurrentRace.GenericImage = Path.GetFileName(moddedPath);
        }
        UpdateUi();       
    }

    private string? CheckImageSize(string imgPath)
    {
        var imageStats = _imageService.GetImageStats(imgPath);
        if (imageStats.Height != 128 && imageStats.Height != 256 ||
            imageStats.Width != 128 && imageStats.Width != 256)
        {
            var dialogResult = _dialogView.Show_YesNo(
                "Looks like the selected image isn't 128x128, or 256x256. Do you want to automatically resize the image?",
                "Image size mis-match");
            if (dialogResult == DialogResult.Yes)
            {
                var path = Path.GetTempPath() + CurrentRace.GenericImage;
                _imageService.ResizeImage(imgPath, path, 256, 256);
                return path;
            }
        }
        return null;
    }

    private void UpdateUi()
    {
        _view.UpdateUi(RaceList.BasePath, CurrentRace);
    }

    private void OnRaceDropDownSelected(object? sender, DataArg<string> e)
    {
        var selectedRace = RaceList.CitizenRaces.FirstOrDefault(race => race.Name_Parsed.Equals(e.Value));
        if (selectedRace == null)
            return;

        CurrentRace = selectedRace.DeepCopy();
        CitizenPortraitList.Clear();
        PopulateCitizenPortraitPaths();
        UpdateUi();
    }

    private void LoadRaceDefs()
    {
        var raceList = _raceService.LoadGameRaceList(GamePlayFolderPath);

        if (raceList == null)
        {
            _dialogView.Show_Ok(
                "Unable to load game races. Please make sure you have specified the game install directory",
                "Unable to load races");
            return;
        }

        RaceList = raceList;
        var props = _raceService.GetGameUsedProperties();
        _view.SetConsumedTraits(props.ConsumedTraits);
        _view.SetDefaultTraits(props.DefaultTraits);
        _view.SetBaseRaces(RaceList.CitizenRaces.Select(race => race.Name_Parsed));
    }


    public void Show()
    {
        _view.Show();
    }
    
}