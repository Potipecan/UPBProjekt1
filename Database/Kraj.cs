using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public abstract class Table
    {
        public int ID { get; set; }

        protected Dictionary<string, string> columns;

        public Table(int id = -1) {
            ID = id;
            columns = new Dictionary<string, string>();
            columns.Add(nameof(ID), "id");
        }

        public override string ToString()
        {
            string res = "";
            foreach(var p in GetType().GetProperties())
            {
                res += p.GetValue(this).ToString() + ";";
            }
            return res.TrimEnd(';');
        }

        public virtual string GetColumns()
        {
            string res = "";
            foreach(var col in columns)
            {
                res += col.Value + ", ";
            }
            return res.TrimEnd(';');
        }
    }

    public class Kraj : Table
    {
        public string Name { get; set; }
        public string PostID { get; set; }
        public string Abbr { get; set; }

        public Kraj(string name, string postid, string abbr = null, int id = -1) : base(id)
        {
            Name = name;
            PostID = postid;
            Abbr = abbr;

            columns.Add(nameof(Name), "ime");
            columns.Add(nameof(PostID), "posta");
            columns.Add(nameof(Abbr), "kratica");
            
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

            columns.Add(nameof(Name), "ime");
            columns.Add(nameof(Surname), "priimek");
            columns.Add(nameof(Email), "email");
            columns.Add(nameof(Username), "uname");
            columns.Add(nameof(Address), "naslov");
            columns.Add(nameof(Reg_ID), "kraj_id");
            columns.Add(nameof(Projects_Num), "st_projektov");
            columns.Add(nameof(Completed_Num), "st_opravljenih_projektov");
        }
    }
}
