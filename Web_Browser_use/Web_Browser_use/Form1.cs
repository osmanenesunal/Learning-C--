using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser_use
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void myNameIsVendettaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://osmanenesunal.epizy.com/?i=1");


        }

        private void trailerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
