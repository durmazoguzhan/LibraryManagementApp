using System.Data.OleDb;

namespace Kutuphane.Data
{
    class KitapIslemleri:VeritabaniBaglanti //Kod tekrarını azaltmak için VeriTabaniBaglanti classından kalıtım aldı
    {
        
        public OleDbDataAdapter KitapListele()
        {
            con.Open(); //Kütüphanedeki tüm kitapları listelemek için bu metodu kullandım.
            query = "SELECT * FROM Kitap ORDER BY KitapAdi"; //Kitap tablosundaki tüm verileri listele ve KitapAdına göre
                                                             //alfabetik olarak sırala
            da = new OleDbDataAdapter(query, con);
            con.Close();
            return da;
        }

        public void KitapEkle(string barkod, string kitapAdi,string yazar,string tur,string yayinevi,string sayfaSayisi,string baskiYili,bool verilmeyeHazirMi)
        {
            con.Open(); //Business katmanından gereken verileri alarak Kitap tablosuna yeni kayıt eklemek için bu metodu
                        //kullandım.
            query = "INSERT INTO Kitap (Barkod, KitapAdi, Yazar, Tur, Yayinevi, SayfaSayisi, BaskiYili, VerilmeyeHazirMi) " +
                "VALUES(@Barkod, @KitapAdi, @Yazar, @Tur, @Yayinevi, @SayfaSayisi, @BaskiYili, @VerilmeyeHazirMi)"; //Kitap
                                                                                                  //tablosuna şu değerleri
                                                                                                  //şunlar olan yeni bir
                                                                                                  //kayıt ekle
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@Barkod", barkod); // query'de tırnak işaretleriyle uğraşmamak ve kod
                                                            // okunabilirliğini artırmak adına Command nesnesini kullandım
                                                            // ve parametreleri/gereken verileri bu nesne ile ilettim.
            cmd.Parameters.AddWithValue("@KitapAdi", kitapAdi);
            cmd.Parameters.AddWithValue("@Yazar", yazar);
            cmd.Parameters.AddWithValue("@Tur", tur);
            cmd.Parameters.AddWithValue("@Yayinevi", yayinevi);
            cmd.Parameters.AddWithValue("@SayfaSayisi", sayfaSayisi);
            cmd.Parameters.AddWithValue("@BaskiYili", baskiYili);
            cmd.Parameters.AddWithValue("@VerilmeyeHazirMi", verilmeyeHazirMi);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public OleDbDataAdapter BarkodaGoreKitapListele(string barkod)
        {
            con.Open(); //Barkod numarasını bilip diğer verilerini bilmediğim kitabın diğer verilerine sahip olabilmek için
                        //bu metodu kullandım.
            query = "SELECT * FROM Kitap WHERE Barkod = \"" + barkod + "\""; //Kitap tablosundaki Barkodu şu olan kayıtları
                                                                             //listele
            da = new OleDbDataAdapter(query, con);
            con.Close();
            return da;
        }

        public void KitapSil(string barkod)
        {
            con.Open(); //Kitap tablosundan kayıt silmek için yani kütüphaneden kitap silmek için bu metodu kullandım.
            query = "DELETE FROM Kitap WHERE Barkod = @Barkod"; //Kitap tablosundaki Barkodu şu olan kaydı sil.
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@Barkod", barkod);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void KitapGuncelle(string barkod, string kitapAdi, string yazar, string tur, string yayinevi, string sayfaSayisi, string baskiYili, bool verilmeyeHazirMi)
        {
            con.Open(); //Bir kitaba ait verileri güncellemek yani değiştirmek için bu metodu kuallandım.
            query = "UPDATE Kitap SET KitapAdi = @KitapAdi, Yazar = @Yazar, Tur = @Tur, Yayinevi = @Yayinevi, SayfaSayisi = @SayfaSayisi, BaskiYili = @BaskiYili, VerilmeyeHazirMi = @VerilmeyeHazirMi WHERE Barkod = @Barkod";
            //Kitap tablosundaki Barkodu şu olan kaydın şu sütunları şu veriler ile değiştir.
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@KitapAdi", kitapAdi); //Kod okunabilirliğini artırmak adına OledbCommand
                                                                //nesnesini kullandım ve verileri/parametreleri bu nesne
                                                                //ile query'e taşıdım.
            cmd.Parameters.AddWithValue("@Yazar", yazar);
            cmd.Parameters.AddWithValue("@Tur", tur);
            cmd.Parameters.AddWithValue("@Yayinevi", yayinevi);
            cmd.Parameters.AddWithValue("@SayfaSayisi", sayfaSayisi);
            cmd.Parameters.AddWithValue("@BaskiYili", baskiYili);
            cmd.Parameters.AddWithValue("@VerilmeyeHazirMi", verilmeyeHazirMi);
            cmd.Parameters.AddWithValue("@Barkod", barkod);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public OleDbDataAdapter KutuphanedekiKitapSayisi()
        {
            con.Open(); // Kütüphanedeki toplam kitap sayısını bulabilmek adına bu metodu kullandım.
            query = "SELECT COUNT(Barkod) FROM Kitap"; //Kitap tablosundaki kayıtların Barkod sütununa göre sayısını
                                                       //göster. Barkod sütununu tercih etmiş olmamın sebebi bu sütunun
                                                       //Primary Key olması ve boş geçilemeyen bir sütun olması
            da = new OleDbDataAdapter(query, con);
            con.Close();
            return da;
        }

        public OleDbDataAdapter KutuphanedekiVerilmeyeHazirKitapSayisi()
        {
            con.Open(); //Kütüphanedeki verilmeye hazır kitapların yani şuan hiç bir öğrencinin almamış olduğu kitapların
                        //sayısını öğrenmek için bu metodu kullandım.
            query = "SELECT COUNT(Barkod) FROM Kitap WHERE VerilmeyeHazirMi = True"; //Kitap tablosundaki VerilmeyeHazirMi
                                                                                     //verisi true olan kayıtların sayısını
                                                                                     //göster
            da = new OleDbDataAdapter(query, con);
            con.Close();
            return da;
        }

        public OleDbDataAdapter KutuphanedekiVerilmeyeHazirOlmayanKitapSayisi()
        {
            con.Open(); //Kütüphanedeki verilmeye hazır olmayan kitapların yani şuan öğrencilerin almış olduğu kitapların
                        //sayısını öğrenmek için bu metodu kullandım.
            query = "SELECT COUNT(Barkod) FROM Kitap WHERE VerilmeyeHazirMi = False"; //Kitap tablosundaki VerilmeyeHazirMi
                                                                                      //verisi false olan kayıtların
                                                                                      //sayısını göster
            da = new OleDbDataAdapter(query, con);
            con.Close();
            return da;
        }
    }
}
