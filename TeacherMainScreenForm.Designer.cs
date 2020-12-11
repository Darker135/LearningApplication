namespace LearningApplication
{
    partial class TeacherMainScreenForm
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
            this.createQuestionButton = new System.Windows.Forms.Button();
            this.deleteQuestionButton = new System.Windows.Forms.Button();
            this.changeQuestionButton = new System.Windows.Forms.Button();
            this.createTestButton = new System.Windows.Forms.Button();
            this.changeTestButton = new System.Windows.Forms.Button();
            this.deleteTestButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.viewResultButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.answerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createQuestionButton
            // 
            this.createQuestionButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.createQuestionButton.Location = new System.Drawing.Point(12, 15);
            this.createQuestionButton.Name = "createQuestionButton";
            this.createQuestionButton.Size = new System.Drawing.Size(176, 49);
            this.createQuestionButton.TabIndex = 3;
            this.createQuestionButton.Text = "Добавить материал";
            this.createQuestionButton.UseVisualStyleBackColor = true;
            this.createQuestionButton.Click += new System.EventHandler(this.createQuestionButton_Click);
            // 
            // deleteQuestionButton
            // 
            this.deleteQuestionButton.Location = new System.Drawing.Point(12, 125);
            this.deleteQuestionButton.Name = "deleteQuestionButton";
            this.deleteQuestionButton.Size = new System.Drawing.Size(176, 49);
            this.deleteQuestionButton.TabIndex = 3;
            this.deleteQuestionButton.Text = "Удалить материал";
            this.deleteQuestionButton.UseVisualStyleBackColor = true;
            this.deleteQuestionButton.Click += new System.EventHandler(this.deleteQuestionButton_Click);
            // 
            // changeQuestionButton
            // 
            this.changeQuestionButton.Location = new System.Drawing.Point(12, 70);
            this.changeQuestionButton.Name = "changeQuestionButton";
            this.changeQuestionButton.Size = new System.Drawing.Size(176, 49);
            this.changeQuestionButton.TabIndex = 3;
            this.changeQuestionButton.Text = "Редактировать материал";
            this.changeQuestionButton.UseVisualStyleBackColor = true;
            this.changeQuestionButton.Click += new System.EventHandler(this.changeQuestionButton_Click);
            // 
            // createTestButton
            // 
            this.createTestButton.Location = new System.Drawing.Point(194, 15);
            this.createTestButton.Name = "createTestButton";
            this.createTestButton.Size = new System.Drawing.Size(176, 49);
            this.createTestButton.TabIndex = 3;
            this.createTestButton.Text = "Добавить тест";
            this.createTestButton.UseVisualStyleBackColor = true;
            this.createTestButton.Click += new System.EventHandler(this.createTestButton_Click);
            // 
            // changeTestButton
            // 
            this.changeTestButton.Location = new System.Drawing.Point(194, 70);
            this.changeTestButton.Name = "changeTestButton";
            this.changeTestButton.Size = new System.Drawing.Size(176, 49);
            this.changeTestButton.TabIndex = 3;
            this.changeTestButton.Text = "Редактировать тест";
            this.changeTestButton.UseVisualStyleBackColor = true;
            this.changeTestButton.Click += new System.EventHandler(this.changeTestButton_Click);
            // 
            // deleteTestButton
            // 
            this.deleteTestButton.Location = new System.Drawing.Point(194, 125);
            this.deleteTestButton.Name = "deleteTestButton";
            this.deleteTestButton.Size = new System.Drawing.Size(176, 49);
            this.deleteTestButton.TabIndex = 3;
            this.deleteTestButton.Text = "Delete test";
            this.deleteTestButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-261, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete test";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // viewResultButton
            // 
            this.viewResultButton.Location = new System.Drawing.Point(377, 229);
            this.viewResultButton.Name = "viewResultButton";
            this.viewResultButton.Size = new System.Drawing.Size(176, 49);
            this.viewResultButton.TabIndex = 3;
            this.viewResultButton.Text = "Оценки";
            this.viewResultButton.UseVisualStyleBackColor = true;
            this.viewResultButton.Click += new System.EventHandler(this.viewResultButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(194, 125);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 49);
            this.button5.TabIndex = 3;
            this.button5.Text = "Удалить тест";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 229);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(176, 49);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // answerButton
            // 
            this.answerButton.Location = new System.Drawing.Point(377, 70);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(176, 49);
            this.answerButton.TabIndex = 3;
            this.answerButton.Text = "Просмотр ответов";
            this.answerButton.UseVisualStyleBackColor = true;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // TeacherMainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(570, 303);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewResultButton);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.deleteTestButton);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.changeTestButton);
            this.Controls.Add(this.createTestButton);
            this.Controls.Add(this.changeQuestionButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.deleteQuestionButton);
            this.Controls.Add(this.createQuestionButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "TeacherMainScreenForm";
            this.Text = "Homescreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeacherMainScreenForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button createQuestionButton;
        private System.Windows.Forms.Button deleteQuestionButton;
        private System.Windows.Forms.Button changeQuestionButton;
        private System.Windows.Forms.Button createTestButton;
        private System.Windows.Forms.Button changeTestButton;
        private System.Windows.Forms.Button deleteTestButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button viewResultButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button answerButton;
    }
}