
namespace Chapter10_PresentationGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.txtBoxStudentSleep = new System.Windows.Forms.TextBox();
            this.txtBoxPersonSleep = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(69, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sleep Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sleep amount for most people:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Show Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(161, 6);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(125, 27);
            this.txtBoxName.TabIndex = 6;
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Location = new System.Drawing.Point(161, 39);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(125, 27);
            this.txtBoxAge.TabIndex = 7;
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(161, 72);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(125, 27);
            this.txtBoxID.TabIndex = 8;
            // 
            // txtBoxStudentSleep
            // 
            this.txtBoxStudentSleep.Location = new System.Drawing.Point(234, 112);
            this.txtBoxStudentSleep.Name = "txtBoxStudentSleep";
            this.txtBoxStudentSleep.Size = new System.Drawing.Size(52, 27);
            this.txtBoxStudentSleep.TabIndex = 9;
            // 
            // txtBoxPersonSleep
            // 
            this.txtBoxPersonSleep.Location = new System.Drawing.Point(234, 146);
            this.txtBoxPersonSleep.Name = "txtBoxPersonSleep";
            this.txtBoxPersonSleep.Size = new System.Drawing.Size(52, 27);
            this.txtBoxPersonSleep.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(305, 224);
            this.Controls.Add(this.txtBoxPersonSleep);
            this.Controls.Add(this.txtBoxStudentSleep);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.txtBoxAge);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Student Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.TextBox txtBoxStudentSleep;
        private System.Windows.Forms.TextBox txtBoxPersonSleep;
    }
}

