using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.49 b
            Console.WriteLine("введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            int n = 0;

            while (a != 0)
            {
                int a1 = a % 10;
                a = a / 10;
                if (a1 == 2 ||a1==5)
                {
                    n = n + 1;
                }



            }
            if (n != 0)
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
