using System;
using System.Data.OleDb; //Access veritabanı kullandığımız için command,connection,adapter gibi sınıfları kullanabilmek
                         //adına OleDb kütüphanesini kullandım.

namespace Kutuphane.Data
{
    class AlimIadeCezaIslemleri:VeritabaniBaglanti //kod tekrarını azaltmak amacıyla Data katmanındaki tüm classlar
                                                   //VeriTabaniBaglanti classından kalıtım alıyor.
    {
        public OleDbDataAdapter TeslimEdilmeyenKitap(string TC) //Öğrencinin teslim etmediği kitap olup olmadığını
                                                                //sorgulayan metot
        {
            con.Open();
            query = "SELECT * FROM Islemler WHERE TC = \""+TC+"\" AND TeslimTarihi IS NULL"; //TC'yi Presentation>Business
                                                                                             //>Data şeklinde formdan
                                                                                             //buraya çektim.
            da = new OleDbDataAdapter(query, con); //DataAdapter ile sorguma ait verileri çektim ve çektiğim verileri
                                                   //Tekrar business katmanına gönderdim.
            con.Close();
            return da;
        }

        public void IslemEkle(string barkod, string TC, DateTime alimTarihi)
        {
            con.Open(); //burada business katmanından aldığım parametreler ile birlikte veritabanındaki Islemler tablosuna
                        //ekleme/insert işlemi gerçekleştirdim.
            query = "INSERT INTO Islemler (Barkod, TC, AlimTarihi) " +
                "VALUES('"+barkod+"', '"+TC+"', '"+alimTarihi+"')"; // Islemler tablosuna Barkod, TC, AlimTarihi değerleri
                                                                    // şunlar olan yeni bir kayıt ekle
            cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close(); //return olarak business'a tekrar göndermem gereken bir veri olmadığı için return tipini
                         //void olarak belirledim.
        }

        public void KitapVerilmeyeHazirDegilYap(string barkod)
        {
            con.Open(); //Bir kitabı bir öğrenci aldığında o kitabı başka bir öğrenci alamamalı. Bu yüzden Kitap
                        //tablosundaki VerilMeyeHazirMi bool ifadesini bu metot ile false haline getirdim.
            query = "UPDATE Kitap SET VerilmeyeHazirMi = False WHERE Barkod = '"+barkod+"'"; //Kitap tablosunda barkodu şu
                                                                                             //olan kitabın
                                                                                             //VerilmeyeHazirMi verisini
                                                                                             //False yap. 
            cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close(); //business katmanına göndermem gereken bir veri olmadığından return tipini void olarak belirledim.
        }

        public void KitapVerilmeyeHazirYap(string barkod)
        {
            con.Open(); //Bir kitabı bir öğrenci iade ettiğinde kitabın verilmeye hazır duruma gelmesi ve diğer öğrencilerin
                        //artık bu kitabı alabiliyor olması gerekiyordu. Bunu sağlamak için bu metodu oluşturdum.
            
            query = "UPDATE Kitap SET VerilmeyeHazirMi = True WHERE Barkod = '" + barkod + "'"; //Kitap tablosunda barkodu
                                                                                                //bu olan kitabın
                                                                                                //VerilmeyeHazirMi verisini
                                                                                                //True yap
                                                                                                
            cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void CezaOde(string TC)
        {
            con.Open();//Cezası olan öğrencilerin ceza ödeme işlemlerini bu metot ile gerçekleştirdim.
            query = "UPDATE Ogrenci SET Ceza = 0 WHERE TC = '" + TC + "'"; //TC'si şu olan Öğrencinin Ceza verisini 0 yap.
            cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void CezaEkle(string TC,int ceza)
        {
            con.Open();//Aldığı kitabı teslim etmesi gereken süreyi geçiren öğrencinin ceza alma işlemlerini bu metot ile
                       //gerçekleştirdim.
            query = "UPDATE Ogrenci SET Ceza = "+ceza+" WHERE TC = '" + TC + "'"; //TC'si şu olan öğrencinin ceza verisini
                                                                                  //şu yap.
            cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void TeslimTarihiEkle(DateTime teslimTarihi,string TC)//teslimTarihi, alimTarihi verilerini tarihsel düzeyde
                                                                     //çalışmak adına DateTime veri tipi ile tanımladım.
        {
            con.Open(); //Aldığı kitabı öğrenci iade ettikten sonra veritabanına teslim tarihinin eklenmesi için bu metodu
                        //kullandım.
            query = "UPDATE Islemler SET TeslimTarihi = '"+teslimTarihi+ "' WHERE TC = \"" + TC + "\" AND TeslimTarihi IS NULL";
            //TC'si şu olan ve TeslimTarihi null olan işlemin TeslimTarihi verisini şu yap.
            cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public OleDbDataAdapter IslemlerTablosunuListele()
        {
            con.Open(); //Islemler tablosunu listeleyip DataAdapter ile business katmanında işleyebileceğim hale
                        //getirebilmek için bu metodu kullandım
            query = "SELECT * FROM Islemler WHERE TeslimTarihi IS NULL"; //TeslimTarihi null olan işlemleri listele
            da = new OleDbDataAdapter(query, con);
            con.Close();
            return da; //Islemler tablosunu listeledim çünkü alım tarihleri ile bugünün tarihini karşılaştırarak Ceza
                       //hesaplaması yapmak için kullanacağım.
        }
    }
}
