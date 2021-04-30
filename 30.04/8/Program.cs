using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            while (a!=0)
            {
                int a1 = a % 10;
                a = a / 10;
                s = s + a1;
            }
            if (s >=10)
            {
                Console.WriteLine("да");
            }
            else
            {
                Console.WriteLine("нет");
            }
            Console.ReadKey();

        }
    }
}
