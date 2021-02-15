using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Car
    {
        private string name;
        private string tel;
        private string address;
        private string model;
        private string color;
        private int year;
        private string company;

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Address { get => address; set => address = value; }
        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public int Year { get => year; set => year = value; }
        public string Company { get => company; set => company = value; }

        public Car(string name, string tel, string address, string model, string color, int year, string company)
        {
            this.name = name;
            this.tel = tel;
            this.address = address;
            this.model = model;
            this.color = color;
            this.year = year;
            this.company = company;
        }
        public void showCustomerInfo()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("이름: "+ name);
            Console.WriteLine("전화번호: " + tel);
            Console.WriteLine("주소: " + address);
            Console.WriteLine("모델: " + model);
            Console.WriteLine("색상: " + color);
            Console.WriteLine("연식: " + year);
            Console.WriteLine("제조회사: " + company);
            Console.WriteLine("--------------------");


        }
    }

}
