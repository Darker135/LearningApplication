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
            
        }
    }
}


//Получить инфо о студенте(группа)(через ключ - логин)
//Получить специальности для группы
//Получить темы где тема == специальности && группе
//массив листов тем где в листах учебный материал, проходится один лист - начинается другой,
    //между этим нужна проверка пройден ли тест по теме