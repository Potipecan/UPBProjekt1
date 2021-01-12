using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;

namespace UPBProjekt1
{
    public partial class WorkHoursChecker : Form
    {
        public static DatabaseManager DB;
        public static List<Kraj> POs;

        public WorkHoursChecker()
        {
            InitializeComponent();

            DB = new DatabaseManager();

            Task.Run(async () =>
            {
                POs = await DB.GetAllPOs();
            }).Wait();

            POs.ForEach(p => PostCB.Items.Add($"{p.PostID} - {p.Name}"));
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameTB.Text != "" && PasswordTB.Text != "")
            {
                var user = await DB.GetUser(UsernameTB.Text, PasswordTB.Text);
                if (user != null)
                {
                    //TO DO: Transition to next form
                }
                else MessageBox.Show("Login failed.\nCheck your info.");
            }
            else MessageBox.Show("Input all fields.");
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            NameTB.Text = "";
            SurnameTB.Text = "";
            UnameTB.Text = "";
            PassTB.Text = "";
            PassChkTB.Text = "";
            AddressTB.Text = "";
            EmailTB.Text = "";
            PostCB.SelectedIndex = -1;
            Tabs.SelectedIndex = 0;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            foreach(var c in RegisterGB.Controls)
            {
                if(c.GetType() == typeof(TextBox) && (c as TextBox).Text == "")
                {
                    MessageBox.Show("Fill out all fields");
                    return;
                }
            }
            if (PostCB.SelectedIndex < 0)
            {
                MessageBox.Show("Select a PO.");
                return;
            }
            if(PassTB.Text != PassChkTB.Text)
            {
                MessageBox.Show("Passwords must match!");
                return;
            }

            var newUser = new User(NameTB.Text, SurnameTB.Text, UnameTB.Text, EmailTB.Text, AddressTB.Text, POs[PostCB.SelectedIndex].ID);
            //TO DO: add user registration function in database manager
        }
    }
}
