﻿using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LearningApplication
{
    public partial class AddMaterialForm : Form, IAddMaterialController
    {
        SqlCommand command;
        string query;
        SqlDataReader reader;
        readonly Teacher teacher = new Teacher();
        public ListBox discipline { get { return disciplineListBox; } set { disciplineListBox = value; }  }
        public CheckedListBox groups { get { return groupCheck; } set { groupCheck = value; } }
        public string theme { get { return themeTextBox.Text; } set { themeTextBox.Text = value; }  }
        public string material { get { return materialTextBox.Text; } set { materialTextBox.Text = value; } }
        public AddMaterialForm()
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
            addMaterialButton.Enabled = true;
        }
        private void AddMaterialForm_Load(object sender, EventArgs e)
        {
            addMaterialButton.Enabled = false;
            groupCheck.Items.Clear();
            disciplineListBox.Items.Clear();
            GetDisciplines();
            themeTextBox.Text = string.Empty;
            materialTextBox.Text = string.Empty;
        }
        private void addMaterialButton_Click(object sender, EventArgs e)
        {
            if (themeErrorProvider.GetError(themeTextBox) == "" && groupErrorProvider.GetError(groupCheck) == ""
                && materialErrorProvider.GetError(materialTextBox) == "")
            { 
                teacher.AddMaterial(this);
                Close();
            }
        }
        private void themeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (themeTextBox.Text == "")
                themeErrorProvider.SetError(themeTextBox, "Theme field can not be empty");
            else themeErrorProvider.SetError(themeTextBox, "");
        }
        private void materialTextBox_TextChanged(object sender, EventArgs e)
        {
            if (materialTextBox.Text == "")
                materialErrorProvider.SetError(materialTextBox, "Material field can not be empty");
            else materialErrorProvider.SetError(materialTextBox, "");
        }
        private void groupCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupCheck.CheckedItems.Count == 0)
                groupErrorProvider.SetError(groupCheck, "Checked groups can not be empty");
            else groupErrorProvider.SetError(groupCheck, "");
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
