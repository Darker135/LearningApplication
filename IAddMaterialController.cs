﻿using System.Windows.Forms;

namespace LearningApplication
{
    interface IAddMaterialController
    {
        ListBox discipline { get; set; }
        CheckedListBox groups { get; set; }
        string theme { get; set; }
        string material { get; set; }
    }
}
