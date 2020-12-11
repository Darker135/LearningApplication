using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LearningApplication
{
    public partial class ChangeQuestionForm : Form
    {
        string query;
        SqlCommand command;
        SqlDataReader reader;
        public ChangeQuestionForm()
        {
            InitializeComponent();
        }
        private void ChangeQuestionForm_Load(object sender, EventArgs e)
        {
            disciplineComboBox.Items.Clear();
            themeComboBox.Items.Clear();
            questionListBox.Items.Clear();
            questionTextBox.Text = string.Empty;
            answerTextBox.Text = string.Empty;
            GetDisciplines();
            saveButton.Enabled = false;
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
        private void GetQuestionsText()
        {
            questionTextBox.Text = string.Empty;
            answerTextBox.Text = string.Empty;
            questionTextBox.Text = questionListBox.SelectedItem.ToString();
            query = $@"SELECT DISTINCT [QuestionAnswer] FROM dbo.QuestionTable WHERE [QuestionText] = '{questionTextBox.Text}'";
            command = new SqlCommand(query, LoginForm.connection);
            answerTextBox.Text = command.ExecuteScalar().ToString();
        }
        private void SaveChanges()
        {
            query = $@"UPDATE dbo.QuestionTable SET [QuestionText] = '{questionTextBox.Text}', [QuestionAnswer] = '{answerTextBox.Text}'
                    WHERE [QuestionText] = '{questionListBox.SelectedItem}'";
            command = new SqlCommand(query, LoginForm.connection);
            command.ExecuteScalar();
        }
        private void themeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            questionTextBox.Text = string.Empty;
            answerTextBox.Text = string.Empty;
            GetQuestions();
        }
        private void disciplineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            questionTextBox.Text = string.Empty;
            answerTextBox.Text = string.Empty;
            questionListBox.Items.Clear();
            GetThemes();
        }
        private void questionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetQuestionsText();
            saveButton.Enabled = true;
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (questionTextBox.Text.Contains(answerTextBox.Text))
            {
                SaveChanges();
                Close();
            }
            else
                MessageBox.Show("Введен некорректный ответ", "ОК");
        }
    }
}
