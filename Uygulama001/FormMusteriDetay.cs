using System;
using System.Windows.Forms;

namespace Uygulama001
{
    public partial class FormMusteriDetay : Form
    {
        public FormMusteri.Musteri YeniMusteri { get; set; }

        public FormMusteriDetay()
        {
            InitializeComponent();
            YeniMusteri = new FormMusteri.Musteri(); // Yeni bir müşteri oluştur
        }

        public FormMusteriDetay(FormMusteri.Musteri musteri)
        {
            InitializeComponent();
            YeniMusteri = musteri; // Düzenlenecek müşteriyi atama
            // Müşteri bilgilerini forma yükle
            txtAd.Text = musteri.Ad;
            txtTelefon.Text = musteri.Telefon;
            txtAciklama.Text = musteri.Aciklama;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Form üzerindeki bilgileri al
            YeniMusteri.Ad = txtAd.Text;
            YeniMusteri.Telefon = txtTelefon.Text;
            YeniMusteri.Aciklama = txtAciklama.Text;

            // Formu kapat
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
