using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOL3
{
    class Program
    {
        static void Main(string[] args) {
            Mid md = new Mid();
            int[] Arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            int sum = 0;
            
            
            for (int i = 0; i < Arr.Length; i++)
            {
                sum += Arr[i];
            }
            int avg = sum / Arr.Length;
            md.setSum(sum);
            md.setAvg(avg);
            md.printMidInfo();

        }
       
        class Mid{
            
            private int sum;
            private int avg;
            public void setSum(int sum)
            {
                this.sum = sum;
            }
            public int getSum()
            {
                return sum;
            }
            public void setAvg(int avg)
            {
                this.avg = avg;
            }
            public int getAvg()
            {
                return avg;
            }
            public void printMidInfo()
            {
                Console.WriteLine("합: " + sum);
                Console.WriteLine("평균: " +avg);
            }

        }
    }
    }
