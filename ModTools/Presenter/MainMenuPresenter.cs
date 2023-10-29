using Microsoft.Extensions.DependencyInjection;
using ModTools.Presenter.Contracts;
using ModTools.Services.Contracts;
using ModTools.View.Contracts;
using System.Diagnostics;

namespace ModTools.Presenter;

public class MainMenuPresenter : IMainMenuPresenter
{
    private readonly IMainMenuView _view;
    private readonly ISettingsService _settingsService;
    private readonly IServiceProvider _serviceProvider;
    private readonly IImageService _imageService;
    private readonly IGenericDialogView _dialogView;
    
    IMainMenuView IPresenter<IMainMenuView>.View => _view;
        
    
    public MainMenuPresenter(IMainMenuView form, IGenericDialogView dialogView, ISettingsService settingsService,
        IServiceProvider serviceProvider, IImageService imageService)
    {
        _view = form;
        _settingsService = settingsService;
        _serviceProvider = serviceProvider;
        _imageService = imageService;
        _dialogView = dialogView;
        var installPath = _settingsService.GetGameInstallPath();
        if (!string.IsNullOrEmpty(installPath)) {
            var background_path = $"{_settingsService.GetGameInstallPath()}{Constants.MAIN_MENU_BACKGROUND_PATH}";
            var image = _imageService.LoadImage(background_path);
            _view.SetBackgroundImage(image.Image);
            var logoPath = $"{_settingsService.GetGameInstallPath()}{Constants.GCIV_LOGO_PATH}";
            var logo = _imageService.LoadImage(logoPath);
            _view.SetGC4LogoImage(logo.Image);
        }        
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
        if (!needsInstallPath)
        {
            var background_path = $"{_settingsService.GetGameInstallPath()}{Constants.MAIN_MENU_BACKGROUND_PATH}";
            var image = _imageService.LoadImage(background_path);
            _view.SetBackgroundImage(image.Image);
            var logoPath = $"{_settingsService.GetGameInstallPath()}{Constants.GCIV_LOGO_PATH}";
            var logo = _imageService.LoadImage(logoPath);
            _view.SetGC4LogoImage(logo.Image);
        }
    }

    public void Init()
    {
        _view.RaceButtonClicked += OnRaceButtonClicked;
        _view.StarSystemButtonClicked += OnStarSystemButtonClicked;
        _view.SettingsButtonClicked += OnSettingsButtonClicked;
        _view.EventButtonClicked += OnEventButtonClicked;
        _view.FeedbackButtonClicked += OnFeedbackButtonClicked;
        _view.Activated += OnActivated;
        ShowDialogIfNeeded();
    }

    private void SetEditorsEnabled(bool enabled)
    {
        _view.SetEventEditorEnabled(enabled);
        _view.SetRaceEditorEnabled(enabled);
        _view.SetStarSystemEditorEnabled(enabled);
    }
    

    private void ShowDialogIfNeeded()
    {
        var needsInstallPath = string.IsNullOrWhiteSpace(_settingsService.GetGameInstallPath());
        var needsModPath = string.IsNullOrWhiteSpace(_settingsService.GetModFolderPath());
        if (needsInstallPath || needsModPath)
        {
            SetEditorsEnabled(false);
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
            // TODO - This is hacky as hell. Figure out why this is needed, and do it a better way.
            Task.Delay(1).ContinueWith((_) =>
            {
                _view.BeginInvoke(() =>
                {
                    var settingsPresenter = _serviceProvider.GetRequiredService<ISettingsPresenter>();
                    settingsPresenter.Init();
                    settingsPresenter.Show();
                });
            });
        }
        else
        {
            SetEditorsEnabled(true);
        }
    }

    private void OnActivated(object? sender, EventArgs e)
    {
        Refresh();
    }
    
    private void OnEventButtonClicked(object? sender, EventArgs e)
    {
        // TODO - To be uncommented when event editor is ready
        // var eventPresenter = _serviceProvider.GetRequiredService<IEventEditorPresenter>();
        // eventPresenter.Init();
        // eventPresenter.Show();
        
        // TODO - Remove this when event editor is ready (or for development)
        _dialogView.Show_Ok("The event editor is not yet ready for public use. It has been shelved for now. If there is enough interest, it may be re-started. Click on the feedback button to submit your desire for this feature.",
            "Coming soon...maybe?");
    }

    private void OnSettingsButtonClicked(object? sender, EventArgs e)
    {
        var settingsPresenter = _serviceProvider.GetRequiredService<ISettingsPresenter>();
        settingsPresenter.Init();
        settingsPresenter.Show();
    }
    
    private void OnRaceButtonClicked(object? sender, EventArgs e)
    {
        var raceEditorPresenter = _serviceProvider.GetRequiredService<IRaceEditorPresenter>();
        raceEditorPresenter.Init();
        raceEditorPresenter.Show();
    }

    private void OnStarSystemButtonClicked(object? sender, EventArgs e)
    {
        // TODO - Uncomment when star system editor is fixed.
        //var starSystemPresenter = _serviceProvider.GetRequiredService<IStarSystemEditorPresenter>();
        //starSystemPresenter.Init();
        //starSystemPresenter.Show();

        _dialogView.Show_Ok("The star system editor isn't ready yet. Once all the major bugs have been ironed out, it will be available."
            , "Coming back soon");
    }

    private void OnFeedbackButtonClicked(object? sender, EventArgs e)
    {
        ProcessStartInfo psInfo = new ProcessStartInfo 
        {
            UseShellExecute = true,
            FileName = "https://github.com/ryanbis/gc4_mod_tools"
        };
        Process.Start(psInfo);
    }

    public void Show()
    {
        _view.Show();
    }
}