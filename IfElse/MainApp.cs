using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class MainApp
    {
        static void Main(string[] args)
        {

            Console.Write("숫자를 입력하세요 :");

            string input = Console.ReadLine();
            int number = Int32.Parse(input);

            if (number < 0)
            {
                Console.WriteLine("음수");
            }

            else if (number > 0)
            {
                Console.WriteLine("양수");
                
            }

            else
            {
                Console.WriteLine("0");

            }


            if (number % 2 == 0)
            {
                Console.WriteLine("짝수");
            }

            else
            {
                Console.WriteLine("홀수");
            }

            string result = (number % 2) == 0 ? "1" : "2";
            Console.WriteLine(result);

            Console.WriteLine(number % 2 == 0 ? "1" : "2");

            // 조건 연산자 에 대한 설명 을 할줄 알아야 한다. 
            // .

        }
    }
}
