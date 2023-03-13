using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p151_ex5
{
    class MainApp
    {
        static void Main(string[] args)
        {

            Console.Write("세개의 정수 중 첫번째 정수를 입력해 주세요 : ");
            string input1 = Console.ReadLine();
            int number1 = Convert.ToInt32(input1);

            Console.Write("세개의 정수 중 두번째 정수를 입력해 주세요 : ");
            string input2 = Console.ReadLine();
            int number2 = Convert.ToInt32(input2);

            Console.Write("세개의 정수 중 세번째 정수를 입력해 주세요 : ");
            string input3 = Console.ReadLine();
            int number3 = Convert.ToInt32(input3);

            int result1 = (number1 > number2)  ? number1 : number2;
            int result2 = (result1 > number3) ? result1 : number3;

            int result3 = (number1 > number2) ? number2 : number1;
            int result4 = (result3 > number3) ? number3 : result3;

            int result5 = number1 + number2 + number3;
            int result6 = result5 / 3;





            Console.WriteLine($"입력하신{number1},{number2},{number3} 중 최대값은 {result2} 이며," +
                $"최소값은 {result4} 입니다.");

            Console.WriteLine($"입력하신{number1},{number2},{number3} 의 합은 {result5}이며," +
                $"평균은 {result6} 입니다.");


        }
    }
}
