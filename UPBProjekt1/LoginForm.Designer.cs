﻿
namespace UPBProjekt1
{
    partial class App
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
            this.LoginGroupBox = new System.Windows.Forms.GroupBox();
            this.QuitButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.LoginTabPage = new System.Windows.Forms.TabPage();
            this.RegistrationTabPage = new System.Windows.Forms.TabPage();
            this.RegisterGB = new System.Windows.Forms.GroupBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.PostCB = new System.Windows.Forms.ComboBox();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.PassChkTB = new System.Windows.Forms.TextBox();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.UnameTB = new System.Windows.Forms.TextBox();
            this.SurnameTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginGroupBox.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.LoginTabPage.SuspendLayout();
            this.RegistrationTabPage.SuspendLayout();
            this.RegisterGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginGroupBox
            // 
            this.LoginGroupBox.Controls.Add(this.QuitButton);
            this.LoginGroupBox.Controls.Add(this.LoginButton);
            this.LoginGroupBox.Controls.Add(this.PasswordTB);
            this.LoginGroupBox.Controls.Add(this.UsernameTB);
            this.LoginGroupBox.Controls.Add(this.label2);
            this.LoginGroupBox.Controls.Add(this.label1);
            this.LoginGroupBox.Location = new System.Drawing.Point(8, 6);
            this.LoginGroupBox.Name = "LoginGroupBox";
            this.LoginGroupBox.Size = new System.Drawing.Size(291, 156);
            this.LoginGroupBox.TabIndex = 0;
            this.LoginGroupBox.TabStop = false;
            this.LoginGroupBox.Text = "Login Info";
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(155, 107);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(130, 31);
            this.QuitButton.TabIndex = 5;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(13, 107);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(125, 31);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Log in";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(89, 63);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(196, 22);
            this.PasswordTB.TabIndex = 3;
            // 
            // UsernameTB
            // 
            this.UsernameTB.Location = new System.Drawing.Point(89, 35);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(196, 22);
            this.UsernameTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.LoginTabPage);
            this.Tabs.Controls.Add(this.RegistrationTabPage);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(558, 441);
            this.Tabs.TabIndex = 1;
            // 
            // LoginTabPage
            // 
            this.LoginTabPage.Controls.Add(this.LoginGroupBox);
            this.LoginTabPage.Location = new System.Drawing.Point(4, 25);
            this.LoginTabPage.Name = "LoginTabPage";
            this.LoginTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.LoginTabPage.Size = new System.Drawing.Size(550, 412);
            this.LoginTabPage.TabIndex = 0;
            this.LoginTabPage.Text = "Login Page";
            this.LoginTabPage.UseVisualStyleBackColor = true;
            // 
            // RegistrationTabPage
            // 
            this.RegistrationTabPage.Controls.Add(this.RegisterGB);
            this.RegistrationTabPage.Location = new System.Drawing.Point(4, 25);
            this.RegistrationTabPage.Name = "RegistrationTabPage";
            this.RegistrationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RegistrationTabPage.Size = new System.Drawing.Size(550, 412);
            this.RegistrationTabPage.TabIndex = 1;
            this.RegistrationTabPage.Text = "Register";
            this.RegistrationTabPage.UseVisualStyleBackColor = true;
            // 
            // RegisterGB
            // 
            this.RegisterGB.Controls.Add(this.EmailTB);
            this.RegisterGB.Controls.Add(this.label10);
            this.RegisterGB.Controls.Add(this.CancelBtn);
            this.RegisterGB.Controls.Add(this.RegisterButton);
            this.RegisterGB.Controls.Add(this.PostCB);
            this.RegisterGB.Controls.Add(this.AddressTB);
            this.RegisterGB.Controls.Add(this.PassChkTB);
            this.RegisterGB.Controls.Add(this.PassTB);
            this.RegisterGB.Controls.Add(this.UnameTB);
            this.RegisterGB.Controls.Add(this.SurnameTB);
            this.RegisterGB.Controls.Add(this.NameTB);
            this.RegisterGB.Controls.Add(this.label9);
            this.RegisterGB.Controls.Add(this.label8);
            this.RegisterGB.Controls.Add(this.label7);
            this.RegisterGB.Controls.Add(this.label6);
            this.RegisterGB.Controls.Add(this.label5);
            this.RegisterGB.Controls.Add(this.label4);
            this.RegisterGB.Controls.Add(this.label3);
            this.RegisterGB.Location = new System.Drawing.Point(8, 6);
            this.RegisterGB.Name = "RegisterGB";
            this.RegisterGB.Size = new System.Drawing.Size(413, 371);
            this.RegisterGB.TabIndex = 2;
            this.RegisterGB.TabStop = false;
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(149, 99);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(234, 22);
            this.EmailTB.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(97, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Email:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(226, 253);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(157, 32);
            this.CancelBtn.TabIndex = 16;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(22, 253);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(157, 32);
            this.RegisterButton.TabIndex = 15;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // PostCB
            // 
            this.PostCB.FormattingEnabled = true;
            this.PostCB.Location = new System.Drawing.Point(149, 212);
            this.PostCB.Name = "PostCB";
            this.PostCB.Size = new System.Drawing.Size(234, 24);
            this.PostCB.TabIndex = 14;
            // 
            // AddressTB
            // 
            this.AddressTB.Location = new System.Drawing.Point(149, 183);
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(234, 22);
            this.AddressTB.TabIndex = 13;
            // 
            // PassChkTB
            // 
            this.PassChkTB.Location = new System.Drawing.Point(149, 155);
            this.PassChkTB.Name = "PassChkTB";
            this.PassChkTB.Size = new System.Drawing.Size(234, 22);
            this.PassChkTB.TabIndex = 12;
            // 
            // PassTB
            // 
            this.PassTB.Location = new System.Drawing.Point(149, 127);
            this.PassTB.Name = "PassTB";
            this.PassTB.Size = new System.Drawing.Size(234, 22);
            this.PassTB.TabIndex = 11;
            // 
            // UnameTB
            // 
            this.UnameTB.Location = new System.Drawing.Point(149, 71);
            this.UnameTB.Name = "UnameTB";
            this.UnameTB.Size = new System.Drawing.Size(234, 22);
            this.UnameTB.TabIndex = 9;
            // 
            // SurnameTB
            // 
            this.SurnameTB.Location = new System.Drawing.Point(149, 43);
            this.SurnameTB.Name = "SurnameTB";
            this.SurnameTB.Size = new System.Drawing.Size(234, 22);
            this.SurnameTB.TabIndex = 8;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(149, 15);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(234, 22);
            this.NameTB.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(103, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Post:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Address:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Confirm password:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Password:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Username:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Surname:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WorkHoursChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(558, 441);
            this.Controls.Add(this.Tabs);
            this.Name = "WorkHoursChecker";
            this.Text = "Login";
            this.LoginGroupBox.ResumeLayout(false);
            this.LoginGroupBox.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.LoginTabPage.ResumeLayout(false);
            this.RegistrationTabPage.ResumeLayout(false);
            this.RegisterGB.ResumeLayout(false);
            this.RegisterGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LoginGroupBox;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage LoginTabPage;
        private System.Windows.Forms.TabPage RegistrationTabPage;
        private System.Windows.Forms.GroupBox RegisterGB;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.ComboBox PostCB;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.TextBox PassChkTB;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.TextBox UnameTB;
        private System.Windows.Forms.TextBox SurnameTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.Label label10;
    }
}

