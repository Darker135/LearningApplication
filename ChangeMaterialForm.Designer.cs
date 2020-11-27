namespace LearningApplication
{
    partial class ChangeMaterialForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.materialTextBox = new System.Windows.Forms.TextBox();
            this.disciplineComboBox = new System.Windows.Forms.ComboBox();
            this.themeComboBox = new System.Windows.Forms.ComboBox();
            this.materialListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(11, 322);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(185, 40);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(543, 322);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(185, 40);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // materialTextBox
            // 
            this.materialTextBox.Location = new System.Drawing.Point(286, 12);
            this.materialTextBox.Multiline = true;
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.Size = new System.Drawing.Size(442, 304);
            this.materialTextBox.TabIndex = 3;
            // 
            // disciplineComboBox
            // 
            this.disciplineComboBox.FormattingEnabled = true;
            this.disciplineComboBox.Location = new System.Drawing.Point(11, 20);
            this.disciplineComboBox.Name = "disciplineComboBox";
            this.disciplineComboBox.Size = new System.Drawing.Size(262, 28);
            this.disciplineComboBox.TabIndex = 4;
            this.disciplineComboBox.SelectedIndexChanged += new System.EventHandler(this.disciplineComboBox_SelectedIndexChanged);
            // 
            // themeComboBox
            // 
            this.themeComboBox.FormattingEnabled = true;
            this.themeComboBox.Location = new System.Drawing.Point(11, 63);
            this.themeComboBox.Name = "themeComboBox";
            this.themeComboBox.Size = new System.Drawing.Size(261, 28);
            this.themeComboBox.TabIndex = 5;
            this.themeComboBox.SelectedIndexChanged += new System.EventHandler(this.themeComboBox_SelectedIndexChanged);
            // 
            // materialListBox
            // 
            this.materialListBox.FormattingEnabled = true;
            this.materialListBox.ItemHeight = 20;
            this.materialListBox.Location = new System.Drawing.Point(11, 105);
            this.materialListBox.Name = "materialListBox";
            this.materialListBox.Size = new System.Drawing.Size(262, 204);
            this.materialListBox.TabIndex = 6;
            this.materialListBox.SelectedIndexChanged += new System.EventHandler(this.materialListBox_SelectedIndexChanged);
            // 
            // ChangeMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 375);
            this.Controls.Add(this.materialListBox);
            this.Controls.Add(this.themeComboBox);
            this.Controls.Add(this.disciplineComboBox);
            this.Controls.Add(this.materialTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "ChangeMaterialForm";
            this.Text = "ChangeMaterialForm";
            this.Load += new System.EventHandler(this.ChangeMaterialForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox materialTextBox;
        private System.Windows.Forms.ComboBox disciplineComboBox;
        private System.Windows.Forms.ComboBox themeComboBox;
        private System.Windows.Forms.ListBox materialListBox;
    }
}