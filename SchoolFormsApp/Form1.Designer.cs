﻿
namespace SchoolFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textCity = new System.Windows.Forms.TextBox();
            this.textState = new System.Windows.Forms.TextBox();
            this.textZip = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textTwitter = new System.Windows.Forms.TextBox();
            this.btnPushToTest = new System.Windows.Forms.Button();
            this.btnTestTeacher = new System.Windows.Forms.Button();
            this.btnTestStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "School Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zip";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Twitter";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(277, 65);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 26);
            this.textName.TabIndex = 7;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(286, 124);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(100, 26);
            this.textAddress.TabIndex = 8;
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(277, 184);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(100, 26);
            this.textCity.TabIndex = 9;
            // 
            // textState
            // 
            this.textState.Location = new System.Drawing.Point(277, 232);
            this.textState.Name = "textState";
            this.textState.Size = new System.Drawing.Size(100, 26);
            this.textState.TabIndex = 10;
            // 
            // textZip
            // 
            this.textZip.Location = new System.Drawing.Point(277, 297);
            this.textZip.Name = "textZip";
            this.textZip.Size = new System.Drawing.Size(100, 26);
            this.textZip.TabIndex = 11;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(277, 348);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(100, 26);
            this.textPhone.TabIndex = 12;
            // 
            // textTwitter
            // 
            this.textTwitter.Location = new System.Drawing.Point(277, 393);
            this.textTwitter.Name = "textTwitter";
            this.textTwitter.Size = new System.Drawing.Size(100, 26);
            this.textTwitter.TabIndex = 13;
            // 
            // btnPushToTest
            // 
            this.btnPushToTest.Location = new System.Drawing.Point(144, 460);
            this.btnPushToTest.Name = "btnPushToTest";
            this.btnPushToTest.Size = new System.Drawing.Size(140, 40);
            this.btnPushToTest.TabIndex = 14;
            this.btnPushToTest.Text = "Push To Test";
            this.btnPushToTest.UseVisualStyleBackColor = true;
            this.btnPushToTest.Click += new System.EventHandler(this.btnPushToTest_Click);
            // 
            // btnTestTeacher
            // 
            this.btnTestTeacher.Location = new System.Drawing.Point(144, 526);
            this.btnTestTeacher.Name = "btnTestTeacher";
            this.btnTestTeacher.Size = new System.Drawing.Size(140, 54);
            this.btnTestTeacher.TabIndex = 15;
            this.btnTestTeacher.Text = "Test Teacher";
            this.btnTestTeacher.UseVisualStyleBackColor = true;
            this.btnTestTeacher.Click += new System.EventHandler(this.btnTestTeacher_Click);
            // 
            // btnTestStudent
            // 
            this.btnTestStudent.Location = new System.Drawing.Point(144, 598);
            this.btnTestStudent.Name = "btnTestStudent";
            this.btnTestStudent.Size = new System.Drawing.Size(140, 54);
            this.btnTestStudent.TabIndex = 16;
            this.btnTestStudent.Text = "Test Student";
            this.btnTestStudent.UseVisualStyleBackColor = true;
            this.btnTestStudent.Click += new System.EventHandler(this.btnTestStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 686);
            this.Controls.Add(this.btnTestStudent);
            this.Controls.Add(this.btnTestTeacher);
            this.Controls.Add(this.btnPushToTest);
            this.Controls.Add(this.textTwitter);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textZip);
            this.Controls.Add(this.textState);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.TextBox textState;
        private System.Windows.Forms.TextBox textZip;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textTwitter;
        private System.Windows.Forms.Button btnPushToTest;
        private System.Windows.Forms.Button btnTestTeacher;
        private System.Windows.Forms.Button btnTestStudent;
    }
}

