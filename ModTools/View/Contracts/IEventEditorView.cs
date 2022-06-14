using ModTools.Event;

namespace ModTools.View.Contracts;

public interface IEventEditorView : IView
{

    // Button clicks
    public event EventHandler AddBackgroundImageClicked;
    public event EventHandler BackgroundImageClicked;
    public event EventHandler AddChoiceClicked;
    public event EventHandler AddCurrentEventClicked;
    public event EventHandler SaveAllClicked;
    
    // Still buttons, but the remove actions specify the index of the ones to remove
    public event EventHandler<DataArg<int?>> RemoveChoiceClicked;
    public event EventHandler<DataArg<int[]?>> RemoveCurrentEventsClicked;

    
    // Combo boxes/ListViews
    public event EventHandler<DataArg<int?>> ModTypeSelected;
    public event EventHandler<DataArg<int?>> EventTypeSelected; 
    public event EventHandler<DataArg<int?>> CulturalAlignmentTypeSelected;
    public event EventHandler<DataArg<int?>> ChoiceSelected;
    
    
    // TextBoxes
    public event EventHandler<DataArg<string>> WeightTextChanged;
    public event EventHandler<DataArg<string>> EventNameTextChanged;
    public event EventHandler<DataArg<string>> WindowTitleTextChanged;
    public event EventHandler<DataArg<string>> EventDescriptionTextChanged; 
    public event EventHandler<DataArg<string?>> ChoiceDescriptionTextChanged;
    public event EventHandler<DataArg<string?>> ChoiceBonusDescriptionTextChanged;
    
    // Checkboxes
    public event EventHandler<DataArg<bool>> ShouldInterruptOtherScreensCheckedChanged;
    public event EventHandler<DataArg<bool>> ShowImmediatelyCheckedChanged;

    void SetModType(string modType);
    void SetEventType(string eventType);
    void SetWeight(string weight);
    void SetShouldInterruptOtherScreensChecked(bool isChecked);
    void SetShowImmediately(bool showImmediately);
    void SetEventName(string eventName);
    void SetWindowTitle(string windowTitle);
    void SetEventDescription(string eventDescription);
    void SetBackgroundImage(string imagePath);

    void SetCulturalAlignmentType(string type);
    void SetChoiceDescription(string description);
    void SetChoiceBonusDescription(string bonusDescription);
    void SetChoicesList(string[] choices);

    void SetEventTypes(IEnumerable<string> types);
    void SetCulturalAlignmentTypes(IEnumerable<string> types);
}