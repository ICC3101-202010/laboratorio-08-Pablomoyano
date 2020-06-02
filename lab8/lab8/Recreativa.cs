using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Recreativa : Local
    {
        public Recreativa(string name, string owner, int id, string startshift, string endshift, List<string> category)
        {
            this.name = name;
            this.owner = owner;
            this.idnumber = id;
            this.startshift = startshift;
            this.endshift = endshift;
        }
    }
}