namespace Telefon_Rehberi
{
    partial class Qr_Code
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtqrname = new System.Windows.Forms.TextBox();
            this.txtqrsurname = new System.Windows.Forms.TextBox();
            this.txtqrbirthday = new System.Windows.Forms.TextBox();
            this.txtqrbirthplace = new System.Windows.Forms.TextBox();
            this.txtqrjob = new System.Windows.Forms.TextBox();
            this.txtqrphone1 = new System.Windows.Forms.TextBox();
            this.txtqrphone2 = new System.Windows.Forms.TextBox();
            this.txtqrhousephone = new System.Windows.Forms.TextBox();
            this.txtqrjobphone = new System.Windows.Forms.TextBox();
            this.txtqrjobadress = new System.Windows.Forms.TextBox();
            this.txtqrhomeadress = new System.Windows.Forms.TextBox();
            this.txtqremail = new System.Windows.Forms.TextBox();
            this.txtqrwebsite = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(318, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "QR Kod Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(318, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(429, 208);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // txtqrname
            // 
            this.txtqrname.Location = new System.Drawing.Point(437, 68);
            this.txtqrname.Name = "txtqrname";
            this.txtqrname.Size = new System.Drawing.Size(241, 20);
            this.txtqrname.TabIndex = 3;
            // 
            // txtqrsurname
            // 
            this.txtqrsurname.Location = new System.Drawing.Point(455, 34);
            this.txtqrsurname.Name = "txtqrsurname";
            this.txtqrsurname.Size = new System.Drawing.Size(10, 20);
            this.txtqrsurname.TabIndex = 3;
            // 
            // txtqrbirthday
            // 
            this.txtqrbirthday.Location = new System.Drawing.Point(471, 12);
            this.txtqrbirthday.Name = "txtqrbirthday";
            this.txtqrbirthday.Size = new System.Drawing.Size(10, 20);
            this.txtqrbirthday.TabIndex = 3;
            // 
            // txtqrbirthplace
            // 
            this.txtqrbirthplace.Location = new System.Drawing.Point(471, 34);
            this.txtqrbirthplace.Name = "txtqrbirthplace";
            this.txtqrbirthplace.Size = new System.Drawing.Size(10, 20);
            this.txtqrbirthplace.TabIndex = 3;
            // 
            // txtqrjob
            // 
            this.txtqrjob.Location = new System.Drawing.Point(487, 12);
            this.txtqrjob.Name = "txtqrjob";
            this.txtqrjob.Size = new System.Drawing.Size(10, 20);
            this.txtqrjob.TabIndex = 3;
            this.txtqrjob.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtqrphone1
            // 
            this.txtqrphone1.Location = new System.Drawing.Point(487, 34);
            this.txtqrphone1.Name = "txtqrphone1";
            this.txtqrphone1.Size = new System.Drawing.Size(10, 20);
            this.txtqrphone1.TabIndex = 3;
            // 
            // txtqrphone2
            // 
            this.txtqrphone2.Location = new System.Drawing.Point(502, 12);
            this.txtqrphone2.Name = "txtqrphone2";
            this.txtqrphone2.Size = new System.Drawing.Size(10, 20);
            this.txtqrphone2.TabIndex = 3;
            // 
            // txtqrhousephone
            // 
            this.txtqrhousephone.Location = new System.Drawing.Point(502, 34);
            this.txtqrhousephone.Name = "txtqrhousephone";
            this.txtqrhousephone.Size = new System.Drawing.Size(10, 20);
            this.txtqrhousephone.TabIndex = 3;
            // 
            // txtqrjobphone
            // 
            this.txtqrjobphone.Location = new System.Drawing.Point(518, 12);
            this.txtqrjobphone.Name = "txtqrjobphone";
            this.txtqrjobphone.Size = new System.Drawing.Size(10, 20);
            this.txtqrjobphone.TabIndex = 3;
            // 
            // txtqrjobadress
            // 
            this.txtqrjobadress.Location = new System.Drawing.Point(534, 12);
            this.txtqrjobadress.Name = "txtqrjobadress";
            this.txtqrjobadress.Size = new System.Drawing.Size(10, 20);
            this.txtqrjobadress.TabIndex = 3;
            this.txtqrjobadress.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtqrhomeadress
            // 
            this.txtqrhomeadress.Location = new System.Drawing.Point(518, 34);
            this.txtqrhomeadress.Name = "txtqrhomeadress";
            this.txtqrhomeadress.Size = new System.Drawing.Size(10, 20);
            this.txtqrhomeadress.TabIndex = 3;
            // 
            // txtqremail
            // 
            this.txtqremail.Location = new System.Drawing.Point(534, 34);
            this.txtqremail.Name = "txtqremail";
            this.txtqremail.Size = new System.Drawing.Size(10, 20);
            this.txtqremail.TabIndex = 3;
            // 
            // txtqrwebsite
            // 
            this.txtqrwebsite.Location = new System.Drawing.Point(550, 12);
            this.txtqrwebsite.Name = "txtqrwebsite";
            this.txtqrwebsite.Size = new System.Drawing.Size(10, 20);
            this.txtqrwebsite.TabIndex = 3;
            this.txtqrwebsite.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Qr_Code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 450);
            this.Controls.Add(this.txtqremail);
            this.Controls.Add(this.txtqrphone1);
            this.Controls.Add(this.txtqrhomeadress);
            this.Controls.Add(this.txtqrbirthplace);
            this.Controls.Add(this.txtqrwebsite);
            this.Controls.Add(this.txtqrjobadress);
            this.Controls.Add(this.txtqrjobphone);
            this.Controls.Add(this.txtqrjob);
            this.Controls.Add(this.txtqrhousephone);
            this.Controls.Add(this.txtqrbirthday);
            this.Controls.Add(this.txtqrphone2);
            this.Controls.Add(this.txtqrsurname);
            this.Controls.Add(this.txtqrname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Qr_Code";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qr_Code";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Qr_Code_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtqrname;
        private System.Windows.Forms.TextBox txtqrsurname;
        private System.Windows.Forms.TextBox txtqrbirthday;
        private System.Windows.Forms.TextBox txtqrbirthplace;
        private System.Windows.Forms.TextBox txtqrjob;
        private System.Windows.Forms.TextBox txtqrphone1;
        private System.Windows.Forms.TextBox txtqrphone2;
        private System.Windows.Forms.TextBox txtqrhousephone;
        private System.Windows.Forms.TextBox txtqrjobphone;
        private System.Windows.Forms.TextBox txtqrjobadress;
        private System.Windows.Forms.TextBox txtqrhomeadress;
        private System.Windows.Forms.TextBox txtqremail;
        private System.Windows.Forms.TextBox txtqrwebsite;
    }
}