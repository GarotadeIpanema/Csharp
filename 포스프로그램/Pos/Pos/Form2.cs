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
    partial class Form2 : Form
    {
        //서버사용 선언
        MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=pos_dataset;" +
            "Uid=root;Pwd=1126");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table = new DataTable();

        public Form2()
        {
            InitializeComponent();

        }
        //Db에서 데이터 불러온 후 텍박 초기화(데이터 갱신 필수)
        public void LoadData()
        {
            string sql = "Server=localhost;Port=3306;" +
                "Database=pos_dataset;Uid=root;Pwd=1126";
            MySqlConnection con = new MySqlConnection(sql);
            MySqlCommand cmd_db = new MySqlCommand("SELECT * FROM sales_tb;", con);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd_db;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";


        }
        public void searchData(string valueToSearch)
        {
            string query = "SELECT * FROM sales_tb WHERE CONCAT('name', 'price', 'count', 'total') like '%" +
                valueToSearch + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            
        }
        

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //새로고침
        private void button_reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            searchData("");
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("검색 정보를 입력해주세요");

            }
            else
            {
                string valueToSearch = textBox1.Text.ToString();
                searchData(valueToSearch);
                textBox1.Text = "";

            }
        }
        int selectedRow;
        //셀 클릭시 해당 행의 정보를 텍박에 채움
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            textBox6.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            textBox5.Text = row.Cells[4].Value.ToString();

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string constring = "Server=localhost;Port=3306;Database=pos_data;Uid=root;Pwd=1126";
            if (textBox2.Text=="" || textBox3.Text==""||textBox4.Text=="")
            {
                MessageBox.Show("항목을 정확히 입력해주세요");
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

            }
            else
            {
                decimal price = decimal.Parse(textBox3.Text);

                decimal count = decimal.Parse(textBox4.Text);
                decimal total = price*count;
                textBox5.Text = total.ToString();
                //업데이트를 통해 DB로 수정된 데이터 전송- 기본키 기준으로 수정 위치 찾기
                string Query = "update pos_dataset.sales_tb set no='" + this.textBox6.Text +
                    "'name='" + this.textBox2.Text + "'price='" + this.textBox3.Text + "'," +
                    "count='" + this.textBox4.Text + "',total='" + this.textBox5.Text + "'where no='" +
                    this.textBox6.Text + "'";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;
                try
                {
                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    MessageBox.Show("수정완료");
                    while (myReader.Read())
                    {

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


            }
            LoadData();

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string constring = "Server=localhost;Port=3306;Database=pos_dataset;Uid=root;Pwd=1126";
            if (textBox6.Text=="")
            {
                MessageBox.Show("삭제 할 항목을 찾지 못했습니다");
            }
            else
            {
                string Query = "delete from pos_dataset.sales_tb where no ='" + this.textBox6.Text + "';";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;
                try
                {
                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    MessageBox.Show("삭제완료");
                    while (myReader.Read())
                    {

                    }
                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                LoadData();

            }
        }
    }
}
