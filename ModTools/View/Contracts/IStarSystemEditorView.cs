using ModTools.Event;

namespace ModTools.View.Contracts;

public interface IStarSystemEditorView : IView
{
    event EventHandler<DataArg<string>> StarSystemTypeSelected;
    event EventHandler<DataArg<string>> StarSelected;
    event EventHandler<DataArg<string>> StarNameChanged;
    event EventHandler<DataArg<string>> StarSystemNameChanged;
    event EventHandler<DataArg<string>> StarSystemDescriptionChanged;
    event EventHandler<DataArg<string>> CurrentStarSystemItemDoubleClicked;
    event EventHandler<DataArg<int?>> PositionTextChanged;
    event EventHandler<DataArg<string>> PlanetNameChanged;
    event EventHandler<DataArg<int?>> PlanetClassChanged;
    event EventHandler<DataArg<int?>> PlanetMineralsChanged;
    event EventHandler<DataArg<int?>> PlanetTechnologyChanged;
    event EventHandler<DataArg<int?>> PlanetWealthChanged;
    event EventHandler<DataArg<int?>> PlanetFertilityChanged;
    event EventHandler<DataArg<int?>> PlanetInfluenceChanged;
    event EventHandler AddOrbitLaneClicked;
    event EventHandler AddLaneBodyClicked;
    event EventHandler AddCurrentSystemClicked;
    event EventHandler SaveAllClicked;
    event EventHandler<DataArg<int>> RemoveOrbitLaneClicked;
    event EventHandler<DataArg<int>> RemoveLaneBodyClicked;
    event EventHandler<DataArg<string[]>> RemoveStarSystemClicked;
    public event EventHandler<DataArg<int?>>? OrbitLaneIndexSelected;
    public event EventHandler<DataArg<int?>>? LaneBodyIndexSelected;
    public event EventHandler<DataArg<int?>>? PlanetTraitIndexSelected;
    public event EventHandler<DataArg<int?>>? PlanetTypeIndexSelected;
    public event EventHandler<DataArg<int?>>? TabIndexSelected;
    public event EventHandler<DataArg<int?>>? ModTypeSelected;
    public event EventHandler<DataArg<int?>>? SystemToCopyIndexSelected;

    string? GetSelectedStar();
    void SetModType(string modType);
    void AllowPlanetClassDistributionEdits(bool allow);
    void SetStarSystemName(string name);
    void SetStarSystemDescription(string description);
    void SetSystemsToCopyItems(string[] systems);
    void SetStarSystemTypes(object[] systemTypes, int? defaultSelected = null);
    void SetCurrentStarSystems(string[] starSystems);
    void SetOrbitLanes(string[] orbitLanes, int? defaultSelected = null);
    void SetLaneBodies(string[] laneBodies, int? defaultSelected = null);
    void EnableLaneButtons(bool enable);
    void SetPlanetTypes(string[] planetTypes, int? defaultSelected = null);
    void SetPlanetTraits(string[] planetTraits);
    void SetStarTypes(string[] stars);
    void SetSelectedStar(string star);
    void SetPlanetName(string name);
    void SetStarName(string name);
    void SetPlanetClass(int planetClass);
    void SetPlanetType(string planetType);
    void SetPlanetTrait(string planetTrait);
    void SetPlanetMinerals(string minerals);
    void SetPlanetTechnology(string tech);
    void SetPlanetWealth(string wealth);
    void SetPlanetFertility(string fertility);
    void SetPlanetInflunce(string influence);
    void SetBodyLabelText(string text);
    void SetPosition(string? position);
    void ShowDescription(bool show);
    void ShowLaneBodies(bool show);
    void ShowBody(bool show);
    void ShowStarTable(bool show);
    void ShowPlanetTable(bool show);
    void ShowPositionTable(bool show);
    void ShowWeight(bool show);
    bool IsReplaceMod { get; }
}