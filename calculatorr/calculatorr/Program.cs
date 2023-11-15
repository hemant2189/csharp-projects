using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorr
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //    }
    //}
    public class calculatorr
    {
        int num1;
        int num2;
        int result;

        void Add()
        {
            result= num1 + num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        void Subtract()
        {
            result = num1 - num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        void modulo()
        {
            result = num1 % num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static void Main(string[] args)
        {
            //Console.WriteLine("hemant");
            //Console.ReadLine();

            // add and subtract calcu
            calculatorr obj = new calculatorr();
            obj.num1 = 20;
            obj.num2 = 30;
            obj.Add();
            obj.Subtract();

            // modulo calculator
            calculatorr obj1 = new calculatorr();
            obj1.num1 = 20;
            obj1.num2 = 30;
            obj1.modulo();

        }

    }
}
