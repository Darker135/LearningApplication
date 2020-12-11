using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LearningApplication
{
    public partial class DeleteMaterialForm : Form
    {
        string query;
        SqlCommand command;
        SqlDataReader reader;
        public DeleteMaterialForm()
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
            query = @$"SELECT [MaterialText] FROM dbo.Material 
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
            query = @$"SELECT [MaterialText] FROM dbo.Material WHERE [MaterialText] = '{materialListBox.SelectedItem}'";
            command = new SqlCommand(query, LoginForm.connection);
            reader = command.ExecuteReader();
            while (reader.Read())
                materialTextBox.Text = reader[0].ToString();
            reader.Close();
        }
        private void DeleteMaterial()
        {
            query = @$"DELETE FROM dbo.Material WHERE [MaterialText] = '{materialListBox.SelectedItem}'";
            command = new SqlCommand(query, LoginForm.connection);
            command.ExecuteScalar();
            /*query = "DELETE FROM dbo.Material WHERE [MaterialText] = ' '";
            command.ExecuteScalar();*/
        }
        private void DeleteMaterialForm_Load(object sender, EventArgs e)
        {
            themeComboBox.Enabled = false;
            materialListBox.Enabled = false;
            materialTextBox.Enabled = false;
            disciplineComboBox.Items.Clear();
            themeComboBox.Items.Clear();
            materialListBox.Items.Clear();
            materialTextBox.Text = "";
            GetDisciplines();
            deleteButton.Enabled = false;
            materialTextBox.ReadOnly = true;
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
            deleteButton.Enabled = true;
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteMaterial();
            Close();
        }
    }
}
