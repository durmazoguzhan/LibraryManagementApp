using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kutuphane.Presentation
{
    public partial class YetkiliPaneli : Form
    {
        public YetkiliPaneli()
        {
            InitializeComponent();
        }

        private void YetkiliPaneli_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //bu form kapatıldığında tüm programı kapat
        }

        private void pboxBuyult(object sender, EventArgs e)
        {
            (sender as PictureBox).Size = new Size(165, 165); //mouse ile üstüne gelindiğinde pictureboxın boyunu büyült
        }

        private void pboxKucult(object sender, EventArgs e)
        {
            (sender as PictureBox).Size = new Size(150, 150); //mouse'u üstünden çektiğinde pictureboxın boyunu
                                                              //Küçült/normal boyuta getir
        }

        private void pboxOgrenci_Click(object sender, EventArgs e)
        {
            this.Hide(); //bu formu gizle
            if (Application.OpenForms["ogrenciIslemleriSayfasi"] == null)
            {
                OgrenciIslemleriSayfasi ogrenciIslemleriSayfasi = new OgrenciIslemleriSayfasi();
                //ogrenciIslemleriSayfasi isimli form yoksa oluştur
                ogrenciIslemleriSayfasi.Show(); //ve göster
            }
            else
                Application.OpenForms["ogrenciIslemleriSayfasi"].Show(); //varsa direkt göster
        }

        private void pboxKitap_Click(object sender, EventArgs e)
        {
            this.Hide(); //bu formu gizle
            if (Application.OpenForms["kitapIslemleriSayfasi"] == null)
            {
                KitapIslemleriSayfasi kitapIslemleriSayfasi = new KitapIslemleriSayfasi();
                //kitapIslemleriSayfasi isimli form yoksa oluştur
                kitapIslemleriSayfasi.Show(); //ve göster
            }
            else
                Application.OpenForms["kitapIslemleriSayfasi"].Show(); //varsa direkt göster
        }

        private void pboxGrafik_Click(object sender, EventArgs e)
        {
            this.Hide(); //bu formu gizle
            if (Application.OpenForms["grafikSayfasi"] == null)
            {
                GrafikSayfasi grafikSayfasi = new GrafikSayfasi();
                //grafikSayfasi isimli form yoksa oluştur
                grafikSayfasi.Show(); //ve göster
            }
            else
                Application.OpenForms["grafikSayfasi"].Show(); //varsa direkt göster
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide(); //bu formu gizle
            Application.OpenForms["Anasayfa"].Show(); //Anasayfa formunu göster
        }
    }
}
