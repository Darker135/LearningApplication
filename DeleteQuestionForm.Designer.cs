namespace LearningApplication
{
    partial class DeleteQuestionForm
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.disciplineComboBox = new System.Windows.Forms.ComboBox();
            this.themeComboBox = new System.Windows.Forms.ComboBox();
            this.questionListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(10, 349);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(185, 40);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(542, 349);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(185, 40);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(285, 242);
            this.answerTextBox.Multiline = true;
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.ReadOnly = true;
            this.answerTextBox.Size = new System.Drawing.Size(442, 101);
            this.answerTextBox.TabIndex = 3;
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(285, 39);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.ReadOnly = true;
            this.questionTextBox.Size = new System.Drawing.Size(442, 167);
            this.questionTextBox.TabIndex = 3;
            // 
            // disciplineComboBox
            // 
            this.disciplineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.disciplineComboBox.FormattingEnabled = true;
            this.disciplineComboBox.Location = new System.Drawing.Point(10, 31);
            this.disciplineComboBox.Name = "disciplineComboBox";
            this.disciplineComboBox.Size = new System.Drawing.Size(262, 28);
            this.disciplineComboBox.TabIndex = 4;
            this.disciplineComboBox.SelectedIndexChanged += new System.EventHandler(this.disciplineComboBox_SelectedIndexChanged);
            // 
            // themeComboBox
            // 
            this.themeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.themeComboBox.FormattingEnabled = true;
            this.themeComboBox.Location = new System.Drawing.Point(9, 85);
            this.themeComboBox.Name = "themeComboBox";
            this.themeComboBox.Size = new System.Drawing.Size(261, 28);
            this.themeComboBox.TabIndex = 5;
            this.themeComboBox.SelectedIndexChanged += new System.EventHandler(this.themeComboBox_SelectedIndexChanged);
            // 
            // questionListBox
            // 
            this.questionListBox.FormattingEnabled = true;
            this.questionListBox.ItemHeight = 20;
            this.questionListBox.Location = new System.Drawing.Point(9, 139);
            this.questionListBox.Name = "questionListBox";
            this.questionListBox.Size = new System.Drawing.Size(262, 204);
            this.questionListBox.TabIndex = 6;
            this.questionListBox.SelectedIndexChanged += new System.EventHandler(this.questionListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выберите вопрос:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Выберите тему:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Выберите учебный предмет:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ответ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Вопрос:";
            // 
            // DeleteQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 401);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questionListBox);
            this.Controls.Add(this.themeComboBox);
            this.Controls.Add(this.disciplineComboBox);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "DeleteQuestionForm";
            this.Text = "DeleteQuestionForm";
            this.Load += new System.EventHandler(this.DeleteQuestionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.ComboBox disciplineComboBox;
        private System.Windows.Forms.ComboBox themeComboBox;
        private System.Windows.Forms.ListBox questionListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}