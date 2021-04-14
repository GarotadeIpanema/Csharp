using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace descript_function
{
    class Circle
    {   
        public int r; //인스턴스 변수(클래스의 속성이다, 클래스의 맴버이다, 선언할때 올라감)
        public static double PI= 3.141592; //클래스 변수, 전역변수이다,메모리에 바로 올라감

        public double round()//인스턴스 함수
        {
            return this.r * PI * 2;

        }
        public double area()
        {
            return this.r * this.r * PI;

        }
        public static void setPI(double pi)
        {
            PI = pi;
        }
        public static double getPi()
        {
            return PI;

        }
        public static void showPi()
        {
            System.Windows.Forms.MessageBox.Show("현재 pi값은"+PI+"입니다.");
        }
       






    }
}
