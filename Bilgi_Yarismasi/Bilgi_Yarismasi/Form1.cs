using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void BtnA_Click(object sender, EventArgs e)
        {
            label5.Text = BtnA.Text;

            if (label4.Text==BtnA.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }

            else
            {
                yanlis++;
                LblYanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }



        }

        private void BtnSonra_Click(object sender, EventArgs e)
        {

            soruno++;

            LblSoruNo.Text=soruno.ToString();

            if (soruno==1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir ? ";
                BtnA.Text = "1932";
                BtnB.Text = "1922";
                BtnC.Text = "1924";
                BtnD.Text="1923";
                label4.Text = "1923";


            }


            if (soruno==2)
            {
                richTextBox1.Text = "Hangi il Ege bölgemizde bulunmaz ?";
                BtnA.Text = "Aydın";
                BtnB.Text = "Balıkkesir";
                BtnC.Text = "Manisa";
                BtnD.Text = "İzmir";
                label4.Text = "Balıkkesir";
            }


            if (soruno == 3)
            {
                richTextBox1.Text = "2+2 Kaçtır?";
                BtnA.Text = "4";
                BtnB.Text = "5";
                BtnC.Text = "2";
                BtnD.Text = "3";
                label4.Text = "4";
            }



        }
    }
}
