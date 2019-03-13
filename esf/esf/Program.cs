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
            

            
            //Beolvas egy karakert a konzolról
            Console.ReadKey();

            
        }
    }
}
