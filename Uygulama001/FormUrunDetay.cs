using System;
using System.Drawing;
using System.Windows.Forms;
using static Uygulama001.FormUrunlerim;
namespace Uygulama001
{
    public partial class FormUrunDetay : Form
    {
        private Urun duzenlenenUrun;

        public FormUrunDetay(Urun urun)
        {
            InitializeComponent();
            duzenlenenUrun = urun;


            txtAdi.Text = duzenlenenUrun.Adi;
            txtKodu.Text = duzenlenenUrun.Kodu;
            txtFiyati.Text = duzenlenenUrun.Fiyati;
            txtAciklama.Text = duzenlenenUrun.Aciklama;
            if (!string.IsNullOrEmpty(duzenlenenUrun.ResimDosyaYolu) && System.IO.File.Exists(duzenlenenUrun.ResimDosyaYolu))
            {
                pictureBoxResim.Image = Image.FromFile(duzenlenenUrun.ResimDosyaYolu);
            }
        }

        public Urun DuzenlenenUrun
        {
            get { return duzenlenenUrun; }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxResim.Image = Image.FromFile(fileDialog.FileName);
            }
        }

        private void btnResimSil_Click(object sender, EventArgs e)
        {
            pictureBoxResim.Image = null;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            duzenlenenUrun.Adi = txtAdi.Text;
            duzenlenenUrun.Kodu = txtKodu.Text;
            duzenlenenUrun.Fiyati = txtFiyati.Text;
            duzenlenenUrun.Aciklama = txtAciklama.Text;
            if (pictureBoxResim.Image != null)
            {
                // Eğer PictureBox'ta resim varsa, resmi geçici bir dosyaya kaydet ve yolunu kayıt edilen ürüne ata
                string tempFilePath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), $"{Guid.NewGuid()}.png");
                pictureBoxResim.Image.Save(tempFilePath, System.Drawing.Imaging.ImageFormat.Png);
                duzenlenenUrun.ResimDosyaYolu = tempFilePath;
            }
            else
            {
                // Eğer PictureBox'ta resim yoksa, resim dosya yolunu boşalt
                duzenlenenUrun.ResimDosyaYolu = "";
            }
            DialogResult = DialogResult.OK;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        
    }
}
