using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionofsharp
{
    class Program
    {
        public static object Scanner { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello하고 한 줄을 띄운다.");
            Console.WriteLine("Hello하고 한 줄을 안 띄움.");


            Console.WriteLine();

            //변수
            int example = 100;
            //단 스트링 변수는 대소문자 구분없이 동일하게 쓸수 있음(보통은 소문자로_)
            
            //string 이런것도되요 = "신기하죠?";// 한글 변수도 됨
            //Console.WriteLine(이런것도됨);// 하지만 비추
            // 문자열로 숫자 혼합하기

            string ex3 = example + " 더하기" + example + "은" + (example + example) + "이다.";
            string ex4 = $"{ example} 더하기 { example}은{example + example }이다.";
            string ex5 = string.Format("{0}더하기 {1}은{2}이다.", example, example, example + example);

            Console.WriteLine(ex3);
            Console.WriteLine(ex4);
            Console.WriteLine(ex5);

            //조건문 ; 자바와 동일
            //if 탭탭
            if (example > 50)
            {
                Console.WriteLine("example은 50이상");

            }
            if (example > 30)
            {
                Console.WriteLine("30이상");
            }
            else {
                Console.WriteLine("30 미만");

            }
            if (example == 10)
            {
                Console.WriteLine("10");

            }
            else if (example == 20) {
                Console.WriteLine("20");
            }
            else
            {
                Console.WriteLine("10이랑 20은 아님");


            }
            switch (example)

            {
                case 10:
                    Console.WriteLine("10");
                    break;
                case 20:
                    Console.WriteLine("20");
                    break;

                default:
                    Console.WriteLine("10이랑 20은 아니다.");
                    break;
            }
            //반복문도 자바랑 동일
            // 단 foreach라는 특수문법 있음
            for (int i = 0; i < 10; i++)
            {
                //공백ㅇ,
                Console.WriteLine("같은 말 10번 반복");
            }
            int temp = 10;

            while (temp > 10)
            {
                temp--;
            }

            do
            {
                temp++;

            } while (temp < 10); {

            }

            string test = Console.ReadLine();
            int test2 = int.Parse(Console.ReadLine());

            //값을 입력 받은 경우
            // java
           

            //* Scanner s = new Scannner(System.in);
             //* String test = s.nextInt();

            //c#
            //String test = Console.ReadLine();
            // int test2 =int.Prase(Console.ReadLine());

            Console.WriteLine("몇층까지 출력해볼까?");
            int floor = int.Parse(Console.ReadLine());




            for (int i = 0; i < floor; i++)//전체 층을 출력
            {
                for (int j = floor; j > i; j--) //각층을 출력==> 54321
                {
                    Console.WriteLine(' ');

                }
                //별을 찍는 부분 // 각층을 출력
                for (int k = 0; k < (2*i)+1; k++)
                {
                    Console.WriteLine('*');
                }
                    Console.WriteLine();  //한줄 띄우고

            }

            Console.WriteLine("4번 문제");
            for (int i = 2; i < 10; i++)  //2단부터 9단
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i}x{j}={i*j}");
                }

            }
            Console.WriteLine("5번 문제");
            Console.WriteLine("월(1~12)을 입력:");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울입니다.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄입니다.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름입니다.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을입니다.");
                    break;

                default:
                    Console.WriteLine("잘못된 입력!");
                    break;
            }
            Console.WriteLine("6번 문제");

            Console.WriteLine("정수 x를 입력하세요.");
            int x = int.Parse(Console.ReadLine());
            // int x =sc.nextInt();
            Console.WriteLine("정수 y를 입력하세요.");
            int y = int.Parse(Console.ReadLine());

            if ((x > 0) && (y > 0))
            {
                Console.WriteLine("1사분면입니다.");
            }
            else if ((x < 0) && (y > 0))
            {
                Console.WriteLine("2사분면입니다.");
            }
            // if(x>0)
            //{ if(y>0) System.out.println(1);
            //else
            //System.out.println(4);}

            else if ((x < 0) && (y < 0))
            {
                Console.WriteLine("3사분면입니다.");

            }
            else if ((x > 0) && (y < 0)){
                Console.WriteLine("4사분면입니다.");

            }
            else
            {
                Console.WriteLine("0");
            }

            Console.WriteLine("7번문제");
            //앞에 행을숫자 갯수를 카운트 읽고 말하기 수열
            //1을 저장하는 변수와 갯수를 카운트 하는 변수, and 라는 누적 변수가 있음
            string start = "1";
            for (int i = 0; i < 20; i++)
            {
                int count = 0;//각 자리 숫자의 개수
                string end = "";// 문자열을 누적시키는 변수
                Console.WriteLine($"{i+1}번째 : {start}");
                char number = start[0];
                for (int j = 0; j < start.Length; j++) // 읽어들이기
                {
                    if (number!=start[j])   //배열
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
            Console.WriteLine("8번문제");

            int x, i = int.Parse(Console.ReadLine()); ;

            Console.WriteLine("숫자를 입력하세요:");
            while (true)
            {

            }
            int cr = x / (6 * i);

        }

        ///배수로 처리????
    }
            Console.WriteLine("지나가는 방의 개수는 : " + cr + "입니다.");






















        }
        }
}
