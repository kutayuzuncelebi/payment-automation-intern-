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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=KUTAY\KUTAY;Initial Catalog=kutay;Integrated Security=True");
        public static int ocak;
        public static string subat;
        public static string mart;
        public static string nisan;
        public static string mayis;
        public static string haziran;
        public static string temmuz;
        public static string agustos;
        public static string eylul;
        public static string ekim;
        public static string kasim;
        public static string aralik;
    


        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label12.Text = Form1.gonderveri;
        {    
                baglanti.Open();
            string sql = "select * from AboneBilgi ";
             SqlCommand verioku= new SqlCommand(sql, baglanti);
           
            SqlDataReader dr = verioku.ExecuteReader();
               
                if (dr.HasRows)
            {
                while (dr.Read()== true)
                {
                    if (label12.Text == Convert.ToString (dr[1]))
                        {
                            label13.Text = Convert.ToString(dr[2]);
                    label14.Text = Convert.ToString(dr[3]);
                    label15.Text = Convert.ToString(dr[4]);
                    label18.Text = Convert.ToString(dr[9]);
                    label19.Text = Convert.ToString(dr[5]);
                    label20.Text = Convert.ToString(dr[6]);
                        }
                    }
                    baglanti.Close();

                }
        }
        {
            baglanti.Open();
            string sqll1 = "select * from Fatura ";
            SqlCommand borcoku = new SqlCommand(sqll1, baglanti);
            SqlDataReader dr1 = borcoku.ExecuteReader();
               
                if (dr1.HasRows)
                    
            {
                while (dr1.Read() == true)
                {
                    if (label12.Text == Convert.ToString(dr1[1]))
                        {
                            label29.Text = Convert.ToString(dr1[2]);
                            label30.Text = Convert.ToString(dr1[3]);
                            label31.Text = Convert.ToString(dr1[4]);
                            label32.Text = Convert.ToString(dr1[5]);
                            label33.Text = Convert.ToString(dr1[6]);
                            label34.Text = Convert.ToString(dr1[7]);
                            label35.Text = Convert.ToString(dr1[8]);
                            label36.Text = Convert.ToString(dr1[9]);
                            label37.Text = Convert.ToString(dr1[10]);
                            label38.Text = Convert.ToString(dr1[11]);
                            label39.Text = Convert.ToString(dr1[12]);
                            label40.Text = Convert.ToString(dr1[13]);


                           
                        }
                        

                    }
                    baglanti.Close();
                }
                
        }
    }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                Form4 f4 = new Form4();
                f4.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public void label12_Click(object sender, EventArgs e)
        {
            label12.Text = Form1.gonderveri;
                   }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Close();
            


        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }
    }
}
