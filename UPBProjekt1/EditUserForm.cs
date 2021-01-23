using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;

namespace UPBProjekt1
{
    public partial class EditUserForm : Form
    {
        private Database.Region Post;

        public EditUserForm()
        {
            InitializeComponent();

            (Dashboard.CSettings.DarkMode ? Const.Dark : Const.Light).ApplyTo(this);
            //Font = new Font()

            UpdateFields();
        }

        private void UpdateFields()
        {
            WorkHoursChecker.POs.ForEach(r => PostCB.Items.Add($"{r.Code} - {r.Name}"));
            var u = Dashboard.CUser;            

            NameTB.Text = u.Name;
            SurnameTB.Text = u.Surname;
            UsernameTB.Text = u.Username;
            EmailTB.Text = u.Email;
            AddressTB.Text = u.Address;
            PostCB.SelectedIndex = WorkHoursChecker.POs.FindIndex(r => r.ID == u.Reg_ID);

            DarkmodeChkBox.Checked = Dashboard.CSettings.DarkMode;
            FontTB.Text = Dashboard.CSettings.Font;
        }

        private void PostCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PostCB.SelectedIndex > 0)
            {
                Post = WorkHoursChecker.POs[PostCB.SelectedIndex];
                PostNameTB.Text = Post.Name;
                PostCodeTB.Text = Post.Code;
                PostAbbrTB.Text = Post.Abbr;

                PostCommitButton.Text = "Update";
                PostDeleteButton.Enabled = true;
                PostCancelButton.Text = "Clear";
            }
            else
            {
                Post = null;
                PostNameTB.Text = "";
                PostCodeTB.Text = "";
                PostAbbrTB.Text = "";

                PostCommitButton.Text = "Add";
                PostDeleteButton.Enabled = false;
                PostCancelButton.Text = "Cancel";
            }
        }

        private void PostCommitButton_Click(object sender, EventArgs e)
        {
            if(PostNameTB.Text != "" && PostCodeTB.Text != "")
            {

            }
        }
    }
}
