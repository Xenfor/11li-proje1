using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace islem3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            if (a == b && a == c)
            {
                label1.Text = "eşkenar üçgen";
            }
            else if (a == b || a == c || b == c)
            {
                label1.Text = "ikizkenar üçgen";

            }
            else
            {
                label1.Text = "çeşitkenar üçgen";
            }
        }
    }
}
