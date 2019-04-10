using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IOne
    {
        void Method();
    }

    interface ITwo
    {
        void Method();
    }
    class Test : IOne, ITwo
    {
         void IOne.Method()
        {
            Console.WriteLine("Method1!");

        }
        void ITwo.Method()
        {
            Console.WriteLine("Method2!");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();

            ((IOne)t).Method();
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
