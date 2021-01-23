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

        #region Post code CRUD
        public async Task<List<Region>> GetAllPOs()
        {
            var result = new List<Region>();

            await conn.OpenAsync();

            string command = "SELECT * FROM all_kraji();";
            using (var com = new NpgsqlCommand(command, conn))
            {
                var r = com.ExecuteReader();
                while (await r.ReadAsync())
                {
                    result.Add(new Region(r));
                }
            }

            await conn.CloseAsync();

            return result;
        }

        public async Task<Region> UpdatePO(Region po)
        {
            Region res = null;
            await conn.OpenAsync();
            using(var com = po.UpdateCommand(conn))
            {
                var r = await com.ExecuteReaderAsync();
                if (await r.ReadAsync()) res = new Region(r);

                com.Dispose();
            }
            await conn.CloseAsync();

            return res;
        }

        public async Task<Region> AddPO(Region po)
        {
            Region res = null;
            await conn.OpenAsync();
            using (var com = po.InsertCommand(conn))
            {
                var r = await com.ExecuteReaderAsync();
                if (await r.ReadAsync()) res = new Region(r);

                com.Dispose();
            }
            await conn.CloseAsync();

            return res;
        }

        public async Task<bool> DeletePO(Region po)
        {
            bool res = false;
            await conn.OpenAsync();
            string command = "SELECT * FROM delete_kraj(@id);";
            using (var com = new NpgsqlCommand(command, conn))
            {
                com.Parameters.AddWithValue("id", po.ID);

                try
                {
                    var r = await com.ExecuteReaderAsync();
                    if (await r.ReadAsync()) res = r.GetBoolean(0);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                com.Dispose();
            }

            await conn.CloseAsync();

            return res;
        }
        #endregion

        #region User CRUD
        public async Task<User> GetUser(string username, string password)
        {
            User res = null;
            await conn.OpenAsync();
            string command = "SELECT * FROM get_user(@uname, @pass);";
            using (var com = new NpgsqlCommand(command, conn))
            {
                com.Parameters.AddWithValue("uname", username);
                com.Parameters.AddWithValue("pass", password);
                var r = await com.ExecuteReaderAsync();

                if (await r.ReadAsync())
                {
                    res = new User(r);
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
            using (var com = newUser.InsertCommand(conn))
            {
                com.Parameters.AddWithValue("pass", NpgsqlDbType.Varchar, pass);

                var r = await com.ExecuteReaderAsync();
                if (await r.ReadAsync())
                {
                    res = new User(r);
                }
                else res = null;
            }

            await conn.CloseAsync();
            return res;
        }

        public async Task<User> UpdateUser(User user, string newpass, string passchk)
        {
            User res = null;

            await conn.OpenAsync();

            using (var com = user.UpdateCommand(conn))
            {
                com.Parameters.AddWithValue("newpass", newpass);
                com.Parameters.AddWithValue("passchk", passchk);

                var r = com.ExecuteReader();
                if (await r.ReadAsync()) res = new User(r);

                com.Dispose();
            }
            await conn.CloseAsync();

            return res;
        }

        public async Task<bool> DeleteUser(User user, string pass)
        {
            bool res = false;

            await conn.OpenAsync();
            string command = "SELECT delete_user(@id, @passchk)";
            using (var com = new NpgsqlCommand(command, conn))
            {
                com.Parameters.AddWithValue("id", user.ID);
                com.Parameters.AddWithValue("passchk", pass);

                var r = await com.ExecuteReaderAsync();

                try
                {
                    if (await r.ReadAsync()) res = r.GetBoolean(0);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                com.Dispose();
            }
            await conn.CloseAsync();

            return res;
        }
        #endregion

        #region Settings RU
        public async Task<Settings> GetSettingForUser(User user)
        {
            Settings res = null;

            await conn.OpenAsync();
            string command = "SELECT * FROM get_settings(@uid);";
            using (var com = new NpgsqlCommand(command, conn))
            {
                com.Parameters.AddWithValue("uid", user.ID);
                var r = await com.ExecuteReaderAsync();
                if (await r.ReadAsync()) res = new Settings(r);
            }

            await conn.CloseAsync();
            return res;
        }

        public async Task<Settings> SetSettings(Settings settings)
        {
            Settings res = null;
            await conn.OpenAsync();
            using (var com = settings.UpdateCommand(conn))
            {
                var r = await com.ExecuteReaderAsync();
                if (await r.ReadAsync()) res = new Settings(r);
                com.Dispose();
            }

            await conn.CloseAsync();
            return res;
        }
        #endregion    
    }
}
