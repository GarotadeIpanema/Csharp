using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace descript_function
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();



        }
        //sender: 이벤트를 호출하는 자기자신, EventArgs: 이벤트에 관련된 정보들
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = int.Parse(textBox1.Text);
            label1.Text = second_demension_sik(int.Parse(textBox1.Text)) + "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            introduce_my_name(textBox1.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number = random_onetoten();
            MessageBox.Show("오늘의 랜덤 숫자는 " + number + "입니다");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hello();
        }
        //매겨변수와 반환형이 있는 함수
        private int second_demension_sik(int x)
        {
            return x * x + (2 * x) + 1;

        }
        //매개변수만 있는 함수
        private void introduce_my_name(string name)
        {
            MessageBox.Show("내 이름은" + name + "이야");
        }
        //반환형만 있는 함수
        private int random_onetoten()
        {
            return new Random().Next(10) + 1;
        }
        //반환형과 매개변수가 없는 함수
        private void Hello()
        {
            MessageBox.Show("안녕!@");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //int.Parse 대신에 쓸수 있는 것

            try
            {
                int num = int.Parse(textBox1.Text);
                MessageBox.Show("내가 입력한 숫자는 " + num);
            }
            catch (Exception ex)
            {
                MessageBox.Show("숫자 적오");
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                printLog(ex.Message);
                printLog(ex.StackTrace);

                //throw; 프로그램을 종료시킴
            }

        }
        private void printLog(string contens)
        {
            DirectoryInfo di = new DirectoryInfo("Trace");
            if (di.Exists==false)
            {
                di.Create();

            }
            using (StreamWriter writer = new StreamWriter("Trace" + "\\" + "Log.txt"))
            {
                writer.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}]{contens}{".txt"}");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //int.Parse 대신 쓸수 있는 것 2
            //int number;
            //숫자를 바꾸는 것 성공하면 true를 반환해줌
            bool result =int.TryParse(textBox1.Text, out int number);
            if (result==false)
            {
                MessageBox.Show("숫자써");
            }
            else
            {
                MessageBox.Show("내가 적은 숫자는 " +textBox1.Text);
            }
                
        }

        //오버로딩
        //파라미터로 넣은 값을 모두 제외 가능
        private int random_onetoten(int except)
        {   

            int num = new Random().Next(10) + 1;
            while (num == except)
            {
                num = new Random().Next(10) + 1;
            }
            return num;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int except = int.Parse(textBox2.Text); ;
            int num= (random_onetoten(except));
           
            MessageBox.Show("5를 제외한 1~10사이의 수 "+num);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox2.Text, out int except);
            label2.Text = "제외되는 숫자는 " + except;
            label3.Text = except + "를 제외한 숫자는 " + random_onetoten(except);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Circle c1 = new Circle();
            c1.r = 100;
            Circle c2 = new Circle();
            c2.r = 111;
            MessageBox.Show("원 pi의 값은" +Circle.PI +"입니다.");
            MessageBox.Show("c1의 둘레는"+c1.round()+"입니다");
            MessageBox.Show("c2의 둘레는" + c2.round() + "입니다");
            MessageBox.Show("c1의 넓이는"+c1.area()+"입니다");
            MessageBox.Show("c2의 넓이는"+c2.area()+"입니다");
            Circle.setPI(3.14);
            MessageBox.Show("원 pi의 값은" + Circle.getPi() + "입니다.");
            MessageBox.Show("c1의 둘레는" + c1.round() + "입니다");
            MessageBox.Show("c2의 둘레는" + c2.round() + "입니다");
            MessageBox.Show("c1의 넓이는" + c1.area() + "입니다");
            MessageBox.Show("c2의 넓이는" + c2.area() + "입니다");
            //클래스 함수: 전역변수를 사용
            Circle.showPi();
         
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox3.Text, out int input);
            MyMath m = new MyMath();
            MessageBox.Show(textBox1.Text+"의 제곱은"+m.power(input));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox6.Text, out int input);
            int.TryParse(textBox5.Text, out int count);
            MessageBox.Show(textBox5.Text + "의"+ textBox6.Text+"제곱은" + MyMath.power(input,count));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox7.Text, out int end);
            
            MessageBox.Show(textBox7.Text + "0부터" + end + "까지의 합은" + MyMath.SumAll(end));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox9.Text, out int end);
            int.TryParse(textBox10.Text, out int start);

            MessageBox.Show(textBox9.Text +"부터" + end + "까지의 합은" + MyMath.SumAll(start,end));
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MyMath a = new MyMath();
            a.end = 100;
            //a.abc = 100;

        }
        
        private void button14_click(object sender, EventArgs e)
        {
            MyMath m = new MyMath();
            int.TryParse(textBox9.Text, out m.end);
            MessageBox.Show("0부터 " + m.end + "까지 합" + m.SumAll());

            MyMath m2 = new MyMath();
            int.TryParse(textBox9.Text, out m2.end);
            MessageBox.Show("0부터 " + m2.end + "까지 합" + m2.SumAll());
        }

       
    }
}
