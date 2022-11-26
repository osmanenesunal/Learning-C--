using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace text_create
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filename, filepath;
        StreamReader sw;

        private void button2_Click(object sender, EventArgs e)
        {
            filename = textBox2.Text;
            sw = File.CreateText(filepath + "\\" + filename + ".txt");
            sw.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                filepath = folderBrowserDialog1.SelectedPath.ToString();
                textBox1.Text=filepath;

            }







        }
    }
}
