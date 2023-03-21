using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMPLE1
{
    class MainApp
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }

            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b <= a; b++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }





        }
    }
}
