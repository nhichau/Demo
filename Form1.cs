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
    public partial class Formbutton : Form
    {
        public Formbutton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Nhấp vào tôi";
            //button1.Image = Image.FromFile("C:\\Users\\ADMIN\\OneDrive\\Desktop\\save.jpg");
            button1.BackColor = Color.Green; //Màu sắc nằm trong Class Color
            //this.BackColor = Color.Blue;//màu nền của form luôn
            this.BackColor = Color.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Formbutton_Load(object sender, EventArgs e)
        {
            button3.Text = "Nhấp chuột vào đây";
            Button b = new Button();
            b.Click += new EventHandler(ShowMessage);
            Controls.Add(b);

        }
        private void ShowMessage(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã nhấp chuột vào Button");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("https://csharpcanban.com");
        }
    }
}
