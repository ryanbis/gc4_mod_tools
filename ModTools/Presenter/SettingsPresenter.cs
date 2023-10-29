using Microsoft.Extensions.DependencyInjection;
using ModTools.Presenter.Contracts;
using ModTools.Services.Contracts;
using ModTools.View.Contracts;

namespace ModTools.Presenter;

public class SettingsPresenter : ISettingsPresenter
{
    private readonly ISettingsView _view;
    public ISettingsView View => _view;
    
    private string ModFolderPath { get; set; }
    private string GameInstallPath { get; set; }

    private readonly ISettingsService _settingsService;
    private readonly IServiceProvider _serviceProvider;

    public SettingsPresenter(ISettingsView settingsView, ISettingsService settingsService, IServiceProvider serviceProvider)
    {
        _view = settingsView;
        _settingsService = settingsService;
        _serviceProvider = serviceProvider;
    }
    
    public void Init()
    {
        GameInstallPath = _settingsService.GetGameInstallPath();
        ModFolderPath = _settingsService.GetModFolderPath();
        _view.SetGameInstallPath(GameInstallPath);
        _view.SetModFolderPath(ModFolderPath);
        _view.SetGameInstallPathClicked += OnSetGameInstallPathClicked;
        _view.SetModFolderPathClicked += OnSetModFolderPathClicked;
    }

    private void OnSetModFolderPathClicked(object? sender, EventArgs e)
    {
        var requestDialog = _serviceProvider.GetRequiredService<IRequestFolderView>();
        var selectFolderRequest = requestDialog.RequestFolder(ModFolderPath);
        if (selectFolderRequest.Canceled)
        {
            return;
        }

        var selectedPath = selectFolderRequest.Path;
        if (verifyModPath(selectedPath))
        {
            ModFolderPath = selectFolderRequest.Path;
            _view.SetModFolderPath(ModFolderPath);
            _settingsService.SetModFolderPath(ModFolderPath);    
        }
        else
        {
            MessageBox.Show(
                $"Please select a valid Mod folder path. The selected path should contain GalCiv4{Path.DirectorySeparatorChar}Mods in it.",
                "Invalid mod path!", MessageBoxButtons.OK);
        }
    }

    private bool verifyModPath(string path)
    {
        var modPath = $"GalCiv4{Path.DirectorySeparatorChar}Mods";
        return path.Contains(modPath);
    }

    private bool verifyInstallPath(string path)
    {
        var gc4Path = path;
        gc4Path = gc4Path + (gc4Path.EndsWith(Path.PathSeparator) ? "" : "/") + "GalCiv4.exe";
        return File.Exists(gc4Path);
    }

    private void OnSetGameInstallPathClicked(object? sender, EventArgs e)
    {
        var requestDialog = _serviceProvider.GetRequiredService<IRequestFolderView>();
        var selectFolderRequest = requestDialog.RequestFolder(GameInstallPath);
        if (selectFolderRequest.Canceled)
        {
            return;
        }
        
        var selectedPath = selectFolderRequest.Path;
        if (verifyInstallPath(selectedPath))
        {
            GameInstallPath = selectFolderRequest.Path;
            _view.SetGameInstallPath(GameInstallPath);
            _settingsService.SetGameInstallPath(GameInstallPath);
            if (!GameInstallPath.EndsWith(Path.DirectorySeparatorChar))
            {
                GameInstallPath = $"{GameInstallPath}{Path.DirectorySeparatorChar}";
            }
            _view.SetGameInstallPath(GameInstallPath);
            _settingsService.SetGameInstallPath(GameInstallPath);
        }
        else
        {
            MessageBox.Show(
                "Please select the directory that Galactic Civilizations is installed in. The directory should contain GalCiv4.exe",
                "GalCiv4.exe not found!", MessageBoxButtons.OK);
            OnSetGameInstallPathClicked(sender, e);
        }
    }


    public void Show()
    {
        _view.Show();
    }
}