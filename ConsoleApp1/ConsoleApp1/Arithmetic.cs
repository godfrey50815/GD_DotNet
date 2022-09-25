using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Arithmetic
    {
        static void Main1(string[] args)
        {
            int a = 4;
            int b = 5;
            Console.WriteLine("Assigning Values: ");
            Console.WriteLine("\t a = " + (a + 5));
            Console.WriteLine("\t b = " + (b + 2));
            Console.WriteLine("Add and Assign: ");
            Console.WriteLine("\t a = " + (a += 3));
            Console.WriteLine("\t b = " + (b += 4));
            Console.WriteLine("Multiply and Assign: ");
            Console.WriteLine("\t a = " + (a *= 2));
            Console.WriteLine("\t b = " + (b *= 10));
            Console.WriteLine("Divide and Assign: ");
            Console.WriteLine("\t a = " + (a /= 2));
            Console.WriteLine("\t b = " + (b /= 2));
        }
    }
}
