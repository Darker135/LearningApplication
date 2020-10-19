using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace LearningApplication
{
    public partial class StudentMainScreenForm : Form
    {
        public StudentMainScreenForm()
        {
            InitializeComponent();
        }

        public static StudentMainScreenForm studentMainScreenForm = new StudentMainScreenForm();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            //if(richTextBox1.SelectedText != string.Empty) urichTextBox1.SelectedText = "aaa";
        }

        private void StudentMainScreenForm_Load(object sender, EventArgs e)
        {
            //richTextBox1.Text = "kiribati";
        }
    }
}
