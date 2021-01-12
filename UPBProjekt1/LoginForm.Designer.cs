
namespace UPBProjekt1
{
    partial class LoginForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.SurnameTB = new System.Windows.Forms.TextBox();
            this.UnameTB = new System.Windows.Forms.TextBox();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.PassChkTB = new System.Windows.Forms.TextBox();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.PostCB = new System.Windows.Forms.ComboBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.LoginGroupBox.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.LoginTabPage.SuspendLayout();
            this.RegistrationTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.RegistrationTabPage.Controls.Add(this.groupBox1);
            this.RegistrationTabPage.Location = new System.Drawing.Point(4, 25);
            this.RegistrationTabPage.Name = "RegistrationTabPage";
            this.RegistrationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RegistrationTabPage.Size = new System.Drawing.Size(550, 412);
            this.RegistrationTabPage.TabIndex = 1;
            this.RegistrationTabPage.Text = "Register";
            this.RegistrationTabPage.UseVisualStyleBackColor = true;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CancelButton);
            this.groupBox1.Controls.Add(this.RegisterButton);
            this.groupBox1.Controls.Add(this.PostCB);
            this.groupBox1.Controls.Add(this.AddressTB);
            this.groupBox1.Controls.Add(this.PassChkTB);
            this.groupBox1.Controls.Add(this.PassTB);
            this.groupBox1.Controls.Add(this.UnameTB);
            this.groupBox1.Controls.Add(this.SurnameTB);
            this.groupBox1.Controls.Add(this.NameTB);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 288);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Password:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Confirm password:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Address:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(103, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Post:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(149, 15);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(234, 22);
            this.NameTB.TabIndex = 7;
            // 
            // SurnameTB
            // 
            this.SurnameTB.Location = new System.Drawing.Point(149, 43);
            this.SurnameTB.Name = "SurnameTB";
            this.SurnameTB.Size = new System.Drawing.Size(234, 22);
            this.SurnameTB.TabIndex = 8;
            // 
            // UnameTB
            // 
            this.UnameTB.Location = new System.Drawing.Point(149, 71);
            this.UnameTB.Name = "UnameTB";
            this.UnameTB.Size = new System.Drawing.Size(234, 22);
            this.UnameTB.TabIndex = 9;
            // 
            // PassTB
            // 
            this.PassTB.Location = new System.Drawing.Point(149, 99);
            this.PassTB.Name = "PassTB";
            this.PassTB.Size = new System.Drawing.Size(234, 22);
            this.PassTB.TabIndex = 10;
            // 
            // PassChkTB
            // 
            this.PassChkTB.Location = new System.Drawing.Point(149, 127);
            this.PassChkTB.Name = "PassChkTB";
            this.PassChkTB.Size = new System.Drawing.Size(234, 22);
            this.PassChkTB.TabIndex = 11;
            // 
            // AddressTB
            // 
            this.AddressTB.Location = new System.Drawing.Point(149, 155);
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(234, 22);
            this.AddressTB.TabIndex = 12;
            // 
            // PostCB
            // 
            this.PostCB.FormattingEnabled = true;
            this.PostCB.Location = new System.Drawing.Point(149, 184);
            this.PostCB.Name = "PostCB";
            this.PostCB.Size = new System.Drawing.Size(234, 24);
            this.PostCB.TabIndex = 13;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(22, 228);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(157, 32);
            this.RegisterButton.TabIndex = 14;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(226, 228);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(157, 32);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(558, 441);
            this.Controls.Add(this.Tabs);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.LoginGroupBox.ResumeLayout(false);
            this.LoginGroupBox.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.LoginTabPage.ResumeLayout(false);
            this.RegistrationTabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Button CancelButton;
    }
}

