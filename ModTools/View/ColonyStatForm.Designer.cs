using System.ComponentModel;
using ReaLTaiizor.Controls;
using Panel = System.Windows.Forms.Panel;

namespace ModTools.View;

partial class ColonyStatForm
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
            this.cancelButton = new CrownButton();
            this.saveButton = new CrownButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new CrownLabel();
            this.label5 = new CrownLabel();
            this.effectTypeComboBox = new CrownComboBox();
            this.bonusTypeComboBox = new CrownComboBox();
            this.label3 = new CrownLabel();
            this.label2 = new CrownLabel();
            this.label1 = new CrownLabel();
            this.targetTypeComboBox = new CrownComboBox();
            this.valueTextBox = new CrownTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.specialValueLabel = new CrownLabel();
            this.specialValueCheckBox = new CrownCheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(289, 212);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(380, 212);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.effectTypeComboBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bonusTypeComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.targetTypeComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.valueTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(367, 194);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Special Value";
            // 
            // effectTypeComboBox
            // 
            this.effectTypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.effectTypeComboBox.FormattingEnabled = true;
            this.effectTypeComboBox.Location = new System.Drawing.Point(191, 78);
            this.effectTypeComboBox.Margin = new System.Windows.Forms.Padding(8, 3, 3, 8);
            this.effectTypeComboBox.Name = "effectTypeComboBox";
            this.effectTypeComboBox.Size = new System.Drawing.Size(173, 23);
            this.effectTypeComboBox.TabIndex = 3;
            this.effectTypeComboBox.SelectedValueChanged += new System.EventHandler(this.effectTypeSelected);
            // 
            // bonusTypeComboBox
            // 
            this.bonusTypeComboBox.FormattingEnabled = true;
            this.bonusTypeComboBox.Location = new System.Drawing.Point(191, 40);
            this.bonusTypeComboBox.Margin = new System.Windows.Forms.Padding(8, 3, 3, 8);
            this.bonusTypeComboBox.Name = "bonusTypeComboBox";
            this.bonusTypeComboBox.Size = new System.Drawing.Size(173, 23);
            this.bonusTypeComboBox.TabIndex = 3;
            this.bonusTypeComboBox.SelectedValueChanged += new System.EventHandler(this.bonusTypeSelected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Effect Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bonus Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Target Type";
            // 
            // targetTypeComboBox
            // 
            this.targetTypeComboBox.FormattingEnabled = true;
            this.targetTypeComboBox.Location = new System.Drawing.Point(191, 3);
            this.targetTypeComboBox.Margin = new System.Windows.Forms.Padding(8, 3, 3, 8);
            this.targetTypeComboBox.Name = "targetTypeComboBox";
            this.targetTypeComboBox.Size = new System.Drawing.Size(173, 23);
            this.targetTypeComboBox.TabIndex = 2;
            this.targetTypeComboBox.SelectedValueChanged += new System.EventHandler(this.targetTypeSelected);
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(191, 159);
            this.valueTextBox.Margin = new System.Windows.Forms.Padding(8, 8, 3, 8);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(173, 23);
            this.valueTextBox.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.specialValueLabel);
            this.panel1.Controls.Add(this.specialValueCheckBox);
            this.panel1.Location = new System.Drawing.Point(191, 119);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 8, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 29);
            this.panel1.TabIndex = 7;
            // 
            // specialValueLabel
            // 
            this.specialValueLabel.Location = new System.Drawing.Point(21, -1);
            this.specialValueLabel.Name = "specialValueLabel";
            this.specialValueLabel.Size = new System.Drawing.Size(152, 30);
            this.specialValueLabel.TabIndex = 1;
            // 
            // specialValueCheckBox
            // 
            this.specialValueCheckBox.AutoSize = true;
            this.specialValueCheckBox.Location = new System.Drawing.Point(0, 0);
            this.specialValueCheckBox.Name = "specialValueCheckBox";
            this.specialValueCheckBox.Size = new System.Drawing.Size(15, 14);
            this.specialValueCheckBox.TabIndex = 0;
            // 
            // ColonyStatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 253);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ColonyStatForm";
            this.Text = "ColonyStatForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private CrownButton cancelButton;
    private CrownButton saveButton;
    private TableLayoutPanel tableLayoutPanel1;
    private CrownLabel label6;
    private CrownLabel label5;
    private CrownComboBox effectTypeComboBox;
    private CrownComboBox bonusTypeComboBox;
    private CrownLabel label3;
    private CrownLabel label2;
    private CrownLabel label1;
    private CrownComboBox targetTypeComboBox;
    private CrownTextBox valueTextBox;
    private Panel panel1;
    private CrownLabel specialValueLabel;
    private CrownCheckBox specialValueCheckBox;
}