using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basladim_Not_Ekranı
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
            int sayi1, sayi2, sayi3, ort;

            sayi1 =Convert.ToInt32(textBox1.Text);
            sayi2= Convert.ToInt32(textBox2.Text);
            sayi3=Convert.ToInt32(textBox3.Text);
            ort = (sayi1 + sayi2 + sayi3) / 3;



            if (ort > 50)
            {
                label7.Text = ("Geçtiniz");
            }
            else
            {
                label7.Text = ("Kaldınız");
                    
            }

            label5.Text = (""+ort);


            


            
































        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
