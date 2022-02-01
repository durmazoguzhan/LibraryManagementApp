using System.Data.OleDb;

namespace Kutuphane.Data
{
    class KullaniciIslemleri:VeritabaniBaglanti //Kod tekrarını azaltmak adına VeritabaniBaglanti classından kalıtım alıyor.
    {

        public OleDbDataAdapter YetkiliKullaniciGirisi(string kullaniciAdi,string sifre)
        {
            con.Open(); //Yetkili kullanıcı paneline erişim için aşılması gereken yetkili kullanıcı login formunda girilen
                        //kullanıcı adı ve şifre değerlerinin doğru olup olmadığını kontrol etmek adına bu metodu kullandım.
            query = "SELECT * FROM Yetkili WHERE KullaniciAdi = \"" + kullaniciAdi + "\" AND Sifre = \"" + sifre + "\"";
            //Yetkili tablosundaki KullaniciAdi değeri şu ve Sifre değeri şu olan kayıtları listele
            da = new OleDbDataAdapter(query, con);
            con.Close();
            return da;
        }

    }
}
