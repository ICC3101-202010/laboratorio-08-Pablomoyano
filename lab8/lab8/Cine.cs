using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    public class Cine : Local
    {
        int numerosalas;
        public Cine(string name, string owner, int id, string startshift, string endshift, int numerosalas)
        {
            this.name = name;
            this.owner = owner;
            this.idnumber = id;
            this.startshift = startshift;
            this.endshift = endshift;
            this.numerosalas = numerosalas;
        }
    }
}