using System;
using System.Windows.Forms;
using Kutuphane.Data; //Data katmanına erişim için gerekli tanımlama

namespace Kutuphane.Business
{
    class OgrenciEkleSilGuncelle //Bu classta Öğrenciye dair ekle/sil/güncelleme işlemleri yapılacak
    {
        private SorguIslemleri sorguIslemleri = new SorguIslemleri(); //metodlarını kullanacağımız sınıfların nesnelerini oluşturduk
        private OgrenciIslemleri ogrenciIslemleri = new OgrenciIslemleri();

        public bool OgrenciEkle(string TC, string adSoyad, string cinsiyet, DateTime dogumTarihi, DateTime uyelikTarihi, int ceza)
        {
            //presentation katmanında gerekli parametreleri alarak data katmanına Öğrenci Ekle işlemi için iletim yapması
            //gereken metot
            if (sorguIslemleri.TCGirisKontrol(TC))
            {
                if (sorguIslemleri.AdSoyadGirisKontrol(adSoyad))
                {
                    //SorguIslemleri classından oluşturduğumuz nesne ile gerekli kontrolleri yapıyoruz.
                    if (!sorguIslemleri.GirilenTCVarMi(TC))
                    {
                        //bu kontrolleri başarılı olarak geçen parametreleri data katmanına göndererek Öğrenci Ekleme
                        //işleminin business katmanını tamamlamış oluyoruz.
                        ogrenciIslemleri.OgrenciEkle(TC, adSoyad, cinsiyet, dogumTarihi, uyelikTarihi, ceza);
                        MessageBox.Show("Öğrenci Başarıyla Eklendi.");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Bu TC'ye ait zaten bir öğrenci kayıtlıdır.");
                        return false;
                    }
                }
                else
                    return false;
            }
            else
                return false; //parametrelerin sorgulamalardan geçememesi durumunda false return ediyoruz.
        }

        public bool OgrenciGuncelle(string TC, string adSoyad, string cinsiyet, DateTime dogumTarihi, DateTime uyelikTarihi, int ceza)
        {
            //presentation katmanında gerekli parametreleri alarak data katmanına Öğrenci Güncelle işlemi için iletim
            //yapması gereken metot
            if (sorguIslemleri.AdSoyadGirisKontrol(adSoyad))
            {
                //bu kontrolleri başarılı olarak geçen parametreleri data katmanına göndererek Öğrenci Güncelle
                //işleminin business katmanını tamamlamış oluyoruz.
                ogrenciIslemleri.OgrenciGuncelle(TC, adSoyad, cinsiyet, dogumTarihi, uyelikTarihi, ceza);
                MessageBox.Show("Öğrenci Bilgileri Başarıyla Güncellendi.");
                return true;
            }
            else
                return false; //parametrelerin sorgulamalardan geçememesi durumunda false return ediyoruz.
        }

        public bool OgrenciSil(string TC,int ceza)
        {
            //presentation katmanında gerekli parametreleri alarak data katmanına Öğrenci Sil işlemi için iletim
            //yapması gereken metot
            if (!sorguIslemleri.CezasiVarMi(ceza))
            {
                //SorguIslemleri classından oluşturduğumuz nesne ile gerekli kontrolleri yapıyoruz.
                if (sorguIslemleri.TeslimEtmedigiKitapVarMi(TC)==null)
                {
                    //bu kontrolleri başarılı olarak geçen parametreleri data katmanına göndererek Öğrenci Sil
                    //işleminin business katmanını tamamlamış oluyoruz.
                    ogrenciIslemleri.OgrenciSil(TC);
                    MessageBox.Show("Öğrenci başarıyla silindi.");
                    return true;
                }
                else
                {
                    MessageBox.Show("Bu öğrencinin iade etmediği kitabı vardır. \n Aldığı kitabı iade etmeyen öğrenci silinemez.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Bu öğrencinin cezası olduğu için bu öğrenci silinemez.");
                return false; //parametrelerin sorgulamalardan geçememesi durumunda false return ediyoruz.
            }
        }
    }
}
