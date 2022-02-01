using System.Data;
using Kutuphane.Data; //Data katmanına erişmek için gerekli tanımlamayı yapıyoruz
using System.Windows.Forms;

namespace Kutuphane.Business
{
    class SorguIslemleri
    {
        private string barkod;
        private AlimIadeCezaIslemleri alimIadeCeza = new AlimIadeCezaIslemleri(); //kullanacağımız metotların bulunduğu classların
                                                                          //nesnelerini oluşturuyoruz.
        private KullaniciIslemleri kullaniciIslemleri = new KullaniciIslemleri();
        private OgrenciIslemleri ogrenciIslemleri = new OgrenciIslemleri();
        private KitapIslemleri kitapIslemleri = new KitapIslemleri();
        private DataSet ds = new DataSet();  //Data katmanından DataAdapter tipinde gelen veriler üzerinde işlemler yapmak için
                                     //bir DataSet tanımlıyoruz.
        public string TeslimEtmedigiKitapVarMi(string TC)
        {
            //Bir öğrencinin teslim etmediği kitap olup olmadığını varsa hangi kitap olduğunu anlamak için
            //kullandığım metot
            barkod = null;
            if (ds.Tables["TeslimEdilmeyenKitap"] != null)
                ds.Tables["TeslimEdilmeyenKitap"].Clear();//hata alma ihtimalini ortadan kaldırmak için eski verileri
                                                          //silerek yeni verileri eklemeye hazır hale getiriyoruz.
            alimIadeCeza.TeslimEdilmeyenKitap(TC).Fill(ds, "TeslimEdilmeyenKitap");
            if (ds.Tables["TeslimEdilmeyenKitap"].Rows.Count == 0)
            {
                return barkod; //teslim etmediği kitap yoksa barkod değerini null olarak gönderiyoruz
            }
            else
            {
                barkod = ds.Tables["TeslimEdilmeyenKitap"].Rows[0][1].ToString();
                return barkod; //teslim etmediği kitap varsa o kitabın barkodunu yolla
            }
        }

        public bool CezasiVarMi(int ceza)
        {
            //Bir öğrencinin parametre olarak alınan ceza değerine göre cezası olup olmadığını sorgulamak için
            //kullandığım metot
            if (ceza == 0)
                return false;
            else
                return true;
        }

        public bool VerilmeyeHazirMi(bool verilmeyeHazirMi)
        {
            //Bir kitabın parametre olarak alınan verilmeyeHazirMi değerine göre verilmeye hazır olup olmadığını
            //sorgulamak için kullandığım metot
            if (verilmeyeHazirMi)
                return true;
            else
                return false;
        }

        public bool KitapAlimSorgu(int ceza,string TC,bool verilmeyeHazirMi)
        {
            //Bu metot ile Kitap Alım işlemi için gereken sorguları birleştirdim.
            if (TeslimEtmedigiKitapVarMi(TC)==null)
            {
                if (!CezasiVarMi(ceza))
                {
                    //Bu metot görüldüğü üzere bu classtaki diğer metotlarıda çalıştırıyor. Bu sayede bu metot tek başına
                    //çalıştırılarak kitap alım için gereken diğer metotlarında çalıştırılması sağlanıyor.
                    if (VerilmeyeHazirMi(verilmeyeHazirMi))
                        return true;
                    else
                    {
                        MessageBox.Show("Bu kitap başka biri tarafından alındığı için şuan alınamaz.");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Cezanızı ödemeden yeni kitap alamazsınız.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Elinizdeki kitabı teslim etmeden yeni kitap alamazsınız.");
                return false;
            }
        }
        
        public bool CezaOdemeSorgu(string TC,int ceza,bool CezaOdendiKutusuIsaretliMi)
        {
            //Öğrencinin cezasının ödenmesi için kullandığım metot.
            if (TeslimEtmedigiKitapVarMi(TC) == null)
            {
                if (CezasiVarMi(ceza))
                {
                    //öncelikle bu classın içine dahil olan ceza ödeme işlemi için gerekli olan sorgu
                    //metotları çalıştırılıyor
                    if (CezaOdendiKutusuIsaretliMi)
                    {
                        //bu sorgulardan başarılı bir şekilde geçildiğinde presentation katmanına true değeri gönderiliyor.
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Lütfen \"Ceza Ödendi\" kutucuğunu işaretleyiniz.");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Seçilen öğrencinin cezası yoktur.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Ceza ödemeden önce elinizdeki kitabı iade etmeniz gerekmektedir.");
                return false; //Parametreler sorgulardan başarılı bir şekilde geçemediğinde presentation katmanına
                              //false return ediliyor.
            }
        }

        public bool GirisBasariliMi(string kullaniciAdi,string sifre)
        {
            //Yetkili kullanıcı login formundaki girilen verilerin doğruluğunu sorgulayan metot
            kullaniciIslemleri.YetkiliKullaniciGirisi(kullaniciAdi, sifre).Fill(ds, "Giris");
            if (ds.Tables["Giris"].Rows.Count != 0) 
            {
                return true;//eğer satır sayısı sıfır değilse=yani bu verilere uygun kayıt bulunduysa girilen bilgiler
                            //doğrudur true gönder
            }
            else
                return false;//eğer satır sayısı sıfırsa=yani bu verilere uygun kayıt bulunamadıysa false gönder
        }

        public bool GirilenTCVarMi(string TC)
        {
            //yeni öğrenci ekleme durumu için aynı TC'ye sahip başka bir öğrenci olup olmadığını denetleyen metot.
            if (ds.Tables["TCyeGoreOgrenci"] != null)
                ds.Tables["TCyeGoreOgrenci"].Clear();//hata alma ihtimalini ortadan kaldırmak için eski verileri
                                                     //silerek yeni verileri eklemeye hazır hale getiriyoruz.
            ogrenciIslemleri.TCyeGoreOgrenciListele(TC).Fill(ds, "TCyeGoreOgrenci");
            if (ds.Tables["TCyeGoreOgrenci"].Rows.Count == 0)
                return false; //yoksa
            else
                return true; //varsa
        }

        public bool GirilenBarkodVarMi(string barkod)
        {
            //yeni kitap ekleme durumu için aynı barkoda sahip başka bir kitap olup olmadığını denetleyen metot.
            if (ds.Tables["BarkodaGoreKitap"] != null)
                ds.Tables["BarkodaGoreKitap"].Clear();//hata alma ihtimalini ortadan kaldırmak için eski verileri
                                                      //silerek yeni verileri eklemeye hazır hale getiriyoruz.
            kitapIslemleri.BarkodaGoreKitapListele(barkod).Fill(ds, "BarkodaGoreKitap");
            if (ds.Tables["BarkodaGoreKitap"].Rows.Count == 0)
                return false; //yoksa
            else
                return true; //varsa
        }

        public bool TCGirisKontrol(string TC)
        {
            //kullanıcıdan girmesi istenen TC verisinin veritabanına uygunluğu için 11 haneli olup olmadığının
            //sorgulandığı metot
            if (TC.Length==11)
                return true; //11 haneliyse
            else
            {
                MessageBox.Show("Lütfen TC kimlik numarasını 11 haneli olacak şekilde girin.");
                return false; //11 haneli değilse
            }
        }

        public bool BarkodGirisKontrol(string barkod)
        {
            //kullanıcıdan girmesi istenen barkod verisinin veritabanına uygunluğu için 13 haneli olup olmadığının
            //sorgulandığı metot
            if (barkod.Length == 13)
                return true; //13 haneliyse
            else
            {
                MessageBox.Show("Lütfen Barkod numarasını 13 haneli olacak şekilde girin.");
                return false; //13 haneli değilse
            }
        }

        public bool AdSoyadGirisKontrol(string adSoyad)
        {
            //kullanıcıdan girmesi istenen AdSoyad verisinin veritabanına uygunluğu için boş olup olmadığının
            //sorgulandığı metot
            if (adSoyad.Length > 0)
                return true; //adsoyad ifadesi boş geçilmemiştir
            else
            {
                MessageBox.Show("Lütfen Ad Soyad alanını doldurunuz.");
                return false; //adsoyad ifadesi boş geçilmiştir
            }
        }

        public bool KitapAdiGirisKontrol(string kitapAdi)
        {
            //kullanıcıdan girmesi istenen KitapAdi verisinin veritabanına uygunluğu için boş olup olmadığının
            //sorgulandığı metot
            if (kitapAdi.Length > 0)
                return true; //kitapadi ifadesi boş geçilmemiştir
            else
            {
                MessageBox.Show("Lütfen Kitap Adı alanını doldurunuz.");
                return false; //kitapadi ifadesi boş geçilmiştir.
            }
        }

        public bool YazarGirisKontrol(string yazar)
        {
            //kullanıcıdan girmesi istenen Yazar verisinin veritabanına uygunluğu için boş olup olmadığının
            //sorgulandığı metot
            if (yazar.Length > 0)
                return true; //yazar ifade boş geçilmemiş
            else
            {
                MessageBox.Show("Lütfen Yazar alanını doldurunuz.");
                return false; //yazar ifadesi boş geçilmiş
            }
        }

        public bool TurGirisKontrol(string tur)
        {
            //kullanıcıdan girmesi istenen Tür verisinin veritabanına uygunluğu için boş olup olmadığının
            //sorgulandığı metot
            if (tur.Length > 0)
                return true; //tur ifadesi boş geçilmemiş
            else
            {
                MessageBox.Show("Lütfen Tür alanını doldurunuz.");
                return false; //tur ifadesi boş geçilmiş
            }
        }

        public bool YayineviGirisKontrol(string yayinevi)
        {
            //kullanıcıdan girmesi istenen Yayinevi verisinin veritabanına uygunluğu için boş olup olmadığının
            //sorgulandığı metot
            if (yayinevi.Length > 0)
                return true; //yayinevi ifadesi boş geçilmemiş
            else
            {
                MessageBox.Show("Lütfen Yayınevi alanını doldurunuz.");
                return false; //yayinevi ifadesi boş geçilmiş
            }
        }

        public bool BaskiYiliGirisKontrol(string baskiYili)
        {
            //kullanıcıdan girmesi istenen BaskiYili verisinin veritabanına uygunluğu için boş olup olmadığının
            //sorgulandığı metot
            if (baskiYili.Length > 0)
                return true; //baskiyili ifadesi boş geçilmemiş
            else
            {
                MessageBox.Show("Lütfen Baskı Yılı alanını doldurunuz.");
                return false; //baskiyili ifadesi boş geçilmiş
            }
        }
    }
}
