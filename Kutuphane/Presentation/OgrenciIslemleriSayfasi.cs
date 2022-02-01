using System;
using System.Windows.Forms;
using Kutuphane.Business; //business katmanı ile olan bağlantıyı sağladık

namespace Kutuphane.Presentation
{
    public partial class OgrenciIslemleriSayfasi : Form
    {

        private ListelemeIslemleri listelemeIslemleri = new ListelemeIslemleri(); //metotlarına ihtiyacımız olan sınıfların
                                                                          //nesnelerini tanımladık
        private OgrenciEkleSilGuncelle ogrenciEkleSilGuncelle = new OgrenciEkleSilGuncelle();

        public OgrenciIslemleriSayfasi()
        {
            InitializeComponent();
        }

        private void OgrenciIslemleriSayfasi_Load(object sender, EventArgs e)
        {
            OgrenciTablosunuYenile(); //öğrenci tablosuna veri aktar
            dtpDogumTarihiBilgi.MaxDate = DateTime.Now.Date; //doğum tarihi maximum bugün olabilir, gelecekte
                                                             //doğmuş olamaz
            dtpUyelikTarihiBilgi.MaxDate = DateTime.Now.Date; //üyelik tarihi maximum bugün olabilir, gelecekte
                                                              //üye olmuş olamaz
        }

        private void OgrenciTablosunuYenile()
        {
            dataOgrenci.DataSource = listelemeIslemleri.OgrenciListele(); //dataOgrenci gridviewine business katmanından
                                                                          //verileri çekiyoruz
            dataOgrenci.Columns[1].HeaderText = "Ad Soyad"; //AdSoyad sütunu başlığını kullanıcı deneyimi için değiştirdim
            dataOgrenci.Columns[2].Visible = false;
            dataOgrenci.Columns[3].Visible = false; //kullanıcının görmesi gerekmeyen sütunları gizledik
            dataOgrenci.Columns[4].Visible = false;
            dataOgrenci.Columns[5].Visible = false;
        }

        private void OgrenciIslemleriSayfasi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //bu form çarpı ikonundan kapatıldığında tüm program kapansın
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            //TC'ye göre filtreleme
            dataOgrenci.DataSource = listelemeIslemleri.OgrenciListeleTCyeGore(txtTC.Text);
        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {
            //Ad Soyada göre filtreleme
            dataOgrenci.DataSource = listelemeIslemleri.OgrenciListeleAdaGore(txtAdSoyad.Text);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide(); // bu formu gizle
            Application.OpenForms["yetkiliPaneli"].Show(); //yetkiliPaneli formunu göster
        }

        private void rbtnEkle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEkle.Checked) //ekle radiobutonu işaretlendiyse
            {
                tabloGizleyici.Visible = true; //kullanıcı deneyimi ve güvenlik açısından bazı kontrollerin Visible ve
                                               //Enabled özelliklerinde değişiklik yaptım
                gboxOgrenciler.Enabled = false;
                gboxBilgiler.Enabled = true;
                btnUygula.Enabled = true;
                txtTCBilgi.Enabled = true;
                BilgileriTemizle(); //Bilgiler groupbox'ındaki kontrollerin textlerini sıfırla
            }
        }

        private void BilgileriTemizle()
        {
            //Bilgiler groupboxındaki kontrollerin değerlerini sıfırla
            txtTCBilgi.Text = "";
            txtAdSoyadBilgi.Text = "";
            cboxCinsiyetBilgi.SelectedIndex = 0;
            dtpDogumTarihiBilgi.Value = Convert.ToDateTime("01/01/1990");
            dtpUyelikTarihiBilgi.Value = DateTime.Now.Date;
            nudCezaBilgi.Value = 0;
        }

        private void rbtnSil_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSil.Checked) //sil radiobutonu işaretlendiyse
            {
                tabloGizleyici.Visible = false; //kullanıcı deneyimi ve güvenlik açısından bazı kontrollerin Visible ve
                                                //Enabled özelliklerinde değişiklik yaptım
                gboxOgrenciler.Enabled = true;
                gboxBilgiler.Enabled = false;
                btnUygula.Enabled = true;
                txtTCBilgi.Enabled = true;
            }
                
        }

        private void rbtnGuncelle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnGuncelle.Checked) //güncelle radiobuttonu işaretlendiyse
            {
                tabloGizleyici.Visible = false; 
                OgrenciTablosunuYenile(); //dataOgrenci tablosuna verileri tekrar çekiyoruz
                gboxOgrenciler.Enabled = true;
                gboxBilgiler.Enabled = true;//kullanıcı deneyimi ve güvenlik açısından bazı kontrollerin Visible ve
                                            //Enabled özelliklerinde değişiklik yaptım
                btnUygula.Enabled = true;
                txtTCBilgi.Enabled = false;
            }
                
        }

        private void dataOgrenci_SelectionChanged(object sender, EventArgs e)
        {
            //hata almamak amacıyla seçili hücre olup olmadığının kontrolünü gerçekleştiriyoruz
            if (dataOgrenci.SelectedCells.Count != 0) 
            {
                txtTCBilgi.Text = dataOgrenci.SelectedCells[0].Value.ToString(); //datagridviewdeki verileri Güncelle
                                                                                 //işlemi yapabilmek adına Bilgiler
                                                                                 //groupboxındaki kontrollere aktardık
                txtAdSoyadBilgi.Text = dataOgrenci.SelectedCells[1].Value.ToString();
                cboxCinsiyetBilgi.Text = dataOgrenci.SelectedCells[2].Value.ToString();
                dtpDogumTarihiBilgi.Text = dataOgrenci.SelectedCells[3].Value.ToString();
                dtpUyelikTarihiBilgi.Text = dataOgrenci.SelectedCells[4].Value.ToString();
                nudCezaBilgi.Value = Convert.ToInt32(dataOgrenci.SelectedCells[5].Value);
            }
        }

        private void btnUygula_Click(object sender, EventArgs e)
        {
            if (rbtnEkle.Checked) //Ekle radiobuttonu seçiliyse
            {
                //Öğrenci ekleme işlemi başarıyla tamamlandıysa
                if (ogrenciEkleSilGuncelle.OgrenciEkle(txtTCBilgi.Text,txtAdSoyadBilgi.Text,cboxCinsiyetBilgi.Text,
                    dtpDogumTarihiBilgi.Value.Date,dtpUyelikTarihiBilgi.Value.Date,Convert.ToInt32(nudCezaBilgi.Value)))
                {
                    OgrenciTablosunuYenile(); //öğrenci tablosuna verileri tekrar çek
                    BilgileriTemizle(); //bilgi groupboxındaki kontrollerin textlerini sıfırla
                }
            }
            
            if (rbtnSil.Checked) //Sil radiobuttonu seçiliyse
            {
                //Öğrenci silme işlemi başarıyla tamamlandıysa
                if (ogrenciEkleSilGuncelle.OgrenciSil(dataOgrenci.SelectedCells[0].Value.ToString(),Convert.ToInt32(dataOgrenci.SelectedCells[5].Value)))
                {
                    OgrenciTablosunuYenile(); //öğrenci tablosuna verileri tekrar çek
                    BilgileriTemizle(); //bilgi groupboxındaki kontrollerin textlerini sıfırla
                }
            }

            if (rbtnGuncelle.Checked) //Guncelle radiobuttonu seçiliyse
            {
                //Öğrenci güncelleme işlemi başarıyla tamamlandıysa
                if (ogrenciEkleSilGuncelle.OgrenciGuncelle(txtTCBilgi.Text, txtAdSoyadBilgi.Text, cboxCinsiyetBilgi.Text,
                    dtpDogumTarihiBilgi.Value.Date, dtpUyelikTarihiBilgi.Value.Date, Convert.ToInt32(nudCezaBilgi.Value)))
                {
                    OgrenciTablosunuYenile(); //öğrenci tablosuna verileri tekrar çek
                    BilgileriTemizle(); //bilgi groupboxındaki kontrollerin textlerini sıfırla
                }
            }
        }

        private void dtpDogumTarihiBilgi_ValueChanged(object sender, EventArgs e)
        {
            //üyelik tarihi doğum tarihinden önce olamaz. yani kimse doğmadan kütüphaneye üye olamaz
            dtpUyelikTarihiBilgi.MinDate = dtpDogumTarihiBilgi.Value;
        }

        private void txtTCBilgi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); //sayı değilse girişi iptal et
        }

        private void txtAdSoyadBilgi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar); //harf,boşluk veya noktalama işareti değilse girişi iptal et
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); //sayı değilse girişi iptal et
        }

        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar); //harf,boşluk veya noktalama işareti değilse girişi iptal et
        }
    }
}
