using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpo
{
    class Program
    {
        static void Main(string[] args)
        {
            ///
            ///Program: Kő papir olló játék leprogramozása
            ///Irta: Tresó Pál / 2019.03.06
            ///Adott: számítógép - véletlenszerűen választ k/p/o
            ///Játékos: billentyűzeten választ


            ///Megoldandó feladat 1:
            ///Ciklikus programfutás, amig a felhasználó szeretne játszani
            bool moreGame = true;
            
            ///Feladat 2: Változók létrehozása
            ///
            string compChoice = "";
            string playerChoice = "";

            int compScore = 0;
            int playerScore = 0;

            Console.WriteLine("*******Kő/Papir/Olló játék*********");

            do
            {

                Console.Write("Akarsz még játszani? i/n");
                if (Console.ReadKey(true).KeyChar == 'n')
                {
                    moreGame = false;
                }

            } while (moreGame);

           



            
        }
    }
}
