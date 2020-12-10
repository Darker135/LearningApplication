namespace LearningApplication
{
    partial class StudentMainScreenForm
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
            this.materialTextBox = new System.Windows.Forms.RichTextBox();
            this.themeComboBox = new System.Windows.Forms.ComboBox();
            this.previousLabel = new System.Windows.Forms.LinkLabel();
            this.nextLabel = new System.Windows.Forms.LinkLabel();
            this.testButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.disciplineComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // materialTextBox
            // 
            this.materialTextBox.Location = new System.Drawing.Point(12, 156);
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.ReadOnly = true;
            this.materialTextBox.Size = new System.Drawing.Size(544, 257);
            this.materialTextBox.TabIndex = 1;
            this.materialTextBox.Text = "";
            // 
            // themeComboBox
            // 
            this.themeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.themeComboBox.FormattingEnabled = true;
            this.themeComboBox.Location = new System.Drawing.Point(12, 96);
            this.themeComboBox.Name = "themeComboBox";
            this.themeComboBox.Size = new System.Drawing.Size(544, 28);
            this.themeComboBox.TabIndex = 2;
            this.themeComboBox.SelectedIndexChanged += new System.EventHandler(this.themeComboBox_SelectedIndexChanged);
            // 
            // previousLabel
            // 
            this.previousLabel.AutoSize = true;
            this.previousLabel.Location = new System.Drawing.Point(251, 437);
            this.previousLabel.Name = "previousLabel";
            this.previousLabel.Size = new System.Drawing.Size(51, 20);
            this.previousLabel.TabIndex = 3;
            this.previousLabel.TabStop = true;
            this.previousLabel.Text = "Назад";
            this.previousLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.previousLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // nextLabel
            // 
            this.nextLabel.AutoSize = true;
            this.nextLabel.Location = new System.Drawing.Point(480, 437);
            this.nextLabel.Name = "nextLabel";
            this.nextLabel.Size = new System.Drawing.Size(51, 20);
            this.nextLabel.TabIndex = 4;
            this.nextLabel.TabStop = true;
            this.nextLabel.Text = "Далее";
            this.nextLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.nextLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nextLabel_LinkClicked);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(308, 424);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(166, 46);
            this.testButton.TabIndex = 5;
            this.testButton.Text = "Пройти тест";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 424);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(166, 46);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Тема:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Материал:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Дисциплина:";
            // 
            // disciplineComboBox
            // 
            this.disciplineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.disciplineComboBox.FormattingEnabled = true;
            this.disciplineComboBox.Location = new System.Drawing.Point(12, 42);
            this.disciplineComboBox.Name = "disciplineComboBox";
            this.disciplineComboBox.Size = new System.Drawing.Size(544, 28);
            this.disciplineComboBox.TabIndex = 10;
            this.disciplineComboBox.SelectedIndexChanged += new System.EventHandler(this.disciplineComboBox_SelectedIndexChanged);
            // 
            // StudentMainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 490);
            this.Controls.Add(this.disciplineComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.nextLabel);
            this.Controls.Add(this.previousLabel);
            this.Controls.Add(this.themeComboBox);
            this.Controls.Add(this.materialTextBox);
            this.Name = "StudentMainScreenForm";
            this.Text = "StudentMainScreenForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentMainScreenForm_FormClosing);
            this.Load += new System.EventHandler(this.StudentMainScreenForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox materialTextBox;
        private System.Windows.Forms.ComboBox themeComboBox;
        private System.Windows.Forms.LinkLabel previousLabel;
        private System.Windows.Forms.LinkLabel nextLabel;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox disciplineComboBox;
    }
}