
namespace Kutuphane.Presentation
{
    partial class KitapIslemleriSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapIslemleriSayfasi));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnUygula = new System.Windows.Forms.Button();
            this.gboxBilgiler = new System.Windows.Forms.GroupBox();
            this.cbVerilmeyeHazirMiBilgi = new System.Windows.Forms.CheckBox();
            this.nudSayfaSayisiBilgi = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBaskiYiliBilgi = new System.Windows.Forms.TextBox();
            this.txtYayineviBilgi = new System.Windows.Forms.TextBox();
            this.txtTurBilgi = new System.Windows.Forms.TextBox();
            this.txtYazarBilgi = new System.Windows.Forms.TextBox();
            this.txtKitapAdiBilgi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBarkodBilgi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gboxIslemler = new System.Windows.Forms.GroupBox();
            this.rbtnGuncelle = new System.Windows.Forms.RadioButton();
            this.rbtnSil = new System.Windows.Forms.RadioButton();
            this.rbtnEkle = new System.Windows.Forms.RadioButton();
            this.gboxKitaplar = new System.Windows.Forms.GroupBox();
            this.tabloGizleyici = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataKitap = new System.Windows.Forms.DataGridView();
            this.btnKitapGorseliYukle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pboxKitap = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.gboxBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSayfaSayisiBilgi)).BeginInit();
            this.gboxIslemler.SuspendLayout();
            this.gboxKitaplar.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKitap)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1048, 27);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Kutuphane.Properties.Resources.home;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(117, 24);
            this.toolStripButton1.Text = "Menüye Dön";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnUygula
            // 
            this.btnUygula.Enabled = false;
            this.btnUygula.Location = new System.Drawing.Point(675, 42);
            this.btnUygula.Name = "btnUygula";
            this.btnUygula.Size = new System.Drawing.Size(113, 191);
            this.btnUygula.TabIndex = 22;
            this.btnUygula.Text = "İşlemi\r\nUygula";
            this.btnUygula.UseVisualStyleBackColor = true;
            this.btnUygula.Click += new System.EventHandler(this.btnUygula_Click);
            // 
            // gboxBilgiler
            // 
            this.gboxBilgiler.Controls.Add(this.cbVerilmeyeHazirMiBilgi);
            this.gboxBilgiler.Controls.Add(this.nudSayfaSayisiBilgi);
            this.gboxBilgiler.Controls.Add(this.label9);
            this.gboxBilgiler.Controls.Add(this.label10);
            this.gboxBilgiler.Controls.Add(this.label3);
            this.gboxBilgiler.Controls.Add(this.label8);
            this.gboxBilgiler.Controls.Add(this.txtBaskiYiliBilgi);
            this.gboxBilgiler.Controls.Add(this.txtYayineviBilgi);
            this.gboxBilgiler.Controls.Add(this.txtTurBilgi);
            this.gboxBilgiler.Controls.Add(this.txtYazarBilgi);
            this.gboxBilgiler.Controls.Add(this.txtKitapAdiBilgi);
            this.gboxBilgiler.Controls.Add(this.label2);
            this.gboxBilgiler.Controls.Add(this.label6);
            this.gboxBilgiler.Controls.Add(this.txtBarkodBilgi);
            this.gboxBilgiler.Controls.Add(this.label1);
            this.gboxBilgiler.Enabled = false;
            this.gboxBilgiler.Location = new System.Drawing.Point(21, 251);
            this.gboxBilgiler.Name = "gboxBilgiler";
            this.gboxBilgiler.Size = new System.Drawing.Size(767, 163);
            this.gboxBilgiler.TabIndex = 21;
            this.gboxBilgiler.TabStop = false;
            this.gboxBilgiler.Text = "Bilgiler";
            // 
            // cbVerilmeyeHazirMiBilgi
            // 
            this.cbVerilmeyeHazirMiBilgi.AutoSize = true;
            this.cbVerilmeyeHazirMiBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVerilmeyeHazirMiBilgi.Location = new System.Drawing.Point(599, 118);
            this.cbVerilmeyeHazirMiBilgi.Name = "cbVerilmeyeHazirMiBilgi";
            this.cbVerilmeyeHazirMiBilgi.Size = new System.Drawing.Size(161, 22);
            this.cbVerilmeyeHazirMiBilgi.TabIndex = 7;
            this.cbVerilmeyeHazirMiBilgi.Text = "Verilmeye Hazır Mı?";
            this.cbVerilmeyeHazirMiBilgi.UseVisualStyleBackColor = true;
            // 
            // nudSayfaSayisiBilgi
            // 
            this.nudSayfaSayisiBilgi.Location = new System.Drawing.Point(210, 119);
            this.nudSayfaSayisiBilgi.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSayfaSayisiBilgi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSayfaSayisiBilgi.Name = "nudSayfaSayisiBilgi";
            this.nudSayfaSayisiBilgi.Size = new System.Drawing.Size(142, 22);
            this.nudSayfaSayisiBilgi.TabIndex = 5;
            this.nudSayfaSayisiBilgi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(453, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Baskı Yılı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(674, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Tür";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yazar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Sayfa Sayısı";
            // 
            // txtBaskiYiliBilgi
            // 
            this.txtBaskiYiliBilgi.Location = new System.Drawing.Point(414, 118);
            this.txtBaskiYiliBilgi.MaxLength = 4;
            this.txtBaskiYiliBilgi.Name = "txtBaskiYiliBilgi";
            this.txtBaskiYiliBilgi.Size = new System.Drawing.Size(142, 22);
            this.txtBaskiYiliBilgi.TabIndex = 6;
            this.txtBaskiYiliBilgi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBaskiYiliBilgi_KeyPress);
            // 
            // txtYayineviBilgi
            // 
            this.txtYayineviBilgi.Location = new System.Drawing.Point(6, 118);
            this.txtYayineviBilgi.MaxLength = 50;
            this.txtYayineviBilgi.Name = "txtYayineviBilgi";
            this.txtYayineviBilgi.Size = new System.Drawing.Size(142, 22);
            this.txtYayineviBilgi.TabIndex = 4;
            // 
            // txtTurBilgi
            // 
            this.txtTurBilgi.Location = new System.Drawing.Point(618, 50);
            this.txtTurBilgi.MaxLength = 50;
            this.txtTurBilgi.Name = "txtTurBilgi";
            this.txtTurBilgi.Size = new System.Drawing.Size(142, 22);
            this.txtTurBilgi.TabIndex = 3;
            this.txtTurBilgi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTurBilgi_KeyPress);
            // 
            // txtYazarBilgi
            // 
            this.txtYazarBilgi.Location = new System.Drawing.Point(414, 50);
            this.txtYazarBilgi.MaxLength = 50;
            this.txtYazarBilgi.Name = "txtYazarBilgi";
            this.txtYazarBilgi.Size = new System.Drawing.Size(142, 22);
            this.txtYazarBilgi.TabIndex = 2;
            this.txtYazarBilgi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYazarBilgi_KeyPress);
            // 
            // txtKitapAdiBilgi
            // 
            this.txtKitapAdiBilgi.Location = new System.Drawing.Point(210, 50);
            this.txtKitapAdiBilgi.MaxLength = 50;
            this.txtKitapAdiBilgi.Name = "txtKitapAdiBilgi";
            this.txtKitapAdiBilgi.Size = new System.Drawing.Size(142, 22);
            this.txtKitapAdiBilgi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kitap Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yayınevi";
            // 
            // txtBarkodBilgi
            // 
            this.txtBarkodBilgi.Location = new System.Drawing.Point(6, 50);
            this.txtBarkodBilgi.MaxLength = 13;
            this.txtBarkodBilgi.Name = "txtBarkodBilgi";
            this.txtBarkodBilgi.Size = new System.Drawing.Size(142, 22);
            this.txtBarkodBilgi.TabIndex = 0;
            this.txtBarkodBilgi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarkodBilgi_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Barkod";
            // 
            // gboxIslemler
            // 
            this.gboxIslemler.Controls.Add(this.rbtnGuncelle);
            this.gboxIslemler.Controls.Add(this.rbtnSil);
            this.gboxIslemler.Controls.Add(this.rbtnEkle);
            this.gboxIslemler.Location = new System.Drawing.Point(544, 40);
            this.gboxIslemler.Name = "gboxIslemler";
            this.gboxIslemler.Size = new System.Drawing.Size(113, 193);
            this.gboxIslemler.TabIndex = 0;
            this.gboxIslemler.TabStop = false;
            this.gboxIslemler.Text = "İşlemler";
            // 
            // rbtnGuncelle
            // 
            this.rbtnGuncelle.AutoSize = true;
            this.rbtnGuncelle.Location = new System.Drawing.Point(15, 140);
            this.rbtnGuncelle.Name = "rbtnGuncelle";
            this.rbtnGuncelle.Size = new System.Drawing.Size(85, 21);
            this.rbtnGuncelle.TabIndex = 2;
            this.rbtnGuncelle.TabStop = true;
            this.rbtnGuncelle.Text = "Güncelle";
            this.rbtnGuncelle.UseVisualStyleBackColor = true;
            this.rbtnGuncelle.CheckedChanged += new System.EventHandler(this.rbtnGuncelle_CheckedChanged);
            // 
            // rbtnSil
            // 
            this.rbtnSil.AutoSize = true;
            this.rbtnSil.Location = new System.Drawing.Point(15, 90);
            this.rbtnSil.Name = "rbtnSil";
            this.rbtnSil.Size = new System.Drawing.Size(44, 21);
            this.rbtnSil.TabIndex = 1;
            this.rbtnSil.TabStop = true;
            this.rbtnSil.Text = "Sil";
            this.rbtnSil.UseVisualStyleBackColor = true;
            this.rbtnSil.CheckedChanged += new System.EventHandler(this.rbtnSil_CheckedChanged);
            // 
            // rbtnEkle
            // 
            this.rbtnEkle.AutoSize = true;
            this.rbtnEkle.Location = new System.Drawing.Point(15, 41);
            this.rbtnEkle.Name = "rbtnEkle";
            this.rbtnEkle.Size = new System.Drawing.Size(56, 21);
            this.rbtnEkle.TabIndex = 0;
            this.rbtnEkle.TabStop = true;
            this.rbtnEkle.Text = "Ekle";
            this.rbtnEkle.UseVisualStyleBackColor = true;
            this.rbtnEkle.CheckedChanged += new System.EventHandler(this.rbtnEkle_CheckedChanged);
            // 
            // gboxKitaplar
            // 
            this.gboxKitaplar.Controls.Add(this.tabloGizleyici);
            this.gboxKitaplar.Controls.Add(this.groupBox5);
            this.gboxKitaplar.Controls.Add(this.dataKitap);
            this.gboxKitaplar.Enabled = false;
            this.gboxKitaplar.Location = new System.Drawing.Point(21, 40);
            this.gboxKitaplar.Name = "gboxKitaplar";
            this.gboxKitaplar.Size = new System.Drawing.Size(505, 193);
            this.gboxKitaplar.TabIndex = 20;
            this.gboxKitaplar.TabStop = false;
            this.gboxKitaplar.Text = "Kitaplar";
            // 
            // tabloGizleyici
            // 
            this.tabloGizleyici.BackColor = System.Drawing.Color.DarkGray;
            this.tabloGizleyici.Location = new System.Drawing.Point(6, 31);
            this.tabloGizleyici.Name = "tabloGizleyici";
            this.tabloGizleyici.Size = new System.Drawing.Size(301, 150);
            this.tabloGizleyici.TabIndex = 25;
            this.tabloGizleyici.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtKitapAdi);
            this.groupBox5.Controls.Add(this.txtBarkod);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(319, 23);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(171, 158);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Filtrele";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(15, 117);
            this.txtKitapAdi.MaxLength = 50;
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(142, 22);
            this.txtKitapAdi.TabIndex = 1;
            this.txtKitapAdi.TextChanged += new System.EventHandler(this.txtKitapAdi_TextChanged);
            this.txtKitapAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKitapAdi_KeyPress);
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(15, 41);
            this.txtBarkod.MaxLength = 13;
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(142, 22);
            this.txtBarkod.TabIndex = 0;
            this.txtBarkod.TextChanged += new System.EventHandler(this.txtBarkod_TextChanged);
            this.txtBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarkod_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kitap Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "veya";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Barkod";
            // 
            // dataKitap
            // 
            this.dataKitap.AllowUserToAddRows = false;
            this.dataKitap.AllowUserToDeleteRows = false;
            this.dataKitap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKitap.Location = new System.Drawing.Point(6, 31);
            this.dataKitap.MultiSelect = false;
            this.dataKitap.Name = "dataKitap";
            this.dataKitap.ReadOnly = true;
            this.dataKitap.RowHeadersWidth = 51;
            this.dataKitap.RowTemplate.Height = 24;
            this.dataKitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataKitap.Size = new System.Drawing.Size(301, 150);
            this.dataKitap.TabIndex = 3;
            this.dataKitap.SelectionChanged += new System.EventHandler(this.dataKitap_SelectionChanged);
            // 
            // btnKitapGorseliYukle
            // 
            this.btnKitapGorseliYukle.Location = new System.Drawing.Point(844, 374);
            this.btnKitapGorseliYukle.Name = "btnKitapGorseliYukle";
            this.btnKitapGorseliYukle.Size = new System.Drawing.Size(161, 40);
            this.btnKitapGorseliYukle.TabIndex = 24;
            this.btnKitapGorseliYukle.Text = "Kitap Görseli Yükle";
            this.btnKitapGorseliYukle.UseVisualStyleBackColor = true;
            this.btnKitapGorseliYukle.Click += new System.EventHandler(this.btnKitapGorseliYukle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pboxKitap
            // 
            this.pboxKitap.Location = new System.Drawing.Point(813, 42);
            this.pboxKitap.Name = "pboxKitap";
            this.pboxKitap.Size = new System.Drawing.Size(223, 326);
            this.pboxKitap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxKitap.TabIndex = 23;
            this.pboxKitap.TabStop = false;
            // 
            // KitapIslemleriSayfasi
            // 
            this.AcceptButton = this.btnUygula;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 427);
            this.Controls.Add(this.btnKitapGorseliYukle);
            this.Controls.Add(this.pboxKitap);
            this.Controls.Add(this.btnUygula);
            this.Controls.Add(this.gboxBilgiler);
            this.Controls.Add(this.gboxIslemler);
            this.Controls.Add(this.gboxKitaplar);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KitapIslemleriSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KitapIslemleriSayfasi_FormClosed);
            this.Load += new System.EventHandler(this.KitapIslemleriSayfasi_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gboxBilgiler.ResumeLayout(false);
            this.gboxBilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSayfaSayisiBilgi)).EndInit();
            this.gboxIslemler.ResumeLayout(false);
            this.gboxIslemler.PerformLayout();
            this.gboxKitaplar.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKitap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button btnUygula;
        private System.Windows.Forms.GroupBox gboxBilgiler;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKitapAdiBilgi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBarkodBilgi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gboxIslemler;
        private System.Windows.Forms.RadioButton rbtnGuncelle;
        private System.Windows.Forms.RadioButton rbtnSil;
        private System.Windows.Forms.RadioButton rbtnEkle;
        private System.Windows.Forms.GroupBox gboxKitaplar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataKitap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTurBilgi;
        private System.Windows.Forms.TextBox txtYazarBilgi;
        private System.Windows.Forms.TextBox txtYayineviBilgi;
        private System.Windows.Forms.NumericUpDown nudSayfaSayisiBilgi;
        private System.Windows.Forms.TextBox txtBaskiYiliBilgi;
        private System.Windows.Forms.CheckBox cbVerilmeyeHazirMiBilgi;
        private System.Windows.Forms.PictureBox pboxKitap;
        private System.Windows.Forms.Button btnKitapGorseliYukle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel tabloGizleyici;
    }
}