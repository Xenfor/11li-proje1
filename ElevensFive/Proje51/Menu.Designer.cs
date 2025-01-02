
namespace bprogram1
{
    partial class Menu
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
            this.raidiobbanka = new System.Windows.Forms.RadioButton();
            this.raidiobcalisan = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.raidiobkisi = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.lbkisi = new System.Windows.Forms.ListBox();
            this.lbbank = new System.Windows.Forms.ListBox();
            this.lbcalisan = new System.Windows.Forms.ListBox();
            this.lbkredikart = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // raidiobbanka
            // 
            this.raidiobbanka.AutoSize = true;
            this.raidiobbanka.Location = new System.Drawing.Point(25, 35);
            this.raidiobbanka.Name = "raidiobbanka";
            this.raidiobbanka.Size = new System.Drawing.Size(82, 17);
            this.raidiobbanka.TabIndex = 4;
            this.raidiobbanka.TabStop = true;
            this.raidiobbanka.Text = "BANKALAR";
            this.raidiobbanka.UseVisualStyleBackColor = true;
            this.raidiobbanka.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // raidiobcalisan
            // 
            this.raidiobcalisan.AutoSize = true;
            this.raidiobcalisan.Location = new System.Drawing.Point(25, 58);
            this.raidiobcalisan.Name = "raidiobcalisan";
            this.raidiobcalisan.Size = new System.Drawing.Size(91, 17);
            this.raidiobcalisan.TabIndex = 5;
            this.raidiobcalisan.TabStop = true;
            this.raidiobcalisan.Text = "ÇALIŞANLAR";
            this.raidiobcalisan.UseVisualStyleBackColor = true;
            this.raidiobcalisan.CheckedChanged += new System.EventHandler(this.rbkisi_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(215, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "MAHSUP";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(25, 81);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(114, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "KREDİ KARTLARI";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // raidiobkisi
            // 
            this.raidiobkisi.AutoSize = true;
            this.raidiobkisi.Location = new System.Drawing.Point(25, 12);
            this.raidiobkisi.Name = "raidiobkisi";
            this.raidiobkisi.Size = new System.Drawing.Size(66, 17);
            this.raidiobkisi.TabIndex = 8;
            this.raidiobkisi.TabStop = true;
            this.raidiobkisi.Text = "KİŞİLER";
            this.raidiobkisi.UseVisualStyleBackColor = true;
            this.raidiobkisi.CheckedChanged += new System.EventHandler(this.raidiobkisiler_changed);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(215, 35);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(75, 17);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "AYARLAR";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // lbkisi
            // 
            this.lbkisi.FormattingEnabled = true;
            this.lbkisi.Items.AddRange(new object[] {
            "Voltır"});
            this.lbkisi.Location = new System.Drawing.Point(25, 35);
            this.lbkisi.Name = "lbkisi";
            this.lbkisi.Size = new System.Drawing.Size(120, 95);
            this.lbkisi.TabIndex = 10;
            this.lbkisi.Visible = false;
            // 
            // lbbank
            // 
            this.lbbank.FormattingEnabled = true;
            this.lbbank.Items.AddRange(new object[] {
            "Halkbank",
            "İşbank Haşim"});
            this.lbbank.Location = new System.Drawing.Point(25, 58);
            this.lbbank.Name = "lbbank";
            this.lbbank.Size = new System.Drawing.Size(120, 95);
            this.lbbank.TabIndex = 11;
            this.lbbank.Visible = false;
            this.lbbank.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // lbcalisan
            // 
            this.lbcalisan.FormattingEnabled = true;
            this.lbcalisan.Items.AddRange(new object[] {
            "Furkan Parlak",
            "Sadi Parlak",
            "Haşim Parlak",
            "Ömer"});
            this.lbcalisan.Location = new System.Drawing.Point(25, 81);
            this.lbcalisan.Name = "lbcalisan";
            this.lbcalisan.Size = new System.Drawing.Size(120, 95);
            this.lbcalisan.TabIndex = 12;
            this.lbcalisan.Visible = false;
            this.lbcalisan.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // lbkredikart
            // 
            this.lbkredikart.FormattingEnabled = true;
            this.lbkredikart.Items.AddRange(new object[] {
            "----"});
            this.lbkredikart.Location = new System.Drawing.Point(25, 104);
            this.lbkredikart.Name = "lbkredikart";
            this.lbkredikart.Size = new System.Drawing.Size(120, 95);
            this.lbkredikart.TabIndex = 13;
            this.lbkredikart.Visible = false;
            this.lbkredikart.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 231);
            this.Controls.Add(this.lbkredikart);
            this.Controls.Add(this.lbcalisan);
            this.Controls.Add(this.lbbank);
            this.Controls.Add(this.lbkisi);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.raidiobkisi);
            this.Controls.Add(this.raidiobbanka);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.raidiobcalisan);
            this.Name = "Menu";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton raidiobbanka;
        private System.Windows.Forms.RadioButton raidiobcalisan;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton raidiobkisi;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.ListBox lbkisi;
        private System.Windows.Forms.ListBox lbbank;
        private System.Windows.Forms.ListBox lbcalisan;
        private System.Windows.Forms.ListBox lbkredikart;
    }
}