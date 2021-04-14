using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace descript_function
{
    class MyMath
    {
        //인스턴스 함수:매개변수 input을 제곱해서 반환하는 함수
        public int power(int input)
        {

            return input * input;
        }
        //클래스 함수(static):매개변수 input을 count 만큼 제곱해서 반환하는 함수
        public static int power(int input, int count)
        {
            int result = input;
            for (int i = 0; i < count - 1; i++)
            {
                result *= input;
            }
            //return (input)^(count);
            return result;
        }
        public static int SumAll(int end)
        {
            int sum = 0;
            for (int i = 0; i <= end; i++)
            {
                sum += i;
            }

            return sum;
        }
        public static int SumAll(int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i;
            }

            return sum;
        }
        public int end;
        public int start;
        public  int SumAll()
        {
            int sum = 0;
            for (int i = 0; i <= end; i++)
            {
                sum += i;
            }

            return sum;
        }

    }
}