using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = $"{textBox1.Text}, {textBox2.Text}";
            // "Hello World";
            //
           // string one = "string" + 123 + "   " +456;
           // string ex = $"첫번째 숫자는 {a}이고,"+$"두 번째 숫자는 {b}이다."; 
            MessageBox.Show(message);
            // 메세지 박스를 띄움
            // 
        }
    }
}
