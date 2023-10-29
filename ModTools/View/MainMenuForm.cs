using System.Reflection;
using ModTools.View.Contracts;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace ModTools.View;

public partial class MainMenuForm : CrownForm, IMainMenuView
{
    public event EventHandler? RaceButtonClicked;
    public event EventHandler? StarSystemButtonClicked;
    public event EventHandler? SettingsButtonClicked;
    public event EventHandler? EventButtonClicked;
    public event EventHandler? FeedbackButtonClicked;


    public MainMenuForm()
    {
        InitializeComponent();
        Text = $"GC IV: Supernova Mod Tools v{Assembly.GetEntryAssembly().GetName().Version}";
    }


    public void SetGC4LogoImage(Image image)
    {
        GC4Logo.Image = image;
    }

    public void SetBackgroundImage(Image image)
    {
        BackgroundImage = image;
    }

    public void SetRaceEditorEnabled(bool enabled)
    {
        raceEditorButton.Enabled = enabled;
    }

    public void SetStarSystemEditorEnabled(bool enabled)
    {
        starSystemEditorButton.Enabled = enabled;
    }

    public void SetEventEditorEnabled(bool enabled)
    {
        eventEditorButton.Enabled = enabled;
    }

    public Form Form()
    {
        return this;
    }

    private void feedbackButton_Click(object sender, EventArgs e)
    {
        FeedbackButtonClicked?.Invoke(this, EventArgs.Empty);
    }

    private void raceEditorButton_Click(object sender, EventArgs e)
    {
        RaceButtonClicked?.Invoke(this, EventArgs.Empty);
    }

    private void starSystemEditorButtonClicked(object sender, EventArgs e)
    {
        StarSystemButtonClicked?.Invoke(this, EventArgs.Empty);
    }

    private void settingsButtonClicked(object sender, EventArgs e)
    {
        SettingsButtonClicked?.Invoke(this, EventArgs.Empty);
    }

    private void eventEditorButtonClicked(object sender, EventArgs e)
    {
        EventButtonClicked?.Invoke(this, EventArgs.Empty);
    }

}