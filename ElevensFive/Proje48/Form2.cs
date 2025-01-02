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

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        static string conString = "Data Source=DESKTOP-52GH07A\\SQLEXPRESS;Initial Catalog=bilgiler;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);
        private void verikayit()
        {
            
            string kayit = "insert into musteri values(@Adsoyad,@Telno,@aracplaka,@firmaismi,@vergidairesi,@vergino,@adress)";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@Adsoyad",textBox7.Text);
            komut.Parameters.AddWithValue("@Telno", textBox1.Text);
            komut.Parameters.AddWithValue("@aracplaka", textBox2.Text);
            komut.Parameters.AddWithValue("@firmaismi", textBox3.Text);
            komut.Parameters.AddWithValue("@vergidairesi", textBox4.Text);
            komut.Parameters.AddWithValue("@vergino", textBox5.Text);
            komut.Parameters.AddWithValue("@adress", textBox6.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            
            SqlDataAdapter da = new SqlDataAdapter("select *from musteri",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            verikayit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            string kayit = "delete from musteri where Adsoyad = @Adsoyad";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@Adsoyad", textBox1.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter("select *from musteri", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

    }
}
