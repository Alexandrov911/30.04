using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
           //6.33 a
            for (int i = 13; i < 100; i=i+13)
            {
                Console.WriteLine(i);

            }



            //6.33 b
            int a = 13;
            while (a < 100)
            {

                Console.WriteLine(a);
                a = a + 13;
            }




            Console.ReadKey();

        }

       

    }
}
