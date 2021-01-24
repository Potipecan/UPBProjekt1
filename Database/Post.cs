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

        public abstract NpgsqlCommand InsertCommand(NpgsqlConnection conn);

        public abstract NpgsqlCommand UpdateCommand(NpgsqlConnection conn);

    }

    public class Post : Table
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Abbr { get; set; }

        public Post(string name, string postid, string abbr = null, int id = -1) : base(id)
        {
            Name = name;
            Code = postid;
            Abbr = abbr;
        }

        public Post(NpgsqlDataReader r) : base(r)
        {
            Name = r.GetString(1);
            Code = r.GetString(2);
            Abbr = (!r.IsDBNull(3)) ? r.GetString(3) : "";
        }

        public override NpgsqlCommand InsertCommand(NpgsqlConnection conn)
        {
            string command = "SELECT * FROM add_kraj(@name, @code, @abbr);";
            var com = new NpgsqlCommand(command, conn);
            com.Parameters.AddWithValue("name", Name);
            com.Parameters.AddWithValue("code", Code);
            com.Parameters.AddWithValue("abbr", Abbr == "" ? null : Abbr);

            return com;
        }

        public override NpgsqlCommand UpdateCommand(NpgsqlConnection conn)
        {
            string command = "SELECT * FROM update_kraj(@id, @name, @code, @abbr);";
            var com = new NpgsqlCommand(command, conn);
            com.Parameters.AddWithValue("id", ID);
            com.Parameters.AddWithValue("name", Name);
            com.Parameters.AddWithValue("code", Code);
            com.Parameters.AddWithValue("abbr", Abbr == "" ? null : Abbr);

            return com;
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

        /// <summary>
        /// Command parameter <c>pass</c> must be added externally.
        /// </summary>
        /// <param name="conn"></param>
        /// <returns></returns>
        public override NpgsqlCommand InsertCommand(NpgsqlConnection conn)
        {
            string command = "SELECT * FROM register_user(@name, @surname, @uname, @email, @address, @postid, @pass);";
            var com = new NpgsqlCommand(command, conn);
            com.Parameters.AddWithValue("name", Name);
            com.Parameters.AddWithValue("surname", Surname);
            com.Parameters.AddWithValue("uname", Username);
            com.Parameters.AddWithValue("email", Email);
            com.Parameters.AddWithValue("postid", Reg_ID);
            com.Parameters.AddWithValue("address", Address);

            return com;
        }

        /// <summary>
        /// Commmand parameters <c>newpass</c> and <c>passchk</c> must be added externally.
        /// </summary>
        /// <param name="conn"></param>
        /// <returns></returns>
        public override NpgsqlCommand UpdateCommand(NpgsqlConnection conn)
        {
            string command = "SELECT * FROM update_user(@id, @name, @surname, @uname, @email, @address, @postid, @newpass, @passchk);";
            var com = new NpgsqlCommand(command, conn);
            com.Parameters.AddWithValue("name", Name);
            com.Parameters.AddWithValue("surname", Surname);
            com.Parameters.AddWithValue("uname", Username);
            com.Parameters.AddWithValue("email", Email);
            com.Parameters.AddWithValue("postid", Reg_ID);
            com.Parameters.AddWithValue("address", Address);

            return com;
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

        public override NpgsqlCommand InsertCommand(NpgsqlConnection conn)
        {
            throw new NotImplementedException("Do not call this function for settings.");
        }

        /// <summary>
        /// Gets command
        /// </summary>
        /// <param name="conn">Database connection</param>
        /// <returns>NpgsqlCommand</returns>
        public override NpgsqlCommand UpdateCommand(NpgsqlConnection conn)
        {
            string command = "SELECT * FROM set_settings(@id, @darkmode, @font);";
            var com = new NpgsqlCommand(command, conn);
            com.Parameters.AddWithValue("id", ID);
            com.Parameters.AddWithValue("darkmode", DarkMode);
            com.Parameters.AddWithValue("font", Font);

            return com;
        }
    }

    public class Project : Table
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Position { get; set; }
        public bool Active { get; set; }
        public string Client { get; set; }
        public double Hours { get; set; }
        public int UserID { get; set; }

        public Project(
            string title,
            string position,
            bool active,
            string client,
            double hours,
            int userid,
            string desc = "",
            int id = -1
            ) : base(id)
        {
            Title = title;
            Position = position;
            Active = active;
            Client = client;
            Hours = hours;
            UserID = userid;
            Description = desc;
        }

        public Project(NpgsqlDataReader r) : base(r)
        {
            Title = r.GetString(1);
            Description = r.GetString(2);
            Position = r.GetString(3);
            Active = r.GetBoolean(4);
            Client = r.GetString(5);
            Hours = r.GetDouble(6);
            UserID = r.GetInt32(7);
        }

        public override NpgsqlCommand InsertCommand(NpgsqlConnection conn)
        {
            string command = "SELECT * FROM add_projekt(@title, @position, @client, @userid, @desc, @active);";
            var com = new NpgsqlCommand(command, conn);

            com.Parameters.AddWithValue("title", Title);
            com.Parameters.AddWithValue("position", Position);
            com.Parameters.AddWithValue("client", Client);
            com.Parameters.AddWithValue("userid", UserID);
            com.Parameters.AddWithValue("desc", Description != "" ? Description : null);
            com.Parameters.AddWithValue("active", Active);

            return com;
        }

        public override NpgsqlCommand UpdateCommand(NpgsqlConnection conn)
        {
            string command = "SELECT * FROM edit_projekt(@id, @title, @position, @client, @userid, @desc, @active);";
            var com = new NpgsqlCommand(command, conn);

            com.Parameters.AddWithValue("id", ID);
            com.Parameters.AddWithValue("title", Title);
            com.Parameters.AddWithValue("position", Position);
            com.Parameters.AddWithValue("client", Client);
            com.Parameters.AddWithValue("userid", UserID);
            com.Parameters.AddWithValue("desc", Description != "" ? Description : null);
            com.Parameters.AddWithValue("active", Active);

            return com;
        }
    }

    public class Session : Table
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Comment { get; set; }
        public int ProjectID { get; set; }

        public Session(DateTime from, DateTime to, int projid, string comment = "", int id = -1) : base(id)
        {
            From = from;
            To = to;
            Comment = comment;
            ProjectID = projid;
        }

        public Session(NpgsqlDataReader r) : base(r)
        {
            From = r.GetDateTime(1);
            To = r.GetDateTime(2);
            Comment = r.GetString(3);
            ProjectID = r.GetInt32(4);
        }

        public override NpgsqlCommand InsertCommand(NpgsqlConnection conn)
        {
            string command = "SELECT * FROM add_delo(@from, @projectid, @to, @comment);";
            var com = new NpgsqlCommand(command, conn);
            com.Parameters.AddWithValue("from", From);
            com.Parameters.AddWithValue("projectid", ProjectID);
            com.Parameters.AddWithValue("to", To != DateTime.MinValue ? To.ToString("yyyy-MM-dd HH:mm:ss") : null);
            com.Parameters.AddWithValue("comment", Comment != "" ? Comment : null);

            return com;
        }

        public override NpgsqlCommand UpdateCommand(NpgsqlConnection conn)
        {
            string command = "SELECT * FROM edit_delo(@id, @from, @projectid, @to, @comment);";
            var com = new NpgsqlCommand(command, conn);
            com.Parameters.AddWithValue("id", ID);
            com.Parameters.AddWithValue("from", From);
            com.Parameters.AddWithValue("projectid", ProjectID);
            com.Parameters.AddWithValue("to", To != DateTime.MinValue ? To.ToString("yyyy-MM-dd HH:mm:ss") : null);
            com.Parameters.AddWithValue("comment", Comment != "" ? Comment : null);

            return com;
        }
    }
}
