using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LearningApplication
{
    public partial class CorrectAnswersForm : Form
    {
        string query;
        SqlCommand command;
        SqlDataReader reader;
        public CorrectAnswersForm()
        {
            InitializeComponent();
        }
        private void CorrectAnswersForm_Load(object sender, EventArgs e)
        {
            disciplineComboBox.Items.Clear();
            themeComboBox.Items.Clear();
            questionListBox.Items.Clear();
            answerTextBox.Text = string.Empty;
            GetDisciplines();
        }
        private void GetDisciplines()
        {
            disciplineComboBox.Items.Clear();
            query = @"SELECT DISTINCT [Discipline] FROM dbo.Disciplines";
            command = new SqlCommand(query, LoginForm.connection);
            reader = command.ExecuteReader();
            while (reader.Read())
                disciplineComboBox.Items.Add(reader[0]);
            reader.Close();
        }
        private void GetThemes()
        {
            themeComboBox.Items.Clear();
            query = @$"SELECT DISTINCT [Theme] FROM dbo.Material WHERE [Discipline] = '{disciplineComboBox.SelectedItem}'";
            command = new SqlCommand(query, LoginForm.connection);
            reader = command.ExecuteReader();
            while (reader.Read())
                themeComboBox.Items.Add(reader[0]);
            reader.Close();
        }
        private void GetQuestions()
        {
            questionListBox.Items.Clear();
            query = @$"SELECT DISTINCT [QuestionText] FROM dbo.QuestionTable WHERE [Theme] = '{themeComboBox.SelectedItem}'";
            command = new SqlCommand(query, LoginForm.connection);
            reader = command.ExecuteReader();
            while (reader.Read())
                questionListBox.Items.Add(reader[0]);
            reader.Close();
        }
        private void GetAnswers()
        {
            answerTextBox.Text = string.Empty;
            query = @$"SELECT DISTINCT [QuestionAnswer] FROM dbo.QuestionTable WHERE [QuestionText] = '{questionListBox.SelectedItem}'";
            command = new SqlCommand(query, LoginForm.connection);
            answerTextBox.Text = command.ExecuteScalar().ToString();
        }
        private void disciplineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            themeComboBox.Items.Clear();
            questionListBox.Items.Clear();
            answerTextBox.Text = string.Empty;
            GetThemes();
        }
        private void themeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            questionListBox.Items.Clear();
            answerTextBox.Text = string.Empty;
            GetQuestions();
        }
        private void questionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            answerTextBox.Text = string.Empty;
            GetAnswers();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
