using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        static void Main(string[] args)
        {
            //Convert.ToInt32();
            //Convert.ToDouble();
            //Convert.ToString();
            Console.Write("Please enter a number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double sum = num + num1;
            Console.WriteLine("Total = " + sum);
            Console.ReadKey();
        }
    }
}
