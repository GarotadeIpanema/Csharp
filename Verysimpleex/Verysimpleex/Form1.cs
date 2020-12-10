using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verysimpleex
{
    public partial class Form1 : Form
    {
        int countTime = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하세요.");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = textBox1_message.Text;
            MessageBox.Show($"내가 빈 칸에 적은 말은 {message}이다.");
        }
        //snake 표기법
        

        private void textBox1_message_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label_nowTime.Text = $"{DateTime.Now.Year}년{DateTime.Now.Month}월" +
                $"{DateTime.Now.Day}일{DateTime.Now.Hour}시{DateTime.Now.Minute}분{DateTime.Now.Second}초";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 내가 지정한 Intervewl에 한 번식 동작  
            // 여기서는 1000ms= 1초에 한 번 동작
            label_second.Text = countTime.ToString();
            countTime++;
        }

        private void label_second_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.co.kr");

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.naver.com");
        }
    }
}
