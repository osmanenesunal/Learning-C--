using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme__time
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
            timer1.Start();
        }
        int sayi = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayi++;
            label1.Text = sayi.ToString();

            if (sayi == 10)
            {
                 
                this.BackColor = Color.Tan;
        
               

            }

            if(sayi == 20 )
            {
                this.BackColor = Color.AliceBlue;



            }
            if(sayi == 30 )
            {
                this.BackColor = Color.MediumSeaGreen;


            }
            if (sayi== 40 )
            {
                sayi = 0;


            }


        }
    }
}
