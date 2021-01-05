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
        
        string connString;
        private NpgsqlConnection conn;

        public DatabaseManager()
        {
            connString = $"Host={Const.Host};Username={Const.User};Password={Const.Pass};Database={Const.DBName}";
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
