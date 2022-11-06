using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Siniflar_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Araba woswos2 = new Araba();

            woswos2.renk = "Siyah";
            woswos2.hiz = 150;
            woswos2.motor = 100.95;
            woswos2.durum = 'i';
            woswos2.fiyat = 35000;



            label1.Text = woswos2.renk;
            label2.Text = woswos2.hiz.ToString();
            label3.Text = woswos2.motor.ToString();
            label4.Text = woswos2.durum.ToString();
            label5.Text = woswos2.fiyat.ToString();
            pictureBox1.BackColor = Color.BlanchedAlmond;






        }
    }
}
