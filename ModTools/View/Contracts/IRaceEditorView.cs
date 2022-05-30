using ModTools.Event;
using ModTools.Model.Race;

namespace ModTools.View.Contracts;

public interface IRaceEditorView : IView
{
    string ProtestingApprovalValue { get; }
    string IdeologyChanceValue { get; }
    string CriminalChanceValue { get; }
    string EmporiumChanceValue { get; }
    string NaturalLeagueChanceValue { get; }
    string PacifistChanceValue { get; }
    string WarforgedChanceValue { get; }
    string EnteredName { get; }
    string EnteredDescription { get; }
    bool IsMinorRaceChecked { get; }
    bool IsHasGenderChecked { get; }
    bool IsReplaceMod { get; }
    string GlobalStatSelected { get; }
    string ColonyStatSelected { get; }
    string ApprovalModifierSelected { get; }
    string? ConsumedTraitSelected { get; }
    string? DefaultTraitsSelected { get; }
    bool IsDisposed { get; }
    event EventHandler SaveRaceClicked;
    event EventHandler AddApprovalModifiersClicked;
    event EventHandler RemoveApprovalModifiersClicked;
    event EventHandler AddColonyStatClicked;
    event EventHandler RemoveColonyStatClicked;
    event EventHandler AddGlobalStatClicked;
    event EventHandler RemoveGlobalStatClicked;
    event EventHandler PoliticalAdvisorPortraitClicked;
    event EventHandler ColonizationAdvisorPortraitClicked;
    event EventHandler ScienceAdvisorPortraitClicked;
    event EventHandler MilitaryAdvisorPortraitClicked;
    event EventHandler GenericImagePortraitClicked;
    event EventHandler ManagePortraitsButtonClicked;
    event EventHandler<DataArg<string>> GlobalStatsDoubleClicked;
    event EventHandler<DataArg<string>> ColonyStatsDoubleClicked;
    event EventHandler<DataArg<string>> ApprovalModifiersDoubleClicked;
    event EventHandler<DataArg<string>> RaceDropDownSelected;
    event EventHandler<DataArg<string>> DefaultTraitSelected;
    event EventHandler<DataArg<string>> ConsumedTraitComboSelected;
    event EventHandler<DataArg<string>> NameTextChanged;
    event EventHandler<DataArg<string>> DescriptionTextChanged;
    event EventHandler<DataArg<bool>> IsMinorRaceCheckChanged;
    event EventHandler<DataArg<bool>> HasGenderCheckChanged;
    event EventHandler<DataArg<double?>> ProtestingApprovalThresholdTextChanged;
    event EventHandler<DataArg<double?>> IdeologyChanceTextChanged;
    event EventHandler<DataArg<double?>> CriminalChanceTextChanged;
    event EventHandler<DataArg<double?>> EmporiumChanceTextChanged;
    event EventHandler<DataArg<double?>> NaturalLeagueChanceTextChanged;
    event EventHandler<DataArg<double?>> PacifistChanceTextChanged;
    event EventHandler<DataArg<double?>> WarforgedChanceTextChanged;


    void SetDefaultTraits(IEnumerable<string>? defaultTraits);
    void SetDefaultTrait(string trait);
    void SetConsumedTraits(IEnumerable<string>? consumedTraits);
    void SetConsumedTrait(string trait);
    void SetBaseRaces(IEnumerable<string> races);
    void UpdateUi(string basePath, CitizenRace race);
    
}