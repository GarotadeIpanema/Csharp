using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class Car
    {
        string model;
        int price;
        string color;
        string company;
        string year;

        public Car(string model, int price, string color, string company, string year)
        {
            this.model = model;
            this.price = price;
            this.color = color;
            this.company = company;
            this.year = year;
        }
    }


}
