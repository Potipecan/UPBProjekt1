
namespace UPBProjekt1
{
    partial class Dashboard
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.EditProfileButton = new System.Windows.Forms.Button();
            this.UserInfoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ProjectsLB = new System.Windows.Forms.ListBox();
            this.WorkSessionLabel = new System.Windows.Forms.Label();
            this.SessionCommitButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TitleTB = new System.Windows.Forms.TextBox();
            this.ClientTB = new System.Windows.Forms.TextBox();
            this.PositionTB = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.DescTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ActiveChkB = new System.Windows.Forms.CheckBox();
            this.CommitProjectButton = new System.Windows.Forms.Button();
            this.DeleteProjectButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.BrowseSessionsBTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.LogoutButton);
            this.groupBox1.Controls.Add(this.EditProfileButton);
            this.groupBox1.Controls.Add(this.UserInfoLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User info";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(149, 173);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(130, 32);
            this.LogoutButton.TabIndex = 3;
            this.LogoutButton.Text = "Log out";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // EditProfileButton
            // 
            this.EditProfileButton.Location = new System.Drawing.Point(10, 173);
            this.EditProfileButton.Name = "EditProfileButton";
            this.EditProfileButton.Size = new System.Drawing.Size(130, 32);
            this.EditProfileButton.TabIndex = 2;
            this.EditProfileButton.Text = "Edit profile";
            this.EditProfileButton.UseVisualStyleBackColor = true;
            this.EditProfileButton.Click += new System.EventHandler(this.EditProfileButton_Click);
            // 
            // UserInfoLabel
            // 
            this.UserInfoLabel.AutoSize = true;
            this.UserInfoLabel.Location = new System.Drawing.Point(146, 22);
            this.UserInfoLabel.Name = "UserInfoLabel";
            this.UserInfoLabel.Size = new System.Drawing.Size(0, 17);
            this.UserInfoLabel.TabIndex = 1;
            this.UserInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 136);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:\r\nSurname:\r\nUsername:\r\nEmail:\r\nAddress:\r\nPO:\r\nAll projects:\r\nCompleted proje" +
    "cts:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SessionCommitButton);
            this.groupBox2.Controls.Add(this.WorkSessionLabel);
            this.groupBox2.Location = new System.Drawing.Point(392, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Work session";
            // 
            // ProjectsLB
            // 
            this.ProjectsLB.FormattingEnabled = true;
            this.ProjectsLB.ItemHeight = 16;
            this.ProjectsLB.Location = new System.Drawing.Point(393, 139);
            this.ProjectsLB.Name = "ProjectsLB";
            this.ProjectsLB.Size = new System.Drawing.Size(395, 436);
            this.ProjectsLB.TabIndex = 2;
            // 
            // WorkSessionLabel
            // 
            this.WorkSessionLabel.AutoSize = true;
            this.WorkSessionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkSessionLabel.Location = new System.Drawing.Point(17, 22);
            this.WorkSessionLabel.Name = "WorkSessionLabel";
            this.WorkSessionLabel.Size = new System.Drawing.Size(53, 25);
            this.WorkSessionLabel.TabIndex = 0;
            this.WorkSessionLabel.Text = "label";
            this.WorkSessionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SessionCommitButton
            // 
            this.SessionCommitButton.Location = new System.Drawing.Point(6, 72);
            this.SessionCommitButton.Name = "SessionCommitButton";
            this.SessionCommitButton.Size = new System.Drawing.Size(149, 37);
            this.SessionCommitButton.TabIndex = 1;
            this.SessionCommitButton.Text = "Begin new session";
            this.SessionCommitButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BrowseSessionsBTN);
            this.groupBox3.Controls.Add(this.ClearButton);
            this.groupBox3.Controls.Add(this.DeleteProjectButton);
            this.groupBox3.Controls.Add(this.CommitProjectButton);
            this.groupBox3.Controls.Add(this.ActiveChkB);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.DescTB);
            this.groupBox3.Controls.Add(this.maskedTextBox1);
            this.groupBox3.Controls.Add(this.PositionTB);
            this.groupBox3.Controls.Add(this.ClientTB);
            this.groupBox3.Controls.Add(this.TitleTB);
            this.groupBox3.Location = new System.Drawing.Point(12, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 331);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Project GroupBox";
            // 
            // TitleTB
            // 
            this.TitleTB.Location = new System.Drawing.Point(149, 21);
            this.TitleTB.Name = "TitleTB";
            this.TitleTB.Size = new System.Drawing.Size(219, 22);
            this.TitleTB.TabIndex = 0;
            // 
            // ClientTB
            // 
            this.ClientTB.Location = new System.Drawing.Point(149, 49);
            this.ClientTB.Name = "ClientTB";
            this.ClientTB.Size = new System.Drawing.Size(219, 22);
            this.ClientTB.TabIndex = 1;
            // 
            // PositionTB
            // 
            this.PositionTB.Location = new System.Drawing.Point(149, 77);
            this.PositionTB.Name = "PositionTB";
            this.PositionTB.Size = new System.Drawing.Size(219, 22);
            this.PositionTB.TabIndex = 2;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(149, 105);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(0, 2);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // DescTB
            // 
            this.DescTB.Location = new System.Drawing.Point(149, 105);
            this.DescTB.Multiline = true;
            this.DescTB.Name = "DescTB";
            this.DescTB.Size = new System.Drawing.Size(219, 82);
            this.DescTB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Title*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Client*:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Position*:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description:";
            // 
            // ActiveChkB
            // 
            this.ActiveChkB.AutoSize = true;
            this.ActiveChkB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ActiveChkB.Location = new System.Drawing.Point(94, 193);
            this.ActiveChkB.Name = "ActiveChkB";
            this.ActiveChkB.Size = new System.Drawing.Size(68, 21);
            this.ActiveChkB.TabIndex = 9;
            this.ActiveChkB.Text = "Active";
            this.ActiveChkB.UseVisualStyleBackColor = true;
            // 
            // CommitProjectButton
            // 
            this.CommitProjectButton.Location = new System.Drawing.Point(10, 233);
            this.CommitProjectButton.Name = "CommitProjectButton";
            this.CommitProjectButton.Size = new System.Drawing.Size(106, 30);
            this.CommitProjectButton.TabIndex = 10;
            this.CommitProjectButton.Text = "Add";
            this.CommitProjectButton.UseVisualStyleBackColor = true;
            // 
            // DeleteProjectButton
            // 
            this.DeleteProjectButton.Location = new System.Drawing.Point(122, 233);
            this.DeleteProjectButton.Name = "DeleteProjectButton";
            this.DeleteProjectButton.Size = new System.Drawing.Size(107, 30);
            this.DeleteProjectButton.TabIndex = 11;
            this.DeleteProjectButton.Text = "Delete";
            this.DeleteProjectButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(235, 233);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(107, 30);
            this.ClearButton.TabIndex = 12;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // BrowseSessionsBTN
            // 
            this.BrowseSessionsBTN.Location = new System.Drawing.Point(10, 269);
            this.BrowseSessionsBTN.Name = "BrowseSessionsBTN";
            this.BrowseSessionsBTN.Size = new System.Drawing.Size(139, 30);
            this.BrowseSessionsBTN.TabIndex = 13;
            this.BrowseSessionsBTN.Text = "Browse sessions";
            this.BrowseSessionsBTN.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ProjectsLB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label UserInfoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button EditProfileButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SessionCommitButton;
        private System.Windows.Forms.Label WorkSessionLabel;
        private System.Windows.Forms.ListBox ProjectsLB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BrowseSessionsBTN;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DeleteProjectButton;
        private System.Windows.Forms.Button CommitProjectButton;
        private System.Windows.Forms.CheckBox ActiveChkB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescTB;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox PositionTB;
        private System.Windows.Forms.TextBox ClientTB;
        private System.Windows.Forms.TextBox TitleTB;
    }
}