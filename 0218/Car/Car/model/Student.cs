using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Student
    {
        private string id;
        private string name;
        private string tel;
        private string address;
        private string email;
        private static Student inst;

        public static Student getInst()
        {
            if(inst == null)
            {
                inst = new Student();

            }
            return inst;
        }
        public Student()
        {

        }

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Id { get => id; set => id = value; }

        public void showAddress()
        {
            Console.WriteLine("이름: {0}", name);
            Console.WriteLine("아이디:{1}",Id);
            Console.WriteLine("전화: ", tel);
            Console.WriteLine("주소: ", address);
            Console.WriteLine("이메일: ", email);
            Console.WriteLine("------------------");


        }

        public Student(string id, string name, string tel, string address, string email)
        {
            this.id = id;
            this.name = name;
            this.tel = tel;
            this.address = address;
            this.email = email;
        }

        public Student(string name, string tel, string address, string email)
        {
            this.name = name;
            this.tel = tel;
            this.address = address;
            this.email = email;
        }
    }
}
