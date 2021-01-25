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
    public partial class SessionBrowser : Form
    {
        private Dashboard Dash;
        private Session sSession;
        private Session SSession { get => sSession;
            set
            {
                sSession = value;
                if(value != null)
                {
                    var dur = SSession.To - SSession.From;
                    InfoLabel.Text = String.Format("{0:D}\n{1:D}\n{2}", SSession.From, SSession.To, dur);
                    CommentLabel.Text = SSession.Comment;
                    DeleteSessionButton.Enabled = true;
                }
                else
                {
                    InfoLabel.Text = "";
                    CommentLabel.Text = "";
                    DeleteSessionButton.Enabled = false;
                }
            }
        }

        private List<Session> Sessions;
        public SessionBrowser(Dashboard dash)
        {
            InitializeComponent();

            Dash = dash;

            ProjectInfoLabel.Text = Dash.CProject.Title;
            Task.Run(async () => Sessions = await App.DB.GetSessionsForProject(Dash.CProject)).Wait();
            SessionsLB.Items.Add(String.Format("{0, 17} | {1, 17}", "Began on", "Ended"));
            Sessions.ForEach(s => SessionsLB.Items.Add(String.Format("{0, 17:dd/MM/yy hh:mm:ss} | {1, 17:dd/MM/yy hh:mm:ss}", s.From, s.To)));
        }

        private void SessionsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            SSession = Sessions[SessionsLB.SelectedIndex - 1];
        }

        private async void DeleteSessionButton_Click(object sender, EventArgs e)
        {
            if(await App.DB.DeleteSession(SSession))
            {
                SessionsLB.Items.RemoveAt(SessionsLB.SelectedIndex);
                Sessions.Remove(SSession);
                SSession = null;
            }
        }
    }
}
