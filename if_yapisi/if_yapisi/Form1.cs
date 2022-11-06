using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_yapisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
           if (textBox1.Text == "Ali")
           {
               label1.Text = ("Doğru");
           }
           else
           {
               label1.Text=("Yanlış Girdiniz");
           }





           int sayi= Convert.ToInt16(textBox1.Text);
           if (textBox1.Text == "5")
           {
               label1.Text=("Doğru");
           }
           else
           {
               label1.Text = "Yanlış";
           }



           int sayi = Convert.ToInt32(textBox1.Text);
           if (sayi % 2==0)
           {
               label1.Text = ("Çifttir");

           }
           else
           {
               label1.Text = ("Tektir");
           }


           int sayi = Convert.ToInt32(textBox1.Text);
           if (sayi % 2==0 && sayi>=10)
           {
               label1.Text=("Sayı Çifttir ve 10dan büyüktüre");
           }
           else
           {
               label1.Text = ("Sayi tektir veya 10dan kücüktür");
           }

     


            if (textBox1.Text==("5"))
            {
                label1.Text = ("Giriş Yapıldı.");
            }
            else
            {
                label1.Text = ("Yanlış kontrol edip bir daha giriniz.");

            }

 

            int sayi = Convert.ToInt32(textBox1.Text);

            if (sayi % 2 == 0)
            {
                label1.Text = ("Çiftir.");
            }
            else
            {
                label1.Text=("Tektir.");
            }


 */


            int sayi = Convert.ToInt32(textBox1.Text);


            if (sayi % 2 == 0 && sayi > 0)
            {
                label1.Text=("Sayı çifttir veya sıfırdan büyüktür");

            }
            else
            {
                label1.Text = ("Sayı tektir veya sıfırdan küçüktür");

            }







        }

    }
}
