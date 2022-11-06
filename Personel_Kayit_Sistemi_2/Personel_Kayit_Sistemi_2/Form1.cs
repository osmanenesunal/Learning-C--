using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Personel_Kayit_Sistemi_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=OSMAN\\SQLEXPRESS;Initial Catalog=Personel_Bilgi;Integrated Security=True");
        public void temizle()
        {
            txtperad.Text = "";
            txtmeslek.Text = "";
            txtperid.Text = "";
            txtsoyad.Text = "";
            maskedmaas.Text = "";
            combosehir.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtperad.Focus();



        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personel_BilgiDataSet.tbl_personel' table. You can move, or remove it, as needed.
            

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.tbl_personelTableAdapter.Fill(this.personel_BilgiDataSet.tbl_personel);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand ekle = new SqlCommand("insert into tbl_personel (Perad,Persoyad,Persehir,Permaas,Permeslek,Perdurum) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            ekle.Parameters.AddWithValue("@p1",txtperad.Text);
            ekle.Parameters.AddWithValue("@p2",txtsoyad.Text);
            ekle.Parameters.AddWithValue("@p3",combosehir.Text);
            ekle.Parameters.AddWithValue("@p4",maskedmaas.Text);
            ekle.Parameters.AddWithValue("@p5", txtmeslek.Text);
            ekle.Parameters.AddWithValue("@p6",label8.Text);
            

            ekle.ExecuteNonQuery();

            MessageBox.Show("Kişi Eklenmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            baglanti.Close();




        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                label8.Text = "False";
            } 
            


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label8.Text = "True";
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtperid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtperad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            combosehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedmaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtmeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();



        }

        private void label8_TextChanged(object sender, EventArgs e)
        {


            if (label8.Text == "True")
            {
                radioButton1.Checked = true;
            }


            if (label8.Text == "False")
            {
                radioButton2.Checked = true;
            }

        }
    }
}
