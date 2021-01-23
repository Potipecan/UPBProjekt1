
namespace UPBProjekt1
{
    partial class EditUserForm
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
            this.UserInfoGB = new System.Windows.Forms.GroupBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.SurnameTB = new System.Windows.Forms.TextBox();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.PostCB = new System.Windows.Forms.ComboBox();
            this.NewPassTB = new System.Windows.Forms.TextBox();
            this.NewPassChkTB = new System.Windows.Forms.TextBox();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PostGB = new System.Windows.Forms.GroupBox();
            this.PostNameTB = new System.Windows.Forms.TextBox();
            this.PostCodeTB = new System.Windows.Forms.TextBox();
            this.PostAbbrTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PostCommitButton = new System.Windows.Forms.Button();
            this.PostCancelButton = new System.Windows.Forms.Button();
            this.PostDeleteButton = new System.Windows.Forms.Button();
            this.SettingsGB = new System.Windows.Forms.GroupBox();
            this.DarkmodeChkBox = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DeleteAccButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.FontTB = new System.Windows.Forms.TextBox();
            this.SetFontButton = new System.Windows.Forms.Button();
            this.FontSelector = new System.Windows.Forms.FontDialog();
            this.UserInfoGB.SuspendLayout();
            this.PostGB.SuspendLayout();
            this.SettingsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInfoGB
            // 
            this.UserInfoGB.Controls.Add(this.label9);
            this.UserInfoGB.Controls.Add(this.label8);
            this.UserInfoGB.Controls.Add(this.label7);
            this.UserInfoGB.Controls.Add(this.label6);
            this.UserInfoGB.Controls.Add(this.label5);
            this.UserInfoGB.Controls.Add(this.label4);
            this.UserInfoGB.Controls.Add(this.label3);
            this.UserInfoGB.Controls.Add(this.label2);
            this.UserInfoGB.Controls.Add(this.label1);
            this.UserInfoGB.Controls.Add(this.PassTB);
            this.UserInfoGB.Controls.Add(this.NewPassChkTB);
            this.UserInfoGB.Controls.Add(this.NewPassTB);
            this.UserInfoGB.Controls.Add(this.PostCB);
            this.UserInfoGB.Controls.Add(this.AddressTB);
            this.UserInfoGB.Controls.Add(this.EmailTB);
            this.UserInfoGB.Controls.Add(this.UsernameTB);
            this.UserInfoGB.Controls.Add(this.SurnameTB);
            this.UserInfoGB.Controls.Add(this.NameTB);
            this.UserInfoGB.Location = new System.Drawing.Point(12, 12);
            this.UserInfoGB.Name = "UserInfoGB";
            this.UserInfoGB.Size = new System.Drawing.Size(372, 290);
            this.UserInfoGB.TabIndex = 0;
            this.UserInfoGB.TabStop = false;
            this.UserInfoGB.Text = "User info";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(156, 21);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(207, 22);
            this.NameTB.TabIndex = 0;
            // 
            // SurnameTB
            // 
            this.SurnameTB.Location = new System.Drawing.Point(156, 49);
            this.SurnameTB.Name = "SurnameTB";
            this.SurnameTB.Size = new System.Drawing.Size(207, 22);
            this.SurnameTB.TabIndex = 1;
            // 
            // UsernameTB
            // 
            this.UsernameTB.Location = new System.Drawing.Point(156, 77);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(207, 22);
            this.UsernameTB.TabIndex = 2;
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(156, 105);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(207, 22);
            this.EmailTB.TabIndex = 3;
            // 
            // AddressTB
            // 
            this.AddressTB.Location = new System.Drawing.Point(156, 133);
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(207, 22);
            this.AddressTB.TabIndex = 4;
            // 
            // PostCB
            // 
            this.PostCB.FormattingEnabled = true;
            this.PostCB.Location = new System.Drawing.Point(156, 161);
            this.PostCB.Name = "PostCB";
            this.PostCB.Size = new System.Drawing.Size(207, 24);
            this.PostCB.TabIndex = 5;
            this.PostCB.SelectedIndexChanged += new System.EventHandler(this.PostCB_SelectedIndexChanged);
            // 
            // NewPassTB
            // 
            this.NewPassTB.Location = new System.Drawing.Point(156, 191);
            this.NewPassTB.Name = "NewPassTB";
            this.NewPassTB.Size = new System.Drawing.Size(207, 22);
            this.NewPassTB.TabIndex = 6;
            // 
            // NewPassChkTB
            // 
            this.NewPassChkTB.Location = new System.Drawing.Point(156, 219);
            this.NewPassChkTB.Name = "NewPassChkTB";
            this.NewPassChkTB.Size = new System.Drawing.Size(207, 22);
            this.NewPassChkTB.TabIndex = 7;
            // 
            // PassTB
            // 
            this.PassTB.Location = new System.Drawing.Point(156, 247);
            this.PassTB.Name = "PassTB";
            this.PassTB.Size = new System.Drawing.Size(207, 22);
            this.PassTB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(96, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name*:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(76, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Surname*:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(68, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Username*:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(99, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email*:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(81, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Address*:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(105, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Post*:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(47, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "New password:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(6, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "New password check:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(76, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Password*:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PostGB
            // 
            this.PostGB.Controls.Add(this.PostDeleteButton);
            this.PostGB.Controls.Add(this.PostCancelButton);
            this.PostGB.Controls.Add(this.PostCommitButton);
            this.PostGB.Controls.Add(this.label12);
            this.PostGB.Controls.Add(this.label11);
            this.PostGB.Controls.Add(this.label10);
            this.PostGB.Controls.Add(this.PostAbbrTB);
            this.PostGB.Controls.Add(this.PostCodeTB);
            this.PostGB.Controls.Add(this.PostNameTB);
            this.PostGB.Location = new System.Drawing.Point(390, 12);
            this.PostGB.Name = "PostGB";
            this.PostGB.Size = new System.Drawing.Size(398, 165);
            this.PostGB.TabIndex = 18;
            this.PostGB.TabStop = false;
            this.PostGB.Text = "Posts";
            // 
            // PostNameTB
            // 
            this.PostNameTB.Location = new System.Drawing.Point(134, 21);
            this.PostNameTB.Name = "PostNameTB";
            this.PostNameTB.Size = new System.Drawing.Size(244, 22);
            this.PostNameTB.TabIndex = 18;
            // 
            // PostCodeTB
            // 
            this.PostCodeTB.Location = new System.Drawing.Point(134, 49);
            this.PostCodeTB.Name = "PostCodeTB";
            this.PostCodeTB.Size = new System.Drawing.Size(244, 22);
            this.PostCodeTB.TabIndex = 19;
            // 
            // PostAbbrTB
            // 
            this.PostAbbrTB.Location = new System.Drawing.Point(134, 77);
            this.PostAbbrTB.Name = "PostAbbrTB";
            this.PostAbbrTB.Size = new System.Drawing.Size(244, 22);
            this.PostAbbrTB.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Post name*:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Post code*:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "Post abbreviation:";
            // 
            // PostCommitButton
            // 
            this.PostCommitButton.Location = new System.Drawing.Point(9, 119);
            this.PostCommitButton.Name = "PostCommitButton";
            this.PostCommitButton.Size = new System.Drawing.Size(119, 34);
            this.PostCommitButton.TabIndex = 19;
            this.PostCommitButton.Text = "Add";
            this.PostCommitButton.UseVisualStyleBackColor = true;
            this.PostCommitButton.Click += new System.EventHandler(this.PostCommitButton_Click);
            // 
            // PostCancelButton
            // 
            this.PostCancelButton.Location = new System.Drawing.Point(134, 119);
            this.PostCancelButton.Name = "PostCancelButton";
            this.PostCancelButton.Size = new System.Drawing.Size(119, 34);
            this.PostCancelButton.TabIndex = 24;
            this.PostCancelButton.Text = "Cancel";
            this.PostCancelButton.UseVisualStyleBackColor = true;
            // 
            // PostDeleteButton
            // 
            this.PostDeleteButton.Enabled = false;
            this.PostDeleteButton.Location = new System.Drawing.Point(259, 119);
            this.PostDeleteButton.Name = "PostDeleteButton";
            this.PostDeleteButton.Size = new System.Drawing.Size(119, 34);
            this.PostDeleteButton.TabIndex = 25;
            this.PostDeleteButton.Text = "Delete";
            this.PostDeleteButton.UseVisualStyleBackColor = true;
            // 
            // SettingsGB
            // 
            this.SettingsGB.Controls.Add(this.SetFontButton);
            this.SettingsGB.Controls.Add(this.FontTB);
            this.SettingsGB.Controls.Add(this.label13);
            this.SettingsGB.Controls.Add(this.DarkmodeChkBox);
            this.SettingsGB.Location = new System.Drawing.Point(391, 184);
            this.SettingsGB.Name = "SettingsGB";
            this.SettingsGB.Size = new System.Drawing.Size(397, 118);
            this.SettingsGB.TabIndex = 19;
            this.SettingsGB.TabStop = false;
            this.SettingsGB.Text = "UI Settings";
            // 
            // DarkmodeChkBox
            // 
            this.DarkmodeChkBox.AutoSize = true;
            this.DarkmodeChkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DarkmodeChkBox.Location = new System.Drawing.Point(50, 49);
            this.DarkmodeChkBox.Name = "DarkmodeChkBox";
            this.DarkmodeChkBox.Size = new System.Drawing.Size(99, 21);
            this.DarkmodeChkBox.TabIndex = 1;
            this.DarkmodeChkBox.Text = "Dark mode";
            this.DarkmodeChkBox.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 308);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(150, 41);
            this.SaveButton.TabIndex = 20;
            this.SaveButton.Text = "Save changes";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(168, 308);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(150, 41);
            this.CancelButton.TabIndex = 21;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // DeleteAccButton
            // 
            this.DeleteAccButton.Location = new System.Drawing.Point(324, 308);
            this.DeleteAccButton.Name = "DeleteAccButton";
            this.DeleteAccButton.Size = new System.Drawing.Size(150, 41);
            this.DeleteAccButton.TabIndex = 22;
            this.DeleteAccButton.Text = "Delete account";
            this.DeleteAccButton.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Font";
            // 
            // FontTB
            // 
            this.FontTB.Location = new System.Drawing.Point(50, 21);
            this.FontTB.Name = "FontTB";
            this.FontTB.ReadOnly = true;
            this.FontTB.Size = new System.Drawing.Size(244, 22);
            this.FontTB.TabIndex = 26;
            // 
            // SetFontButton
            // 
            this.SetFontButton.Location = new System.Drawing.Point(300, 21);
            this.SetFontButton.Name = "SetFontButton";
            this.SetFontButton.Size = new System.Drawing.Size(75, 23);
            this.SetFontButton.TabIndex = 27;
            this.SetFontButton.Text = "Set";
            this.SetFontButton.UseVisualStyleBackColor = true;
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteAccButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SettingsGB);
            this.Controls.Add(this.PostGB);
            this.Controls.Add(this.UserInfoGB);
            this.Name = "EditUserForm";
            this.Text = "EditUserForm";
            this.UserInfoGB.ResumeLayout(false);
            this.UserInfoGB.PerformLayout();
            this.PostGB.ResumeLayout(false);
            this.PostGB.PerformLayout();
            this.SettingsGB.ResumeLayout(false);
            this.SettingsGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UserInfoGB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.TextBox NewPassChkTB;
        private System.Windows.Forms.TextBox NewPassTB;
        private System.Windows.Forms.ComboBox PostCB;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.TextBox SurnameTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.GroupBox PostGB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PostAbbrTB;
        private System.Windows.Forms.TextBox PostCodeTB;
        private System.Windows.Forms.TextBox PostNameTB;
        private System.Windows.Forms.Button PostDeleteButton;
        private System.Windows.Forms.Button PostCancelButton;
        private System.Windows.Forms.Button PostCommitButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox SettingsGB;
        private System.Windows.Forms.CheckBox DarkmodeChkBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button DeleteAccButton;
        private System.Windows.Forms.Button SetFontButton;
        private System.Windows.Forms.TextBox FontTB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.FontDialog FontSelector;
    }
}