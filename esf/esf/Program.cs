using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esf
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = 0;

            //A létregozott új tipussal inicializálunk egy objektumot
            Excercise ex = new Excercise("Tresó Pál");

            //ex.Name = "Tresó Pál";

            //Public adattagot elérjük
            Console.WriteLine(ex.Name);

            //Tagfüggvény hivás
            ex.printName();
            
            //Ezt kellene megoldani
            Console.WriteLine(ex.getName());

            ///Ciklusok
            //For ciklus
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Ciklus:<Változó hivatkozás I.>" + i);
                Console.WriteLine("Ciklus:<Változó hivatkozás II.> {0}", i);
            }

            //While ciklus, előltesztelős ciklus
            v = 2;
            while (v>0)
            {
                Console.WriteLine("While ciklus");
                v--;
            }

            //Do-While: Hátultesztelős ciklus
            v = 2;
            do
            {
                Console.WriteLine("Do While ciklus");
                v--;
            } while (v>0);

            //Elágazások: IF
            v = 2;
            if (v == 2)
            {
                Console.WriteLine("A v értéke egyenlő 2vel");

            }
            else if (v == 3)
            {
                Console.WriteLine("A v értéke egyenlő 3val");
            }
            else
            {
                Console.WriteLine("V nem 2 és nem 3, hanem:" + v);
                 
            }
            //Elágazások: switch
            v = 6;
            switch (v)
            {
                case 0:
                    Console.WriteLine("Switch:" + v);
                    break;
                case 5:
                    Console.WriteLine("Switch:" + v);
                    break;
                default:
                    Console.WriteLine("Switch default:" + v);
                    break;
            }


            //Beolvas egy karakert a konzolról
            Console.ReadKey();

            
        }
    }
}
