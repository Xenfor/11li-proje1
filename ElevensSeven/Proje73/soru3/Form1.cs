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
                  progressBar1.ForeColor = Color.FromName(listBox1.Items[s].ToString());
                  
                  //listBox1.SetSelected(s, true);
                  if (listBox1.SelectedIndex == 1)
                  {
                      progressBar1.Value = 20;
                  }
                  if (listBox1.SelectedIndex == 2)
                  {
                      progressBar1.Value = 40;
                  }
                  if (listBox1.SelectedIndex == 3)
                  {
                      progressBar1.Value =60;
                  }
                  if (listBox1.SelectedIndex == 4)
                  {
                      progressBar1.Value = 80;
                  }
                  if (listBox1.SelectedIndex == 5)
                  {
                      progressBar1.Value = 100;
                  }
                      s++;
                      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "-f -s -t 1");

        }
    }
}
