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
    public partial class LoginForm : Form
    {
        DatabaseManager DB;
        public LoginForm()
        {
            InitializeComponent();

            DB = new DatabaseManager();

            //Task.Run(async () =>
            //{
            //    var list = await DB.GetAllPost();
            //    list.ForEach(i => AllPostLB.Items.Add(i.ToString()));
            //}).Wait();


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
    }
}
