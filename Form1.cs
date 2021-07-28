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
