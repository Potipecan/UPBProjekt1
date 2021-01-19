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
        public static User CUser;

        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(User user) : this()
        {
            CUser = user;            

            UpdateUserInfo();
        }

        private void UpdateUserInfo()
        {
            Text = $"Dashboard - {CUser.Username}";
            var po = WorkHoursChecker.POs.Find(p => p.ID == CUser.Reg_ID);
            UserInfoLabel.Text = $"{CUser.Name}\n{CUser.Surname}\n{CUser.Username}\n{CUser.Email}\n" +
                $"{CUser.Address}\n{po.PostID} - {po.Name}\n{CUser.Projects_Num}\n{CUser.Completed_Num}";
        }
    }
}
