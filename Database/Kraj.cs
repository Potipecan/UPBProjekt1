using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Kraj
    {
        public string Name;
        public string PostID;
        public string Abbr;

        public Kraj(string name, string postid, string abbr = null)
        {
            Name = name;
            PostID = postid;
            Abbr = abbr;
        }

        public override string ToString()
        {
            return $"{Name};{PostID};{Abbr}";
        }
    }
}
