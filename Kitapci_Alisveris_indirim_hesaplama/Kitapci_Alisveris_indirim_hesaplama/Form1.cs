using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitapci_Alisveris_indirim_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kitapadeti;
            double toplam;


            kitapadeti =Convert.ToInt32(textBox1.Text);


            if (kitapadeti >= 0 && kitapadeti <=20)
            {
                toplam = (kitapadeti * 8) - (kitapadeti * 8 * 0.20);

                label3.Text = toplam + "tl";


            }


            if (kitapadeti >= 21 && kitapadeti <= 40)
            {
                toplam = (kitapadeti * 8) - (kitapadeti * 8 * 0.40);
                label3.Text = toplam + "tl";



            }






            if (kitapadeti >= 41)
            {
                toplam = (kitapadeti * 8) - (kitapadeti * 8 * 0.50);


                label3.Text = toplam + "tl";

            }






        }
    }
}
