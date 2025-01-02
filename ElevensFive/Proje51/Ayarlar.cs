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
namespace bprogram1
{
    public partial class Ayarlar : Form
    {
        
        public Ayarlar()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        public void kisiler()
        {
            

        }

        public void ekleme()
        {
            
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
             
            
            
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            
            SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP - 52GH07A\\SQLEXPRESS; Initial Catalog = bilgiler; Integrated Security = True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into musteri values(@adsoyad,@tc,@telno)", baglanti);
            komut.Parameters.AddWithValue("@adsoyad",textBox2.Text);
            komut.Parameters.AddWithValue("@tc", textBox3.Text);
            komut.Parameters.AddWithValue("@telno", textBox4.Text);
                komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
