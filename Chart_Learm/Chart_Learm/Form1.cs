using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart_Learm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            Kitap.Series["Kitap"].Points.AddXY("Manisa",5);
            Kitap.Series["Kitap"].Points.AddXY("İzmir",10);
            Kitap.Series["Kitap"].Points.AddXY("Ankara",6);
    


        }
    }
}
