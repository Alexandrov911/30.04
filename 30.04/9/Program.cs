﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.49
            
            Console.WriteLine("введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            int n = 0;

            while (a != 0)
            {
                int a1 = a % 10;
                a = a / 10;
                if (a1 == 3)
                {
                    n = n + 1;
                }
                


            }
            if (n!=0)
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
