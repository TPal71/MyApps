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

            Random r = new Random();
            string compChoice = "";
            string playerChoice = "";

            int compScore = 0;
            int playerScore = 0;

            bool l = true;

            do
            {


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

                Console.WriteLine("Akarsz még játszani? i/n");
                if (Console.ReadKey(true).KeyChar == 'n')
                {
                    l = false;
                }
            } while (l);



            Console.ReadKey();


        }
    }
}
