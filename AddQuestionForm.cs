using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LearningApplication
{
    
    public partial class AddQuestionForm : Form
    {
        string query;
        SqlCommand command;
        SqlDataReader reader;
        public AddQuestionForm()
        {
            InitializeComponent();
        }

        private void AddQuestionForm_Load(object sender, EventArgs e)
        {
            disciplineComboBox.Items.Clear();
            themeComboBox.Items.Clear();
            groupListBox.Items.Clear();
            GetDisciplines();
            themeComboBox.Enabled = false;
            groupListBox.Enabled = false;
            questionTextBox.Enabled = false;
            answerTextBox.Enabled = false;
            addQuestionButton.Enabled = false;
        }

        private void GetDisciplines()
        {
            query = @"SELECT DISTINCT [Discipline] FROM dbo.Disciplines";
            command = new SqlCommand(query, LoginForm.connection);
            reader = command.ExecuteReader();
            while (reader.Read())
                disciplineComboBox.Items.Add(reader[0]);
            reader.Close();
        }
        private void GetThemes()
        {
            query = @$"SELECT DISTINCT [Theme] FROM dbo.Material WHERE [Discipline] = '{disciplineComboBox.SelectedItem}'";
            command = new SqlCommand(query, LoginForm.connection);
            reader = command.ExecuteReader();
            while (reader.Read())
                themeComboBox.Items.Add(reader[0]);
            reader.Close();
        }
        private void GetGroups()
        {
            query = @$"SELECT DISTINCT [Group] FROM dbo.Disciplines 
                       WHERE dbo.Disciplines.[Discipline] = '{disciplineComboBox.SelectedItem}'";
            command = new SqlCommand(query, LoginForm.connection);
            reader = command.ExecuteReader();
            while (reader.Read())
                groupListBox.Items.Add(reader[0]);
            reader.Close();
        }

        private void disciplineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupListBox.Items.Clear();
            themeComboBox.Items.Clear();
            questionTextBox.Text = string.Empty;
            answerTextBox.Text = string.Empty;
            GetThemes();
            themeComboBox.Enabled = true;
        }

        private void themeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupListBox.Items.Clear();
            questionTextBox.Text = string.Empty;
            answerTextBox.Text = string.Empty;
            GetGroups();
            groupListBox.Enabled = true;
        }

        private void AddQuestion()
        {
            if (questionTextBox.Text.Contains(answerTextBox.Text))
                foreach (var group in groupListBox.CheckedItems)
                {
                    query = @$"INSERT INTO dbo.QuestionTable VALUES('{group}',
                        '{questionTextBox.Text}', '{answerTextBox.Text}', '{themeComboBox.SelectedItem}',
                        '{disciplineComboBox.SelectedItem}')";
                    SqlCommand command = new SqlCommand(query, LoginForm.connection);
                    command.ExecuteScalar();
                    Close();
                }
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            
            if(groupListBox.CheckedItems.Count != 0)
            {
                if (!(questionTextBox.Text == string.Empty || answerTextBox.Text == string.Empty))
                    AddQuestion();
                else MessageBox.Show("Введите вопрос и ответ", "ОК");
            }                
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if(groupListBox.CheckedItems.Count != 0)
            {
                questionTextBox.Enabled = true;
                answerTextBox.Enabled = true;
                addQuestionButton.Enabled = true;
            }
            else
            {
                questionTextBox.Enabled = false;
                answerTextBox.Enabled = false;
                addQuestionButton.Enabled = false;
            }
        }

        private void answerTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
