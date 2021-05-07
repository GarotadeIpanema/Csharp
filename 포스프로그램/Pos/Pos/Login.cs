using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{
    public partial class Login : Form
    {   //구분한 값 form1으로 전송하기 위해 static 으로 설정
        public static string chk;
        public Login()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "Server=localhost;Port=3306;Database=pos_data;Uid=root;Pwd=1126";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                //각각의 항목을 디비와 대조
                MySqlCommand selectCommand = new MySqlCommand("select * from pos_data.pos_login_tb where id" +
                    "='" + this.textBox_id.Text + "' and password='" + this.textBox_pw.Text + "' and position='" +
                    this.textBox_who.Text + "'", myConn);
                MySqlDataReader myReader;
                myReader = selectCommand.ExecuteReader();
                myConn.Open();
                int count = 0;
                while (myReader.Read())
                {
                    count += 1;

                }
                if (count==1)
                {
                    //포지션 값을 0,1로 나타냄, 매니져인지 아닌지 확인
                    if (textBox_who.Text=="manager")
                    {
                        chk = "0";
                    }
                    else
                    {
                        chk = "1";
                    }
                    MessageBox.Show("로그인 되었습니다.");
                    this.Visible = false;
                    Form1 showform1 = new Form1();
                    showform1.ShowDialog();

                }
                else if (count>1)
                {
                    MessageBox.Show("중복된 유저가 존재합니다.");
                }
                else
                {
                    MessageBox.Show("아이디, 비밀번호나 직책이 일치하지 않습니다.");
                }
                myConn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_createac_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Account Dlg = new Account();
            Dlg.ShowDialog();
        }
    }
}
