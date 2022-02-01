using System.Data;
using System.Data.OleDb;

namespace Kutuphane.Data
{
    class OgrenciKitapGecmisiIslemleri:VeritabaniBaglanti //Kod tekrarını azaltmak için VeritabaniBaglanti classından
                                                          //kalıtım alıyor.
    {
        private DataSet ds = new DataSet(); //DataAdapter tipindeki veriler ile detaylı işlemler yapabilmek için bir DataSet
                                    //nesnesi tanımladım.

        public OleDbDataAdapter TeslimEdilmisKitaplariListele(string TC)
        {
            con.Open(); //Kütüphanedeki teslim edilmiş kitapların listesine erişebilmek adına bu metodu kullandım.
            query = "SELECT * FROM Islemler WHERE TC = \"" + TC + "\" AND TeslimTarihi IS NOT NULL";
            //Islemler tablosundaki TC'si şu olan ve TeslimTarihi verisi null olmayan kayıtları listele
            da = new OleDbDataAdapter(query, con);
            con.Close();
            return da;
        }

        public OleDbDataAdapter TeslimEdilmemisKitaplariListele(string TC)
        {
            con.Open(); //Kütüphanedeki teslim edilmemiş kitapların listesine erişebilmek adına bu metodu kullandım.
            query = "SELECT * FROM Islemler WHERE TC = \"" + TC + "\" AND TeslimTarihi IS NULL";
            //Islemler tablosundaki TC'si şu olan ve TeslimTarihi verisi null olan kayıtları listele
            da = new OleDbDataAdapter(query, con);
            con.Close();
            return da;
        }

        public string BarkodaGoreKitapAdiBulma(string barkod)
        {
            con.Open(); //Barkod numarasını bildiğimiz ama adını bilmediğimiz kitapların adını öğrenebilmek için bu metodu
                        //kullandım.
            query = "SELECT KitapAdi FROM Kitap WHERE Barkod = \"" + barkod + "\""; //Kitap tablosundaki Barkod verisi şu
                                                                                    //olan kaydın KitapAdi sütununu listele.
            da = new OleDbDataAdapter(query, con);
            if (ds.Tables["KitapAdi"] != null) //DataSetteki belirttiğimiz tablodaki verilerle alakalı bir hata ile
                                               //karşılaşmamak adına datasetteki eski verileri siliyor ve yeni veriler
                                               //eklemeye hazır hale getiriyoruz.
                ds.Tables["KitapAdi"].Clear();
            da.Fill(ds, "KitapAdi"); //DataAdapterdeki verileri ds DataSetine "KitapAdi" şeklinde isimlendirerek aktar.
            con.Close();
            return ds.Tables["KitapAdi"].Rows[0][0].ToString(); //Kitap adını direkt string olarak business katmanına
                                                                //return ediyoruz.
        }
    }
}
