using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_li_sv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Thêm các dòng sinh viên mẫu vào bảng (đúng thứ tự 9 cột đã tạo)
            dataGridView1.Rows.Add("1", "Nguyễn Thái Hoàng", "15/08/2006", "Nam", "hoangtn@vju.ac.vn", "0912345678", "1.0", "BCSE", "Đuổi học");
            dataGridView1.Rows.Add("2", "Hoàng Viết Hiếu", "04/02/2006", "Nữ", "18namdinh@vju.ac.vn", "0987654321", "1.8", "BCSE", "Đuổi học");
            dataGridView1.Rows.Add("3", "Hà Văn Híu", "08/02/2006", "Nam", "hahieuminecraft@vju.ac.vn", "0355556677", "1.7", "BCSE ", "Đuổi học");
            dataGridView1.Rows.Add("4", "Vũ Huy Hùng", "24/11/2006", "Nam", "viniciusjr@vju.ac.vn", "0321754897", "9.8", "BCSE ", "Đang học");
            dataGridView1.Rows.Add("5", "Nguyễn Phúc Minh Đức", "12/07/2006", "Nam", "mducngaoda@vju.ac.vn", "0234897234", "7.0", "BCSE ", "Đang học");
            dataGridView1.Rows.Add("6", "Hà Huy Hoàng", "10/03/2006", "Nam", "hoangha@vju.ac.vn", "0317421980", "7.9", "BCSE ", "Đang học");
            dataGridView1.Rows.Add("7", "Nguyễn Đình Hải", "31/02/2006", "Nam", "haidandon@vju.ac.vn", "0123456789", "0.1", "BCSE ", "Đuổi học");
            dataGridView1.Rows.Add("8", "Vũ Mạnh Hùng", "08/02/2006", "Nam", "hungngao@vju.ac.vn", "0321032765", "5.0", "BCSE ", "Đang học");
            dataGridView1.Rows.Add("9", "Nguyễn Đức Anh", "09/01/2006", "Nam", "ducanhng@vju.ac.vn", "0987654321", "8.0", "BCSE ", "Đang học");
            dataGridView1.Rows.Add("10", "Lại Khánh Duy", "01/01/2006", "Nam", "duynen@vju.ac.vn", "0320654782", "6.0, "BCSE ", "Đang học");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
