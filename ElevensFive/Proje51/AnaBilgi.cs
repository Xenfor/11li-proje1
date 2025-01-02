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
    public partial class AnaBilgi : Form
    {
        public AnaBilgi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu f2 = new Menu();
            f2.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP - 52GH07A\\SQLEXPRESS; Initial Catalog = bilgiler; Integrated Security = True");
        DataSet daset = new DataSet();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kayit_goruntuleme();
        }
        public void kayit_goruntuleme()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from musteri", baglanti);
            adtr.Fill(daset, "musteri");
            
            dataGridView1.DataSource = daset;
            dataGridView1.DataMember = "musteri";
            baglanti.Close();
        }
    }
}
