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
        private Database.Post Post;

        public EditUserForm()
        {
            InitializeComponent();

            (Dashboard.CSettings.DarkMode ? Const.Dark : Const.Light).ApplyTo(this);
            //Font = new Font()

            UpdateFields();
        }

        private void UpdateFields()
        {
            App.POs.ForEach(r => PostCB.Items.Add($"{r.Code} - {r.Name}"));
            var u = Dashboard.CUser;            

            NameTB.Text = u.Name;
            SurnameTB.Text = u.Surname;
            UsernameTB.Text = u.Username;
            EmailTB.Text = u.Email;
            AddressTB.Text = u.Address;
            PostCB.SelectedIndex = App.POs.FindIndex(r => r.ID == u.Reg_ID);

            DarkmodeChkBox.Checked = Dashboard.CSettings.DarkMode;
            FontTB.Text = Dashboard.CSettings.Font;
        }

        private void PostCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PostCB.SelectedIndex > 0)
            {
                Post = App.POs[PostCB.SelectedIndex];
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

        private async void PostCommitButton_Click(object sender, EventArgs e)
        {
            if (PostNameTB.Text != "" && PostCodeTB.Text != "")
            {
                if (PostCB.SelectedIndex < 0)
                {
                    var reg = new Post(PostNameTB.Text, PostCodeTB.Text, PostAbbrTB.Text);
                    reg = await App.DB.AddPO(reg);
                    App.POs.Add(reg);

                    PostCB.SelectedIndex = App.POs.FindIndex(r => r.ID == reg.ID);
                    UpdateFields(); 
                }
                else
                {
                    var reg = new Post(PostNameTB.Text, PostCodeTB.Text, PostAbbrTB.Text, Post.ID);
                    reg = await App.DB.UpdatePO(reg);

                    await App.UpdatePOs();
                    UpdateFields();
                }
            }
            else MessageBox.Show("All fields marked with '*' are mandatory!");
        }

        private void PostCancelButton_Click(object sender, EventArgs e)
        {
            PostCB.SelectedIndex = -1;
        }

        private async void PostDeleteButton_Click(object sender, EventArgs e)
        {
            var ok = MessageBox.Show("Post deletion!", "Warning! Action cannot be undone!\nAre you sure you want to proceed?", MessageBoxButtons.YesNo);
            if(ok == DialogResult.Yes)
            {
                if (await App.DB.DeletePO(Post))
                {
                    await App.UpdatePOs();
                    UpdateFields();
                }
                else MessageBox.Show("Task failed.");
            }
        }
    }
}
