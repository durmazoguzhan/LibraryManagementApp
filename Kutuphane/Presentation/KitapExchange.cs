using System;
using Kutuphane.Business; //Business katmanı ile olan bağlantıyı sağlıyoruz
using System.Windows.Forms;
using System.IO;

namespace Kutuphane.Presentation
{
    public partial class KitapExchange : Form
    {
        public KitapExchange()
        {
            InitializeComponent();
        }

        private ListelemeIslemleri listelemeIslemleri = new ListelemeIslemleri(); //metotlarını kullanacağımız sınıfların
                                                                          //nesnelerini oluşturuyoruz
        private SorguIslemleri sorguIslemleri = new SorguIslemleri();
        private string barkod,TC, teslimEtmedigiKitap; //metotları her çalıştırdığımızda her seferinde yeni değişken oluşturarak
                                               //bellekte kaplanan alanı artırmamak için değişkenlerin bazılarını
                                               //global olarak tanımladık
        private int ceza,i;
        private bool verilmeyeHazirMi;

        private void KitapExchange_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //bu formu kapadığında tüm programı kapat
        }

        private void pboxAnasayfa_Click(object sender, EventArgs e)
        {
            this.Hide();//bu formu gizle ve Anasayfa formunu aç
            Application.OpenForms["Anasayfa"].Show();
        }

        private void KitapExchange_Load(object sender, EventArgs e)
        {
            KitapTablosunuYenile();
            OgrenciTablosunuYenile();
        }

        private void KitapTablosunuYenile()
        {
            //dataKitap datagridviewine veri çekme, Sütun başlığı değiştirme ve kullanıcı görünmesi istenmeyen sütunların
            //gizlenmesi işlemlerini gerçekleştiren metot
            dataKitap.DataSource = listelemeIslemleri.KitapListele();
            dataKitap.Columns[1].HeaderText = "Kitap Adı";
            dataKitap.Columns[7].HeaderText = "Verilmeye Hazır Mı?";
            dataKitap.Columns[3].Visible = false;
            dataKitap.Columns[4].Visible = false;
            dataKitap.Columns[5].Visible = false;
            dataKitap.Columns[6].Visible = false;
        }

        private void OgrenciTablosunuYenile()
        {
            //dataOgrenci datagridviewine veri çekme, Sütun başlığı değiştirme ve kullanıcı görünmesi istenmeyen sütunların
            //gizlenmesi işlemlerini gerçekleştiren metot
            dataOgrenci.DataSource = listelemeIslemleri.OgrenciListele();
            dataOgrenci.Columns[1].HeaderText = "Ad Soyad";
            dataOgrenci.Columns[3].Visible = false;
            dataOgrenci.Columns[4].Visible = false;
        }

        private void rbtnCezaOdeme_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCezaOdeme.Checked)
            {
                //bu radiobutton işaretliyse bazı kontrollerin aktif/pasif durumlarını değiştir.
                gboxCeza.Enabled = true;
                gboxKitaplar.Enabled = false;
                tabloGizleyici.Visible = true;

                pboxKitapResim.ImageLocation= Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Resources\\para.png";
                //para resmini çekme
                //Directory.GetParent(Environment.CurrentDirectory).Parent.FullName kodu projenin konumunu ifade eder
            }
        }

        private void KitaplarAktifDeaktif(object sender, EventArgs e) 
        {
            //Alım ve Iade radiobuttonlarının checkedChanged
            //eventleri için ortak kod
            if (rbtnAlim.Checked || rbtnIade.Checked)
            {
                gboxKitaplar.Enabled = true;
                tabloGizleyici.Visible = false;
                dataKitap_SelectionChanged(this, new EventArgs()); //dataKitap_SelectionChanged eventini çalıştır
                if (rbtnAlim.Checked)
                    gboxCeza.Enabled = false; //gboxCeza kontrolünü deaktif et

                else
                    gboxCeza.Enabled = true; //gboxCeza kontrolünü aktif et
            }
        }

        private void dataOgrenci_SelectionChanged(object sender, EventArgs e)
        {
            try {//bir hata oluşması durumunda programın işleyişini engellememek adına try catch yapısı kullandım
                ceza = Convert.ToInt32(dataOgrenci.SelectedCells[5].Value);
                txtCeza.Text = ceza.ToString()+" ₺"; //ceza textboxının sonuna ₺ ifadesi ekledim
                if (sorguIslemleri.CezasiVarMi(ceza))
                    cboxCezaOdendi.Enabled = true; //aktif et
                else
                {
                    cboxCezaOdendi.Enabled = false; //deaktif et
                    cboxCezaOdendi.Checked = false; //deaktif et
                }

                TC = dataOgrenci.SelectedCells[0].Value.ToString();
                teslimEtmedigiKitap = sorguIslemleri.TeslimEtmedigiKitapVarMi(TC);//businesstan öğrencinin teslim
                                                                                  //etmediği kitap verisini çekerek
                                                                                  //değişkene aktarıyoruz.
                if (teslimEtmedigiKitap!=null)//teslim edilmeyen kitap varsa
                {
                    for (i = 0; i < dataKitap.Rows.Count; i++)
                    {
                        if (dataKitap.Rows[i].Cells[0].Value.ToString() == teslimEtmedigiKitap)
                        {
                            //bu döngü ile birlikte teslim edilmeyen kitaba ait satırı seçili hale getiriyoruz
                            dataKitap.ClearSelection();
                            dataKitap.Rows[i].Selected = true;
                            break;
                        }
                    }
                }

            }
            catch { }//hata yakaladığında programın işlenişini kesmemek adına bu bölüm için catch bloğunu boş bıraktım
        }

        private void dataKitap_SelectionChanged(object sender, EventArgs e)
        {
            try //bu scope'ta hata alıp programın işleyişini kesmemek adına try catch kullandım
            {
                barkod = dataKitap.SelectedCells[0].Value.ToString(); //dataKitaptan veri çekme
                pboxKitapResim.ImageLocation = listelemeIslemleri.KitapGorselListele(barkod); //seçili kitaba ait görseli getirme
                verilmeyeHazirMi = (bool)dataKitap.SelectedCells[7].Value; //dataKitaptan veri çekme
            }
            catch { }
        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {
            //Öğrenci adına göre filtreleme
            dataOgrenci.DataSource = listelemeIslemleri.OgrenciListeleAdaGore(txtAdSoyad.Text);
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            //TC'ye göre filtreleme
            dataOgrenci.DataSource = listelemeIslemleri.OgrenciListeleTCyeGore(txtTC.Text);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide(); //Bu formu gizle ve Anasayfa formunu aç
            Application.OpenForms["Anasayfa"].Show();
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); //sayı değilse girişi iptal et
        }

        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar); //harf,boşluk veya noktalama işareti değilse girişi iptal et
        }

        private void txtKitapAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar); //harf,boşluk veya noktalama işareti değilse girişi iptal et
        }

        private void txtBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); //sayı değilse girişi iptal et
        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            //Barkoda göre filtreleme
            dataKitap.DataSource = listelemeIslemleri.KitapListeleBarkodaGore(txtBarkod.Text);
        }

        private void txtKitapAdi_TextChanged(object sender, EventArgs e)
        {
            //Kitap adına göre filtreleme
            dataKitap.DataSource = listelemeIslemleri.KitapListeleAdaGore(txtKitapAdi.Text);
        }

        private void btnIslemGerceklestir_Click(object sender, EventArgs e)
        {
            
            BAlimIadeCezaIslemleri bAlimIadeCeza = new BAlimIadeCezaIslemleri();
            string iadeEdilecekKitapBarkodu= sorguIslemleri.TeslimEtmedigiKitapVarMi(TC);
            if (rbtnIade.Checked)
            {

                if (iadeEdilecekKitapBarkodu!=null)//iade edilmesi gereken kitap varsa
                {
                    if (cboxCezaOdendi.Checked)//ceza ödendi kutucuğu işaretliyse ceza ödeme işlemini de gerçekleştir
                        bAlimIadeCeza.CezaOde(TC);
                    bAlimIadeCeza.TeslimTarihiEkle(TC);//teslim tarihini ekle ve iade işlemini gerçekleştir
                    bAlimIadeCeza.KitapVerilmeyeHazirYap(iadeEdilecekKitapBarkodu);//son olarak diğer öğrenciler de kitabı
                                                                                   //artık alabilir durumda olabilsin
                                                                                   //diye verilmeye hazır yap
                    OgrenciTablosunuYenile(); //tabloları güncelle
                    KitapTablosunuYenile();
                    MessageBox.Show("İşlem başarıyla tamamlandı.");
                }
                else
                    MessageBox.Show("Öğrencinin teslim etmediği kitap yoktur.");

            }
            else if (rbtnAlim.Checked)
            {

                
                if (sorguIslemleri.KitapAlimSorgu(ceza,TC,verilmeyeHazirMi))
                {
                    //sorguları başarılı bir şekilde geçtiyse kitap alım işlemini gerçekleştir
                    bAlimIadeCeza.IslemEkle(barkod, TC);
                    bAlimIadeCeza.KitapVerilmeyeHazırDegilYap(barkod);//kitap alındığı için verilmeye hazır değil yapıyoruz
                    KitapTablosunuYenile(); //kitap tablosunu güncelliyoruz
                    MessageBox.Show("İşlem başarıyla tamamlandı.");
                }

            }
            else if(rbtnCezaOdeme.Checked)
            {

                if (sorguIslemleri.CezaOdemeSorgu(TC,ceza,cboxCezaOdendi.Checked))
                {
                    //sorguları başarılı bir şekilde geçtiyse ceza ödeme işlemini gerçekleştir
                    bAlimIadeCeza.CezaOde(TC);
                    OgrenciTablosunuYenile(); //öğrenci tablosunu güncelle
                    MessageBox.Show("Ceza başarıyla ödendi.");
                }

            }
            else
                MessageBox.Show("Lütfen yapmak istediğiniz işlemi seçiniz.");
        }
    }
}
