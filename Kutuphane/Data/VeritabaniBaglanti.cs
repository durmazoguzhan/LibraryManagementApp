using System;
using System.Data.OleDb;

namespace Kutuphane.Data
{
    //Bu class bizim Base Classımız. Yani Data katmanındaki diğer classların ortak olarak kalıtım alacağı sınıf bu sınıf
    //Neden abstract?
    //interface=    nesnesi oluşturulamaz | body'e sahip metod yok |public destekliyor
    //abstract=     nesnesi oluşturulamaz | body'e sahip metod var |private,protected,public destekliyor
    //Öncelikle bu classı nesne olarak çağırmayacağım için aklıma bu classı abstract veya interface yapmak geldi.
    //Veritabanı bağlantısında kullandığım değişkenleri constructor'da oluşturmak ve destructor'da imha etmek istiyordum.
    //Bu sebeple body'li metodları destekleyen abstract class'ı kullanma kararı aldım.

    abstract class VeritabaniBaglanti
    {
        protected OleDbConnection con; //Data katmanındaki diğer classlar için ortak olarak kullanılacak olan değişkenlerini
                                       //bu classta tanımlıyorum. Bu sayede kod tekrarını azaltmış oluyoruz.
        protected OleDbDataAdapter da;
        protected OleDbCommand cmd; //değişkenleri sadece bu classın metotları ve bu classtan kalıtım alan diğer classlar
                                    //ulaşabilsin diye protected olarak tanımladım
        protected string query;
        protected string constring;

        public VeritabaniBaglanti()
        {
            //Environment.UserName ifadesi windowsa login olmuş olan kullanıcının adını veriyor
            constring = "C:\\Users\\"+Environment.UserName+"\\AppData\\Roaming\\Kutuphane\\Kutuphane.accdb";
            //Veritabanı bağlantımızı gerçekleştirmek için connectionstringimizi hazırlıyoruz.
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + constring);
        }

        ~VeritabaniBaglanti()
        {
            con.Dispose(); //Dispose() metodu ile con değişkenini imha ediyor ve ramde kapladığı alanı serbest bırakıyoruz.
        }
    }
}
