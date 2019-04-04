namespace NT_ADO.Net_Son_Proje
{
    partial class Form1
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
            this.grpBoxEkle = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpBoxGuncelle = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtEkleAd = new System.Windows.Forms.TextBox();
            this.txtEkleFiyat = new System.Windows.Forms.TextBox();
            this.txtEkleStok = new System.Windows.Forms.TextBox();
            this.txtGuncelleStok = new System.Windows.Forms.TextBox();
            this.txtGuncelleFiyat = new System.Windows.Forms.TextBox();
            this.txtGuncelleAd = new System.Windows.Forms.TextBox();
            this.lstUrun = new System.Windows.Forms.ListView();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblID = new System.Windows.Forms.Label();
            this.grpBoxEkle.SuspendLayout();
            this.grpBoxGuncelle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxEkle
            // 
            this.grpBoxEkle.Controls.Add(this.txtEkleStok);
            this.grpBoxEkle.Controls.Add(this.txtEkleFiyat);
            this.grpBoxEkle.Controls.Add(this.txtEkleAd);
            this.grpBoxEkle.Controls.Add(this.btnEkle);
            this.grpBoxEkle.Controls.Add(this.label3);
            this.grpBoxEkle.Controls.Add(this.label2);
            this.grpBoxEkle.Controls.Add(this.label1);
            this.grpBoxEkle.Location = new System.Drawing.Point(12, 22);
            this.grpBoxEkle.Name = "grpBoxEkle";
            this.grpBoxEkle.Size = new System.Drawing.Size(310, 200);
            this.grpBoxEkle.TabIndex = 0;
            this.grpBoxEkle.TabStop = false;
            this.grpBoxEkle.Text = "EKLE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stok:";
            // 
            // grpBoxGuncelle
            // 
            this.grpBoxGuncelle.Controls.Add(this.txtGuncelleStok);
            this.grpBoxGuncelle.Controls.Add(this.btnGuncelle);
            this.grpBoxGuncelle.Controls.Add(this.txtGuncelleFiyat);
            this.grpBoxGuncelle.Controls.Add(this.label4);
            this.grpBoxGuncelle.Controls.Add(this.txtGuncelleAd);
            this.grpBoxGuncelle.Controls.Add(this.label5);
            this.grpBoxGuncelle.Controls.Add(this.label6);
            this.grpBoxGuncelle.Location = new System.Drawing.Point(345, 22);
            this.grpBoxGuncelle.Name = "grpBoxGuncelle";
            this.grpBoxGuncelle.Size = new System.Drawing.Size(310, 200);
            this.grpBoxGuncelle.TabIndex = 3;
            this.grpBoxGuncelle.TabStop = false;
            this.grpBoxGuncelle.Text = "GÜNCELLE";
            this.grpBoxGuncelle.Enter += new System.EventHandler(this.grpBoxGuncelle_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Stok:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fiyat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ad:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(187, 152);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(98, 23);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(206, 152);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(98, 23);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtEkleAd
            // 
            this.txtEkleAd.Location = new System.Drawing.Point(71, 34);
            this.txtEkleAd.Name = "txtEkleAd";
            this.txtEkleAd.Size = new System.Drawing.Size(214, 20);
            this.txtEkleAd.TabIndex = 4;
            // 
            // txtEkleFiyat
            // 
            this.txtEkleFiyat.Location = new System.Drawing.Point(71, 69);
            this.txtEkleFiyat.Name = "txtEkleFiyat";
            this.txtEkleFiyat.Size = new System.Drawing.Size(214, 20);
            this.txtEkleFiyat.TabIndex = 5;
            // 
            // txtEkleStok
            // 
            this.txtEkleStok.Location = new System.Drawing.Point(71, 101);
            this.txtEkleStok.Name = "txtEkleStok";
            this.txtEkleStok.Size = new System.Drawing.Size(214, 20);
            this.txtEkleStok.TabIndex = 6;
            // 
            // txtGuncelleStok
            // 
            this.txtGuncelleStok.Location = new System.Drawing.Point(80, 97);
            this.txtGuncelleStok.Name = "txtGuncelleStok";
            this.txtGuncelleStok.Size = new System.Drawing.Size(214, 20);
            this.txtGuncelleStok.TabIndex = 9;
            // 
            // txtGuncelleFiyat
            // 
            this.txtGuncelleFiyat.Location = new System.Drawing.Point(80, 65);
            this.txtGuncelleFiyat.Name = "txtGuncelleFiyat";
            this.txtGuncelleFiyat.Size = new System.Drawing.Size(214, 20);
            this.txtGuncelleFiyat.TabIndex = 8;
            // 
            // txtGuncelleAd
            // 
            this.txtGuncelleAd.Location = new System.Drawing.Point(80, 30);
            this.txtGuncelleAd.Name = "txtGuncelleAd";
            this.txtGuncelleAd.Size = new System.Drawing.Size(214, 20);
            this.txtGuncelleAd.TabIndex = 7;
            // 
            // lstUrun
            // 
            this.lstUrun.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstUrun.FullRowSelect = true;
            this.lstUrun.GridLines = true;
            this.lstUrun.Location = new System.Drawing.Point(12, 299);
            this.lstUrun.Name = "lstUrun";
            this.lstUrun.Size = new System.Drawing.Size(655, 203);
            this.lstUrun.TabIndex = 4;
            this.lstUrun.UseCompatibleStateImageBehavior = false;
            this.lstUrun.View = System.Windows.Forms.View.Details;
            this.lstUrun.SelectedIndexChanged += new System.EventHandler(this.lstUrun_SelectedIndexChanged);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(31, 249);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(136, 31);
            this.btnListele.TabIndex = 7;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(186, 249);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(136, 31);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 521);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(214, 20);
            this.txtAra.TabIndex = 7;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(551, 521);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(116, 23);
            this.btnAra.TabIndex = 7;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            this.columnHeader1.Width = 281;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fiyat";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Stok";
            this.columnHeader3.Width = 123;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(375, 258);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 13);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "label7";
            this.lblID.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 553);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.lstUrun);
            this.Controls.Add(this.grpBoxGuncelle);
            this.Controls.Add(this.grpBoxEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxEkle.ResumeLayout(false);
            this.grpBoxEkle.PerformLayout();
            this.grpBoxGuncelle.ResumeLayout(false);
            this.grpBoxGuncelle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxEkle;
        private System.Windows.Forms.TextBox txtEkleStok;
        private System.Windows.Forms.TextBox txtEkleFiyat;
        private System.Windows.Forms.TextBox txtEkleAd;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBoxGuncelle;
        private System.Windows.Forms.TextBox txtGuncelleStok;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtGuncelleFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGuncelleAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lstUrun;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label lblID;
    }
}

