using Kutuphane.Presentation;
using System;
using System.Drawing;
using System.Windows.Forms;
using Kutuphane.Business;
using System.Diagnostics;
using System.IO;

namespace Kutuphane
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void pboxBuyult(object sender, EventArgs e)
        {
            (sender as PictureBox).Size = new Size((sender as PictureBox).Size.Width+10, (sender as PictureBox).Size.Width + 10); //resmin üstüne gelindiğinde resmi büyült.
        }

        private void pboxKucult(object sender, EventArgs e)
        {
            (sender as PictureBox).Size = new Size((sender as PictureBox).Size.Width - 10, (sender as PictureBox).Size.Width - 10); //resmin üstüne gelindiğinde resmi küçült/normal haline getir.
        }

        private void pboxKitapExchange_Click(object sender, EventArgs e)
        {
            this.Hide(); //bu formu gizle
            if (Application.OpenForms["kitapExchange"] == null) //eğer daha önce kitapExchange formu oluşturulmamışsa
            {
                KitapExchange kitapExchange = new KitapExchange(); //oluştur ve aç
                kitapExchange.Show();
            }
            else
                Application.OpenForms["kitapExchange"].Show(); //zaten oluşturulduysa direkt aç
                
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            ADEKontrol();
            //Program her açıldığında Islemler tablosundaki teslim tarihi null olan kayıtların alım tarihlerini ve
            //sistem tarihi arasındaki farka bakarak öğrencilerin cezasal durumlarını yerine getiriyor.
            BAlimIadeCezaIslemleri bAlimIadeCeza = new BAlimIadeCezaIslemleri();
            bAlimIadeCeza.CezaEkle();
        }

        private void ADEKontrol() //setup kurulan bilgisayarda Access Database Engine yüklü mü değil mi diye denetliyoruz
        {
            string yuklupath = "C:\\Program Files (x86)\\Microsoft Office\\Office14\\STSLIST.DLL"; //Access Database Engine'in yüklü olması
                                                                                      //gereken konum
            string path = "C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\Kutuphane\\AccessDatabaseEngine.exe";
            //AccessDatabaseEngine.exe dosyasının konumu
            if (!File.Exists(yuklupath)) //AccessDatabaseEngine yüklü değilse yükle
            {
                DialogResult sonuc = MessageBox.Show("Programı kullanabilmek için Access Database Engine yüklenmelidir. Yüklemek istiyor musunuz?", "UYARI", MessageBoxButtons.YesNo);
                if (sonuc == DialogResult.Yes) //evet seçildiyse
                {
                    Process p = new Process(); //yeni bir işlem oluştur
                    p.StartInfo.FileName = path;
                    p.Start(); //AccessDatabaseEngine.exe'yi çalıştır
                    p.WaitForExit(); //kurulum işlemi bitene kadar programı beklet
                }
                else
                    Application.Exit(); //hayır seçildiyse programı kapat
            }
        }

        private void pboxKitapHistory_Click(object sender, EventArgs e)
        {
            this.Hide(); //bu formu gizle
            if (Application.OpenForms["ogrenciKitapGecmisi"] == null) //ogrenciKitapGecmisi daha önce açılmadıysa
            {
                OgrenciKitapGecmisi ogrenciKitapGecmisi = new OgrenciKitapGecmisi(); //ogrenciKitapGecmisi formunu oluştur
                ogrenciKitapGecmisi.Show();//ve göster
            }
            else
                Application.OpenForms["ogrenciKitapGecmisi"].Show(); //zaten oluşturulduysa direkt göster
        }

        private void pboxKitapInfo_Click(object sender, EventArgs e)
        {
            this.Hide(); //bu formu gizle
            if (Application.OpenForms["detayliKitapBilgileri"] == null) //detayliKitapBilgileri daha önce açılmadıysa
            {
                DetayliKitapBilgileri detayliKitapBilgileri = new DetayliKitapBilgileri(); //detayliKitapBilgileri
                                                                                           //formunu oluştur
                detayliKitapBilgileri.Show();
            }
            else
                Application.OpenForms["detayliKitapBilgileri"].Show();//zaten oluşturulduysa direkt göster
        }

        private void Anasayfa_KeyDown(object sender, KeyEventArgs e)
        {
            //CTRL+SHIFT+N kombinasyonu yapıldığında Yetkili Kullanıcı Giriş Sayfasını Aç
            if (e.Control&&e.Shift&& e.KeyCode == Keys.N) 
            {
                this.Hide(); //bu formu gizle
                if (Application.OpenForms["kullaniciGirisSayfasi"] == null) 
                {
                    KullaniciGirisSayfasi kullaniciGirisSayfasi = new KullaniciGirisSayfasi();
                    kullaniciGirisSayfasi.Show(); //daha önce açılmadıysa yeni bir tane oluştur ve göster.
                }
                else
                    Application.OpenForms["kullaniciGirisSayfasi"].Show(); //zaten oluşturulduysa direkt formu göster
            }
        }
    }
}
