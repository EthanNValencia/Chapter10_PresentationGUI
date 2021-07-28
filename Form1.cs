using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chapter10_PersonStudent; // I added a reference to the directory of the Chapter10_PersonStudent.dll
/*
 * What makes this project special is that it relies on Chapter10_PersonStudent.dll, which is a library
 * that I made myself. 
 * 
 * This project needs to know where the Chapter10_PersonStudent.dll is located. 
 * 
 * After a DLL is created, it is not easy to view its contents. In order to view it ILDASM must be 
 * used. It must be added as a tool.
 * Tools > External Tools > Add > add the exe to the command, "C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools\ildasm.exe"
 * Now IL DASM can be run from the Tools. Open the DLL and limited information about the contents of the DLL
 * can be viewed. Page 606 for more information.
 */

namespace Chapter10_PresentationGUI
{
    public partial class Form1 : Form
    {
        Student aStudent; // I had to make the class public. 
        public Form1()
        {
            aStudent = new Student("12345", "Maria", "Woo", "CS", 1111); // Instantiating with no problems. 
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Calls various accessors and methods, then displays on the GUI.
        {
            aStudent.Age = 25;
            this.txtBoxName.Text = aStudent.ToString();
            this.txtBoxAge.Text = aStudent.Age.ToString();
            this.txtBoxID.Text = System.Convert.ToString(aStudent.StudentId);
            this.txtBoxStudentSleep.Text = System.Convert.ToString(aStudent.GetSleepAmt());
            this.txtBoxPersonSleep.Text = System.Convert.ToString(aStudent.CallOverriddenGetSleepAmt());
        }
    }
}
