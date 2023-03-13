using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p151_ex6
{
    class MainApp
    {
        static void Main(string[] args)
        {
            
            Console.Write("현재 본인의 학년을 숫자만 입력하세요. :");
            string input2 = Console.ReadLine();
            int gradenumber = Convert.ToInt32(input2);

            Console.Write("현재 본인의 점수를 입력해 주세요. :");
            string input1 = Console.ReadLine();
            int score = Convert.ToInt32(input1);



            if (score < 100)
            {
                

                if (gradenumber < 4)
                {
                    if (score >= 60)
                    {
                        Console.WriteLine($"입력하신 점수 {score} 는(은) 합격 입니다.");
                    }
                    else
                    {
                        Console.WriteLine($"입력하신 점수 {score} 는(은) 불합격 입니다.");
                    }


                }

                else
                {
                    if (score >= 70)
                    {
                        Console.WriteLine($"입력하신 점수 {score} 는(은) 합격 입니다.");
                    }
                    else
                    {
                        Console.WriteLine($"입력하신 점수 {score} 는(은) 불합격 입니다.");
                    }

                }


                // 돌아가서 다시 입력을 요구하는 소스코드를 작성 못하겠습니다.
                // 값을 다시 입력해 주세요.
            }
            else
            {
                Console.WriteLine("점수를 잘못 입력하셨습니다. 확인 후 다시 입력해 주세요.");
            }



        }
    }
}
