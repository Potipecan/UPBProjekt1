
namespace UPBProjekt1
{
    partial class SessionBrowser
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
            this.SessionsLB = new System.Windows.Forms.ListBox();
            this.SessionInfoGB = new System.Windows.Forms.GroupBox();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProjectInfoLabel = new System.Windows.Forms.Label();
            this.DeleteSessionButton = new System.Windows.Forms.Button();
            this.SessionInfoGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // SessionsLB
            // 
            this.SessionsLB.Dock = System.Windows.Forms.DockStyle.Right;
            this.SessionsLB.FormattingEnabled = true;
            this.SessionsLB.ItemHeight = 16;
            this.SessionsLB.Location = new System.Drawing.Point(349, 0);
            this.SessionsLB.Name = "SessionsLB";
            this.SessionsLB.Size = new System.Drawing.Size(678, 434);
            this.SessionsLB.TabIndex = 0;
            this.SessionsLB.SelectedIndexChanged += new System.EventHandler(this.SessionsLB_SelectedIndexChanged);
            // 
            // SessionInfoGB
            // 
            this.SessionInfoGB.Controls.Add(this.CommentLabel);
            this.SessionInfoGB.Controls.Add(this.InfoLabel);
            this.SessionInfoGB.Controls.Add(this.label1);
            this.SessionInfoGB.Location = new System.Drawing.Point(12, 48);
            this.SessionInfoGB.Name = "SessionInfoGB";
            this.SessionInfoGB.Size = new System.Drawing.Size(330, 194);
            this.SessionInfoGB.TabIndex = 1;
            this.SessionInfoGB.TabStop = false;
            this.SessionInfoGB.Text = "Session info";
            // 
            // CommentLabel
            // 
            this.CommentLabel.Location = new System.Drawing.Point(7, 90);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(317, 101);
            this.CommentLabel.TabIndex = 2;
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(80, 18);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(0, 17);
            this.InfoLabel.TabIndex = 1;
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start:\r\nEnd:\r\nDuration:\r\nComment:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProjectInfoLabel
            // 
            this.ProjectInfoLabel.AutoSize = true;
            this.ProjectInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectInfoLabel.Location = new System.Drawing.Point(12, 9);
            this.ProjectInfoLabel.Name = "ProjectInfoLabel";
            this.ProjectInfoLabel.Size = new System.Drawing.Size(79, 29);
            this.ProjectInfoLabel.TabIndex = 2;
            this.ProjectInfoLabel.Text = "label2";
            this.ProjectInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeleteSessionButton
            // 
            this.DeleteSessionButton.Enabled = false;
            this.DeleteSessionButton.Location = new System.Drawing.Point(15, 248);
            this.DeleteSessionButton.Name = "DeleteSessionButton";
            this.DeleteSessionButton.Size = new System.Drawing.Size(125, 33);
            this.DeleteSessionButton.TabIndex = 3;
            this.DeleteSessionButton.Text = "Delete";
            this.DeleteSessionButton.UseVisualStyleBackColor = true;
            this.DeleteSessionButton.Click += new System.EventHandler(this.DeleteSessionButton_Click);
            // 
            // SessionBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 434);
            this.Controls.Add(this.DeleteSessionButton);
            this.Controls.Add(this.ProjectInfoLabel);
            this.Controls.Add(this.SessionInfoGB);
            this.Controls.Add(this.SessionsLB);
            this.Name = "SessionBrowser";
            this.Text = "Session Browser";
            this.SessionInfoGB.ResumeLayout(false);
            this.SessionInfoGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SessionsLB;
        private System.Windows.Forms.GroupBox SessionInfoGB;
        private System.Windows.Forms.Label CommentLabel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProjectInfoLabel;
        private System.Windows.Forms.Button DeleteSessionButton;
    }
}