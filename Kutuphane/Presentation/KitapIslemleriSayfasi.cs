using System;
using System.Drawing;
using System.Windows.Forms;
using Kutuphane.Business; //Business katmanı ile olan ilişkiyi sağladık

namespace Kutuphane.Presentation
{
    public partial class KitapIslemleriSayfasi : Form
    {
        private ListelemeIslemleri listelemeIslemleri = new ListelemeIslemleri(); //metotlarını kullancağımız classların
                                                                          //nesnelerini tanımladık
        private KitapEkleSilGuncelle kitapEkleSilGuncelle = new KitapEkleSilGuncelle();

        public KitapIslemleriSayfasi()
        {
            InitializeComponent();
        }

        private void KitapIslemleriSayfasi_Load(object sender, EventArgs e)
        {
            KitapTablosunuYenile();
            //openfiledialog ile resim seçimi yapacağımız için uygul Filter'ı giriyoruz
            openFileDialog1.Filter= "Resim Dosyaları(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
        }

        private void KitapTablosunuYenile()
        {
            //dataKitap tablosuna veri çekme
            dataKitap.DataSource = listelemeIslemleri.KitapListele();
            dataKitap.Columns[1].HeaderText = "Kitap Adı"; //sütun başlığı değiştirme
            dataKitap.Columns[2].Visible = false;
            dataKitap.Columns[3].Visible = false;
            dataKitap.Columns[4].Visible = false; //kullanıcıya göstermek istemediğimiz sütunları gizleme
            dataKitap.Columns[5].Visible = false;
            dataKitap.Columns[6].Visible = false;
            dataKitap.Columns[7].Visible = false;
        }

        private void KitapIslemleriSayfasi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //bu form kapatılırsa tüm programı kapat
        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            //barkoda göre filtreleme
            dataKitap.DataSource = listelemeIslemleri.KitapListeleBarkodaGore(txtBarkod.Text);
        }

        private void txtKitapAdi_TextChanged(object sender, EventArgs e)
        {
            //kitap adına göre filtreleme
            dataKitap.DataSource = listelemeIslemleri.KitapListeleAdaGore(txtKitapAdi.Text);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide(); //bu formu gizle
            Application.OpenForms["yetkiliPaneli"].Show(); //yetkiliPaneli formunu aç
        }

        private void rbtnEkle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEkle.Checked)
            {
                tabloGizleyici.Visible = true; //tablo ile işimiz olmadığı için tabloyu kullanıcı enabled=false
                                               //olmasına rağmen hiç görmesin diye paneli görünür yapıyoruz
                gboxKitaplar.Enabled = false; //deaktif yap
                gboxBilgiler.Enabled = true; //aktif yap
                btnUygula.Enabled = true; //aktif yap
                txtBarkodBilgi.Enabled = true; //aktif yap
                btnKitapGorseliYukle.Enabled = true; //aktif yap
                BilgileriTemizle(); //Bilgiler grubunun kontrollerinin içlerini temizle
                PictureBoxiResimsizYap(); //pictureboxa resimsiz.png yi yükle
            }
        }

        private void PictureBoxiResimsizYap()
        {
            //pictureboxa resimsiz.png yi yükle
            pboxKitap.ImageLocation = Environment.CurrentDirectory + "\\resimsiz.png";
            //Directory.GetParent(Environment.CurrentDirectory).Parent.FullName ifadesi projenin konumunu temsil eder
        }

        private void BilgileriTemizle()
        {
            //Bilgiler grubunun kontrollerinin içlerini temizle
            txtBarkodBilgi.Text = "";
            txtKitapAdiBilgi.Text = "";
            txtYazarBilgi.Text = "";
            txtTurBilgi.Text = "";
            txtYayineviBilgi.Text = "";
            nudSayfaSayisiBilgi.Value = 1;
            txtBaskiYiliBilgi.Text = "";
            cbVerilmeyeHazirMiBilgi.Checked = false;
        }

        private void rbtnSil_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSil.Checked)
            {
                //Kullanıcı deneyimi ve güvenlik açısından gerekli kontrol aktif/deaktif işlemlerini gerçekleştiriyoruz.
                tabloGizleyici.Visible = false; //deaktif et
                KitapTablosunuYenile();
                gboxKitaplar.Enabled = true; //aktif et
                gboxBilgiler.Enabled = false; //deaktif et
                btnUygula.Enabled = true; //aktif et
                txtBarkodBilgi.Enabled = true; //aktif et
                btnKitapGorseliYukle.Enabled = false; //deaktif et
            }
        }

        private void rbtnGuncelle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnGuncelle.Checked)
            {
                //Kullanıcı deneyimi ve güvenlik açısından gerekli kontrol aktif/deaktif işlemlerini gerçekleştiriyoruz.
                tabloGizleyici.Visible = false; //deaktif et
                KitapTablosunuYenile();
                gboxKitaplar.Enabled = true; //aktif et
                gboxBilgiler.Enabled = true; //aktif et
                btnUygula.Enabled = true; //aktif et
                txtBarkodBilgi.Enabled = false; //deaktif et
                btnKitapGorseliYukle.Enabled = true; //aktif et
            }
        }

        private void dataKitap_SelectionChanged(object sender, EventArgs e)
        {
            if (dataKitap.SelectedCells.Count!=0)
            {
                //seçili bir satır varsa o satırdaki bilgileri Bilgi groupboxındaki kontrollere gönder
                txtBarkodBilgi.Text = dataKitap.SelectedCells[0].Value.ToString();
                txtKitapAdiBilgi.Text = dataKitap.SelectedCells[1].Value.ToString();
                txtYazarBilgi.Text = dataKitap.SelectedCells[2].Value.ToString();
                txtTurBilgi.Text = dataKitap.SelectedCells[3].Value.ToString();
                txtYayineviBilgi.Text = dataKitap.SelectedCells[4].Value.ToString();
                nudSayfaSayisiBilgi.Text = dataKitap.SelectedCells[5].Value.ToString();
                txtBaskiYiliBilgi.Text = dataKitap.SelectedCells[6].Value.ToString();
                cbVerilmeyeHazirMiBilgi.Checked = Convert.ToBoolean(dataKitap.SelectedCells[7].Value);
                //seçili kitabın görselini picturebox'a yükle
                pboxKitap.ImageLocation = listelemeIslemleri.KitapGorselListele(txtBarkodBilgi.Text);
            }
        }

        private void btnKitapGorseliYukle_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                //seçili görseli picturebox'a yükle
                pboxKitap.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void btnUygula_Click(object sender, EventArgs e)
        {
            if (rbtnEkle.Checked)
            {
                if (kitapEkleSilGuncelle.KitapEkle(txtBarkodBilgi.Text,txtKitapAdiBilgi.Text,txtYazarBilgi.Text,txtTurBilgi.Text,txtYayineviBilgi.Text,nudSayfaSayisiBilgi.Value.ToString(),txtBaskiYiliBilgi.Text,cbVerilmeyeHazirMiBilgi.Checked))
                {
                    //Ekleme işlemi başarıyla tamamlandıysa pboxtaki görseli Resources klasörüne yükle
                    kitapEkleSilGuncelle.KitapGorseliEkle(pboxKitap.Image, txtBarkodBilgi.Text);
                    KitapTablosunuYenile(); //tabloyu güncelle
                    BilgileriTemizle();
                    PictureBoxiResimsizYap();
                }
            }
            if (rbtnSil.Checked)
            {
                if (kitapEkleSilGuncelle.KitapSil(dataKitap.SelectedCells[0].Value.ToString(),Convert.ToBoolean(dataKitap.SelectedCells[7].Value)))
                {
                    //Silme işlemi başarıyla gerçekleştiyse
                    KitapTablosunuYenile(); //tabloyu güncelle
                    BilgileriTemizle();
                    dataKitap_SelectionChanged(this, new EventArgs()); //dataKitap_SelectionChanged eventini çalıştır
                }
            }
            if (rbtnGuncelle.Checked)
            {
                if (kitapEkleSilGuncelle.KitapGuncelle(txtBarkodBilgi.Text, txtKitapAdiBilgi.Text, txtYazarBilgi.Text, txtTurBilgi.Text, txtYayineviBilgi.Text, nudSayfaSayisiBilgi.Value.ToString(), txtBaskiYiliBilgi.Text, cbVerilmeyeHazirMiBilgi.Checked))
                {
                    //Güncelleme işlemi başarıyla gerçekleştiyse
                    kitapEkleSilGuncelle.KitapGorseliEkle(pboxKitap.Image, txtBarkodBilgi.Text); //Kitap görselinin de
                                                                                                 //güncellenmiş olma
                                                                                                 //ihtimaline karşılık
                                                                                                 //son görsel de resources
                                                                                                 //klasöründeki aynı
                                                                                                 //görsel ile
                                                                                                 //değiştiriliyor
                    KitapTablosunuYenile(); //tabloyu güncelle
                    BilgileriTemizle();
                    dataKitap_SelectionChanged(this, new EventArgs()); //dataKitap_SelectionChanged eventini çalıştır
                }
            }
        }

        private void txtBarkodBilgi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); //sayı değilse girişi iptal et
        }

        private void txtYazarBilgi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar); //harf,boşluk veya noktalama işareti değilse girişi iptal et
        }

        private void txtTurBilgi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar); //harf,boşluk veya noktalama işareti değilse girişi iptal et
        }

        private void txtBaskiYiliBilgi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); //sayı değilse girişi iptal et
        }

        private void txtBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); //sayı değilse girişi iptal et
        }

        private void txtKitapAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar); //harf,boşluk veya noktalama işareti değilse girişi iptal et
        }
    }
}
