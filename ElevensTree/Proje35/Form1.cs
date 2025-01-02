using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string i = textBox1.Text;
            string isi = textBox2.Text;
            
            
            label5.Text = "İsminiz: " + i +"\nSoyisminiz: "+isi; 
            if (checkBox2.Checked)
            {
                string ei = textBox3.Text;
                
                label5.Text += "\nEşinizin İsimi: " + ei;
            }
            if (checkBox3.Checked)
            {
                string cs = textBox4.Text;
                label5.Text += "\nÇocuk Sayısı: " + cs;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                groupBox3.Enabled = true;
            }
            else
            {
                groupBox3.Enabled = false;
            }
        }
    }
}
