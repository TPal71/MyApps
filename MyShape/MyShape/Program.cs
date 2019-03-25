using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShape
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = 10, b = 20, r = 10, m = 10;

            Alakzat n = new Negyzet(a);
            Alakzat n2 = new Negyzet(b);

            Alakzat k = new Kor(r);
            Alakzat t = new Teglalap(a,b);
            Alakzat h = new Haromszog(a, m);

            Console.WriteLine("Négyzet területe(a={0}):{1}",a,n.Terulet());
            Console.WriteLine("Négyzet területe(a={0}):{1}", b, n2.Terulet());
            Console.WriteLine("Kör területe:(r={0}):{1}",r,k.Terulet());
            Console.WriteLine("Téglalap területe:(a={0}, b={1}):{2}", a,b, t.Terulet());
            Console.WriteLine("Háromszög területe:(a={0}, m={1}):{2}", a, m, h.Terulet());

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
