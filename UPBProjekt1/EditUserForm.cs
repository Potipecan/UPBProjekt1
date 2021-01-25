using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private Post Post;
        private Dashboard Dash;

        public EditUserForm(Dashboard dash)
        {
            InitializeComponent();
            Dash = dash;

            (Dash.CSettings.DarkMode ? Const.Dark : Const.Light).ApplyTo(this);
            //Font = new Font()

            UpdateFields();
        }

        private void UpdateFields()
        {
            App.POs.ForEach(r => PostCB.Items.Add($"{r.Code} - {r.Name}"));
            var u = Dash.CUser;            

            NameTB.Text = u.Name;
            SurnameTB.Text = u.Surname;
            UsernameTB.Text = u.Username;
            EmailTB.Text = u.Email;
            AddressTB.Text = u.Address;
            PostCB.SelectedIndex = App.POs.FindIndex(r => r.ID == u.Reg_ID);

            DarkmodeChkBox.Checked = Dash.CSettings.DarkMode;
            FontTB.Text = Dash.CSettings.Font;
        }

        private void PostCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PostCB.SelectedIndex >= 0)
            {
                Post = App.POs[PostCB.SelectedIndex];
                Debug.WriteLine(Post.ToString());
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

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            bool check = true;
            foreach(var c in UserInfoGB.Controls)
            {
                if(c != NewPassChkTB && c != NewPassTB)
                {
                    if(c.GetType() == typeof(TextBox) && (c as TextBox).Text == "")
                    {
                        check = false;
                        break;
                    }
                }
            }
            if(!check || Post == null)
            {
                MessageBox.Show("All fields marked with '*' are mandatory!");
                return;
            }

            var user = new User(NameTB.Text, SurnameTB.Text, UsernameTB.Text, EmailTB.Text, AddressTB.Text, Post.ID, id: Dash.CUser.ID);
            var res = await Dash.UpdateUser(user, NewPassTB.Text, PassTB.Text);
            if (res)
            {
                UpdateFields();

                if(FontTB.Text != "" && (DarkmodeChkBox.Checked != Dash.CSettings.DarkMode || FontTB.Text != Dash.CSettings.Font))
                {

                    var settings = new Settings(Dash.CSettings.ID, Dash.CSettings.UserID, DarkmodeChkBox.Checked, SetFontButton.Text);
                    settings = await App.DB.SetSettings(settings);
                    (settings.DarkMode ? Const.Dark : Const.Light).ApplyTo(Dash);
                   

                }
                Close();
            }
            else MessageBox.Show("Profile edit failed.\nCheck your info.");
        }

        private void EditCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void DeleteAccButton_Click(object sender, EventArgs e)
        {
            if(PassTB.Text == "")
            {
                MessageBox.Show("Profile deletion failed.\nPassword must be filled out.");
                return;
            }

            if(await App.DB.DeleteUser(Dash.CUser, PassTB.Text))
            {
                MessageBox.Show("Profile succesfully deleted");
                Dash.Close();
            }
        }

        private void BrowseArchiveButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
