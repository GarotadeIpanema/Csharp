using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            //java : System.out.prinln("Hello World");
            //C# : Console.WriteLine("Hello World");
            // Console.WriteLine("Hello World");
            //cw 하고 탭댑
            
            //java
            /*
                 Scanner s = new Scanner(System.in);
                 string ss = s.nextLine();
                 int aa = s.nextInt();
             */

            //실행하는 건 ctrl + f5
            string ss = Console.ReadLine();
            String sa = Console.ReadLine();
            int aa = int.Parse(Console.ReadLine());

            //1번
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0) {
                    sum += i;
                    Console.WriteLine(sum);
                }
           //2번
   

                int num,min, sec;
                Console.WriteLine("세자리 정수를 입력하세요.");
                
                int num = int.Parse(Console.ReadLine());
                int min = num / 60;
                    int sec = num % 60;

                    Console.WriteLine( min + " 분 "+ sec +"초");
           //3번
                 

                        int num, space, star;
                        Console.WriteLine( "정수를 입력하세요.");
                        num


//4번
             

                        for (int i = 1; i < 10; i++)
                        {
                            for (int j = 2; j < 10; j++)
                            {

                                Console.WriteLine(j + "x" + i + "=" + String.format("%2d", i * j));
                                Console.WriteLine(" ");
                            }
                            Console.WriteLine();
                        }
                    }
                }




//5번

        public class 4dementions{

            public static void main(String[] args)
            {
            // TODO Auto-generated method stub



            
            Console.WriteLine("정수 x를 입력하세요.");
            int x = int.Parse(Console.ReadLine());
            // int x =sc.nextInt();
            Console.WriteLine("정수 y를 입력하세요.");
            int y = int.Parse(Console.ReadLine());

            if ((x > 0) && (y > 0))
                {
                    Console.WriteLine(1);
                }
                else if ((x < 0) && (y > 0))
                {
                    Console.WriteLine(2);
                }
                // if(x>0)
                //{ if(y>0) System.out.println(1);
                //else
                //System.out.println(4);}

                else if ((x < 0) && (y < 0))
                {
                    Console.WriteLine("3");

                }
            else { 
                    Console.WriteLine(4);

                }



 
//6번
public class Switch_2
        {

            public static void main(String[] args)
            {
                // TODO Auto-generated method stub
                
                Console.WriteLine("월(1~12)을 입력:");
                int month = int.Parse(Console.ReadLine());
                switch (month)
                {
                    case 12:
                    case 1:
                    case 2:
                        Console.WriteLine("겨울입니다.");
                        break;
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("봄입니다.");
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("여름입니다.");
                        break;
                    case 9:
                    case 10:
                    case 11:
                        Console.WriteLine("가을입니다.");
                        break;
                    
                    default:
                        Console.WriteLine("잘못된 입력!");


                }
               
            }

        }

//7번
     






        
//8번
            public static void main(String[] args)
        {
            // TODO Auto-generated method stub
            int x = int.Parse(Console.ReadLine()); ;
            
            Console.WriteLine("숫자를 입력하세요:");
            int cr = x / 6;

            }

            ///배수로 처리????
            }
            Console.WriteLine("지나가는 방의 개수는 : " + cr + "입니다.");








        }
}


