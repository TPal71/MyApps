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

            double a = 10, b = 20, r = 10;
            Alakzat n = new Negyzet(a);
            Alakzat k = new Kor(r);
            Alakzat t = new Teglalap(a,b);

            Console.WriteLine("Négyzet területe(a={0}):{1}",a,n.Terulet());
            Console.WriteLine("Kör területe:(r={0}):{1}",r,k.Terulet());
            Console.WriteLine("Téglalap területe:(a={0}, b={1}):{2}", a,b, t.Terulet());


            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}