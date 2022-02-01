using System;
using System.Drawing; //Image sınıfı ile ilgili işlem yapabilmek için bu kütüphaneyi ekliyoruz.
using System.IO;
using System.Windows.Forms;
using Kutuphane.Data; //Data katmanına erişebilmek için ekleme yapıyoruz.

namespace Kutuphane.Business
{
    class KitapEkleSilGuncelle
    {

        private SorguIslemleri sorguIslemleri = new SorguIslemleri(); //metodlarını kullanarak kod tekrarını azaltmamızı
                                                              //sağlayacak olan sınıfların nesnelerini oluşturduk
        private KitapIslemleri kitapIslemleri = new KitapIslemleri();

        public bool KitapEkle(string barkod, string kitapAdi, string yazar, string tur, string yayinevi, string sayfaSayisi, string baskiYili, bool verilmeyeHazirMi)
        {
            //Gerekli parametreleri formdan alarak data katmanına iletme işlemini gerçekleştiren metot
            if (sorguIslemleri.BarkodGirisKontrol(barkod))
            {
                if (sorguIslemleri.KitapAdiGirisKontrol(kitapAdi))
                {
                    if (sorguIslemleri.YazarGirisKontrol(yazar))
                    {
                        if (sorguIslemleri.TurGirisKontrol(tur))
                        {
                            if (sorguIslemleri.YayineviGirisKontrol(yayinevi))
                            {
                                if (sorguIslemleri.BaskiYiliGirisKontrol(baskiYili))
                                {
                                    if (!sorguIslemleri.GirilenBarkodVarMi(barkod))
                                    {
                                        //gerekli sorguları/kontrolleri gerçekleştirdikten sonra kitap ekleme işleminin
                                        //son aşaması olan data katmanına parametreleri iletiyoruz.
                                        kitapIslemleri.KitapEkle(barkod, kitapAdi, yazar, tur, yayinevi, sayfaSayisi, baskiYili, verilmeyeHazirMi);
                                        MessageBox.Show("Kitap Başarıyla Eklendi.");
                                        return true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Bu Barkoda sahip zaten bir kitap kayıtlıdır.");
                                        return false;
                                    }
                                }
                                else
                                    return false;
                            }
                            else
                                return false;
                        }
                        else
                            return false; // Parametreleri bazı koşullara tabi tutacağımdan return tipini bool olarak
                                          // belirledim. Koşulları sağlıyorsa true, sağlamıyorsa false return ettim.
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public void KitapGorseliEkle(Image kitapGorseli,string barkod)
        {
            //Kitap eklerken aynı zamanda kitabın görselini Resources klasörüne barkod numarasıyla kaydetmek için bu
            //metodu kullandım.
            kitapGorseli.Save("C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\Kutuphane\\" + barkod + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            //Environment.UserName ifadesi windowsa login olan kullanıcının adı,
            //System.Drawing.Imaging.ImageFormat.Jpeg ifadesi ise görselin hangi formatta kaydedileceğini ifade ediyor.
        }

        public bool KitapGuncelle(string barkod, string kitapAdi, string yazar, string tur, string yayinevi, string sayfaSayisi, string baskiYili, bool verilmeyeHazirMi)
        {
            //Presentation katmanından Data katmanına iletmek adına kitap bilgilerini güncellemek için gerekli olan
            //parametreleri alan ve gerekli sorgu/kontrollerini gerçekleştiren metot
            if (sorguIslemleri.KitapAdiGirisKontrol(kitapAdi))
            {
                if (sorguIslemleri.YazarGirisKontrol(yazar))
                {
                    if (sorguIslemleri.TurGirisKontrol(tur))
                    {
                        if (sorguIslemleri.YayineviGirisKontrol(yayinevi))
                        {
                            if (sorguIslemleri.BaskiYiliGirisKontrol(baskiYili))
                            {
                                //Tüm sorguları/koşulları geçtikten sonra son olarak veriler data katmanına gönderiliyor
                                kitapIslemleri.KitapGuncelle(barkod, kitapAdi, yazar, tur, yayinevi, sayfaSayisi, baskiYili, verilmeyeHazirMi);
                                MessageBox.Show("Kitap Bilgileri Başarıyla Güncellendi.");
                                return true;
                            }
                            else
                                return false;
                        }
                        else
                            return false;
                    }
                    else
                        return false; // Parametreleri bazı koşullara tabi tutacağımdan return tipini bool olarak
                                      // belirledim. Koşulları sağlıyorsa true, sağlamıyorsa false return ettim.
                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool KitapSil(string barkod, bool verilmeyeHazirMi)
        {
            //Kütüphaneden kitap silmek/eksiltmek için bu metodu kullandım.
            if (verilmeyeHazirMi==true)
            {
                //sorguyu geçtikten sonra verileri data katmanına göndererek kitap silme işlemini tamamlıyoruz. Bu işlemi
                //tamamladıktan sonra kitaba ait görseli Resources klasöründen siliyoruz.
                kitapIslemleri.KitapSil(barkod);
                KitapGorseliSil(barkod);
                MessageBox.Show("Kitap başarıyla silindi.");
                return true;
            }
            else
            {
                MessageBox.Show("Bu kitap verilmeye hazır değildir. Yani şuan kütüphanede değildir. \n Kitap silme işlemi için kitabın öğrenciden teslim alınması gerekmektedir.");
                return false;
            }
        }

        public void KitapGorseliSil(string barkod)
        {
            //Kütüphaneden çıkarılacak/silinecek olan kitapların görsellerinin de boş yere yer kaplamayıp silinmesi için kullandığım metot.
            File.Delete("C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\Kutuphane\\" + barkod + ".jpg");
            //File.Delete() metodu path'ini belirttiğiniz dosyayı silmeye yarıyor.
            //Environment.UserName ifadesi windowsa login olmuş olan kullanıcının adını veriyor.
        }

    }
}
