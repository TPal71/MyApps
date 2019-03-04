using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Fruit[] fruits = new Fruit[15];
            
            //Segédváltozók
            string nev;
            string szhely;
            int mennyiseg;
            int gyszam;

            //Bekérjük a gyümölcsök számát számát
            Console.Write("Kérem a gyümölcsök számát:");
             gyszam = int.Parse(Console.ReadLine());

            //Adatbekérés
            for (int i = 0; i < gyszam; i++)
            {
                //Adatbekérés 
                Console.Write("Kérem a(z) {0}. gyümölcs nevét: ", i + 1);
                nev = Console.ReadLine();
                Console.Write("Kérem a(z) {0}. gyümölcs szármezási helyét: ", i + 1);
                szhely = Console.ReadLine();
                Console.Write("Kérem a(z) {0}. gyümölcs mennyiség: ", i + 1);
                mennyiseg = int.Parse(Console.ReadLine());
                /*
                 * 
                 */
                //Tömbfeltöltés: Konstruktor hivása
                fruits[i] = new Fruit(nev,szhely,mennyiseg);
            }





            Console.ReadKey();

            
        }
    }
}
