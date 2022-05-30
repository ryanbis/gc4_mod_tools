namespace ModTools.View
{
    partial class OrbitBodyForm
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new ReaLTaiizor.Controls.CrownLabel();
            this.bodyTypeComboBox = new ReaLTaiizor.Controls.CrownComboBox();
            this.saveButton = new ReaLTaiizor.Controls.CrownButton();
            this.isHomeworldTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new ReaLTaiizor.Controls.CrownLabel();
            this.isHomeworldCheckBox = new ReaLTaiizor.Controls.CrownCheckBox();
            this.tableLayoutPanel.SuspendLayout();
            this.isHomeworldTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.bodyTypeComboBox, 1, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(382, 39);
            this.tableLayoutPanel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Body Type";
            // 
            // bodyTypeComboBox
            // 
            this.bodyTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.bodyTypeComboBox.FormattingEnabled = true;
            this.bodyTypeComboBox.Location = new System.Drawing.Point(199, 3);
            this.bodyTypeComboBox.Margin = new System.Windows.Forms.Padding(8, 3, 3, 8);
            this.bodyTypeComboBox.Name = "bodyTypeComboBox";
            this.bodyTypeComboBox.Size = new System.Drawing.Size(173, 24);
            this.bodyTypeComboBox.TabIndex = 2;
            this.bodyTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.bodyTypeIndexSelected);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(415, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Padding = new System.Windows.Forms.Padding(5);
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButtonClicked);
            // 
            // isHomeworldTablePanel
            // 
            this.isHomeworldTablePanel.ColumnCount = 2;
            this.isHomeworldTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.isHomeworldTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.isHomeworldTablePanel.Controls.Add(this.label2, 0, 0);
            this.isHomeworldTablePanel.Controls.Add(this.isHomeworldCheckBox, 1, 0);
            this.isHomeworldTablePanel.Location = new System.Drawing.Point(12, 57);
            this.isHomeworldTablePanel.Name = "isHomeworldTablePanel";
            this.isHomeworldTablePanel.RowCount = 1;
            this.isHomeworldTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.isHomeworldTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.isHomeworldTablePanel.Size = new System.Drawing.Size(382, 41);
            this.isHomeworldTablePanel.TabIndex = 10;
            this.isHomeworldTablePanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Is Homeworld";
            // 
            // isHomeworldCheckBox
            // 
            this.isHomeworldCheckBox.AutoSize = true;
            this.isHomeworldCheckBox.Location = new System.Drawing.Point(199, 12);
            this.isHomeworldCheckBox.Margin = new System.Windows.Forms.Padding(8, 12, 3, 3);
            this.isHomeworldCheckBox.Name = "isHomeworldCheckBox";
            this.isHomeworldCheckBox.Size = new System.Drawing.Size(15, 14);
            this.isHomeworldCheckBox.TabIndex = 2;
            // 
            // OrbitBodyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(523, 142);
            this.Controls.Add(this.isHomeworldTablePanel);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.saveButton);
            this.Name = "OrbitBodyForm";
            this.Text = "OrbitBodyForm";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.isHomeworldTablePanel.ResumeLayout(false);
            this.isHomeworldTablePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private ReaLTaiizor.Controls.CrownLabel label1;
        private ReaLTaiizor.Controls.CrownComboBox bodyTypeComboBox;
        private ReaLTaiizor.Controls.CrownButton saveButton;
        private TableLayoutPanel isHomeworldTablePanel;
        private ReaLTaiizor.Controls.CrownLabel label2;
        private ReaLTaiizor.Controls.CrownCheckBox isHomeworldCheckBox;
    }
}