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
    public partial class Qr_Code : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider = Microsoft.JET.OLEDB.4.0; Data Source = PhoneBook.mdb");
        public Qr_Code()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            QRCoder.QRCodeGenerator qRCode = new QRCoder.QRCodeGenerator();
            var MyData = qRCode.CreateQrCode(txtqrname.Text,QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            pictureBox1.Image = code.GetGraphic(50);
           
        }

        private void Qr_Code_Load(object sender, EventArgs e)
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
                dataGridView1.DataSource = dt;
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            {
                txtqrname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtqrsurname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtqrbirthday.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtqrbirthplace.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtqrjob.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtqrphone2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtqrphone1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtqrhousephone.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txtqrjobphone.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                txtqrhomeadress.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                txtqrjobadress.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                txtqremail.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                txtqrwebsite.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();

            }
        }
    }
}
   


