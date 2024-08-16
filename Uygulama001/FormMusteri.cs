using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Uygulama001
{
    public partial class FormMusteri : Form
    {
        private List<Musteri> musteriListesi = new List<Musteri>();
        private List<Musteri> aramaSonucu = new List<Musteri>(); // Arama sonucu listesi
        private string jsonFilePath = "musteriler.json";

        public FormMusteri()
        {
            InitializeComponent();
            LoadMusteriler();
        }

        private void LoadMusteriler()
        {
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                musteriListesi = JsonConvert.DeserializeObject<List<Musteri>>(json) ?? new List<Musteri>();
            }
            else
            {
                musteriListesi = new List<Musteri>();
                Kaydet();
            }
            TemizleVeYukle();

        }

        private void musteriTextTemizle()
        {
            textAd.Text = "";
            textTelefon.Text = "";
            textTarih.Text = dateTime.Value.ToString("dd/MM/yyyy HH:mm");
            textislem.Text = "";
            textUcret.Text = "";
            textBorc.Text = "";
            textAciklama.Text = "";
        }

        private void TemizleVeYukle()
        {
            musteriTextTemizle();
            listViewMusteriler.Items.Clear(); // ListView'i temizle 

            // Tüm müşterileri ListView'e ekle
            foreach (var musteri in musteriListesi.OrderBy(m => m.Id))
            {
                ListViewItem item = new ListViewItem(musteri.Id.ToString()); // Müşteri ID'sini ekliyoruz
                item.SubItems.Add(musteri.Ad);
                item.SubItems.Add(musteri.Telefon);
                item.SubItems.Add(musteri.Tarih);
                item.SubItems.Add(musteri.islem);
                item.SubItems.Add(musteri.Ucret);
                item.SubItems.Add(musteri.Borc);
                item.SubItems.Add(musteri.Aciklama);

                listViewMusteriler.Items.Add(item);
            }
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            /*
            FormMusteriDetay musteriDetayForm = new FormMusteriDetay();
            if (musteriDetayForm.ShowDialog() == DialogResult.OK)
            {
                // Yeni müşteriye ID atıyoruz
                musteriDetayForm.YeniMusteri.Id = musteriListesi.Count > 0 ? musteriListesi.Max(m => m.Id) + 1 : 1;
                musteriListesi.Add(musteriDetayForm.YeniMusteri);
                Kaydet();
                TemizleVeYukle();
            }
            */



            Musteri yeniMusteriler = new Musteri();
            yeniMusteriler.Id = musteriListesi.Count > 0 ? musteriListesi.Max(m => m.Id) + 1 : 1;

            yeniMusteriler.Ad = textAd.Text;
            yeniMusteriler.Telefon = textTelefon.Text;
            yeniMusteriler.Tarih = textTarih.Text;
            yeniMusteriler.islem = textislem.Text;
            yeniMusteriler.Ucret = textUcret.Text + "  ₺";
            yeniMusteriler.Borc = textBorc.Text + "  ₺";
            yeniMusteriler.Aciklama = textAciklama.Text;

            musteriListesi.Add(yeniMusteriler);

            Kaydet();
            TemizleVeYukle();

        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            if (listViewMusteriler.SelectedItems.Count > 0)
            {
                // Seçili öğelerin sayısını al
                int selectedCount = listViewMusteriler.SelectedItems.Count;

                // Her bir seçili öğe için
                for (int i = selectedCount - 1; i >= 0; i--)
                {
                    // Öğenin indeksini al
                    int selectedIndex = listViewMusteriler.SelectedIndices[i];

                    // Öğeyi listemizden kaldır
                    musteriListesi.RemoveAt(selectedIndex);
                }

                // Değişiklikleri dosyaya kaydet
                Kaydet();

                // ListView'i güncelle
                TemizleVeYukle();
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAnasayfa formAnasayfa = new FormAnasayfa();
            formAnasayfa.ShowDialog();
        }

        private void Urunlerim_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUrunlerim formUrunlerim = new FormUrunlerim();
            formUrunlerim.ShowDialog();
        }



        private void txtArama_TextChanged(object? sender, EventArgs? e)
        {
            string arananMetin = txtArama.Text.ToLower(); // Arama metnini küçük harfe dönüştür

            // ListView'deki öğeleri temizle
            listViewMusteriler.Items.Clear();

            // Arama sonucunu tutacak bir liste oluştur
            aramaSonucu.Clear(); // Arama sonucu listesini temizle

            // Orijinal listeyi tarayarak arama sonucunu bul

            foreach (var musteri in musteriListesi)
            {
                if ((musteri.Ad?.ToLower().Contains(arananMetin) ?? false)
                    || (musteri.Aciklama?.ToLower().Contains(arananMetin) ?? false)
                    || (musteri.Telefon?.ToLower().Contains(arananMetin) ?? false)
                    || (musteri.Tarih?.ToLower().Contains(arananMetin) ?? false)
                    || (musteri.islem?.ToLower().Contains(arananMetin) ?? false)
                    || (musteri.Ucret?.ToLower().Contains(arananMetin) ?? false)
                    || (musteri.Borc?.ToLower().Contains(arananMetin) ?? false))
                {
                    aramaSonucu.Add(musteri);
                }
            }



            // Arama sonucunu ListView'e ekle
            foreach (var musteri in aramaSonucu.OrderBy(m => m.Id))
            {
                ListViewItem item = new ListViewItem(musteri.Id.ToString()); // Müşteri ID'sini ekliyoruz
                item.SubItems.Add(musteri.Ad);

                item.SubItems.Add(musteri.Telefon);
                item.SubItems.Add(musteri.Tarih);
                item.SubItems.Add(musteri.islem);
                item.SubItems.Add(musteri.Ucret);
                item.SubItems.Add(musteri.Borc);
                item.SubItems.Add(musteri.Aciklama);
                listViewMusteriler.Items.Add(item);
            }
        }

        private void Kaydet()
        {
            try
            {
                string json = JsonConvert.SerializeObject(musteriListesi, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(jsonFilePath, json);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler kaydedilirken bir hata oluştu: " + ex.Message);
            }
        }


        /*
        private void listViewMusteriler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewMusteriler.SelectedItems.Count == 1)
            {
                int index = listViewMusteriler.SelectedItems[0].Index;
                Musteri secilenMusteri = aramaSonucu[index]; // Arama sonucu listesinden seçilen müşteriyi al
                FormMusteriDetay detayForm = new FormMusteriDetay(secilenMusteri);
                if (detayForm.ShowDialog() == DialogResult.OK)
                {
                    // Detay formundan gelen güncellenmiş müşteri bilgisini aramaSonucu listesine yaz
                    aramaSonucu[index] = detayForm.YeniMusteri;
                    Kaydet();
                    TemizleVeYukle();
                }
            }
        }
        */

        private void listViewMusteriler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewMusteriler.SelectedItems.Count == 1)
            {
                int index = listViewMusteriler.SelectedItems[0].Index;
                if (index >= 0 && index < musteriListesi.Count)
                {
                    Musteri secilenMusteri = musteriListesi[index];

                    // Seçilen müşterinin bilgilerini TextBox'lara yaz
                    textAd.Text = secilenMusteri.Ad;

                    textTelefon.Text = secilenMusteri.Telefon;
                    textTarih.Text = secilenMusteri.Tarih;
                    textislem.Text = secilenMusteri.islem;
                    textUcret.Text = secilenMusteri.Ucret;
                    textBorc.Text = secilenMusteri.Borc;
                    textAciklama.Text = secilenMusteri.Aciklama;

                    // İsteğe bağlı olarak, bu noktada düzenleme yapılabilir.
                    // Örneğin, textAd.ReadOnly = true; ile Ad alanını okunabilir yapabilirsiniz.
                }
                else
                {
                    MessageBox.Show("Geçersiz endeks: " + index);
                    Kaydet();
                    TemizleVeYukle();
                }
            }
        }




        private void FormMusteri_Load(object sender, EventArgs e)
        {
            txtArama_TextChanged(null, null); // İlk yüklenme sırasında tüm müşterileri göstermek için
        }

        public class Musteri
        {
            public int Id { get; set; } // ID özelliği eklendi

            public string? Ad { get; set; }
            public string? Telefon { get; set; }
            public string? islem { get; set; }
            public string? Ucret { get; set; }
            public string? Borc { get; set; }
            public string? Tarih { get; set; }
            public string? Aciklama { get; set; }
        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textislem_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listViewMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMusteriDuzenle_Click(object sender, EventArgs e)
        {
            // Seçili öğeyi kontrol edelim
            if (listViewMusteriler.SelectedItems.Count == 1)
            {
                // Seçilen öğenin indeksini alalım
                int selectedIndex = listViewMusteriler.SelectedItems[0].Index;

                Musteri secilenMusteri = musteriListesi[selectedIndex];

                secilenMusteri.Ad = textAd.Text;
                secilenMusteri.Telefon = textTelefon.Text;
                secilenMusteri.Ucret = textUcret.Text;
                secilenMusteri.Borc = textBorc.Text;
                secilenMusteri.islem = textislem.Text;
                secilenMusteri.Tarih = textTarih.Text;
                secilenMusteri.Aciklama = textAciklama.Text;

                Kaydet();
                TemizleVeYukle();
                MessageBox.Show("Duzenleme başarılı: ");

            }
            else
            {
                MessageBox.Show("Geçersiz endeks: ");
                Kaydet();
                TemizleVeYukle();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Veriler başarıyla kaydedildi.");
            Kaydet();
            TemizleVeYukle();
        }

        private void listViewMusteriler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && listViewMusteriler.SelectedItems.Count > 0)
            {
                // Seçili öğelerin sayısını al
                int selectedCount = listViewMusteriler.SelectedIndices.Count;

                // Her bir seçili öğe için
                for (int i = selectedCount - 1; i >= 0; i--)
                {
                    // Öğenin indeksini al
                    int selectedIndex = listViewMusteriler.SelectedIndices[i];

                    // Öğeyi listemizden kaldır
                    musteriListesi.RemoveAt(selectedIndex);
                }

                // Değişiklikleri dosyaya kaydet
                Kaydet();

                // ListView'i güncelle
                TemizleVeYukle();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
