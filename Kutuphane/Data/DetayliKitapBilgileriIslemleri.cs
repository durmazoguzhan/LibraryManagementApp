using System.Data;
using System.Data.OleDb;
namespace Kutuphane.Data
{
    class DetayliKitapBilgileriIslemleri:VeritabaniBaglanti //Kod tekrarını azaltmak adına VeritabaniBaglanti classından
                                                            //kalıtım alıyor.
    {
        private DataSet ds = new DataSet(); //DataAdapter ile çektiğim verileri işleyebilmek adına bir DataSet tanımladım.

        public OleDbDataAdapter KitabaGoreKisileriListele(string barkod)
        {//Belirli bir kitaba ait yapılan tüm işlem kayıtlarını listeleyebilmek için bu metodu kullandım.
            con.Open();
            query = "SELECT * FROM Islemler WHERE Barkod = \"" + barkod + "\" ORDER BY AlimTarihi"; //Barkodu şu olan tüm
                                                                                                    //işlemleri listele ve
                                                                                                    //AlımTarihine göre
                                                                                                    //eskiden yeniye sırala
            da = new OleDbDataAdapter(query, con);
            con.Close();
            return da;
        }

        public string TCyeGoreOgrenciAdiBulma(string TC)
        {
            con.Open(); //TC'sine sahip olduğum ama Adını bilmediğim öğrencilerin adlarını listeleyebilmek ve
                        //öğrenemebilmek için bu metodu kullandım.
            query = "SELECT AdSoyad FROM Ogrenci WHERE TC = \"" + TC + "\""; //TC'si şu olan öğrencinin AdSoyad verisini
                                                                             //göster
            da = new OleDbDataAdapter(query, con);
            if (ds.Tables["OgrenciAdi"] != null) //bu nesne ve metot tekrar tekrar kullanıldığında sorun oluşmaması adına
                                                 //datasetteki tablonun boş olup olmadığını kontrol ettim ve doluysa yeni
                                                 //veriler ile eski verilerin karışmaması adına datasetteki üzerinde işlem
                                                 //yapacağım tabloyu Clear() metodu ile temizledim.
                ds.Tables["OgrenciAdi"].Clear();
            da.Fill(ds, "OgrenciAdi");
            con.Close();
            return ds.Tables["OgrenciAdi"].Rows[0][0].ToString(); //Bulduğum öğrenci adını string tipinde business
                                                                  //katmanına return ettim.
        }
    }
}
