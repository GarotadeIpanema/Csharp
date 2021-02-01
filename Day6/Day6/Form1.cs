using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginName = txtUsername.Text;
            string password = txtPassword.Text;

            if(loginName == "adimin" && password ="1234")
            {
                MessageBox.Show("Login Sucess", "Success");
            }
            else
            {
                MessageBox.Show("Access Denied", "Failure");
            }
        }
    }
}
