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
    public partial class FormMessageBox : Form
    {
        public FormMessageBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Dạng thông báo đơn giản:
            MessageBox.Show("Bạn đã nhấp vào tôi");
            

        }

        private void FormMessageBox_Load(object sender, EventArgs e)
        {
           
                            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Dạng thông báo có tiêu đề:
            MessageBox.Show("you touched me", "Warning");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("you touched me", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            if (kq == DialogResult.Retry)
            {
                txtThongBao.Text = "You knew me";
                return;
            }
            if (kq == DialogResult.Cancel)
            {
                txtThongBao.Text = "You don't know me. So let go to me!! ^.^ \r\nWebsite: huygamer.wordpress.com";
                return;
            }

        }

        private void txtThongBao_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("you touched me", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            switch (kq)
            {
                case DialogResult.OK:
                    {
                        this.Text = "Thanks";//tên của form sẽ thành Thanks
                        break;
                    }
                case DialogResult.Cancel:
                    {
                        this.Text = "Again";
                        break;
                    }
             
                
            }
                

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Chọn Yes No?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();//khi chọn yes sẽ nhảy xuống FormClosing
            }

        }

        private void FormMessageBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Cancel)
            {
                // this.Close();
                e.Cancel = true;
            }
        }
    }
}
