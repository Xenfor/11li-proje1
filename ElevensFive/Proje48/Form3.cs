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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-52GH07A\\SQLEXPRESS;Initial Catalog=bilgiler;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);
        #region kayıt
        private void button2_Click(object sender, EventArgs e)
        {

            //try
            //{
                
                if (textBox3.Text == "0")
                {
                    string kayit = "insert into mahsup(no,tarih,hesapadi,aciklama,alacak) values(@no,@tarih,@hesapadi,@aciklama,@alacak)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@no", textBox4.Text);
                    komut.Parameters.AddWithValue("@tarih", textBox5.Text);
                    komut.Parameters.AddWithValue("@hesapadi", textBox1.Text);
                    komut.Parameters.AddWithValue("@aciklama", textBox2.Text);
                    komut.Parameters.AddWithValue("@alacak", textBox7.Text);
                //SELECT ISNULL(myColumn, 0 ) FROM myTable
                    
                    
                    baglanti.Open();
                    string sifirsa = "select isnull(borc,0) from mahsup";
                    SqlCommand komut2 = new SqlCommand(sifirsa, baglanti);
                    komut2.ExecuteNonQuery();
                    komut.ExecuteNonQuery();
                    
                    SqlDataAdapter da = new SqlDataAdapter("select no,tarih,hesapadi,aciklama,isnull(borc,0),isnull(alacak,0) from mahsup", baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    baglanti.Close();
            }
                else if(textBox7.Text == "0")
                {
                    string kayit = "insert into mahsup(no,tarih,hesapadi,aciklama,borc) values(@no,@tarih,@hesapadi,@aciklama,@borc)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@no", textBox4.Text);
                    komut.Parameters.AddWithValue("@tarih", textBox5.Text);
                    komut.Parameters.AddWithValue("@hesapadi", textBox1.Text);
                    komut.Parameters.AddWithValue("@aciklama", textBox2.Text);
                    komut.Parameters.AddWithValue("@borc", textBox3.Text);
                    baglanti.Open();
                    
                    komut.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter("select no,tarih,hesapadi,aciklama,isnull(borc,0),isnull(alacak,0) from mahsup", baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    baglanti.Close();
                }
            temizle();
            label7.Text = bakiye();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Bir şeyler yanlış gitti!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

        }
        #endregion
        void temizle()
        {
            
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();

        }
        #region sil
        private void button3_Click(object sender, EventArgs e)
        {
            string kayit = "delete  from mahsup where no = @no";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@no", textBox4.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter("select no as NO, tarih as TARİH,hesapadi as HESAPADI,aciklama as AÇIKLAMA,isnull(borc,0),isnull(alacak,0) from mahsup", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            temizle();
            label7.Text = bakiye();
        }
        #endregion
        #region bos
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string kayit = "delete from mahsup where no = @no";
            //SqlCommand komut = new SqlCommand(kayit, baglanti);
            //komut.Parameters.AddWithValue("@no", dataGridView1.SelectedRows);
            //baglanti.Open();
            //komut.ExecuteNonQuery();

            //SqlDataAdapter da = new SqlDataAdapter("select *from mahsup", baglanti);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //baglanti.Close();
        }
        #endregion
        #region goruntule aktarma
        private void button4_Click_1(object sender, EventArgs e)
        {
            goruntel3();

            goruntele goruntule = new goruntele();
            goruntule.Show();
            
        }
        #endregion
        #region gorutule
        public string lbl7;
        void goruntel3()
        {
            baglanti.Open();
            DataTable dt = new DataTable();
           
            
            //if (textBox6.Text == "")
            //{
                SqlDataAdapter da = new SqlDataAdapter("select no,tarih,hesapadi,aciklama,isnull(borc,0),isnull(alacak,0) from mahsup", baglanti);
                dataGridView1.DataSource = dt;
                da.Fill(dt);
               
            //}
            //else
            //{
            //    string kayit = "select no,tarih,hesapadi,aciklama,isnull(borc,0),isnull(alacak,0) from mahsup where hesapadi=@hesapadi";
            //    SqlCommand komut = new SqlCommand(kayit, baglanti);
            //    komut.Parameters.AddWithValue("@hesapadi", textBox6.Text);
            //    SqlDataAdapter da = new SqlDataAdapter(komut);

            //    da.Fill(dt);
            //    dataGridView1.DataSource = dt;
            //}
            baglanti.Close();

            //4,5,1,2,3,7

            label7.Text = bakiye();
        }
        #endregion
        
        public string bakiye()
        {//bakiye hesaplama
            int topborc = 0;
            int topalacak = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                //if (dataGridView1.Rows[i].Cells[4].Value == null)
                //{
                topborc += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                //}
            }

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                topalacak += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
            }
            string aa= (topborc - topalacak).ToString();
            return aa;
            
        }
    }
}
