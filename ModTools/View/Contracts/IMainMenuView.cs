namespace ModTools.View.Contracts;

public interface IMainMenuView : IView
{
    event EventHandler RaceButtonClicked;
    event EventHandler StarSystemButtonClicked;
    event EventHandler SettingsButtonClicked;
    event EventHandler EventButtonClicked;
    event EventHandler Activated;
    

    void SetRaceEditorEnabled(bool enabled);
    void SetStarSystemEditorEnabled(bool enabled);
    void SetEventEditorEnabled(bool enabled);
    void Invoke(Action action);
    Form Form();
}