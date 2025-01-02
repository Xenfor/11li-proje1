using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace bprogram1
{
    class Class1
    {
        public void sqlbaglanti()
        {
            string con = "Data Source=DESKTOP-52GH07A\SQLEXPRESS;Initial Catalog=bilgiler;Integrated Security=True";
            SqlConnection connect = new SqlConnection(con);
            string sql = "select * from 001";
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connect);

            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "001");
            string a = Interaction.InputBox("Ad", "Giriş", "");
            string b = Interaction.InputBox("Soyad ", "Giriş", "0");
            string c = Interaction.InputBox("Telno", "Giriş", "");

            string kayit = "insert into 001 (Ad,Soyad,Telno) values(@Ad,@Soyad,@Telno)";
            SqlCommand komut = new SqlCommand(kayit, connect);


            komut.Parameters.AddWithValue("@Ad", a);
            komut.Parameters.AddWithValue("@Soyad", b);
            komut.Parameters.AddWithValue("@Telno", c);

            dataGridView1.DataSource = komut;



            komut.ExecuteNonQuery();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "001";
            connect.Close();
        }
    }
}
