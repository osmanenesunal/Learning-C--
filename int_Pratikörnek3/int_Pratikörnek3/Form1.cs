using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace int_Pratikörnek3
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
            int sayi1, sayi2, toplam, fark, carpma, bolme;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox1.Text);
            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            carpma = sayi1 * sayi2;
            bolme = sayi1 / sayi2;
            MessageBox.Show(" Toplam :" + toplam + "\n Çıkartma :" + fark + "\n Çarpma :" + carpma + " \n Bölme :" + bolme);

            // ctrl + k + d kodu düzenliyor 
        }
    }
}
