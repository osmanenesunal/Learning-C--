﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PDF_READER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            OpenFileDialog ofp = new OpenFileDialog();

            if (ofp.ShowDialog()==DialogResult.OK)
            {
                axAcroPDF1.LoadFile(ofp.FileName);


            }



        }
    }
}
