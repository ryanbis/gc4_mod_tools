namespace ModTools.View.Contracts;

public interface ISettingsView : IView
{
    void SetGameInstallPath(string path);
    void SetModFolderPath(string path);
    event EventHandler SetGameInstallPathClicked;
    event EventHandler SetModFolderPathClicked;
}