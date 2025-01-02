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
    public partial class FurkanParlak : Form
    {
        public FurkanParlak()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP - 52GH07A\\SQLEXPRESS; Initial Catalog = bilgiler; Integrated Security = True");
        
        private void kayitGetir()
        {
            baglanti.Open();
            string kayit = "SELECT * from musteri";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            kayitGetir();
            
        }

        private void FurkanParlak_Load(object sender, EventArgs e)
        {
            
        }
    }
}
