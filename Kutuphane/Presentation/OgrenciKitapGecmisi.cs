using System;
using System.Drawing;
using System.Windows.Forms;
using Kutuphane.Business; //business katmanına bağlantıyı sağladık

namespace Kutuphane.Presentation
{
    public partial class OgrenciKitapGecmisi : Form
    {

        private ListelemeIslemleri listelemeIslemleri = new ListelemeIslemleri(); //metotlarına ihtiyacımız olan
                                                                          //ListelemeIslemleri classına ait nesne
                                                                          //oluşturduk
        private string TC;

        public OgrenciKitapGecmisi()
        {
            InitializeComponent();
        }

        private void pboxAnasayfa_Click(object sender, EventArgs e)
        {
            this.Hide(); //bu formu gizle
            Application.OpenForms["Anasayfa"].Show(); //Anasayfa formunu göster
        }

        private void OgrenciKitapGecmisi_Load(object sender, EventArgs e)
        {
            dataTeslimEdilmis.DefaultCellStyle.BackColor = Color.LightGreen; //teslim edilmiş kitapların olduğu
                                                                             //datagridviewdeki tüm satırların
                                                                             //arkaplanını yeşil olarak ayarlıyoruz
            OgrenciTablosunuYenile(); //öğrenci tablosundaki verileri güncelle
        }

        private void OgrenciTablosunuYenile()
        {
            //öğrenci tablosundaki verileri güncelle
            dataOgrenci.DataSource = listelemeIslemleri.OgrenciListele();
            dataOgrenci.Columns[1].HeaderText = "Ad Soyad"; //AdSoyad sütununun başlığı değiştir
            dataOgrenci.Columns[3].Visible = false; //kullanıcının görmesini istemediğimiz sütunları gizledik
            dataOgrenci.Columns[4].Visible = false;
            dataOgrenci.ClearSelection(); //seçimi temizledik. Bunu yaptığımızda önce seçimi siliyor ve sonra
                                          //otomatik olarak en üstteki satırı seçiyor. Bunu aslında yapmamızın amacı
                                          //seçimi yenilemek ve bu şekilde bilgi groupboxına verileri tekrar göndermek
        }

        private void OgrenciKitapGecmisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //bu form kapatılırsa tüm programı kapat
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            //TC kimlik numarasına göre filtreleme
            dataOgrenci.DataSource = listelemeIslemleri.OgrenciListeleTCyeGore(txtTC.Text);
        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {
            //Ad ve soyada göre filtreleme
            dataOgrenci.DataSource = listelemeIslemleri.OgrenciListeleAdaGore(txtAdSoyad.Text);
        }

        private void dataOgrenci_SelectionChanged(object sender, EventArgs e)
        {
            try //Hata oluştuğunda programın işleyişinin duraksamaması için try catch yapısı kullandım 
            {
                TC = dataOgrenci.SelectedCells[0].Value.ToString(); //tablodan tc verisini değişkene aktarıyoruz
                dataTeslimEdilmis.DataSource = listelemeIslemleri.TeslimEdilmisKitaplariListele(TC);
                //öğrenci seçimi değiştikçe dataTeslimEdilmis ve dataTeslimEdilmemis tablolarına veri çekme
                dataTeslimEdilmemis.DataSource = listelemeIslemleri.TeslimEdilmemisKitaplariListele(TC);
                for (int i = 0; i < dataTeslimEdilmemis.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dataTeslimEdilmemis.Rows[i].Cells[2].Value)>=0 && Convert.ToInt32(dataTeslimEdilmemis.Rows[i].Cells[2].Value) <= 2)
                    {
                        //teslim tarihine 2 günden az kalanların satırların arkaplanını sarı renk yap
                        dataTeslimEdilmemis.Rows[i].DefaultCellStyle.BackColor = Color.LightYellow;
                    }
                    else if (Convert.ToInt32(dataTeslimEdilmemis.Rows[i].Cells[2].Value) <= 0)
                    {
                        //teslim tarihi geçen satırların arkaplanını sarı renk yap
                        dataTeslimEdilmemis.Rows[i].DefaultCellStyle.BackColor = Color.PaleVioletRed;
                    }
                }
            }
            catch { }
        }

        private void dataTeslimEdilmis_SelectionChanged(object sender, EventArgs e)
        {
            dataTeslimEdilmis.ClearSelection(); //dataTeslimEdilmis classını seçim yapılamaz hale getirmek için
                                                //selectionchanged eventinde ClearSelection metodunu çalıştırdım.
        }

        private void dataTeslimEdilmemis_SelectionChanged(object sender, EventArgs e)
        {
            dataTeslimEdilmemis.ClearSelection(); //dataTeslimEdilmis classını seçim yapılamaz hale getirmek için
                                                  //selectionchanged eventinde ClearSelection metodunu çalıştırdım.
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["Anasayfa"].Show();
        }

        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar); //harf,boşluk veya noktalama işareti değilse girişi iptal et
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); //sayı değilse girişi iptal et
        }
    }
}
