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
}
