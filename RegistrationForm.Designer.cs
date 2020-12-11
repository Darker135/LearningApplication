namespace LearningApplication
{
    partial class RegistrationForm
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
            this.singUpButton = new System.Windows.Forms.Button();
            this.registerAs_label = new System.Windows.Forms.Label();
            this.studentRadio = new System.Windows.Forms.RadioButton();
            this.teacherRadio = new System.Windows.Forms.RadioButton();
            this.nameLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.specialityLabel = new System.Windows.Forms.Label();
            this.groupLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.specialityComboBox = new System.Windows.Forms.ComboBox();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.teacherNameComboBox = new System.Windows.Forms.ComboBox();
            this.loginErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.passwordErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.nameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.loginErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // singUpButton
            // 
            this.singUpButton.Location = new System.Drawing.Point(148, 244);
            this.singUpButton.Name = "singUpButton";
            this.singUpButton.Size = new System.Drawing.Size(181, 53);
            this.singUpButton.TabIndex = 0;
            this.singUpButton.Text = "Регистрация";
            this.singUpButton.UseVisualStyleBackColor = true;
            this.singUpButton.Click += new System.EventHandler(this.singUpButton_Click);
            // 
            // registerAs_label
            // 
            this.registerAs_label.AutoSize = true;
            this.registerAs_label.Location = new System.Drawing.Point(12, 15);
            this.registerAs_label.Name = "registerAs_label";
            this.registerAs_label.Size = new System.Drawing.Size(180, 20);
            this.registerAs_label.TabIndex = 1;
            this.registerAs_label.Text = "Зарегистрироваться как:";
            // 
            // studentRadio
            // 
            this.studentRadio.AutoSize = true;
            this.studentRadio.Location = new System.Drawing.Point(12, 48);
            this.studentRadio.Name = "studentRadio";
            this.studentRadio.Size = new System.Drawing.Size(83, 24);
            this.studentRadio.TabIndex = 2;
            this.studentRadio.TabStop = true;
            this.studentRadio.Text = "Студент";
            this.studentRadio.UseVisualStyleBackColor = true;
            this.studentRadio.CheckedChanged += new System.EventHandler(this.studentRadio_CheckedChanged);
            // 
            // teacherRadio
            // 
            this.teacherRadio.AutoSize = true;
            this.teacherRadio.Location = new System.Drawing.Point(12, 78);
            this.teacherRadio.Name = "teacherRadio";
            this.teacherRadio.Size = new System.Drawing.Size(138, 24);
            this.teacherRadio.TabIndex = 2;
            this.teacherRadio.TabStop = true;
            this.teacherRadio.Text = "Преподаватель";
            this.teacherRadio.UseVisualStyleBackColor = true;
            this.teacherRadio.CheckedChanged += new System.EventHandler(this.teacherRadio_CheckedChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(233, 19);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 20);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Имя:";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(223, 48);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(55, 20);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Логин:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(213, 81);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(65, 20);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Пароль:";
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Location = new System.Drawing.Point(194, 116);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(81, 20);
            this.departmentLabel.TabIndex = 3;
            this.departmentLabel.Text = "Факультет:";
            // 
            // specialityLabel
            // 
            this.specialityLabel.AutoSize = true;
            this.specialityLabel.Location = new System.Drawing.Point(156, 152);
            this.specialityLabel.Name = "specialityLabel";
            this.specialityLabel.Size = new System.Drawing.Size(119, 20);
            this.specialityLabel.TabIndex = 3;
            this.specialityLabel.Text = "Специальность:";
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(214, 186);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(61, 20);
            this.groupLabel.TabIndex = 3;
            this.groupLabel.Text = "Группа:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(281, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(191, 27);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(281, 45);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(191, 27);
            this.loginTextBox.TabIndex = 4;
            this.loginTextBox.TextChanged += new System.EventHandler(this.loginTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(281, 78);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(191, 27);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(281, 113);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(191, 28);
            this.departmentComboBox.TabIndex = 5;
            this.departmentComboBox.SelectedIndexChanged += new System.EventHandler(this.departmentComboBox_SelectedIndexChanged);
            // 
            // specialityComboBox
            // 
            this.specialityComboBox.FormattingEnabled = true;
            this.specialityComboBox.Location = new System.Drawing.Point(281, 149);
            this.specialityComboBox.Name = "specialityComboBox";
            this.specialityComboBox.Size = new System.Drawing.Size(191, 28);
            this.specialityComboBox.TabIndex = 5;
            this.specialityComboBox.SelectedIndexChanged += new System.EventHandler(this.specialityComboBox_SelectedIndexChanged);
            // 
            // groupComboBox
            // 
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(281, 183);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(191, 28);
            this.groupComboBox.TabIndex = 5;
            this.groupComboBox.SelectedIndexChanged += new System.EventHandler(this.groupComboBox_SelectedIndexChanged);
            // 
            // teacherNameComboBox
            // 
            this.teacherNameComboBox.FormattingEnabled = true;
            this.teacherNameComboBox.Location = new System.Drawing.Point(281, 11);
            this.teacherNameComboBox.Name = "teacherNameComboBox";
            this.teacherNameComboBox.Size = new System.Drawing.Size(191, 28);
            this.teacherNameComboBox.TabIndex = 5;
            this.teacherNameComboBox.SelectedIndexChanged += new System.EventHandler(this.teacherNameComboBox_SelectedIndexChanged);
            // 
            // loginErrorProvider
            // 
            this.loginErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.loginErrorProvider.ContainerControl = this;
            // 
            // passwordErrorProvider
            // 
            this.passwordErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.passwordErrorProvider.ContainerControl = this;
            // 
            // nameErrorProvider
            // 
            this.nameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.nameErrorProvider.ContainerControl = this;
            // 
            // groupErrorProvider
            // 
            this.groupErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.groupErrorProvider.ContainerControl = this;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(533, 318);
            this.Controls.Add(this.teacherNameComboBox);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.specialityComboBox);
            this.Controls.Add(this.departmentComboBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.specialityLabel);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.teacherRadio);
            this.Controls.Add(this.studentRadio);
            this.Controls.Add(this.registerAs_label);
            this.Controls.Add(this.singUpButton);
            this.Name = "RegistrationForm";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button singUpButton;
        private System.Windows.Forms.Label registerAs_label;
        private System.Windows.Forms.RadioButton studentRadio;
        private System.Windows.Forms.RadioButton teacherRadio;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Label specialityLabel;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.ComboBox specialityComboBox;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.ComboBox teacherNameComboBox;
        private System.Windows.Forms.ErrorProvider loginErrorProvider;
        private System.Windows.Forms.ErrorProvider passwordErrorProvider;
        private System.Windows.Forms.ErrorProvider nameErrorProvider;
        private System.Windows.Forms.ErrorProvider groupErrorProvider;
    }
}