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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public static class FormManager
        {
            public static void OpenNewForm2()
            {
                Form2 f = new Form2();
                f.Show();
            }
            
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=KUTAY\KUTAY;Initial Catalog=kutay;Integrated Security=True");
        public static string gonderveri;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void giris_Click(object sender, EventArgs e)
        {

            try
            {

                baglanti.Open();
                string sql = "Select * from Abone where AboneNo=@adi AND Şifre=@sifresi";
                SqlParameter prm1 = new SqlParameter("adi", textBox1.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", textBox2.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    gonderveri = textBox1.Text;
                    FormManager.OpenNewForm2();
                    this.Hide();
                    
                    

                }





            }
            catch (Exception)
            {

                MessageBox.Show("Hatali giris");
                Application.Restart();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            {
                //checkBox işaretli ise
                if (checkBox1.Checked)
                {
                    //karakteri göster.
                    textBox2.PasswordChar = '\0';
                }
                //değilse karakterlerin yerine * koy.
                else
                {
                    textBox2.PasswordChar = '*';
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kadi_Click(object sender, EventArgs e)
        {

        }

        private void sifre_Click(object sender, EventArgs e)
        {

        }
    }
}

