using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            //네임스페이스, 클래스, 메서드
            String s = "Hello";
            char c = s[0];
            c = s[1];
            c = s[2];
            Console.WriteLine(c);

            Day4.Program.Display("Hi");
            Display("Hi");
            int result = Day4.MyMath.Sum(12, 21);
            result = MyMath.Sum(12, 21);
        }
        static void Display(String s)
        {
            Console.WriteLine(s);
        }
        class MyMath
        {
            public static int Sum(int a, int b)
            {
                return a + b;
            }
        }
    }
}
            //string s1 = " Hello";
            //string s2 = "World";
            //string s3 = s1 + " " + s2;
            //Console.WriteLine(s3);
            //부분 문자열 :SubStirng
            //string sub = s.Substring(1, 4);
            //Console.WriteLine(sub);
            //문자열에서 공백으로 분리

            //s = "I an a boy";
            //String[] words = s.Split(' ');

            //for(int i=0; i < words.Length; i++)
            //{
                //Console.WriteLine(words[i] );
            //}

        //}
    //}
//}
