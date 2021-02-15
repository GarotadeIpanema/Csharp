using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Arraytest1
    {
        private int sum;
        private int avg;
        private int[] arr;

        public Arraytest1() { }
        public Arraytest1(int[] arr)
        {

            sumAvg(arr);

        }
        //람다식
        public int Sum { get => sum; set => sum = value; }
        public int Avg { get => avg; set => avg = value; }
        public void sumAvg(int[] arr)
        {
            Arraytest1 at1 = new Arraytest1(arr);
            Arraytest1 at2 = new Arraytest1(arr);
           
           



            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            avg = sum / arr.Length;

            Console.WriteLine("총점: " + sum);
            Console.WriteLine("평균: " + avg);
        }
            public void setArray(int [] arr)
        {
            this.arr = arr;

        }
        public void sumAvg()
        {

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            avg = sum / arr.Length;

            Console.WriteLine("총점: " + sum);
            Console.WriteLine("평균: " + avg);
        }
        }
    }

