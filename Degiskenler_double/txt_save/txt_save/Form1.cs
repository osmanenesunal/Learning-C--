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
namespace txt_save
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Filename|*.txt";
            saveFileDialog1.Title = "File Save Place ";
            saveFileDialog1.ShowDialog();

          StreamWriter st = new StreamWriter(saveFileDialog1.FileName);
            st.WriteLine(richTextBox1.Text); 
            st.Close();
            MessageBox.Show("Done");

           



        }
    }
}
