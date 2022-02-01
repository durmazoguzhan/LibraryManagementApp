
namespace Kutuphane.Presentation
{
    partial class KitapExchange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapExchange));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnCezaOdeme = new System.Windows.Forms.RadioButton();
            this.rbtnAlim = new System.Windows.Forms.RadioButton();
            this.rbtnIade = new System.Windows.Forms.RadioButton();
            this.btnIslemGerceklestir = new System.Windows.Forms.Button();
            this.gboxCeza = new System.Windows.Forms.GroupBox();
            this.cboxCezaOdendi = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCeza = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataOgrenci = new System.Windows.Forms.DataGridView();
            this.gboxKitaplar = new System.Windows.Forms.GroupBox();
            this.tabloGizleyici = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataKitap = new System.Windows.Forms.DataGridView();
            this.pboxKitapResim = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.gboxCeza.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOgrenci)).BeginInit();
            this.gboxKitaplar.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKitapResim)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnCezaOdeme);
            this.groupBox1.Controls.Add(this.rbtnAlim);
            this.groupBox1.Controls.Add(this.rbtnIade);
            this.groupBox1.Location = new System.Drawing.Point(23, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yapmak İstediğiniz İşlem";
            // 
            // rbtnCezaOdeme
            // 
            this.rbtnCezaOdeme.AutoSize = true;
            this.rbtnCezaOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCezaOdeme.Location = new System.Drawing.Point(33, 71);
            this.rbtnCezaOdeme.Name = "rbtnCezaOdeme";
            this.rbtnCezaOdeme.Size = new System.Drawing.Size(117, 22);
            this.rbtnCezaOdeme.TabIndex = 2;
            this.rbtnCezaOdeme.Text = "Ceza Ödeme";
            this.rbtnCezaOdeme.UseVisualStyleBackColor = true;
            this.rbtnCezaOdeme.CheckedChanged += new System.EventHandler(this.rbtnCezaOdeme_CheckedChanged);
            // 
            // rbtnAlim
            // 
            this.rbtnAlim.AutoSize = true;
            this.rbtnAlim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAlim.Location = new System.Drawing.Point(105, 39);
            this.rbtnAlim.Name = "rbtnAlim";
            this.rbtnAlim.Size = new System.Drawing.Size(57, 22);
            this.rbtnAlim.TabIndex = 1;
            this.rbtnAlim.Text = "Alım";
            this.rbtnAlim.UseVisualStyleBackColor = true;
            this.rbtnAlim.CheckedChanged += new System.EventHandler(this.KitaplarAktifDeaktif);
            // 
            // rbtnIade
            // 
            this.rbtnIade.AutoSize = true;
            this.rbtnIade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnIade.Location = new System.Drawing.Point(20, 39);
            this.rbtnIade.Name = "rbtnIade";
            this.rbtnIade.Size = new System.Drawing.Size(56, 22);
            this.rbtnIade.TabIndex = 0;
            this.rbtnIade.Text = "İade";
            this.rbtnIade.UseVisualStyleBackColor = true;
            this.rbtnIade.CheckedChanged += new System.EventHandler(this.KitaplarAktifDeaktif);
            // 
            // btnIslemGerceklestir
            // 
            this.btnIslemGerceklestir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIslemGerceklestir.Location = new System.Drawing.Point(531, 40);
            this.btnIslemGerceklestir.Name = "btnIslemGerceklestir";
            this.btnIslemGerceklestir.Size = new System.Drawing.Size(507, 116);
            this.btnIslemGerceklestir.TabIndex = 4;
            this.btnIslemGerceklestir.Text = "İşlemi Gerçekleştir";
            this.btnIslemGerceklestir.UseVisualStyleBackColor = true;
            this.btnIslemGerceklestir.Click += new System.EventHandler(this.btnIslemGerceklestir_Click);
            // 
            // gboxCeza
            // 
            this.gboxCeza.Controls.Add(this.cboxCezaOdendi);
            this.gboxCeza.Controls.Add(this.label1);
            this.gboxCeza.Controls.Add(this.txtCeza);
            this.gboxCeza.Location = new System.Drawing.Point(276, 40);
            this.gboxCeza.Name = "gboxCeza";
            this.gboxCeza.Size = new System.Drawing.Size(207, 116);
            this.gboxCeza.TabIndex = 3;
            this.gboxCeza.TabStop = false;
            this.gboxCeza.Text = "Ceza Durumu";
            // 
            // cboxCezaOdendi
            // 
            this.cboxCezaOdendi.AutoSize = true;
            this.cboxCezaOdendi.Location = new System.Drawing.Point(49, 76);
            this.cboxCezaOdendi.Name = "cboxCezaOdendi";
            this.cboxCezaOdendi.Size = new System.Drawing.Size(112, 21);
            this.cboxCezaOdendi.TabIndex = 0;
            this.cboxCezaOdendi.Text = "Ceza Ödendi";
            this.cboxCezaOdendi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ceza :";
            // 
            // txtCeza
            // 
            this.txtCeza.Location = new System.Drawing.Point(85, 39);
            this.txtCeza.Name = "txtCeza";
            this.txtCeza.ReadOnly = true;
            this.txtCeza.Size = new System.Drawing.Size(89, 22);
            this.txtCeza.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.dataOgrenci);
            this.groupBox4.Location = new System.Drawing.Point(23, 181);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(700, 193);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Öğrenciler";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtAdSoyad);
            this.groupBox5.Controls.Add(this.txtTC);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(519, 23);
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
            this.dataOgrenci.Size = new System.Drawing.Size(507, 150);
            this.dataOgrenci.TabIndex = 3;
            this.dataOgrenci.SelectionChanged += new System.EventHandler(this.dataOgrenci_SelectionChanged);
            // 
            // gboxKitaplar
            // 
            this.gboxKitaplar.Controls.Add(this.tabloGizleyici);
            this.gboxKitaplar.Controls.Add(this.groupBox6);
            this.gboxKitaplar.Controls.Add(this.dataKitap);
            this.gboxKitaplar.Location = new System.Drawing.Point(23, 391);
            this.gboxKitaplar.Name = "gboxKitaplar";
            this.gboxKitaplar.Size = new System.Drawing.Size(700, 253);
            this.gboxKitaplar.TabIndex = 2;
            this.gboxKitaplar.TabStop = false;
            this.gboxKitaplar.Text = "Kitaplar";
            // 
            // tabloGizleyici
            // 
            this.tabloGizleyici.BackColor = System.Drawing.Color.DarkGray;
            this.tabloGizleyici.Location = new System.Drawing.Point(6, 97);
            this.tabloGizleyici.Name = "tabloGizleyici";
            this.tabloGizleyici.Size = new System.Drawing.Size(684, 150);
            this.tabloGizleyici.TabIndex = 27;
            this.tabloGizleyici.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtKitapAdi);
            this.groupBox6.Controls.Add(this.txtBarkod);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Location = new System.Drawing.Point(20, 21);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(670, 60);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Filtrele";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(394, 26);
            this.txtKitapAdi.MaxLength = 50;
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(159, 22);
            this.txtKitapAdi.TabIndex = 1;
            this.txtKitapAdi.TextChanged += new System.EventHandler(this.txtKitapAdi_TextChanged);
            this.txtKitapAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKitapAdi_KeyPress);
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(87, 26);
            this.txtBarkod.MaxLength = 13;
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(142, 22);
            this.txtBarkod.TabIndex = 0;
            this.txtBarkod.TextChanged += new System.EventHandler(this.txtBarkod_TextChanged);
            this.txtBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarkod_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kitap Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "veya";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Barkod :";
            // 
            // dataKitap
            // 
            this.dataKitap.AllowUserToAddRows = false;
            this.dataKitap.AllowUserToDeleteRows = false;
            this.dataKitap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKitap.Location = new System.Drawing.Point(6, 97);
            this.dataKitap.MultiSelect = false;
            this.dataKitap.Name = "dataKitap";
            this.dataKitap.ReadOnly = true;
            this.dataKitap.RowHeadersWidth = 51;
            this.dataKitap.RowTemplate.Height = 24;
            this.dataKitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataKitap.Size = new System.Drawing.Size(684, 150);
            this.dataKitap.TabIndex = 3;
            this.dataKitap.SelectionChanged += new System.EventHandler(this.dataKitap_SelectionChanged);
            // 
            // pboxKitapResim
            // 
            this.pboxKitapResim.Location = new System.Drawing.Point(756, 181);
            this.pboxKitapResim.Name = "pboxKitapResim";
            this.pboxKitapResim.Size = new System.Drawing.Size(282, 463);
            this.pboxKitapResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxKitapResim.TabIndex = 5;
            this.pboxKitapResim.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1063, 27);
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
            // KitapExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 659);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pboxKitapResim);
            this.Controls.Add(this.gboxKitaplar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnIslemGerceklestir);
            this.Controls.Add(this.gboxCeza);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KitapExchange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Alma/İade İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KitapExchange_FormClosed);
            this.Load += new System.EventHandler(this.KitapExchange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboxCeza.ResumeLayout(false);
            this.gboxCeza.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOgrenci)).EndInit();
            this.gboxKitaplar.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKitapResim)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnAlim;
        private System.Windows.Forms.RadioButton rbtnIade;
        private System.Windows.Forms.Button btnIslemGerceklestir;
        private System.Windows.Forms.GroupBox gboxCeza;
        private System.Windows.Forms.TextBox txtCeza;
        private System.Windows.Forms.RadioButton rbtnCezaOdeme;
        private System.Windows.Forms.CheckBox cboxCezaOdendi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.DataGridView dataOgrenci;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gboxKitaplar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataKitap;
        private System.Windows.Forms.PictureBox pboxKitapResim;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel tabloGizleyici;
    }
}