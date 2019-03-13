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
            //A létregozott új tipussal inicializálunk egy objektumot
            Excercise ex = new Excercise("Tresó Pál");

            //ex.Name = "Tresó Pál";

            //Public adattagot elérjük
            Console.WriteLine(ex.Name);

            //Tagfüggvény hivás
            ex.printName();
            
            //Ezt kellene megoldani
            Console.WriteLine(ex.getName());

            
            //Beolvas egy karakert a konzolról
            Console.ReadKey();

            
        }
    }
}
