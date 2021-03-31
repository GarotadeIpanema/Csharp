using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Car
    {
        string model;
        string price;
        string color;
        string company;
        string year;
        private string text1;
        private int v;
        private string text2;
        private Car car;


        public Car(string text1, int v, string text2, Car car)
        {
            this.text1 = text1;
            this.v = v;
            this.text2 = text2;
            this.car = car;
        }

        public Car(string model, string  price, string color, string company, string year)
        {
            this.model = model;
            this.price = price;
            this.color = color;
            this.company = company;
            this.year = year;
        }

        public string Model { get => model; set => model = value; }
        public string Price { get => price; set => price = value; }
        public string Color { get => color; set => color = value; }
        public string Company { get => company; set => company = value; }
        public string Year { get => year; set => year = value; }
    }


}
