using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class arrays
    {
        static void Main(string[] args)
        {
            string[] cars = new string[] { "BMW", "Audi", "VW" };
            Console.WriteLine("First Car is : " + cars[0]);
            Console.WriteLine("First and Second Car is : " + cars[0] + " " + cars[1]);
            int[,] cordinates = new int[2,3] { { 1, 2, 3 }, { 9, 8, 7 } };
            Console.WriteLine("X1, Y1 : " + cordinates[0, 0]);
            Console.WriteLine("X2, Y3 : " + cordinates[1, 1]);
        }
    }
}
