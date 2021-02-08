using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //객체(인스턴스)를 생성한다.
            Student st = new Student();

            //생성자가 없으므로 셋팅해준다
            st.setName("홍길동");
            st.setTel("010-3246-2455");
            st.printStudentInfo();
            Console.WriteLine("이름:" + st.getName());

            Student2 st2 = new Student2();
            //변수아님 특수한 메서드, 씨썁용 생성자 셋팅 문법
            st2.Name = " 마길동";
            st2.Tel = "010-3246-2455";
            st2.printStudentInfo();
            Console.WriteLine("이름:" + st2.Name);
            Student2 st3 = new Student2("최길동", " 010- 32584-2472");
            st3.printStudentInfo();
            new Student2("최길동", " 010- 32584-2472").printStudentInfo();
            string[] nameArr = { "홍길동", "점길동", "박길동" };
            string[] telArr = { "010-3274-2478", "010-1372-2437", "010-2462-2476" };
            Random r = new Random();
            Student2[] strArr = new Student2[10];
            for (int i = 0; i < strArr.Length; i++)
            {
                strArr[i] = new Student2(nameArr[r.Next(0, 3)], telArr[r.Next(0, 3)]);
                strArr[i].printStudentInfo();
            }
            //클래스 변수 사용
            Console.WriteLine("과정명: " + Student2.CLASS);

        }
    }
    //한명에 대한 정보: 틀은 하나
    class Student
    {
        //캡슐화
        private string name;
        private string tel;
        
        //객체의 주소값 지정: this(포인터 개념)
        public void setName(string name)
        {
            this.name = name;
           
        }
        public string getName()
        {
            return name;
        }
        public void setTel(string tel)
        {
            this.tel
                = tel;

        }
        public string getTel()
        {
            return tel;
        }
        public void printStudentInfo()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("이름: " +name);
            Console.WriteLine("전화: " + tel);
            Console.WriteLine("----------------------");


        }
    }
}
