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
            
            //Seg�dv�ltoz�k
            string nev;
            string szhely;
            int mennyiseg;
            int gyszam;

            //Bek�rj�k a gy�m�lcs�k sz�m�t sz�m�t
            Console.Write("K�rem a gy�m�lcs�k sz�m�t:");
             gyszam = int.Parse(Console.ReadLine());

            //Adatbek�r�s
            for (int i = 0; i < gyszam; i++)
            {
                //Adatbek�r�s 
                Console.Write("K�rem a(z) {0}. gy�m�lcs nev�t: ", i + 1);
                nev = Console.ReadLine();
                Console.Write("K�rem a(z) {0}. gy�m�lcs sz�rmez�si hely�t: ", i + 1);
                szhely = Console.ReadLine();
                Console.Write("K�rem a(z) {0}. gy�m�lcs mennyis�g: ", i + 1);
                mennyiseg = int.Parse(Console.ReadLine());
                /*
                 * 
                 */
                //T�mbfelt�lt�s: Konstruktor hiv�sa
                fruits[i] = new Fruit(nev,szhely,mennyiseg);
            }





            Console.ReadKey();

            
        }
    }
}
