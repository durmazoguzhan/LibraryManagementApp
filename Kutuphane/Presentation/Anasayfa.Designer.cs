
namespace Kutuphane
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.lblKitapExchange = new System.Windows.Forms.Label();
            this.lblKitapHistory = new System.Windows.Forms.Label();
            this.lblKitapInfo = new System.Windows.Forms.Label();
            this.pboxKitapInfo = new System.Windows.Forms.PictureBox();
            this.pboxKitapHistory = new System.Windows.Forms.PictureBox();
            this.pboxKitapExchange = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKitapInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKitapHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKitapExchange)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKitapExchange
            // 
            this.lblKitapExchange.AutoSize = true;
            this.lblKitapExchange.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitapExchange.Location = new System.Drawing.Point(77, 245);
            this.lblKitapExchange.Name = "lblKitapExchange";
            this.lblKitapExchange.Size = new System.Drawing.Size(129, 38);
            this.lblKitapExchange.TabIndex = 1;
            this.lblKitapExchange.Text = "Kitap Alma/İade\r\nİşlemleri";
            this.lblKitapExchange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKitapHistory
            // 
            this.lblKitapHistory.AutoSize = true;
            this.lblKitapHistory.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitapHistory.Location = new System.Drawing.Point(283, 245);
            this.lblKitapHistory.Name = "lblKitapHistory";
            this.lblKitapHistory.Size = new System.Drawing.Size(117, 38);
            this.lblKitapHistory.TabIndex = 1;
            this.lblKitapHistory.Text = "Öğrenci Kitap\r\nGeçmişi";
            this.lblKitapHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKitapInfo
            // 
            this.lblKitapInfo.AutoSize = true;
            this.lblKitapInfo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitapInfo.Location = new System.Drawing.Point(485, 245);
            this.lblKitapInfo.Name = "lblKitapInfo";
            this.lblKitapInfo.Size = new System.Drawing.Size(113, 38);
            this.lblKitapInfo.TabIndex = 1;
            this.lblKitapInfo.Text = "Kitap Bilgileri\r\nSorgulama";
            this.lblKitapInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pboxKitapInfo
            // 
            this.pboxKitapInfo.Image = global::Kutuphane.Properties.Resources.bookinfo;
            this.pboxKitapInfo.Location = new System.Drawing.Point(466, 69);
            this.pboxKitapInfo.Name = "pboxKitapInfo";
            this.pboxKitapInfo.Size = new System.Drawing.Size(150, 150);
            this.pboxKitapInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxKitapInfo.TabIndex = 0;
            this.pboxKitapInfo.TabStop = false;
            this.pboxKitapInfo.Click += new System.EventHandler(this.pboxKitapInfo_Click);
            this.pboxKitapInfo.MouseEnter += new System.EventHandler(this.pboxBuyult);
            this.pboxKitapInfo.MouseLeave += new System.EventHandler(this.pboxKucult);
            // 
            // pboxKitapHistory
            // 
            this.pboxKitapHistory.Image = global::Kutuphane.Properties.Resources.bookhistory;
            this.pboxKitapHistory.Location = new System.Drawing.Point(266, 69);
            this.pboxKitapHistory.Name = "pboxKitapHistory";
            this.pboxKitapHistory.Size = new System.Drawing.Size(150, 150);
            this.pboxKitapHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxKitapHistory.TabIndex = 0;
            this.pboxKitapHistory.TabStop = false;
            this.pboxKitapHistory.Click += new System.EventHandler(this.pboxKitapHistory_Click);
            this.pboxKitapHistory.MouseEnter += new System.EventHandler(this.pboxBuyult);
            this.pboxKitapHistory.MouseLeave += new System.EventHandler(this.pboxKucult);
            // 
            // pboxKitapExchange
            // 
            this.pboxKitapExchange.Image = global::Kutuphane.Properties.Resources.bookexchange;
            this.pboxKitapExchange.Location = new System.Drawing.Point(66, 69);
            this.pboxKitapExchange.Name = "pboxKitapExchange";
            this.pboxKitapExchange.Size = new System.Drawing.Size(150, 150);
            this.pboxKitapExchange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxKitapExchange.TabIndex = 0;
            this.pboxKitapExchange.TabStop = false;
            this.pboxKitapExchange.Click += new System.EventHandler(this.pboxKitapExchange_Click);
            this.pboxKitapExchange.MouseEnter += new System.EventHandler(this.pboxBuyult);
            this.pboxKitapExchange.MouseLeave += new System.EventHandler(this.pboxKucult);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 353);
            this.Controls.Add(this.lblKitapInfo);
            this.Controls.Add(this.lblKitapHistory);
            this.Controls.Add(this.lblKitapExchange);
            this.Controls.Add(this.pboxKitapInfo);
            this.Controls.Add(this.pboxKitapHistory);
            this.Controls.Add(this.pboxKitapExchange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Anasayfa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pboxKitapInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKitapHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKitapExchange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxKitapExchange;
        private System.Windows.Forms.PictureBox pboxKitapHistory;
        private System.Windows.Forms.PictureBox pboxKitapInfo;
        private System.Windows.Forms.Label lblKitapExchange;
        private System.Windows.Forms.Label lblKitapHistory;
        private System.Windows.Forms.Label lblKitapInfo;
    }
}

