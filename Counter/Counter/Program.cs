using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            string szoveg;
            int x=0,y=0;

            bool bDataOk = false;
            while (!bDataOk)
            {
                Console.Write("Kérem az x-et:");

                x = int.Parse(Console.ReadLine());

                if( x > 1 && x < 11)
                {
                    bDataOk = true;
                }
                else
                {
                    Console.WriteLine("Hibás x");
                }

            }
            bDataOk = false;
            while (!bDataOk)
            {
                Console.Write("Kérem az y-et:");

                y = int.Parse(Console.ReadLine());

                if (y > 1 && y < 11)
                {
                    bDataOk = true;
                }
                else
                {
                    Console.WriteLine("Hibás y");
                }

            }
            Console.Write("Kérem a szöveget:");
            szoveg = Console.ReadLine();
            Console.SetCursorPosition(x,y);
            Console.Write(szoveg);



            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
