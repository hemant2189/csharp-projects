using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBasedproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerhp = 40;
            int enemyhp = 20;

            int playerattack = 5;
            int enemyattack = 7;

            int healamount = 5;
            Random random = new Random();

            while(playerhp > 0)
            {

                //turn the player
                Console.WriteLine("-- turn the player --");
                Console.WriteLine("player hp - " + playerhp + ". enemy hp - " + enemyhp);
                Console.WriteLine("Enter 'a' to attack or 'h' to heal.");

                string choice = Console.ReadLine();

                if(choice == "a")
                {
                    enemyhp -= playerattack;
                    Console.WriteLine("player attack enemy and deals " + playerattack + "damage!");
                }
                else
                {
                    playerhp += healamount;
                    Console.WriteLine("player restores " + healamount + " health points!");

                   
                }

                //turn the enemy
                if(enemyhp > 0)
                {
                    Console.WriteLine(" -- turn the enemy --");
                    Console.WriteLine("player hp - " + playerhp + ". enemy hp - " + enemyhp);

                    int enemychoice = random.Next(0, 2);

                    if(enemychoice == 0)
                    {
                        playerhp -= enemyattack;
                        Console.WriteLine("enemy attacks and deals " + enemyattack + " damage!");
                    }
                    else
                    {
                        enemyhp += healamount;
                        Console.WriteLine("enemy restores " + healamount + " health points!");
                    }

                }

            }
            if (playerhp > 0)
            {
                Console.WriteLine("winer winer!");
            }
            else 
            {
                Console.WriteLine("you lose the game!");
                    }
        }
    }
}
