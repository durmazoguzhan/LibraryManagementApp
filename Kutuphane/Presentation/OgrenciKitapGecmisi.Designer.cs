
namespace Kutuphane.Presentation
{
    partial class OgrenciKitapGecmisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciKitapGecmisi));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataOgrenci = new System.Windows.Forms.DataGridView();
            this.gboxTeslimEdilenler = new System.Windows.Forms.GroupBox();
            this.dataTeslimEdilmis = new System.Windows.Forms.DataGridView();
            this.gboxTeslimEdilmeyenler = new System.Windows.Forms.GroupBox();
            this.dataTeslimEdilmemis = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOgrenci)).BeginInit();
            this.gboxTeslimEdilenler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTeslimEdilmis)).BeginInit();
            this.gboxTeslimEdilmeyenler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTeslimEdilmemis)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.dataOgrenci);
            this.groupBox4.Location = new System.Drawing.Point(12, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(620, 193);
            this.groupBox4.TabIndex = 7;
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
            this.groupBox5.Location = new System.Drawing.Point(436, 24);
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
            this.dataOgrenci.Size = new System.Drawing.Size(417, 150);
            this.dataOgrenci.TabIndex = 3;
            this.dataOgrenci.SelectionChanged += new System.EventHandler(this.dataOgrenci_SelectionChanged);
            // 
            // gboxTeslimEdilenler
            // 
            this.gboxTeslimEdilenler.Controls.Add(this.dataTeslimEdilmis);
            this.gboxTeslimEdilenler.Location = new System.Drawing.Point(73, 251);
            this.gboxTeslimEdilenler.Name = "gboxTeslimEdilenler";
            this.gboxTeslimEdilenler.Size = new System.Drawing.Size(494, 390);
            this.gboxTeslimEdilenler.TabIndex = 8;
            this.gboxTeslimEdilenler.TabStop = false;
            this.gboxTeslimEdilenler.Text = "Teslim Edilmiş Kitaplar";
            // 
            // dataTeslimEdilmis
            // 
            this.dataTeslimEdilmis.AllowUserToAddRows = false;
            this.dataTeslimEdilmis.AllowUserToDeleteRows = false;
            this.dataTeslimEdilmis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataTeslimEdilmis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTeslimEdilmis.Location = new System.Drawing.Point(9, 30);
            this.dataTeslimEdilmis.MultiSelect = false;
            this.dataTeslimEdilmis.Name = "dataTeslimEdilmis";
            this.dataTeslimEdilmis.ReadOnly = true;
            this.dataTeslimEdilmis.RowHeadersWidth = 51;
            this.dataTeslimEdilmis.RowTemplate.Height = 24;
            this.dataTeslimEdilmis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTeslimEdilmis.Size = new System.Drawing.Size(479, 350);
            this.dataTeslimEdilmis.TabIndex = 3;
            this.dataTeslimEdilmis.SelectionChanged += new System.EventHandler(this.dataTeslimEdilmis_SelectionChanged);
            // 
            // gboxTeslimEdilmeyenler
            // 
            this.gboxTeslimEdilmeyenler.Controls.Add(this.dataTeslimEdilmemis);
            this.gboxTeslimEdilmeyenler.Location = new System.Drawing.Point(73, 647);
            this.gboxTeslimEdilmeyenler.Name = "gboxTeslimEdilmeyenler";
            this.gboxTeslimEdilmeyenler.Size = new System.Drawing.Size(500, 156);
            this.gboxTeslimEdilmeyenler.TabIndex = 8;
            this.gboxTeslimEdilmeyenler.TabStop = false;
            this.gboxTeslimEdilmeyenler.Text = "Teslim Edilmemiş Kitaplar";
            // 
            // dataTeslimEdilmemis
            // 
            this.dataTeslimEdilmemis.AllowUserToAddRows = false;
            this.dataTeslimEdilmemis.AllowUserToDeleteRows = false;
            this.dataTeslimEdilmemis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataTeslimEdilmemis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTeslimEdilmemis.Location = new System.Drawing.Point(9, 30);
            this.dataTeslimEdilmemis.MultiSelect = false;
            this.dataTeslimEdilmemis.Name = "dataTeslimEdilmemis";
            this.dataTeslimEdilmemis.ReadOnly = true;
            this.dataTeslimEdilmemis.RowHeadersWidth = 51;
            this.dataTeslimEdilmemis.RowTemplate.Height = 24;
            this.dataTeslimEdilmemis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTeslimEdilmemis.Size = new System.Drawing.Size(485, 120);
            this.dataTeslimEdilmemis.TabIndex = 3;
            this.dataTeslimEdilmemis.SelectionChanged += new System.EventHandler(this.dataTeslimEdilmemis_SelectionChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(647, 27);
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
            // OgrenciKitapGecmisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 810);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gboxTeslimEdilmeyenler);
            this.Controls.Add(this.gboxTeslimEdilenler);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OgrenciKitapGecmisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Kitap Geçmişi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OgrenciKitapGecmisi_FormClosed);
            this.Load += new System.EventHandler(this.OgrenciKitapGecmisi_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOgrenci)).EndInit();
            this.gboxTeslimEdilenler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTeslimEdilmis)).EndInit();
            this.gboxTeslimEdilmeyenler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTeslimEdilmemis)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataOgrenci;
        private System.Windows.Forms.GroupBox gboxTeslimEdilenler;
        private System.Windows.Forms.DataGridView dataTeslimEdilmis;
        private System.Windows.Forms.GroupBox gboxTeslimEdilmeyenler;
        private System.Windows.Forms.DataGridView dataTeslimEdilmemis;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}