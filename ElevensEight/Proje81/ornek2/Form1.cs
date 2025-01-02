using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ornek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            MessageBox.Show("bI SıKInTı Mı vAr", "HeY dOsTUm", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            string message = "Pencereyi Kapatmak istermisin";
            string title = "Kapat la pencereyi";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkmak İçin Emin Misin", "Çıkış", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Çıkış Yapmadın Haberin ola","niye la",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
        }
    }
}
