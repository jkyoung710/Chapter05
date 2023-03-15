using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p161_ex4
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("알고싶은 월을 입력해주세요. : ");
            string input1 = Console.ReadLine();
            int number1 = Convert.ToInt32(input1);

            switch (number1)
            {
                case 12:
                case 2:
                case 1:
                    Console.WriteLine($"입력하신{number1}월은 겨울 입니다.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine($"입력하신{number1}월은 봄 입니다.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine($"입력하신{number1}월은 여름 입니다.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine($"입력하신{number1}월은 가을 입니다.");
                    break;
                default:
                    Console.WriteLine("정상적인 입력값이 아닙니다. 확인후 다시 실행해 주세요");
                    return;


            }






            /*
            switch (season)
            {
                case "spring":
                    Console.WriteLine($"입력하신 {number1}월은 봄 입니다.");
                    break;
            }
            */
        }
    }
}
