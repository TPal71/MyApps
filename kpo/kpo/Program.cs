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

            Random r = new Random();

            ///Feladat 2: Változók létrehozása

            string compChoice = "";
            string playerChoice = "";

            int compScore = 0;
            int playerScore = 0;


            Console.WriteLine("*******Kő/Papir/Olló játék*********");

            do
            {
                ///Feladat 3:
                ///Player választásának megkérdezése és tárolása
                ///
                Console.WriteLine("Mit választasz? k/p/o");

                switch (Console.ReadKey(true).KeyChar)
                {
                    case 'k':
                        playerChoice = "kő";
                        break;
                    case 'p':
                        playerChoice = "papir";
                        break;
                    case 'o':
                        playerChoice = "olló";
                        break;
                }
                ///Feladat 4:
                ///Számítógép választásának kérdése: Random()
                ///
                switch (r.Next(0, 3))
                {
                    case 0:
                        compChoice = "kő";
                        break;
                    case 1:
                        compChoice = "papir";
                        break;
                    case 2:
                        compChoice = "olló";
                        break;
                }
                ///Feladat 5: Értékeljük ki a compChoice és a playerChoice 
                ///változókat
                ///
                if (
                   (playerChoice == "kő" && compChoice == "papir") ||
                   (playerChoice == "papir" && compChoice == "olló") ||
                   (playerChoice == "olló" && compChoice == "kő")
                   )
                {
                    Console.WriteLine("Számítógép: " + compChoice + " Te: " + playerChoice);
                    Console.WriteLine("Veszitettél! Állás: Szg: {0} Játékos: {1}", ++compScore, playerScore);

                }
                else if (playerChoice == compChoice)
                {
                    Console.WriteLine("Számítógép: " + compChoice + " Te: " + playerChoice);
                    Console.WriteLine("Döntetlen! Állás: Szg: {0} Játékos: {1}", compScore, playerScore);
                }
                else
                {
                    Console.WriteLine("Számítógép: " + compChoice + " Te: " + playerChoice);
                    Console.WriteLine("Nyertél! Állás: Szg: {0} Játékos: {1}", compScore, ++playerScore);

                }




                Console.Write("Akarsz még játszani? i/n");
                if (Console.ReadKey(true).KeyChar == 'n')
                {
                    moreGame = false;
                }

            } while (moreGame);

         



            
        }
    }
}
