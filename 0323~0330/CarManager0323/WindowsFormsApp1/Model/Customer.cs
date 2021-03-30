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

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
    }
}
