using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace islem5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex==1)
            {
                groupBox3.Visible = false;
                groupBox2.Visible = true;
                groupBox1.Visible = false;
            }
            if (listBox1.SelectedIndex==2)
            {
                groupBox3.Visible = true;
                groupBox2.Visible = false;
                groupBox1.Visible = false;
            }
            if(listBox1.SelectedIndex==0)
            {
                groupBox3.Visible = false;
                groupBox2.Visible = false;
                groupBox1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox2.Text);
            int alan,cevre;
            alan = a * a;
            cevre = a * 4;
            label1.Text = Convert.ToString("Çevre : "+cevre );
            label2.Text = Convert.ToString("Alan : " + alan);
            label7.Text = "Çevre A*4 Alan A*A";
                
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(textBox1.Text);
            const double pi = 3.14;
            double alan, cevre;
            alan = (a * a) * pi;
            cevre = 2 *pi *a;
            label1.Text = Convert.ToString("Çevre : " + cevre);
            label2.Text = Convert.ToString("Alan : " + alan);
            label7.Text = "Çevre 2*pi*r Alan pi*r^2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox3.Text);
            int b = Convert.ToInt32(textBox4.Text);
            int alan, cevre;
            alan = a*b;
            cevre = 2*(a+b);
            label1.Text = Convert.ToString("Çevre : " + cevre);
            label2.Text = Convert.ToString("Alan : " + alan);
            label7.Text = "Çevre 2AB Alan AB";
        }
    }
}
