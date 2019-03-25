using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShape
{
    /// <summary>
    /// Abstrakt osztály 
    /// </summary>
    abstract class Alakzat
    {
        protected const double PI = 3.14;
        protected  double x;
        protected  double y;
        public abstract double Terulet();
  

    }
    /// <summary>
    /// A Negyzet osztály származtatva az Alakzat osztályból
    /// </summary>
     class Negyzet : Alakzat
     {

        /// <summary>
        /// Konstruktor - 1 argumentummal, az oldal van megadva
        /// </summary>
        /// <param name="n"></param>
        public Negyzet(double n) 
        {
            x = n;
        }
        /// <summary>
        /// Átdefiniáljuk az Örökölt Terulet() metódust
        /// </summary>
        /// <returns></returns>
        public override double Terulet()
        {
            return x * x;
        }
     }
    class Teglalap : Alakzat
    {
        public Teglalap(double aX, double aY)
        {
            x = aX;
            y = aY;

        }
        public override double Terulet()
        {
            return x * y;
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
    class Haromszog : Alakzat
    {
        public Haromszog(double a, double m)
        {
            x = a;
            y = m;
        }
        public override double Terulet()
        {
            return (x * y) / 2;
        }
    }
}
