using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numberguesspro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectGuess = false;
            Random random = new Random();


            int randomNum = random.Next(1, 11);
            
            
            //printing text
            Console.WriteLine("welcome to the number gussing game!");
            Console.WriteLine("A number between 1 and 10 will be generated.");
            Console.WriteLine("If you guess the correct number, you win!");


            //Console.WriteLine(randomNum);


            while (!isCorrectGuess) 
            {
                Console.WriteLine("Please enter the guess number.");
                int guess = Convert.ToInt32(Console.ReadLine());

                 
                if (guess > randomNum)
                {
                    Console.WriteLine("your guess is to high.");
                }
                else if (guess < randomNum)
                {
                    Console.WriteLine("your guess is to low.");
                }
                else
                {
                    Console.WriteLine("correct!");
                    isCorrectGuess = true;
                }
            }

            Console.WriteLine("Big congratulations, you can win this game!");
            Console.WriteLine("Thank you for playing this game!");
            Console.ReadKey();
        }
    }
}
