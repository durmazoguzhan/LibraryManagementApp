using Kutuphane.Data; //data katmanına erişebilmek için gerekli tanımlamayı yapıyoruz
using System;
using System.Data; 

namespace Kutuphane.Business
{
    class KutuphanedekiKitapSayilari
    {
        private KitapIslemleri kitapIslemleri = new KitapIslemleri(); //metodlarını kullanmaya ihtiyacımız olan sınıfın nesnesini
                                                              //oluşturuyoruz.
        private DataSet ds = new DataSet();

        public int KutuphanedekiKitapSayisiHesapla()
        {
            //Kütüphanedeki toplam kitap sayısını hesaplamak için bu aracı metodu kullandım.
            if (ds.Tables["KutuphanedekiKitapSayisi"] != null) 
                ds.Tables["KutuphanedekiKitapSayisi"].Clear(); //hata alma ihtimalini ortadan kaldırmak için eski verileri
                                                               //silerek yeni verileri eklemeye hazır hale getiriyoruz.
            kitapIslemleri.KutuphanedekiKitapSayisi().Fill(ds,"KutuphanedekiKitapSayisi");
            return Convert.ToInt32(ds.Tables["KutuphanedekiKitapSayisi"].Rows[0][0]); //DataAdapter nesnesi olarak gelen
                                                                                      //verileri DataSete aktararak gerekli
                                                                                      //işlemlerimizi gerçekleştiriyor ve
                                                                                      //return ediyoruz. 
        }
        
        public int KutuphanedekiVerilmeyeHazirKitapSayisiHesapla()
        {
            if (ds.Tables["KutuphanedekiVerilmeyeHazirKitapSayisi"] != null)
                ds.Tables["KutuphanedekiVerilmeyeHazirKitapSayisi"].Clear();//hata alma ihtimalini ortadan kaldırmak için eski verileri
                                                                            //silerek yeni verileri eklemeye hazır hale getiriyoruz.
            kitapIslemleri.KutuphanedekiVerilmeyeHazirKitapSayisi().Fill(ds, "KutuphanedekiVerilmeyeHazirKitapSayisi");
            return Convert.ToInt32(ds.Tables["KutuphanedekiVerilmeyeHazirKitapSayisi"].Rows[0][0]); //DataAdapter nesnesi
                                                                                                    //olarak gelen verileri
                                                                                                    //DataSete aktararak
                                                                                                    //gerekli işlemlerimizi
                                                                                                    //gerçekleştiriyor ve
                                                                                                    //return ediyoruz. 
        }

        public int KutuphanedekiVerilmeyeHazirOlmayanKitapSayisiHesapla()
        {
            if (ds.Tables["KutuphanedekiVerilmeyeHazirOlmayanKitapSayisi"] != null)
                ds.Tables["KutuphanedekiVerilmeyeHazirOlmayanKitapSayisi"].Clear();//hata alma ihtimalini ortadan kaldırmak için eski verileri
                                                                                   //silerek yeni verileri eklemeye hazır hale getiriyoruz.
            kitapIslemleri.KutuphanedekiVerilmeyeHazirOlmayanKitapSayisi().Fill(ds, "KutuphanedekiVerilmeyeHazirOlmayanKitapSayisi");
            return Convert.ToInt32(ds.Tables["KutuphanedekiVerilmeyeHazirOlmayanKitapSayisi"].Rows[0][0]);
            //DataAdapter nesnesi olarak gelen verileri DataSete aktararak gerekli işlemlerimizi gerçekleştiriyor ve
            //return ediyoruz. 
        }

    }
}
