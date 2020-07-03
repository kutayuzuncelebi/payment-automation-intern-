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

namespace WindowsFormsApp4
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=KUTAY\KUTAY;Initial Catalog=kutay;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "insert into Faturaİtiraz(AboneNo,Ay,Sebep) values(@abone,@ay,@sebep)";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@abone", textBox2.Text);
            komut.Parameters.AddWithValue(@"ay", textBox3.Text);
            komut.Parameters.AddWithValue("@sebep", textBox1.Text);
            komut.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Fatura İtirazınız İşleme Alınmıştır");


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox2.Text = Form1.gonderveri;
        }
    }
}
