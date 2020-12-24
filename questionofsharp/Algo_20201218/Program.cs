using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_20201218
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("문제풀이 시작");
            Console.WriteLine("1번 문제");
            int sum, i= 0;
            //sum =sum + i;
            for (i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                    sum += i;
            }


                Console.WriteLine($"1부터 100까지의 수 중 3배수의 합은" + $"{sum}이다.");

                Console.WriteLine("2번 문제");

                int inputSecond = int.Parse(Console.ReadLine());

                Console.WriteLine($"{inputSecond / 60}분{inputSecond % 60}초");
                Console.WriteLine("3번 문제");
                Console.WriteLine(" 몇층까지 쌓아볼까?");
                int floor = int.Parse(Console.ReadLine());
                for (int i = 0; i < floor; i++)
                {   //공뱍을 찍는 부분
                    for (int j = floor; j > i; j--)  //각층을 출력(공백)
                    {
                        Console.WriteLine('-');
                    }
                    //별을 찍는 부분
                    Console.WriteLine();

                }

            Console.WriteLine("8번문제");
            int input = int.Parse(Console.ReadLine());
            int max = 1;//각 벌집의 최대값
            int counter = 0; //임의의 카운트 변수
            while (true)
            {
                max = max + (6 * counter);
                if (max < input)
                {
                    counter++;
                    continue;
                }
                else
                    Console.WriteLine($"{input}은 {counter + 1}번째 벌집에 속함");
                break;

            }




        }
        }
    }
}
