using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Database
{
    public abstract class Table
    {
        public int ID { get; set; }


        public Table(int id = -1) {
            ID = id;
        }

        public Table(NpgsqlDataReader r)
        {
            ID = r.GetInt32(0);
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
        public string Code { get; set; }
        public string Abbr { get; set; }

        public Region(string name, string postid, string abbr = null, int id = -1) : base(id)
        {
            Name = name;
            Code = postid;
            Abbr = abbr;
        }

        public Region(NpgsqlDataReader r) : base(r)
        {
            Name = r.GetString(1);
            Code = r.GetString(2);
            Abbr = (!r.IsDBNull(3)) ? r.GetString(3) : "";
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

        public User(NpgsqlDataReader r) : base(r)
        {
            Name = r.GetString(1);
            Surname = r.GetString(2);
            Username = r.GetString(3);
            Email = r.GetString(4);
            Address = r.GetString(5);
            Reg_ID = r.GetInt32(6);
            Projects_Num = r.GetInt32(7);
            Completed_Num = r.GetInt32(8);
        }
    }

    public class Settings : Table
    {
        public int UserID { get; set; }
        public bool DarkMode { get; set; }
        public string Font { get; set; }

        public Settings(int id, int uid, bool darkmode, string font) : base(id)
        {
            UserID = uid;
            DarkMode = darkmode;
            Font = font;
        }

        public Settings(NpgsqlDataReader r) : base(r)
        {
            Font = r.GetString(1);
            DarkMode = r.GetBoolean(2);
            UserID = r.GetInt32(3);
        }

    }
}
