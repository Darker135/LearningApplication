using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace LearningApplication
{
    interface IAddQuestionController
    {
        ListBox discipline { get; set; }
        CheckedListBox groups { get; set; }
        string theme { get; set; }
        string question { get; set; }
        string answer { get; set; }
    }
}
