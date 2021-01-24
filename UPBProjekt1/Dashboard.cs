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
        public static User CUser { get; set; }
        public static Settings CSettings { get; set; }

        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(User user) : this()
        {
            CUser = user;
            Task.Run(async () =>
            {
                CSettings = await WorkHoursChecker.DB.GetSettingForUser(CUser);
            }).Wait();

            WindowRefresh();
        }

        private void WindowRefresh()
        {
            Text = $"Dashboard - {CUser.Username}";

            if (CSettings.DarkMode) Const.Dark.ApplyTo(this);
            else Const.Light.ApplyTo(this);

            var po = WorkHoursChecker.POs.Find(p => p.ID == CUser.Reg_ID);
            UserInfoLabel.Text = $"{CUser.Name}\n{CUser.Surname}\n{CUser.Username}\n{CUser.Email}\n" +
                $"{CUser.Address}\n{po.Code} - {po.Name}\n{CUser.Projects_Num}\n{CUser.Completed_Num}";
        }

        private void EditProfileButton_Click(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to log out?", "Logging out", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes) Close();
        }
    }
}
