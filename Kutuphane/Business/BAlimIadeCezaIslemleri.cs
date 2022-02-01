using System;
using System.Data;
using Kutuphane.Data; //data katmanına erişebilmek için using tümcesiyle ekleme yapıyoruz.

namespace Kutuphane.Business
{
    class BAlimIadeCezaIslemleri
    {
        private AlimIadeCezaIslemleri alimIadeCeza = new AlimIadeCezaIslemleri(); //data katmanındaki classın metodlarını
                                                                          //kullanabilmek için classın nesnesini
                                                                          //oluşturuyoruz.

        public void IslemEkle(string barkod,string TC)
        {
            //Veritabanına yeni işlem kaydı eklemek için presentation>business>data ilişkisini kullandım ve form
            //ekranındaki verileri business katmanı aracılığıyla data katmanına ilettim.
            alimIadeCeza.IslemEkle(barkod, TC, DateTime.Now.Date); //DateTime.Now.Date bilgisayar tarih/sattinden bakarak
                                                                   //şuanki tarihi verir
        }

        public void KitapVerilmeyeHazırDegilYap(string barkod)
        {
            //Bir kitabın VerilmeyeHazirMi verisini false yapmak için bu aracı metodu kullandım.
            alimIadeCeza.KitapVerilmeyeHazirDegilYap(barkod);
        }

        public void KitapVerilmeyeHazirYap(string barkod)
        {
            //Bir kitabın VerilmeyeHazirMi verisini true yapmak için bu aracı metodu kullandım.
            alimIadeCeza.KitapVerilmeyeHazirYap(barkod);
        }

        public void CezaOde(string TC)
        {
            //Bir öğrencinin Ceza ödeme işlemini gerçekleştirmek için bu aracı metodu kullandım.
            alimIadeCeza.CezaOde(TC);
        }

        public void TeslimTarihiEkle(string TC)
        {
            //İade edilen kitap için Islemler tablosuna teslim tarihi ekleme işlemini gerçekleştirmek için bu aracı
            //metodu kullandım.
            alimIadeCeza.TeslimTarihiEkle(DateTime.Now.Date,TC);
        }

        public void CezaEkle()
        {
            //Teslim tarihi olan 7 günü aşan öğrenciye ceza ekleme işlemi için bu metodu kullandım.
            const int gun = 7; //gun değişkenini sabit olarak yani const olarak tanımladım. Çünkü bu değişkeni programın
                               //her yerinde verdiğim başlangıç değeri ile kullanılmasını istiyorum.
            int fark;
            DataSet ds=new DataSet();
            if (ds.Tables["Islemler"] != null)
                ds.Tables["Islemler"].Clear();
            alimIadeCeza.IslemlerTablosunuListele().Fill(ds,"Islemler"); //DataAdapter olarak data katmanından çektiğimiz
                                                                         //verileri işleyebilmek adına bir datasete
                                                                         //aktarıyoruz.
            for (int i = 0; i < ds.Tables["Islemler"].Rows.Count; i++)
            {
                fark = (int)(DateTime.Now.Date - Convert.ToDateTime(ds.Tables["Islemler"].Rows[i][3])).TotalDays;
                if ((fark-gun)>0)
                {
                    //DataSetteki tüm satırları karşılaştırarak alım tarihi ve teslim tarihi arasındaki farkı buluyor ve
                    //bu farka göre öğrencinin ödemesi gereken ceza tutarının hesaplamasını bu döngü ile gerçekleştirdim.
                    alimIadeCeza.CezaEkle(ds.Tables["Islemler"].Rows[i][2].ToString(),fark-gun);
                }
            }
        }
    }
}
