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

            //Fruit[] fruits = new Fruit[15];

            var fruits = new List<Fruit>();        
            
            //Segédváltozók
            string nev;
            string szhely;
            int mennyiseg;
            int gyszam;
            int osszmenny = 0;

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

                osszmenny += mennyiseg;
                /*
                 * 
                 */
                //Tömbfeltöltés: Konstruktor hivása
                //fruits[i] = new Fruit(nev,szhely,mennyiseg);
                fruits.Add(new Fruit(nev, szhely, mennyiseg));
            }
            Console.WriteLine("Gyümölcsök összes mennyisége: " + osszmenny);
            Console.ReadKey();
           
        }
    }
}
