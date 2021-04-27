using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = new string[n];
            int cnt_true = 0;
            for (int i = 0; i < n; i++)
            {
                input[i] = Console.ReadLine();
                if (Checkgroup(input[i])==true)
                {
                    cnt_true++;
                }
            }
            Console.WriteLine(cnt_true);
        }
        //그룹단어 = 각 문자가 연속해서 나타나는 경우
        public static bool Checkgroup(string input)
        {
            bool checker = true;
            char[] ch = input.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                int cnt = 1;
                for (int j = i+1; j < ch.Length; j++)
                {
                    if (ch[i] == ch[j])
                    {
                        cnt++;
                    }
                }
                if(cnt > 1)
                {
                    if (ch[i] != ch[i + 1])
                    {
                        checker = false;
                        break;
                    }
                    else
                        checker = true;
                }
            }
            return checker;
        }
    }
}
