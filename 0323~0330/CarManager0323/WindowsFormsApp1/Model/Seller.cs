using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class Seller
    {
        string name;
        string pos;
        string tel;
        string email;
        string company;

        public Seller(string name, string pos, string tel, string email, string company)
        {
            this.name = name;
            this.pos = pos;
            this.tel = tel;
            this.email = email;
            this.company = company;
        }
        public string Name { get => name; set => name = value; }
        public string Pos { get => pos; set => pos = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Email { get => email; set => email = value; }
        public string Company { get => company; set => company = value; }



    }
}
