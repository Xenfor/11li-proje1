using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace projeprocess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                serialPort1.Open();
                button1.Enabled = true;
            }
            else
            {
                serialPort1.Close();
                button3.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = serialPort1.IsOpen.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                serialPort1.Write("SI\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening/writing to serial port :: " + ex.Message, "Error!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.WriteTimeout = 1000;
        }
    }
}
