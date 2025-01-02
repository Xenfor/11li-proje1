using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Telefon_Rehberi
{
    public partial class Person_List : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider = Microsoft.JET.OLEDB.4.0; Data Source = PhoneBook.mdb");

        public Person_List()
        {
            InitializeComponent();
        }

        private void Kişi_Listesi_Load(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connect;
                string query = "select * from persons";
                cmd.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                personlistdt.DataSource = dt;
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            DataSet ds = new DataSet();
            OleDbDataAdapter oleDbDataAdapter = new  OleDbDataAdapter("select * from persons where name like +'"+ txtlist.Text+"%'order by name",connect);
            oleDbDataAdapter.Fill(ds, "test");
            personlistdt.DataSource = ds.Tables["test"];
            personlistdt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connect;
                string query = "delete from persons where id='" + txtlist.Text + "'";
                cmd.CommandText = query;
                MessageBox.Show(query);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Veri Silindi");
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
