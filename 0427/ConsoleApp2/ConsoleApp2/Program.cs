using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1427번
            // 첫째즐에 자리수를 내림차순으로 정렬한 수 출력
            string n = Console.ReadLine();
            char[] arr = n.ToCharArray();
            for (int i = 0; i < n.Length; i++)
            {
                for (int j = i+1; j < n.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        char temp = arr[i];
                        arr[i] = arr[j];
                        arr[j]=temp;
  
                        
                    }
                }
            }
            string result = string.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }
            Console.WriteLine(result);

        }
    }
}
