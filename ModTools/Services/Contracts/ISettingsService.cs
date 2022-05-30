namespace ModTools.Services.Contracts;

public interface ISettingsService
{
    string? GetGameInstallPath();
    void SetGameInstallPath(string? installPath);
    string? GetModFolderPath();
    void SetModFolderPath(string? modFolderPath);

}