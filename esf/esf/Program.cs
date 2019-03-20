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
            string s;


            
            

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

            //Beolvasás konzolról
            s = Console.ReadLine();
            Console.WriteLine("Beolvasás konzolról:" + s);

            //Egy billentyű leütése
            // Console.ReadKey(true).KeyChar
            // integerré konvertálni a console számot(string)
            //int.Parse(Console.ReadLine())


            ///Tömbök
            ///Létrehoztunk egy int elemeket tartalmazó tömböt, aminek a neve
            ///'szamok'
            int[] szamok = new int[5];
            string[] szovegek = new string[10];

            //Tömb inicializálás
            int[] iNums = new int[] { 1,2,3,4,5,6};
            string[] sFruit = new string[] {"alma","körte","banán","narancs" };
            Console.WriteLine("iNums első eleme: {0} sFruit első eleme:{1}", iNums[0],sFruit[0]);
            Console.WriteLine("iNums első eleme:" + iNums[0] + " sFruit első eleme:" + sFruit[0]);




            ///Tipusos listák: List<T>
            //Lista elem 
            var Lista = new List<Book>();


            //Új elemek hozzáadása a listához
            //Ctrl-'.' hivhatjuk segítségül
            Lista.Add(new Book() { Name = "Oroszlánkölykök", Author = "Irwin Shaw",Page=100 });
            Lista.Add(new Book() { Name = "Megkergetve", Author = "Margó István" ,Page=200});
            Lista.Add(new Book() { Name = "Egri csillagok", Author = "Gárdonyi Géza", Page = 1200 });

            
            //Lista kiiratása
            foreach (Book book in Lista)
            {
                Console.WriteLine(book.Name + " " +book.Author + " " + book.Page );
            }

            //Lista egy elemének törlése
            Lista.Remove(new Book() { Name = "Megkergetve", Author = "Margó István", Page = 200 });


            Console.WriteLine("***************************************************************************");
            //Lista kiiratása
            foreach (Book book in Lista)
            {
                Console.WriteLine(book.Name + " " + book.Author + " " + book.Page);
            }
            Lista.Remove(Lista.Find(x => x.Name.Contains("Oroszlánkölykök")));
            //Lista.Find(x => x.Name.Contains("Oroszlánkölykök"))
            //Console.WriteLine("Keressük az Oroszlánkölykök könyvet:" + Lista.Find(x => x.Name.Contains("Oroszlánkölykök")).Name);

            Console.WriteLine("***************************************************************************");

            //Lista kiiratása
            foreach (Book book in Lista)
            {
                Console.WriteLine(book.Name + " " + book.Author + " " + book.Page);
            }
            /*Oldalszám keresés
            Console.WriteLine("Tartalmaz(): {0}",
            Lista.Contains(new Book { Name="",Author="", Page=100}));
            */

            //Keresés cim alapján

            // Console.WriteLine("\nFind: Könyv cime tartalmaz \"Oroszlánkölykök\": {0}",
            //     Lista.Find(x => x.Name.Contains("Oroszlánkölykök")).Name);

            //Beolvas egy karakert a konzolról
            Console.ReadKey();

            
        }
    }
}
