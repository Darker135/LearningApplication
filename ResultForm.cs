using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace LearningApplication
{
    public partial class ResultForm : Form
    {
        static string fullPath;
        string query;
        SqlCommand command;
        SqlDataReader reader;
        List<string> ThemesInSelectedLogin = new List<string>();
        Dictionary<string, string> StudentsInSelectedGroup = new Dictionary<string, string>();
        Dictionary<string, int> AnsweredThemes = new Dictionary<string, int>();
        Dictionary<string, int> CorrectlyAnsweredThemes = new Dictionary<string, int>();
        static string data = "";
        public ResultForm()
        {
            InitializeComponent();
        }
        private void GroupResultForm_Load(object sender, EventArgs e)
        {
            data = string.Empty;
            disciplineComboBox.Items.Clear();
            groupComboBox.Items.Clear();
            studentNameComboBox.Items.Clear();
            pathTextBox.Text = string.Empty;
            pathTextBox.ReadOnly = false;
            GetDiscipline();
            saveButton.Enabled = false;
        }
        private void GetDiscipline()
        {
            disciplineComboBox.Items.Clear();
            query = $@"SELECT DISTINCT [Discipline] FROM dbo.Disciplines";
            command = new SqlCommand(query, LoginForm.connection);
            reader = command.ExecuteReader();
            while (reader.Read())
                disciplineComboBox.Items.Add(reader[0]);
            reader.Close();
        }
        private void GetGroups()
        {
            groupComboBox.Items.Clear();
            query = $@"SELECT DISTINCT [Group] FROM dbo.Disciplines WHERE [Discipline] = '{disciplineComboBox.SelectedItem}'";
            command = new SqlCommand(query, LoginForm.connection);
            reader = command.ExecuteReader();
            while (reader.Read())
                groupComboBox.Items.Add(reader[0]);
            reader.Close();
        }
        private void GetStudentsInGroup()
        {
            StudentsInSelectedGroup.Clear();
            studentNameComboBox.Items.Clear();
            query = $@"SELECT DISTINCT [Login], [Name] FROM dbo.StudentAccountInfo WHERE [Group] = '{groupComboBox.SelectedItem}'";
            command = new SqlCommand(query, LoginForm.connection);
            reader = command.ExecuteReader();
            while (reader.Read())
                StudentsInSelectedGroup.Add(reader[0].ToString(), reader[1].ToString());
            reader.Close();
            foreach (var student in StudentsInSelectedGroup)
                studentNameComboBox.Items.Add(student.Value);
        }
        private void GetThemesInLogin()
        {
            query = $@"SELECT [Login] FROM dbo.StudentAccountInfo WHERE [Name] = '{studentNameComboBox.SelectedItem}'";
            command = new SqlCommand(query, LoginForm.connection);
            string login = command.ExecuteScalar().ToString();
            AnsweredThemes.Clear();
            CorrectlyAnsweredThemes.Clear();
            query = $@"SELECT DISTINCT [Theme] FROM dbo.TestingResults WHERE [Login] = '{login}'";
            command = new SqlCommand(query, LoginForm.connection);
            reader = command.ExecuteReader();
            while (reader.Read())
                ThemesInSelectedLogin.Add(reader[0].ToString());
            reader.Close();
            foreach(string theme in ThemesInSelectedLogin)
            {
                query = $@"SELECT COUNT([Theme]) FROM dbo.TestingResults WHERE [Theme] = '{theme}'";
                command = new SqlCommand(query, LoginForm.connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                    AnsweredThemes.Add(theme, (int)reader[0]);
                reader.Close();
            }
            foreach (string theme in ThemesInSelectedLogin)
            {
                query = $@"SELECT COUNT([Theme]) FROM dbo.TestingResults WHERE [Theme] = '{theme}' AND [IsCorrect] = 1";
                command = new SqlCommand(query, LoginForm.connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                    CorrectlyAnsweredThemes.Add(theme, (int)reader[0]);
                reader.Close();
            }
        }
        private string CalculateThemeMark()
        {
            string str = "";
            int wholeAnswered;
            int correctlyAnswered;
            foreach (var theme in ThemesInSelectedLogin)
            {
                AnsweredThemes.TryGetValue(theme, out wholeAnswered);
                CorrectlyAnsweredThemes.TryGetValue(theme, out correctlyAnswered);
                if(correctlyAnswered >= wholeAnswered / 2 && correctlyAnswered != 0)
                {
                    str += $"{theme} - {correctlyAnswered}/{wholeAnswered} - Оценка удовлетворительная\n";
                }
                else
                {
                    str += $"{theme} - {correctlyAnswered}/{wholeAnswered} - Оценка не удовлетворительная\n";
                }
            }
            return str;
        }
        private void disciplineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupComboBox.Items.Clear();
            studentNameComboBox.Items.Clear();
            GetGroups();
        }
        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentNameComboBox.Items.Clear();
            GetStudentsInGroup();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            fullPath = pathTextBox.Text + $@"\{studentNameComboBox.SelectedItem}.txt".Replace(" ", "");
            using (var stream = File.Create(fullPath))
            {
                stream.Dispose();
            }
            GetThemesInLogin();
            data += $"Студент {studentNameComboBox.SelectedItem}\n" + CalculateThemeMark();
            using (StreamWriter writer = new StreamWriter(fullPath, false))
            {
                writer.Write(data);
            }
            AnsweredThemes.Clear();
            ThemesInSelectedLogin.Clear();
            StudentsInSelectedGroup.Clear();
            Close();
        }
        private void directoryButton_Click(object sender, EventArgs e)
        {
            pathTextBox.Text = string.Empty;
            pathDialog.ShowDialog();
            pathTextBox.Text = pathDialog.SelectedPath;
            pathTextBox.ReadOnly = true;
            saveButton.Enabled = true;
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
