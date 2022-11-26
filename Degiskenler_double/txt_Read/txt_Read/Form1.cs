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
namespace txt_Read
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamReader st = new StreamReader(openFileDialog1.FileName);
                string way = st.ReadLine();
                while (way !=null)
                {
                    listBox1.Items.Add(way);
                    way = st.ReadLine();

                }



            }




        }
    }
}
