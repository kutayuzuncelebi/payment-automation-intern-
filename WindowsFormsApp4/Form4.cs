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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=KUTAY\KUTAY;Initial Catalog=kutay;Integrated Security=True");

        

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "insert into İhbar(AboneNo,Şehir,İlçe,Mahalle,Sokak,Adres,İhbarTürü) values(@abone,@sehir,@ilce,@mahalle,@sokak,@adres,@ihbar)";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            
            komut.Parameters.AddWithValue("@abone", textBox1.Text);
            komut.Parameters.AddWithValue("@sehir", textBox2.Text);
            komut.Parameters.AddWithValue("@ilce", textBox3.Text);
            komut.Parameters.AddWithValue("@mahalle", textBox5.Text);
            komut.Parameters.AddWithValue("@sokak", textBox6.Text);
            komut.Parameters.AddWithValue("@adres", textBox4.Text);
            komut.Parameters.AddWithValue("@ihbar", textBox7.Text);
            komut.ExecuteNonQuery();
           
            baglanti.Close();
            MessageBox.Show("İhbar Kayıdınız İşleme Alınmıştır");
                                             
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            textBox1.Text = Form1.gonderveri;
        }
    }
}
