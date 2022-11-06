using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Metot;Komutları  bir araya toplayan yapılar
        //Public 
        //Private  
        //-------------------------------- 
        //Geriye değer döndüren
        //Geriye değer döndürmeyen
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
        void color()
        {
            textBox1.BackColor = Color.Aqua;
            textBox2.BackColor = Color.Bisque;
            textBox3.BackColor = Color.Coral;
            textBox4.BackColor = Color.OliveDrab;

        }
        private void clear2()
        {
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox5.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            color();
        }


        void writer()
        {
            textBox5.Text = "Osman Enes";
            textBox6.Text = "Ünal";
            textBox7.Text = "Manisa";
            textBox8.Text = "20";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            writer();
        }

        

        
        private void button4_Click(object sender, EventArgs e)
        {
            clear2();
        }
    }
}
