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


            Negyzet n = new Negyzet(10);

            Console.WriteLine(n.Terulet());

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
