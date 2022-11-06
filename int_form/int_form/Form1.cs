using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace int_form
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
            /* int sayi;
            sayi = Convert.ToInt16(textBox1.Text);
            label2.Text = sayi.ToString();
            Sayının Küpünü alan program
             */
            int sayi,kare;
            sayi = Convert.ToInt32(textBox1.Text);
            kare =sayi*sayi*sayi;
            label3.Text = kare.ToString();
           


        }
    }
}
