using System;
using System.Data;
using Kutuphane.Data; //Data katmanına erişebilmek için gerekli tanımlamayı yapıyoruz.

namespace Kutuphane.Business
{
    class ListelemeIslemleri
    {
        private DataSet ds = new DataSet();
        private OgrenciKitapGecmisiIslemleri ogrenciKitapGecmisi = new OgrenciKitapGecmisiIslemleri(); //metodlarını kullanmak
                                                                                               //istediğimiz sınıfların
                                                                                               //nesnelerini oluşturuyoruz.
        DetayliKitapBilgileriIslemleri detayliKitapBilgileri = new DetayliKitapBilgileriIslemleri();
        int i,fark;
        const int gun = 7; //gun ifadesini programın hiç bir yerinde değişmesini istemediğim için const/sabit olarak
                           //tanımladım.
        string TC;

        public string KitapGorselListele(string barkod)
        {
            //barkod numarasına göre barkod.jpg şeklinde AppData'dan kitabın görselini çeken metot
            return "C:\\Users\\"+Environment.UserName+"\\AppData\\Roaming\\Kutuphane\\"+barkod+".jpg";
            //Environment.Username windowsa login olmuş kullanıcının adını verir
        }

        public DataTable KitapListele()
        {
            //Kütüphanedeki kitapları listelemek için kullandığım metot
            KitapIslemleri dataKitapIslemleri = new KitapIslemleri();
            if(ds.Tables["Kitap"]!=null)//hata alma ihtimalini ortadan kaldırmak için eski verileri
                                        //silerek yeni verileri eklemeye hazır hale getiriyoruz.
                ds.Tables["Kitap"].Clear();
            dataKitapIslemleri.KitapListele().Fill(ds,"Kitap");
            return ds.Tables["Kitap"]; //datagridview'de DataSource olarak kullanmak için DataTable tipinde return ediyoruz
        }

        public DataView KitapListeleBarkodaGore(string barkod)
        {
            //Burada data katmanına erişim sağlamıyoruz. Sadece elimizdeki verilerle DataView oluşturarak kitap
            //datagridviewinin Barkod bazında kitap filtrelemesini gerçekleştiriyoruz.
            DataView dv = ds.Tables["Kitap"].DefaultView;
            dv.RowFilter = "Barkod Like '" + barkod + "%'"; //Barkod sütununun parametre olarak aldığımız barkoda benzer
                                                            //olup olmadığını Like tümcesi ile anlıyoruz ve bunuda
                                                            //DataView'in özelliği olan RowFilter ile gerçekleştiriyoruz.
            return dv;
        }

        public DataView KitapListeleAdaGore(string kitapAdi)
        {
            //Burada data katmanına erişim sağlamıyoruz. Sadece elimizdeki verilerle DataView oluşturarak kitap
            //datagridviewinin Kitap Adı bazında kitap filtrelemesini gerçekleştiriyoruz.
            DataView dv = ds.Tables["Kitap"].DefaultView;
            dv.RowFilter = "KitapAdi Like '" + kitapAdi + "%'"; //KitapAdi sütununun parametre olarak aldığımız kitapAdi'na
                                                                //benzer olup olmadığını Like tümcesi ile anlıyoruz ve
                                                                //bunuda DataView'in özelliği olan RowFilter ile
                                                                //gerçekleştiriyoruz.
            return dv;
        }

        public DataTable OgrenciListele()
        {
            //Kütüphanedeki öğrencileri listelemek için kullandığım metot
            OgrenciIslemleri dataOgrenciIslemleri = new OgrenciIslemleri();
            if (ds.Tables["Ogrenci"] != null)//hata alma ihtimalini ortadan kaldırmak için eski verileri
                                             //silerek yeni verileri eklemeye hazır hale getiriyoruz.
                ds.Tables["Ogrenci"].Clear();
            dataOgrenciIslemleri.OgrenciListele().Fill(ds, "Ogrenci"); 
            return ds.Tables["Ogrenci"]; //datagridview'de DataSource olarak kullanmak için DataTable tipinde return ediyoruz
        }

        public DataView OgrenciListeleAdaGore(string adSoyad)
        {
            //Burada data katmanına erişim sağlamıyoruz. Sadece elimizdeki verilerle DataView oluşturarak öğrenci
            //datagridviewinin Öğrenci Adı bazında öğrenci filtrelemesini gerçekleştiriyoruz.
            DataView dv = ds.Tables["Ogrenci"].DefaultView;
            dv.RowFilter = "AdSoyad Like '" + adSoyad + "%'"; //AdSoyad sütununun parametre olarak aldığımız adSoyad'a
                                                              //benzer olup olmadığını Like tümcesi ile anlıyoruz ve
                                                              //bunuda DataView'in özelliği olan RowFilter ile
                                                              //gerçekleştiriyoruz.
            return dv;
        }

        public DataView OgrenciListeleTCyeGore(string TC)
        {
            //Burada data katmanına erişim sağlamıyoruz. Sadece elimizdeki verilerle DataView oluşturarak öğrenci
            //datagridviewinin TC kimlik numarası bazında öğrenci filtrelemesini gerçekleştiriyoruz.
            DataView dv = ds.Tables["Ogrenci"].DefaultView;
            dv.RowFilter = "TC Like '" + TC + "%'"; //TC sütununun parametre olarak aldığımız TC'ye
                                                    //benzer olup olmadığını Like tümcesi ile anlıyoruz ve
                                                    //bunuda DataView'in özelliği olan RowFilter ile
                                                    //gerçekleştiriyoruz.
            return dv;
        }

        public DataTable TeslimEdilmisKitaplariListele(string TC)
        {
            //Teslim edilmiş kitapları listelemek için bu metodu kullandım.
            DataTable duzenlenmisTeslimEdilmisKitaplar = new DataTable();
            //Birkaç tabloyu birleştirmem gerektiği için yeni bir DataTable tanımladım ve tablolardaki istediğim sütunları
            //bu DataTable'a ekledim.
            duzenlenmisTeslimEdilmisKitaplar.Columns.Add("Kitap Adı");
            duzenlenmisTeslimEdilmisKitaplar.Columns.Add("Alım Tarihi");
            duzenlenmisTeslimEdilmisKitaplar.Columns.Add("Teslim Tarihi");
            if (ds.Tables["TeslimEdilmisKitaplar"] != null)
                ds.Tables["TeslimEdilmisKitaplar"].Clear();//hata alma ihtimalini ortadan kaldırmak için eski verileri
                                                           //silerek yeni verileri eklemeye hazır hale getiriyoruz.
            if (ds.Tables["KitabinAdi"] != null)
                ds.Tables["KitabinAdi"].Clear();
            ogrenciKitapGecmisi.TeslimEdilmisKitaplariListele(TC).Fill(ds, "TeslimEdilmisKitaplar");
            
            for (i = 0; i < ds.Tables["TeslimEdilmisKitaplar"].Rows.Count; i++)
            {
                //Kitap adını bilmediğimden data katmanından barkod ile çektim ve tarihle ilgili verileri de data
                //katmanından ayrı bir metot ile çektim. Bu çektiğim verileri bu döngü ile birlikte kendi datatable'ımda
                //topladım.
                duzenlenmisTeslimEdilmisKitaplar.Rows.Add(
                    ogrenciKitapGecmisi.BarkodaGoreKitapAdiBulma(ds.Tables["TeslimEdilmisKitaplar"].Rows[i][1].ToString()),
                    ds.Tables["TeslimEdilmisKitaplar"].Rows[i][3].ToString().Substring(0,10),
                    ds.Tables["TeslimEdilmisKitaplar"].Rows[i][4].ToString().Substring(0,10));
            }
            return duzenlenmisTeslimEdilmisKitaplar; //son olarak oluşturduğum DataTable'ı return ettim.
        }

        public DataTable TeslimEdilmemisKitaplariListele(string TC)
        {
            //Teslim edilmemiş kitapları listelemek için bu metodu kullandım.
            DataTable duzenlenmisTeslimEdilmemisKitaplar = new DataTable();
            //Birkaç tabloyu birleştirmem gerektiği için yeni bir DataTable tanımladım ve tablolardaki istediğim sütunları
            //bu DataTable'a ekledim.
            duzenlenmisTeslimEdilmemisKitaplar.Columns.Add("Kitap Adı");
            duzenlenmisTeslimEdilmemisKitaplar.Columns.Add("Alım Tarihi");
            duzenlenmisTeslimEdilmemisKitaplar.Columns.Add("Teslim Etmeye Kalan Gün");
            if (ds.Tables["TeslimEdilmemisKitaplar"] != null)
                ds.Tables["TeslimEdilmemisKitaplar"].Clear();//hata alma ihtimalini ortadan kaldırmak için eski verileri
                                                             //silerek yeni verileri eklemeye hazır hale getiriyoruz.
            if (ds.Tables["KitabinAdi"] != null)
                ds.Tables["KitabinAdi"].Clear();
            ogrenciKitapGecmisi.TeslimEdilmemisKitaplariListele(TC).Fill(ds, "TeslimEdilmemisKitaplar");

            for (i = 0; i < ds.Tables["TeslimEdilmemisKitaplar"].Rows.Count; i++)
            {
                //Kitap adını bilmediğimden data katmanından barkod ile çektim ve tarihle ilgili verileri de data
                //katmanından ayrı bir metot ile çektim. Bu çektiğim verileri bu döngü ile birlikte kendi datatable'ımda
                //topladım.
                fark = (int)(DateTime.Now.Date - Convert.ToDateTime(ds.Tables["TeslimEdilmemisKitaplar"].Rows[i][3])).TotalDays;
                duzenlenmisTeslimEdilmemisKitaplar.Rows.Add(
                    ogrenciKitapGecmisi.BarkodaGoreKitapAdiBulma(ds.Tables["TeslimEdilmemisKitaplar"].Rows[i][1].ToString()),
                    ds.Tables["TeslimEdilmemisKitaplar"].Rows[i][3].ToString().Substring(0, 10),
                    gun-fark); //teslim edilmesi gereken gün-fark ile Kalan Günü hesapladım ve onu da DataTable'a ekledim.
            }

            return duzenlenmisTeslimEdilmemisKitaplar; //son olarak oluşturduğum DataTable'ı return ettim.
        }

        public DataTable KitabaGoreKisiListele(string barkod)
        {
            //Burada öğrencilerin geçmişte alıp iade ettiği ve halihazırda alıp teslim etmediği kitapların listesini
            //DataTable oluşturarak bir bütün halinde bu metotla elde ettim.
            DataTable duzenlenmisKitabiTeslimAlanEdenler = new DataTable();
            duzenlenmisKitabiTeslimAlanEdenler.Columns.Add("Öğrenci Adı Soyadı");
            duzenlenmisKitabiTeslimAlanEdenler.Columns.Add("Alım Tarihi");
            duzenlenmisKitabiTeslimAlanEdenler.Columns.Add("Teslim Tarihi");
            if (ds.Tables["KitabiTeslimAlanEdenKisiler"] != null)
                ds.Tables["KitabiTeslimAlanEdenKisiler"].Clear();//hata alma ihtimalini ortadan kaldırmak için eski verileri
                                                                 //silerek yeni verileri eklemeye hazır hale getiriyoruz.
            if (ds.Tables["OgrenciAdi"] != null)
                ds.Tables["OgrenciAdi"].Clear();
            detayliKitapBilgileri.KitabaGoreKisileriListele(barkod).Fill(ds, "KitabiTeslimAlanEdenKisiler");

            for (int i = 0; i < ds.Tables["KitabiTeslimAlanEdenKisiler"].Rows.Count; i++)
            {
                //Bu döngü ile birlikte DataTable'a gerekli verileri ekledim.
                //Bu veriler: Öğrenci Adı | Alım Tarihi | Teslim Tarihi
                TC = ds.Tables["KitabiTeslimAlanEdenKisiler"].Rows[i][2].ToString();

                if (ds.Tables["KitabiTeslimAlanEdenKisiler"].Rows[i][4].ToString() == "")
                {
                    duzenlenmisKitabiTeslimAlanEdenler.Rows.Add(
                    detayliKitapBilgileri.TCyeGoreOgrenciAdiBulma(TC),
                    ds.Tables["KitabiTeslimAlanEdenKisiler"].Rows[i][3].ToString().Substring(0, 10),
                    null);
                }
                else
                {
                    duzenlenmisKitabiTeslimAlanEdenler.Rows.Add(
                    detayliKitapBilgileri.TCyeGoreOgrenciAdiBulma(TC),
                    //Substring(0, 10) ifadesi ile birlikte sadece tarih değerini aldım. Saat değerini almadım. Yani
                    //DateTime tipini string tipe dönüştürerek string ifadede kesme işlemi yapmış oldum
                    ds.Tables["KitabiTeslimAlanEdenKisiler"].Rows[i][3].ToString().Substring(0, 10),
                    ds.Tables["KitabiTeslimAlanEdenKisiler"].Rows[i][4].ToString().Substring(0, 10));
                }
                
            }

            return duzenlenmisKitabiTeslimAlanEdenler; //Son olarak oluşturduğum DataTable'ı return ettim.
        }
    }
}
