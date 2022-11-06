using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siniflar_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba woswos =new Araba();

            woswos.renk = "MAVİ";
            woswos.hiz = 210;
            woswos.motor = 1543.45;
            woswos.durum = 'Y';
            woswos.fiyat = 2500000;
            woswos.YIL = -2018;
            woswos.MARKA = "woswos";
            woswos.plaka = "45 ZB 7202";
            woswos.muayene = 2022;
            woswos.sahip = "Osman Enes Ünal";

            label1.Text = woswos.renk;
            label2.Text = woswos.hiz.ToString();
            label3.Text = woswos.motor.ToString();
            label4.Text = woswos.durum.ToString();
            label5.Text = woswos.fiyat.ToString();
            label6.Text = woswos.YIL.ToString();
            label7.Text = woswos.MARKA;
            label8.Text = woswos.plaka;
            label9.Text = woswos.muayene.ToString();
            label10.Text = woswos.sahip;


            pictureBox1.BackColor = Color.BlueViolet;









        }
    }
}
