using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //역슬러쉬 n이랑 동일=Environment.NewLine
            Console.WriteLine("WriteWriteLine" + Environment.NewLine);
            Console.WriteLine("WriteLine");
            Console.WriteLine("WriteLine");
            Console.WriteLine("WriteWrite");
            //인치를 입력받아 cm단위로 출력되는 코드 
            Console.WriteLine("\"Write\"");
            Console.WriteLine("1번 :인치를 입력하세요");
            double inch = double.Parse(Console.ReadLine());
            //세가지 방법으로 출력 가능
            Console.WriteLine(inch * 2.54 + "cm");
            Console.WriteLine(string.Format("{0}cm", inch * 2.54));
            Console.WriteLine($"{inch * 2.54}cm");

            //킬로그램 단위 입력받아 파운드 단위로 출력
            Console.WriteLine("2번: 킬로그램을 입력하세요");
            int kg = int.Parse(Console.ReadLine());
            Console.WriteLine(kg * 2.20462262 + "pound");
            Console.WriteLine("3번: 반지름을 입력하세요");
            int r = int.Parse(Console.ReadLine());
            //자바 파이널= 씨샵 const= 상수
            const double pi = 3.141592;
            Console.WriteLine("원의 둘레는 "+(pi*2*r)+"입니다.");
            Console.WriteLine("원의 넓이는 " +(pi*r*r)+"입니다.");

            //세자리를 입력받는다 가정
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            //2번째 방법
            string sTwo = two.ToString();
            //첫번째 숫자 곱하기 두번째 숫자의 1의 자리
            Console.WriteLine(one*int.Parse(sTwo[2].ToString()));
            Console.WriteLine(one* (sTwo[1]-'0'));
            Console.WriteLine(one * (sTwo[0] - '0'));


            //왜 안됨??? 아스키코드로 변환되기때문에 안됨!!!
            Console.WriteLine(one*sTwo[2]);
            Console.WriteLine(one*sTwo[1]);
            Console.WriteLine(one * sTwo[0]);


            Console.WriteLine(one * (two%10)); //3번째 줄
            Console.WriteLine(one * (two%100)/10); //4번째 줄
            Console.WriteLine(one * (two /100)); //5번째 줄
            Console.WriteLine(one*two); //6번째 줄
            Console.WriteLine();
            Console.WriteLine("4번: 첫번째 숫자를 입력하세요");
            string a1 = Console.ReadLine(); // 1번째 

            Console.WriteLine("두번째 숫자를 입력하세요");
            string a2 = Console.ReadLine(); // 2번째 줄

            char[] a3 = a2.ToCharArray();

            int num1 = int.Parse(a1);
            int[] num2 = new int[a3.Length];

            for (int i = 0; i < a3.Length; i++)
            {
                num2[i] = int.Parse(a3[i].ToString());
            }

            Console.WriteLine(num1 * num2[2]); //3번째 줄
            Console.WriteLine(num1 * num2[1]); //4번째 줄
            Console.WriteLine(num1 * num2[0]); //5번째 줄
            Console.WriteLine(num1 * num2[2]
                              + num1 * num2[1] * 10
                              + num1 * num2[0] * 100); //6번째 줄



           
           






        }
    }
}
