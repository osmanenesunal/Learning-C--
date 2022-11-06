using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            int sayi1, sayi2, toplam, cıkarma, bolme, carpma;

            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            string islem = textBox3.Text;


            toplam = sayi1 + sayi2;
            cıkarma = sayi1 - sayi2;
            bolme = sayi1 / sayi2;
            carpma = sayi1 * sayi2;





            switch (islem)
            {
                case "+": label6.Text = "" + toplam; break;
                case "-": label6.Text = "" + cıkarma; break;
                case "/": label6.Text = "" + bolme; break;
                case "*": label6.Text = "" + carpma; break;

                default:
                    label6.Text = "Lütfen doğru değer girin":
                    break;
            }



        }
    }
}
