using Microsoft.Extensions.DependencyInjection;
using ModTools.Presenter.Contracts;
using ModTools.Services.Contracts;
using ModTools.View.Contracts;

namespace ModTools.Presenter;

public class MainMenuPresenter : IMainMenuPresenter
{
    private readonly IMainMenuView _view;
    private IRaceEditorPresenter _raceEditorPresenter;
    private readonly ISettingsService _settingsService;
    private readonly IServiceProvider _serviceProvider;
    private readonly IGenericDialogView _dialogView;
    
    IMainMenuView IPresenter<IMainMenuView>.View => _view;
    
    
    public MainMenuPresenter(IMainMenuView form, IGenericDialogView dialogView, ISettingsService settingsService,
        IServiceProvider serviceProvider)
    {
        _view = form;
        _settingsService = settingsService;
        _serviceProvider = serviceProvider;
        _dialogView = dialogView;
    }

    public Form Form()
    {
        return _view.Form();
    }

    private void Refresh()
    {
        var needsInstallPath = string.IsNullOrWhiteSpace(_settingsService.GetGameInstallPath());
        var needsModPath = string.IsNullOrWhiteSpace(_settingsService.GetModFolderPath());
        var editorsEnabled = !needsInstallPath && !needsModPath;
        _view.SetRaceEditorEnabled(editorsEnabled);
        _view.SetStarSystemEditorEnabled(editorsEnabled);
    }

    public void Init()
    {
        _view.RaceButtonClicked += OnRaceButtonClicked;
        _view.StarSystemButtonClicked += OnStarSystemButtonClicked;
        _view.SettingsButtonClicked += OnSettingsButtonClicked;
        _view.Activated += OnActivated;
        ShowDialogIfNeeded();
    }

    private void ShowDialogIfNeeded()
    {
        var needsInstallPath = string.IsNullOrWhiteSpace(_settingsService.GetGameInstallPath());
        var needsModPath = string.IsNullOrWhiteSpace(_settingsService.GetModFolderPath());
        if (needsInstallPath || needsModPath)
        {
            _view.SetRaceEditorEnabled(false);
            _view.SetStarSystemEditorEnabled(false);
            var msg = "Before using any editor, please make sure to set your ";
            if (needsInstallPath)
            {
                msg += "game install ";
                if (needsModPath)
                {
                    msg += "and mod folder paths";
                }
                else
                {
                    msg += "path";
                }
            } else if (needsModPath)
            {
                msg += "mod folder path";
            }

            _dialogView.Show_Ok(msg, "Incomplete Settings");
            Task.Run(() =>
            {
                _view.Invoke(() =>
                {
                    var settingsPresenter = _serviceProvider.GetRequiredService<ISettingsPresenter>();
                    settingsPresenter.Init();
                    settingsPresenter.Show();    
                });    
            });
        }
        else
        {
            _view.SetRaceEditorEnabled(true);
            _view.SetStarSystemEditorEnabled(true);
        }
    }

    private void OnActivated(object? sender, EventArgs e)
    {
        Refresh();
    }

    private void OnSettingsButtonClicked(object? sender, EventArgs e)
    {
        var settingsPresenter = _serviceProvider.GetRequiredService<ISettingsPresenter>();
        settingsPresenter.Init();
        settingsPresenter.Show();
    }
    
    private void OnRaceButtonClicked(object? sender, EventArgs e)
    {
        if (_raceEditorPresenter == null || _raceEditorPresenter.IsDestroyed)
        {
            _raceEditorPresenter = _serviceProvider.GetRequiredService<IRaceEditorPresenter>();
            _raceEditorPresenter.Init();
        }

        _raceEditorPresenter.Show();
    }

    private void OnStarSystemButtonClicked(object? sender, EventArgs e)
    {
        var starSystemPresenter = _serviceProvider.GetRequiredService<IStarSystemEditorPresenter>();
        starSystemPresenter.Init();
        starSystemPresenter.Show();
    }

    public void Show()
    {
        _view.Show();
    }
}