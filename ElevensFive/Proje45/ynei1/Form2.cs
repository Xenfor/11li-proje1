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


namespace ynei1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        static string con = "Data Source = DESKTOP-52GH07A\\SQLEXPRESS;Initial Catalog=ynei1;Integrated Security= True";
        SqlConnection cmd = new SqlConnection(con);
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (cmd.State == ConnectionState.Closed)
            {
                cmd.Open();
            }
            string sql = "select * from giris1";
            SqlDataAdapter sqldata = new SqlDataAdapter(sql, cmd);
            DataSet ds = new DataSet();
            sqldata.Fill(ds, "giris1");
            string a = textBox1.Text;
            string b = textBox2.Text;
            string c = textBox3.Text;
            string kayit = "insert into giris1 (AdSoyad,Sinif,Numara) values(@Adsoyad,@Sinif,@Numara)";
            SqlCommand komut = new SqlCommand(kayit, cmd);
            komut.Parameters.AddWithValue("@Adsoyad", a);
            komut.Parameters.AddWithValue("@Sinif",b);
            komut.Parameters.AddWithValue("@Numara", c);
            komut.ExecuteNonQuery();
            cmd.Close();
            DialogResult msg = new DialogResult();
            msg= MessageBox.Show("Kaydedildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            
            if (msg == DialogResult.OK)
            {
                this.Close();
                
            }
            
        }
    }
}
