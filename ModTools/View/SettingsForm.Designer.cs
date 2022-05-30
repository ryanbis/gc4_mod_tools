namespace ModTools.View
{
    partial class SettingsForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.setModPathButton = new ReaLTaiizor.Controls.CrownButton();
            this.mfpLabel = new ReaLTaiizor.Controls.CrownLabel();
            this.gcpLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            this.gameInstallPathLabel = new ReaLTaiizor.Controls.CrownLabel();
            this.setInstallPathButton = new ReaLTaiizor.Controls.CrownButton();
            this.modFolderPathLabel = new ReaLTaiizor.Controls.CrownLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.35279F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.05836F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.58886F));
            this.tableLayoutPanel1.Controls.Add(this.setModPathButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.mfpLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gcpLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gameInstallPathLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.setInstallPathButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.modFolderPathLabel, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(754, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // setModPathButton
            // 
            this.setModPathButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.setModPathButton.Location = new System.Drawing.Point(647, 53);
            this.setModPathButton.Name = "setModPathButton";
            this.setModPathButton.Padding = new System.Windows.Forms.Padding(5);
            this.setModPathButton.Size = new System.Drawing.Size(46, 23);
            this.setModPathButton.TabIndex = 3;
            this.setModPathButton.Text = "Set";
            this.setModPathButton.Click += new System.EventHandler(this.setModFolderPathClicked);
            // 
            // mfpLabel
            // 
            this.mfpLabel.AutoSize = true;
            this.mfpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.mfpLabel.Location = new System.Drawing.Point(3, 56);
            this.mfpLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.mfpLabel.Name = "mfpLabel";
            this.mfpLabel.Size = new System.Drawing.Size(98, 15);
            this.mfpLabel.TabIndex = 1;
            this.mfpLabel.Text = "MOD Folder Path";
            // 
            // gcpLabel1
            // 
            this.gcpLabel1.AutoSize = true;
            this.gcpLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.gcpLabel1.Location = new System.Drawing.Point(3, 6);
            this.gcpLabel1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.gcpLabel1.Name = "gcpLabel1";
            this.gcpLabel1.Size = new System.Drawing.Size(124, 15);
            this.gcpLabel1.TabIndex = 0;
            this.gcpLabel1.Text = "GC4 Game Install Path";
            // 
            // gameInstallPathLabel
            // 
            this.gameInstallPathLabel.AutoSize = true;
            this.gameInstallPathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.gameInstallPathLabel.Location = new System.Drawing.Point(164, 6);
            this.gameInstallPathLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.gameInstallPathLabel.Name = "gameInstallPathLabel";
            this.gameInstallPathLabel.Size = new System.Drawing.Size(0, 15);
            this.gameInstallPathLabel.TabIndex = 1;
            // 
            // setInstallPathButton
            // 
            this.setInstallPathButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.setInstallPathButton.Location = new System.Drawing.Point(647, 3);
            this.setInstallPathButton.Name = "setInstallPathButton";
            this.setInstallPathButton.Padding = new System.Windows.Forms.Padding(5);
            this.setInstallPathButton.Size = new System.Drawing.Size(46, 23);
            this.setInstallPathButton.TabIndex = 2;
            this.setInstallPathButton.Text = "Set";
            this.setInstallPathButton.Click += new System.EventHandler(this.setGameInstallPathClicked);
            // 
            // modFolderPathLabel
            // 
            this.modFolderPathLabel.AutoSize = true;
            this.modFolderPathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.modFolderPathLabel.Location = new System.Drawing.Point(164, 56);
            this.modFolderPathLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.modFolderPathLabel.Name = "modFolderPathLabel";
            this.modFolderPathLabel.Size = new System.Drawing.Size(0, 15);
            this.modFolderPathLabel.TabIndex = 3;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.CrownButton setModPathButton;
        private ReaLTaiizor.Controls.CrownLabel mfpLabel;
        private ReaLTaiizor.Controls.CrownLabel gcpLabel1;
        private ReaLTaiizor.Controls.CrownLabel gameInstallPathLabel;
        private ReaLTaiizor.Controls.CrownButton setInstallPathButton;
        private ReaLTaiizor.Controls.CrownLabel modFolderPathLabel;
    }
}