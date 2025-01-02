using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable tablo = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("ID", typeof(int));
            tablo.Columns.Add("GİDER", typeof(string));
            tablo.Columns.Add("TUTAR", typeof(int));
            dataGridView1.DataSource = tablo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablo.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
            dataGridView1.DataSource = tablo;
            //Sütun değerlerini toplama
            int toplam = 0;//www.yazilimkodlama.com
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            label1.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Lüffen silinecek satırı seçin.");
            }
        }
    }
}
