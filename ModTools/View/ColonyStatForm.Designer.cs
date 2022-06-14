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
            this.saveButton = new ReaLTaiizor.Controls.CrownButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            this.crownLabel2 = new ReaLTaiizor.Controls.CrownLabel();
            this.crownLabel3 = new ReaLTaiizor.Controls.CrownLabel();
            this.crownLabel4 = new ReaLTaiizor.Controls.CrownLabel();
            this.valueParamTextBox2 = new ReaLTaiizor.Controls.CrownTextBox();
            this.label5 = new ReaLTaiizor.Controls.CrownLabel();
            this.effectTypeComboBox = new ModCrownComboBox();
            this.bonusTypeComboBox = new ModCrownComboBox();
            this.label3 = new ReaLTaiizor.Controls.CrownLabel();
            this.label2 = new ReaLTaiizor.Controls.CrownLabel();
            this.label1 = new ReaLTaiizor.Controls.CrownLabel();
            this.targetTypeComboBox = new ModCrownComboBox();
            this.specialValueCheckBox = new ReaLTaiizor.Controls.CrownCheckBox();
            this.valueTextBox = new ReaLTaiizor.Controls.CrownTextBox();
            this.specialTextBox = new ReaLTaiizor.Controls.CrownTextBox();
            this.label6 = new ReaLTaiizor.Controls.CrownLabel();
            this.valueParamTextBox1 = new ReaLTaiizor.Controls.CrownTextBox();
            this.stringParamComboBox = new ReaLTaiizor.Controls.CrownComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(519, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Padding = new System.Windows.Forms.Padding(5);
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.crownLabel1, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.crownLabel2, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.valueTextBox, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.crownLabel3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.valueParamTextBox2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.crownLabel4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.effectTypeComboBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bonusTypeComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.targetTypeComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.specialValueCheckBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.specialTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.valueParamTextBox1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.stringParamComboBox, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(494, 353);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // crownLabel1
            // 
            this.crownLabel1.AutoSize = true;
            this.crownLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.crownLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownLabel1.Location = new System.Drawing.Point(3, 282);
            this.crownLabel1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.crownLabel1.Name = "crownLabel1";
            this.crownLabel1.Size = new System.Drawing.Size(241, 21);
            this.crownLabel1.TabIndex = 7;
            this.crownLabel1.Text = "String Param (Strategic Resource)";
            // 
            // crownLabel2
            // 
            this.crownLabel2.AutoSize = true;
            this.crownLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.crownLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownLabel2.Location = new System.Drawing.Point(3, 243);
            this.crownLabel2.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.crownLabel2.Name = "crownLabel2";
            this.crownLabel2.Size = new System.Drawing.Size(218, 21);
            this.crownLabel2.TabIndex = 8;
            this.crownLabel2.Text = "ValueParam (Increment Value)";
            // 
            // crownLabel3
            // 
            this.crownLabel3.AutoSize = true;
            this.crownLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.crownLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownLabel3.Location = new System.Drawing.Point(3, 204);
            this.crownLabel3.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.crownLabel3.Name = "crownLabel3";
            this.crownLabel3.Size = new System.Drawing.Size(198, 21);
            this.crownLabel3.TabIndex = 9;
            this.crownLabel3.Text = "ValueParam (StartingValue)";
            // 
            // crownLabel4
            // 
            this.crownLabel4.AutoSize = true;
            this.crownLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.crownLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownLabel4.Location = new System.Drawing.Point(3, 165);
            this.crownLabel4.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.crownLabel4.Name = "crownLabel4";
            this.crownLabel4.Size = new System.Drawing.Size(59, 21);
            this.crownLabel4.TabIndex = 10;
            this.crownLabel4.Text = "Special";
            // 
            // valueParamTextBox2
            // 
            this.valueParamTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.valueParamTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valueParamTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.valueParamTextBox2.Location = new System.Drawing.Point(255, 243);
            this.valueParamTextBox2.Margin = new System.Windows.Forms.Padding(8, 8, 3, 8);
            this.valueParamTextBox2.Name = "valueParamTextBox2";
            this.valueParamTextBox2.Size = new System.Drawing.Size(173, 23);
            this.valueParamTextBox2.TabIndex = 10;
            this.valueParamTextBox2.TextChanged += new System.EventHandler(this.valueParam2TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label5.Location = new System.Drawing.Point(3, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Special Value";
            // 
            // effectTypeComboBox
            // 
            this.effectTypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.effectTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.effectTypeComboBox.FormattingEnabled = true;
            this.effectTypeComboBox.Location = new System.Drawing.Point(255, 88);
            this.effectTypeComboBox.Margin = new System.Windows.Forms.Padding(8, 8, 3, 8);
            this.effectTypeComboBox.Name = "effectTypeComboBox";
            this.effectTypeComboBox.Size = new System.Drawing.Size(173, 24);
            this.effectTypeComboBox.TabIndex = 3;
            this.effectTypeComboBox.DrawTextItem += effectTypeComboBoxOnDrawTextItem; 
            this.effectTypeComboBox.SelectedValueChanged += new System.EventHandler(this.effectTypeSelected);
            // 
            // bonusTypeComboBox
            // 
            this.bonusTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.bonusTypeComboBox.FormattingEnabled = true;
            this.bonusTypeComboBox.Location = new System.Drawing.Point(255, 48);
            this.bonusTypeComboBox.Margin = new System.Windows.Forms.Padding(8, 8, 3, 8);
            this.bonusTypeComboBox.Name = "bonusTypeComboBox";
            this.bonusTypeComboBox.Size = new System.Drawing.Size(173, 24);
            this.bonusTypeComboBox.TabIndex = 3;
            this.bonusTypeComboBox.SelectedValueChanged += new System.EventHandler(this.bonusTypeSelected);
            this.bonusTypeComboBox.DrawTextItem += bonusTypeComboBoxOnDrawTextItem;
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label3.Location = new System.Drawing.Point(3, 88);
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
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label2.Location = new System.Drawing.Point(3, 48);
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
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Target Type";
            // 
            // targetTypeComboBox
            // 
            this.targetTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.targetTypeComboBox.FormattingEnabled = true;
            this.targetTypeComboBox.Location = new System.Drawing.Point(255, 8);
            this.targetTypeComboBox.Margin = new System.Windows.Forms.Padding(8, 8, 3, 8);
            this.targetTypeComboBox.Name = "targetTypeComboBox";
            this.targetTypeComboBox.Size = new System.Drawing.Size(173, 24);
            this.targetTypeComboBox.TabIndex = 2;
            this.targetTypeComboBox.SelectedValueChanged += new System.EventHandler(this.targetTypeSelected);
            this.targetTypeComboBox.DrawTextItem += targetTypeComboBoxOnDrawTextItem;
            // 
            this.specialValueCheckBox.AutoSize = true;
            this.specialValueCheckBox.Location = new System.Drawing.Point(255, 130);
            this.specialValueCheckBox.Margin = new System.Windows.Forms.Padding(8, 10, 3, 3);
            this.specialValueCheckBox.Name = "specialValueCheckBox";
            this.specialValueCheckBox.Size = new System.Drawing.Size(15, 14);
            this.specialValueCheckBox.TabIndex = 7;
            this.specialValueCheckBox.CheckedChanged += new System.EventHandler(this.specialValueCheckChanged);
            // 
            // valueTextBox
            // 
            this.valueTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.valueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valueTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.valueTextBox.Location = new System.Drawing.Point(255, 322);
            this.valueTextBox.Margin = new System.Windows.Forms.Padding(8, 8, 3, 8);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(173, 23);
            this.valueTextBox.TabIndex = 4;
            // 
            // specialTextBox
            // 
            this.specialTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.specialTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.specialTextBox.Enabled = false;
            this.specialTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.specialTextBox.Location = new System.Drawing.Point(255, 165);
            this.specialTextBox.Margin = new System.Windows.Forms.Padding(8, 8, 3, 8);
            this.specialTextBox.Name = "specialTextBox";
            this.specialTextBox.Size = new System.Drawing.Size(173, 23);
            this.specialTextBox.TabIndex = 8;
            this.specialTextBox.Text = "StatCalc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label6.Location = new System.Drawing.Point(3, 322);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Value";
            // 
            // valueParamTextBox1
            // 
            this.valueParamTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.valueParamTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valueParamTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.valueParamTextBox1.Location = new System.Drawing.Point(255, 204);
            this.valueParamTextBox1.Margin = new System.Windows.Forms.Padding(8, 8, 3, 8);
            this.valueParamTextBox1.Name = "valueParamTextBox1";
            this.valueParamTextBox1.Size = new System.Drawing.Size(173, 23);
            this.valueParamTextBox1.TabIndex = 9;
            this.valueParamTextBox1.TextChanged += new System.EventHandler(this.valueParam1TextChanged);
            // 
            // stringParamComboBox
            // 
            this.stringParamComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.stringParamComboBox.FormattingEnabled = true;
            this.stringParamComboBox.Location = new System.Drawing.Point(255, 282);
            this.stringParamComboBox.Margin = new System.Windows.Forms.Padding(8, 8, 3, 8);
            this.stringParamComboBox.Name = "stringParamComboBox";
            this.stringParamComboBox.Size = new System.Drawing.Size(173, 24);
            this.stringParamComboBox.TabIndex = 11;
            this.stringParamComboBox.SelectedIndexChanged += new System.EventHandler(this.stringParamIndexSelectedChanged);
            // 
            // ColonyStatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(638, 384);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ColonyStatForm";
            this.Text = "ColonyStatForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private CrownButton saveButton;
    private TableLayoutPanel tableLayoutPanel1;
    private CrownLabel label6;
    private CrownLabel label5;
    private ModCrownComboBox effectTypeComboBox;
    private ModCrownComboBox bonusTypeComboBox;
    private CrownLabel label3;
    private CrownLabel label2;
    private CrownLabel label1;
    private ModCrownComboBox targetTypeComboBox;
    private CrownTextBox valueTextBox;
    private CrownCheckBox specialValueCheckBox;
    private CrownLabel crownLabel1;
    private CrownLabel crownLabel2;
    private CrownLabel crownLabel3;
    private CrownLabel crownLabel4;
    private CrownTextBox valueParamTextBox2;
    private CrownTextBox specialTextBox;
    private CrownTextBox valueParamTextBox1;
    private CrownComboBox stringParamComboBox;
}