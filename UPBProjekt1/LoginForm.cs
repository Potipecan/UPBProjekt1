﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;
using Npgsql;

namespace UPBProjekt1
{
    public partial class App : Form
    {
        public static DatabaseManager DB;
        public static List<Post> POs;

        public App()
        {
            InitializeComponent();

            DB = new DatabaseManager();

            Task.Run(async () => await UpdatePOs()).Wait();

            POs.ForEach(p => PostCB.Items.Add($"{p.Code} - {p.Name}"));
        }

        public static async Task UpdatePOs()
        {
            POs = await DB.GetAllPOs();
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameTB.Text != "" && PasswordTB.Text != "")
            {
                LoginButton.Enabled = false;
                var user = await DB.GetUser(UsernameTB.Text, PasswordTB.Text);
                ToDashboard(user);
                LoginButton.Enabled = true;
            }
            else MessageBox.Show("Fill out all fields.");
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

        private async void RegisterButton_Click(object sender, EventArgs e)
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
            try
            {
                newUser = await DB.RegisterUser(newUser, PassTB.Text);
            }
            catch (NpgsqlException ex)
            {
                if ((string)ex.Data["SqlState"] == "23505")
                {
                    string message = "Unknown constraint violation!";
                    switch (ex.Data["ConstraintName"])
                    {
                        case "uime":
                            message = "Registration failed!\nUsername already taken.";
                            break;
                        case "email":
                            message = "Registration failed\nEmail already taken.";
                            break;
                    }
                    MessageBox.Show(message);
                    return;
                }
                else throw ex;
            }
            ToDashboard(newUser);
        }

        private void ToDashboard(User user)
        {
            if(user == null)
            {
                MessageBox.Show("Login failed.");
                return;
            }

            foreach(var c in Controls)
            {
                if (c.GetType() == typeof(TextBox)) (c as TextBox).Text = "";
            }
            PostCB.SelectedIndex = -1;

            Hide();
            var d = new Dashboard(user);
            d.FormClosed += DashboardClosed;
            d.Show();
        }

        private async void DashboardClosed(object sender, FormClosedEventArgs e)
        {
            await UpdatePOs();
            PostCB.Items.Clear();
            POs.ForEach(p => PostCB.Items.Add($"{p.Code} - {p.Name}"));
            Show();
        }
    }
}
