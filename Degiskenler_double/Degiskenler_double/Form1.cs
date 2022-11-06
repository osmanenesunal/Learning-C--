using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_double
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*  double sayi;
              sayi = 4.26;
              label1.Text = sayi.ToString();
            

            double s1, s2, s3, ortalma;
            s1 = 45;
            s2 = 55;
            s3 = 57;
            ortalma = (s1 + s2 + s3) / 3;
            label1.Text = ortalma.ToString("0.00");

            */

            double sayi;
            sayi = Convert.ToDouble(textBox1.Text);
            label1.Text = sayi.ToString("0.00");




        }
    }
}
