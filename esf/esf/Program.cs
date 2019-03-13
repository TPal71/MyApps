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

            Console.WriteLine(ex.Name);

            
            //Beolvas egy karakert a konzolról
            Console.ReadKey();

            
        }
    }
}
