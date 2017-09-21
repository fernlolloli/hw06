using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw06
{
    class Program
    {
        static void Main()
        {
            check();
            Console.WriteLine();
                  Console.WriteLine();
         }

        static void check()
        {
            Console.WriteLine("input \"a\" base:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("input \"b\" base:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("input \"h\" base:");
            double h = double.Parse(Console.ReadLine());
            double area = ((a + b) / 2) * h;
            Console.WriteLine("The area of your trapezoid is: {0}", area);

        }
    }
}

