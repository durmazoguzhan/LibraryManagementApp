using System;
using System.Windows.Forms;
using Kutuphane.Business; //Presentation katmanının Business katmanı ile olan bağını tanımladık.

namespace Kutuphane.Presentation
{
    public partial class DetayliKitapBilgileri : Form
    {

        private ListelemeIslemleri listelemeIslemleri = new ListelemeIslemleri(); //metotlarına ihtiyacımız olan nesneyi tanımladık.
        private string barkod;

        public DetayliKitapBilgileri()
        {
            InitializeComponent();
        }

        private void DetayliKitapBilgileri_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //bu formu kapadığımızda tüm programın kapanmasını sağlar
        }

        private void DetayliKitapBilgileri_Load(object sender, EventArgs e)
        {
            KitapTablosunuYenile();
        }

        private void KitapTablosunuYenile()
        {
            //bu metot ile dataKitap datagridviewinin verilerini çekiyor ve sütun başlıklarını düzenliyoruz.
            dataKitap.DataSource = listelemeIslemleri.KitapListele();
            dataKitap.Columns[1].HeaderText = "Kitap Adı";
            dataKitap.Columns[3].HeaderText = "Tür";
            dataKitap.Columns[4].HeaderText = "Yayınevi";
            dataKitap.Columns[5].HeaderText = "Sayfa Sayısı";
            dataKitap.Columns[6].HeaderText = "Baskı Yılı";
            dataKitap.Columns[7].HeaderText = "Verilmeye Hazır Mı?";
        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            //barkod textboxında yazı yazdıkça filtreleme işlemini gerçekleştiriyoruz
            dataKitap.DataSource = listelemeIslemleri.KitapListeleBarkodaGore(txtBarkod.Text);
        }

        private void txtKitapAdi_TextChanged(object sender, EventArgs e)
        {
            //kitap adı textboxında yazı yazdıkça filtreleme işlemini gerçekleştiriyoruz
            dataKitap.DataSource = listelemeIslemleri.KitapListeleAdaGore(txtKitapAdi.Text);
        }

        private void dataKitap_SelectionChanged(object sender, EventArgs e)
        {
            if (dataKitap.SelectedCells.Count!=0)//hata almamak için sadece dataKitap kontrolünün içinde veri varken çalıştırıyoruz
            {
                barkod = dataKitap.SelectedCells[0].Value.ToString();//datakitaptan barkod hücresini çek
                dataTeslimAlanEden.DataSource = listelemeIslemleri.KitabaGoreKisiListele(barkod);//seçili satıra göre
                                                                                                 //listeleme işlemini
                                                                                                 //gerçekleştiriyoruz
                pboxKitapResim.ImageLocation = listelemeIslemleri.KitapGorselListele(barkod);
                //kitap görselini gösteriyoruz.
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //Şuanki formu gizleyip anasayfa formunu tekrar gösteriyoruz.
            this.Hide();
            Application.OpenForms["Anasayfa"].Show();
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
