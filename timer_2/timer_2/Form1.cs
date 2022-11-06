using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saniye = 0, dakika = 0, saat = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            saniye++;
            label3.Text = saniye.ToString();
            if (saniye == 60)
            {
                dakika++;
                saniye = 0;
                label2.Text = dakika.ToString();
               
            }
            if (dakika == 3)
            {
                saat++;
                label1.Text = saat.ToString();
                dakika = 0;
            }




        }
    }
}
