using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Sembol1 = {"a","b","c","d","e","f","g","j" };
            string[] Sembol2 = { "+", "-", "*", "/", "#" };
            string[] Sembol3 = {"A","B","C","D","E","F","G","J" };

            Random rs = new Random();

            int s1, s2, s3,s4;

            s1 = rs.Next(Sembol1.Length);
            s2 = rs.Next(Sembol2.Length);
            s3 = rs.Next(Sembol3.Length);
            s4 = rs.Next(1,11);

            label1.Text= Sembol1[s1].ToString()+Sembol2[s2].ToString()+Sembol3[s3].ToString()+s4.ToString();




          







        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text==label1.Text)
            {
                MessageBox.Show("Doğru","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Yanlış","Bilgi",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
            }

        }
    }
}
