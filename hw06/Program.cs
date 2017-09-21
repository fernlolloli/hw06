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
            Console.WriteLine("input human weight ");
            val = int.Parse(Console.ReadLine());
            check(ref val);
            Console.ReadLine();
        }
        static void check(ref int i)
        {
          
                Console.WriteLine("answer");
            Console.WriteLine("i/ 1.60");

        }
    }
    
}
