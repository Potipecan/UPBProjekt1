using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Database
{
    public class DatabaseManager
    {
        const string _host = "rogue.db.elephantsql.com";
        const string _user = "hxsncoqk";
        const string _pass = "XaZ8iDDa0PccwESDkH7g9zxwVMT4jdYp";
        const string _dbname = "hxsncoqk";
        string connString;
        private NpgsqlConnection conn;

        public DatabaseManager()
        {
            connString = $"Host={_host};Username={_user};Password={_pass};Database={_dbname}";
            conn = new NpgsqlConnection(connString);
        }

        public async Task<List<Kraj>> GetAllPost()
        {
            var result = new List<Kraj>();

            await conn.OpenAsync();

            string command = "SELECT ime, posta FROM kraji;";
            using(var com = new NpgsqlCommand(command, conn))
            {
                var r = com.ExecuteReader();
                while(await r.ReadAsync())
                {
                    result.Add(new Kraj(r.GetString(0), r.GetString(1)));
                }
            }

            await conn.CloseAsync();

            return result;
        }
    }
}
