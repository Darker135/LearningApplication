using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Threading;

namespace LearningApplication
{
    public partial class RegistrationForm : Form, IRegistrationController
    {
        
        Student student = new Student();
        Teacher teacher = new Teacher();
        public static RegistrationForm registrationForm = new RegistrationForm();
        List<string> allLoginsList = new List<string>();
        string query;
        SqlCommand command;
        SqlDataReader reader;
        public RegistrationForm()
        {
            InitializeComponent();
            
        }
        public string name { get { return loginTextBox.Text; } set { loginTextBox.Text = value; } }
        public string teacherName { get { return teacherNameComboBox.SelectedItem.ToString(); } set { teacherNameComboBox.SelectedItem.ToString(); } }
        public string login { get { return loginTextBox.Text; } set { loginTextBox.Text.ToString(); } }
        public string password { get { return passwordTextBox.Text; } set { passwordTextBox.Text.ToString(); } }
        public string department { get { return departmentComboBox.SelectedItem.ToString(); } set { departmentComboBox.SelectedItem.ToString(); } }
        public string speciality { get { return specialityComboBox.SelectedItem.ToString(); } set { specialityComboBox.SelectedItem.ToString(); } }
        public string group { get { return groupComboBox.SelectedItem.ToString(); } set { groupComboBox.SelectedItem.ToString(); } }

    

    private void RegistrationForm_Load(object sender, EventArgs e)
        {
            getAllLoginsList();
            singUpButton.Enabled = false;
            studentRadio.Checked = true;
            this.updateRegistrationInfo();
            loginTextBox.Enabled = false;
            passwordTextBox.Enabled = false;
            if (nameTextBox.Text == "")
                nameErrorProvider.SetError(nameTextBox, "Name field can not be empty");
            if (loginTextBox.Text == "")
                loginErrorProvider.SetError(loginTextBox, "Login string can not be empty");
            if (passwordTextBox.Text == "")
                passwordErrorProvider.SetError(passwordTextBox, "Password string can not be empty");
            if (groupComboBox.SelectedItem == null)
                groupErrorProvider.SetError(groupComboBox, "Group field can not be empty");
            departmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            specialityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            groupComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            teacherNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            specialityComboBox.Enabled = false;
            groupComboBox.Enabled = false;
            
        }

        private void singUpButton_Click(object sender, EventArgs e)
        {
            if (studentRadio.Checked)
                if (checkLoginCorrection() && checkPasswordCorrection() && checkNameCorrection() && checkGroupCorrection())
                {
                    student.RegisterAsStudent(this).ExecuteScalar();
                    loginTextBox.Clear();
                    passwordTextBox.Clear();
                    teacherNameComboBox.Items.Clear();
                    departmentComboBox.Items.Clear();
                    specialityComboBox.Items.Clear();
                    groupComboBox.Items.Clear();
                    Close();
                }
                if(checkLoginCorrection() && checkPasswordCorrection())
                {
                    teacher.RegisterAsTeacher(this).ExecuteScalar();
                    loginTextBox.Clear();
                    passwordTextBox.Clear();
                    teacherNameComboBox.Items.Clear();
                    departmentComboBox.Items.Clear();
                    specialityComboBox.Items.Clear();
                    groupComboBox.Items.Clear();
                    Close();
                }
                else { }
            /*if (checkLoginCorrection() && checkPasswordCorrection())
            {
                if (studentRadio.Checked && checkNameCorrection())
                    student.RegisterAsStudent(this).ExecuteScalar();
                else if (teacherRadio.Checked)
                    teacher.RegisterAsTeacher(this).ExecuteScalar();
                loginTextBox.Clear();
                passwordTextBox.Clear();
                teacherNameComboBox.Items.Clear();
                departmentComboBox.Items.Clear();
                specialityComboBox.Items.Clear();
                groupComboBox.Items.Clear();
                Close();
            }
            else 
            { }*/
        }

        private void studentRadio_CheckedChanged(object sender, EventArgs e)
        {
            singUpButton.Enabled = true;
            teacherNameComboBox.Visible = false;
            nameTextBox.Visible = true;
            departmentLabel.Visible = true;
            specialityLabel.Visible = true;
            groupLabel.Visible = true;
            departmentComboBox.Visible = true;
            specialityComboBox.Visible = true;
            groupComboBox.Visible = true;
            loginTextBox.Clear();
            loginTextBox.Enabled = false;
            passwordTextBox.Enabled = false;
            passwordTextBox.Clear();
            teacherNameComboBox.SelectedItem = null;
        }

        private void teacherRadio_CheckedChanged(object sender, EventArgs e)
        {

            
            singUpButton.Enabled = true;
            nameTextBox.Visible = false;
            teacherNameComboBox.Visible = true;
            departmentLabel.Visible = false;
            specialityLabel.Visible = false;
            groupLabel.Visible = false;
            departmentComboBox.Visible = false;
            specialityComboBox.Visible = false;
            groupComboBox.Visible = false;
            loginTextBox.Clear();
            passwordTextBox.Clear();
            nameTextBox.Clear();
            if(teacherNameComboBox.SelectedItem == null)
            {
                loginTextBox.Enabled = false;
                passwordTextBox.Enabled = false;
            }
        }

        private void getTeacherName()
        {
            string query = @"USE LearningAppDB
                            SELECT DISTINCT [TeacherName] FROM dbo.PrefilledInfo
E                           EXCEPT SELECT [Name] FROM dbo.TeacherAccountInfo";
            SqlCommand command = new SqlCommand(query, LoginForm.connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                teacherNameComboBox.Items.Add(reader[0]);
            }
            reader.Close();
        }
        private void getDepartment()
        {
            string query = @"SELECT DISTINCT [Department] FROM dbo.PrefilledInfo";
            command = new SqlCommand(query, LoginForm.connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                departmentComboBox.Items.Add(reader[0]);
            }
            reader.Close();
        }
        private void GetSpeciality()
        {
            query = $@"SELECT DISTINCT [Speciality] FROM dbo.PrefilledInfo";
            //WHERE [Department] = '{departmentComboBox.SelectedItem.ToString()}'";
            command = new SqlCommand(query, LoginForm.connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                specialityComboBox.Items.Add(reader[0]);
            }
            reader.Close();
        }
        private void GetGroup()
        {
            query = $@"SELECT DISTINCT [Group] FROM dbo.PrefilledInfo";
            //WHERE [Speciality] = '{specialityComboBox.SelectedItem.ToString()}'";
            command = new SqlCommand(query, LoginForm.connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                groupComboBox.Items.Add(reader[0]);
            }
            reader.Close();
        }

        private void updateSpeciality()
        {
            specialityComboBox.Items.Clear();
            query = $@"SELECT DISTINCT [Speciality] FROM dbo.PrefilledInfo
            WHERE [Department] = '{departmentComboBox.SelectedItem.ToString()}'";
            command = new SqlCommand(query, LoginForm.connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                specialityComboBox.Items.Add(reader[0]);
            }
            reader.Close();
        }

        public void updateGroup()
        {
            groupComboBox.Items.Clear();
            query = $@"SELECT DISTINCT [Group] FROM dbo.PrefilledInfo
            WHERE [Speciality] = '{specialityComboBox.SelectedItem.ToString()}'";
            command = new SqlCommand(query, LoginForm.connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                groupComboBox.Items.Add(reader[0]);
            }
            reader.Close();
        }

        public void updateRegistrationInfo()
        {
            teacherNameComboBox.Items.Clear();
            departmentComboBox.Items.Clear();
            specialityComboBox.Items.Clear();
            groupComboBox.Items.Clear();

            getTeacherName();
            getDepartment();
            GetSpeciality();
            GetGroup(); 
        }

        private void getAllLoginsList()
        {
            
            string query = @"SELECT  dbo.[TeacherAccountInfo].[Login] FROM dbo.TeacherAccountInfo
                             UNION SELECT[Login] FROM dbo.StudentAccountInfo";
            SqlCommand command = new SqlCommand(query, LoginForm.connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                allLoginsList.Add(reader[0].ToString());
            reader.Close();
        }

        public bool checkLoginCorrection()
        {
            allLoginsList.Add("");
            
            if (loginTextBox.Text.Length > 40 || allLoginsList.Contains(loginTextBox.Text) || loginTextBox.Text.Contains(" "))
            {
                if(loginTextBox.Text.Length > 40)
                    loginErrorProvider.SetError(loginTextBox, "Login is too long");
                if(allLoginsList.Contains(loginTextBox.Text))
                    if(loginTextBox.Text == "")
                        loginErrorProvider.SetError(loginTextBox, "Login field can not be empty");
                    else loginErrorProvider.SetError(loginTextBox, "Such login is already created");
                if(loginTextBox.Text.Contains(" "))
                    loginErrorProvider.SetError(loginTextBox, "Login field can not contain empty spaces");
            }
            else loginErrorProvider.SetError(loginTextBox, "");
            if (loginErrorProvider.GetError(loginTextBox) == "")
                return true;
            else return false;
        }

        public bool checkPasswordCorrection()
        {
            
            if (passwordTextBox.Text.Length > 40 || passwordTextBox.Text.Length == 0 || passwordTextBox.Text.Contains(" "))
            {
                if (passwordTextBox.Text.Length > 40)
                    passwordErrorProvider.SetError(passwordTextBox, "Password is too long");
                if (passwordTextBox.Text.Length == 0)
                        passwordErrorProvider.SetError(passwordTextBox, "Password field can not be empty");
                if (passwordTextBox.Text.Contains(" "))
                    passwordErrorProvider.SetError(passwordTextBox, "Password field can not contain empty spaces");
            }
            else passwordErrorProvider.SetError(passwordTextBox, "");
            if (passwordErrorProvider.GetError(passwordTextBox) == "")
                return true;
            else return false;
        }

        public bool checkNameCorrection()
        {
            if (nameTextBox.Text.Length > 40 || nameTextBox.Text.Length == 0)
            {
                if (nameTextBox.Text.Length > 40)
                    nameErrorProvider.SetError(nameTextBox, "Name is too long");
                if (nameTextBox.Text.Length == 0)
                    nameErrorProvider.SetError(nameTextBox, "Name field can not be empty");
            }
            else nameErrorProvider.SetError(nameTextBox, "");
            if (nameErrorProvider.GetError(nameTextBox) == "")
                return true;
            else return false;
        }

        public bool checkGroupCorrection()
        {
            if (groupComboBox.SelectedItem == null)
            {
                groupErrorProvider.SetError(groupComboBox, "Group field can not be empty");
                return false;
            }
            else
            {
                groupErrorProvider.SetError(groupComboBox, "");
                return true;
            }
        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            checkLoginCorrection();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            checkPasswordCorrection();
        }

        private void departmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateSpeciality();
            specialityComboBox.Enabled = true;
        }

        private void specialityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateGroup();
            groupComboBox.Enabled = true;
            groupErrorProvider.SetError(groupComboBox, "Group field can not be empty");
        }

        private void teacherNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loginTextBox.Enabled = true;
            passwordTextBox.Enabled = true;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if(checkNameCorrection())        
            {
                loginTextBox.Enabled = true;
                passwordTextBox.Enabled = true;
            }
            else
            {
                loginTextBox.Enabled = false;
                passwordTextBox.Enabled = false;
            }
        }

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkGroupCorrection();
        }
    }
}
