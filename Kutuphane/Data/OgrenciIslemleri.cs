using System;
using System.Data.OleDb;

namespace Kutuphane.Data
{
    class OgrenciIslemleri:VeritabaniBaglanti //Kod tekrarını azaltmak için VeritabaniBaglanti classından kalıtım alıyor.
    {

        public OleDbDataAdapter OgrenciListele()
        {
            con.Open(); //Veritabanına kayıtlı öğrencileri listelemek adına bu metodu kullandım.
            query = "SELECT * FROM Ogrenci ORDER BY AdSoyad"; //Ogrenci tablosundaki kayıtları listele ve AdSoyad verisine
                                                              //göre alfabetik olarak sırala
            da = new OleDbDataAdapter(query, con);
            con.Close();
            return da;
        }

        public void OgrenciEkle(string TC,string adSoyad,string cinsiyet,DateTime dogumTarihi,DateTime uyelikTarihi, int ceza)
        {
            con.Open(); //Business clasından alınan gerekli parametreler ile birlikte Ogrenci tablosuna yeni kayıt eklemek
                        //için bu metodu kullandım.
            query = "INSERT INTO Ogrenci (TC, AdSoyad, Cinsiyet, DogumTarihi, UyelikTarihi, Ceza) " +
                "VALUES(@TC, @AdSoyad, @Cinsiyet, @DogumTarihi, @UyelikTarihi, @Ceza)";
            //Ogrenci tablosuna verileri şunlar olan yeni bir kayıt ekle.
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@TC", TC); //Kod okunabilirliğini artırmak için query içinde direkt olarak +
                                                    //belirteçleri kullanmak yerine OledbCommand kullandım. Ve sonra
                                                    //gerekli parametreleri/verileri command aracılığıyla query'e aktardım.
            cmd.Parameters.AddWithValue("@AdSoyad", adSoyad);
            cmd.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
            cmd.Parameters.AddWithValue("@DogumTarihi", dogumTarihi);
            cmd.Parameters.AddWithValue("@UyelikTarihi", uyelikTarihi);
            cmd.Parameters.AddWithValue("@Ceza", ceza);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public OleDbDataAdapter TCyeGoreOgrenciListele(string TC)
        {
            con.Open(); //TC'si bilinen öğrencinin diğer verilerine erişmek için bu metodu kullandım.
            query = "SELECT * FROM Ogrenci WHERE TC = \"" + TC + "\""; //Ogrenci tablosundaki TC verisi şu olan kayıtları
                                                                       //listele.
            da = new OleDbDataAdapter(query, con);
            con.Close();
            return da;
        }

        public void OgrenciSil(string TC)
        {
            con.Open(); //Ogrenci tablosundan bir kayıt silmek için yani kütüphaneye kayıtlı bir öğrencinin kaydını silmek
                        //için bu metodu kullandım.
            query = "DELETE FROM Ogrenci WHERE TC = @TC"; //Ogrenci tablosundaki TC'si şu olan kaydı sil.
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@TC", TC); //Kod okunabilirliğini artırmak adına OledbCommand nesnesini kullandım
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void OgrenciGuncelle(string TC, string adSoyad, string cinsiyet, DateTime dogumTarihi, DateTime uyelikTarihi, int ceza)
        {
            con.Open(); //Gerekli parametreleri business katmanından alarak ve tarihle ilgili verileri tarihsel düzeyde
                        //işlem yapabilmek adına Datetime tipinde alarak bir öğrenciye ait kayıtlı bilgileri değiştirmek
                        //için bu metodu kullandım.
            query = "UPDATE Ogrenci SET AdSoyad = @AdSoyad, Cinsiyet = @Cinsiyet, DogumTarihi = @DogumTarihi, UyelikTarihi = @UyelikTarihi, Ceza = @Ceza WHERE TC = @TC";
            //Ogrenci tablosundaki TC'si şu olan kaydın verilerini şunlar ile güncelle.
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@AdSoyad", adSoyad); //Kod okunabilirliğini artırmak adına OledbCommand nesnesini
                                                              //kullandım ve gerekli verileri bu nesne ile query'e aktardım.
            cmd.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
            cmd.Parameters.AddWithValue("@DogumTarihi", dogumTarihi);
            cmd.Parameters.AddWithValue("@UyelikTarihi", uyelikTarihi);
            cmd.Parameters.AddWithValue("@Ceza", ceza);
            cmd.Parameters.AddWithValue("@TC", TC);
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
