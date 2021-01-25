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
    public partial class Dashboard : Form
    {
        public User CUser { get; set; }
        public Settings CSettings { get; set; }
        private static Dashboard This;

        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(User user) : this()
        {
            This = this;
            CUser = user;
            Task.Run(async () =>
            {
                CSettings = await App.DB.GetSettingForUser(CUser);
            }).Wait();

            WindowRefresh();
        }

        public async Task<bool> UpdateUser(User user, string newpass, string pass)
        {
            user = await App.DB.UpdateUser(user, newpass, pass);
            bool res = user != null;
            if (res)
            {
                CUser = user;
                WindowRefresh();
            }
            return res;
        }

        public async void DeleteUser(User user, string pass)
        {
            if(await App.DB.DeleteUser(user, pass))
            {
                This.Close();
            }
        }

        private void WindowRefresh()
        {
            Text = $"Dashboard - {CUser.Username}";

            if (CSettings.DarkMode) Const.Dark.ApplyTo(this);
            else Const.Light.ApplyTo(this);

            var po = App.POs.Find(p => p.ID == CUser.Reg_ID);
            UserInfoLabel.Text = $"{CUser.Name}\n{CUser.Surname}\n{CUser.Username}\n{CUser.Email}\n" +
                $"{CUser.Address}\n{po.Code} - {po.Name}\n{CUser.Projects_Num}\n{CUser.Completed_Num}";
        }

        private void EditProfileButton_Click(object sender, EventArgs e)
        {
            var ef = new EditUserForm(this);
            ef.FormClosed += Ef_FormClosed;
            Enabled = false;
            ef.Show();
        }

        private void Ef_FormClosed(object sender, FormClosedEventArgs e)
        {
            Enabled = true;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to log out?", "Logging out", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes) Close();
        }
    }
}
