using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;

namespace LearningApplication
{
    class Teacher
    {
        public string query;
        
        public bool ProveTeacher(LoginForm form)
        {
            List<string> TeacherLogins = new List<string>();
            List<string> TeacherPasswords = new List<string>();
            query = "SELECT [Login], [Password] FROM dbo.TeacherAccountInfo";
            SqlCommand command = new SqlCommand(query, LoginForm.connection);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                TeacherLogins.Add(reader[0].ToString());
                TeacherPasswords.Add(reader[1].ToString());
            }
            reader.Close();
            return TeacherLogins.Contains(form.login) && TeacherPasswords.Contains(form.password);
        }

        public SqlCommand RegisterAsTeacher(RegistrationForm form)
        {
            query = $@"INSERT INTO dbo.TeacherAccountInfo (Name, Login, Password, IsRegistered)
                        VALUES ('{form.teacherName}', '{form.login}', '{form.password}', 'True')";
            SqlCommand command = new SqlCommand(query, LoginForm.connection);
            return command;
        }

        public void AddQuestion(AddQuestionForm form)
        {
            foreach(var group in form.groups.CheckedItems)
            {
                query = @$"INSERT INTO dbo.Questions VALUES('{form.discipline.SelectedItem}',
                        '{form.question}', '{form.answer}', '{group}', '{form.theme}')";
                SqlCommand command = new SqlCommand(query, LoginForm.connection);
                command.ExecuteScalar();
            }
        }
    }
}
