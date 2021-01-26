
namespace UPBProjekt1
{
    partial class ArchiveBrowser
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
            this.ArchiveLB = new System.Windows.Forms.ListBox();
            this.LoadArchiveBTN = new System.Windows.Forms.Button();
            this.DeleteArchiveBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ArchiveLB
            // 
            this.ArchiveLB.Dock = System.Windows.Forms.DockStyle.Left;
            this.ArchiveLB.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArchiveLB.FormattingEnabled = true;
            this.ArchiveLB.ItemHeight = 15;
            this.ArchiveLB.Location = new System.Drawing.Point(0, 0);
            this.ArchiveLB.Name = "ArchiveLB";
            this.ArchiveLB.Size = new System.Drawing.Size(904, 450);
            this.ArchiveLB.TabIndex = 0;
            this.ArchiveLB.SelectedIndexChanged += new System.EventHandler(this.ArchiveLB_SelectedIndexChanged);
            // 
            // LoadArchiveBTN
            // 
            this.LoadArchiveBTN.Location = new System.Drawing.Point(911, 13);
            this.LoadArchiveBTN.Name = "LoadArchiveBTN";
            this.LoadArchiveBTN.Size = new System.Drawing.Size(133, 43);
            this.LoadArchiveBTN.TabIndex = 1;
            this.LoadArchiveBTN.Text = "Load";
            this.LoadArchiveBTN.UseVisualStyleBackColor = true;
            this.LoadArchiveBTN.Click += new System.EventHandler(this.LoadArchiveBTN_Click);
            // 
            // DeleteArchiveBTN
            // 
            this.DeleteArchiveBTN.Location = new System.Drawing.Point(911, 62);
            this.DeleteArchiveBTN.Name = "DeleteArchiveBTN";
            this.DeleteArchiveBTN.Size = new System.Drawing.Size(133, 43);
            this.DeleteArchiveBTN.TabIndex = 2;
            this.DeleteArchiveBTN.Text = "Delete";
            this.DeleteArchiveBTN.UseVisualStyleBackColor = true;
            this.DeleteArchiveBTN.Click += new System.EventHandler(this.DeleteArchiveBTN_Click);
            // 
            // ArchiveBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 450);
            this.Controls.Add(this.DeleteArchiveBTN);
            this.Controls.Add(this.LoadArchiveBTN);
            this.Controls.Add(this.ArchiveLB);
            this.Name = "ArchiveBrowser";
            this.Text = "ArchiveBrowser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ArchiveLB;
        private System.Windows.Forms.Button LoadArchiveBTN;
        private System.Windows.Forms.Button DeleteArchiveBTN;
    }
}