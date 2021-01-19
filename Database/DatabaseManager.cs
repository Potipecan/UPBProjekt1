using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;

namespace Database
{
    public class DatabaseManager
    {
        
        string connString;
        private NpgsqlConnection conn;

        public DatabaseManager()
        {
            connString = $"Host={Const.Host};Username={Const.User};Password={Const.Pass};Database={Const.DBName}";
            conn = new NpgsqlConnection(connString);
        }

        public async Task<List<Kraj>> GetAllPOs()
        {
            var result = new List<Kraj>();

            await conn.OpenAsync();

            string command = "SELECT id, ime, posta FROM kraji;";
            using(var com = new NpgsqlCommand(command, conn))
            {
                var r = com.ExecuteReader();
                while(await r.ReadAsync())
                {
                    result.Add(new Kraj(r.GetString(1), r.GetString(2), id: r.GetInt32(0)));
                }
            }

            await conn.CloseAsync();

            return result;
        }

        public async Task<User> GetUser(string username, string password)
        {
            User res = null;
            await conn.OpenAsync();
            string command = "SELECT * FROM get_user(@uname, @pass);";
            using(var com = new NpgsqlCommand(command, conn))
            {
                com.Parameters.AddWithValue("uname", username);
                com.Parameters.AddWithValue("pass", password);
                var r = await com.ExecuteReaderAsync();

                if(await r.ReadAsync())
                {
                    res = new User(r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4), r.GetString(5), r.GetInt32(6), r.GetInt32(7), r.GetInt32(8), r.GetInt32(0));
                }
                
            }
            await conn.CloseAsync();

            return res;
        }

        public async Task<User> RegisterUser(User newUser, string pass)
        {
            User res;

            await conn.OpenAsync();
            string command = $"SELECT * FROM register_user(@name, @surname, @uname, @email, @address, @postid, @pass)";
            using(var com = new NpgsqlCommand(command, conn))
            {
                com.Parameters.AddWithValue("name", NpgsqlDbType.Varchar, newUser.Name);
                com.Parameters.AddWithValue("surname", NpgsqlDbType.Varchar, newUser.Surname);
                com.Parameters.AddWithValue("uname", NpgsqlDbType.Varchar, newUser.Username);
                com.Parameters.AddWithValue("email", NpgsqlDbType.Varchar, newUser.Email);
                com.Parameters.AddWithValue("postid", NpgsqlDbType.Integer, newUser.Reg_ID);
                com.Parameters.AddWithValue("address", NpgsqlDbType.Varchar, newUser.Address);
                com.Parameters.AddWithValue("pass", NpgsqlDbType.Varchar, pass);

                var r = await com.ExecuteReaderAsync();
                if (await r.ReadAsync())
                {
                    res = new User(r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4), r.GetString(5), r.GetInt32(6), r.GetInt32(7), r.GetInt32(8), r.GetInt32(0));
                }
                else res = null;
            }

            await conn.CloseAsync();
            return res;
        }
    }
}
