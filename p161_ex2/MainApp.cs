using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p161_ex2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수 2개와 연산기호를 입력해주세요! ");
            Console.Write("첫 번째 정수를 입력해주세요 : ");
            string input1 = Console.ReadLine();
            int number1 = Convert.ToInt32(input1);
            
            Console.Write("두 번째 정수를 입력해주세요 : ");
            string input2 = Console.ReadLine();
            int number2 = Convert.ToInt32(input2);

            Console.Write("연산기호를 입력해주세요.  ex)+,-,*,/,% : ");
            string input3 = Console.ReadLine();

            int value = 0;


            switch (input3)
            {
                case "+":
                    value = number1 + number2;
                    break;
                case "-":
                    value = number1 - number2;
                    break;
                case "*":
                    value = number1 * number2;
                    break;
                case "/":
                    value = number1 / number2;
                    break;
                case "%":
                    value = number1 % number2;
                    break;
                default:
                    Console.WriteLine("연산기호가 아닌 값을 입력했습니다. 다시 입력해주세요");
                    return;

                    // 연산기호 말고 숫자도 잘못입력 했을 때
                    // 오류 표현을 해주고 다시 입력하라고 해야한다.
                    // 그것 까지 생각해서 소스코드 짜보기 .



            }
            Console.WriteLine($"입력하신 {number1}{input3}{number2}의 값은 {value}입니다.");


        }
    }
}
