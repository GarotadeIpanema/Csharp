using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class N개의_최소공배수
    {
        public int solution(int[] arr)
        {
            arr =new int[] { 2,6,8,14};
           int maxyak=Enumerable.Range(1, arr.Max()).Where(x => x % arr[x] == 0).Max();
            Console.WriteLine();
            int answer = 0;
            
            return answer;
        }
    }
}
