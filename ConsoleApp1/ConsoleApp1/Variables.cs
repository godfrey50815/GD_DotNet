using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main1(string[] args)
        {
            char letter = 'a';
            int num = 12;
            float temprature = 123.45f;
            double pi = 3.14159;
            decimal sum = 1000.00m;
            bool flag = false;
            string text = "Hello there!!";
            Console.WriteLine("character letter is:\t" + letter);
            Console.WriteLine("Integer is:\t" + num);
            Console.WriteLine("float is:\t" + temprature);
            Console.WriteLine("double pi:\t" + pi);
            Console.WriteLine("decimal sum is:\t" + sum);
            Console.WriteLine("boolean flag is:\t" + flag);
            Console.WriteLine("string text is:\t" + text);
            Console.ReadKey();

        }
    }
}
