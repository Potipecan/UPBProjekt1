using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public abstract class Table
    {
        public int ID { get; set; }


        public Table(int id = -1) {
            ID = id;
        }

        public override string ToString()
        {
            string res = "";
            foreach(var p in GetType().GetProperties())
            {
                object val = p.GetValue(this);
                res += ((val != null) ? val.ToString() : "null") + ";";
            }
            return res.TrimEnd(';');
        }
    }

    public class Region : Table
    {
        public string Name { get; set; }
        public string PostID { get; set; }
        public string Abbr { get; set; }

        public Region(string name, string postid, string abbr = null, int id = -1) : base(id)
        {
            Name = name;
            PostID = postid;
            Abbr = abbr;
        }
    }

    public class User : Table
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Reg_ID { get; set; }
        public int Projects_Num { get; set; }
        public int Completed_Num { get; set; }

        public User(
            string name,
            string surname,
            string username,
            string email,
            string address,
            int reg_id,
            int proj_num = 0,
            int comp_num = 0,            
            int id = -1
            ) : base(id)
        {
            Name = name;
            Surname = surname;
            Username = username;
            Email = email;
            Address = address;
            Reg_ID = reg_id;
            Projects_Num = proj_num;
            Completed_Num = comp_num;
        }
    }

    public class Settings : Table
    {
        public int UserID { get; set; }
        public bool DarkMode { get; set; }
        public string Font { get; set; }

        public Settings(int id, int uid, bool darkmode, string font) : base(id)
        {
            UserID = id;
            DarkMode = darkmode;
            Font = font;
        }

    }
}
