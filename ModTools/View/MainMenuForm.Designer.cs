using System.ComponentModel;

namespace ModTools.View;

partial class MainMenuForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.raceEditorButton = new ReaLTaiizor.Controls.SpaceButton();
            this.settingsButton = new ReaLTaiizor.Controls.SpaceButton();
            this.starSystemEditorButton = new ReaLTaiizor.Controls.SpaceButton();
            this.spaceButton3 = new ReaLTaiizor.Controls.SpaceButton();
            this.eventEditorButton = new ReaLTaiizor.Controls.SpaceButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.GC4Logo = new System.Windows.Forms.PictureBox();
            this.FeedbackButton = new ReaLTaiizor.Controls.SpaceButton();
            ((System.ComponentModel.ISupportInitialize)(this.GC4Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // raceEditorButton
            // 
            this.raceEditorButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.raceEditorButton.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            this.raceEditorButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.raceEditorButton.Image = null;
            this.raceEditorButton.Location = new System.Drawing.Point(12, 12);
            this.raceEditorButton.Name = "raceEditorButton";
            this.raceEditorButton.NoRounding = false;
            this.raceEditorButton.Size = new System.Drawing.Size(195, 40);
            this.raceEditorButton.TabIndex = 0;
            this.raceEditorButton.Text = "Race Editor";
            this.raceEditorButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.raceEditorButton.Transparent = false;
            this.raceEditorButton.Click += new System.EventHandler(this.raceEditorButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.settingsButton.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            this.settingsButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingsButton.Image = null;
            this.settingsButton.Location = new System.Drawing.Point(444, 12);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.NoRounding = false;
            this.settingsButton.Size = new System.Drawing.Size(195, 40);
            this.settingsButton.TabIndex = 1;
            this.settingsButton.Text = "Settings";
            this.settingsButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.settingsButton.Transparent = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButtonClicked);
            // 
            // starSystemEditorButton
            // 
            this.starSystemEditorButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.starSystemEditorButton.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            this.starSystemEditorButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.starSystemEditorButton.Image = null;
            this.starSystemEditorButton.Location = new System.Drawing.Point(12, 114);
            this.starSystemEditorButton.Name = "starSystemEditorButton";
            this.starSystemEditorButton.NoRounding = false;
            this.starSystemEditorButton.Size = new System.Drawing.Size(195, 40);
            this.starSystemEditorButton.TabIndex = 2;
            this.starSystemEditorButton.Text = "Star System Editor";
            this.starSystemEditorButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.starSystemEditorButton.Transparent = false;
            this.starSystemEditorButton.Click += new System.EventHandler(this.starSystemEditorButtonClicked);
            // 
            // spaceButton3
            // 
            this.spaceButton3.BackColor = System.Drawing.SystemColors.Desktop;
            this.spaceButton3.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            this.spaceButton3.Enabled = false;
            this.spaceButton3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.spaceButton3.Image = null;
            this.spaceButton3.Location = new System.Drawing.Point(12, 319);
            this.spaceButton3.Name = "spaceButton3";
            this.spaceButton3.NoRounding = false;
            this.spaceButton3.Size = new System.Drawing.Size(195, 40);
            this.spaceButton3.TabIndex = 3;
            this.spaceButton3.Text = "TBD";
            this.spaceButton3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.spaceButton3.Transparent = false;
            // 
            // eventEditorButton
            // 
            this.eventEditorButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.eventEditorButton.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            this.eventEditorButton.Enabled = false;
            this.eventEditorButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eventEditorButton.Image = null;
            this.eventEditorButton.Location = new System.Drawing.Point(12, 213);
            this.eventEditorButton.Name = "eventEditorButton";
            this.eventEditorButton.NoRounding = false;
            this.eventEditorButton.Size = new System.Drawing.Size(195, 40);
            this.eventEditorButton.TabIndex = 4;
            this.eventEditorButton.Text = "Event Editor";
            this.eventEditorButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.eventEditorButton.Transparent = false;
            this.eventEditorButton.Click += new System.EventHandler(this.eventEditorButtonClicked);
            // 
            // GC4Logo
            // 
            this.GC4Logo.Location = new System.Drawing.Point(439, 243);
            this.GC4Logo.Name = "GC4Logo";
            this.GC4Logo.Size = new System.Drawing.Size(200, 116);
            this.GC4Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GC4Logo.TabIndex = 5;
            this.GC4Logo.TabStop = false;
            // 
            // FeedbackButton
            // 
            this.FeedbackButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.FeedbackButton.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            this.FeedbackButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FeedbackButton.Image = null;
            this.FeedbackButton.Location = new System.Drawing.Point(444, 114);
            this.FeedbackButton.Name = "FeedbackButton";
            this.FeedbackButton.NoRounding = false;
            this.FeedbackButton.Size = new System.Drawing.Size(195, 40);
            this.FeedbackButton.TabIndex = 6;
            this.FeedbackButton.Text = "Contribute/Feedback";
            this.FeedbackButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.FeedbackButton.Transparent = false;
            this.FeedbackButton.Click += new System.EventHandler(this.feedbackButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(651, 371);
            this.Controls.Add(this.FeedbackButton);
            this.Controls.Add(this.GC4Logo);
            this.Controls.Add(this.eventEditorButton);
            this.Controls.Add(this.spaceButton3);
            this.Controls.Add(this.starSystemEditorButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.raceEditorButton);
            this.Name = "MainMenuForm";
            this.Text = "GC IV Mod Tools";
            ((System.ComponentModel.ISupportInitialize)(this.GC4Logo)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private ReaLTaiizor.Controls.SpaceButton raceEditorButton;
    private ReaLTaiizor.Controls.SpaceButton settingsButton;
    private ReaLTaiizor.Controls.SpaceButton starSystemEditorButton;
    private ReaLTaiizor.Controls.SpaceButton spaceButton3;
    private ReaLTaiizor.Controls.SpaceButton eventEditorButton;
    private ToolTip toolTip;
    private PictureBox GC4Logo;
    private ReaLTaiizor.Controls.SpaceButton FeedbackButton;
}