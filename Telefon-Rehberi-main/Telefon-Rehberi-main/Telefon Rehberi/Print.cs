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
using PagedList;

namespace Telefon_Rehberi
{

    public partial class Print : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider = Microsoft.JET.OLEDB.4.0; Data Source = PhoneBook.mdb");

        public Print()
        {
            InitializeComponent();
        }
        

        private void Print_Load(object sender, EventArgs e)
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
                datagridprint.DataSource = dt;
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex);
            }
        }
        Bitmap bitmap;
        private void btnprevious_Click_1(object sender, EventArgs e)
        {
            int height = datagridprint.Height;
            datagridprint.Height = datagridprint.RowCount * datagridprint.RowTemplate.Height * 2;
            bitmap = new Bitmap(datagridprint.Height, datagridprint.Width);
            datagridprint.DrawToBitmap(bitmap, new Rectangle(0, 0, datagridprint.Width, datagridprint.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            datagridprint.Height = height;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 50, 50);
        }
    }
}
