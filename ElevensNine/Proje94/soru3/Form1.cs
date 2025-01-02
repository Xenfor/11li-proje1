using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace soru3
{
    public partial class Form1 : Form
    {
        int s=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {  
                  if (s >= listBox1.Items.Count)
	              {
                      s =0;
                  }
                  listBox1.SelectedItem = listBox1.Items[s].ToString();
                  this.BackColor = Color.FromName(listBox1.Items[s].ToString());
                  //listBox1.SetSelected(s, true);
                  
                      s++;
                      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
