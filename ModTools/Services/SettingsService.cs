using Hanssens.Net;
using ModTools.Services.Contracts;

namespace ModTools.Services;

public class SettingsService : ISettingsService
{
    private const string KEY_GAME_INSTALL_PATH = "GameInstallPath";
    private const string KEY_MOD_FOLDER_PATH = "ModFolderPath";
    
    private readonly LocalStorage _localStorage;
    private string? _gameInstallPath;
    private string? _modFolderPath;

    public SettingsService(LocalStorage localStorage)
    {
        _localStorage = localStorage;        
    }
    
    public string? GetGameInstallPath()
    {
        if (_localStorage.Exists(KEY_GAME_INSTALL_PATH))
        {
            _gameInstallPath = _localStorage.Get(KEY_GAME_INSTALL_PATH)?.ToString();
        }

        return _gameInstallPath;
    }

    public void SetGameInstallPath(string? installPath)
    {
        _gameInstallPath = installPath;
        _localStorage.Store(KEY_GAME_INSTALL_PATH, _gameInstallPath);
        _localStorage.Persist();
    }

    public string? GetModFolderPath()
    {
        if (_localStorage.Exists(KEY_MOD_FOLDER_PATH))
        {
            _modFolderPath = _localStorage.Get(KEY_MOD_FOLDER_PATH)?.ToString();
        }

        return _modFolderPath;
    }

    public void SetModFolderPath(string? modFolderPath)
    {
        _modFolderPath = modFolderPath;
        _localStorage.Store(KEY_MOD_FOLDER_PATH, _modFolderPath);
        _localStorage.Persist();
    }
}