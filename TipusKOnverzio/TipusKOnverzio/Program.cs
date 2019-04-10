using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipusKOnverzio
{
    class Program
    {
        static void Main(string[] args)
        {
            object a = "123";
            object b = "Hello";
            object c = 10;
            string aa = a as string;
            // expr1 ? v1 : v2;
            Console.WriteLine(aa == null ? "NULL" : aa); // 123
            string bb = b as string;
            Console.WriteLine(bb == null ? "NULL" : bb); // Hello
            string cc = c as string;
            Console.WriteLine(cc == null ? "NULL" : cc); // NULL
            // expr1 ? v1 : v2;
            int x = 5;
            Console.WriteLine(x == 5 ? "x==5":"x != 5");

            //Karakterkonverziók (int) : cast
            for (char ch = 'a'; ch <= 'z'; ch++)
            {

                Console.Write(ch + "->" + (int)ch + " ");
            }
            Console.WriteLine();
            //Tömbök
            int[] iTomb = new int[2];
            Random r = new Random();
            int iPrev = 0;
            for (int i = 0; i < iTomb.Length; i++)
            {
                //iTomb[i] = r.Next();
                //Konzolról kérje be a számot
                Console.Write("Kérem az {0}. számot: ", i);
                // Console.Write("Kérem az " + i + ". számot");
                //A kivétel keletkezésének helye (Exception)
                try
                {
                    iTomb[i] = int.Parse(Console.ReadLine());
                    iPrev = i;
                }
                catch(Exception e)
                {
                    Console.WriteLine("Hiba." + e.Message);
                    i = iPrev;
                }
            }
            Console.WriteLine();
            //Kiiratni az iTomb elemeit
            for (int i = 0; i < iTomb.Length; i++)
            {
                Console.Write(iTomb[i] + " ");
            }

            //Tömb kezdeti értékeinek megadása int[], string[]
            int[] iArr = new int[] { 5, 2, 1, 4 };
            String[] sArr = new String[] {"banán", "mangó", "alma", "korte"};

            //Tömb sorbarendezése
            Array.Sort(sArr);
            Array.Sort(iArr);
            //Kiiratni az sArr elemeit
            for (int i = 0; i < sArr.Length; i++)
            {
                Console.Write(sArr[i] + " ");
            }
            //Kiiratni az sArr elemeit
            for (int i = 0; i < iArr.Length; i++)
            {
                Console.Write(iArr[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
