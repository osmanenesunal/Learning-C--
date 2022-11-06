using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switch_case
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

           int ay= Convert.ToInt32(textBox1.Text);



            switch (ay)
            {
                case 1:label2.Text = "Ocak"; break;
                case 2:label2.Text = "Şubat"; break;
                case 3: label2.Text = "Mart"; break;
                case 4: label2.Text = "Nisan"; break;
                case 5: label2.Text = "Mayıs"; break;
                case 6: label2.Text = "Haziran"; break;
                case 7: label2.Text = "Temmuz"; break;
                case 8: label2.Text = "Ağustos"; break;
                case 9: label2.Text = "Eylül"; break;
                case 10: label2.Text = "Ekim"; break;
                case 11: label2.Text = "Kasım"; break;
                case 12: label2.Text = "Aralık"; break;










                default:
                    label2.Text ="Böyle Bir AY yoktur";
                    break;
            }




           



            string mevsim = textBox1.Text;

            switch (mevsim)
            {
                case "yaz": label2.Text = "Haziran , temmuz, ağustos";  break;

                case "kış": label2.Text = "Ocak ,  Aralık, Şubat"; break;

                case "Sonbahar": label2.Text = "Eylül ekim kasım"; break;
                case "İlkbaharr": label2.Text = "Mart nisan mayıs"; break;






                default: label2.Text ="Hatalı mevsim";

                    break;
            }



 */
            //Klavyeden değere göre bulma ready:)














        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2,toplam, cıkarma,bolme ,carpma ;

           sayi1 =  Convert.ToInt32(textBox2.Text);
           sayi2 =   Convert.ToInt32(textBox3.Text);
           string islem = textBox4.Text;


            toplam = sayi1 + sayi2;
            cıkarma = sayi1 - sayi2;
            bolme = sayi1 / sayi2;
            carpma = sayi1 * sayi2;





            switch (islem)
            {
                case "+": label6.Text ="" + toplam ; break;
                case "-": label6.Text = "" + cıkarma;break;
                case "/": label6.Text = "" + bolme;break;
                case "*": label6.Text = "" + carpma;break;

                default: label6.Text = "Lütfen doğru değer girin":
                    break;
            }








        }
    }
}
