using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab0520
{
    class Program
    {
        static void Main(string[] args)
        {

            //Hozzunk létre egy 15 elemű int tömböt, aminek a neve iArray
            int[] iArray = new int[15];
            //Hozzunk létre 5 elemű szöveg tárolására alkalmas tömböt
            string[] sArray = new string[5];
            //Hozzunk létre egy int tömböt, amit feltöltünk 3 db elemmel(5,8,9)
            int[] iT = new int[] { 5, 8, 9 };
            //Hozzunk létre 2 dimenziós tömbot egész számoknak ((4,5)(2,3)(6,8))
            int[][] iT2 = new int[][]
            {
                new int[] { 4,5},
                 new int[] { 2,3},
                  new int[] { 6,8}


            };
            int[,] iT3 = new int[,] { {4,5 },{2,3 },{6,8 } };
            try
            {
                Console.WriteLine(iT3[2, 1]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

            } 
            
            //Három dim tömb
            int[,,] iT4 = new int[,,] 
            { 
                {{ 1, 2, 3 }, { 4, 5, 6 } }, 
                {{ 7, 8, 9 }, { 10, 11, 12 }}


            };
            try
            {
                Console.WriteLine(iT4[1, 1, 0]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            //Hárommal osztható számok kiirása 50-ig
            for (int i = 0; i < 50; i++)
            {
                
            }

            //Feladat 50 ig a primszámok keresése
            Console.WriteLine("Primszámok:");
            FindPrimes(0, 50);

            Console.ReadKey();

           
        }
        private static bool IsPrime(int number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
                if (number % i == 0) return false;
            return true;
        }

        private static void FindPrimes(int min, int max)
        {
            for (int i = min; i < max; i++)
            {
                if (IsPrime(i)) Console.WriteLine(i);
            }
        }
    }
}
