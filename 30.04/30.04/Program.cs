using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            int min = 0;

            while (a != 0)
            {
                int a1 = a % 10;
                a = a / 10;
                if (min >  a1 || min==0)
                {
                    min = a1;
                }


            }
            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}
