using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 114;
            int n = 1;
            while (n<15)
            {
                Console.WriteLine(a);
                a = a + 19;
                n = n + 1;
            }
            Console.WriteLine(n);
            Console.ReadKey();

        }
    }
}
