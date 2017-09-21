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
            int val;
            Console.WriteLine("in put a number you want to check evven of odd");
            val = int.Parse(Console.ReadLine());
            check(ref val);
            Console.WriteLine(val);
            Console.ReadLine();
        }
        static void check(ref int i)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("even");
            }
        }
    }
}
