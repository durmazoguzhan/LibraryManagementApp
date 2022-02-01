
namespace Kutuphane.Presentation
{
    partial class YetkiliPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YetkiliPaneli));
            this.lblGrafik = new System.Windows.Forms.Label();
            this.lblKitap = new System.Windows.Forms.Label();
            this.lblOgrenci = new System.Windows.Forms.Label();
            this.pboxGrafik = new System.Windows.Forms.PictureBox();
            this.pboxKitap = new System.Windows.Forms.PictureBox();
            this.pboxOgrenci = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pboxGrafik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxOgrenci)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGrafik
            // 
            this.lblGrafik.AutoSize = true;
            this.lblGrafik.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrafik.Location = new System.Drawing.Point(471, 241);
            this.lblGrafik.Name = "lblGrafik";
            this.lblGrafik.Size = new System.Drawing.Size(141, 38);
            this.lblGrafik.TabIndex = 5;
            this.lblGrafik.Text = "Kütüphane Kitap\r\nGrafiği";
            this.lblGrafik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKitap
            // 
            this.lblKitap.AutoSize = true;
            this.lblKitap.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitap.Location = new System.Drawing.Point(272, 241);
            this.lblKitap.Name = "lblKitap";
            this.lblKitap.Size = new System.Drawing.Size(139, 57);
            this.lblKitap.TabIndex = 6;
            this.lblKitap.Text = "Kitap\r\nEkle/Sil/Güncelle\r\nİşlemleri";
            this.lblKitap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOgrenci
            // 
            this.lblOgrenci.AutoSize = true;
            this.lblOgrenci.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOgrenci.Location = new System.Drawing.Point(72, 241);
            this.lblOgrenci.Name = "lblOgrenci";
            this.lblOgrenci.Size = new System.Drawing.Size(139, 57);
            this.lblOgrenci.TabIndex = 7;
            this.lblOgrenci.Text = "Öğrenci\r\nEkle/Sil/Güncelle\r\nİşlemleri";
            this.lblOgrenci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pboxGrafik
            // 
            this.pboxGrafik.Image = global::Kutuphane.Properties.Resources.grafik;
            this.pboxGrafik.Location = new System.Drawing.Point(466, 70);
            this.pboxGrafik.Name = "pboxGrafik";
            this.pboxGrafik.Size = new System.Drawing.Size(150, 150);
            this.pboxGrafik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxGrafik.TabIndex = 2;
            this.pboxGrafik.TabStop = false;
            this.pboxGrafik.Click += new System.EventHandler(this.pboxGrafik_Click);
            this.pboxGrafik.MouseEnter += new System.EventHandler(this.pboxBuyult);
            this.pboxGrafik.MouseLeave += new System.EventHandler(this.pboxKucult);
            // 
            // pboxKitap
            // 
            this.pboxKitap.Image = global::Kutuphane.Properties.Resources.kitap;
            this.pboxKitap.Location = new System.Drawing.Point(266, 70);
            this.pboxKitap.Name = "pboxKitap";
            this.pboxKitap.Size = new System.Drawing.Size(150, 150);
            this.pboxKitap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxKitap.TabIndex = 3;
            this.pboxKitap.TabStop = false;
            this.pboxKitap.Click += new System.EventHandler(this.pboxKitap_Click);
            this.pboxKitap.MouseEnter += new System.EventHandler(this.pboxBuyult);
            this.pboxKitap.MouseLeave += new System.EventHandler(this.pboxKucult);
            // 
            // pboxOgrenci
            // 
            this.pboxOgrenci.Image = global::Kutuphane.Properties.Resources.ogrenci;
            this.pboxOgrenci.Location = new System.Drawing.Point(66, 70);
            this.pboxOgrenci.Name = "pboxOgrenci";
            this.pboxOgrenci.Size = new System.Drawing.Size(150, 150);
            this.pboxOgrenci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxOgrenci.TabIndex = 4;
            this.pboxOgrenci.TabStop = false;
            this.pboxOgrenci.Click += new System.EventHandler(this.pboxOgrenci_Click);
            this.pboxOgrenci.MouseEnter += new System.EventHandler(this.pboxBuyult);
            this.pboxOgrenci.MouseLeave += new System.EventHandler(this.pboxKucult);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(682, 27);
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
            // YetkiliPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 353);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblGrafik);
            this.Controls.Add(this.lblKitap);
            this.Controls.Add(this.lblOgrenci);
            this.Controls.Add(this.pboxGrafik);
            this.Controls.Add(this.pboxKitap);
            this.Controls.Add(this.pboxOgrenci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "YetkiliPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetkili Paneli";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.YetkiliPaneli_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pboxGrafik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxOgrenci)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrafik;
        private System.Windows.Forms.Label lblKitap;
        private System.Windows.Forms.Label lblOgrenci;
        private System.Windows.Forms.PictureBox pboxGrafik;
        private System.Windows.Forms.PictureBox pboxKitap;
        private System.Windows.Forms.PictureBox pboxOgrenci;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}