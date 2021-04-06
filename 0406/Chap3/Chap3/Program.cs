using System;

namespace Chap3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (false)
            {
                string name = Console.ReadLine();
                if (name == "휘인")
                {
                    Console.WriteLine("마마무 무무");
                }
                else
                {
                    Console.WriteLine("9-1=0. 지금은 소녀시대, 앞으로도 소녀시대, 영원히 소녀시대!");
                }
                int a = 100;
                if (a > 50)
                {
                    Console.WriteLine("크당!");
                    a = -100;

                }
                else
                {
                    Console.WriteLine("작넹");
                }
                //   콘솔 리드라인만 하면 문자열을 입력받는것

                int n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    Console.WriteLine("짝수입니다!");
                }
                else
                {
                    Console.WriteLine("홀수입니다!");
                }
                if (a > 0)
                {
                    Console.WriteLine("a의 값이 양수");
                    if (a > -50)
                    {
                        Console.WriteLine("a의 값이 50초과");
                    }
                    else
                    {
                        Console.WriteLine("a의 값이 50미만");
                    }
                }
                else
                {
                    Console.WriteLine("a의 값이 음수");
                    if (a < -50)
                    {
                        Console.WriteLine("a의 값이 -50초과");
                    }
                    else
                    {
                        Console.WriteLine("a의 값이 -50미만");
                    }
                }
                int b = 100;
                if (b < 50)
                {
                    Console.WriteLine("b 50보다 작다");
                }
                else if (b < 70)
                {
                    Console.WriteLine("b 70보다 작다.");

                }
                else if (b < 90)
                {
                    Console.WriteLine("b는 90보다 작다");
                }
                else
                {
                    Console.WriteLine("b의 값은 " + b + " 입니다");
                }


                int year = int.Parse(Console.ReadLine());
                int y = year % 12;
                switch (y)
                {
                    case 0:
                        Console.WriteLine("원숭이띠 입니다");
                    case 1:
                        Console.WriteLine("닭띠 입니다");
                        break;
                    case 2:
                        Console.WriteLine("개띠입니다");
                        break;
                    case 3:
                        Console.WriteLine("돼지띠입니다");
                        break;
                    case 4:
                        Console.WriteLine("쥐띠입니다");
                        break;
                    case 5:
                        Console.WriteLine("소띠입니다.");
                        break;
                    case 6:
                        Console.WriteLine("호랑이띠입니다.");
                        break;
                    case 7:
                        Console.WriteLine("토끼띠입니다.");
                        break;
                    case 8:
                        Console.WriteLine("용띠입니다.");
                        break;
                    case 9:
                        Console.WriteLine("뱀띠입니다.");
                        break;
                    case 10:
                        Console.WriteLine("말띠입니다.");
                        break;
                    case 11:
                        Console.WriteLine("양띠입니다.");
                        break;

                }
                int month = int.Parse(Console.ReadLine());

                switch (month)
                {
                    case 12:
                    case 1:
                    case 2:
                        Console.WriteLine("겨울입니다");
                        break;
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("봄입니다");
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("여름입니다");
                        break;
                    case 9:
                    case 10:
                    case 11:
                        Console.WriteLine("가을입니다");
                        break;
                    default:
                        Console.WriteLine("달을 다시 입력하세요");

                        //if (dice == 1)
                        //{
                        //    Console.WriteLine("dice:1");
                        //}
                        //else if (dice == 2)
                        //{
                        //    Console.WriteLine("dice:2");
                        //}
                        //else if (dice == 4 || dice == 5 || dice == 6)
                        //{
                        //    Console.WriteLine("dice:3,4,5,6");
                        //}
                }
                int keycm = 163;
                if (keycm >= 160)
                {
                    if (keycm < 170)
                    {
                        Console.WriteLine("애매하다?");
                    }
                }
                //논리곱
                if (keycm >= 160 && keycm < 170)
                    Console.WriteLine("애매하다고 한다");

                //논리합
                if (keycm < 100 || keycm > 200)
                    Console.WriteLine("너무 작거나 크다");
                if (keycm >= 100 ^ keycm >= 200)
                    Console.WriteLine("100");
                //값이 짝수이면 -1출력
                int c = keycm % 2 == 0 ? -1 : 0;
                //String에 특정한 문장/ 글자가 있을때
                string ds = "디오니소스";
                if (ds.Contains("디"))
                {
                    Console.WriteLine("포도포도");
                }
                if (ds.Contains("소스"))
                {
                    Console.WriteLine("와인와인");
                }

                for (int i = 0; i < 10; i++)//라인
                {

                    for (int j = 9-i; j > 0 ; j--)//공백은 갈수록 줄어들어야함
                    {
                        Console.Write(' ');
                    }
                    for (int k = 0; k < (2*i)+1; k++)//별
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();

                }


                //반쪽 피라미드
                //for (int i = 0; i < 10; i++)
                //{
                //    for (int j = 0; j < i + 1; j++)
                //    {
                //        Console.Write('*');
                //    }
                //    Console.Write('\n');
                //    }
                //}
                ////반쪽 거꾸로 피라미드

                //for(int i = 0; i < 10; i++)
                //{
                //    for(int j = 0; j < 10-i; j++)
                //    {
                //        Console.Write(' ');
                //    }
                //    for(int j=0;j<i+1;j++){
                //        Console.Write('*');
                //    }
                //    Console.Write('\n');
                //    }


            }
        }

    }

}




