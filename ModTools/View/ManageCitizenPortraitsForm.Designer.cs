using ReaLTaiizor.Controls;

namespace ModTools.View
{
    partial class ManageCitizenPortraitsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCitizenPortraitsForm));
            this.citizenPortraitListView = new System.Windows.Forms.ListView();
            this.addCitizenPortraitButton = new System.Windows.Forms.PictureBox();
            this.removeCitizenPortraitsButton = new System.Windows.Forms.PictureBox();
            this.saveButton = new ReaLTaiizor.Controls.CrownButton();
            ((System.ComponentModel.ISupportInitialize)(this.addCitizenPortraitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeCitizenPortraitsButton)).BeginInit();
            this.SuspendLayout();
            // 
            // citizenPortraitListView
            // 
            this.citizenPortraitListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.citizenPortraitListView.Location = new System.Drawing.Point(12, 12);
            this.citizenPortraitListView.Name = "citizenPortraitListView";
            this.citizenPortraitListView.Size = new System.Drawing.Size(755, 481);
            this.citizenPortraitListView.TabIndex = 0;
            this.citizenPortraitListView.UseCompatibleStateImageBehavior = false;
            // 
            // addCitizenPortraitButton
            // 
            this.addCitizenPortraitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addCitizenPortraitButton.BackgroundImage")));
            this.addCitizenPortraitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addCitizenPortraitButton.Location = new System.Drawing.Point(773, 12);
            this.addCitizenPortraitButton.Name = "addCitizenPortraitButton";
            this.addCitizenPortraitButton.Size = new System.Drawing.Size(24, 24);
            this.addCitizenPortraitButton.TabIndex = 32;
            this.addCitizenPortraitButton.TabStop = false;
            this.addCitizenPortraitButton.Click += new System.EventHandler(this.addCitizenPortraitClicked);
            // 
            // removeCitizenPortraitsButton
            // 
            this.removeCitizenPortraitsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeCitizenPortraitsButton.BackgroundImage")));
            this.removeCitizenPortraitsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeCitizenPortraitsButton.Location = new System.Drawing.Point(773, 51);
            this.removeCitizenPortraitsButton.Name = "removeCitizenPortraitsButton";
            this.removeCitizenPortraitsButton.Size = new System.Drawing.Size(24, 24);
            this.removeCitizenPortraitsButton.TabIndex = 33;
            this.removeCitizenPortraitsButton.TabStop = false;
            this.removeCitizenPortraitsButton.Click += new System.EventHandler(this.removeCitizenPortraitsClicked);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(773, 462);
            this.saveButton.Name = "saveButton";
            this.saveButton.Padding = new System.Windows.Forms.Padding(5);
            this.saveButton.Size = new System.Drawing.Size(84, 30);
            this.saveButton.TabIndex = 34;
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButtonClicked);
            // 
            // ManageCitizenPortraitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 504);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.removeCitizenPortraitsButton);
            this.Controls.Add(this.addCitizenPortraitButton);
            this.Controls.Add(this.citizenPortraitListView);
            this.Name = "ManageCitizenPortraitsForm";
            this.Text = "ManageCitizenPortraitsForm";
            ((System.ComponentModel.ISupportInitialize)(this.addCitizenPortraitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeCitizenPortraitsButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView citizenPortraitListView;
        private PictureBox addCitizenPortraitButton;
        private PictureBox removeCitizenPortraitsButton;
        private CrownButton saveButton;
    }
}