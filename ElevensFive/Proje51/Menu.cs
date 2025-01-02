using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bprogram1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (raidiobbanka.Checked)
            {
                lbbank.Visible = true;
                raidiobcalisan.Location = new Point(raidiobcalisan.Location.X, raidiobcalisan.Location.Y + 95);
                
                
                
                radioButton2.Location = new Point(radioButton2.Location.X, radioButton2.Location.Y + 95);
                
            }
            else
            {
                lbbank.Visible = false;
                radioButton2.Location = new Point(radioButton2.Location.X, radioButton2.Location.Y - 95);
                
                raidiobcalisan.Location = new Point(raidiobcalisan.Location.X, raidiobcalisan.Location.Y - 95);
            }
        }

        private void rbkisi_CheckedChanged(object sender, EventArgs e)
        {
            if (raidiobcalisan.Checked)
            {
                lbcalisan.Visible = true;
                



                radioButton2.Location = new Point(radioButton2.Location.X, radioButton2.Location.Y + 95);

            }
            else
            {
                lbcalisan.Visible = false;
                radioButton2.Location = new Point(radioButton2.Location.X, radioButton2.Location.Y - 95);

                
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Mahsup f3 = new Mahsup();
                f3.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FurkanParlak f4 = new FurkanParlak();
            f4.Show();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                Ayarlar f5 = new Ayarlar();
                f5.Show();
            }
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbcalisan.SelectedItem == "Furkan Parlak")
            {
                FurkanParlak fp = new FurkanParlak();
                fp.Show();
            }
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (raidiobcalisan.Checked)
            {
                lbkredikart.Visible = true;
            }
            else
            {
                lbkredikart.Visible = false;
            }
        }

        private void raidiobkisiler_changed(object sender, EventArgs e)
        {
            if (raidiobkisi.Checked)
            {
                lbkisi.Visible = true;
                raidiobcalisan.Location = new Point(raidiobcalisan.Location.X, raidiobcalisan.Location.Y + 95);
                lbcalisan.Visible = false;
                raidiobbanka.Location = new Point(raidiobbanka.Location.X, raidiobbanka.Location.Y + 95);
                lbbank.Visible = false;
                radioButton2.Location = new Point(radioButton2.Location.X, radioButton2.Location.Y + 95);
                lbkredikart.Visible = false;
            }
            else
            {
                lbkisi.Visible = false;
                raidiobcalisan.Location = new Point(raidiobcalisan.Location.X, raidiobcalisan.Location.Y - 95);
                raidiobbanka.Location = new Point(raidiobbanka.Location.X, raidiobbanka.Location.Y - 95);
                radioButton2.Location = new Point(radioButton2.Location.X, radioButton2.Location.Y - 95);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu mm = new Menu();
            mm.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
