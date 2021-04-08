using System;

namespace answer0408
{
    class Program
    {
        static void Main(string[] args)
        {   //1. 5개 숫자중 최댓값 최솟값
            int[] numbers = new int[5];
            for(int i=0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

            }
            int min = numbers[0];
            int max = numbers[0];
            //오옹 이렇게 동시에 할 수 있다!!
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                    min = numbers[i];
                if (numbers[i] > max)
                    max = numbers[i];

            }
            Console.WriteLine("min:" +min+"max:"+max);

            //2.개미수열: 1 11 12 1121 122111
            //시작 변수, 읽을 변수 지정 필요, 읽은 변수를 카운트할 변수 필요
            //값이 누적되기 때문에 temp 변수 도 필요 ㅠㅜㅠㅜㅜㅠ 엉엉

            Console.WriteLine("2번 개미수열: ");
            //시작이 1
            string start = "1";
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine((i+1)+"번쨰 수열:"+start);
                char number = start[0];
                int cnt = 0;
                string end = " ";
                //입력한 수열을 읽어들임
                for (int j = 0; j < start.Length; j++)
                {
                    if (number == start[j])
                    {
                        cnt++;

                    }
                    else
                    {
                        //1121 1에서 2로 넘어가는 시점 등; 그동안의 카운트 누적
                        end = end + number + cnt;
                        number = start[j];
                        cnt = 1;

                    }
                }
                //한줄을 다 읽었다
                end = end + number + cnt;
                //스타트값 변경 후 다시 for문 돈다
                start = end;

                }
           
            //3. 별찍기 입력한 숫자의 두배만큼 반복
            int inputFloor = int.Parse(Console.ReadLine());
            //+빈칸별 별 빈칸 결정해주는 변수 필요(Flag)
            int Flag = 0;
            if (inputFloor == 1)
            {
                Console.WriteLine('*');
            }
            else
            {
                for (int i = 0; i < inputFloor*2; i++)
                {   
                    //각 줄을 입력
                    for (int j = 0; j < inputFloor; j++)
                    {
                        if(Flag%2 ==0)
                            Console.Write('*');
                        else
                            Console.Write(' ');
                        Flag++;

                    }
                    if (inputFloor % 2 == 0)
                        Flag++;
                        
                    

                    Console.WriteLine();
                }
            }

            //4.설탕 배달-그리디 알고리즘
            //5의배수인지 체크
            int totalSugar = int.Parse(Console.ReadLine());
            int bag = 0;
            while (true)
            {
                if(totalSugar%5 == 0)
                {
                    bag += totalSugar / 5;

                }
                totalSugar -= 3;
                bag++;
                if (totalSugar < 0)
                {
                    bag -= 1;
                    break;
                }

            }
            Console.WriteLine(bag);

        }
    }
}
