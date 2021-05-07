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
    public partial class Form3 : Form
    {
        Form2 f2 = new Form2();
        public Form3()
        {
            InitializeComponent();
        }

        private void button_back1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //재고추가
        private void button_add_Click(object sender, EventArgs e)
        {
            string constring = "Server=localhost;Port=3306;Database=pos_dataset;Uid=root;Pwd=1126";
            string Query = "INSERT INTO pos_dataset.item_tb(i_name,i_price,i_count) value('" + this.textBox3.Text +
                "','" + this.textBox4.Text + "','" + this.textBox5.Text + "')";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("재고 추가 완료");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("항목을 정확하게 입력하세요");
                MessageBox.Show(ex.Message);
            }
            f2.LoadData();




        }
    }
}
