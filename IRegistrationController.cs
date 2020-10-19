using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace LearningApplication
{
    interface IRegistrationController
    {
        string name { get; set; }
        string teacherName { get; set; }
        string login { get; set; }
        string password { get; set; }
        string department { get; set; }
        string speciality { get; set; }
        string group { get; set; }

    }
}
