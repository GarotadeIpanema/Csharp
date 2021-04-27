using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("1546번: 세준이 기말고사 복습");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            double[] newArray = new double[size];
            string[] arr = Console.ReadLine().Split(" ");

            int max = 0;
            for (int i = 0; i < size; i++)
            {
                int score = int.Parse(arr[i]);
                array[i] = score;
                if (score > max)
                    max = score;
            }
            double sum = 0.0;
            for (int i = 0; i < size; i++)
            {
                newArray[i] = (double)array[i] / max * 100;
                sum += newArray[i];
            }

            Console.WriteLine(sum / size);












        }

    }
}
