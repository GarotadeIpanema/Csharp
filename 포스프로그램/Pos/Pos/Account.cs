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
    public partial class Account : Form
    {   //mysql로 sales_tb, pos_dataset, pos_data.pos_login_tb 만들어야 함
        public Account()
        {
            InitializeComponent();
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text==""||textBox_name.Text==""||textBox_pw.Text=="")
            {
                MessageBox.Show("항목을 정확히 입력해주세요");
                textBox_pw.Clear();
                textBox_id.Clear();

            }
            else
            {
                string constring= "Server=localhost;Port = 3306;Database = pos_data;Uid = root;Pwd = 1126";
                string Query = "INSERT INTO pos_login_tb.item_tb(i_name,i_price,i_count) value('"
                    + this.textBox_name.Text + "','" + this.textBox_id.Text + "','" + this.textBox_pw.Text + "')'";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;
                try
                {
                    conDataBase.Open();
                    myReader = cmdDatabase.ExecuteReader();
                    MessageBox.Show("계정 생성 완료");
                    //여긴 왜 아무것도 없지..?
                    while (myReader.Read())
                    {

                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("항목을 정확히 입력해주세요");
                    MessageBox.Show(ex.Message);
                }

            }

        }
        //계정생성 취소
        private void button_cancelac_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login showform1=new Login();
            showform1.ShowDialog();


        }
    }
}
