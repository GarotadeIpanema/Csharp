using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOl1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car cr = new Car();
            cr.setCompany("기아");
            cr.setColor("블랙");
            cr.setPrice("4천만원");
            cr.setName("K7");
            cr.printCarInfo();

        }
    }
    class Car
    {
        private string company;
        private string color;
        private string price;
        private string name;
        const  string AGENCY = "동대구 영업소";

        public void setCompany(string company)
        {
            this.company = company;

        }
        public string getCompany()
        {
            return company;

        }
        public void setColor(string color)
        {
            this.color = color;

        }
        public string getColor()
        {
            return color;

        }
        public void setPrice(string price)
        {
            this.price = price;

        }
        public string getPrice()
        {
            return price;

        }
        public void setName(string name)
        {
            this.name = name;

        }
        public string getName()
        {
            return name;

        }
        public void printCarInfo()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("제조사: " + company);
            Console.WriteLine("색상: " +color);
            Console.WriteLine("가격: "+price);
            Console.WriteLine("모델명: " + name);
            Console.WriteLine("대리점명: " + AGENCY);
            Console.WriteLine("--------------------");

        }

    }
}
