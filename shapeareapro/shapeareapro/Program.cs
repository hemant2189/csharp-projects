using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeareapro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            float result;

            Console.WriteLine("What shape would you lije to find the area of? Please enter 'r' for rectange or any other key for the circle!.");

            answer = Console.ReadLine();

            if(answer == "r")
            {
                Console.WriteLine("please enter the height of the rectangle.");
                float height = float.Parse(Console.ReadLine());

                Console.WriteLine("please enter the width of the rectangle");
                float width = float.Parse(Console.ReadLine());

                result = height * width;

            }
            else
            {
                Console.WriteLine("Please enter the radius of the circle!");
                float radius = float.Parse(Console.ReadLine());

                result = (float)Math.PI * (radius * radius);
            }

            Console.WriteLine("The result is: " + result);
            Console.ReadKey();
        }
    }
}
