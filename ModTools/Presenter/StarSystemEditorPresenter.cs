using Hanssens.Net;
using Microsoft.Extensions.DependencyInjection;
using ModTools.Event;
using ModTools.Model.Space;
using ModTools.Presenter.Contracts;
using ModTools.Services.Contracts;
using ModTools.View.Contracts;

namespace ModTools.Presenter;

public class StarSystemEditorPresenter : IStarSystemEditorPresenter
{
    private readonly IStarSystemEditorView _view;
    public IStarSystemEditorView View => _view;

    private readonly ISpaceService _spaceService;
    private readonly IServiceProvider _serviceProvider;
    private readonly ISettingsService _settingsService;
    private readonly LocalStorage _storage;
    private readonly IGenericDialogView _dialogView;


    private string? ModFolderPath { get; set; }
    private string? GamePlayFolderPath { get; set; }
    private string? GameInstallFolderPath { get; set; }

    private IEnumerable<Star> _inGameStars = new List<Star>();
    private IList<StarSystem> _inGameStarSystems = new List<StarSystem>();

    private ISpaceService.StarsAndPlanets _starsAndPlanets;
    private List<StarSystem> _allStarSystems;
    private ISpaceService.AnalyzeResult _analyzeResult;

    private readonly StarSystemList _currentStarSystemList = new() {StarSystemGroups = new List<StarSystemGroup>()};
    private StarSystemGroup _currentStarSystemGroup = new() {StarSystems = new List<StarSystem>()};
    private readonly PlanetList _currentPlanetList = new() {Planets = new List<Planet>()};
    private readonly StarList _currentStarList = new() {Stars = new List<Star>()};
    private StarSystem _currentStarSystem = new();
    private OrbitLane _currentOrbitLane;
    private OrbitBody _currentOrbitBody = new();
    private Planet _currentPlanet = new();
    private Star _currentStar = new();


    public StarSystemEditorPresenter(IStarSystemEditorView view, ISpaceService spaceService,
        ISettingsService settingsService, IServiceProvider serviceProvider, IGenericDialogView dialogView,
        LocalStorage storage)
    {
        _view = view;
        _spaceService = spaceService;
        _settingsService = settingsService;
        _serviceProvider = serviceProvider;
        _dialogView = dialogView;
        _storage = storage;
    }


    public void Init()
    {
        var gameInstallFolderPath = _settingsService.GetGameInstallPath();
        if (!string.IsNullOrWhiteSpace(gameInstallFolderPath))
        {
            GameInstallFolderPath = gameInstallFolderPath;
            GamePlayFolderPath = $"{gameInstallFolderPath}{Constants.GAMEPLAY_PATH}";
        }

        if (_storage.Exists("ModFolderPath"))
        {
            ModFolderPath = _storage.Get("ModFolderPath").ToString();
        }

        if (GamePlayFolderPath != null)
        {
            LoadStarSystemAndPlanetDefs();
        }

        _currentStarSystemGroup.InternalName = Constants.Space.FACTION_START_STAR_SYSTEMS;
        _view.StarSystemTypeSelected += OnStarSystemTypeSelected;
        // _view.StarSelected += OnStarSelected;
        _view.AddLaneBodyClicked += OnAddLaneBodyClicked;
        _view.AddOrbitLaneClicked += OnAddOrbitLaneClicked;
        _view.RemoveLaneBodyClicked += OnRemoveLaneBodyClicked;
        _view.RemoveOrbitLaneClicked += OnRemoveOrbitLaneClicked;
        _view.RemoveStarSystemClicked += OnRemoveStarSystemClicked;
        _view.OrbitLaneIndexSelected += OnOrbitLaneIndexSelected;
        _view.LaneBodyIndexSelected += OnLaneBodyIndexSelected;
        _view.PlanetClassChanged += OnPlanetClassChanged;
        _view.PlanetNameChanged += OnPlanetNameChanged;
        _view.PositionTextChanged += OnPositionTextChanged;
        _view.PlanetTraitIndexSelected += OnPlanetTraitIndexSelected;
        _view.PlanetTypeIndexSelected += OnPlanetTypeIndexSelected;
        _view.StarNameChanged += OnStarNameChanged;
        _view.AddCurrentSystemClicked += OnAddCurrentSystemClicked;
        _view.SaveAllClicked += OnSaveAllClicked;
        _view.TabIndexSelected += OnTabIndexSelected;
        _view.StarSystemNameChanged += OnStarSystemNameChanged;
        _view.StarSystemDescriptionChanged += OnStarSystemDescriptionChanged;
        _view.PlanetMineralsChanged += OnPlanetMineralsChanged;
        _view.PlanetTechnologyChanged += OnPlanetTechnologyChanged;
        _view.PlanetWealthChanged += OnPlanetWealthChanged;
        _view.PlanetFertilityChanged += OnPlanetFertilityChanged;
        _view.PlanetInfluenceChanged += OnPlanetInfluenceChanged;
        _view.ModTypeSelected += OnModTypeSelected;
        _view.SystemToCopyIndexSelected += OnSystemToCopyIndexSelected;
        _view.CurrentStarSystemItemDoubleClicked += OnCurrentStarSystemItemDoubleClicked;
        UpdateInGameStarSystems();
        _inGameStars = _starsAndPlanets.StarList.Stars.Where(star => !string.IsNullOrWhiteSpace(star.DisplayName));
        _view.SetStarTypes(_inGameStars.Select(star => star.Name_Parsed).ToArray<string>());
        _view.SetStarSystemTypes(Constants.Space.STAR_SYSTEM_GROUP_TYPES.Keys.ToArray<object>(), 0);
        _view.SetPlanetTraits(_analyzeResult.PlanetTraits.ToArray());
        _view.SetPlanetTypes(_analyzeResult.PlanetTypes.ToArray());
        _view.SetModType("Replace");
    }

    private void OnCurrentStarSystemItemDoubleClicked(object? sender, DataArg<string> e)
    {
        // TODO - Fill in current objects with the selected from the current list
        _currentStarSystem = _allStarSystems.FirstOrDefault(ss => ss.InternalName.Equals(e.Value));
        _currentOrbitLane = null;
        _currentOrbitBody = null;
        _currentPlanet = null;
        _currentStar = null;
        UpdateStarSystems();
        UpdateUi();
    }

    private void UpdateInGameStarSystems()
    {
        _inGameStarSystems = _starsAndPlanets.StarSystemList.StarSystemGroups.Where(ssg => ssg.InternalName.Equals(_currentStarSystemGroup.InternalName)).SelectMany(ssg =>
        {
            return ssg.StarSystems.Select(ss => ss).ToList();
        }).ToList();
        _view.SetSystemsToCopyItems(_inGameStarSystems.Select(ss => ss.InternalName).ToArray());
    }

    private void OnSystemToCopyIndexSelected(object? sender, DataArg<int?> e)
    {
        if (e.Value != null)
        {
            _currentStarSystem.OrbitLanes.Clear();
            var system = _inGameStarSystems[e.Value.Value];
            _currentStarSystem.Description_Desired = system.Description_Desired;
            _currentStarSystem.Weight = system.Weight;
            _currentStarSystem.Name_Parsed = system.Name_Parsed;
            _currentStarSystem.Name_Desired = _currentStarSystem.Name_Parsed;
            _currentStarSystem.OrbitLanes = new List<OrbitLane>(system.OrbitLanes);
            _currentOrbitLane = _currentStarSystem.OrbitLanes[0];
            _currentOrbitBody = _currentOrbitLane.Bodies[0];
            UpdateUi();
        }
    }

    private void OnModTypeSelected(object? sender, DataArg<int?> e)
    {
        if (e.Value is 0)
        {
            _dialogView.Show_Ok(
                "The append MOD type doesn't seem to work with star systems. It is advised to always use the Replace method for star systems. ",
                "Invalid Mod type");
        } else if (e.Value is 1)
        {
            _currentStarSystemList.StarSystemGroups.Clear();
            _currentStarSystemList.StarSystemGroups.AddRange(_starsAndPlanets.StarSystemList.StarSystemGroups);
            _currentPlanet = null;
            _currentStar = null;
            _currentOrbitBody = null;
            _currentOrbitLane = null;
            UpdateStarSystems();
            UpdateUi();
        }
    }

    private void OnPlanetInfluenceChanged(object? sender, DataArg<int?> e)
    {
        if (e.Value != null)
        {
            _currentPlanet.PlanetClassDistribution.PlanetInfluence = e.Value.Value.ToString();
        }
    }

    private void OnPlanetFertilityChanged(object? sender, DataArg<int?> e)
    {
        if (e.Value != null)
        {
            _currentPlanet.PlanetClassDistribution.Fertility = e.Value.Value.ToString();
        }
    }

    private void OnPlanetWealthChanged(object? sender, DataArg<int?> e)
    {
        if (e.Value != null)
        {
            _currentPlanet.PlanetClassDistribution.Wealth = e.Value.Value.ToString();
        }
    }

    private void OnPlanetTechnologyChanged(object? sender, DataArg<int?> e)
    {
        if (e.Value != null)
        {
            _currentPlanet.PlanetClassDistribution.Technology = e.Value.Value.ToString();
        }
    }

    private void OnPlanetMineralsChanged(object? sender, DataArg<int?> e)
    {
        if (e.Value != null)
        {
            _currentPlanet.PlanetClassDistribution.Minerals = e.Value.Value.ToString();
        }
    }

    private void OnStarSystemDescriptionChanged(object? sender, DataArg<string> e)
    {
        if (string.IsNullOrWhiteSpace(e.Value)) return;

        _currentStarSystem.Description_Desired = e.Value;
        _currentStarSystem.Description = $"{_currentStarSystem.InternalName}{Constants.DESCRIPTION_SUFFIX}";
    }

    private void OnStarSystemNameChanged(object? sender, DataArg<string> e)
    {
        if (string.IsNullOrWhiteSpace(e.Value)) return;

        _currentStarSystem.Name_Desired = e.Value;
        _currentStarSystem.Name_Parsed = e.Value.Replace(" ", "_");
        _currentStarSystem.InternalName = $"{_currentStarSystem.Name_Parsed}{Constants.Space.STAR_SYSTEM_SUFFIX}";
        var label = $"{_currentStarSystem.InternalName}{Constants.DISPLAYNAME_SUFFIX}";
        _currentStarSystem.DisplayName = label;
        if (_currentStarSystem.Description == null && !string.IsNullOrWhiteSpace(_currentStarSystem.Description_Desired))
        {
            _currentStarSystem.Description = $"{_currentStarSystem.InternalName}{Constants.DESCRIPTION_SUFFIX}";
        }
    }

    private void OnTabIndexSelected(object? sender, DataArg<int?> e)
    {
        if (e.Value != null && e.Value == 1 && _currentOrbitLane == null)
        {
            OrbitLane lane = null;
            if (_currentStarSystem.OrbitLanes.Count == 0)
            {
                lane = new OrbitLane {LaneType = OrbitLaneType.Star.ToString()};
                OnOrbitLaneSaved(lane);
            }
            else
            {
                lane = _currentStarSystem.OrbitLanes.FirstOrDefault(ol => ol.LaneType.Equals(OrbitLaneType.Star.ToString()));
                _currentOrbitLane = lane;
                UpdateUi();
            }
        }
    }

    private void OnSaveAllClicked(object? sender, EventArgs e)
    {
        if (ModFolderPath == null || !Directory.Exists(ModFolderPath))
        {
            _dialogView.Show_Ok("Please select the MOD folder you would like to save to",
                "MOD Folder needed");
            var requestDialog = _serviceProvider.GetRequiredService<IRequestFolderView>();
            var selectFolderRequest = requestDialog.RequestFolder(ModFolderPath);
            if (selectFolderRequest.Canceled)
            {
                return;
            }

            ModFolderPath = selectFolderRequest.Path;
            _storage.Store("ModFolderPath", ModFolderPath);
        }
        var saveObject = new ISpaceService.SaveObject
        {
            planetList = _currentPlanetList,
            starList = _currentStarList,
            gameplayFolderPath = GamePlayFolderPath,
            modFolderPath = ModFolderPath,
            starSystemList = _currentStarSystemList,
            IsReplaceMod = _view.IsReplaceMod
        };
        _spaceService.SaveStarSystemList(saveObject);
        _dialogView.Show_Ok("Your star system(s) have been saved!", "System(s) saved");
    }

    private void OnAddCurrentSystemClicked(object? sender, EventArgs e)
    {
        if (_currentStarSystem == null) return;

        if (string.IsNullOrWhiteSpace(_currentStarSystem.Name_Desired))
        {
            _dialogView.Show_Ok("Please enter a name for your new star system.", "Need a name!");
            return;
        }

        // TODO - Verify stars and star names
        //if (string.IsNullOrWhiteSpace(_currentStar.Name_Desired))
        //{
        //    _dialogView.Show_Ok("Please enter a name for your new star.", "Need a name!");
        //    return;
        //}
        
        //if (_view.GetSelectedStar() == null)
        //{
        //    _dialogView.Show_Ok("Please select an in game star to base your new star on.", "Select star");
        //    return;
        //}

        VerifyPlanets();

        var group = _currentStarSystemList.StarSystemGroups.FirstOrDefault(ssg =>
            ssg.InternalName.Equals(_currentStarSystemGroup.InternalName));
        if (group == null)
        {
            _currentStarSystemList.StarSystemGroups.Add(_currentStarSystemGroup);
        }

        var oldOne = group.StarSystems.FirstOrDefault(ss => ss.InternalName.Equals(_currentStarSystem.InternalName));
        if (oldOne == null)
        {
            _currentStarSystemGroup.StarSystems.Add(_currentStarSystem);
            UpdateStarSystems();
            _currentStarSystem = _currentStarSystem.Clone();
        }
    }

    private void VerifyPlanets()
    {
        var planets = _currentStarSystem.GetPlanets();
        foreach (var planet in planets)
        {
            if (string.IsNullOrWhiteSpace(_currentPlanet.PlanetClassDistribution.Minerals))
            {
                _dialogView.Show_Ok("Please enter a value for your planet's minerals.", "Need a value!");
                return;
            }

            if (string.IsNullOrWhiteSpace(_currentPlanet.PlanetClassDistribution.Technology))
            {
                _dialogView.Show_Ok("Please enter a value for your planet's technology.", "Need a value!");
                return;
            }

            if (string.IsNullOrWhiteSpace(_currentPlanet.PlanetClassDistribution.Wealth))
            {
                _dialogView.Show_Ok("Please enter a value for your planet's wealth.", "Need a value!");
                return;
            }

            if (string.IsNullOrWhiteSpace(_currentPlanet.PlanetClassDistribution.Fertility))
            {
                _dialogView.Show_Ok("Please enter a value for your planet's fertility.", "Need a value!");
                return;
            }

            if (string.IsNullOrWhiteSpace(_currentPlanet.PlanetClassDistribution.PlanetInfluence))
            {
                _dialogView.Show_Ok("Please enter a value for your planet's influence.", "Need a value!");
                return;
            }
        }
    }

    private void OnStarNameChanged(object? sender, DataArg<string> e)
    {
        if (e.Value != null)
        {
            _currentStar.Name_Desired = e.Value;
            _currentStar.Name_Parsed = e.Value.Replace(" ", "_");
            _currentStar.InternalName = $"{_currentStar.Name_Desired.Replace(" ", "")}{Constants.Space.STAR_SUFFIX}";
            _currentStar.DisplayName = $"{_currentStar.Name_Parsed}{Constants.DISPLAYNAME_SUFFIX}";
            _currentOrbitBody.BodyDef = _currentStar.InternalName;
        }
    }

    private void OnPlanetTypeIndexSelected(object? sender, DataArg<int?> e)
    {
        if (e.Value != null)
        {
            var type = _analyzeResult.PlanetTypes.ToList()[e.Value.Value];
            _currentPlanet.PlanetType = type;
            var allowEdits = _currentPlanet.PlanetType == PlanetType.Habitable.ToString();
            _view.AllowPlanetClassDistributionEdits(allowEdits);
            if (!allowEdits)
            {
                _currentPlanet.PlanetClassDistribution.Minerals = "0";
                _currentPlanet.PlanetClassDistribution.Technology = "0";
                _currentPlanet.PlanetClassDistribution.Wealth = "0";
                _currentPlanet.PlanetClassDistribution.Fertility = "0";
                _currentPlanet.PlanetClassDistribution.PlanetInfluence = "0";
                _view.SetPlanetMinerals("0");
                _view.SetPlanetTechnology("0");
                _view.SetPlanetWealth("0");
                _view.SetPlanetFertility("0");
                _view.SetPlanetInflunce("0");
            }
        }
    }

    private void OnPlanetTraitIndexSelected(object? sender, DataArg<int?> e)
    {
        if (e.Value != null && e.Value.Value >= 0)
        {
            var trait = _analyzeResult.PlanetTraits.ToList()[e.Value.Value];
            _currentPlanet.PlanetTrait = trait;
        }
    }

    private void OnPositionTextChanged(object? sender, DataArg<int?> e)
    {
        if (e.Value != null)
        {
            _currentOrbitBody.Position = e.Value.Value.ToString();
        }
    }

    private void OnPlanetNameChanged(object? sender, DataArg<string> e)
    {
        _currentPlanet.Name_Desired = e.Value;
        _currentPlanet.Name_Parsed = _currentPlanet.Name_Desired.Replace(" ", "_");
        _currentPlanet.InternalName = $"{Constants.Space.PLANET_PREFIX}{_currentPlanet.Name_Parsed}";
        var label = $"{_currentPlanet.Name_Parsed}{Constants.DISPLAYNAME_SUFFIX}";
        _currentPlanet.DisplayName = label;
        _currentOrbitBody.BodyDef = _currentPlanet.InternalName;
    }

    private void OnPlanetClassChanged(object? sender, DataArg<int?> e)
    {
        if (e.Value != null)
        {
            _currentPlanet.PlanetClass = e.Value.Value.ToString();
        }
    }

    // private void OnStarSelected(object? sender, DataArg<string> e)
    // {
    //     var star = _inGameStars.FirstOrDefault(star => star.Name_Parsed?.Equals(e.Value) ?? false);
    //     if (star != null && _currentOrbitBody != null)
    //     {
    //         _currentOrbitBody.BodyDef = star.InternalName;
    //         _currentStar.Type = star.Type;
    //         _currentStar.ArtDefine = star.ArtDefine;
    //         _currentStar.ObjectType = star.ObjectType;
    //         _currentStar.TypeDisplayName = star.TypeDisplayName;
    //         _currentStar.SFXDefine = star.SFXDefine;
    //         _currentStar.AreaEffectDisplayName = star.AreaEffectDisplayName;
    //     }
    // }

    private void OnLaneBodyIndexSelected(object? sender, DataArg<int?> e)
    {
        var nullValue = e.Value == null;
        if (!nullValue)
        {
            _currentOrbitBody = _currentOrbitLane.Bodies[e.Value.Value];
        }
        else
        {
            _currentOrbitBody = null;
        }

        if (_currentOrbitBody != null)
        {
            var bodyType = _currentOrbitBody.BodyType;
            _view.SetBodyLabelText(bodyType);
            var showStarTable = bodyType == StarSystemBodyType.UnaryStar.ToString();
            _view.ShowStarTable(showStarTable);
            if (showStarTable && !string.IsNullOrWhiteSpace(_currentOrbitBody.BodyDef))
            {
                var star = _inGameStars.FirstOrDefault(star => star.InternalName.Equals(_currentOrbitBody.BodyDef));
                if (star == null)
                {
                    star = _currentStarList.Stars.FirstOrDefault(st => st.InternalName.Equals(_currentOrbitBody.BodyDef));
                }
                else
                {
                    _view.SetSelectedStar(star.Name_Desired);                    
                }
                _currentStar = star;
                _view.SetStarName(star.Name_Desired);
            }

            var showPlanetTable = bodyType == StarSystemBodyType.Planet.ToString();
            if (showPlanetTable)
            {
                if (!string.IsNullOrWhiteSpace(_currentOrbitBody.BodyDef))
                {
                    var planet = _currentPlanetList.Planets.FirstOrDefault(p =>
                        p.InternalName.Equals(_currentOrbitBody.BodyDef));
                    if (planet == null)
                    {
                        planet = _starsAndPlanets.PlanetList.Planets.FirstOrDefault(p =>
                            p.InternalName.Equals(_currentOrbitBody.BodyDef));
                    } 
                    _currentPlanet = planet;
                    _view.SetPlanetName(planet.Name_Desired);
                    _view.SetPlanetClass(int.Parse(planet.PlanetClass));
                    _view.SetPlanetTrait(planet.PlanetTrait);
                    _view.SetPlanetType(planet.PlanetType);
                    _view.SetPlanetMinerals(planet.PlanetClassDistribution.Minerals);
                    _view.SetPlanetTechnology(planet.PlanetClassDistribution.Technology);
                    _view.SetPlanetWealth(planet.PlanetClassDistribution.Wealth);
                    _view.SetPlanetFertility(planet.PlanetClassDistribution.Fertility);
                    _view.SetPlanetInflunce(planet.PlanetClassDistribution.PlanetInfluence);                    
                }
            }

            _view.ShowPlanetTable(showPlanetTable);
            var showPosition = showPlanetTable ||
                               bodyType == StarSystemBodyType.Asteroid.ToString();
            if (showPosition && !string.IsNullOrWhiteSpace(_currentOrbitBody.Position))
            {
                _view.SetPosition(_currentOrbitBody.Position);
            } else
            {
                _view.SetPosition("");
            }

            _view.ShowPositionTable(showPosition);
        }

        _view.ShowBody(!nullValue);
    }

    private void OnOrbitLaneIndexSelected(object? sender, DataArg<int?> e)
    {
        var nullValue = e.Value == null;
        if (!nullValue)
        {
            _currentOrbitLane = _currentStarSystem.OrbitLanes[e.Value.Value];
        }
        else
        {
            _currentOrbitLane = null;
        }

        if (_currentOrbitLane != null)
        {
            _view.SetLaneBodies(_currentOrbitLane.Bodies?.Select(body => body.BodyType).ToArray());
        }

        _view.ShowLaneBodies(!nullValue);
    }

    private void OnRemoveStarSystemClicked(object? sender, DataArg<string[]> e)
    {
        if (e.Value == null) return;
        var systems = _currentStarSystemGroup.StarSystems.FindAll(ss => e.Value.Contains(ss.InternalName));
        if (systems.Count > 0)
        {
            systems.ForEach(system => _currentStarSystemGroup.StarSystems.Remove(system));
            UpdateStarSystems();
        }
    }

    private void UpdateStarSystems()
    {
        var data = _currentStarSystemList.StarSystemGroups.SelectMany(ssg =>
        {
            return ssg.StarSystems.Select(ss => ss.InternalName).ToArray();
        }).ToArray();
        _view.SetCurrentStarSystems(data);
    }

    private void OnRemoveOrbitLaneClicked(object? sender, DataArg<int> e)
    {
        _currentStarSystem.OrbitLanes.RemoveAt(e.Value);
        _view.ShowLaneBodies(false);
        _view.SetOrbitLanes(_currentStarSystem.OrbitLanes.Select(lane => lane.LaneType).ToArray());
    }

    private void OnRemoveLaneBodyClicked(object? sender, DataArg<int> e)
    {
        _currentOrbitLane.Bodies.RemoveAt(e.Value);
        _view.ShowBody(false);
        _view.SetLaneBodies(_currentOrbitLane.Bodies.Select(body => body.BodyType).ToArray());
    }

    private void OnAddOrbitLaneClicked(object? sender, EventArgs e)
    {
        var orbitLanePresenter = _serviceProvider.GetRequiredService<IOrbitLanePresenter>();
        var config = new IOrbitLanePresenter.OrbitConfig
        {
            laneTypes = _analyzeResult.LaneTypes
        };
        orbitLanePresenter.Init(config);
        orbitLanePresenter.OrbitLaneSavedEvent += OnOrbitLaneSaved;
        orbitLanePresenter.Show();
    }

    private void UpdateUi()
    {
        if (_currentOrbitLane != null)
        {
            var index = _currentStarSystem.OrbitLanes.IndexOf(_currentOrbitLane);
            _view.SetOrbitLanes(_currentStarSystem.OrbitLanes.Select(lane => lane.LaneType).ToArray(), index);
            var enableLanBtns = !_currentOrbitLane.LaneType.Equals(OrbitLaneType.Star.ToString());
            _view.EnableLaneButtons(enableLanBtns);
        }

        if (_currentOrbitBody != null)
        {
            var index = _currentOrbitLane.Bodies.IndexOf(_currentOrbitBody);
            _view.SetLaneBodies(_currentOrbitLane.Bodies.Select(body => body.BodyType).ToArray(), index);    
        }

        _view.SetStarSystemName(_currentStarSystem.Name_Desired);
        _view.SetStarSystemDescription(_currentStarSystem.Description_Desired);
    }

    private void OnOrbitLaneSaved(OrbitLane lane)
    {
        if (_currentStarSystem.OrbitLanes == null)
        {
            _currentStarSystem.OrbitLanes = new List<OrbitLane>();
        }

        _currentStarSystem.OrbitLanes.Add(lane);
        _currentOrbitLane = lane;
        var index = _currentStarSystem.OrbitLanes.IndexOf(_currentOrbitLane);
        _view.SetOrbitLanes(_currentStarSystem.OrbitLanes.Select(lane => lane.LaneType).ToArray(), index);
        var enableLanBtns = !_currentOrbitLane.LaneType.Equals(OrbitLaneType.Star.ToString());
        _view.EnableLaneButtons(enableLanBtns);
        if (!enableLanBtns)
        {
            var body = new OrbitBody
            {
                BodyType = StarSystemBodyType.UnaryStar.ToString()
            };
            OrbitBodySaved(body);
        }
    }

    private void OrbitBodySaved(OrbitBody body)
    {
        if (_currentOrbitLane.Bodies == null)
        {
            _currentOrbitLane.Bodies = new List<OrbitBody>();
        }

        _currentOrbitLane.Bodies.Add(body);
        if (body.BodyType == StarSystemBodyType.Planet.ToString())
        {
            _currentPlanet = new Planet();
            _currentPlanetList.Planets.Add(_currentPlanet);
        }

        if (body.BodyType == StarSystemBodyType.Asteroid.ToString())
        {
            body.BodyDef = Constants.Space.ASTEROID_BODY_DEF;
        }

        if (body.BodyType == StarSystemBodyType.UnaryStar.ToString())
        {
            _currentStar = new Star();
            _currentStarList.Stars.Add(_currentStar);
        }

        _currentOrbitBody = body;
        var index = _currentOrbitLane.Bodies.IndexOf(_currentOrbitBody);
        _view.SetLaneBodies(_currentOrbitLane.Bodies.Select(body => body.BodyType).ToArray(), index);
    }

    private void OnAddLaneBodyClicked(object? sender, EventArgs e)
    {
        var orbitBodyPresenter = _serviceProvider.GetRequiredService<IOrbitBodyPresenter>();
        orbitBodyPresenter.Init(Enum.GetNames(typeof(StarSystemBodyType)));
        orbitBodyPresenter.OrbitBodySaved += OrbitBodySaved;
        orbitBodyPresenter.Show();
    }

    private void OnStarSystemTypeSelected(object? sender, DataArg<string> e)
    {
        var showDescription = e.Value.Equals(Constants.Space.FACTION_START_KEY);
        var key = showDescription
            ? Constants.Space.FACTION_START_STAR_SYSTEMS
            : Constants.Space.SYSTEM_TEMPLATE_STAR_GROUP;
        _currentStarSystemGroup =
            _currentStarSystemList.StarSystemGroups.FirstOrDefault(ssg => ssg.InternalName.Equals(key));
        if (_currentStarSystemGroup == null)
        {
            _currentStarSystemGroup = new StarSystemGroup
            {
                InternalName = key,
                StarSystems = new List<StarSystem>()
            };
            _currentStarSystemList.StarSystemGroups.Add(_currentStarSystemGroup);
        }

        _view.ShowDescription(showDescription);
        _view.ShowWeight(!showDescription);
        if (!showDescription)
        {
            _currentStarSystem.Weight = null;
        }
        UpdateInGameStarSystems();
    }

    private void LoadStarSystemAndPlanetDefs()
    {
        _starsAndPlanets = _spaceService.LoadStarSystemsAndPlanets(
            GamePlayFolderPath + Constants.Space.STAR_SYSTEM_INSTALLED_FILENAME);

        _analyzeResult = _spaceService.AnalyzeStarSystemsAndPlanets(_starsAndPlanets);
        _allStarSystems = _starsAndPlanets.StarSystemList.StarSystemGroups.SelectMany(ssg => ssg.StarSystems).ToList();
    }

    public void Show()
    {
        _view.Show();
    }
}