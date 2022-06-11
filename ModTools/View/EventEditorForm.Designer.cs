namespace ModTools.View
{
    partial class EventEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventEditorForm));
            this.saveAllButton = new ReaLTaiizor.Controls.CrownButton();
            this.addCurrentEventButton = new ReaLTaiizor.Controls.CrownButton();
            this.removeEventsButton = new System.Windows.Forms.PictureBox();
            this.crownLabel8 = new ReaLTaiizor.Controls.CrownLabel();
            this.currentEventsListView = new System.Windows.Forms.ListView();
            this.tabPage1 = new ReaLTaiizor.Controls.TabPage();
            this.configTabPage = new System.Windows.Forms.TabPage();
            this.showImmediatelyCheckBox = new ReaLTaiizor.Controls.CrownCheckBox();
            this.crownLabel24 = new ReaLTaiizor.Controls.CrownLabel();
            this.shouldInterruptOtherScreensCheckBox = new ReaLTaiizor.Controls.CrownCheckBox();
            this.crownLabel23 = new ReaLTaiizor.Controls.CrownLabel();
            this.weightLabel = new ReaLTaiizor.Controls.CrownLabel();
            this.weightTextBox = new ReaLTaiizor.Controls.CrownTextBox();
            this.modTypeComboBox = new ReaLTaiizor.Controls.CrownComboBox();
            this.crownLabel16 = new ReaLTaiizor.Controls.CrownLabel();
            this.crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            this.eventTypeComboBox = new ReaLTaiizor.Controls.CrownComboBox();
            this.generalInfoTabPage = new System.Windows.Forms.TabPage();
            this.addBackgroundImageButton = new System.Windows.Forms.PictureBox();
            this.backgroundPictureBox = new System.Windows.Forms.PictureBox();
            this.crownLabel22 = new ReaLTaiizor.Controls.CrownLabel();
            this.windowTitleTextBox = new ReaLTaiizor.Controls.CrownTextBox();
            this.crownLabel21 = new ReaLTaiizor.Controls.CrownLabel();
            this.starSystemDescriptionLabel = new ReaLTaiizor.Controls.CrownLabel();
            this.eventDescriptionTextBox = new ReaLTaiizor.Controls.CrownTextBox();
            this.eventNameTextBox = new ReaLTaiizor.Controls.CrownTextBox();
            this.crownLabel2 = new ReaLTaiizor.Controls.CrownLabel();
            this.choicesTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.choiceBonusDescriptionTextBox = new ReaLTaiizor.Controls.CrownTextBox();
            this.crownLabel6 = new ReaLTaiizor.Controls.CrownLabel();
            this.crownLabel5 = new ReaLTaiizor.Controls.CrownLabel();
            this.crownLabel3 = new ReaLTaiizor.Controls.CrownLabel();
            this.culturalAlignmentTypeComboBox = new ReaLTaiizor.Controls.CrownComboBox();
            this.choiceDescriptionTextBox = new ReaLTaiizor.Controls.CrownTextBox();
            this.crownLabel4 = new ReaLTaiizor.Controls.CrownLabel();
            this.removeChoiceButton = new System.Windows.Forms.PictureBox();
            this.addChoiceButton = new System.Windows.Forms.PictureBox();
            this.choicesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.crownLabel7 = new ReaLTaiizor.Controls.CrownLabel();
            this.crownLabel9 = new ReaLTaiizor.Controls.CrownLabel();
            this.removeTriggerButton = new System.Windows.Forms.PictureBox();
            this.addTriggerButton = new System.Windows.Forms.PictureBox();
            this.triggersListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.removeEventsButton)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.configTabPage.SuspendLayout();
            this.generalInfoTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addBackgroundImageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).BeginInit();
            this.choicesTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeChoiceButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addChoiceButton)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeTriggerButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addTriggerButton)).BeginInit();
            this.SuspendLayout();
            // 
            // saveAllButton
            // 
            this.saveAllButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveAllButton.Location = new System.Drawing.Point(830, 381);
            this.saveAllButton.Name = "saveAllButton";
            this.saveAllButton.Padding = new System.Windows.Forms.Padding(5);
            this.saveAllButton.Size = new System.Drawing.Size(213, 49);
            this.saveAllButton.TabIndex = 47;
            this.saveAllButton.Text = "Save All";
            this.saveAllButton.Click += new System.EventHandler(this.saveAllButtonClicked);
            // 
            // addCurrentEventButton
            // 
            this.addCurrentEventButton.AutoSize = true;
            this.addCurrentEventButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCurrentEventButton.Location = new System.Drawing.Point(835, 214);
            this.addCurrentEventButton.Name = "addCurrentEventButton";
            this.addCurrentEventButton.Padding = new System.Windows.Forms.Padding(5);
            this.addCurrentEventButton.Size = new System.Drawing.Size(183, 41);
            this.addCurrentEventButton.TabIndex = 46;
            this.addCurrentEventButton.Text = "Add Current Event";
            this.addCurrentEventButton.Click += new System.EventHandler(this.addCurrentEventButtonClicked);
            // 
            // removeEventsButton
            // 
            this.removeEventsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeEventsButton.BackgroundImage")));
            this.removeEventsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeEventsButton.Location = new System.Drawing.Point(1024, 52);
            this.removeEventsButton.Name = "removeEventsButton";
            this.removeEventsButton.Size = new System.Drawing.Size(24, 24);
            this.removeEventsButton.TabIndex = 45;
            this.removeEventsButton.TabStop = false;
            this.removeEventsButton.Click += new System.EventHandler(this.removeEventsButtonClicked);
            // 
            // crownLabel8
            // 
            this.crownLabel8.AutoSize = true;
            this.crownLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.crownLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownLabel8.Location = new System.Drawing.Point(835, 12);
            this.crownLabel8.Name = "crownLabel8";
            this.crownLabel8.Size = new System.Drawing.Size(121, 21);
            this.crownLabel8.TabIndex = 44;
            this.crownLabel8.Text = "Current Events";
            // 
            // currentEventsListView
            // 
            this.currentEventsListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.currentEventsListView.Location = new System.Drawing.Point(835, 52);
            this.currentEventsListView.Name = "currentEventsListView";
            this.currentEventsListView.Size = new System.Drawing.Size(183, 146);
            this.currentEventsListView.TabIndex = 43;
            this.currentEventsListView.UseCompatibleStateImageBehavior = false;
            this.currentEventsListView.View = System.Windows.Forms.View.List;
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
            this.tabPage1.Controls.Add(this.configTabPage);
            this.tabPage1.Controls.Add(this.generalInfoTabPage);
            this.tabPage1.Controls.Add(this.choicesTabPage);
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
            this.tabPage1.Size = new System.Drawing.Size(812, 422);
            this.tabPage1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabPage1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.tabPage1.StringType = System.Drawing.StringAlignment.Near;
            this.tabPage1.TabColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.tabPage1.TabIndex = 42;
            // 
            // configTabPage
            // 
            this.configTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.configTabPage.Controls.Add(this.showImmediatelyCheckBox);
            this.configTabPage.Controls.Add(this.crownLabel24);
            this.configTabPage.Controls.Add(this.shouldInterruptOtherScreensCheckBox);
            this.configTabPage.Controls.Add(this.crownLabel23);
            this.configTabPage.Controls.Add(this.weightLabel);
            this.configTabPage.Controls.Add(this.weightTextBox);
            this.configTabPage.Controls.Add(this.modTypeComboBox);
            this.configTabPage.Controls.Add(this.crownLabel16);
            this.configTabPage.Controls.Add(this.crownLabel1);
            this.configTabPage.Controls.Add(this.eventTypeComboBox);
            this.configTabPage.Location = new System.Drawing.Point(139, 4);
            this.configTabPage.Name = "configTabPage";
            this.configTabPage.Size = new System.Drawing.Size(669, 414);
            this.configTabPage.TabIndex = 2;
            this.configTabPage.Text = "Config";
            // 
            // showImmediatelyCheckBox
            // 
            this.showImmediatelyCheckBox.AutoSize = true;
            this.showImmediatelyCheckBox.Location = new System.Drawing.Point(202, 187);
            this.showImmediatelyCheckBox.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.showImmediatelyCheckBox.Name = "showImmediatelyCheckBox";
            this.showImmediatelyCheckBox.Size = new System.Drawing.Size(15, 14);
            this.showImmediatelyCheckBox.TabIndex = 19;
            this.showImmediatelyCheckBox.CheckedChanged += new System.EventHandler(this.showImmediatelyCheckChanged);
            // 
            // crownLabel24
            // 
            this.crownLabel24.AutoSize = true;
            this.crownLabel24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownLabel24.Location = new System.Drawing.Point(12, 186);
            this.crownLabel24.Name = "crownLabel24";
            this.crownLabel24.Size = new System.Drawing.Size(105, 15);
            this.crownLabel24.TabIndex = 18;
            this.crownLabel24.Text = "Show Immediately";
            // 
            // shouldInterruptOtherScreensCheckBox
            // 
            this.shouldInterruptOtherScreensCheckBox.AutoSize = true;
            this.shouldInterruptOtherScreensCheckBox.Location = new System.Drawing.Point(202, 146);
            this.shouldInterruptOtherScreensCheckBox.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.shouldInterruptOtherScreensCheckBox.Name = "shouldInterruptOtherScreensCheckBox";
            this.shouldInterruptOtherScreensCheckBox.Size = new System.Drawing.Size(15, 14);
            this.shouldInterruptOtherScreensCheckBox.TabIndex = 17;
            this.shouldInterruptOtherScreensCheckBox.CheckedChanged += new System.EventHandler(this.shouldInterruptOtherScreensCheckChanged);
            // 
            // crownLabel23
            // 
            this.crownLabel23.AutoSize = true;
            this.crownLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownLabel23.Location = new System.Drawing.Point(12, 145);
            this.crownLabel23.Name = "crownLabel23";
            this.crownLabel23.Size = new System.Drawing.Size(169, 15);
            this.crownLabel23.TabIndex = 16;
            this.crownLabel23.Text = "Should Interrupt Other Screens";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.weightLabel.Location = new System.Drawing.Point(12, 105);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(45, 15);
            this.weightLabel.TabIndex = 15;
            this.weightLabel.Text = "Weight";
            // 
            // weightTextBox
            // 
            this.weightTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.weightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weightTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.weightTextBox.Location = new System.Drawing.Point(202, 103);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(236, 23);
            this.weightTextBox.TabIndex = 14;
            this.weightTextBox.TextChanged += new System.EventHandler(this.weightTextChanged);
            // 
            // modTypeComboBox
            // 
            this.modTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.modTypeComboBox.FormattingEnabled = true;
            this.modTypeComboBox.Items.AddRange(new object[] {
            "Append",
            "Replace"});
            this.modTypeComboBox.Location = new System.Drawing.Point(202, 11);
            this.modTypeComboBox.Name = "modTypeComboBox";
            this.modTypeComboBox.Size = new System.Drawing.Size(236, 24);
            this.modTypeComboBox.TabIndex = 13;
            this.modTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.modTypeSelectedIndexChanged);
            // 
            // crownLabel16
            // 
            this.crownLabel16.AutoSize = true;
            this.crownLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownLabel16.Location = new System.Drawing.Point(12, 14);
            this.crownLabel16.Name = "crownLabel16";
            this.crownLabel16.Size = new System.Drawing.Size(62, 15);
            this.crownLabel16.TabIndex = 12;
            this.crownLabel16.Text = "MOD Type";
            // 
            // crownLabel1
            // 
            this.crownLabel1.AutoSize = true;
            this.crownLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownLabel1.Location = new System.Drawing.Point(12, 59);
            this.crownLabel1.Name = "crownLabel1";
            this.crownLabel1.Size = new System.Drawing.Size(63, 15);
            this.crownLabel1.TabIndex = 11;
            this.crownLabel1.Text = "Event Type";
            // 
            // eventTypeComboBox
            // 
            this.eventTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.eventTypeComboBox.FormattingEnabled = true;
            this.eventTypeComboBox.Location = new System.Drawing.Point(202, 56);
            this.eventTypeComboBox.Name = "eventTypeComboBox";
            this.eventTypeComboBox.Size = new System.Drawing.Size(236, 24);
            this.eventTypeComboBox.TabIndex = 10;
            this.eventTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.eventTypeSelectedIndexChanged);
            // 
            // generalInfoTabPage
            // 
            this.generalInfoTabPage.AutoScroll = true;
            this.generalInfoTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.generalInfoTabPage.Controls.Add(this.addBackgroundImageButton);
            this.generalInfoTabPage.Controls.Add(this.backgroundPictureBox);
            this.generalInfoTabPage.Controls.Add(this.crownLabel22);
            this.generalInfoTabPage.Controls.Add(this.windowTitleTextBox);
            this.generalInfoTabPage.Controls.Add(this.crownLabel21);
            this.generalInfoTabPage.Controls.Add(this.starSystemDescriptionLabel);
            this.generalInfoTabPage.Controls.Add(this.eventDescriptionTextBox);
            this.generalInfoTabPage.Controls.Add(this.eventNameTextBox);
            this.generalInfoTabPage.Controls.Add(this.crownLabel2);
            this.generalInfoTabPage.Location = new System.Drawing.Point(139, 4);
            this.generalInfoTabPage.Name = "generalInfoTabPage";
            this.generalInfoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalInfoTabPage.Size = new System.Drawing.Size(669, 414);
            this.generalInfoTabPage.TabIndex = 0;
            this.generalInfoTabPage.Text = "General Info";
            // 
            // addBackgroundImageButton
            // 
            this.addBackgroundImageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addBackgroundImageButton.BackgroundImage")));
            this.addBackgroundImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBackgroundImageButton.Location = new System.Drawing.Point(123, 233);
            this.addBackgroundImageButton.Name = "addBackgroundImageButton";
            this.addBackgroundImageButton.Size = new System.Drawing.Size(24, 24);
            this.addBackgroundImageButton.TabIndex = 38;
            this.addBackgroundImageButton.TabStop = false;
            this.addBackgroundImageButton.Click += new System.EventHandler(this.addBackgroundImageButtonClicked);
            // 
            // backgroundPictureBox
            // 
            this.backgroundPictureBox.Location = new System.Drawing.Point(123, 233);
            this.backgroundPictureBox.Name = "backgroundPictureBox";
            this.backgroundPictureBox.Size = new System.Drawing.Size(100, 50);
            this.backgroundPictureBox.TabIndex = 13;
            this.backgroundPictureBox.TabStop = false;
            this.backgroundPictureBox.Click += new System.EventHandler(this.backgoundPictureBoxClicked);
            // 
            // crownLabel22
            // 
            this.crownLabel22.AutoSize = true;
            this.crownLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownLabel22.Location = new System.Drawing.Point(6, 233);
            this.crownLabel22.Name = "crownLabel22";
            this.crownLabel22.Size = new System.Drawing.Size(107, 15);
            this.crownLabel22.TabIndex = 12;
            this.crownLabel22.Text = "Background Image";
            // 
            // windowTitleTextBox
            // 
            this.windowTitleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.windowTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.windowTitleTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.windowTitleTextBox.Location = new System.Drawing.Point(123, 56);
            this.windowTitleTextBox.Name = "windowTitleTextBox";
            this.windowTitleTextBox.Size = new System.Drawing.Size(236, 23);
            this.windowTitleTextBox.TabIndex = 11;
            this.windowTitleTextBox.TextChanged += new System.EventHandler(this.windowTitleTextChanged);
            // 
            // crownLabel21
            // 
            this.crownLabel21.AutoSize = true;
            this.crownLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownLabel21.Location = new System.Drawing.Point(6, 58);
            this.crownLabel21.Name = "crownLabel21";
            this.crownLabel21.Size = new System.Drawing.Size(76, 15);
            this.crownLabel21.TabIndex = 10;
            this.crownLabel21.Text = "Window Title";
            // 
            // starSystemDescriptionLabel
            // 
            this.starSystemDescriptionLabel.AutoSize = true;
            this.starSystemDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.starSystemDescriptionLabel.Location = new System.Drawing.Point(6, 107);
            this.starSystemDescriptionLabel.Name = "starSystemDescriptionLabel";
            this.starSystemDescriptionLabel.Size = new System.Drawing.Size(99, 15);
            this.starSystemDescriptionLabel.TabIndex = 7;
            this.starSystemDescriptionLabel.Text = "Event Description";
            // 
            // eventDescriptionTextBox
            // 
            this.eventDescriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.eventDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventDescriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.eventDescriptionTextBox.Location = new System.Drawing.Point(123, 102);
            this.eventDescriptionTextBox.Multiline = true;
            this.eventDescriptionTextBox.Name = "eventDescriptionTextBox";
            this.eventDescriptionTextBox.Size = new System.Drawing.Size(359, 108);
            this.eventDescriptionTextBox.TabIndex = 6;
            this.eventDescriptionTextBox.TextChanged += new System.EventHandler(this.eventDescriptionTextChanged);
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.eventNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.eventNameTextBox.Location = new System.Drawing.Point(123, 11);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(236, 23);
            this.eventNameTextBox.TabIndex = 3;
            this.eventNameTextBox.TextChanged += new System.EventHandler(this.eventNameTextChanged);
            // 
            // crownLabel2
            // 
            this.crownLabel2.AutoSize = true;
            this.crownLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownLabel2.Location = new System.Drawing.Point(6, 16);
            this.crownLabel2.Name = "crownLabel2";
            this.crownLabel2.Size = new System.Drawing.Size(71, 15);
            this.crownLabel2.TabIndex = 2;
            this.crownLabel2.Text = "Event Name";
            // 
            // choicesTabPage
            // 
            this.choicesTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.choicesTabPage.Controls.Add(this.panel1);
            this.choicesTabPage.Controls.Add(this.crownLabel4);
            this.choicesTabPage.Controls.Add(this.removeChoiceButton);
            this.choicesTabPage.Controls.Add(this.addChoiceButton);
            this.choicesTabPage.Controls.Add(this.choicesListView);
            this.choicesTabPage.Location = new System.Drawing.Point(139, 4);
            this.choicesTabPage.Name = "choicesTabPage";
            this.choicesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.choicesTabPage.Size = new System.Drawing.Size(669, 414);
            this.choicesTabPage.TabIndex = 1;
            this.choicesTabPage.Text = "Choices";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.choiceBonusDescriptionTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.crownLabel6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.crownLabel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.crownLabel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.culturalAlignmentTypeComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.choiceDescriptionTextBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(433, 251);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // choiceBonusDescriptionTextBox
            // 
            this.choiceBonusDescriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.choiceBonusDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.choiceBonusDescriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.choiceBonusDescriptionTextBox.Location = new System.Drawing.Point(158, 143);
            this.choiceBonusDescriptionTextBox.Margin = new System.Windows.Forms.Padding(8, 8, 3, 8);
            this.choiceBonusDescriptionTextBox.Multiline = true;
            this.choiceBonusDescriptionTextBox.Name = "choiceBonusDescriptionTextBox";
            this.choiceBonusDescriptionTextBox.Size = new System.Drawing.Size(266, 79);
            this.choiceBonusDescriptionTextBox.TabIndex = 42;
            this.choiceBonusDescriptionTextBox.TextChanged += new System.EventHandler(this.choiceBonusDescriptionTextChanged);
            // 
            // crownLabel6
            // 
            this.crownLabel6.AutoSize = true;
            this.crownLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownLabel6.Location = new System.Drawing.Point(3, 147);
            this.crownLabel6.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.crownLabel6.Name = "crownLabel6";
            this.crownLabel6.Size = new System.Drawing.Size(103, 15);
            this.crownLabel6.TabIndex = 40;
            this.crownLabel6.Text = "Bonus Description";
            // 
            // crownLabel5
            // 
            this.crownLabel5.AutoSize = true;
            this.crownLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownLabel5.Location = new System.Drawing.Point(3, 52);
            this.crownLabel5.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.crownLabel5.Name = "crownLabel5";
            this.crownLabel5.Size = new System.Drawing.Size(67, 15);
            this.crownLabel5.TabIndex = 40;
            this.crownLabel5.Text = "Description";
            // 
            // crownLabel3
            // 
            this.crownLabel3.AutoSize = true;
            this.crownLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownLabel3.Location = new System.Drawing.Point(3, 12);
            this.crownLabel3.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.crownLabel3.Name = "crownLabel3";
            this.crownLabel3.Size = new System.Drawing.Size(135, 15);
            this.crownLabel3.TabIndex = 13;
            this.crownLabel3.Text = "Cultural Alignment Type";
            // 
            // culturalAlignmentTypeComboBox
            // 
            this.culturalAlignmentTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.culturalAlignmentTypeComboBox.FormattingEnabled = true;
            this.culturalAlignmentTypeComboBox.Location = new System.Drawing.Point(158, 8);
            this.culturalAlignmentTypeComboBox.Margin = new System.Windows.Forms.Padding(8, 8, 3, 8);
            this.culturalAlignmentTypeComboBox.Name = "culturalAlignmentTypeComboBox";
            this.culturalAlignmentTypeComboBox.Size = new System.Drawing.Size(266, 24);
            this.culturalAlignmentTypeComboBox.TabIndex = 12;
            this.culturalAlignmentTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.culturalAlignmentTypeSelectedIndexChanged);
            // 
            // choiceDescriptionTextBox
            // 
            this.choiceDescriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.choiceDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.choiceDescriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.choiceDescriptionTextBox.Location = new System.Drawing.Point(158, 48);
            this.choiceDescriptionTextBox.Margin = new System.Windows.Forms.Padding(8, 8, 3, 8);
            this.choiceDescriptionTextBox.Multiline = true;
            this.choiceDescriptionTextBox.Name = "choiceDescriptionTextBox";
            this.choiceDescriptionTextBox.Size = new System.Drawing.Size(266, 79);
            this.choiceDescriptionTextBox.TabIndex = 41;
            this.choiceDescriptionTextBox.TextChanged += new System.EventHandler(this.choiceDescriptionTextChanged);
            // 
            // crownLabel4
            // 
            this.crownLabel4.AutoSize = true;
            this.crownLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.crownLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownLabel4.Location = new System.Drawing.Point(227, 3);
            this.crownLabel4.Name = "crownLabel4";
            this.crownLabel4.Size = new System.Drawing.Size(151, 21);
            this.crownLabel4.TabIndex = 38;
            this.crownLabel4.Text = "Choices (Max of 3)";
            // 
            // removeChoiceButton
            // 
            this.removeChoiceButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeChoiceButton.BackgroundImage")));
            this.removeChoiceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeChoiceButton.Location = new System.Drawing.Point(406, 66);
            this.removeChoiceButton.Name = "removeChoiceButton";
            this.removeChoiceButton.Size = new System.Drawing.Size(24, 24);
            this.removeChoiceButton.TabIndex = 37;
            this.removeChoiceButton.TabStop = false;
            this.removeChoiceButton.Click += new System.EventHandler(this.removeChoiceButtonClicked);
            // 
            // addChoiceButton
            // 
            this.addChoiceButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addChoiceButton.BackgroundImage")));
            this.addChoiceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addChoiceButton.Location = new System.Drawing.Point(406, 27);
            this.addChoiceButton.Name = "addChoiceButton";
            this.addChoiceButton.Size = new System.Drawing.Size(24, 24);
            this.addChoiceButton.TabIndex = 36;
            this.addChoiceButton.TabStop = false;
            this.addChoiceButton.Click += new System.EventHandler(this.addChoiceButtonClicked);
            // 
            // choicesListView
            // 
            this.choicesListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.choicesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.choicesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.choicesListView.Location = new System.Drawing.Point(227, 27);
            this.choicesListView.MultiSelect = false;
            this.choicesListView.Name = "choicesListView";
            this.choicesListView.Size = new System.Drawing.Size(173, 83);
            this.choicesListView.TabIndex = 35;
            this.choicesListView.UseCompatibleStateImageBehavior = false;
            this.choicesListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 120;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crownLabel9);
            this.panel1.Controls.Add(this.removeTriggerButton);
            this.panel1.Controls.Add(this.addTriggerButton);
            this.panel1.Controls.Add(this.triggersListView);
            this.panel1.Controls.Add(this.crownLabel7);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(3, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 295);
            this.panel1.TabIndex = 40;
            // 
            // crownLabel7
            // 
            this.crownLabel7.AutoSize = true;
            this.crownLabel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.crownLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownLabel7.Location = new System.Drawing.Point(221, 0);
            this.crownLabel7.Name = "crownLabel7";
            this.crownLabel7.Size = new System.Drawing.Size(206, 21);
            this.crownLabel7.TabIndex = 40;
            this.crownLabel7.Text = "Currently Selected Choice";
            // 
            // crownLabel9
            // 
            this.crownLabel9.AutoSize = true;
            this.crownLabel9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.crownLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownLabel9.Location = new System.Drawing.Point(442, 38);
            this.crownLabel9.Name = "crownLabel9";
            this.crownLabel9.Size = new System.Drawing.Size(71, 21);
            this.crownLabel9.TabIndex = 44;
            this.crownLabel9.Text = "Triggers";
            // 
            // removeTriggerButton
            // 
            this.removeTriggerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeTriggerButton.BackgroundImage")));
            this.removeTriggerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeTriggerButton.Location = new System.Drawing.Point(621, 101);
            this.removeTriggerButton.Name = "removeTriggerButton";
            this.removeTriggerButton.Size = new System.Drawing.Size(24, 24);
            this.removeTriggerButton.TabIndex = 43;
            this.removeTriggerButton.TabStop = false;
            // 
            // addTriggerButton
            // 
            this.addTriggerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addTriggerButton.BackgroundImage")));
            this.addTriggerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addTriggerButton.Location = new System.Drawing.Point(621, 62);
            this.addTriggerButton.Name = "addTriggerButton";
            this.addTriggerButton.Size = new System.Drawing.Size(24, 24);
            this.addTriggerButton.TabIndex = 42;
            this.addTriggerButton.TabStop = false;
            // 
            // triggersListView
            // 
            this.triggersListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.triggersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.triggersListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.triggersListView.Location = new System.Drawing.Point(442, 62);
            this.triggersListView.MultiSelect = false;
            this.triggersListView.Name = "triggersListView";
            this.triggersListView.Size = new System.Drawing.Size(173, 103);
            this.triggersListView.TabIndex = 41;
            this.triggersListView.UseCompatibleStateImageBehavior = false;
            this.triggersListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 120;
            // 
            // EventEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 477);
            this.Controls.Add(this.saveAllButton);
            this.Controls.Add(this.addCurrentEventButton);
            this.Controls.Add(this.removeEventsButton);
            this.Controls.Add(this.crownLabel8);
            this.Controls.Add(this.currentEventsListView);
            this.Controls.Add(this.tabPage1);
            this.Name = "EventEditorForm";
            this.Text = "ColonizeEventForm";
            ((System.ComponentModel.ISupportInitialize)(this.removeEventsButton)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.configTabPage.ResumeLayout(false);
            this.configTabPage.PerformLayout();
            this.generalInfoTabPage.ResumeLayout(false);
            this.generalInfoTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addBackgroundImageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).EndInit();
            this.choicesTabPage.ResumeLayout(false);
            this.choicesTabPage.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeChoiceButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addChoiceButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeTriggerButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addTriggerButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.CrownButton saveAllButton;
        private ReaLTaiizor.Controls.CrownButton addCurrentEventButton;
        private PictureBox removeEventsButton;
        private ReaLTaiizor.Controls.CrownLabel crownLabel8;
        private ListView currentEventsListView;
        private ReaLTaiizor.Controls.TabPage tabPage1;
        private TabPage generalInfoTabPage;
        private ReaLTaiizor.Controls.CrownLabel starSystemDescriptionLabel;
        private ReaLTaiizor.Controls.CrownTextBox eventDescriptionTextBox;
        private ReaLTaiizor.Controls.CrownTextBox eventNameTextBox;
        private ReaLTaiizor.Controls.CrownLabel crownLabel2;
        private TabPage choicesTabPage;
        private ReaLTaiizor.Controls.CrownTextBox windowTitleTextBox;
        private ReaLTaiizor.Controls.CrownLabel crownLabel21;
        private TabPage configTabPage;
        private PictureBox backgroundPictureBox;
        private ReaLTaiizor.Controls.CrownLabel crownLabel22;
        private ReaLTaiizor.Controls.CrownLabel weightLabel;
        private ReaLTaiizor.Controls.CrownTextBox weightTextBox;
        private ReaLTaiizor.Controls.CrownComboBox modTypeComboBox;
        private ReaLTaiizor.Controls.CrownLabel crownLabel16;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
        private ReaLTaiizor.Controls.CrownComboBox eventTypeComboBox;
        private PictureBox addBackgroundImageButton;
        private ReaLTaiizor.Controls.CrownCheckBox shouldInterruptOtherScreensCheckBox;
        private ReaLTaiizor.Controls.CrownLabel crownLabel23;
        private ReaLTaiizor.Controls.CrownCheckBox showImmediatelyCheckBox;
        private ReaLTaiizor.Controls.CrownLabel crownLabel24;
        private ReaLTaiizor.Controls.CrownLabel crownLabel3;
        private ReaLTaiizor.Controls.CrownComboBox culturalAlignmentTypeComboBox;
        private PictureBox removeChoiceButton;
        private PictureBox addChoiceButton;
        private ListView choicesListView;
        private ColumnHeader columnHeader1;
        private ReaLTaiizor.Controls.CrownLabel crownLabel4;
        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.CrownTextBox choiceBonusDescriptionTextBox;
        private ReaLTaiizor.Controls.CrownLabel crownLabel6;
        private ReaLTaiizor.Controls.CrownLabel crownLabel5;
        private ReaLTaiizor.Controls.CrownTextBox choiceDescriptionTextBox;
        private Panel panel1;
        private ReaLTaiizor.Controls.CrownLabel crownLabel9;
        private PictureBox removeTriggerButton;
        private PictureBox addTriggerButton;
        private ListView triggersListView;
        private ColumnHeader columnHeader2;
        private ReaLTaiizor.Controls.CrownLabel crownLabel7;
    }
}