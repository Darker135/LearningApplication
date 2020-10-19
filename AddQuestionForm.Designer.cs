namespace LearningApplication
{
    partial class AddQuestionForm
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
            this.components = new System.ComponentModel.Container();
            this.disciplineListBox = new System.Windows.Forms.ListBox();
            this.groupCheck = new System.Windows.Forms.CheckedListBox();
            this.questionTextBox = new System.Windows.Forms.RichTextBox();
            this.addQuestionButton = new System.Windows.Forms.Button();
            this.themeLabel = new System.Windows.Forms.Label();
            this.themeTextBox = new System.Windows.Forms.TextBox();
            this.answerTextBox = new System.Windows.Forms.RichTextBox();
            this.groupErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.themeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.questionErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.AnswerErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // disciplineListBox
            // 
            this.disciplineListBox.FormattingEnabled = true;
            this.disciplineListBox.ItemHeight = 20;
            this.disciplineListBox.Location = new System.Drawing.Point(13, 13);
            this.disciplineListBox.Name = "disciplineListBox";
            this.disciplineListBox.Size = new System.Drawing.Size(156, 424);
            this.disciplineListBox.TabIndex = 0;
            this.disciplineListBox.SelectedIndexChanged += new System.EventHandler(this.disciplineListBox_SelectedIndexChanged);
            // 
            // groupCheck
            // 
            this.groupCheck.FormattingEnabled = true;
            this.groupCheck.Location = new System.Drawing.Point(184, 13);
            this.groupCheck.Name = "groupCheck";
            this.groupCheck.Size = new System.Drawing.Size(115, 422);
            this.groupCheck.TabIndex = 1;
            this.groupCheck.SelectedIndexChanged += new System.EventHandler(this.groupCheck_SelectedIndexChanged);
            this.groupCheck.SelectedValueChanged += new System.EventHandler(this.groupCheck_SelectedValueChanged);
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(332, 46);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.questionTextBox.Size = new System.Drawing.Size(445, 240);
            this.questionTextBox.TabIndex = 2;
            this.questionTextBox.Text = "Question";
            this.questionTextBox.TextChanged += new System.EventHandler(this.questionTextBox_TextChanged);
            // 
            // addQuestionButton
            // 
            this.addQuestionButton.Location = new System.Drawing.Point(457, 393);
            this.addQuestionButton.Name = "addQuestionButton";
            this.addQuestionButton.Size = new System.Drawing.Size(188, 51);
            this.addQuestionButton.TabIndex = 3;
            this.addQuestionButton.Text = "Add question";
            this.addQuestionButton.UseVisualStyleBackColor = true;
            this.addQuestionButton.Click += new System.EventHandler(this.addQuestionButton_Click);
            // 
            // themeLabel
            // 
            this.themeLabel.AutoSize = true;
            this.themeLabel.Location = new System.Drawing.Point(332, 13);
            this.themeLabel.Name = "themeLabel";
            this.themeLabel.Size = new System.Drawing.Size(57, 20);
            this.themeLabel.TabIndex = 4;
            this.themeLabel.Text = "Theme:";
            // 
            // themeTextBox
            // 
            this.themeTextBox.Location = new System.Drawing.Point(408, 11);
            this.themeTextBox.Name = "themeTextBox";
            this.themeTextBox.Size = new System.Drawing.Size(325, 27);
            this.themeTextBox.TabIndex = 5;
            this.themeTextBox.TextChanged += new System.EventHandler(this.themeTextBox_TextChanged);
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(330, 298);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(446, 80);
            this.answerTextBox.TabIndex = 6;
            this.answerTextBox.Text = "Answer";
            this.answerTextBox.TextChanged += new System.EventHandler(this.answerTextBox_TextChanged);
            // 
            // groupErrorProvider
            // 
            this.groupErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.groupErrorProvider.ContainerControl = this;
            // 
            // themeErrorProvider
            // 
            this.themeErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.themeErrorProvider.ContainerControl = this;
            // 
            // questionErrorProvider
            // 
            this.questionErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.questionErrorProvider.ContainerControl = this;
            // 
            // AnswerErrorProvider
            // 
            this.AnswerErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.AnswerErrorProvider.ContainerControl = this;
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 457);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.themeTextBox);
            this.Controls.Add(this.themeLabel);
            this.Controls.Add(this.addQuestionButton);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.groupCheck);
            this.Controls.Add(this.disciplineListBox);
            this.Name = "AddQuestionForm";
            this.Text = "AddQuestionForm";
            this.Load += new System.EventHandler(this.AddQuestionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox disciplineListBox;
        private System.Windows.Forms.CheckedListBox groupCheck;
        private System.Windows.Forms.RichTextBox questionTextBox;
        private System.Windows.Forms.Button addQuestionButton;
        private System.Windows.Forms.Label themeLabel;
        private System.Windows.Forms.TextBox themeTextBox;
        private System.Windows.Forms.RichTextBox answerTextBox;
        private System.Windows.Forms.ErrorProvider groupErrorProvider;
        private System.Windows.Forms.ErrorProvider themeErrorProvider;
        private System.Windows.Forms.ErrorProvider questionErrorProvider;
        private System.Windows.Forms.ErrorProvider AnswerErrorProvider;
    }
}