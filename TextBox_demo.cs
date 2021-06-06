using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_WInForm
{
    public partial class TextBox_demo : Form
    {
        public TextBox_demo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

          

        }

        private void TextBox_demo_Load(object sender, EventArgs e)
        {
            //textbox 1
            textBox1.Visible = true;
            //Lấy dữ liệu từ textbox
            string var;
            var = textBox1.Text;
            //Thay đổi thuộc tính
            textBox1.Text = "abc"; textBox1.Enabled = true;

            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

            //sử dụng Biểu thức chính quy (Regular Expression): 
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "  ^ [0-9]"))
            {
                textBox2.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textbox 2
            double click;
            click = double.Parse(textBox2.Text);

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode = Keys.Enter)
            //{
            //    MessageBox.Show("Đang đăng nhập!");
            //}
            //if (e.KeyCode == Keys.CapsLock)
            //{
            //    MessageBox.Show("Kiểm tra lại CapsLock");
            //}

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int num = 0;

            if (Int32.TryParse(textBox3.Text, out num))
                lbValue.Text = (num * num).ToString();
            else
                lbValue.Text = "Vui lòng nhập số!";

        }
    }
}
