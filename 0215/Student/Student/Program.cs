using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
            int[] age = { 20, 25, 30, 35, 40 };
            String[] gender = { "남", "여" };
            String[] address = { "대구시 동구 신암4동 ", "서울시 동구 신암4동","광주시 동구 신암4동",
                "인천시 동구 신암4동", "부산시 동구 신암4동"};

            Random r = new Random();
            Student[] st = new Student[10];
            for(int i = 0; i < st.Length; i++)

            { 
                string strName = name[r.Next(0,5)];
                int intAge = age[r.Next(0,5)];
                string strGender = gender[r.Next(0,2)];
                string strAddress = address[r.Next(0,5)];

                st[i] = new Student(strName, intAge, strGender, strAddress);
                st[i].showStudentInfo();

            }


        }
    }
}
