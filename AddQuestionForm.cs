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
    public partial class AddQuestionForm : Form, IAddQuestionController
    {
        
        SqlCommand command;
        string query;
        SqlDataReader reader;
        Teacher teacher = new Teacher();

        public ListBox discipline { get { return disciplineListBox; } set { disciplineListBox = value; }  }
        public CheckedListBox groups { get { return groupCheck; } set { groupCheck = value; } }
        public string theme { get { return themeTextBox.Text; } set { themeTextBox.Text = value; }  }
        public string question { get { return questionTextBox.Text; } set { questionTextBox.Text = value; } }
        public string answer { get { return answerTextBox.Text; } set { answerTextBox.Text = value; } }

        public AddQuestionForm()
        {
            InitializeComponent();
        }

        private void GetDisciplines()
        {
            query = @"SELECT DISTINCT [Discipline] FROM dbo.Disciplines";
            command = new SqlCommand(query, LoginForm.connection);
            reader = command.ExecuteReader();
            while (reader.Read())
                disciplineListBox.Items.Add(reader[0]);
            reader.Close();
        }

        private void GetGroups()
        {
            query = @$"SELECT DISTINCT [Group] FROM dbo.Disciplines 
                       WHERE dbo.Disciplines.[Discipline] = '{disciplineListBox.SelectedItem}'";
            command = new SqlCommand(query, LoginForm.connection);
            reader = command.ExecuteReader();
            while (reader.Read())
                groupCheck.Items.Add(reader[0]);
            reader.Close();
        }

        private void disciplineListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupCheck.Items.Clear();
            GetGroups();
            if(groupCheck.CheckedItems.Count == 0)
                groupErrorProvider.SetError(groupCheck, "Checked groups can not be empty");
            if(themeTextBox.Text == string.Empty)
                themeErrorProvider.SetError(themeTextBox, "Theme field can not be empty");
            addQuestionButton.Enabled = true;
        }

        private void AddQuestionForm_Load(object sender, EventArgs e)
        {
            addQuestionButton.Enabled = false;
            groupCheck.Items.Clear();
            disciplineListBox.Items.Clear();
            GetDisciplines();
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            if (themeErrorProvider.GetError(themeTextBox) == "" && groupErrorProvider.GetError(groupCheck) == ""
                && questionErrorProvider.GetError(questionTextBox) == "" && AnswerErrorProvider.GetError(answerTextBox) == "")
            { 
                teacher.AddQuestion(this);
                Close();
            }
            
        }

        

        private void groupCheck_SelectedValueChanged(object sender, EventArgs e)
        {
            /*if (groupCheck.CheckedItems.Count == 0)
                groupErrorProvider.SetError(groupCheck, "Checked groups can not be empty");
            else groupErrorProvider.SetError(groupCheck, "");*/
        }

        private void themeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (themeTextBox.Text == "")
                themeErrorProvider.SetError(themeTextBox, "Theme field can not be empty");
            else themeErrorProvider.SetError(themeTextBox, "");
        }

        private void questionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (questionTextBox.Text == "")
                questionErrorProvider.SetError(questionTextBox, "Question field can not be empty");
            else questionErrorProvider.SetError(questionTextBox, "");
        }

        private void answerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (answerTextBox.Text == "")
                AnswerErrorProvider.SetError(answerTextBox, "Question field can not be empty");
            else AnswerErrorProvider.SetError(answerTextBox, "");
        }

        private void groupCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupCheck.CheckedItems.Count == 0)
                groupErrorProvider.SetError(groupCheck, "Checked groups can not be empty");
            else groupErrorProvider.SetError(groupCheck, "");
        }
    }
}
