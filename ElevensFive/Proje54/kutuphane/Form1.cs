using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace kutuphane
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        static string con = "Data Source=DESKTOP-52GH07A\\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True";
        SqlConnection connect = new SqlConnection(con);
        int z = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            z++;
            if (z == 2)
            {
                this.Close();
            }



            if (connect.State == ConnectionState.Closed)
                connect.Open();
            string sql = "select * from Bilgi";
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connect);

            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "Bilgi");
            string a = Interaction.InputBox("Ad Soyad", "Giriş", "");
            string b = Interaction.InputBox("Numara", "Giriş", "0");
            string c = Interaction.InputBox("Kitap", "Giriş", "");

            string kayit = "insert into Bilgi (AdSoyad,Numara,Kitap) values(@AdSoyad,@Numara,@Kitap)";
            SqlCommand komut = new SqlCommand(kayit, connect);


            komut.Parameters.AddWithValue("@AdSoyad", a);
            komut.Parameters.AddWithValue("@Numara", b);
            komut.Parameters.AddWithValue("@Kitap", c);

            dataGridView1.DataSource = komut;



            komut.ExecuteNonQuery();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Bilgi";
            connect.Close();

            MessageBox.Show("muq", "eyyo", MessageBoxButtons.OK);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm2 = new Form ();
            frm2.Location = new System.Drawing.Point(100, 100);
            frm2.Size = new System.Drawing.Size(100, 100);
            Label lbl1 = new Label
            {
                Location = new System.Drawing.Point(0,0)
            };
            
        }
    }
}
