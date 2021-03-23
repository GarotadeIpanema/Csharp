using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class Customer
    {
        string name;
        string tel;
        string email;
        string address;

        public Customer(string name, string tel, string email, string address)
        {
            this.name = name;
            this.tel = tel;
            this.email = email;
            this.address = address;
        }


    }
}
