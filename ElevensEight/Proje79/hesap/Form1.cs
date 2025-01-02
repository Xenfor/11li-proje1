using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hesap
{
    public partial class Form1 : Form
    {
        double fiyat, miktar, tutar, indirim, vergi;
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            fiyat = Convert.ToDouble(textBox1.Text);
            miktar = Convert.ToDouble(textBox2.Text);


            tutar = fiyat * miktar;

            if (checkBox1.Checked)
            {
                indirim = Convert.ToDouble(textBox3.Text);
                tutar = (tutar-(tutar * indirim/100));
            }
            if (checkBox2.Checked)
            {
                vergi = Convert.ToDouble(textBox4.Text);
                tutar = (tutar+(tutar * vergi/100));
            }                                     
            
            
     
		        
	        
            
            label3.Text = Convert.ToString(tutar);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
	{
		 textBox3.Enabled=true;
	}
            else
	{
         textBox3.Enabled= false;
         
	}
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           if (checkBox2.Checked)
	       {
		 textBox4.Enabled=true;
               
	       }
            else
	       {
         textBox4.Enabled= false;
         
	       }
      }
    }
}
