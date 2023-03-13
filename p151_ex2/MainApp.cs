using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p151_ex2
{
    class MainApp
    {
        static void Main(string[] args)
        {

            Console.Write("점수를 입력하세요. : ");

            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            string point;
            

            if (number >= 90)
            {
                point = "A";
                //Console.WriteLine($"입력하신 점수{number}는(은) A 학점 입니다.");

                

            }

            else if (number >= 80)
            {
                point = "B";
                //Console.WriteLine($"입력하신 점수{number}는(은) B 학점 입니다.");
            }

            else if ( number >= 70 )
            {
                point = "C";
                //Console.WriteLine($"입력하신 점수{number}는(은) C 학점 입니다.");

            }
            else
            {
                point = "F";
                //Console.WriteLine($"입력하신 점수{number}는(은) F 학점 입니다.");
            }




            Console.WriteLine($"입력하신 점수는{number}는(은) {point}  학점 입니다.");


        }
    }
}
