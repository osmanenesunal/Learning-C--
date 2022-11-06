using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kup_metod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     int kup(int sayi)
        {
            int sonuc = sayi * sayi * sayi;
            return (sonuc);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hesapla = Convert.ToInt32(textBox1.Text);
            label1.Text = kup(hesapla).ToString();
            



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

            int Topla(int s1, int s2)
            {
              int s3 = s1 + s2;
              return s3;
 

            }

        private void button2_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(textBox2.Text);
            int c2 = Convert.ToInt32(textBox3.Text);
            label2.Text = Topla(c, c2).ToString();






        }
    }
}
