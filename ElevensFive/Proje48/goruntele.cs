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
    public partial class goruntele : Form
    {
        public goruntele()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-52GH07A\\SQLEXPRESS;Initial Catalog=bilgiler;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable dt = new DataTable();
            if (textBox1.Text == "")
            {
                //SqlDataAdapter da = new SqlDataAdapter("select no,tarih,hesapadi,aciklama,isnull(borc,0),isnull(alacak,0) from mahsup", baglanti);
                SqlDataAdapter da = new SqlDataAdapter("select distinct tarih as TARİH, no as NO,hesapadi as HESAPADI,aciklama as AÇIKLAMA ,borc as BORÇ, alacak as ALACAK from mahsup", baglanti);
                dataGridView1.DataSource = dt;
                da.Fill(dt);
                
            }
            else
            {
                string kayit = "select distinct tarih as TARİH, no as NO,hesapadi as HESAPADI,aciklama as AÇIKLAMA, alacak as ALACAK,borc as BORÇ  from mahsup where hesapadi=@hesapadi";
                
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@hesapadi", textBox1.Text);
                SqlDataAdapter da = new SqlDataAdapter(komut);

                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            baglanti.Close();
            //4,5,1,2,3,7

            Form3 f3 = new Form3();
            label2.Text = f3.lbl7;
            
            
        }
    }
}
