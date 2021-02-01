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
        private User cUser;
        public User CUser
        {
            get => cUser; set
            {
                cUser = value;
                if (value != null)
                {
                    var po = App.POs.Find(p => p.ID == CUser.RegID);
                    UserInfoLabel.Text = $"{CUser.Name}\n{CUser.Surname}\n{CUser.Username}\n{CUser.Email}\n" +
                        $"{CUser.Address}\n{po.Code} - {po.Name}\n{CUser.Projects_Num}\n{CUser.Completed_Num}";
                }
                else UserInfoLabel.Text = "";
            }
        }

        public Settings CSettings { get; set; }
        public List<Project> CProjects { get; set; }

        private Project cProject;
        public Project CProject
        {
            get => cProject; set
            {
                cProject = value;
                if (value != null)
                {
                    TitleTB.Text = CProject.Title;
                    PositionTB.Text = CProject.Position;
                    ClientTB.Text = CProject.Client;
                    ActiveChkB.Checked = CProject.Active;
                    SessionCommitButton.Enabled = true;
                    CommitProjectButton.Text = "Edit";
                }
                else
                {
                    TitleTB.Text = "";
                    PositionTB.Text = "";
                    ClientTB.Text = "";
                    ActiveChkB.Checked = false;
                    SessionCommitButton.Enabled = CSession != null;
                    CommitProjectButton.Text = "Add";
                }
            }
        }

        private Session cSession;
        public Session CSession
        {
            get => cSession; set
            {
                cSession = value;
                if (value != null)
                {
                    WorkSessionLabel.Text = $"{CProjects.Find(p => p.ID == CSession.ProjectID).Title}, since {CSession.From}.";
                    SessionCommitButton.Text = "Finish session.";
                }
                else
                {
                    WorkSessionLabel.Text = "No session in progress. Select a project to start a new session.";
                    SessionCommitButton.Text = "Begin a new session.";
                }
            }
        }

        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(User user) : this()
        {
            CUser = user;

            Task.Run(async () =>
            {
                await GetProjects();
                CSettings = await App.DB.GetSettingForUser(CUser);
                CSession = await App.DB.GetCurrentSession(CUser);
            }).Wait();

            Font = CSettings.GetFont();

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
            if (await App.DB.DeleteUser(user, pass))
            {
                Close();
            }
        }

        private void WindowRefresh()
        {
            Text = $"Dashboard - {CUser.Username}";

            if (CSettings.DarkMode) Const.Dark.ApplyTo(this);
            else Const.Light.ApplyTo(this);
        }

        private void RefreshProjectsLB()
        {
            ProjectsLB.Items.Clear();
            ProjectsLB.Items.Add(String.Format("{0,20} | {1, 15} | {2, 15} | {3, 4} | {4, 2}", "Title", "Client", "Positon", "Hours", "Status"));
            foreach (var p in CProjects)
            {
                ProjectsLB.Items.Add(String.Format("{0,20} | {1, 15} | {2, 15} | {3, 5:F1} | {4, 2}", p.Title, p.Client, p.Position, p.Hours, p.Active ? "WIP" : "DONE"));
            }
        }

        private async Task GetProjects()
        {
            CProjects = await App.DB.GetProjectFromUser(CUser);
            RefreshProjectsLB();
        }

        private void EditProfileButton_Click(object sender, EventArgs e)
        {
            var ef = new EditUserForm(this);
            ef.FormClosed += ChildWindowClosed;
            Enabled = false;
            ef.Show();
        }

        private async void ChildWindowClosed(object sender, FormClosedEventArgs e)
        {
            Enabled = true;
            if(sender.GetType() == typeof(EditUserForm))
            {
                CSettings = await App.DB.GetSettingForUser(CUser);
                Font = CSettings.GetFont();
            }
            WindowRefresh();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to log out?", "Logging out", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes) Close();
        }

        private async void CommitProjectButton_Click(object sender, EventArgs e)
        {
            if (TitleTB.Text != "" && ClientTB.Text != "" && PositionTB.Text != "")
            {
                if (CProject == null) // add new Project
                {
                    var pro = new Project(TitleTB.Text, PositionTB.Text, ActiveChkB.Checked, ClientTB.Text, 0, CUser.ID, DescTB.Text);
                    pro = await App.DB.AddProject(pro);
                    CProjects.Add(pro);

                    Enabled = false;
                    CUser = await App.DB.GetUserByID(CUser.ID);
                    Enabled = true;

                    RefreshProjectsLB();
                    ProjectsLB.SelectedIndex = CProjects.FindIndex(p => p.ID == pro.ID) + 1;
                }
                else // edit project
                {
                    var pro = new Project(TitleTB.Text, PositionTB.Text, ActiveChkB.Checked, ClientTB.Text, 0, CProject.ID, DescTB.Text, CProject.ID);
                    pro = await App.DB.EditProject(pro);
                    if (pro != null)
                    {
                        MessageBox.Show("Success!");
                        Enabled = false;
                        CUser = await App.DB.GetUserByID(CUser.ID);
                        await GetProjects();
                        Enabled = true;
                    }
                    else MessageBox.Show("Action failed");
                }
            }
            else MessageBox.Show("All fields marked with '*' must be filled out.");
        }

        private void ProjectsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            CProject = ProjectsLB.SelectedIndex > 0 ? CProjects[ProjectsLB.SelectedIndex - 1] : null;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ProjectsLB.SelectedIndex = -1;
        }

        private async void DeleteProjectButton_Click(object sender, EventArgs e)
        {
            if (await App.DB.DeleteProject(CProject))
            {
                MessageBox.Show("Project succesfully deleted.");
                Enabled = false;
                await GetProjects();
                Enabled = true;
                CSession = await App.DB.GetCurrentSession(CUser);
            }
            else MessageBox.Show("Project deletion failed.");
        }

        private async void SessionCommitButton_Click(object sender, EventArgs e)
        {
            if (CSession == null)
            {
                if (CProject != null)
                {
                    var ses = new Session(DateTime.Now, DateTime.MinValue, CProject.ID, SessionCommentTB.Text);
                    Enabled = false;
                    ses = await App.DB.NewSession(ses);
                    Enabled = true;
                    if (ses != null)
                    {
                        CSession = ses;
                    }
                    else MessageBox.Show("Error! Session could not start.");
                }                
            }
            else
            {
                var ses = new Session(CSession.From, DateTime.Now, CSession.ProjectID, CSession.Comment, CSession.ID);
                Enabled = false;
                ses = await App.DB.EditSession(ses);
                Enabled = true;
                if (ses != null)
                {
                    CSession = null;
                    await GetProjects();
                }
                else MessageBox.Show("Error! Session could not be closed.");
            }
        }

        private void BrowseSessionsBTN_Click(object sender, EventArgs e)
        {
            if (CProject != null)
            {
                var sb = new SessionBrowser(this);
                sb.FormClosed += ChildWindowClosed;
                Enabled = false;
                sb.Show();
            }
            else MessageBox.Show("Select a session first.");
        }
    }
}