namespace Telefon_Rehberi
{
    partial class Person_List
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
            this.personlistdt = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlist = new System.Windows.Forms.TextBox();
            this.btnfind = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personlistdt)).BeginInit();
            this.SuspendLayout();
            // 
            // personlistdt
            // 
            this.personlistdt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personlistdt.Location = new System.Drawing.Point(0, 73);
            this.personlistdt.Name = "personlistdt";
            this.personlistdt.Size = new System.Drawing.Size(1157, 467);
            this.personlistdt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(549, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kişi Listesi";
            // 
            // txtlist
            // 
            this.txtlist.Location = new System.Drawing.Point(12, 47);
            this.txtlist.Name = "txtlist";
            this.txtlist.Size = new System.Drawing.Size(192, 20);
            this.txtlist.TabIndex = 15;
            // 
            // btnfind
            // 
            this.btnfind.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnfind.Location = new System.Drawing.Point(210, 37);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(75, 30);
            this.btnfind.TabIndex = 16;
            this.btnfind.Text = "Ara";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.btndel.Location = new System.Drawing.Point(291, 37);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 30);
            this.btndel.TabIndex = 16;
            this.btndel.Text = "Sil";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.button2_Click);
            // 
            // Person_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 539);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.txtlist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.personlistdt);
            this.Name = "Person_List";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kişi Listesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Kişi_Listesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personlistdt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView personlistdt;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlist;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btndel;
    }
}