using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Büfe_Satiş_Uygulamasi
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        int kasa = 0;
        private void label11_Click(object sender, EventArgs e)
        {
           






        }

        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, gozluk, cay, bilet, toplam;
            misir = Convert.ToInt16(misir_txt.Text);
            su = Convert.ToInt16(su_txt.Text);
            gozluk = Convert.ToInt16(goz_txt.Text);
            cay = Convert.ToInt16(cay_txt.Text);
            bilet = Convert.ToInt16(bilet_txt.Text);
            toplam = misir * 12 + su * 1 + gozluk * 25 + cay * 5 + bilet * 30;
            toplm.Text = toplam.ToString()+"  TL ";

            kasa = kasa + toplam;
            label12.Text = kasa.ToString() + " TL ";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            misir_txt.Text = "";
            su_txt.Text = "";
            goz_txt.Text = "";
            cay_txt.Text = "";
            bilet_txt.Text = "";

            misir_txt.Focus();





        }
    }
}
