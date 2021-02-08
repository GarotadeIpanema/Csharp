using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Student2
    {
        //인스턴스 변수 (속성)
        private string tel;
        private string name;
        //클래스 변수
        public static  string CLASS = "JAVA, C# 응용프로그램 개발자과정";
        //오버로딩: 중복정의

        public Student2()
        {
            name = "박길동";
            tel = " 010-3242-2347";
        }
        //prop 탭탭
        public Student2(string name, string tel)
        {
            this.name = name;
            this.tel = tel;
        }

        //하나의 특수한 메서드처럼 생각
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        public void printStudentInfo() { 
            Console.WriteLine("과정: " +Student2.CLASS);
            Console.WriteLine("----------------------");
            Console.WriteLine("이름: " + name);
            Console.WriteLine("전화: " + tel);
            Console.WriteLine("----------------------");
        }
    }
}

