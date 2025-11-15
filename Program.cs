using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();

            for(int i = 0; i < 10; i++) // i < 10 (10 defa kodu çalıştırcak)
            {
                Console.WriteLine("Press any key to roll to dice.");

                Console.ReadKey();
                playerRandomNum = random.Next(1, 7); //alt sınır 1 , üst sınır 7
                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy AI rooled a " + enemyRandomNum);

                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins this round");
                }
                else if (playerRandomNum < enemyRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this round");

                }
                else
                {
                    Console.WriteLine("Draw!");
                }

                Console.WriteLine("This score is now - Player : " + playerPoints + ". Enemy : " + enemyPoints + ".");
                Console.WriteLine();
            }

            if(playerPoints > enemyPoints)
            {
                Console.WriteLine("You win!");
            }
            else if(playerPoints < enemyPoints)
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }


                Console.ReadKey();
        }
    }
}
