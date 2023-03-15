using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p161_ex3
{
    class MainApp
    {
        static void Main(string[] args)
        {

            Console.Write("몇월이 궁금하세요? : ");
            string input1 = Console.ReadLine();
            int number1 = Convert.ToInt32(input1);

            // DateTime nowyear = DateTime.Now;


            int lastday = DateTime.DaysInMonth(2023,number1);




            // 년도 까지 입력 받는 다면 2023 자리에 어떤것을 입력해야하는지 질문
            //  >>>> 년도 까지 변수로 받는다면 몇년도 몇월도 알아낼수 있다. 

            // 알고싶은 년도와 월을 입력 받았을때 그날의 마지막 일수 


            Console.WriteLine(lastday);

            switch (lastday)
            {
                case 28:                    
                case 30:                    
                case 31:
                    Console.WriteLine($"{number1}월은 {lastday}일까지 있습니다.");
                    break;
                

            }

            // case 1,3,5,7,8,10,12 는 31
            // case 4,6,9,11 은 30
            // case 2 는 28.

            // 예외 는 계산식에 조건을 달아야 할거 같다.
            // 이 방법 말고 다른 방법도 있을거 같다. .


        }
    }
}
