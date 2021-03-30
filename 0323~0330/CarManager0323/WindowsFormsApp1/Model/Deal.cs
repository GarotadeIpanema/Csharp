using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class Deal
    {
        string date;
        Customer customer;
        Car car;
        Seller seller;

        public Deal(string date, Customer customer, Car car, Seller seller)
        {
            this.date = date;
            this.customer = customer;
            this.car = car;
            this.seller = seller;
        }

        public string Date { get => date; set => date = value; }
        public Car Car { get => car; set => car = value; }
        internal Customer Customer { get => customer; set => customer = value; }
        internal Seller Seller { get => seller; set => seller = value; }
    }
}
