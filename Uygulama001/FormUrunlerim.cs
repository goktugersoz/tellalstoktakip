using System;
using System.Collections.Generic;
using System.Drawing; // PictureBox için gerekli
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Uygulama001.FormMusteri;
using static Uygulama001.FormUrunlerim;

namespace Uygulama001
{
    public partial class FormUrunlerim : Form
    {
        private string resimDosyaYolu = "";
        private bool resimSecildi = false;
        private List<Urun> urunListesi = new List<Urun>();
        private string jsonFilePath = "urunler.json";
        private string kategoriYolu = "kategoriler.json";
        private string konumDosyaYolu = "konumlar.json"; // Konumların dosya yolu
        private List<string> konumlar = new List<string>(); // Konumları tutacak liste
        List<Urun> eslesenUrunler = new List<Urun>();



        public FormUrunlerim()
        {
            InitializeComponent();
            KonumDosyasiOlustur(); // Eğer dosya yoksa, konumlar dosyasını oluştur
            KonumlariYukle(); // Kaydedilmiş konumları yükle
            KategorileriYukle();
            LoadUrunler();
        }

        private void LoadUrunler()
        {
            textTarih.Text = dateTime.Value.ToString("dd/MM/yyyy HH:mm");
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                urunListesi = JsonConvert.DeserializeObject<List<Urun>>(json) ?? new List<Urun>();
                ShowUrunler();
            }
        }

        private void ShowUrunler()
        {
            textTarih.Text = dateTime.Value.ToString("dd/MM/yyyy HH:mm");
            listViewUrunler.Items.Clear();

            foreach (var urun in urunListesi)
            {
                ListViewItem item = new ListViewItem();
                item.Text = urun.Id.ToString(); // ID sütununa ürünün Id özelliğini ekleyin
                item.SubItems.Add(urun?.Adi);
                item.SubItems.Add(urun?.Kodu);
                item.SubItems.Add(urun?.Fiyati.ToString());
                item.SubItems.Add(urun?.Aciklama);
                item.SubItems.Add(urun?.Kategori);
                item.SubItems.Add(urun?.Konumu);
                item.SubItems.Add(urun?.Tarih);
                listViewUrunler.Items.Add(item);
            }
        }
        private void Musteriler_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUrunlerim formUrunlerim = new FormUrunlerim();
            formUrunlerim.ShowDialog();
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAnasayfa formAnasayfa = new FormAnasayfa();
            formAnasayfa.ShowDialog();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (listViewUrunler.SelectedItems.Count == 1)
            {
                int index = listViewUrunler.SelectedItems[0].Index;

                if (eslesenUrunler.Any() && index >= 0 && index < eslesenUrunler.Count)
                {
                    Urun secilenUrun = eslesenUrunler[index]; // Arama sonucu listesinden seçilen ürünü al
                    FormUrunDetay detayForm = new FormUrunDetay(secilenUrun);
                    if (detayForm.ShowDialog() == DialogResult.OK)
                    {
                        // Detay formundan gelen güncellenmiş ürün bilgisini eslesenUrunler listesine yaz
                        eslesenUrunler[index] = detayForm.DuzenlenenUrun;
                        Kaydet();
                        TemizleVeYukle();
                    }
                }
                else if (index >= 0 && index < urunListesi.Count)
                {
                    Urun secilenUrun = urunListesi[index]; // Tüm ürünler listesinden seçilen ürünü al
                    FormUrunDetay detayForm = new FormUrunDetay(secilenUrun);
                    if (detayForm.ShowDialog() == DialogResult.OK)
                    {
                        // Detay formundan gelen güncellenmiş ürün bilgisini urunListesi listesine yaz
                        urunListesi[index] = detayForm.DuzenlenenUrun;
                        Kaydet();
                        TemizleVeYukle();
                    }
                }
            }
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            // Seçili öğelerin sayısını kontrol et
            if (listViewUrunler.SelectedItems.Count > 0)
            {
                // Kullanıcıdan silme işlemini onaylamasını iste
                DialogResult result = MessageBox.Show("Seçili ürünleri silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                // Kullanıcı "Evet"i seçerse, seçili öğeleri sil
                if (result == DialogResult.Yes)
                {
                    // Seçili tüm öğeleri kaldır
                    foreach (ListViewItem item in listViewUrunler.SelectedItems)
                    {
                        int index = item.Index;
                        Urun seciliUrun = urunListesi[index];

                        // Ürünü listeden ve listView'den kaldır
                        urunListesi.RemoveAt(index);
                        item.Remove();

                        // Silinen ürünün konumunu konumlar.json dosyasına ekle
                        if (!string.IsNullOrEmpty(seciliUrun.Konumu))
                        {
                            KonumuEkle(seciliUrun.Konumu);
                        }
                    }

                    // Değişiklikleri dosyaya kaydet
                    Kaydet();

                    // Kullanıcıya bilgi ver
                    MessageBox.Show("Seçili ürünler başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // ComboBox2'yi yenile
                    comboBox2.Items.Clear();
                    KonumlariYukle();
                }
            }
            else
            {
                // Kullanıcıya bir hata mesajı göster
                MessageBox.Show("Lütfen silmek için bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnResimSec_Click1(object sender, EventArgs e)
        {
            // Seçili öğeyi al
            if (listViewUrunler.SelectedItems.Count > 0)
            {
                int index = listViewUrunler.SelectedItems[0].Index;
                Urun seciliUrun = urunListesi[index];

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        seciliUrun.ResimDosyaYolu = openFileDialog.FileName;
                        ShowResim(seciliUrun.ResimDosyaYolu);
                        Kaydet();
                    }
                }
            }
        }
        private void btnResimSec_Click_1(object sender, EventArgs e)
        {
            // Resim dosyası seçimi için bir dosya iletişim kutusu oluştur
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp|Tüm Dosyalar|*.*";
            openFileDialog.Title = "Resim Seç";

            // Kullanıcı bir resim seçerse
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Seçilen resmin dosya yolunu sakla
                resimDosyaYolu = openFileDialog.FileName;

                // Resim dosyasını hedef klasöre taşı
                string hedefKlasor = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resimler");
                string hedefDosya = Path.Combine(hedefKlasor, Path.GetFileName(resimDosyaYolu));

                // Hedef klasör yoksa oluştur
                if (!Directory.Exists(hedefKlasor))
                {
                    Directory.CreateDirectory(hedefKlasor);
                }

                // Resim dosyasını hedef klasöre taşı
                File.Copy(resimDosyaYolu, hedefDosya, true);

                // Resim dosyasının yolunu güncelle
                resimDosyaYolu = hedefDosya;

                // Seçilen resmi pictureBoxResim'de göster
                pictureBox1.ImageLocation = resimDosyaYolu;
                pictureBox1.Visible = true;
                resimSecildi = true; // Resim seçildiğini işaretle
            }
        }

        /*private void btnResimSil_Click_1(object sender, EventArgs e)
        {
            // Seçili öğeyi al
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = null;
                resimDosyaYolu = null; // Resim dosya yolunu temizle
                resimSecildi = false; // Resim seçildiğini sıfırla
            }
        }*/

        private void ShowResim(string resimDosyaYolu)
        {
            if (!string.IsNullOrEmpty(resimDosyaYolu) && File.Exists(resimDosyaYolu))
            {
                try
                {
                    pictureBoxResim.Image = Image.FromFile(resimDosyaYolu);
                    pictureBoxResim.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Resim gösterme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                pictureBoxResim.Image = null;
            }
        }

        private void Kaydet()
        {
            string json = JsonConvert.SerializeObject(urunListesi, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);
        }

        private void listViewUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewUrunler.SelectedItems.Count > 0)
            {
                int index = listViewUrunler.SelectedItems[0].Index;
                Urun seciliUrun = urunListesi[index];

                // Eğer ürünün bir resmi varsa, resmi pictureBoxResim içinde göster
                if (!string.IsNullOrEmpty(seciliUrun.ResimDosyaYolu) && File.Exists(seciliUrun.ResimDosyaYolu))
                {
                    try
                    {
                        // Resmi pictureBoxResim içinde göster
                        pictureBoxResim.Image = Image.FromFile(seciliUrun.ResimDosyaYolu);
                        pictureBoxResim.SizeMode = PictureBoxSizeMode.Zoom; // Resmi PictureBox boyutuna sığacak şekilde ayarla
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Resim gösterme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Eğer resim dosyası yoksa uyarı ver, sadece işlemi geç
                    pictureBoxResim.Image = null; // Önceki resmi temizle
                }
            }
            else
            {
                // Listedeki bir öğe seçilmediğinde, resmi temizle
                pictureBoxResim.Image = null;
            }
        }

        private void TemizleVeYukle()
        {
            textTarih.Text = dateTime.Value.ToString("dd/MM/yyyy HH:mm");
            listViewUrunler.Items.Clear(); // ListView'i temizle

            // Tüm ürünleri ListView'e ekle
            foreach (var urun in urunListesi.OrderBy(u => u.Id))
            {
                ListViewItem item = new ListViewItem(urun.Id.ToString()); // Ürün ID'sini ekliyoruz
                item.SubItems.Add(urun?.Adi);
                item.SubItems.Add(urun?.Kodu);
                item.SubItems.Add(urun?.Fiyati);
                item.SubItems.Add(urun?.Aciklama);
                item.SubItems.Add(urun?.Kategori);
                item.SubItems.Add(urun?.Konumu);
                item.SubItems.Add(urun?.Tarih); 
                listViewUrunler.Items.Add(item);
            }
        }


        private void FormUrunlerim_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Uygulama kapanırken dosyayı kaydet
            Kaydet();
        }
        private void listViewUrunler_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && listViewUrunler.SelectedItems.Count > 0)
            {
                int index = listViewUrunler.SelectedItems[0].Index;
                Urun seciliUrun = urunListesi[index];

                // Eğer ürünün bir resmi varsa, resmi pictureBoxResim içinde göster
                if (!string.IsNullOrEmpty(seciliUrun.ResimDosyaYolu) && File.Exists(seciliUrun.ResimDosyaYolu))
                {
                    try
                    {
                        // Resmi pictureBoxResim içinde göster
                        pictureBoxResim.Image = Image.FromFile(seciliUrun.ResimDosyaYolu);
                        pictureBoxResim.SizeMode = PictureBoxSizeMode.Zoom; // Resmi PictureBox boyutuna sığacak şekilde ayarla
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Resim gösterme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Eğer resim dosyası yoksa uyarı ver, sadece işlemi geç
                    pictureBoxResim.Image = null; // Önceki resmi temizle
                }
            }
        }


        private void listViewUrunler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewUrunler.SelectedItems.Count == 1)
            {
                int index = listViewUrunler.SelectedItems[0].Index;

                if (eslesenUrunler.Any() && index >= 0 && index < eslesenUrunler.Count)
                {
                    Urun secilenUrun = eslesenUrunler[index]; // Arama sonucu listesinden seçilen ürünü al
                    FormUrunDetay detayForm = new FormUrunDetay(secilenUrun);
                    if (detayForm.ShowDialog() == DialogResult.OK)
                    {
                        // Detay formundan gelen güncellenmiş ürün bilgisini eslesenUrunler listesine yaz
                        eslesenUrunler[index] = detayForm.DuzenlenenUrun;
                        Kaydet();
                        TemizleVeYukle();
                    }
                }
                else if (index >= 0 && index < urunListesi.Count)
                {
                    Urun secilenUrun = urunListesi[index]; // Tüm ürünler listesinden seçilen ürünü al
                    FormUrunDetay detayForm = new FormUrunDetay(secilenUrun);
                    if (detayForm.ShowDialog() == DialogResult.OK)
                    {
                        // Detay formundan gelen güncellenmiş ürün bilgisini urunListesi listesine yaz
                        urunListesi[index] = detayForm.DuzenlenenUrun;
                        Kaydet();
                        TemizleVeYukle();
                    }
                }
            }
        }



        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            string aramaMetni = txtArama.Text.ToLower(); // Arama metnini küçük harfe dönüştür

            // ListView'deki öğeleri temizle
            listViewUrunler.Items.Clear();

            // Orijinal listeyi tarayarak arama sonucunu bul
            eslesenUrunler.Clear(); // eslesenUrunler listesini temizle
            foreach (var urun in urunListesi)
            {
                if (urun != null && (
                    (urun.Adi?.ToLower().Contains(aramaMetni) ?? false)
                    || (urun.Kodu?.ToLower().Contains(aramaMetni) ?? false)
                    || (urun.Fiyati?.ToLower().Contains(aramaMetni) ?? false)
                    || (urun.Kategori?.ToLower().Contains(aramaMetni) ?? false)
                    || (urun.Tarih?.ToLower().Contains(aramaMetni) ?? false)
                    || (urun.Aciklama?.ToLower().Contains(aramaMetni) ?? false)))
                {
                    eslesenUrunler.Add(urun);
                }
            }

            // Arama sonucunu ListView'e ekle
            // Ürünleri listeye ekleme işlemi
            foreach (var urun in eslesenUrunler)
            {
                ListViewItem item = new ListViewItem();
                item.Text = urun.Id.ToString(); // ID sütununa ürünün Id özelliğini ekleyin
                item.SubItems.Add(urun?.Adi);
                item.SubItems.Add(urun?.Kodu);
                item.SubItems.Add(urun?.Fiyati.ToString());
                item.SubItems.Add(urun?.Aciklama);
                item.SubItems.Add(urun?.Kategori);
                item.SubItems.Add(urun?.Konumu);
                item.SubItems.Add(urun?.Tarih);
                listViewUrunler.Items.Add(item);
            }
        }


        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            // ComboBox'a elle bir kategori yazıldığında bu metod tetiklenecek
            string yeniKategori = comboBox1.Text.Trim();

            // Eğer kategori zaten mevcutsa ve elle yazılmışsa, uyarı ver
            if (comboBox1.Items.Cast<string>().Any(item => item.Equals(yeniKategori, StringComparison.OrdinalIgnoreCase)) &&
                comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Bu kategori zaten mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Kategori seçimini buradan kaldırıyoruz

            // Ürün adı ve kodu boş ise uyarı ver
            if (string.IsNullOrWhiteSpace(txtAdi.Text) || string.IsNullOrWhiteSpace(txtKodu.Text))
            {
                MessageBox.Show("Ürün adı ve kodu alanlarını doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Yeni bir ürün oluştur
            Urun yeniUrun = new Urun();

            // Id değerini belirle
            yeniUrun.Id = urunListesi.Count > 0 ? urunListesi.Max(u => u.Id) + 1 : 1;

            // Yeni ürünün bilgilerini TextBox'lardan al
            yeniUrun.Adi = txtAdi.Text;
            yeniUrun.Kodu = txtKodu.Text;
            yeniUrun.Fiyati = txtFiyati.Text;
            yeniUrun.Aciklama = txtAciklama.Text;
            yeniUrun.Tarih = textTarih.Text;

            // Seçilen konumu yeni ürünün konumu olarak ata
            if (comboBox2.SelectedItem != null)
            {
                yeniUrun.Konumu = comboBox2.SelectedItem.ToString();
            }

            // Kategori bilgisini comboBox1'den alın veya yeni kategori oluştur
            string yeniKategori = comboBox1.Text.Trim();

            // Kategori ismi boş mu veya null karakter içeriyor mu kontrolü
            if (string.IsNullOrWhiteSpace(yeniKategori))
            {
                MessageBox.Show("Geçerli bir kategori ismi giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kategorilerde daha önce eklenip eklenmediğini kontrol et
            if (!comboBox1.Items.Cast<string>().Any(item => item.Equals(yeniKategori, StringComparison.OrdinalIgnoreCase)))
            {
                // Yeni kategori daha önce eklenmemişse, comboBox'a ekleyin
                KategoriEkle(yeniKategori);
            }
            else if (comboBox1.SelectedIndex == -1) // Sadece elle yazılmışsa uyarı ver
            {
                MessageBox.Show("Bu kategori zaten mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                KategoriEkle(yeniKategori);

            }

            yeniUrun.Kategori = yeniKategori;

            // Seçilen resmin dosya yolunu yeni ürünün resim dosya yoluna ekle
            yeniUrun.ResimDosyaYolu = resimDosyaYolu;

            // Yeni ürünü listeye ekle
            urunListesi.Add(yeniUrun);

            // ListView'e yeni ürünü ekle
            ListViewItem item = new ListViewItem(yeniUrun.Id.ToString()); // Ürün ID'sini ekliyoruz
            item.SubItems.Add(yeniUrun.Adi);
            item.SubItems.Add(yeniUrun.Kodu);
            item.SubItems.Add(yeniUrun.Fiyati);
            item.SubItems.Add(yeniUrun.Aciklama);
            item.SubItems.Add(yeniUrun.Kategori);
            item.SubItems.Add(yeniUrun.Konumu);
            item.SubItems.Add(yeniUrun.Tarih);

            listViewUrunler.Items.Add(item);

            // Değişiklikleri dosyaya kaydet
            Kaydet();
            if (comboBox2.SelectedItem != null)
            {
                yeniUrun.Konumu = comboBox2.SelectedItem.ToString();

                // Seçilen konumu dosyadan sil
                KonumuSil(yeniUrun.Konumu);
            }
            // Kullanıcıya bilgi ver
            MessageBox.Show("Yeni ürün başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // TextBox'ları temizle
            txtAdi.Clear();
            txtKodu.Clear();
            txtFiyati.Clear();
            txtAciklama.Clear();

            // Resim seçildiğini sıfırla
            resimDosyaYolu = "";
            resimSecildi = false;

            // Eğer bir sonraki resim seçilene kadar picturebox1 görünmez olacak
            pictureBox1.Visible = false;
        }
        // Kategoriyi listeye ekleyen fonksiyon
        private void KategoriEkle(string kategori)
        {
            // Kategorilerin dosyada tutulduğu dosya yolu
            string dosyaYolu = "kategoriler.json";

            // Kategorileri dosyadan oku
            List<string> mevcutKategoriler = DosyadanKategorileriOku();

            // Eğer kategori zaten mevcutsa, eklemeyi engelle
            if (mevcutKategoriler.Contains(kategori))
            {
                MessageBox.Show("Bu kategori zaten mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Yeni kategoriyi listeye ekle
            mevcutKategoriler.Add(kategori);

            // Kategorileri dosyaya yaz
            KategorileriDosyayaYaz(mevcutKategoriler);

            // ComboBox'a yeni kategoriyi ekle
            comboBox1.Items.Add(kategori);

            // Kullanıcıya bilgi ver
            MessageBox.Show("Yeni kategori eklendi: " + kategori, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        // Kategorileri dosyadan okuyan fonksiyon
        // Kategorileri dosyadan okuyan fonksiyon
        private List<string> DosyadanKategorileriOku()
        {
            List<string> kategoriler = new List<string>();

            // Kategorilerin dosyada tutulduğu dosya yolu
            string dosyaYolu = "kategoriler.json";

            // Dosya varsa oku
            if (File.Exists(dosyaYolu))
            {
                // Dosyadaki JSON dizgesini oku
                string json = File.ReadAllText(dosyaYolu);

                // JSON dizgesini listeye dönüştür
                kategoriler = JsonConvert.DeserializeObject<List<string>>(json);
            }

            return kategoriler;
        }


        // Kategorileri dosyaya yazan fonksiyon

        private void KategorileriDosyayaYaz(List<string> kategoriler)
        {
            // Kategorilerin dosyada tutulduğu dosya yolu
            string dosyaYolu = "kategoriler.json";

            // Kategorileri JSON dizgesine dönüştür
            string json = JsonConvert.SerializeObject(kategoriler);

            // JSON dizgesini dosyaya yaz
            File.WriteAllText(dosyaYolu, json);
        }




        private void btnIptal_Click(object sender, EventArgs e)
        {
            // Resim pictureBox kontrolünde görüntüleniyorsa, resmi kaldır
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = null;
                resimDosyaYolu = ""; // Resim dosya yolunu temizle
                resimSecildi = false; // Resim seçildiğini sıfırla
            }

            // Diğer metin kutularını temizle
            txtAdi.Clear();
            txtKodu.Clear();
            txtFiyati.Clear();
            txtAciklama.Clear();


            // Kullanıcıya bilgi ver
            MessageBox.Show("Doldurduğunuz veriler temizlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnTopluSil_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan silme işlemini onaylamasını iste
            DialogResult result = MessageBox.Show("Seçili ürünleri silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Kullanıcı "Evet"i seçerse, seçili öğeleri sil
            if (result == DialogResult.Yes)
            {
                // Seçili tüm öğeleri kaldır
                foreach (ListViewItem item in listViewUrunler.SelectedItems)
                {
                    int index = item.Index;
                    urunListesi.RemoveAt(index);
                    item.Remove();
                }

                // Değişiklikleri dosyaya kaydet
                Kaydet();

                // Kullanıcıya bilgi ver
                MessageBox.Show("Seçili ürünler başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Kullanıcıya bir hata mesajı göster
                MessageBox.Show("Ürünler silinmedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void btnResimSec_Click(object sender, EventArgs e)
        {
            // Resim dosyası seçimi için bir dosya iletişim kutusu oluştur
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp|Tüm Dosyalar|*.*";
            openFileDialog.Title = "Resim Seç";

            // Kullanıcı bir resim seçerse
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                resimDosyaYolu = openFileDialog.FileName; // Seçilen resmin dosya yolunu sakla
                pictureBox1.ImageLocation = resimDosyaYolu; // Seçilen resmi pictureBoxResim'de göster
                pictureBox1.Visible = true;
                resimSecildi = true; // Resim seçildiğini işaretle
            }

        }
        private void btnResimSil_Click(object sender, EventArgs e)
        {
            // pictureBoxResim kontrolündeki resmi sıfırla
            pictureBoxResim.Image = null;

            // Resim dosya yolunu temizle
            resimDosyaYolu = null;

            // Resim seçildiğini false olarak işaretle
            resimSecildi = false;
        }
        private void KonumDosyasiOlustur()
        {
            // Eğer dosya yoksa, yeni bir dosya oluştur ve içine kombinasyonları satır satır yaz
            if (!File.Exists(konumDosyaYolu))
            {
                using (StreamWriter sw = new StreamWriter(konumDosyaYolu))
                {
                    for (char harf = 'A'; harf <= 'Z'; harf++)
                    {
                        for (int sayi = 0; sayi < 10; sayi++)
                        {
                            sw.WriteLine($"{harf}{sayi}"); // Her kombinasyonu yeni bir satırda yaz
                        }
                    }
                }
            }
        }
        private void KonumlariYukle()
        {
            // Dosyadaki konumları oku ve listeye ekle
            using (StreamReader sr = new StreamReader(konumDosyaYolu))
            {
                string satir;
                while ((satir = sr.ReadLine()) != null)
                {
                    konumlar.Add(satir); // Satırları doğrudan listeye ekle
                }
            }

            // Konumları ComboBox'a ekle
            comboBox2.Items.AddRange(konumlar.ToArray());
        }
        private void KaydetKonumlar()
        {
            string json = JsonConvert.SerializeObject(konumlar);
            File.WriteAllText(konumDosyaYolu, json);
        }
        private void KonumuSil(string konum)
        {
            string dosyaYolu = "konumlar.json";

            // Dosya var mı kontrol et
            if (File.Exists(dosyaYolu))
            {
                // Dosyanın tüm satırlarını oku
                string[] satirlar = File.ReadAllLines(dosyaYolu);

                // Yeni bir liste oluştur
                List<string> guncelSatirlar = new List<string>();

                // Her satırı kontrol et
                foreach (string satir in satirlar)
                {
                    // Seçilen konumu içermeyen satırları yeni listeye ekle
                    if (!satir.Equals(konum))
                    {
                        guncelSatirlar.Add(satir);
                    }
                }

                // Dosyayı güncel satırlarla yeniden yaz
                File.WriteAllLines(dosyaYolu, guncelSatirlar);
            }
        }

        private void KonumuEkle(string konum)
        {
            // Konumları tutan dosyanın yolunu tanımla
            string konumDosyaYolu = "konumlar.json";

            // Eğer dosya mevcut değilse oluştur
            if (!File.Exists(konumDosyaYolu))
            {
                File.Create(konumDosyaYolu).Close();
            }

            // Konumları dosyadan oku
            List<string> konumlar = File.ReadAllLines(konumDosyaYolu).ToList();

            // Eklemek istediğimiz konumu dosyaya ekle
            konumlar.Add(konum);

            // Dosyaya konumları yaz
            File.WriteAllLines(konumDosyaYolu, konumlar);
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ComboBox'ta bir konum seçildiğinde, seçilen konumu dosyadan sil
            string secilenKonum = comboBox2.SelectedItem.ToString();
            KonumuSil(secilenKonum);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ComboBox'tan seçilen kategoriyi alın
            string secilenKategori = comboBox1.SelectedItem.ToString();

            // Seçilen kategoriyi kullanarak yeni bir Urun nesnesi oluşturun
            Urun yeniUrun = new Urun();
            yeniUrun.Kategori = secilenKategori;

            // Diğer ürün özelliklerini de istediğiniz gibi doldurabilirsiniz
        }
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            // Eğer tıklanan bölge PictureBox'ın içinde değilse ve ürüne tıklanmamışsa resmi temizle
            if (!pictureBoxResim.Bounds.Contains(e.Location) && listViewUrunler.SelectedItems.Count == 0)
            {
                pictureBoxResim.Image = null; // Resmi temizle
            }
        }
        private void KategorileriYukle()
        {
            if (File.Exists("kategoriler.json"))
            {
                // Dosya varsa kategorileri oku
                string json = File.ReadAllText("kategoriler.json");
                List<string> kategoriler = JsonConvert.DeserializeObject<List<string>>(json) ?? new List<string>();

                // ComboBox'a kategorileri ekle
                comboBox1.Items.AddRange(kategoriler.ToArray());
            }
        }



        public class Urun
        {
            public int? Id { get; set; }
            public string? Kategori { get; set; }
            public string? Adi { get; set; }
            public string? Kodu { get; set; }
            public string? Fiyati { get; set; }
            public string? Aciklama { get; set; }
            public string? ResimDosyaYolu { get; set; }
            public string? Konumu { get; set; }
            public string? Tarih {  get; set; }


            public override string ToString()
            {
                return $"{Id} - {Adi} - {Kodu} - {Fiyati} TL - {Aciklama} - {Konumu} - {Tarih}";
            }
        }

    }

}

