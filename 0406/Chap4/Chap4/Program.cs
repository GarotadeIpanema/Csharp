using System;

namespace Chap4
{
    class Program
    {
        static void Main(string[] args)
        {
            //프로젝트이름= 프로그램 이름
            //scproj= 프로젝트 실행파일, 이것만 있어도 실행됨
            // 알람시계 문제: 45분 전에 알람이 미리 울리도록
           
            Console.WriteLine("1번 문제: 년도를 입력해주세요!");

            int year = int.Parse(Console.ReadLine());
            int y=year% 12 ;
            switch (y)
            {
                case 0:
                    Console.WriteLine("원숭이띠입니다!");
                    break;
                case 1:
                    Console.WriteLine("닭띠입니다!");
                    break;
                case 2:
                    Console.WriteLine("개띠입니다!");
                    break;
                case 3:
                    Console.WriteLine("돼지띠입니다!");
                    break;
                case 4:
                    Console.WriteLine("쥐띠입니다!");
                    break;
                case 5:
                    Console.WriteLine("소띠입니다!");
                    break;
                case 6:
                    Console.WriteLine("호랑이띠입니다!");
                    break;
                case 7:
                    Console.WriteLine("토끼띠입니다!");
                    break;
                case 8:
                    Console.WriteLine("용띠입니다!");
                    break;
                case 9:
                    Console.WriteLine("뱀띠입니다!");
                    break;
                case 10:
                    Console.WriteLine("말띠입니다!");
                    break;
                case 11:
                    Console.WriteLine("양띠입니다!");
                    break;
                
            }

   

            Console.WriteLine("2번문제: 월을 입력해주세요!");

            int month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울이라네");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄이라네");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름이라네");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을이라네");
                    break;

                default:
                    Console.WriteLine("올바르게 입력하라네");
                    break;
            }
            //자정 정오
            Console.WriteLine("3번문제: 시와 분을 입력하세요!" );
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());


            if (m < 45)
            {
                h -= 1;
                m += 60;
                m -= 45;
               
                if(h<0)
                {
                    h +=24;
                }
                
            }
            else
            {
                m -= 45;
            }
            Console.WriteLine(h+"시"+m+"분에 알람이 울립니다!");
            Console.WriteLine($"내가 맞춘 시간: {h}시 {m}분");
            //동전 문제: n개의 동전을 활용해서 k를 합으로 만듦, 동전의 최솟값을 구하는 문제
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int cnt = 0;
            int[] arr = new int[n];
            //배열에 동전을 넣고
            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            //
            for(int i = n - 1; i >= 0; i++)
            {
                if (k >= arr[i])
                {
                    cnt += k / arr[i];
                    k %= arr[i];
                }
                Console.WriteLine(cnt);
            }




            
		}



	}
}

