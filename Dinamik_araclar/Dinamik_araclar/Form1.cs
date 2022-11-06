using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinamik_araclar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point pnt = new Point(20,10);
            btn.Location = pnt;
            btn.Name = "Button1";
            btn.Text = "Tıkla";
            btn.BackColor = Color.Gray;
            btn.Height = 30;
            btn.Width = 50; 
            this.Controls.Add(btn);



            Label lbl = new Label();
            Point lbllocation = new Point(100,10);
            lbl.Location = lbllocation;
            lbl.Text = "Osman";
            lbl.Name = "Label";
            lbl.BackColor = Color.Red;
            lbl.Height = 30;
            lbl.Width = 31;
            lbl.AutoSize = true;
            this.Controls.Add(lbl);


            for (int i = 0; i < 5; i++)
            {  
                TextBox txt = new TextBox();
                Point txtloca = new Point(200,i * 30);
                txt.Location = txtloca;
                txt.Name ="Textbox"+ i;
                txt.Text = i.ToString();
                
                this.Controls.Add(txt);


            }








































        }
    }
}
