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

        ModFolderPath = selectFolderRequest.Path;
        _view.SetModFolderPath(ModFolderPath);
        _settingsService.SetModFolderPath(ModFolderPath);
    }

    private void OnSetGameInstallPathClicked(object? sender, EventArgs e)
    {
        var requestDialog = _serviceProvider.GetRequiredService<IRequestFolderView>();
        var selectFolderRequest = requestDialog.RequestFolder(GameInstallPath);
        if (selectFolderRequest.Canceled)
        {
            return;
        }

        GameInstallPath = selectFolderRequest.Path;
        if (!GameInstallPath.EndsWith(Path.DirectorySeparatorChar))
        {
            GameInstallPath = $"{GameInstallPath}{Path.DirectorySeparatorChar}";
        }
        _view.SetGameInstallPath(GameInstallPath);
        _settingsService.SetGameInstallPath(GameInstallPath);
    }


    public void Show()
    {
        _view.Show();
    }
}