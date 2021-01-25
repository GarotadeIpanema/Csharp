using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 100;
            int b = 200;
            int c = a + b;
            Console.WriteLine(c);
            int sum = 0;
            for(int i = 1; i <= 100; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum: {0}", sum);
            //cw 탭탭
            for (int i = 2; i < 10; i++)
            {
                for(int j = 1; j < 10; j++)
                {
                    Console.WriteLine("{0} x {1} ={2}", i,j,i*j);
                }
            }
            
        }
    }
}
