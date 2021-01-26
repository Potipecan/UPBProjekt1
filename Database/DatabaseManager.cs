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
        public async Task<List<Post>> GetAllPOs()
        {
            var result = new List<Post>();

            await conn.OpenAsync();

            string command = "SELECT * FROM all_kraji();";
            using (var com = new NpgsqlCommand(command, conn))
            {
                var r = com.ExecuteReader();
                while (await r.ReadAsync())
                {
                    result.Add(new Post(r));
                }
            }

            await conn.CloseAsync();

            return result;
        }

        public async Task<Post> UpdatePO(Post po)
        {
            Post res = null;
            await conn.OpenAsync();
            using (var com = po.UpdateCommand(conn))
            {
                var r = await com.ExecuteReaderAsync();
                if (await r.ReadAsync()) res = new Post(r);

                com.Dispose();
            }
            await conn.CloseAsync();

            return res;
        }

        public async Task<Post> AddPO(Post po)
        {
            Post res = null;
            await conn.OpenAsync();
            using (var com = po.InsertCommand(conn))
            {
                var r = await com.ExecuteReaderAsync();
                if (await r.ReadAsync()) res = new Post(r);

                com.Dispose();
            }
            await conn.CloseAsync();

            return res;
        }

        public async Task<bool> DeletePO(Post po)
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

        public async Task<User> GetUserByID(int id)
        {
            User res = null;
            string command = "SELECT * FROM get_user_by_id(@id);";
            await conn.OpenAsync();
            using (var com = new NpgsqlCommand(command, conn))
            {
                com.Parameters.AddWithValue("id", id);
                var r = await com.ExecuteReaderAsync();
                if (await r.ReadAsync()) res = new User(r);
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

        #region Projects CRUD
        public async Task<List<Project>> GetProjectFromUser(User user, int proid = -1)
        {
            var res = new List<Project>();
            await conn.OpenAsync();
            string command = "SELECT * FROM get_projekti(@userid, @proid)";

            using(var com = new NpgsqlCommand(command, conn))
            {
                com.Parameters.AddWithValue("userid", user.ID);
                com.Parameters.AddWithValue("proid", proid > 0 ? proid.ToString() : null);

                var r = await com.ExecuteReaderAsync();
                while(await r.ReadAsync())
                {
                    res.Add(new Project(r));
                }

                com.Dispose();
            }

            await conn.CloseAsync();

            return res;
        }

        public async Task<Project> EditProject(Project project)
        {
            Project res = null;

            await conn.OpenAsync();

            using(var com = project.UpdateCommand(conn))
            {
                var r = await com.ExecuteReaderAsync();
                if (await r.ReadAsync()) res = new Project(r);
                com.Dispose();
            }

            await conn.CloseAsync();
            return res;
        }

        public async Task<Project> AddProject(Project project)
        {
            Project res = null;

            await conn.OpenAsync();

            using (var com = project.InsertCommand(conn))
            {
                var r = await com.ExecuteReaderAsync();
                if (await r.ReadAsync()) res = new Project(r);
                com.Dispose();
            }

            await conn.CloseAsync();
            return res;
        }

        public async Task<bool> DeleteProject(Project project)
        {
            bool res = false;
            string command = "SELECT * FROM delete_projekt(@userid, @proid);";
            await conn.OpenAsync();

            using(var com = new NpgsqlCommand(command, conn))
            {
                com.Parameters.AddWithValue("userid", project.UserID);
                com.Parameters.AddWithValue("proid", project.ID);

                var r = await com.ExecuteReaderAsync();
                if (await r.ReadAsync()) res = r.GetBoolean(0);

                com.Dispose();
            }

            await conn.CloseAsync();
            return res;
        }

        #endregion

        #region Sessions CRUD

        public async Task<Session> GetCurrentSession(User user)
        {
            Session res = null;
            string command = "SELECT * FROM get_current_session(@uid);";
            await conn.OpenAsync();
            using (var com = new NpgsqlCommand(command, conn))
            {
                com.Parameters.AddWithValue("uid", user.ID);
                var r = await com.ExecuteReaderAsync();
                if (await r.ReadAsync()) res = new Session(r);
                com.Dispose();
            }
            await conn.CloseAsync();
            return res;
        }

        public async Task<List<Session>> GetSessionsForProject(Project project)
        {
            var res = new List<Session>();
            string command = "SELECT * FROM get_delo(@prid);";
            await conn.OpenAsync();
            using (var com = new NpgsqlCommand(command, conn))
            {
                com.Parameters.AddWithValue("prid", project.ID);
                var r = await com.ExecuteReaderAsync();
                while(await r.ReadAsync())
                {
                    res.Add(new Session(r));
                }
                com.Dispose();
            }
            await conn.CloseAsync();
            return res;
        }

        public async Task<Session> NewSession(Session session)
        {
            Session res = null;
            await conn.OpenAsync();
            using(var com = session.InsertCommand(conn))
            {
                var r = await com.ExecuteReaderAsync();
                if (await r.ReadAsync()) res = new Session(r);
            }
            await conn.CloseAsync();
            return res;
        }

        public async Task<Session> EditSession(Session session)
        {
            Session res = null;
            await conn.OpenAsync();
            using (var com = session.UpdateCommand(conn))
            {
                var r = await com.ExecuteReaderAsync();
                if (await r.ReadAsync()) res = new Session(r);
            }
            await conn.CloseAsync();
            return res;
        }

        public async Task<bool> DeleteSession(Session session)
        {
            bool res = false;
            string command = "SELECT * FROM delete_delo(@id, @projid);";
            await conn.OpenAsync();
            using (var com = new NpgsqlCommand(command, conn))
            {
                com.Parameters.AddWithValue("id", session.ID);
                com.Parameters.AddWithValue("projid", session.ProjectID);

                var r = await com.ExecuteReaderAsync();
                if (await r.ReadAsync()) res = r.GetBoolean(0);
            }
            await conn.CloseAsync();
            return res;
        }

        #endregion

        #region Archive RD

        public async Task<List<Archive>> GetArchivesForUser(User user)
        {
            var res = new List<Archive>();
            string command = "SELECT * FROM get_arhiv(@uid);";
            await conn.OpenAsync();
            using (var com = new NpgsqlCommand(command, conn))
            {
                com.Parameters.AddWithValue("uid", user.ID);
                var r = await com.ExecuteReaderAsync();
                while(await r.ReadAsync())
                {
                    res.Add(new Archive(r));
                }
                com.Dispose();
            }
            await conn.CloseAsync();
            return res;
        }

        public async Task<bool> DeleteArchive(Archive archive)
        {
            bool res = false;
            string command = "SELECT * FROM delete_arhiv(@id);";
            await conn.OpenAsync();
            using (var com = new NpgsqlCommand(command, conn))
            {
                com.Parameters.AddWithValue("id", archive.ID);
                var r = await com.ExecuteReaderAsync();
                if (await r.ReadAsync()) res = r.GetBoolean(0);
                com.Dispose();
            }
            await conn.CloseAsync();
            return res;
        }

        #endregion
    }
}
