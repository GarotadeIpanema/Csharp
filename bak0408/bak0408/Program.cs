using System;

namespace bak0408
{
    class Program
    {
        static void Main(string[] args)
        {


            //{   //피라미드
            //    for (int i = 0; i < 10; i++)
            //    {
            //        for (int j = 10; j > i; j--)
            //        {
            //            Console.Write(' ');
            //        }
            //        for (int j = 0; j <= (2 * i); j++) {
            //            Console.Write('*');
            //        }
            //        Console.WriteLine();
            //    }
            //        //역삼각 피리마드
            //     for(int i=10; i > 0; i--)
            //        {
            //            for(int j=10; j>i;j++)
            //            {
            //            Console.Write(' ');

            //            }
            //            for(int j=10; j<=2*i; j--)
            //            {
            //            Console.Write('*');
            //            }
            //        Console.WriteLine();
            //

            //꼭짓점 왼쪽 역삼각형
            for (int i = 10; i > 0; i--)
            {
                for (int j = 0; j <= (2 * i); j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }


            //꼭지점 오른족 역삼각형
            for (int i = 0; i < 10; i++)
            {   //공백을 찍고 별을 찍는데 공백 갈수록 늘어나게끔
                for (int j = 0; j < i; j++)
                {
                    Console.Write(' ');
                }
                for (int j = 0; j < 10 - i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();

            }
        }
    }
}

