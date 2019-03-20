using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShape
{
    abstract class Alakzat
    {
        abstract public int Terulet();
    }
     class Negyzet : Alakzat
    {
        int Oldal = 0;

        public Negyzet(int n)
        {
            Oldal = n;
        }
        public override int Terulet()
        {
            return Oldal * Oldal;
        }
    }
}
