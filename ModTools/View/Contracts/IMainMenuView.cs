namespace ModTools.View.Contracts;

public interface IMainMenuView : IView
{
    event EventHandler RaceButtonClicked;
    event EventHandler StarSystemButtonClicked;
    event EventHandler SettingsButtonClicked;
    event EventHandler EventButtonClicked;
    event EventHandler FeedbackButtonClicked;
    event EventHandler Activated;
    

    void SetRaceEditorEnabled(bool enabled);
    void SetStarSystemEditorEnabled(bool enabled);
    void SetEventEditorEnabled(bool enabled);
    void SetBackgroundImage(Image image);
    void SetGC4LogoImage(Image image);
    void Invoke(Action action);
    IAsyncResult BeginInvoke(Action action);
    Form Form();
}