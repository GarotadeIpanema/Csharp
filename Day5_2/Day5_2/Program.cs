using System;

namespace Day5_2
{
    class Program
    {
        // 배열을 foreach를 사용하여 출력
        static void Main(string[] args)
        {
          string[] s = { "Jim", "Sam", " Kim", "Park"};
          foreach (string x in s)
            {
                Console.WriteLine(x);
            }
            //while문으로 1부터 100까지 함계 구하기
            int sum = 0;
            int i = 1;
            while(i<=100){
                sum += i;
                i++;
            }
            Console.WriteLine(sum);
            int j = 0;
            do
            {
                Console.WriteLine("Hello");
                j++;
            } while (j < 0);
            int a = 100;
            int b = 0;
            try
            {
                int c = a / b;
                Console.WriteLine(c);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " +ex.Message );
            }

        }
    }
}
