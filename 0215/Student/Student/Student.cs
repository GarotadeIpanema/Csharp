using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        private string name;
        private int age;
        private string gender;
        private string address;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; }

        public Student(string name, int age, string gender, string address)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.address = address;
        }
        
        public void showStudentInfo()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("이름:" +name);
            Console.WriteLine("나이:" + age);
            Console.WriteLine("성별:" + gender);
            Console.WriteLine("주소:" + address);
            Console.WriteLine("--------------------");

        }
    }
}
