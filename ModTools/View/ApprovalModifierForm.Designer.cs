using System.ComponentModel;
using ReaLTaiizor.Controls;

namespace ModTools.View;

partial class ApprovalModifierForm
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
            this.tagComboBox = new CrownComboBox();
            this.bonusTypeComboBox = new CrownComboBox();
            this.label4 = new CrownLabel();
            this.label3 = new CrownLabel();
            this.label2 = new CrownLabel();
            this.label1 = new CrownLabel();
            this.typeComboBox = new CrownComboBox();
            this.valueTextBox = new CrownTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(272, 167);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            // this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(363, 167);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            // this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tagComboBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bonusTypeComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.typeComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.valueTextBox, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(367, 149);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tagComboBox
            // 
            this.tagComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tagComboBox.FormattingEnabled = true;
            this.tagComboBox.Location = new System.Drawing.Point(191, 78);
            this.tagComboBox.Margin = new System.Windows.Forms.Padding(8, 3, 3, 8);
            this.tagComboBox.Name = "tagComboBox";
            this.tagComboBox.Size = new System.Drawing.Size(173, 23);
            this.tagComboBox.TabIndex = 3;
            this.tagComboBox.SelectedValueChanged += new System.EventHandler(this.tagSelected);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tag";
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
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(191, 3);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(8, 3, 3, 8);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(173, 23);
            this.typeComboBox.TabIndex = 2;
            this.typeComboBox.SelectedValueChanged += new System.EventHandler(this.typeSelected);
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(191, 119);
            this.valueTextBox.Margin = new System.Windows.Forms.Padding(8, 8, 3, 8);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(173, 23);
            this.valueTextBox.TabIndex = 4;
            // 
            // ApprovalModifierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 210);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ApprovalModifierForm";
            this.Text = "ApprovalModifierForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private CrownButton cancelButton;
    private CrownButton saveButton;
    private TableLayoutPanel tableLayoutPanel1;
    private CrownComboBox tagComboBox;
    private CrownComboBox bonusTypeComboBox;
    private CrownLabel label4;
    private CrownLabel label3;
    private CrownLabel label2;
    private CrownLabel label1;
    private CrownComboBox typeComboBox;
    private CrownTextBox valueTextBox;
}