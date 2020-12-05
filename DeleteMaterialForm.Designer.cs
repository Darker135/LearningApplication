namespace LearningApplication
{
    partial class DeleteMaterialForm
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.disciplineComboBox = new System.Windows.Forms.ComboBox();
            this.themeComboBox = new System.Windows.Forms.ComboBox();
            this.materialListBox = new System.Windows.Forms.ListBox();
            this.materialTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(11, 414);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(167, 47);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.Text = "cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(474, 414);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(167, 47);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // disciplineComboBox
            // 
            this.disciplineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.disciplineComboBox.FormattingEnabled = true;
            this.disciplineComboBox.Location = new System.Drawing.Point(12, 36);
            this.disciplineComboBox.Name = "disciplineComboBox";
            this.disciplineComboBox.Size = new System.Drawing.Size(210, 28);
            this.disciplineComboBox.TabIndex = 1;
            this.disciplineComboBox.SelectedIndexChanged += new System.EventHandler(this.disciplineComboBox_SelectedIndexChanged);
            // 
            // themeComboBox
            // 
            this.themeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.themeComboBox.FormattingEnabled = true;
            this.themeComboBox.Location = new System.Drawing.Point(11, 90);
            this.themeComboBox.Name = "themeComboBox";
            this.themeComboBox.Size = new System.Drawing.Size(211, 28);
            this.themeComboBox.TabIndex = 2;
            this.themeComboBox.SelectedIndexChanged += new System.EventHandler(this.themeComboBox_SelectedIndexChanged);
            // 
            // materialListBox
            // 
            this.materialListBox.FormattingEnabled = true;
            this.materialListBox.ItemHeight = 20;
            this.materialListBox.Location = new System.Drawing.Point(11, 144);
            this.materialListBox.Name = "materialListBox";
            this.materialListBox.Size = new System.Drawing.Size(211, 264);
            this.materialListBox.TabIndex = 3;
            this.materialListBox.SelectedIndexChanged += new System.EventHandler(this.materialListBox_SelectedIndexChanged);
            // 
            // materialTextBox
            // 
            this.materialTextBox.Enabled = false;
            this.materialTextBox.Location = new System.Drawing.Point(228, 21);
            this.materialTextBox.Multiline = true;
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.Size = new System.Drawing.Size(410, 387);
            this.materialTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите материал:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Выберите тему:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Выберите учебный предмет:";
            // 
            // DeleteMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 473);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialTextBox);
            this.Controls.Add(this.materialListBox);
            this.Controls.Add(this.themeComboBox);
            this.Controls.Add(this.disciplineComboBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelBtn);
            this.Name = "DeleteMaterialForm";
            this.Text = "DeleteMaterialForm";
            this.Load += new System.EventHandler(this.DeleteMaterialForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ComboBox disciplineComboBox;
        private System.Windows.Forms.ComboBox themeComboBox;
        private System.Windows.Forms.ListBox materialListBox;
        private System.Windows.Forms.TextBox materialTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}