using System;
using System.Drawing;
using System.Windows.Forms;
using Kutuphane.Business; //Business katmanı ile olan bağı sağlıyoruz

namespace Kutuphane.Presentation
{
    public partial class GrafikSayfasi : Form
    {

        private KutuphanedekiKitapSayilari kitapSayilari = new KutuphanedekiKitapSayilari(); //metotlarını kullanacağımız classın
                                                                                     //nesnesini oluşturuyoruz

        public GrafikSayfasi()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //şuanki formu gizleyerek yetkiliPaneli menüsüne dönüşü sağlıyoruz
            this.Hide();
            Application.OpenForms["yetkiliPaneli"].Show();
        }

        private void GrafikSayfasi_Load(object sender, EventArgs e)
        {
            //eski grafik verilerini temizliyoruz
            zedGraphControl1.GraphPane.CurveList.Clear();
            //kitap sayılarını çekerek bunları zedgraphta kullanabilmek adına double dizilere atıyoruz.
            double[] toplamKitap = new double[1];
            toplamKitap[0] = kitapSayilari.KutuphanedekiKitapSayisiHesapla();
            double[] verilmeyeHazirKitap = new double[1];
            verilmeyeHazirKitap[0] = kitapSayilari.KutuphanedekiVerilmeyeHazirKitapSayisiHesapla();
            double[] verilmeyeHazirOlmayanKitap = new double[1];
            verilmeyeHazirOlmayanKitap[0] = kitapSayilari.KutuphanedekiVerilmeyeHazirOlmayanKitapSayisiHesapla();
            //elimizdeki veriler ve dizilerle zedgrapha verilerimizi ekliyor ve renk title gibi özelleştirmeleri yapıyoruz.
            zedGraphControl1.GraphPane.AddBar("Tüm Kitaplar", toplamKitap, toplamKitap, Color.Red);
            zedGraphControl1.GraphPane.AddBar("Verilmeye Hazır Olan Kitaplar", toplamKitap, verilmeyeHazirKitap, Color.Green);
            zedGraphControl1.GraphPane.AddBar("Alınmış Kitaplar", toplamKitap, verilmeyeHazirOlmayanKitap, Color.Blue);
            //grafik başlığı ve eksen isimlerini dilediğimizde ayarlıyoruz
            zedGraphControl1.GraphPane.Title.Text="Kütüphanedeki Kitaplara Ait Grafik";
            zedGraphControl1.GraphPane.XAxis.Title.Text = "x ekseni";
            zedGraphControl1.GraphPane.YAxis.Title.Text = "y ekseni";
            //eksenlerin otomatik olarak oluşturulmasını sağlıyoruz
            zedGraphControl1.GraphPane.XAxis.ResetAutoScale(zedGraphControl1.GraphPane, CreateGraphics());
            zedGraphControl1.GraphPane.YAxis.ResetAutoScale(zedGraphControl1.GraphPane, CreateGraphics());
            //son olarak displayi güncelliyoruz.
            zedGraphControl1.Refresh();
        }

        private void GrafikSayfasi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //bu formu kapadığımda programı kapat
        }
    }
}
