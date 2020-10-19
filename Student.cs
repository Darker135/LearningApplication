using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace LearningApplication
{
    class Student
    {
        string query;
        public SqlCommand RegisterAsStudent(RegistrationForm form)
        {
            query = $@"INSERT INTO dbo.StudentAccountInfo (Name, Login, Password, IsRegistered, Department, Speciality, [Group])
                        VALUES ('{form.name}', '{form.login}', '{form.password}', 'True', '{form.department}', '{form.speciality}', '{form.group}')";
            SqlCommand command = new SqlCommand(query, LoginForm.connection);
            return command;
        }

        public bool ProveStudent(LoginForm form)
        {
            List<string> StudentLogins = new List<string>();
            List<string> StudentPasswords = new List<string>();
            query = "SELECT [Login], [Password] FROM dbo.StudentAccountInfo";
            SqlCommand command = new SqlCommand(query, LoginForm.connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                StudentLogins.Add(reader[0].ToString());
                StudentPasswords.Add(reader[1].ToString());
            }
            reader.Close();
            return StudentLogins.Contains(form.login) && StudentPasswords.Contains(form.password);
        }
    }
}
