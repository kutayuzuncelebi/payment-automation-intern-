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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection(@"Data Source=KUTAY\KUTAY;Initial Catalog=kutay;Integrated Security=True");
        int bakiyem;
        
        public int bakiyegetir(int mno)
        {
            baglanti.Open();
            int musteribakiye = 0;
            string sql1 = "select*from KrediKartı where AboneNo=" + mno + "";
            SqlCommand verioku = new SqlCommand(sql1, baglanti);
            SqlDataReader dr = verioku.ExecuteReader();
            while (dr.Read())
            {
                musteribakiye = Convert.ToInt32(dr[6]);
                bakiyem = musteribakiye;

            }
            baglanti.Close();
            
            return musteribakiye;
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox6.Text = Form1.gonderveri;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mno = Convert.ToInt32(textBox6.Text);
            int cekilen = Convert.ToInt32(textBox5.Text);

            int mbakiye = bakiyegetir(mno);
            if (textBox6.Text != Form1.gonderveri)
            {
                MessageBox.Show("Lütfen Kendi Abone Numaranızı Giriniz.");
            }
            else
            {
                if (mbakiye >= cekilen)
                {
                    baglanti.Open();
                    string sorgu = "Update KrediKartı Set Bakiye=(Bakiye-@cekilen) where AboneNo=@abone";
                    SqlCommand cmd = new SqlCommand(sorgu, baglanti);
                    cmd.Parameters.AddWithValue("@cekilen", cekilen);
                    cmd.Parameters.AddWithValue("@abone", Convert.ToInt32(textBox6.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ödeme Başarıyla Yapıldı. ---->" + "Kalan Bakiyeniz : " + (bakiyem - cekilen));
                    baglanti.Close();
                   


                }
                else
                {
                    MessageBox.Show("Yetersiz Bakiye.");
                }
            }

                        

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
