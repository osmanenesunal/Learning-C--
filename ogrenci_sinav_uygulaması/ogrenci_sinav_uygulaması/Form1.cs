using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenci_sinav_uygulaması
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

            string ad, soyad;
            int sayi1, sayi2,proje;
            double ortalama;
            ad = textBox1.Text;
            soyad = textBox2.Text;

            sayi1 = Convert.ToInt32(textBox3.Text);
            sayi2 = Convert.ToInt32(textBox5.Text);
            proje = Convert.ToInt32(textBox4.Text);
            ortalama = (sayi1 + sayi2 + proje)/3;

            listBox1.Items.Add(" ADI: " + ad + " Soyadı: " + soyad + "  İlk Notunuz:  " + sayi1 + "  İkinci Notunuz:  " + sayi2+"  Proje Notunuz:  "+proje+" Ve ORTALAMANIZ  "+ortalama    );


            MessageBox.Show("Ad: " + ad + "\n Soyad: " + soyad + "\n Ortalamanız: " + ortalama);




        } 
    }
}
