
namespace Pos
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_currentsell = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_stock = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_pick = new System.Windows.Forms.Button();
            this.button_charge = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button_crulist = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_currentsell
            // 
            this.button_currentsell.Location = new System.Drawing.Point(26, 392);
            this.button_currentsell.Name = "button_currentsell";
            this.button_currentsell.Size = new System.Drawing.Size(75, 23);
            this.button_currentsell.TabIndex = 0;
            this.button_currentsell.Text = "판매 내역";
            this.button_currentsell.UseVisualStyleBackColor = true;
            this.button_currentsell.Click += new System.EventHandler(this.button_currentsell_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(602, 315);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "상품판매";
            // 
            // button_stock
            // 
            this.button_stock.Location = new System.Drawing.Point(434, 392);
            this.button_stock.Name = "button_stock";
            this.button_stock.Size = new System.Drawing.Size(75, 23);
            this.button_stock.TabIndex = 3;
            this.button_stock.Text = "재고 현황";
            this.button_stock.UseVisualStyleBackColor = true;
            this.button_stock.Click += new System.EventHandler(this.button_stock_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(647, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "상품명";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(649, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 21);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(650, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 21);
            this.textBox2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(648, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "가격";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(648, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "개수";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(650, 257);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(120, 21);
            this.textBox4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(648, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "합계";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(649, 194);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown1.TabIndex = 12;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(650, 295);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(119, 23);
            this.button_cancel.TabIndex = 13;
            this.button_cancel.Text = "취소";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_pick
            // 
            this.button_pick.Location = new System.Drawing.Point(650, 324);
            this.button_pick.Name = "button_pick";
            this.button_pick.Size = new System.Drawing.Size(120, 23);
            this.button_pick.TabIndex = 14;
            this.button_pick.Text = "담기";
            this.button_pick.UseVisualStyleBackColor = true;
            this.button_pick.Click += new System.EventHandler(this.button_pick_Click);
            // 
            // button_charge
            // 
            this.button_charge.Location = new System.Drawing.Point(650, 353);
            this.button_charge.Name = "button_charge";
            this.button_charge.Size = new System.Drawing.Size(120, 23);
            this.button_charge.TabIndex = 15;
            this.button_charge.Text = "계산히기";
            this.button_charge.UseVisualStyleBackColor = true;
            this.button_charge.Click += new System.EventHandler(this.button_charge_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(683, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "SERVER";
            // 
            // button_crulist
            // 
            this.button_crulist.Location = new System.Drawing.Point(540, 392);
            this.button_crulist.Name = "button_crulist";
            this.button_crulist.Size = new System.Drawing.Size(75, 23);
            this.button_crulist.TabIndex = 17;
            this.button_crulist.Text = "직원 목록";
            this.button_crulist.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(506, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "-";
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(695, 8);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(75, 23);
            this.button_logout.TabIndex = 19;
            this.button_logout.Text = "로그 아웃";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 434);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_crulist);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_charge);
            this.Controls.Add(this.button_pick);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_stock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_currentsell);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_currentsell;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_stock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_pick;
        private System.Windows.Forms.Button button_charge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_crulist;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_logout;
    }
}

