namespace Telefon_Rehberi
{
    partial class Edit_Person
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
            this.btneditdel = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.editdatagrid = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txteditpers = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.editdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btneditdel
            // 
            this.btneditdel.Location = new System.Drawing.Point(250, 28);
            this.btneditdel.Name = "btneditdel";
            this.btneditdel.Size = new System.Drawing.Size(75, 23);
            this.btneditdel.TabIndex = 15;
            this.btneditdel.Text = "Sil";
            this.btneditdel.UseVisualStyleBackColor = true;
            this.btneditdel.Click += new System.EventHandler(this.btneditdel_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(331, 28);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 16;
            this.btnadd.Text = "Ekle";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(412, 28);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 17;
            this.btnupdate.Text = "Güncelle";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // editdatagrid
            // 
            this.editdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editdatagrid.Location = new System.Drawing.Point(12, 57);
            this.editdatagrid.Name = "editdatagrid";
            this.editdatagrid.Size = new System.Drawing.Size(1143, 391);
            this.editdatagrid.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // txteditpers
            // 
            this.txteditpers.Location = new System.Drawing.Point(12, 31);
            this.txteditpers.Name = "txteditpers";
            this.txteditpers.Size = new System.Drawing.Size(232, 20);
            this.txteditpers.TabIndex = 19;
            // 
            // Edit_Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txteditpers);
            this.Controls.Add(this.editdatagrid);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btneditdel);
            this.Name = "Edit_Person";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit_Person";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.editdatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btneditdel;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.DataGridView editdatagrid;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txteditpers;
    }
}