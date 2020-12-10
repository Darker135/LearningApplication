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
    public partial class ChangeMaterialForm : Form
    {
        string query;
        SqlCommand command;
        SqlDataReader reader;
        public ChangeMaterialForm()
        {
            InitializeComponent();
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

        private void GetMaterial()
        {
            query = @$"SELECT DISTINCT [MaterialText] FROM dbo.Material 
                    WHERE [Theme] = '{themeComboBox.SelectedItem}'
                    AND [MaterialText] <> ' '";
            command = new SqlCommand(query, LoginForm.connection);
            reader = command.ExecuteReader();
            while (reader.Read())
                materialListBox.Items.Add(reader[0]);
            reader.Close();
        }

        private void GetMaterialText()
        {
            query = @$"SELECT DISTINCT [MaterialText] FROM dbo.Material WHERE [MaterialText] = '{materialListBox.SelectedItem}'";
            command = new SqlCommand(query, LoginForm.connection);
            reader = command.ExecuteReader();
            while (reader.Read())
                materialTextBox.Text = reader[0].ToString();
            reader.Close();
        }
        private void SaveChanges()
        {
            query = @$"UPDATE dbo.Material SET [MaterialText] = '{materialTextBox.Text}' 
                       WHERE [MaterialText] = '{materialListBox.SelectedItem}'";
            command = new SqlCommand(query, LoginForm.connection);
            command.ExecuteScalar();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveChanges();
            Close();
        }

        private void ChangeMaterialForm_Load(object sender, EventArgs e)
        {
            themeComboBox.Enabled = false;
            materialListBox.Enabled = false;
            materialTextBox.Enabled = false;
            disciplineComboBox.Items.Clear();
            themeComboBox.Items.Clear();
            materialListBox.Items.Clear();
            materialTextBox.Text = "";
            GetDisciplines();
            saveButton.Enabled = false;
        }

        private void disciplineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            materialListBox.Items.Clear();
            materialTextBox.Text = string.Empty;
            themeComboBox.Items.Clear();
            GetThemes();
            themeComboBox.Enabled = true;
        }

        private void themeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            materialTextBox.Text = string.Empty;
            materialListBox.Items.Clear();
            GetMaterial();
            materialListBox.Enabled = true;
        }

        private void materialListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            materialTextBox.Text = string.Empty;            
            GetMaterialText();
            materialTextBox.Enabled = true;
            saveButton.Enabled = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
