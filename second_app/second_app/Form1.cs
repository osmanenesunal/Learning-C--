using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace second_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Osman Enes";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "Osman";
            label6.Text = "Ünal";
            label8.Text = "Öğrenci";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // textBox1.Text = "Yönetim Bilişim Sistemleri";
            label9.Text =textBox1.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ad1.Text =textBox3.Text;
            ad2.Text = textBox2.Text;
            ad3.Text = textBox4.Text;
        }
    }
}
