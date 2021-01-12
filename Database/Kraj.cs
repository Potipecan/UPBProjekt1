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

        public Table() {
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

        public Kraj(string name, string postid, string abbr = null) : base()
        {

            Name = name;
            PostID = postid;
            Abbr = abbr;

            columns.Add(nameof(Name), "ime");
            columns.Add(nameof(PostID), "posta");
            columns.Add(nameof(Abbr), "kratica");
            
        }
    }

    //public class /*User*/
}
