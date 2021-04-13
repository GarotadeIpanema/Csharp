using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overloading
{
    public partial class Form1 : Form
    {   //재사용=오버로딩
        public Form1()
        {
            InitializeComponent();
        }
        private void black()
        {
            MessageBox.Show("커피");
        }
        private void black(string name)
        {
            MessageBox.Show(name);
        }
        private void black(string name, string name2)
        {
            MessageBox.Show(name+name2);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            black(button2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            black();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            black(button2.Text, button1.Text);
        }
    }
}
