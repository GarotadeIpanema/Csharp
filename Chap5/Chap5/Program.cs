using System;

namespace Chap5
{
    class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;

       
        public void SetIntime()
        {
            this.inTime = DateTime.Now;
        }
        public void SetOuttime()
        {
            this.outTime = DateTime.Now;
        }

        static void Main(string[] args)
        {
            //클래스와 윈폼 듀듕
            //클래스: 하나의 변수에 여러개의 변수를 저장할 수 있다
            Random random = new Random();
            Console.WriteLine( random.Next(10,100));
            Console.WriteLine(random.Next(10,100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));

            Car car = new Car();
            car.SetIntime();
            car.SetOuttime();
            //클래스, 인스턴스 ,new, 생성자


        }
    }
}
