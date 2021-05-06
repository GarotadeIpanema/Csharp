using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pos
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable();
        public Form1()
        {
            InitializeComponent();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Price", typeof(string));
            table.Columns.Add("Count", typeof(string));
            table.Columns.Add("Total", typeof(string));
            dataGridView1.DataSource = table;
            //초기값 1로 지정
            numericUpDown1.Value = 1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=1126");
            connection.Open();
            if (connection.State==ConnectionState.Open)
            {
                label6.Text = "Connected";
                label6.ForeColor = Color.Black;
            }
            else
            {
                label6.Text = "Disconnected";
                label6.ForeColor = Color.Red;

            }

        }
        //담기버튼
        private void button_pick_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==" " || textBox2.Text==" ")
            {
                MessageBox.Show("항목을 정확히 입력해주세요");
                textBox1.Clear();
                textBox2.Clear();

            }
            else
            {
                decimal price = decimal.Parse(textBox2.Text);
                decimal count = numericUpDown1.Value;
                decimal total = price*count;
                //text박스 내 정보를 표에 삽입
                table.Rows.Add(textBox1.Text, textBox2.Text, numericUpDown1.Value, total);
                dataGridView1.DataSource = table;
                textBox1.Clear();
                textBox2.Clear();
                numericUpDown1.Value = 1;
                //합계
                decimal all = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    all += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);

                }
                textBox4.Text = all.ToString();




            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {   
            //행을 지운다
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
            //합계창에 수정된 값 넣기
            decimal all = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                all += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);

            }
            textBox4.Text = all.ToString();

        }

        private void button_charge_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;Database=pos_dataset;" +
                "Uid=root;Pwd=1126"))
            {
                conn.Open();
                //각행의 정보를 반복문으로 불러온다
                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                {
                    String Name = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    String Price = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    String Count = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    String Total = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    //insert into 쿼리문으로 받은 정보 디비에 전송
                    string sql=string.Format("INSERT INTO sales_tb(name,price,count,total,c_num)" +
                        "VALUES('{0}',{1},{2},{3},{4})", @Name, @Price, @Count, @Total, @i);
                    try
                    {
                        MySqlCommand command = new MySqlCommand(sql, conn);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
            }
            MessageBox.Show("계산되었습니다");
            int rowCount = dataGridView1.Rows.Count;
            for (int n = 0; n < rowCount; n++)
            {
                if (dataGridView1.Rows[0].IsNewRow==false)
                {
                    dataGridView1.Rows.RemoveAt(0);
                }
                textBox4.Text = "0";

            }

        }

        private void button_currentsell_Click(object sender, EventArgs e)
        {
            Form dlg = new Form2();
            dlg.ShowDialog();

        }

        private void button_stock_Click(object sender, EventArgs e)
        {
            Form3 Dlg = new Form3();
            Dlg.ShowDialog();

        }
    }
}
