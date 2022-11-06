using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Birbiriyle ilişkili veri kümesi
        //dizilr bellekte tutul köşşeli parantezle yazılır ram de tutulur ilk indexsi sıfırdır 
        private void button1_Click(object sender, EventArgs e)
        {
            //string[]    rehber={"Osman","Enes","Ünal" } ;

            //label1.Text = rehber[1];







            int[] sayiler = {1,2,3,4,5,6,7,8 };

            label1.Text = sayiler[1].ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {

            string[] sehirler = {"Manisa","İZMİR","ANKARA","İSTANBUL" };

            for (int i = 0; i < sehirler.Length; i++ )
            {
                listBox1.Items.Add(sehirler[i]);


            }



        }
    }
}
