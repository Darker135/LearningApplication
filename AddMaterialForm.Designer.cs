namespace LearningApplication
{
    partial class AddMaterialForm
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
            this.materialTextBox = new System.Windows.Forms.RichTextBox();
            this.addMaterialButton = new System.Windows.Forms.Button();
            this.themeLabel = new System.Windows.Forms.Label();
            this.themeTextBox = new System.Windows.Forms.TextBox();
            this.groupErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.themeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.AnswerErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // disciplineListBox
            // 
            this.disciplineListBox.FormattingEnabled = true;
            this.disciplineListBox.ItemHeight = 20;
            this.disciplineListBox.Location = new System.Drawing.Point(13, 13);
            this.disciplineListBox.Name = "disciplineListBox";
            this.disciplineListBox.Size = new System.Drawing.Size(192, 424);
            this.disciplineListBox.TabIndex = 0;
            this.disciplineListBox.SelectedIndexChanged += new System.EventHandler(this.disciplineListBox_SelectedIndexChanged);
            // 
            // groupCheck
            // 
            this.groupCheck.FormattingEnabled = true;
            this.groupCheck.Location = new System.Drawing.Point(211, 11);
            this.groupCheck.Name = "groupCheck";
            this.groupCheck.Size = new System.Drawing.Size(115, 422);
            this.groupCheck.TabIndex = 1;
            this.groupCheck.SelectedIndexChanged += new System.EventHandler(this.groupCheck_SelectedIndexChanged);
            this.groupCheck.SelectedValueChanged += new System.EventHandler(this.groupCheck_SelectedValueChanged);
            // 
            // materialTextBox
            // 
            this.materialTextBox.Location = new System.Drawing.Point(332, 46);
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox.Size = new System.Drawing.Size(445, 341);
            this.materialTextBox.TabIndex = 2;
            this.materialTextBox.Text = "Material";
            this.materialTextBox.TextChanged += new System.EventHandler(this.materialTextBox_TextChanged);
            // 
            // addMaterialButton
            // 
            this.addMaterialButton.Location = new System.Drawing.Point(457, 393);
            this.addMaterialButton.Name = "addMaterialButton";
            this.addMaterialButton.Size = new System.Drawing.Size(188, 51);
            this.addMaterialButton.TabIndex = 3;
            this.addMaterialButton.Text = "Добавить материал";
            this.addMaterialButton.UseVisualStyleBackColor = true;
            this.addMaterialButton.Click += new System.EventHandler(this.addMaterialButton_Click);
            // 
            // themeLabel
            // 
            this.themeLabel.AutoSize = true;
            this.themeLabel.Location = new System.Drawing.Point(355, 14);
            this.themeLabel.Name = "themeLabel";
            this.themeLabel.Size = new System.Drawing.Size(47, 20);
            this.themeLabel.TabIndex = 4;
            this.themeLabel.Text = "Тема:";
            // 
            // themeTextBox
            // 
            this.themeTextBox.Location = new System.Drawing.Point(408, 11);
            this.themeTextBox.Name = "themeTextBox";
            this.themeTextBox.Size = new System.Drawing.Size(325, 27);
            this.themeTextBox.TabIndex = 5;
            this.themeTextBox.TextChanged += new System.EventHandler(this.themeTextBox_TextChanged);
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
            // materialErrorProvider
            // 
            this.materialErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.materialErrorProvider.ContainerControl = this;
            // 
            // AnswerErrorProvider
            // 
            this.AnswerErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.AnswerErrorProvider.ContainerControl = this;
            // 
            // AddMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(812, 457);
            this.Controls.Add(this.themeTextBox);
            this.Controls.Add(this.themeLabel);
            this.Controls.Add(this.addMaterialButton);
            this.Controls.Add(this.materialTextBox);
            this.Controls.Add(this.groupCheck);
            this.Controls.Add(this.disciplineListBox);
            this.Name = "AddMaterialForm";
            this.Text = "Добавление материала";
            this.Load += new System.EventHandler(this.AddMaterialForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox disciplineListBox;
        private System.Windows.Forms.CheckedListBox groupCheck;
        private System.Windows.Forms.RichTextBox materialTextBox;
        private System.Windows.Forms.Button addMaterialButton;
        private System.Windows.Forms.Label themeLabel;
        private System.Windows.Forms.TextBox themeTextBox;
        private System.Windows.Forms.ErrorProvider groupErrorProvider;
        private System.Windows.Forms.ErrorProvider themeErrorProvider;
        private System.Windows.Forms.ErrorProvider materialErrorProvider;
        private System.Windows.Forms.ErrorProvider AnswerErrorProvider;
    }
}