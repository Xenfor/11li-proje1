using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Telefon_Rehberi
{
    public partial class Login : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=PhoneBook.mdb;Persist Security Info=False;");
        public Login()
        {

            InitializeComponent();
        }

        private void loginemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)30)
                loginpw.Focus();

        }

        private void loginpw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)15)
                btnlogin.PerformClick();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loginemail.Text))
            {
                MessageBox.Show("Lütfen E-mail giriniz.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loginemail.Focus();
                return;
            }
            try
            {
                DataTable dataTable = new DataTable();

                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(new OleDbCommand("Select * from users where email ='" + this.loginemail.Text + "' and password = '" + this.loginpw.Text + "'", this.connect));
                oleDbDataAdapter.Fill(dataTable);
                MessageBox.Show(dataTable.Rows.Count.ToString());
                if (dataTable.Rows.Count == 1)
                {
                    MessageBox.Show("Başarıyla giriş yapıldı.");
                    
                }

                else
                {
                    MessageBox.Show("Email ya da Şifre hatalı.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loginemail.Text))
            {
                MessageBox.Show("Lütfen E-mail giriniz.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loginemail.Focus();
                return;
            }
            try
            {
                DataTable dataTable = new DataTable();

                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(new OleDbCommand("Select * from users where email ='" + this.loginemail.Text + "' and password = '" + this.loginpw.Text + "'", this.connect));
                oleDbDataAdapter.Fill(dataTable);
                MessageBox.Show(dataTable.Rows.Count.ToString());
                if (dataTable.Rows.Count == 1)
                {
                    MessageBox.Show("Başarıyla giriş yapıldı.");
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Email ya da Şifre hatalı.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
