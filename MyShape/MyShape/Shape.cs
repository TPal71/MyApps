using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShape
{
    abstract class Alakzat
    {
        protected const double PI = 3.14;
        protected  double x;
        protected  double y;


        public abstract double Terulet();
        


    }
     class Negyzet : Alakzat
     {

        public Negyzet(double n) 
        {
            x = n;
        }
        public override double Terulet()
        {
            return x * x;
        }
     }
    class Kor : Alakzat
    {
        public Kor(double r) 
        {
            x = r;
        }
        public override double Terulet()
        {
            return PI * x * x;
        }
    }
}
