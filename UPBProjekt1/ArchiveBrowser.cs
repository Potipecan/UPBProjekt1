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
    public partial class ArchiveBrowser : Form
    {
        private EditUserForm Editor;

        private Archive sArchive;
        private Archive SArchive
        {
            get => sArchive; set
            {
                sArchive = value;
                DeleteArchiveBTN.Enabled = value != null;
                LoadArchiveBTN.Enabled = value != null;
            }
        }

        private List<Archive> Archives;

        public ArchiveBrowser(EditUserForm form)
        {
            InitializeComponent();
            Editor = form;

            Task.Run(async () =>
            {
                Archives = await App.DB.GetArchivesForUser(Editor.Dash.CUser);
            }).Wait();
            // dd/MM/yy hh:mm:ss
            ArchiveLB.Items.Add(String.Format("{0, 20} | {1, 20} | {2, 20} | {3, 30} | {4, 20} | {5, 30} | {6, 17}", "Name", "Surname", "Username", "Email", "Address", "Post", "Date"));
            var post = App.POs.Find(p => p.ID == Editor.Dash.CUser.RegID);
            Archives.ForEach(a => ArchiveLB.Items.Add(
                String.Format("{0, 20} | {1, 20} | {2, 20} | {3, 30} | {4, 20} | {5, 30} | {6, 17:dd/MM/yy hh:mm:ss}", a.Name, a.Surname, a.Username, a.Email, a.Address, $"{post.Code} - {post.Name}", a.Date)
                ));
        }

        private void ArchiveLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ArchiveLB.SelectedIndex > 0)
            {
                SArchive = Archives[ArchiveLB.SelectedIndex - 1];
            }
            else SArchive = null;
        }

        private void LoadArchiveBTN_Click(object sender, EventArgs e)
        {
            Editor.UpdateFields(SArchive.ToUser());
            Close();
        }

        private async void DeleteArchiveBTN_Click(object sender, EventArgs e)
        {
            var res = await App.DB.DeleteArchive(SArchive);
            if (res)
            {
                ArchiveLB.Items.RemoveAt(ArchiveLB.SelectedIndex);
                Archives.Remove(SArchive);
                ArchiveLB.SelectedIndex = -1;
            }
            else MessageBox.Show("Error! Archive could not be deleted.");
        }
    }
}
