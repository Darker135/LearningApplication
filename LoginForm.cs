using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LearningApplication
{
    public partial class LoginForm : Form, ILoginController
    {
        public static LoginForm loginForm = new LoginForm();
        public const string connectionString = @"Data Source=DESKTOP-TDD2QC5;Initial Catalog=LearningAppDB;Integrated Security=True";
        public static SqlConnection connection = new SqlConnection(connectionString);
        readonly Student student = new Student();
        readonly Teacher teacher = new Teacher();
        //TeacherMainScreenForm teacherMainScreen = new TeacherMainScreenForm();
        public string login { get { return loginTextBox.Text; } set { loginTextBox.Text = value; } }
        public string password { get { return passwordTextBox.Text; } set { passwordTextBox.Text = value; } }
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            connection.Open();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            loginForm.login = loginTextBox.Text;
            if (teacher.ProveTeacher(this))
            {
                TeacherMainScreenForm.teacherMainScreenForm.Show();
                Hide();
            }
            else if(student.ProveStudent(this))
            {
                StudentMainScreenForm.studentMainScreenForm.Show();                
                Hide();
            }
        }
        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm.registrationForm.ShowDialog();
        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
            Application.Exit();
        }
    }
}
