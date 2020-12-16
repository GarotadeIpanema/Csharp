using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shakerestaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel1.Height = button1.Height;
            firstUserControl11.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel1.Height = button1.Height;

            SidePanel1.Top = button1.Top;
            firstUserControl11.BringToFront();
            //secondUserControl11.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel1.Height = button3.Height;
            SidePanel1.Top = button3.Top;
            secondUserControl11.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
