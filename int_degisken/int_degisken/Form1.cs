using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace int_degisken
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
            //  int sayi;
            //sayi = 23;
            //label1.Text = sayi.ToString();
            /*  int sayi1, sayi2, toplam;
              sayi1 = 11;
              sayi2 = 21;
              toplam = sayi1 + sayi2;
              label1.Text = toplam.ToString();
            */
            /* int alan, cevre, kenar;
             kenar = 10;
             alan = kenar * kenar;
             cevre = kenar * 4;
             label1.Text = "Alan : " +alan+"  Çevre  :" + cevre;
            */

            int sinav1, sinav2, sinav3,ortalama;

            sinav1 = 30;
            sinav2 = 45;
            sinav3 = 65;
            ortalama = (sinav1 + sinav2 + sinav3) / 3;

            label1.Text="İlk Sınavınız  :"+sinav1+"  İkinci Sınavınız  :"+sinav2+"  Son Sınavınız  :"+sinav3+"  Ortalamanız  :"+ortalama;







        }
    }
}
