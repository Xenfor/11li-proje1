using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace islem21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
                textBox1.SelectionLength = 1;
            }
            int a = Convert.ToInt32(textBox1.Text);

            if (a < 0 && a % 2 == 0)
            {
                label1.Text = "Çift ve Negatif";
            }
            else if (a < 0 && a % 2 == 1)
            {
                label1.Text = "Tek ve Negatif";
            }
            else if (a > 0 && a % 2 == 0)
            {
                label1.Text = "Çift ve Pozitif";
            }
            else if (a > 0 && a % 2 == 1)
            {
                label1.Text = "Tek ve Pozitif";
            }
            else if (a == 0)
            {
                label1.Text = "Sıfır";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
