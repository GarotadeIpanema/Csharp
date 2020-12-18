using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("7번문제");
            //앞에 행을숫자 갯수를 카운트 읽고 말하기 수열
            //1을 저장하는 변수와 갯수를 카운트 하는 변수, and 라는 누적 변수가 있음
            string start = "1";
            for (int i = 0; i < 20; i++)
            {
                int count = 0;//각 자리 숫자의 개수
                string end = "";// 문자열을 누적시키는 변수
                Console.WriteLine($"{i + 1}번째 : {start}");
                char number = start[0];
                for (int j = 0; j < start.Length; j++) // 읽어들이기
                {
                    if (number != start[j])   //배열
                    {
                        end = end + number + count; //end =""+'1'+1
                        number = start[j];//가리키는 숫자 다른 걸로 바꿈
                        count = 1;//cnt 1로 초기화. 왜냐면 다른 숫자가 있어서 이 조건문으로 들어왔기 때문
                    }
                    else
                    {
                        count++;
                    }
                }
                end = end + number + count;
                start = end;
            }/// 1 들어가고/cnt=0/number='1'/
        }
    }
}
