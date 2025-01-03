﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sqlyeni1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAB8OGR03;Initial Catalog=sqldeneme;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open(); 
            }
            string kayit = "insert into bilgi (id,pw) values(@id,@pw)";
            SqlCommand cmd = new SqlCommand(kayit, con); 
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@pw", textBox2.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kaydedildi");
            textBox1.Clear();
            textBox2.Clear();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string i = textBox1.Text;
            con.Open();
            string kayit = "insert into bilgi (id,pw) values(@id,@pw)";
            SqlCommand cmd = new SqlCommand("select id["+i+"] from bilgi", con);
            cmd.ExecuteNonQuery();
            if (textBox1.Text == kayit.Cast[])
            {
                MessageBox.Show(cmd.CommandText);
                MessageBox.Show("Kullanıcı Adı Vardır");
            }
            con.Close();
        }
    }
}
