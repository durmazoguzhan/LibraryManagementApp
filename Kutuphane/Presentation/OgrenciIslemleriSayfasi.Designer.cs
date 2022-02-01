
namespace Kutuphane.Presentation
{
    partial class OgrenciIslemleriSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciIslemleriSayfasi));
            this.gboxOgrenciler = new System.Windows.Forms.GroupBox();
            this.tabloGizleyici = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataOgrenci = new System.Windows.Forms.DataGridView();
            this.gboxIslemler = new System.Windows.Forms.GroupBox();
            this.rbtnGuncelle = new System.Windows.Forms.RadioButton();
            this.rbtnSil = new System.Windows.Forms.RadioButton();
            this.rbtnEkle = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTCBilgi = new System.Windows.Forms.TextBox();
            this.gboxBilgiler = new System.Windows.Forms.GroupBox();
            this.nudCezaBilgi = new System.Windows.Forms.NumericUpDown();
            this.dtpUyelikTarihiBilgi = new System.Windows.Forms.DateTimePicker();
            this.dtpDogumTarihiBilgi = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cboxCinsiyetBilgi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdSoyadBilgi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUygula = new System.Windows.Forms.Button();
            this.gboxOgrenciler.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOgrenci)).BeginInit();
            this.gboxIslemler.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.gboxBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCezaBilgi)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxOgrenciler
            // 
            this.gboxOgrenciler.Controls.Add(this.tabloGizleyici);
            this.gboxOgrenciler.Controls.Add(this.groupBox5);
            this.gboxOgrenciler.Controls.Add(this.dataOgrenci);
            this.gboxOgrenciler.Enabled = false;
            this.gboxOgrenciler.Location = new System.Drawing.Point(19, 45);
            this.gboxOgrenciler.Name = "gboxOgrenciler";
            this.gboxOgrenciler.Size = new System.Drawing.Size(505, 193);
            this.gboxOgrenciler.TabIndex = 14;
            this.gboxOgrenciler.TabStop = false;
            this.gboxOgrenciler.Text = "Öğrenciler";
            // 
            // tabloGizleyici
            // 
            this.tabloGizleyici.BackColor = System.Drawing.Color.DarkGray;
            this.tabloGizleyici.Location = new System.Drawing.Point(6, 31);
            this.tabloGizleyici.Name = "tabloGizleyici";
            this.tabloGizleyici.Size = new System.Drawing.Size(301, 150);
            this.tabloGizleyici.TabIndex = 26;
            this.tabloGizleyici.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtAdSoyad);
            this.groupBox5.Controls.Add(this.txtTC);
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
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(15, 117);
            this.txtAdSoyad.MaxLength = 50;
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(142, 22);
            this.txtAdSoyad.TabIndex = 1;
            this.txtAdSoyad.TextChanged += new System.EventHandler(this.txtAdSoyad_TextChanged);
            this.txtAdSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdSoyad_KeyPress);
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(15, 41);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(142, 22);
            this.txtTC.TabIndex = 0;
            this.txtTC.TextChanged += new System.EventHandler(this.txtTC_TextChanged);
            this.txtTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTC_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ad Soyad";
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
            this.label5.Location = new System.Drawing.Point(73, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "TC";
            // 
            // dataOgrenci
            // 
            this.dataOgrenci.AllowUserToAddRows = false;
            this.dataOgrenci.AllowUserToDeleteRows = false;
            this.dataOgrenci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOgrenci.Location = new System.Drawing.Point(6, 31);
            this.dataOgrenci.MultiSelect = false;
            this.dataOgrenci.Name = "dataOgrenci";
            this.dataOgrenci.ReadOnly = true;
            this.dataOgrenci.RowHeadersWidth = 51;
            this.dataOgrenci.RowTemplate.Height = 24;
            this.dataOgrenci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOgrenci.Size = new System.Drawing.Size(301, 150);
            this.dataOgrenci.TabIndex = 3;
            this.dataOgrenci.SelectionChanged += new System.EventHandler(this.dataOgrenci_SelectionChanged);
            // 
            // gboxIslemler
            // 
            this.gboxIslemler.Controls.Add(this.rbtnGuncelle);
            this.gboxIslemler.Controls.Add(this.rbtnSil);
            this.gboxIslemler.Controls.Add(this.rbtnEkle);
            this.gboxIslemler.Location = new System.Drawing.Point(542, 45);
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
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(678, 27);
            this.toolStrip1.TabIndex = 16;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "TC";
            // 
            // txtTCBilgi
            // 
            this.txtTCBilgi.Location = new System.Drawing.Point(6, 50);
            this.txtTCBilgi.MaxLength = 11;
            this.txtTCBilgi.Name = "txtTCBilgi";
            this.txtTCBilgi.Size = new System.Drawing.Size(142, 22);
            this.txtTCBilgi.TabIndex = 0;
            this.txtTCBilgi.TextChanged += new System.EventHandler(this.txtTC_TextChanged);
            this.txtTCBilgi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTCBilgi_KeyPress);
            // 
            // gboxBilgiler
            // 
            this.gboxBilgiler.Controls.Add(this.nudCezaBilgi);
            this.gboxBilgiler.Controls.Add(this.dtpUyelikTarihiBilgi);
            this.gboxBilgiler.Controls.Add(this.dtpDogumTarihiBilgi);
            this.gboxBilgiler.Controls.Add(this.label9);
            this.gboxBilgiler.Controls.Add(this.cboxCinsiyetBilgi);
            this.gboxBilgiler.Controls.Add(this.label3);
            this.gboxBilgiler.Controls.Add(this.label8);
            this.gboxBilgiler.Controls.Add(this.txtAdSoyadBilgi);
            this.gboxBilgiler.Controls.Add(this.label2);
            this.gboxBilgiler.Controls.Add(this.label6);
            this.gboxBilgiler.Controls.Add(this.txtTCBilgi);
            this.gboxBilgiler.Controls.Add(this.label1);
            this.gboxBilgiler.Enabled = false;
            this.gboxBilgiler.Location = new System.Drawing.Point(19, 256);
            this.gboxBilgiler.Name = "gboxBilgiler";
            this.gboxBilgiler.Size = new System.Drawing.Size(505, 163);
            this.gboxBilgiler.TabIndex = 17;
            this.gboxBilgiler.TabStop = false;
            this.gboxBilgiler.Text = "Bilgiler";
            // 
            // nudCezaBilgi
            // 
            this.nudCezaBilgi.Location = new System.Drawing.Point(357, 118);
            this.nudCezaBilgi.Name = "nudCezaBilgi";
            this.nudCezaBilgi.Size = new System.Drawing.Size(142, 22);
            this.nudCezaBilgi.TabIndex = 20;
            // 
            // dtpUyelikTarihiBilgi
            // 
            this.dtpUyelikTarihiBilgi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUyelikTarihiBilgi.Location = new System.Drawing.Point(181, 118);
            this.dtpUyelikTarihiBilgi.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpUyelikTarihiBilgi.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpUyelikTarihiBilgi.Name = "dtpUyelikTarihiBilgi";
            this.dtpUyelikTarihiBilgi.Size = new System.Drawing.Size(142, 22);
            this.dtpUyelikTarihiBilgi.TabIndex = 19;
            // 
            // dtpDogumTarihiBilgi
            // 
            this.dtpDogumTarihiBilgi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDogumTarihiBilgi.Location = new System.Drawing.Point(6, 118);
            this.dtpDogumTarihiBilgi.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpDogumTarihiBilgi.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDogumTarihiBilgi.Name = "dtpDogumTarihiBilgi";
            this.dtpDogumTarihiBilgi.Size = new System.Drawing.Size(142, 22);
            this.dtpDogumTarihiBilgi.TabIndex = 19;
            this.dtpDogumTarihiBilgi.ValueChanged += new System.EventHandler(this.dtpDogumTarihiBilgi_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(408, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Ceza";
            // 
            // cboxCinsiyetBilgi
            // 
            this.cboxCinsiyetBilgi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCinsiyetBilgi.FormattingEnabled = true;
            this.cboxCinsiyetBilgi.Items.AddRange(new object[] {
            "Erkek",
            "Kız"});
            this.cboxCinsiyetBilgi.Location = new System.Drawing.Point(357, 50);
            this.cboxCinsiyetBilgi.Name = "cboxCinsiyetBilgi";
            this.cboxCinsiyetBilgi.Size = new System.Drawing.Size(142, 24);
            this.cboxCinsiyetBilgi.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cinsiyet";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Üyelik Tarihi";
            // 
            // txtAdSoyadBilgi
            // 
            this.txtAdSoyadBilgi.Location = new System.Drawing.Point(181, 50);
            this.txtAdSoyadBilgi.MaxLength = 50;
            this.txtAdSoyadBilgi.Name = "txtAdSoyadBilgi";
            this.txtAdSoyadBilgi.Size = new System.Drawing.Size(142, 22);
            this.txtAdSoyadBilgi.TabIndex = 0;
            this.txtAdSoyadBilgi.TextChanged += new System.EventHandler(this.txtTC_TextChanged);
            this.txtAdSoyadBilgi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdSoyadBilgi_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ad Soyad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Doğum Tarihi";
            // 
            // btnUygula
            // 
            this.btnUygula.Enabled = false;
            this.btnUygula.Location = new System.Drawing.Point(542, 256);
            this.btnUygula.Name = "btnUygula";
            this.btnUygula.Size = new System.Drawing.Size(113, 163);
            this.btnUygula.TabIndex = 18;
            this.btnUygula.Text = "İşlemi\r\nUygula";
            this.btnUygula.UseVisualStyleBackColor = true;
            this.btnUygula.Click += new System.EventHandler(this.btnUygula_Click);
            // 
            // OgrenciIslemleriSayfasi
            // 
            this.AcceptButton = this.btnUygula;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 430);
            this.Controls.Add(this.btnUygula);
            this.Controls.Add(this.gboxBilgiler);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gboxIslemler);
            this.Controls.Add(this.gboxOgrenciler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OgrenciIslemleriSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OgrenciIslemleriSayfasi_FormClosed);
            this.Load += new System.EventHandler(this.OgrenciIslemleriSayfasi_Load);
            this.gboxOgrenciler.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOgrenci)).EndInit();
            this.gboxIslemler.ResumeLayout(false);
            this.gboxIslemler.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gboxBilgiler.ResumeLayout(false);
            this.gboxBilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCezaBilgi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gboxOgrenciler;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataOgrenci;
        private System.Windows.Forms.GroupBox gboxIslemler;
        private System.Windows.Forms.RadioButton rbtnGuncelle;
        private System.Windows.Forms.RadioButton rbtnSil;
        private System.Windows.Forms.RadioButton rbtnEkle;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTCBilgi;
        private System.Windows.Forms.GroupBox gboxBilgiler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdSoyadBilgi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxCinsiyetBilgi;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihiBilgi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpUyelikTarihiBilgi;
        private System.Windows.Forms.Button btnUygula;
        private System.Windows.Forms.NumericUpDown nudCezaBilgi;
        private System.Windows.Forms.Panel tabloGizleyici;
    }
}