using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rockpaperscissors
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        List<string> rand = new List<string>();
        List<string> rand2 = new List<string>();

        public Form1()
        {
            InitializeComponent();

            rand.Add("가위");
            rand.Add("바위");
            rand.Add("보");

            rand2.Add("삐리빠빠");
            rand2.Add("빼리빠빠");
            rand2.Add("빼뺴뺴빼");
            rand2.Add("빼앰~~!");



        }

        private void button1_Click(object sender, EventArgs e)
        {

            int randNum = r.Next(rand.Count);
            


            label5.Text = rand[randNum];
            
            if (textBox1.Text == label5.Text)
            {
                label4.Text="비겼습니다!";
            }
            else 
            {
                if (textBox1.Text == "가위")
                {
                    if (label5.Text == "보"){
                        label4.Text = "이겼습니다!";
                    }
                    if (label5.Text == "바위")
                    {
                        label4.Text = "졌습니다!";
                    }

                }
                if (textBox1.Text == "보")
                {
                    if (label5.Text == "가위")
                    {
                        label4.Text = "졌습니다!";
                    }
                    if (label5.Text == "바위")
                    {
                        label4.Text = "이겼습니다!";
                    }

                }
                if (textBox1.Text == "바위")
                {
                    if (label5.Text == "가위")
                    {
                        label4.Text = "졌습니다!";
                    }
                    if (label5.Text == "가위")
                    {
                        label4.Text = "이겼습니다!";
                    }

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int randNum2 = r.Next(rand2.Count);
            label3.Text= rand2[randNum2];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
