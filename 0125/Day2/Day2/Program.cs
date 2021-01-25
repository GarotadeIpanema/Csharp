using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine();
                Console.WriteLine("*********  Menu  ************");
                Console.WriteLine("1. Chesseburger");
                Console.WriteLine("2. Hamburger");
                Console.WriteLine("3. Chicken Burger");
                Console.WriteLine("4. Veggie Hamburger");
                Console.WriteLine();
                Console.WriteLine("Your Choice(Q t quit) ==> ");
                string answer = Console.ReadLine();
                Console.WriteLine();
                if (answer == "Q" || answer == "q")
                {
                    break;
                }
                if (answer == "1")
                {
                    Console.WriteLine("Chesseburger: $ 7.99");
                }
                else if (answer == "2")
                {
                    Console.WriteLine("Hamburger: $ 6.99");
                }
                else if (answer == "3")
                {
                    Console.WriteLine("Chicken Burger: $ 6.50");
                }
                else if (answer == "4")
                {
                    Console.WriteLine("Veggie Burger: $ 6.00");
                }
                else
                {
                    Console.WriteLine("Error: Invalid input");
                }

            }

        }
    }
}
