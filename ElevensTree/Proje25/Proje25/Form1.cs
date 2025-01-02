using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje25
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
            int s = 0;
            for (int i = 0; i < a; i++)
            {
                if (a%i==0)
                {
                    s++;
                }
            }
            if (s == 1)
            {
                listBox1.Items.Add(a.ToString();
            }
            else if (a%2 == 0)
            {
                listBox2.Items.Add(a.ToString());

            }
            else if (a % 2 == 1)
            {
                listBox3.Items.Add(a.ToString());
            }
        }
    }
}
