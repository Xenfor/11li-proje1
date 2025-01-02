using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char o1 = Convert.ToChar(textBox2.Text);
            double n1 = Convert.ToDouble(textBox1.Text),n2 = Convert.ToDouble(textBox3.Text); ;

            switch (o1)
            {
                case '+': label4.Text = (n1 + n2).ToString();break;
                case '-': label4.Text = (n1 - n2).ToString(); break;
                case '*': label4.Text = (n1 * n2).ToString(); break;
                case '/': label4.Text = (n1 / n2).ToString(); break;
                case '%': label4.Text = (n1 % n2).ToString(); break;

                default:label4.Text = "Please enter a valid operator";
                    break;
            }
        }
    }
}
