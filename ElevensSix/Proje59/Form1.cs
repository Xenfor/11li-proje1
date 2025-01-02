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

namespace serialportperf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updatePorts();          
            CheckForIllegalCrossThreadCalls = false;
        }
        private void updatePorts()
        {
            
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }
        }
        private SerialPort ComPort = new SerialPort(); 
        private void connect()
        {
            bool error = false;


            if (comboBox1.SelectedIndex != -1 & comboBox2.SelectedIndex != -1 & comboBox3.SelectedIndex != -1 & comboBox4.SelectedIndex != -1 & comboBox5.SelectedIndex != -1)
            {
                ComPort.PortName = comboBox1.Text;
                ComPort.BaudRate = int.Parse(comboBox2.Text);     
                ComPort.Parity = (Parity)Enum.Parse(typeof(Parity), comboBox3.Text);
                ComPort.DataBits = int.Parse(comboBox4.Text);       
                ComPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBox5.Text); 

                try   
                     
                {
                    ComPort.Open();
                    ComPort.DataReceived += SerialPortDataReceived;  
                }
                catch (UnauthorizedAccessException) { error = true; }
                catch (System.IO.IOException) { error = true; }
                catch (ArgumentException) { error = true; }

                if (error) MessageBox.Show(this, "Could not open the COM port. Most likely it is already in use, has been removed, or is unavailable.", "COM Port unavailable", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                MessageBox.Show("Please select all the COM Serial Port Settings", "Serial Port Interface", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            if (ComPort.IsOpen)
            {
                button1.Text = "Disconnect";
                button2.Enabled = true;
                if (!radioButton1.Checked & !radioButton2.Checked) 
                {
                    radioButton1.Checked = true;
                }
                groupBox1.Enabled = false;


            }
        }
        private void disconnect()
        {
            ComPort.Close();
            
            button2.Enabled = false;
            groupBox1.Enabled = true;

        }
        private void btnConnect_Click(object sender, EventArgs e)

        {
            if (ComPort.IsOpen)
            {
                disconnect();
            }
            else
            {
                connect();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            textBox1.Clear();
        }

        private void sendData()
        {
            bool error = false;
            if (radioButton1.Checked == true)    
            {
                ComPort.Write(textBox1.Text);


                richTextBox1.ForeColor = Color.Green;     
                textBox1.Clear();      

            }
            else               
            {
                try
                {
                    byte[] data = HexStringToByteArray(textBox1.Text);

                    ComPort.Write(data, 0, data.Length);

        
                    richTextBox1.ForeColor = Color.Blue;  
                    richTextBox1.AppendText(textBox1.Text.ToUpper() + "\n");
                    textBox1.Clear();                    
                }
                catch (FormatException) { error = true; }

        
                catch (ArgumentException) { error = true; }

                if (error) MessageBox.Show(this, "Not properly formatted hex string: " + textBox1.Text + "\n" + "example: E1 FF 1B", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }
        private byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendData();
        }
      
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ComPort.IsOpen) ComPort.Close();  
        }
       
        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
         
            if (this.richTextBox1.InvokeRequired)
            {
                richTextBox1.ForeColor = Color.Green;    

                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.richTextBox1.AppendText(text);
            }
        }
        private void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var serialPort = (SerialPort)sender;
            var data = serialPort.ReadExisting();
            SetText(data);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            updatePorts();           
        }
    }
}
