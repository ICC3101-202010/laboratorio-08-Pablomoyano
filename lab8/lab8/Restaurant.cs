using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    public class Restaurant : Local
    {
        bool hasexclusivestables;
        int exclusivetables;
        int normaltables;
        public Restaurant(string name, string owner, int id, string startshift, string endshift,bool hastables,int excl, int normtab )
        {
            this.name = name;
            this.owner = owner;
            this.idnumber = id;
            this.startshift = startshift;
            this.endshift = endshift;
            this.hasexclusivestables = hastables;
            this.normaltables = normtab;
            this.exclusivetables = excl;
        }
    } }
