using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Foreach(1234)
        //1-Değişken türü
        //2-Değişken adı
        //3-in (içinden)
        //4-Dizi Adı


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*  string[] rehber = {"Osman","Enes"," Ünal","Emre","Nisa" };
              foreach(string r in rehber )
              {
                  listBox1.Items.Add(r);
              }
            */

            int toplam = 0;
          int [] osman_sayilar = {1,2,3,4,5,6,7,8,9 };

            foreach (int os in osman_sayilar)
            {
                listBox1.Items.Add(os.ToString());
                toplam = toplam + os;

            }
            label1.Text=(toplam.ToString());

            int ortalama = toplam / osman_sayilar.Length;
            label2.Text = ortalama.ToString();



        }
    }
}
