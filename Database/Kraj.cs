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

        public override string ToString()
        {
            return $"{Name};{PostID};{Abbr}";
        }
    }

    //public class /*User*/
}
