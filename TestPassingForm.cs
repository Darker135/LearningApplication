using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LearningApplication
{
    public partial class TestPassingForm : Form
    {
        static int counter = 0;
        static List<string> Answers = new List<string>();
        /*static Dictionary<string, string> Questions = new Dictionary<string, string>();*/
        static List<string> QuestionsList = new List<string>();
        string query;
        SqlCommand command;
        SqlDataReader reader;
        public TestPassingForm()
        {
            InitializeComponent();
        }

        private void TestPassingForm_Load(object sender, EventArgs e)
        {
            GetTest();
            textBox1.Text = QuestionsList[0];
        }

        private void GetTest()
        {
            QuestionsList.Clear();
            Answers.Clear();
            /*Questions.Clear();*/
            query = $@"SELECT DISTINCT [QuestionText], [QuestionAnswer] FROM dbo.QuestionTable WHERE [Theme] = '{StudentMainScreenForm.theme}'";
            command = new SqlCommand(query, LoginForm.connection);
            reader = command.ExecuteReader();
            while(reader.Read())
            {
                QuestionsList.Add(reader[0].ToString());
                Answers.Add(reader[1].ToString());
                /*Questions.Add(reader[1].ToString(), reader[0].ToString());*/
            }
            reader.Close();
        }

        private bool CheckCorrection()
        {
            query = $@"SELECT [id] FROM dbo.QuestionTable WHERE [QuestionText] = '{textBox1.Text}'";
            command = new SqlCommand(query, LoginForm.connection);
            int id = (int)command.ExecuteScalar();
            query = $@"SELECT [QuestionAnswer] FROM dbo.QuestionTable WHERE [id] = {id}";
            command = new SqlCommand(query, LoginForm.connection);
            string answer = command.ExecuteScalar().ToString();
            if (textBox1.SelectedText == answer)
                return true;
            else
                return false;
        }

        private void NextQuestion()
        {
            if(counter + 1 < QuestionsList.Count)
            {
                counter++;
                textBox1.Text = QuestionsList[counter];
            }
            else
            {
                MessageBox.Show("Тест завершен", "OK");
                Close();
            }
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            if(CheckCorrection())
            {
                query = $@"INSERT INTO dbo.TestingResults VALUES ('{LoginForm.loginForm.login}', '{textBox1.Text}',
                        '{StudentMainScreenForm.theme}', 1)";
                command = new SqlCommand(query, LoginForm.connection);
                command.ExecuteScalar();
                NextQuestion();
            }
            else
            {
                query = $@"INSERT INTO dbo.TestingResults VALUES ('{LoginForm.loginForm.login}', '{textBox1.Text}',
                        '{StudentMainScreenForm.theme}', 0)";
                command = new SqlCommand(query, LoginForm.connection);
                command.ExecuteScalar();
                NextQuestion();
            }
        }
    }
}
