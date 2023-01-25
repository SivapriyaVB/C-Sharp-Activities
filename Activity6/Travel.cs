using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity6
{
    internal class Travel
    {
        public string starting;
        public string ending;
        public int path;
        public int short_path;
        public int fair;
        public int fair_short;
        public Travel(string a, string b, int c, int short_path, int fair, int fair_short)
        {
            this.starting = a;
            this.ending = b;
            this.path = c;
            this.fair_short = fair_short;
            this.fair = fair;
            this.short_path = short_path;
        }
    }
}
