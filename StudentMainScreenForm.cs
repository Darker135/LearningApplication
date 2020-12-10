using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace LearningApplication
{
    public partial class StudentMainScreenForm : Form
    {
        public static string theme;
        TestPassingForm passingForm = new TestPassingForm();
        static int counter = 0;
        List<string> MaterialList = new List<string>();
        static string group { get; set; }
        SqlCommand command;
        SqlDataReader reader;
        string query;
        public StudentMainScreenForm()
        {
            InitializeComponent();
        }
        
        public static StudentMainScreenForm studentMainScreenForm = new StudentMainScreenForm();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (counter - 1 >= 0)
            {
                counter--;
                previousLabel.Visible = true;
                nextLabel.Visible = true;
                materialTextBox.Text = MaterialList[counter];
                if (counter - 1 < 0)
                    previousLabel.Visible = false;
                if (counter + 1 == MaterialList.Count)
                    testButton.Enabled = true;
                else testButton.Enabled = false;
            }
            //else previousLabel.Visible = false;
            //if(richTextBox1.SelectedText != string.Empty) urichTextBox1.SelectedText = "aaa";
        }

        private void StudentMainScreenForm_Load(object sender, EventArgs e)
        {
            previousLabel.Visible = false;
            nextLabel.Visible = false;
            GetDisciplines();
            //materialTextBox.Text = LoginForm.loginForm.login;
        }

        private void StudentMainScreenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GetDisciplines()
        {
            disciplineComboBox.Items.Clear();
            query = $@"SELECT [Group] FROM dbo.StudentAccountInfo WHERE [Login] = '{LoginForm.loginForm.login}'";
            command = new SqlCommand(query, LoginForm.connection);
            group = command.ExecuteScalar().ToString();
            query = $@"SELECT DISTINCT [Discipline] FROM dbo.Disciplines WHERE [Group] = '{group}'";
            command = new SqlCommand(query, LoginForm.connection);
            reader = command.ExecuteReader();
            while (reader.Read())
                disciplineComboBox.Items.Add(reader[0]);
            reader.Close();
        }

        private void GetThemes()
        {
            themeComboBox.Items.Clear();
            query = $@"SELECT DISTINCT [Theme] FROM dbo.Material WHERE [Discipline] = '{disciplineComboBox.SelectedItem}'
                    AND [Group] = '{group}'";
            command = new SqlCommand(query, LoginForm.connection);
            reader = command.ExecuteReader();
            while (reader.Read())
                themeComboBox.Items.Add(reader[0]);
            reader.Close();
        }

        private void GetMaterial()
        {
            MaterialList.Clear();
            materialTextBox.Text = string.Empty;
            query = $@"SELECT DISTINCT [MaterialText] FROM dbo.Material WHERE [Theme] = '{themeComboBox.SelectedItem}'
                    AND [MaterialText] <> ' '";
            command = new SqlCommand(query, LoginForm.connection);
            reader = command.ExecuteReader();
            while (reader.Read())
                MaterialList.Add(reader[0].ToString());
            reader.Close();
        }
        private bool QuestionsExists()
        {
            List<string> NoExistQuestions = new List<string>();
            query = "SELECT [Theme] FROM dbo.Material EXCEPT SELECT [Theme] FROM dbo.QuestionTable";
            command = new SqlCommand(query, LoginForm.connection);
            reader = command.ExecuteReader();
            while (reader.Read())
                NoExistQuestions.Add(reader[0].ToString());
            reader.Close();
            if (!NoExistQuestions.Contains(themeComboBox.SelectedItem.ToString()))
                return true;
            else return false;
        }
        private bool TestCompleted()
        {
            List<string> Logins = new List<string>();
            List<string> Themes = new List<string>();
            query = "SELECT [Login], [Theme] FROM dbo.TestingResults";
            command = new SqlCommand(query, LoginForm.connection);
            reader = command.ExecuteReader();
            while(reader.Read())
            {
                Logins.Add(reader[0].ToString());
                Themes.Add(reader[1].ToString());
            }
            reader.Close();
            if (Logins.Contains(LoginForm.loginForm.login) && Themes.Contains(themeComboBox.SelectedItem.ToString()))
            {
                return true;
            }
            else return false;
        }

        private void disciplineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetThemes();
        }

        private void nextLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (counter + 1 < MaterialList.Count)
            {
                counter++;
                nextLabel.Visible = true;
                previousLabel.Visible = true;
                materialTextBox.Text = MaterialList[counter];
                testButton.Enabled = true;
                if (counter + 1 >= MaterialList.Count)
                {
                    nextLabel.Visible = false;
                    testButton.Enabled = false;
                }
                if (counter + 1 == MaterialList.Count)
                    testButton.Enabled = true;
                else testButton.Enabled = false;
            }
            else nextLabel.Visible = false;
        }

        private void themeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nextLabel.Visible = true;
            counter = 0;
            GetMaterial();
            materialTextBox.Text = MaterialList[counter];
            previousLabel.Visible = false;
            //testButton.Enabled = false;
            if (counter + 1 == MaterialList.Count)
            {
                testButton.Enabled = true;
                //nextLabel.Visible = true;
            }
            else
            {
                //nextLabel.Visible = false;
                testButton.Enabled = false;
            }
            if (MaterialList.Count == 1)
                nextLabel.Visible = false;
            else 
                nextLabel.Visible = true;
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            if (QuestionsExists())
            {
                if (!TestCompleted())
                {
                    theme = themeComboBox.Text;
                    passingForm.ShowDialog();
                }
                else MessageBox.Show("Тест уже пройден", "ОК");
            }
            else MessageBox.Show("Тест к выбраной теме отсутствует", "ОК");
        }
    }
}


//Получить инфо о студенте(группа)(через ключ - логин)
//Получить специальности для группы
//Получить темы где тема == специальности && группе
//массив листов тем где в листах учебный материал, проходится один лист - начинается другой,
    //между этим нужна проверка пройден ли тест по теме