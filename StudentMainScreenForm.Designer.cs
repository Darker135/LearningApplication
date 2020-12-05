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
            this.disciplineComboBox = new System.Windows.Forms.ComboBox();
            this.previousLabel = new System.Windows.Forms.LinkLabel();
            this.nextLabel = new System.Windows.Forms.LinkLabel();
            this.testButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // materialTextBox
            // 
            this.materialTextBox.Location = new System.Drawing.Point(12, 86);
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.Size = new System.Drawing.Size(544, 257);
            this.materialTextBox.TabIndex = 1;
            this.materialTextBox.Text = "";
            // 
            // disciplineComboBox
            // 
            this.disciplineComboBox.FormattingEnabled = true;
            this.disciplineComboBox.Location = new System.Drawing.Point(12, 26);
            this.disciplineComboBox.Name = "disciplineComboBox";
            this.disciplineComboBox.Size = new System.Drawing.Size(544, 28);
            this.disciplineComboBox.TabIndex = 2;
            // 
            // previousLabel
            // 
            this.previousLabel.AutoSize = true;
            this.previousLabel.Location = new System.Drawing.Point(251, 367);
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
            this.nextLabel.Location = new System.Drawing.Point(480, 367);
            this.nextLabel.Name = "nextLabel";
            this.nextLabel.Size = new System.Drawing.Size(51, 20);
            this.nextLabel.TabIndex = 4;
            this.nextLabel.TabStop = true;
            this.nextLabel.Text = "Далее";
            this.nextLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(308, 354);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(166, 46);
            this.testButton.TabIndex = 5;
            this.testButton.Text = "Пройти тест";
            this.testButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 354);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(166, 46);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Тема:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Материал:";
            // 
            // StudentMainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 417);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.nextLabel);
            this.Controls.Add(this.previousLabel);
            this.Controls.Add(this.disciplineComboBox);
            this.Controls.Add(this.materialTextBox);
            this.Name = "StudentMainScreenForm";
            this.Text = "StudentMainScreenForm";
            this.Load += new System.EventHandler(this.StudentMainScreenForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox materialTextBox;
        private System.Windows.Forms.ComboBox disciplineComboBox;
        private System.Windows.Forms.LinkLabel previousLabel;
        private System.Windows.Forms.LinkLabel nextLabel;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}