
namespace Kutuphane.Presentation
{
    partial class DetayliKitapBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetayliKitapBilgileri));
            this.gboxKitaplar = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataKitap = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataTeslimAlanEden = new System.Windows.Forms.DataGridView();
            this.pboxKitapResim = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.gboxKitaplar.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKitap)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTeslimAlanEden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKitapResim)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxKitaplar
            // 
            this.gboxKitaplar.Controls.Add(this.groupBox6);
            this.gboxKitaplar.Controls.Add(this.dataKitap);
            this.gboxKitaplar.Location = new System.Drawing.Point(12, 38);
            this.gboxKitaplar.Name = "gboxKitaplar";
            this.gboxKitaplar.Size = new System.Drawing.Size(1070, 296);
            this.gboxKitaplar.TabIndex = 9;
            this.gboxKitaplar.TabStop = false;
            this.gboxKitaplar.Text = "Kitaplar";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtKitapAdi);
            this.groupBox6.Controls.Add(this.txtBarkod);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Location = new System.Drawing.Point(244, 21);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(582, 60);
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
            this.txtBarkod.MaxLength = 11;
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
            this.dataKitap.Size = new System.Drawing.Size(1053, 190);
            this.dataKitap.TabIndex = 3;
            this.dataKitap.SelectionChanged += new System.EventHandler(this.dataKitap_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataTeslimAlanEden);
            this.groupBox1.Location = new System.Drawing.Point(12, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 229);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitabı Teslim Alan/Eden Kişiler";
            // 
            // dataTeslimAlanEden
            // 
            this.dataTeslimAlanEden.AllowUserToAddRows = false;
            this.dataTeslimAlanEden.AllowUserToDeleteRows = false;
            this.dataTeslimAlanEden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataTeslimAlanEden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTeslimAlanEden.Location = new System.Drawing.Point(6, 28);
            this.dataTeslimAlanEden.MultiSelect = false;
            this.dataTeslimAlanEden.Name = "dataTeslimAlanEden";
            this.dataTeslimAlanEden.ReadOnly = true;
            this.dataTeslimAlanEden.RowHeadersWidth = 51;
            this.dataTeslimAlanEden.RowTemplate.Height = 24;
            this.dataTeslimAlanEden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTeslimAlanEden.Size = new System.Drawing.Size(407, 190);
            this.dataTeslimAlanEden.TabIndex = 3;
            // 
            // pboxKitapResim
            // 
            this.pboxKitapResim.Location = new System.Drawing.Point(472, 351);
            this.pboxKitapResim.Name = "pboxKitapResim";
            this.pboxKitapResim.Size = new System.Drawing.Size(584, 229);
            this.pboxKitapResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxKitapResim.TabIndex = 10;
            this.pboxKitapResim.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1096, 27);
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
            // DetayliKitapBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 595);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pboxKitapResim);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxKitaplar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DetayliKitapBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detaylı Kitap Bilgileri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DetayliKitapBilgileri_FormClosed);
            this.Load += new System.EventHandler(this.DetayliKitapBilgileri_Load);
            this.gboxKitaplar.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKitap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTeslimAlanEden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKitapResim)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gboxKitaplar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataKitap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataTeslimAlanEden;
        private System.Windows.Forms.PictureBox pboxKitapResim;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}