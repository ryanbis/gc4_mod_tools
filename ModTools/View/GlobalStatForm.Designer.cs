﻿using System.ComponentModel;
using ReaLTaiizor.Controls;


namespace ModTools.View;

partial class GlobalStatForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.effectTypeComboBox = new ModCrownComboBox();
            this.bonusTypeComboBox = new ModTools.View.ModCrownComboBox();
            this.label4 = new ReaLTaiizor.Controls.CrownLabel();
            this.label3 = new ReaLTaiizor.Controls.CrownLabel();
            this.label2 = new ReaLTaiizor.Controls.CrownLabel();
            this.label1 = new ReaLTaiizor.Controls.CrownLabel();
            this.targetTypeComboBox = new ModCrownComboBox();
            this.valueTextBox = new ReaLTaiizor.Controls.CrownTextBox();
            this.button1 = new ReaLTaiizor.Controls.CrownButton();
            this.button2 = new ReaLTaiizor.Controls.CrownButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.25688F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.74312F));
            this.tableLayoutPanel1.Controls.Add(this.effectTypeComboBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bonusTypeComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.targetTypeComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.valueTextBox, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 11);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(545, 149);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // effectTypeComboBox
            // 
            this.effectTypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.effectTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.effectTypeComboBox.FormattingEnabled = true;
            this.effectTypeComboBox.Location = new System.Drawing.Point(271, 78);
            this.effectTypeComboBox.Margin = new System.Windows.Forms.Padding(8, 3, 3, 8);
            this.effectTypeComboBox.Name = "effectTypeComboBox";
            this.effectTypeComboBox.Size = new System.Drawing.Size(271, 24);
            this.effectTypeComboBox.TabIndex = 3;
            this.effectTypeComboBox.DrawTextItem += new ModCrownComboBox.DrawItemTextColorEventHandler(this.effectTypeComboBoxDrawItem);
            this.effectTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.effectTypeSelected);
            // 
            // bonusTypeComboBox
            // 
            this.bonusTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.bonusTypeComboBox.FormattingEnabled = true;
            this.bonusTypeComboBox.Location = new System.Drawing.Point(271, 40);
            this.bonusTypeComboBox.Margin = new System.Windows.Forms.Padding(8, 3, 3, 8);
            this.bonusTypeComboBox.Name = "bonusTypeComboBox";
            this.bonusTypeComboBox.Size = new System.Drawing.Size(271, 24);
            this.bonusTypeComboBox.TabIndex = 3;
            this.bonusTypeComboBox.DrawTextItem += new ModCrownComboBox.DrawItemTextColorEventHandler(this.bonusTypeComboBoxDrawItem);
            this.bonusTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.bonusTypeSelected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label4.Location = new System.Drawing.Point(3, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
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
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
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
            this.targetTypeComboBox.Location = new System.Drawing.Point(271, 3);
            this.targetTypeComboBox.Margin = new System.Windows.Forms.Padding(8, 3, 3, 8);
            this.targetTypeComboBox.Name = "targetTypeComboBox";
            this.targetTypeComboBox.Size = new System.Drawing.Size(271, 24);
            this.targetTypeComboBox.TabIndex = 2;
            this.targetTypeComboBox.DrawTextItem += new ModCrownComboBox.DrawItemTextColorEventHandler(this.targetTypeComboBoxDrawItem);
            this.targetTypeComboBox.SelectedValueChanged += new System.EventHandler(this.targetTypeSelected);
            // 
            // valueTextBox
            // 
            this.valueTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.valueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valueTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.valueTextBox.Location = new System.Drawing.Point(271, 119);
            this.valueTextBox.Margin = new System.Windows.Forms.Padding(8, 8, 3, 8);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(271, 23);
            this.valueTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 165);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(408, 165);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5);
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GlobalStatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 204);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GlobalStatForm";
            this.Text = "GlobalStatForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private ModCrownComboBox effectTypeComboBox;
    private ModCrownComboBox bonusTypeComboBox;
    private CrownLabel label4;
    private CrownLabel label3;
    private CrownLabel label2;
    private CrownLabel label1;
    private ModCrownComboBox targetTypeComboBox;
    private CrownTextBox valueTextBox;
    private CrownButton button1;
    private CrownButton button2;
}