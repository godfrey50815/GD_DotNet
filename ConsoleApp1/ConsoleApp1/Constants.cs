using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Constants
    {
        enum Days { Sat, Sun, Mon, Tue, Wed, Thu, Fri };
        static void Main(string[] args)
        {
            const double pi = 3.121321312323;
            var dataType = typeof(Days);
            Console.WriteLine("Pi Type : " + pi.GetType());
            Console.WriteLine("Circumference: " + (pi * 3));
            Console.WriteLine("First day is " + Days.Sat);
        }
    }
}

