using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_gameProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerrandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++) 
            { 
                Console.WriteLine("Press any key to roll the dice.");

                Console.ReadKey();

                playerrandomNum = random.Next(1, 7);
                Console.WriteLine("you rolled a " + playerrandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy AI rolled a " + enemyRandomNum);

                if (playerrandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins this round!");
                }
                else if (playerrandomNum < enemyRandomNum) 
                {
                    enemyPoints++;
                    Console.WriteLine("enemy wins this round!");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }
                Console.WriteLine("The score is now - Player : " + playerPoints + ". Enemy :" + enemyPoints + ".");
                Console.WriteLine();
            }
            
            if (playerPoints > enemyPoints)
            {
                Console.WriteLine("You win!");
            }
            else if(playerPoints < enemyPoints)
            {
                Console.WriteLine("you lose!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
            Console.ReadKey();
        }
    }
}
