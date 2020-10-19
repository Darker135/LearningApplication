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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.loggedLabel = new System.Windows.Forms.Label();
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
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(23, 16);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(71, 20);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome";
            // 
            // loggedLabel
            // 
            this.loggedLabel.AutoSize = true;
            this.loggedLabel.Location = new System.Drawing.Point(21, 52);
            this.loggedLabel.Name = "loggedLabel";
            this.loggedLabel.Size = new System.Drawing.Size(103, 20);
            this.loggedLabel.TabIndex = 1;
            this.loggedLabel.Text = "You logged as";
            // 
            // createQuestionButton
            // 
            this.createQuestionButton.Location = new System.Drawing.Point(23, 110);
            this.createQuestionButton.Name = "createQuestionButton";
            this.createQuestionButton.Size = new System.Drawing.Size(176, 49);
            this.createQuestionButton.TabIndex = 3;
            this.createQuestionButton.Text = "Create question";
            this.createQuestionButton.UseVisualStyleBackColor = true;
            this.createQuestionButton.Click += new System.EventHandler(this.createQuestionButton_Click);
            // 
            // deleteQuestionButton
            // 
            this.deleteQuestionButton.Location = new System.Drawing.Point(23, 220);
            this.deleteQuestionButton.Name = "deleteQuestionButton";
            this.deleteQuestionButton.Size = new System.Drawing.Size(176, 49);
            this.deleteQuestionButton.TabIndex = 3;
            this.deleteQuestionButton.Text = "Delete question";
            this.deleteQuestionButton.UseVisualStyleBackColor = true;
            // 
            // changeQuestionButton
            // 
            this.changeQuestionButton.Location = new System.Drawing.Point(23, 165);
            this.changeQuestionButton.Name = "changeQuestionButton";
            this.changeQuestionButton.Size = new System.Drawing.Size(176, 49);
            this.changeQuestionButton.TabIndex = 3;
            this.changeQuestionButton.Text = "Change question";
            this.changeQuestionButton.UseVisualStyleBackColor = true;
            // 
            // createTestButton
            // 
            this.createTestButton.Location = new System.Drawing.Point(205, 110);
            this.createTestButton.Name = "createTestButton";
            this.createTestButton.Size = new System.Drawing.Size(176, 49);
            this.createTestButton.TabIndex = 3;
            this.createTestButton.Text = "Create test";
            this.createTestButton.UseVisualStyleBackColor = true;
            // 
            // changeTestButton
            // 
            this.changeTestButton.Location = new System.Drawing.Point(205, 165);
            this.changeTestButton.Name = "changeTestButton";
            this.changeTestButton.Size = new System.Drawing.Size(176, 49);
            this.changeTestButton.TabIndex = 3;
            this.changeTestButton.Text = "Change test";
            this.changeTestButton.UseVisualStyleBackColor = true;
            // 
            // deleteTestButton
            // 
            this.deleteTestButton.Location = new System.Drawing.Point(205, 220);
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
            this.viewResultButton.Location = new System.Drawing.Point(387, 324);
            this.viewResultButton.Name = "viewResultButton";
            this.viewResultButton.Size = new System.Drawing.Size(176, 49);
            this.viewResultButton.TabIndex = 3;
            this.viewResultButton.Text = "View results";
            this.viewResultButton.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(205, 220);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 49);
            this.button5.TabIndex = 3;
            this.button5.Text = "Delete test";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(23, 324);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(176, 49);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // answerButton
            // 
            this.answerButton.Location = new System.Drawing.Point(387, 165);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(176, 49);
            this.answerButton.TabIndex = 3;
            this.answerButton.Text = "Show correct answers";
            this.answerButton.UseVisualStyleBackColor = true;
            // 
            // TeacherMainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 385);
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
            this.Controls.Add(this.loggedLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "TeacherMainScreenForm";
            this.Text = "Homescreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeacherMainScreenForm_FormClosing);
            this.Load += new System.EventHandler(this.TeacherMainScreenForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label loggedLabel;
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