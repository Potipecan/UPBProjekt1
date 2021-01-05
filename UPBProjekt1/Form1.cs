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
    public partial class Form1 : Form
    {
        DatabaseManager DB;
        public Form1()
        {
            InitializeComponent();

            DB = new DatabaseManager();

            Task.Run(async () =>
            {
                var list = await DB.GetAllPost();
                list.ForEach(i => AllPostLB.Items.Add(i.ToString()));
            }).Wait();
        }
    }
}
