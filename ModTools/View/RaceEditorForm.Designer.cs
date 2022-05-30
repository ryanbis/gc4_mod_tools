using ModTools.Model.Race;
using ReaLTaiizor.Controls;
using Button = ReaLTaiizor.Controls.CrownButton;
using CheckBox = ReaLTaiizor.Controls.CrownCheckBox;
using Panel = System.Windows.Forms.Panel;

namespace ModTools.View
{
    partial class RaceEditorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaceEditorForm));
            this.citizenRaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabPage1 = new ReaLTaiizor.Controls.TabPage();
            this.generalInfoTabPage = new System.Windows.Forms.TabPage();
            this.modTypeComboBox = new ReaLTaiizor.Controls.CrownComboBox();
            this.crownLabel3 = new ReaLTaiizor.Controls.CrownLabel();
            this.manageCitizenPortraitsButton = new ReaLTaiizor.Controls.CrownButton();
            this.crownLabel2 = new ReaLTaiizor.Controls.CrownLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new ReaLTaiizor.Controls.CrownLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.militaryAdvisorPortraitPictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new ReaLTaiizor.Controls.CrownLabel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.scienceAdvisorPortraitPictureBox = new System.Windows.Forms.PictureBox();
            this.label5 = new ReaLTaiizor.Controls.CrownLabel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.colonizationAdvisorPortraitPictureBox = new System.Windows.Forms.PictureBox();
            this.label6 = new ReaLTaiizor.Controls.CrownLabel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.genericImagePictureBox = new System.Windows.Forms.PictureBox();
            this.label8 = new ReaLTaiizor.Controls.CrownLabel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.politicalAdvisorPortraitPictureBox = new System.Windows.Forms.PictureBox();
            this.label7 = new ReaLTaiizor.Controls.CrownLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.raceComboBox = new ReaLTaiizor.Controls.CrownComboBox();
            this.crownLabel4 = new ReaLTaiizor.Controls.CrownLabel();
            this.label15 = new ReaLTaiizor.Controls.CrownLabel();
            this.label2 = new ReaLTaiizor.Controls.CrownLabel();
            this.hasGenderCheckBox = new ReaLTaiizor.Controls.CrownCheckBox();
            this.descriptionLabel = new ReaLTaiizor.Controls.CrownLabel();
            this.IsMinorRaceCheckBox = new ReaLTaiizor.Controls.CrownCheckBox();
            this.nameLabel = new ReaLTaiizor.Controls.CrownLabel();
            this.descriptionTextBox = new ReaLTaiizor.Controls.CrownTextBox();
            this.nameTextBox = new ReaLTaiizor.Controls.CrownTextBox();
            this.statsTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.consumedTraitComboBox = new ReaLTaiizor.Controls.CrownComboBox();
            this.defaultTraitsComboBox = new ReaLTaiizor.Controls.CrownComboBox();
            this.warforgedChanceTextBox = new ReaLTaiizor.Controls.CrownTextBox();
            this.pacifistChanceTextBox = new ReaLTaiizor.Controls.CrownTextBox();
            this.naturalLeagueChanceTextBox = new ReaLTaiizor.Controls.CrownTextBox();
            this.emporiumChanceTextBox = new ReaLTaiizor.Controls.CrownTextBox();
            this.label20 = new ReaLTaiizor.Controls.CrownLabel();
            this.label19 = new ReaLTaiizor.Controls.CrownLabel();
            this.label13 = new ReaLTaiizor.Controls.CrownLabel();
            this.label12 = new ReaLTaiizor.Controls.CrownLabel();
            this.label11 = new ReaLTaiizor.Controls.CrownLabel();
            this.label10 = new ReaLTaiizor.Controls.CrownLabel();
            this.ideologyChanceTextBox = new ReaLTaiizor.Controls.CrownTextBox();
            this.label9 = new ReaLTaiizor.Controls.CrownLabel();
            this.label1 = new ReaLTaiizor.Controls.CrownLabel();
            this.protestingApprovalThresholdTextBox = new ReaLTaiizor.Controls.CrownTextBox();
            this.label14 = new ReaLTaiizor.Controls.CrownLabel();
            this.criminalChanceTextBox = new ReaLTaiizor.Controls.CrownTextBox();
            this.modifiersTabPage = new System.Windows.Forms.TabPage();
            this.approvalModifiersListView = new System.Windows.Forms.ListView();
            this.approvalModifierTypeColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.approvalModifierTagColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.approvalModifierValueColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.removeApprovalModifiersButton = new System.Windows.Forms.PictureBox();
            this.addApprovalModifiersButton = new System.Windows.Forms.PictureBox();
            this.label18 = new ReaLTaiizor.Controls.CrownLabel();
            this.removeColonyStatButton = new System.Windows.Forms.PictureBox();
            this.addColonyStatButton = new System.Windows.Forms.PictureBox();
            this.colonyStatsListView = new System.Windows.Forms.ListView();
            this.colonyEffectTypeHeader = new System.Windows.Forms.ColumnHeader();
            this.colonyValueHeader = new System.Windows.Forms.ColumnHeader();
            this.colonyValueTypeHeader = new System.Windows.Forms.ColumnHeader();
            this.colonyStringParamHeader = new System.Windows.Forms.ColumnHeader();
            this.label17 = new ReaLTaiizor.Controls.CrownLabel();
            this.removeGlobalStatButton = new System.Windows.Forms.PictureBox();
            this.addGlobalStatButton = new System.Windows.Forms.PictureBox();
            this.globalStatslistView = new System.Windows.Forms.ListView();
            this.effectTypeHeader = new System.Windows.Forms.ColumnHeader();
            this.valueHeader = new System.Windows.Forms.ColumnHeader();
            this.label16 = new ReaLTaiizor.Controls.CrownLabel();
            this.citizenRaceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.saveRaceButton = new ReaLTaiizor.Controls.CrownButton();
            this.valueParam1Header = new System.Windows.Forms.ColumnHeader();
            this.valueParam2Header = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.citizenRaceBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.generalInfoTabPage.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.militaryAdvisorPortraitPictureBox)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scienceAdvisorPortraitPictureBox)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colonizationAdvisorPortraitPictureBox)).BeginInit();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genericImagePictureBox)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.politicalAdvisorPortraitPictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.statsTabPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.modifiersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeApprovalModifiersButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addApprovalModifiersButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeColonyStatButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addColonyStatButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeGlobalStatButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addGlobalStatButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citizenRaceBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // citizenRaceBindingSource
            // 
            this.citizenRaceBindingSource.DataSource = typeof(string);
            // 
            // tabPage1
            // 
            this.tabPage1.ActiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage1.ActiveLineTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.tabPage1.ActiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.tabPage1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabPage1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            this.tabPage1.CompositingType = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            this.tabPage1.ControlBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.generalInfoTabPage);
            this.tabPage1.Controls.Add(this.statsTabPage);
            this.tabPage1.Controls.Add(this.modifiersTabPage);
            this.tabPage1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabPage1.FrameColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.tabPage1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.tabPage1.ItemSize = new System.Drawing.Size(44, 135);
            this.tabPage1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.tabPage1.LineTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.tabPage1.Location = new System.Drawing.Point(12, 12);
            this.tabPage1.Multiline = true;
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.tabPage1.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.tabPage1.SelectedIndex = 0;
            this.tabPage1.Size = new System.Drawing.Size(878, 509);
            this.tabPage1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabPage1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.tabPage1.StringType = System.Drawing.StringAlignment.Near;
            this.tabPage1.TabColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.tabPage1.TabIndex = 1;
            // 
            // generalInfoTabPage
            // 
            this.generalInfoTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.generalInfoTabPage.Controls.Add(this.modTypeComboBox);
            this.generalInfoTabPage.Controls.Add(this.crownLabel3);
            this.generalInfoTabPage.Controls.Add(this.manageCitizenPortraitsButton);
            this.generalInfoTabPage.Controls.Add(this.crownLabel2);
            this.generalInfoTabPage.Controls.Add(this.panel3);
            this.generalInfoTabPage.Controls.Add(this.tableLayoutPanel1);
            this.generalInfoTabPage.Location = new System.Drawing.Point(139, 4);
            this.generalInfoTabPage.Name = "generalInfoTabPage";
            this.generalInfoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalInfoTabPage.Size = new System.Drawing.Size(735, 501);
            this.generalInfoTabPage.TabIndex = 0;
            this.generalInfoTabPage.Text = "General Info";
            // 
            // modTypeComboBox
            // 
            this.modTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.modTypeComboBox.FormattingEnabled = true;
            this.modTypeComboBox.Items.AddRange(new object[] {
            "Append",
            "Replace"});
            this.modTypeComboBox.Location = new System.Drawing.Point(448, 16);
            this.modTypeComboBox.Name = "modTypeComboBox";
            this.modTypeComboBox.Size = new System.Drawing.Size(136, 24);
            this.modTypeComboBox.TabIndex = 34;
            // 
            // crownLabel3
            // 
            this.crownLabel3.AutoSize = true;
            this.crownLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownLabel3.Location = new System.Drawing.Point(380, 19);
            this.crownLabel3.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.crownLabel3.Name = "crownLabel3";
            this.crownLabel3.Size = new System.Drawing.Size(62, 15);
            this.crownLabel3.TabIndex = 18;
            this.crownLabel3.Text = "MOD Type";
            // 
            // manageCitizenPortraitsButton
            // 
            this.manageCitizenPortraitsButton.Location = new System.Drawing.Point(594, 252);
            this.manageCitizenPortraitsButton.Name = "manageCitizenPortraitsButton";
            this.manageCitizenPortraitsButton.Padding = new System.Windows.Forms.Padding(5);
            this.manageCitizenPortraitsButton.Size = new System.Drawing.Size(125, 41);
            this.manageCitizenPortraitsButton.TabIndex = 17;
            this.manageCitizenPortraitsButton.Text = "Manage Portraits";
            this.manageCitizenPortraitsButton.Click += new System.EventHandler(this.managePortraitsClicked);
            // 
            // crownLabel2
            // 
            this.crownLabel2.AutoSize = true;
            this.crownLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.crownLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownLabel2.Location = new System.Drawing.Point(6, 20);
            this.crownLabel2.Name = "crownLabel2";
            this.crownLabel2.Size = new System.Drawing.Size(81, 21);
            this.crownLabel2.TabIndex = 16;
            this.crownLabel2.Text = "Race Info";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.flowLayoutPanel2);
            this.panel3.Controls.Add(this.flowLayoutPanel3);
            this.panel3.Controls.Add(this.flowLayoutPanel5);
            this.panel3.Controls.Add(this.flowLayoutPanel4);
            this.panel3.Location = new System.Drawing.Point(6, 318);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(713, 177);
            this.panel3.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Advisor Portraits";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.militaryAdvisorPortraitPictureBox);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(146, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(134, 154);
            this.flowLayoutPanel1.TabIndex = 9;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // militaryAdvisorPortraitPictureBox
            // 
            this.militaryAdvisorPortraitPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.militaryAdvisorPortraitPictureBox.Location = new System.Drawing.Point(3, 3);
            this.militaryAdvisorPortraitPictureBox.Name = "militaryAdvisorPortraitPictureBox";
            this.militaryAdvisorPortraitPictureBox.Size = new System.Drawing.Size(128, 128);
            this.militaryAdvisorPortraitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.militaryAdvisorPortraitPictureBox.TabIndex = 0;
            this.militaryAdvisorPortraitPictureBox.TabStop = false;
            this.militaryAdvisorPortraitPictureBox.Click += new System.EventHandler(this.militaryAdvisorPortraitPictureBox_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label4.Location = new System.Drawing.Point(37, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Military";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.scienceAdvisorPortraitPictureBox);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(286, 23);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(134, 154);
            this.flowLayoutPanel2.TabIndex = 10;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // scienceAdvisorPortraitPictureBox
            // 
            this.scienceAdvisorPortraitPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.scienceAdvisorPortraitPictureBox.Location = new System.Drawing.Point(3, 3);
            this.scienceAdvisorPortraitPictureBox.Name = "scienceAdvisorPortraitPictureBox";
            this.scienceAdvisorPortraitPictureBox.Size = new System.Drawing.Size(128, 128);
            this.scienceAdvisorPortraitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scienceAdvisorPortraitPictureBox.TabIndex = 0;
            this.scienceAdvisorPortraitPictureBox.TabStop = false;
            this.scienceAdvisorPortraitPictureBox.Click += new System.EventHandler(this.scienceAdvisorPortraitPictureBox_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label5.Location = new System.Drawing.Point(37, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Science";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.colonizationAdvisorPortraitPictureBox);
            this.flowLayoutPanel3.Controls.Add(this.label6);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(426, 23);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(134, 154);
            this.flowLayoutPanel3.TabIndex = 11;
            this.flowLayoutPanel3.WrapContents = false;
            // 
            // colonizationAdvisorPortraitPictureBox
            // 
            this.colonizationAdvisorPortraitPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.colonizationAdvisorPortraitPictureBox.Location = new System.Drawing.Point(3, 3);
            this.colonizationAdvisorPortraitPictureBox.Name = "colonizationAdvisorPortraitPictureBox";
            this.colonizationAdvisorPortraitPictureBox.Size = new System.Drawing.Size(128, 128);
            this.colonizationAdvisorPortraitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colonizationAdvisorPortraitPictureBox.TabIndex = 0;
            this.colonizationAdvisorPortraitPictureBox.TabStop = false;
            this.colonizationAdvisorPortraitPictureBox.Click += new System.EventHandler(this.colonizationAdvisorPortraitPictureBox_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label6.Location = new System.Drawing.Point(20, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Colonization";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel5.Controls.Add(this.genericImagePictureBox);
            this.flowLayoutPanel5.Controls.Add(this.label8);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(6, 23);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(134, 154);
            this.flowLayoutPanel5.TabIndex = 13;
            this.flowLayoutPanel5.WrapContents = false;
            // 
            // genericImagePictureBox
            // 
            this.genericImagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.genericImagePictureBox.Location = new System.Drawing.Point(3, 3);
            this.genericImagePictureBox.Name = "genericImagePictureBox";
            this.genericImagePictureBox.Size = new System.Drawing.Size(128, 128);
            this.genericImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.genericImagePictureBox.TabIndex = 0;
            this.genericImagePictureBox.TabStop = false;
            this.genericImagePictureBox.Click += new System.EventHandler(this.genericImagePictureBox_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label8.Location = new System.Drawing.Point(37, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Generic";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.Controls.Add(this.politicalAdvisorPortraitPictureBox);
            this.flowLayoutPanel4.Controls.Add(this.label7);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(566, 23);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(134, 154);
            this.flowLayoutPanel4.TabIndex = 12;
            this.flowLayoutPanel4.WrapContents = false;
            // 
            // politicalAdvisorPortraitPictureBox
            // 
            this.politicalAdvisorPortraitPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.politicalAdvisorPortraitPictureBox.Location = new System.Drawing.Point(3, 3);
            this.politicalAdvisorPortraitPictureBox.Name = "politicalAdvisorPortraitPictureBox";
            this.politicalAdvisorPortraitPictureBox.Size = new System.Drawing.Size(128, 128);
            this.politicalAdvisorPortraitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.politicalAdvisorPortraitPictureBox.TabIndex = 0;
            this.politicalAdvisorPortraitPictureBox.TabStop = false;
            this.politicalAdvisorPortraitPictureBox.Click += new System.EventHandler(this.politicalAdvisorPortraitPictureBox_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label7.Location = new System.Drawing.Point(36, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Political";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.raceComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.crownLabel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.hasGenderCheckBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.descriptionLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.IsMinorRaceCheckBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.descriptionTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(578, 243);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // raceComboBox
            // 
            this.raceComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.raceComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.raceComboBox.FormattingEnabled = true;
            this.raceComboBox.Location = new System.Drawing.Point(207, 3);
            this.raceComboBox.Name = "raceComboBox";
            this.raceComboBox.Size = new System.Drawing.Size(156, 24);
            this.raceComboBox.TabIndex = 35;
            this.raceComboBox.SelectedIndexChanged += new System.EventHandler(this.RaceDropDown_SelectedIndexChanged);
            // 
            // crownLabel4
            // 
            this.crownLabel4.AutoSize = true;
            this.crownLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownLabel4.Location = new System.Drawing.Point(3, 8);
            this.crownLabel4.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.crownLabel4.Name = "crownLabel4";
            this.crownLabel4.Size = new System.Drawing.Size(198, 15);
            this.crownLabel4.TabIndex = 16;
            this.crownLabel4.Text = "Select race to base your new race on";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label15.Location = new System.Drawing.Point(3, 208);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 15);
            this.label15.TabIndex = 15;
            this.label15.Text = "Has Gender";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label2.Location = new System.Drawing.Point(3, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Is Minor Race";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // hasGenderCheckBox
            // 
            this.hasGenderCheckBox.AutoSize = true;
            this.hasGenderCheckBox.Location = new System.Drawing.Point(207, 208);
            this.hasGenderCheckBox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.hasGenderCheckBox.Name = "hasGenderCheckBox";
            this.hasGenderCheckBox.Size = new System.Drawing.Size(15, 14);
            this.hasGenderCheckBox.TabIndex = 15;
            this.hasGenderCheckBox.CheckedChanged += new System.EventHandler(this.hasGenderCheckChanged);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.descriptionLabel.Location = new System.Drawing.Point(3, 67);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(67, 15);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Description";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IsMinorRaceCheckBox
            // 
            this.IsMinorRaceCheckBox.AutoSize = true;
            this.IsMinorRaceCheckBox.Location = new System.Drawing.Point(207, 178);
            this.IsMinorRaceCheckBox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.IsMinorRaceCheckBox.Name = "IsMinorRaceCheckBox";
            this.IsMinorRaceCheckBox.Size = new System.Drawing.Size(15, 14);
            this.IsMinorRaceCheckBox.TabIndex = 8;
            this.IsMinorRaceCheckBox.CheckedChanged += new System.EventHandler(this.isMinorRaceCheckChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.nameLabel.Location = new System.Drawing.Point(3, 38);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 15);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.descriptionTextBox.Location = new System.Drawing.Point(207, 62);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(480, 105);
            this.descriptionTextBox.TabIndex = 4;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.nameTextBox.Location = new System.Drawing.Point(207, 33);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(124, 23);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextChanged);
            // 
            // statsTabPage
            // 
            this.statsTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.statsTabPage.Controls.Add(this.tableLayoutPanel2);
            this.statsTabPage.Location = new System.Drawing.Point(139, 4);
            this.statsTabPage.Name = "statsTabPage";
            this.statsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.statsTabPage.Size = new System.Drawing.Size(735, 501);
            this.statsTabPage.TabIndex = 1;
            this.statsTabPage.Text = "Stats";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.consumedTraitComboBox, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.defaultTraitsComboBox, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.warforgedChanceTextBox, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.pacifistChanceTextBox, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.naturalLeagueChanceTextBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.emporiumChanceTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label20, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.label19, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.ideologyChanceTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.protestingApprovalThresholdTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.criminalChanceTextBox, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 8);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(456, 272);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // consumedTraitComboBox
            // 
            this.consumedTraitComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.consumedTraitComboBox.FormattingEnabled = true;
            this.consumedTraitComboBox.Location = new System.Drawing.Point(176, 236);
            this.consumedTraitComboBox.Name = "consumedTraitComboBox";
            this.consumedTraitComboBox.Size = new System.Drawing.Size(255, 24);
            this.consumedTraitComboBox.TabIndex = 34;
            this.consumedTraitComboBox.SelectedValueChanged += new System.EventHandler(this.consumedTraitSelected);
            // 
            // defaultTraitsComboBox
            // 
            this.defaultTraitsComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.defaultTraitsComboBox.FormattingEnabled = true;
            this.defaultTraitsComboBox.Location = new System.Drawing.Point(176, 206);
            this.defaultTraitsComboBox.Name = "defaultTraitsComboBox";
            this.defaultTraitsComboBox.Size = new System.Drawing.Size(255, 24);
            this.defaultTraitsComboBox.TabIndex = 33;
            this.defaultTraitsComboBox.SelectedValueChanged += new System.EventHandler(this.defaultTraitSelected);
            // 
            // warforgedChanceTextBox
            // 
            this.warforgedChanceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.warforgedChanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.warforgedChanceTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.warforgedChanceTextBox.Location = new System.Drawing.Point(176, 177);
            this.warforgedChanceTextBox.Name = "warforgedChanceTextBox";
            this.warforgedChanceTextBox.Size = new System.Drawing.Size(124, 23);
            this.warforgedChanceTextBox.TabIndex = 28;
            this.warforgedChanceTextBox.Text = "0";
            this.warforgedChanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.warforgedChanceTextBox.TextChanged += new System.EventHandler(this.warforgedChanceTextChanged);
            // 
            // pacifistChanceTextBox
            // 
            this.pacifistChanceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.pacifistChanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pacifistChanceTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.pacifistChanceTextBox.Location = new System.Drawing.Point(176, 148);
            this.pacifistChanceTextBox.Name = "pacifistChanceTextBox";
            this.pacifistChanceTextBox.Size = new System.Drawing.Size(124, 23);
            this.pacifistChanceTextBox.TabIndex = 26;
            this.pacifistChanceTextBox.Text = "0";
            this.pacifistChanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pacifistChanceTextBox.TextChanged += new System.EventHandler(this.pacifistChanceTextChanged);
            // 
            // naturalLeagueChanceTextBox
            // 
            this.naturalLeagueChanceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.naturalLeagueChanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.naturalLeagueChanceTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.naturalLeagueChanceTextBox.Location = new System.Drawing.Point(176, 119);
            this.naturalLeagueChanceTextBox.Name = "naturalLeagueChanceTextBox";
            this.naturalLeagueChanceTextBox.Size = new System.Drawing.Size(124, 23);
            this.naturalLeagueChanceTextBox.TabIndex = 27;
            this.naturalLeagueChanceTextBox.Text = "0";
            this.naturalLeagueChanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.naturalLeagueChanceTextBox.TextChanged += new System.EventHandler(this.naturalLeagueChanceTextChanged);
            // 
            // emporiumChanceTextBox
            // 
            this.emporiumChanceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.emporiumChanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emporiumChanceTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.emporiumChanceTextBox.Location = new System.Drawing.Point(176, 90);
            this.emporiumChanceTextBox.Name = "emporiumChanceTextBox";
            this.emporiumChanceTextBox.Size = new System.Drawing.Size(124, 23);
            this.emporiumChanceTextBox.TabIndex = 25;
            this.emporiumChanceTextBox.Text = "0.1";
            this.emporiumChanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.emporiumChanceTextBox.TextChanged += new System.EventHandler(this.emporiumChanceTextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label20.Location = new System.Drawing.Point(3, 241);
            this.label20.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 15);
            this.label20.TabIndex = 26;
            this.label20.Text = "Consumed Trait";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label19.Location = new System.Drawing.Point(3, 211);
            this.label19.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 15);
            this.label19.TabIndex = 25;
            this.label19.Text = "Default Traits";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label13.Location = new System.Drawing.Point(3, 153);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "Pacifist Chance";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label12.Location = new System.Drawing.Point(3, 124);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "Natural League Chance";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label11.Location = new System.Drawing.Point(3, 95);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Emporium Chance";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label10.Location = new System.Drawing.Point(3, 66);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Criminal Chance";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ideologyChanceTextBox
            // 
            this.ideologyChanceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.ideologyChanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ideologyChanceTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ideologyChanceTextBox.Location = new System.Drawing.Point(176, 32);
            this.ideologyChanceTextBox.Name = "ideologyChanceTextBox";
            this.ideologyChanceTextBox.Size = new System.Drawing.Size(124, 23);
            this.ideologyChanceTextBox.TabIndex = 19;
            this.ideologyChanceTextBox.Text = "0.2";
            this.ideologyChanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ideologyChanceTextBox.TextChanged += new System.EventHandler(this.ideologyChanceTextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label9.Location = new System.Drawing.Point(3, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ideology Chance";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Protesting Approval Threshold";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // protestingApprovalThresholdTextBox
            // 
            this.protestingApprovalThresholdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.protestingApprovalThresholdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.protestingApprovalThresholdTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.protestingApprovalThresholdTextBox.Location = new System.Drawing.Point(176, 3);
            this.protestingApprovalThresholdTextBox.Name = "protestingApprovalThresholdTextBox";
            this.protestingApprovalThresholdTextBox.Size = new System.Drawing.Size(124, 23);
            this.protestingApprovalThresholdTextBox.TabIndex = 16;
            this.protestingApprovalThresholdTextBox.Text = "0.25";
            this.protestingApprovalThresholdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.protestingApprovalThresholdTextBox.TextChanged += new System.EventHandler(this.protestingApprovalTextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label14.Location = new System.Drawing.Point(3, 182);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 15);
            this.label14.TabIndex = 24;
            this.label14.Text = "Warforged Chance";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // criminalChanceTextBox
            // 
            this.criminalChanceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.criminalChanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.criminalChanceTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.criminalChanceTextBox.Location = new System.Drawing.Point(176, 61);
            this.criminalChanceTextBox.Name = "criminalChanceTextBox";
            this.criminalChanceTextBox.Size = new System.Drawing.Size(124, 23);
            this.criminalChanceTextBox.TabIndex = 20;
            this.criminalChanceTextBox.Text = "0.1";
            this.criminalChanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.criminalChanceTextBox.TextChanged += new System.EventHandler(this.criminalChanceTextChanged);
            // 
            // modifiersTabPage
            // 
            this.modifiersTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.modifiersTabPage.Controls.Add(this.approvalModifiersListView);
            this.modifiersTabPage.Controls.Add(this.removeApprovalModifiersButton);
            this.modifiersTabPage.Controls.Add(this.addApprovalModifiersButton);
            this.modifiersTabPage.Controls.Add(this.label18);
            this.modifiersTabPage.Controls.Add(this.removeColonyStatButton);
            this.modifiersTabPage.Controls.Add(this.addColonyStatButton);
            this.modifiersTabPage.Controls.Add(this.colonyStatsListView);
            this.modifiersTabPage.Controls.Add(this.label17);
            this.modifiersTabPage.Controls.Add(this.removeGlobalStatButton);
            this.modifiersTabPage.Controls.Add(this.addGlobalStatButton);
            this.modifiersTabPage.Controls.Add(this.globalStatslistView);
            this.modifiersTabPage.Controls.Add(this.label16);
            this.modifiersTabPage.Location = new System.Drawing.Point(139, 4);
            this.modifiersTabPage.Name = "modifiersTabPage";
            this.modifiersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.modifiersTabPage.Size = new System.Drawing.Size(735, 501);
            this.modifiersTabPage.TabIndex = 2;
            this.modifiersTabPage.Text = "Modifiers";
            // 
            // approvalModifiersListView
            // 
            this.approvalModifiersListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.approvalModifiersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.approvalModifierTypeColumnHeader,
            this.approvalModifierTagColumnHeader,
            this.approvalModifierValueColumnHeader});
            this.approvalModifiersListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.approvalModifiersListView.Location = new System.Drawing.Point(315, 35);
            this.approvalModifiersListView.MultiSelect = false;
            this.approvalModifiersListView.Name = "approvalModifiersListView";
            this.approvalModifiersListView.Size = new System.Drawing.Size(384, 210);
            this.approvalModifiersListView.TabIndex = 41;
            this.approvalModifiersListView.UseCompatibleStateImageBehavior = false;
            this.approvalModifiersListView.View = System.Windows.Forms.View.Details;
            this.approvalModifiersListView.DoubleClick += new System.EventHandler(this.approvalModifiersDoubleClicked);
            // 
            // approvalModifierTypeColumnHeader
            // 
            this.approvalModifierTypeColumnHeader.Text = "Type";
            this.approvalModifierTypeColumnHeader.Width = 200;
            // 
            // approvalModifierTagColumnHeader
            // 
            this.approvalModifierTagColumnHeader.Text = "Tag";
            this.approvalModifierTagColumnHeader.Width = 125;
            // 
            // approvalModifierValueColumnHeader
            // 
            this.approvalModifierValueColumnHeader.Text = "Value";
            this.approvalModifierValueColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.approvalModifierValueColumnHeader.Width = 55;
            // 
            // removeApprovalModifiersButton
            // 
            this.removeApprovalModifiersButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeApprovalModifiersButton.BackgroundImage")));
            this.removeApprovalModifiersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeApprovalModifiersButton.Location = new System.Drawing.Point(705, 74);
            this.removeApprovalModifiersButton.Name = "removeApprovalModifiersButton";
            this.removeApprovalModifiersButton.Size = new System.Drawing.Size(24, 24);
            this.removeApprovalModifiersButton.TabIndex = 40;
            this.removeApprovalModifiersButton.TabStop = false;
            this.removeApprovalModifiersButton.Click += new System.EventHandler(this.removeApprovalModifiersButton_Click);
            this.removeApprovalModifiersButton.MouseHover += new System.EventHandler(this.removeApprovalModifiersButtonHover);
            // 
            // addApprovalModifiersButton
            // 
            this.addApprovalModifiersButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addApprovalModifiersButton.BackgroundImage")));
            this.addApprovalModifiersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addApprovalModifiersButton.Location = new System.Drawing.Point(705, 35);
            this.addApprovalModifiersButton.Name = "addApprovalModifiersButton";
            this.addApprovalModifiersButton.Size = new System.Drawing.Size(24, 24);
            this.addApprovalModifiersButton.TabIndex = 39;
            this.addApprovalModifiersButton.TabStop = false;
            this.addApprovalModifiersButton.Click += new System.EventHandler(this.addApprovalModifiersButton_Click);
            this.addApprovalModifiersButton.MouseHover += new System.EventHandler(this.addApprovalModifiersButtonHover);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label18.Location = new System.Drawing.Point(315, 15);
            this.label18.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(108, 15);
            this.label18.TabIndex = 37;
            this.label18.Text = "Approval Modifiers";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // removeColonyStatButton
            // 
            this.removeColonyStatButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeColonyStatButton.BackgroundImage")));
            this.removeColonyStatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeColonyStatButton.Location = new System.Drawing.Point(575, 320);
            this.removeColonyStatButton.Name = "removeColonyStatButton";
            this.removeColonyStatButton.Size = new System.Drawing.Size(24, 24);
            this.removeColonyStatButton.TabIndex = 36;
            this.removeColonyStatButton.TabStop = false;
            this.removeColonyStatButton.Click += new System.EventHandler(this.removeColonyStatButton_Click);
            this.removeColonyStatButton.MouseHover += new System.EventHandler(this.removeColonyStatButtonHover);
            // 
            // addColonyStatButton
            // 
            this.addColonyStatButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addColonyStatButton.BackgroundImage")));
            this.addColonyStatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addColonyStatButton.Location = new System.Drawing.Point(575, 280);
            this.addColonyStatButton.Name = "addColonyStatButton";
            this.addColonyStatButton.Size = new System.Drawing.Size(24, 24);
            this.addColonyStatButton.TabIndex = 35;
            this.addColonyStatButton.TabStop = false;
            this.addColonyStatButton.Click += new System.EventHandler(this.addColonyStatButton_Click);
            this.addColonyStatButton.MouseHover += new System.EventHandler(this.addColonyStatButtonHover);
            // 
            // colonyStatsListView
            // 
            this.colonyStatsListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.colonyStatsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colonyEffectTypeHeader,
            this.colonyValueHeader,
            this.colonyValueTypeHeader,
            this.colonyStringParamHeader,
            this.valueParam1Header,
            this.valueParam2Header});
            this.colonyStatsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.colonyStatsListView.Location = new System.Drawing.Point(6, 280);
            this.colonyStatsListView.MultiSelect = false;
            this.colonyStatsListView.Name = "colonyStatsListView";
            this.colonyStatsListView.Size = new System.Drawing.Size(563, 210);
            this.colonyStatsListView.TabIndex = 34;
            this.colonyStatsListView.UseCompatibleStateImageBehavior = false;
            this.colonyStatsListView.View = System.Windows.Forms.View.Details;
            this.colonyStatsListView.DoubleClick += new System.EventHandler(this.colonyStatsDoubleClicked);
            // 
            // colonyEffectTypeHeader
            // 
            this.colonyEffectTypeHeader.Text = "Effect Type";
            this.colonyEffectTypeHeader.Width = 150;
            // 
            // colonyValueHeader
            // 
            this.colonyValueHeader.Text = "Value";
            this.colonyValueHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colonyValueTypeHeader
            // 
            this.colonyValueTypeHeader.Text = "ValueType";
            this.colonyValueTypeHeader.Width = 75;
            // 
            // colonyStringParamHeader
            // 
            this.colonyStringParamHeader.Text = "Resource";
            this.colonyStringParamHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colonyStringParamHeader.Width = 100;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label17.Location = new System.Drawing.Point(9, 256);
            this.label17.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 15);
            this.label17.TabIndex = 33;
            this.label17.Text = "Colony Stats";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // removeGlobalStatButton
            // 
            this.removeGlobalStatButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeGlobalStatButton.BackgroundImage")));
            this.removeGlobalStatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeGlobalStatButton.Location = new System.Drawing.Point(262, 76);
            this.removeGlobalStatButton.Name = "removeGlobalStatButton";
            this.removeGlobalStatButton.Size = new System.Drawing.Size(24, 24);
            this.removeGlobalStatButton.TabIndex = 32;
            this.removeGlobalStatButton.TabStop = false;
            this.removeGlobalStatButton.Click += new System.EventHandler(this.removeGlobalStatButton_Click);
            this.removeGlobalStatButton.MouseHover += new System.EventHandler(this.removeGlobalStatButtonHover);
            // 
            // addGlobalStatButton
            // 
            this.addGlobalStatButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addGlobalStatButton.BackgroundImage")));
            this.addGlobalStatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addGlobalStatButton.Location = new System.Drawing.Point(262, 35);
            this.addGlobalStatButton.Name = "addGlobalStatButton";
            this.addGlobalStatButton.Size = new System.Drawing.Size(24, 24);
            this.addGlobalStatButton.TabIndex = 31;
            this.addGlobalStatButton.TabStop = false;
            this.addGlobalStatButton.Click += new System.EventHandler(this.addGlobalStatButton_Click);
            this.addGlobalStatButton.MouseHover += new System.EventHandler(this.addGlobalStatsButtonHover);
            // 
            // globalStatslistView
            // 
            this.globalStatslistView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.globalStatslistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.effectTypeHeader,
            this.valueHeader});
            this.globalStatslistView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.globalStatslistView.Location = new System.Drawing.Point(6, 35);
            this.globalStatslistView.MultiSelect = false;
            this.globalStatslistView.Name = "globalStatslistView";
            this.globalStatslistView.Size = new System.Drawing.Size(250, 210);
            this.globalStatslistView.TabIndex = 30;
            this.globalStatslistView.UseCompatibleStateImageBehavior = false;
            this.globalStatslistView.View = System.Windows.Forms.View.Details;
            this.globalStatslistView.DoubleClick += new System.EventHandler(this.globalStatsDoubleClicked);
            // 
            // effectTypeHeader
            // 
            this.effectTypeHeader.Text = "EffectType";
            this.effectTypeHeader.Width = 150;
            // 
            // valueHeader
            // 
            this.valueHeader.Text = "Value";
            this.valueHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valueHeader.Width = 75;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label16.Location = new System.Drawing.Point(9, 11);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 15);
            this.label16.TabIndex = 29;
            this.label16.Text = "Global Stats";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // citizenRaceBindingSource1
            // 
            this.citizenRaceBindingSource1.DataSource = typeof(ModTools.Model.Race.CitizenRace);
            // 
            // saveRaceButton
            // 
            this.saveRaceButton.AutoSize = true;
            this.saveRaceButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveRaceButton.Location = new System.Drawing.Point(820, 527);
            this.saveRaceButton.Name = "saveRaceButton";
            this.saveRaceButton.Padding = new System.Windows.Forms.Padding(5);
            this.saveRaceButton.Size = new System.Drawing.Size(100, 41);
            this.saveRaceButton.TabIndex = 2;
            this.saveRaceButton.Text = "Save Race";
            this.saveRaceButton.Click += new System.EventHandler(this.saveRaceButton_Click);
            // 
            // valueParam1Header
            // 
            this.valueParam1Header.Text = "ValueParam1";
            this.valueParam1Header.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valueParam1Header.Width = 75;
            // 
            // valueParam2Header
            // 
            this.valueParam2Header.Text = "ValueParam2";
            this.valueParam2Header.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valueParam2Header.Width = 75;
            // 
            // RaceEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 579);
            this.Controls.Add(this.saveRaceButton);
            this.Controls.Add(this.tabPage1);
            this.Name = "RaceEditorForm";
            this.Text = "Race Editor";
            this.Click += new System.EventHandler(this.managePortraitsClicked);
            ((System.ComponentModel.ISupportInitialize)(this.citizenRaceBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.generalInfoTabPage.ResumeLayout(false);
            this.generalInfoTabPage.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.militaryAdvisorPortraitPictureBox)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scienceAdvisorPortraitPictureBox)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colonizationAdvisorPortraitPictureBox)).EndInit();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genericImagePictureBox)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.politicalAdvisorPortraitPictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statsTabPage.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.modifiersTabPage.ResumeLayout(false);
            this.modifiersTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeApprovalModifiersButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addApprovalModifiersButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeColonyStatButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addColonyStatButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeGlobalStatButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addGlobalStatButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citizenRaceBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BindingSource citizenRaceBindingSource;
        private ToolTip toolTip1;
        private ReaLTaiizor.Controls.TabPage tabPage1;
        private System.Windows.Forms.TabPage generalInfoTabPage;
        private Panel panel3;
        private CrownLabel label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox militaryAdvisorPortraitPictureBox;
        private CrownLabel label4;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox scienceAdvisorPortraitPictureBox;
        private CrownLabel label5;
        private FlowLayoutPanel flowLayoutPanel3;
        private PictureBox colonizationAdvisorPortraitPictureBox;
        private CrownLabel label6;
        private FlowLayoutPanel flowLayoutPanel5;
        private PictureBox genericImagePictureBox;
        private CrownLabel label8;
        private FlowLayoutPanel flowLayoutPanel4;
        private PictureBox politicalAdvisorPortraitPictureBox;
        private CrownLabel label7;
        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox hasGenderCheckBox;
        private CrownLabel label15;
        private CrownLabel descriptionLabel;
        private CrownLabel nameLabel;
        private CrownTextBox nameTextBox;
        private CrownTextBox descriptionTextBox;
        private CrownLabel label2;
        private CheckBox IsMinorRaceCheckBox;
        private System.Windows.Forms.TabPage statsTabPage;
        private TableLayoutPanel tableLayoutPanel2;
        private CrownComboBox consumedTraitComboBox;
        private CrownComboBox defaultTraitsComboBox;
        private CrownTextBox warforgedChanceTextBox;
        private CrownTextBox pacifistChanceTextBox;
        private CrownTextBox naturalLeagueChanceTextBox;
        private CrownTextBox emporiumChanceTextBox;
        private CrownLabel label20;
        private CrownLabel label19;
        private CrownLabel label13;
        private CrownLabel label12;
        private CrownLabel label11;
        private CrownLabel label10;
        private CrownTextBox ideologyChanceTextBox;
        private CrownLabel label9;
        private CrownLabel label1;
        private CrownTextBox protestingApprovalThresholdTextBox;
        private CrownLabel label14;
        private CrownTextBox criminalChanceTextBox;
        private System.Windows.Forms.TabPage modifiersTabPage;
        private PictureBox removeApprovalModifiersButton;
        private PictureBox addApprovalModifiersButton;
        private CrownLabel label18;
        private PictureBox removeColonyStatButton;
        private PictureBox addColonyStatButton;
        private ListView colonyStatsListView;
        private ColumnHeader colonyEffectTypeHeader;
        private ColumnHeader colonyValueHeader;
        private ColumnHeader colonyValueTypeHeader;
        private ColumnHeader colonyStringParamHeader;
        private CrownLabel label17;
        private PictureBox removeGlobalStatButton;
        private PictureBox addGlobalStatButton;
        private ListView globalStatslistView;
        private ColumnHeader effectTypeHeader;
        private ColumnHeader valueHeader;
        private CrownLabel label16;
        private BindingSource citizenRaceBindingSource1;
        private CrownLabel crownLabel2;
        private ListView approvalModifiersListView;
        private ColumnHeader approvalModifierTypeColumnHeader;
        private ColumnHeader approvalModifierTagColumnHeader;
        private ColumnHeader approvalModifierValueColumnHeader;
        private Button saveRaceButton;
        private CrownButton manageCitizenPortraitsButton;
        private CrownComboBox modTypeComboBox;
        private CrownLabel crownLabel3;
        private CrownComboBox raceComboBox;
        private CrownLabel crownLabel4;
        private ColumnHeader valueParam1Header;
        private ColumnHeader valueParam2Header;
    }
}