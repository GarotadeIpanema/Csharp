using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Star3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n= Console.Read();
            for(int i = 1; i < 5; i++)
            {
                for (int j = 4; j >0; j--)
                    if (i < j)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                Console.WriteLine(" ");
            }

            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j < 3 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");

            }
            }
    }
}
