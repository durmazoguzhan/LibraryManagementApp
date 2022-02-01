using System;
using System.Drawing;
using System.Windows.Forms;
using Kutuphane.Business; //business katmanı ile olan bağlantıyı sağladık

namespace Kutuphane.Presentation
{
    public partial class KullaniciGirisSayfasi : Form
    {
        //Bu formda yetkili kullanıcı paneline ulaşmak için gerekli kullanıcı adı şifre giriş işlemini gerçekleştirdim.
        //Kullanıcı adı ve şifre programda değil veritabanı tablosunda kayıtlı. Böylece veri güvenliği sağlanıyor ve
        //yeni başka yetkide kullanıcılar eklenmek istendiğinde veritabanında ekleme imkanı sunmuş oluyoruz
        private SorguIslemleri sorguIslemleri = new SorguIslemleri(); //metotlarına ihtiyacımız olan SorguIslemleri classının
                                                              //nesnesini oluşturuyoruz

        public KullaniciGirisSayfasi()
        {
            InitializeComponent();
        }

        private void pboxGoz_Click(object sender, EventArgs e)
        {
            //şifreyi * şeklinde kodluyoruz. kullanıcı göz ikonuna basarsa şifreyi gösteriyor tekrar bastığında ise
            //şifreyi * ifadesiyle gizliyor.
            if (txtSifre.PasswordChar == '\0') //bu işlem için textbox'ın PasswordChar özelliğini kullanıyoruz.
                txtSifre.PasswordChar = '*';
            else
                txtSifre.PasswordChar = '\0';
        }

        private void pboxGoz_MouseEnter(object sender, EventArgs e)
        {
            pboxGoz.Size = new Size(25, 25); //imleç üstüne gelince boyutu büyült
        }

        private void pboxGoz_MouseLeave(object sender, EventArgs e)
        {
            pboxGoz.Size = new Size(20, 20); //imleç üstünde olmadığında boyutu küçült/normale getir
        }

        private void KullaniciGirisSayfasi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //bu formu çarpı ikonundan kapattığında tüm programı kapat.
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (sorguIslemleri.GirisBasariliMi(txtKullaniciAdi.Text,txtSifre.Text))//girilen kullanıcı adı ve şifre doğruysa
            {
                this.Hide(); //bu formu gizle
                if (Application.OpenForms["yetkiliPaneli"] == null)
                {
                    YetkiliPaneli yetkiliPaneli = new YetkiliPaneli(); //yetkiliPaneli isminde halihazırda açık olan bir
                                                                       //form yoksa oluştur
                    yetkiliPaneli.Show();//ve göster
                }
                else
                    Application.OpenForms["yetkiliPaneli"].Show(); //halihazırda yetkiliPaneli isimli bir form açıksa
                                                                   //onu göster
            }
            else// girilen kullanıcı adı ve şifre yanlışsa yani bu şifre ve kullanıcı adına ait Yetkili veritabanında kayıt yoksa
                MessageBox.Show("Hatalı kullanıcı adı veya şifre girdiniz.");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();//bu formu gizle
            Application.OpenForms["Anasayfa"].Show(); //anasayfa formunu göster
        }

        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar); //harf değilse girişi iptal et
        }
    }
}
