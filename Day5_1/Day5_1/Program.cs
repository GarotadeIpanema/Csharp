using System;

namespace Day5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int errorCode = 1200;
            string s = ErrorDescription(errorCode);
            Console.WriteLine(s);
         }
        static string ErrorDescription(int errorCode)
        {
            string desc;
            switch (errorCode)
            {
                case 1100:
                    desc = "입력 데이터가 없습니다.";
                    break;
                case 1200:
                    desc = "잘못된 입력값입니다.";
                case 1300:
                    desc = "입력 범위를 초과하였습니다";
                    break;
                default:
                    desc = "Unknown Error";
                    break;

            }
            return desc;
        }

    }
}
