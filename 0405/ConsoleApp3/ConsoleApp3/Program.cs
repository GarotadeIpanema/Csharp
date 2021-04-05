using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)"안녕하세요"[0]);//안

            Console.WriteLine("안녕하세요"[0]);//안
            Console.WriteLine("안녕하세요"[4]);//요
            //Console.WriteLine("안녕하세요"[5]);//에라남
            //50504를 2진수로 바꾸면 유니코드 c548가 됨
            Console.WriteLine(Convert.ToString((int)"안녕하세요"[0],16));//요
            //문자값과 문자값 더한 값 출력
            Console.WriteLine('가' +'힣');
            
            Console.WriteLine(true);
            Console.WriteLine(false);
            //==동치, =는 값 할당
            //int a = 10;
            int ab = 10;

            Console.WriteLine(1==1);
            Console.WriteLine(1!=1);
            bool result = true;
            bool result2 = false;
            Console.WriteLine(!result);//논리 부정 연산자, 숫자의 부호를 반대로 출력
            Console.WriteLine(!result2);//논리 부정 연산자

            //9223372036854775807
            Console.WriteLine(long.MaxValue);
            //2147483647
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(1+1);// 디폴트 int
                                   //오버플로우: 영역을 벗어나서 이상한 값이 출력됨
                                   //unsigned int= 17846762
            //unit c = uint.MaxValue;

            int a = int.MaxValue; 
            int b = int.MaxValue;
            Console.WriteLine(a+b);//오버플로우 됨
            Console.WriteLine((long)a+b);//정상값이 나옴
            Console.WriteLine();
            int example = 100;
            Console.WriteLine(example++);//100 
            Console.WriteLine(++example);//102 처리된 상태에서 +1되어서 102가 된다
            int exex = 100;

            Console.WriteLine(exex);
            exex = exex + 1;
            int conclusion = 100;//1증가 시킨 뒤 그 값을 출력
            conclusion++;

            string input = Console.ReadLine();
            Console.WriteLine("안녕 나는 "+input+"이야!");
            //숫자(정수)입력 받기
            int number = int.Parse(Console.ReadLine());
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine(number/num);





            

















        }
    }
}
