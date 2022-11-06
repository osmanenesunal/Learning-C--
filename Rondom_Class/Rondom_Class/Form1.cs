using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rondom_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();

            int s1, s2, s3, s4, s5;
            s1 = rastgele.Next(1,100);
            s2 = rastgele.Next(1, 100);
            s3 = rastgele.Next(1,100);
            s4 = rastgele.Next(1,100);
            s5 = rastgele.Next(1,100);


            label1.Text = s1.ToString();
            label2.Text = s2.ToString();
            label3.Text = s3.ToString();
            label4.Text = s4.ToString();
            label5.Text = s5.ToString();



        }
    }
}
