
using System.Windows.Forms;

namespace Uygulama001
{
    partial class FormUrunlerim
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewUrunler;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderAdi;
        private System.Windows.Forms.ColumnHeader columnHeaderKodu;
        private System.Windows.Forms.ColumnHeader columnHeaderFiyati;
        private System.Windows.Forms.ColumnHeader columnHeaderAciklama;
        private System.Windows.Forms.ColumnHeader columnHeaderKonumu;
        private System.Windows.Forms.ColumnHeader columnHeaderKategori;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtArama;

        private PictureBox pictureBoxResim;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUrunlerim));
            listViewUrunler = new ListView();
            columnHeaderId = new ColumnHeader();
            columnHeaderAdi = new ColumnHeader();
            columnHeaderKodu = new ColumnHeader();
            columnHeaderFiyati = new ColumnHeader();
            columnHeaderAciklama = new ColumnHeader();
            columnHeaderKategori = new ColumnHeader();
            columnHeaderKonumu = new ColumnHeader();
            btnGeri = new Button();
            btnDegistir = new Button();
            btnSil = new Button();
            pictureBoxResim = new PictureBox();
            txtArama = new TextBox();
            pictureBox1 = new PictureBox();
            btnResimSec = new Button();
            btnResimSil = new Button();
            btnIptal = new Button();
            btnKaydet = new Button();
            txtAciklama = new TextBox();
            txtFiyati = new TextBox();
            txtKodu = new TextBox();
            txtAdi = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            comboBox2 = new ComboBox();
            label7 = new Label();
            dateTime = new DateTimePicker();
            textTarih = new TextBox();
            label8 = new Label();
            denemeToolStripMenuItem = new ToolStripMenuItem();
            müşterilerToolStripMenuItem = new ToolStripMenuItem();
            ürünlerToolStripMenuItem = new ToolStripMenuItem();
            stokToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listViewUrunler
            // 
            listViewUrunler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewUrunler.BackColor = SystemColors.InactiveCaption;
            listViewUrunler.BackgroundImageTiled = true;
            listViewUrunler.BorderStyle = BorderStyle.None;
            listViewUrunler.Columns.AddRange(new ColumnHeader[] { columnHeaderId, columnHeaderAdi, columnHeaderKodu, columnHeaderFiyati, columnHeaderAciklama, columnHeaderKategori, columnHeaderKonumu });
            listViewUrunler.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listViewUrunler.ForeColor = SystemColors.InactiveCaptionText;
            listViewUrunler.FullRowSelect = true;
            listViewUrunler.Location = new Point(358, 110);
            listViewUrunler.Margin = new Padding(4);
            listViewUrunler.Name = "listViewUrunler";
            listViewUrunler.Size = new Size(589, 434);
            listViewUrunler.TabIndex = 0;
            listViewUrunler.UseCompatibleStateImageBehavior = false;
            listViewUrunler.View = View.Details;
            listViewUrunler.MouseClick += listViewUrunler_MouseClick;
            listViewUrunler.MouseDoubleClick += listViewUrunler_MouseDoubleClick;
            // 
            // columnHeaderId
            // 
            columnHeaderId.Text = "ID";
            columnHeaderId.Width = 50;
            // 
            // columnHeaderAdi
            // 
            columnHeaderAdi.Text = "Adı";
            columnHeaderAdi.Width = 200;
            // 
            // columnHeaderKodu
            // 
            columnHeaderKodu.Text = "Kodu";
            columnHeaderKodu.Width = 150;
            // 
            // columnHeaderFiyati
            // 
            columnHeaderFiyati.Text = "Fiyatı";
            columnHeaderFiyati.Width = 100;
            // 
            // columnHeaderAciklama
            // 
            columnHeaderAciklama.Text = "Açıklama";
            columnHeaderAciklama.Width = 300;
            // 
            // columnHeaderKategori
            // 
            columnHeaderKategori.Text = "Kategori";
            columnHeaderKategori.Width = 100;
            // 
            // columnHeaderKonumu
            // 
            columnHeaderKonumu.Text = "Konumu";
            columnHeaderKonumu.Width = 100;
            // 
            // btnGeri
            // 
            btnGeri.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGeri.BackColor = Color.FromArgb(111, 204, 221);
            btnGeri.Font = new Font("Georgia", 15F, FontStyle.Bold);
            btnGeri.Location = new Point(1148, 27);
            btnGeri.Margin = new Padding(4);
            btnGeri.MaximumSize = new Size(100, 40);
            btnGeri.MinimumSize = new Size(100, 40);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(100, 40);
            btnGeri.TabIndex = 1;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // btnDegistir
            // 
            btnDegistir.Anchor = AnchorStyles.Bottom;
            btnDegistir.BackColor = Color.FromArgb(111, 204, 221);
            btnDegistir.Cursor = Cursors.Hand;
            btnDegistir.FlatStyle = FlatStyle.Popup;
            btnDegistir.Font = new Font("Georgia", 15F, FontStyle.Bold);
            btnDegistir.Location = new Point(649, 564);
            btnDegistir.Margin = new Padding(4);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(115, 34);
            btnDegistir.TabIndex = 2;
            btnDegistir.Text = "Değiştir";
            btnDegistir.UseVisualStyleBackColor = false;
            btnDegistir.Click += btnDegistir_Click;
            // 
            // btnSil
            // 
            btnSil.Anchor = AnchorStyles.Bottom;
            btnSil.BackColor = Color.FromArgb(111, 204, 221);
            btnSil.Cursor = Cursors.Hand;
            btnSil.FlatStyle = FlatStyle.Popup;
            btnSil.Font = new Font("Georgia", 15F, FontStyle.Bold);
            btnSil.Location = new Point(832, 564);
            btnSil.Margin = new Padding(4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(115, 34);
            btnSil.TabIndex = 3;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // pictureBoxResim
            // 
            pictureBoxResim.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxResim.BackColor = Color.Transparent;
            pictureBoxResim.Location = new Point(969, 133);
            pictureBoxResim.Margin = new Padding(4);
            pictureBoxResim.Name = "pictureBoxResim";
            pictureBoxResim.Size = new Size(282, 341);
            pictureBoxResim.TabIndex = 4;
            pictureBoxResim.TabStop = false;
            // 
            // txtArama
            // 
            txtArama.BackColor = Color.FromArgb(111, 204, 221);
            txtArama.BorderStyle = BorderStyle.FixedSingle;
            txtArama.Font = new Font("Segoe UI", 13.8F);
            txtArama.Location = new Point(358, 60);
            txtArama.Name = "txtArama";
            txtArama.PlaceholderText = "Ara...";
            txtArama.Size = new Size(169, 32);
            txtArama.TabIndex = 0;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(146, 514);
            pictureBox1.MaximumSize = new Size(190, 135);
            pictureBox1.MinimumSize = new Size(190, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // btnResimSec
            // 
            btnResimSec.BackColor = Color.FromArgb(111, 204, 221);
            btnResimSec.Font = new Font("Georgia", 8F, FontStyle.Bold);
            btnResimSec.Location = new Point(26, 538);
            btnResimSec.Name = "btnResimSec";
            btnResimSec.Size = new Size(95, 36);
            btnResimSec.TabIndex = 34;
            btnResimSec.Text = "Resim Seç";
            btnResimSec.UseVisualStyleBackColor = false;
            btnResimSec.Click += btnResimSec_Click;
            // 
            // btnResimSil
            // 
            btnResimSil.BackColor = Color.FromArgb(111, 204, 221);
            btnResimSil.Font = new Font("Georgia", 8F, FontStyle.Bold);
            btnResimSil.Location = new Point(26, 592);
            btnResimSil.Name = "btnResimSil";
            btnResimSil.Size = new Size(95, 36);
            btnResimSil.TabIndex = 33;
            btnResimSil.Text = "Resim Sil";
            btnResimSil.UseVisualStyleBackColor = false;
            // 
            // btnIptal
            // 
            btnIptal.Anchor = AnchorStyles.Bottom;
            btnIptal.BackColor = Color.FromArgb(111, 204, 221);
            btnIptal.FlatStyle = FlatStyle.Popup;
            btnIptal.Font = new Font("Georgia", 15F, FontStyle.Bold);
            btnIptal.Location = new Point(358, 563);
            btnIptal.MaximumSize = new Size(85, 35);
            btnIptal.MinimumSize = new Size(85, 35);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(85, 35);
            btnIptal.TabIndex = 32;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Anchor = AnchorStyles.Bottom;
            btnKaydet.BackColor = Color.FromArgb(111, 204, 221);
            btnKaydet.FlatStyle = FlatStyle.Popup;
            btnKaydet.Font = new Font("Georgia", 15F, FontStyle.Bold);
            btnKaydet.Location = new Point(498, 563);
            btnKaydet.MaximumSize = new Size(90, 35);
            btnKaydet.MinimumSize = new Size(90, 35);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(90, 35);
            btnKaydet.TabIndex = 31;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtAciklama
            // 
            txtAciklama.BackColor = Color.FromArgb(111, 204, 221);
            txtAciklama.Font = new Font("Segoe UI", 13.8F);
            txtAciklama.Location = new Point(144, 312);
            txtAciklama.MinimumSize = new Size(192, 188);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.PlaceholderText = "Açıklama";
            txtAciklama.Size = new Size(192, 188);
            txtAciklama.TabIndex = 30;
            // 
            // txtFiyati
            // 
            txtFiyati.BackColor = Color.FromArgb(111, 204, 221);
            txtFiyati.Font = new Font("Segoe UI", 13.8F);
            txtFiyati.Location = new Point(144, 269);
            txtFiyati.MaximumSize = new Size(190, 32);
            txtFiyati.MinimumSize = new Size(190, 32);
            txtFiyati.Name = "txtFiyati";
            txtFiyati.PlaceholderText = "Fiyatı";
            txtFiyati.Size = new Size(190, 32);
            txtFiyati.TabIndex = 29;
            // 
            // txtKodu
            // 
            txtKodu.BackColor = Color.FromArgb(111, 204, 221);
            txtKodu.Font = new Font("Segoe UI", 13.8F);
            txtKodu.Location = new Point(144, 231);
            txtKodu.MaximumSize = new Size(190, 32);
            txtKodu.MinimumSize = new Size(190, 32);
            txtKodu.Name = "txtKodu";
            txtKodu.PlaceholderText = "Kodu";
            txtKodu.Size = new Size(190, 32);
            txtKodu.TabIndex = 28;
            // 
            // txtAdi
            // 
            txtAdi.AutoCompleteCustomSource.AddRange(new string[] { "Vestel", "Phillips", "Samsung", "LG", "Sony", "Panasonic", "Philips", "Sharp", "Toshiba", "Hisense", "Grundig ", "Onvo", "Profilo", "Skytech", "Regal", "Sunny", "Dijitsu", "Arçelik", "Beko", "TCL", "Telefunken", "Altus" });
            txtAdi.AutoCompleteMode = AutoCompleteMode.Append;
            txtAdi.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtAdi.BackColor = Color.FromArgb(111, 204, 221);
            txtAdi.Font = new Font("Segoe UI", 13.8F);
            txtAdi.ForeColor = SystemColors.WindowText;
            txtAdi.Location = new Point(144, 193);
            txtAdi.MaximumSize = new Size(190, 32);
            txtAdi.MinimumSize = new Size(190, 32);
            txtAdi.Name = "txtAdi";
            txtAdi.PlaceholderText = "Marka";
            txtAdi.Size = new Size(190, 32);
            txtAdi.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Franklin Gothic Medium", 12F);
            label4.Location = new Point(41, 311);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 26;
            label4.Text = "Açıklama:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Franklin Gothic Medium", 12F);
            label3.Location = new Point(39, 275);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 25;
            label3.Text = "Fiyatı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Franklin Gothic Medium", 12F);
            label2.Location = new Point(39, 237);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 24;
            label2.Text = "Kodu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Franklin Gothic Medium", 12F);
            label1.Location = new Point(39, 199);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 23;
            label1.Text = "Marka:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(111, 204, 221);
            comboBox1.DropDownHeight = 158;
            comboBox1.Font = new Font("Segoe UI", 13.8F);
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Location = new Point(144, 111);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(192, 33);
            comboBox1.TabIndex = 36;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Franklin Gothic Medium", 12F);
            label5.Location = new Point(39, 118);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 37;
            label5.Text = "Kategoriler:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(177, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(108, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Franklin Gothic Medium", 12F);
            label6.Location = new Point(39, 156);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 40;
            label6.Text = "Konumu:";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(111, 204, 221);
            comboBox2.DropDownHeight = 158;
            comboBox2.DropDownWidth = 192;
            comboBox2.Font = new Font("Segoe UI", 13.8F);
            comboBox2.FormattingEnabled = true;
            comboBox2.IntegralHeight = false;
            comboBox2.ItemHeight = 25;
            comboBox2.Location = new Point(144, 150);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(192, 33);
            comboBox2.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Franklin Gothic Medium", 12F);
            label7.Location = new Point(358, 36);
            label7.Name = "label7";
            label7.Size = new Size(61, 21);
            label7.TabIndex = 42;
            label7.Text = "Arama:";
            // 
            // dateTime
            // 
            dateTime.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dateTime.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTime.Format = DateTimePickerFormat.Custom;
            dateTime.ImeMode = ImeMode.NoControl;
            dateTime.Location = new Point(39, 37);
            dateTime.Name = "dateTime";
            dateTime.ShowUpDown = true;
            dateTime.Size = new Size(82, 23);
            dateTime.TabIndex = 43;
            dateTime.Visible = false;
            // 
            // textTarih
            // 
            textTarih.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textTarih.BackColor = Color.FromArgb(111, 204, 221);
            textTarih.BorderStyle = BorderStyle.FixedSingle;
            textTarih.Font = new Font("Segoe UI", 12F);
            textTarih.Location = new Point(747, 60);
            textTarih.MaximumSize = new Size(200, 32);
            textTarih.MinimumSize = new Size(140, 32);
            textTarih.Multiline = true;
            textTarih.Name = "textTarih";
            textTarih.Size = new Size(200, 32);
            textTarih.TabIndex = 44;
            textTarih.Text = "27.02.2024 20:35";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Cursor = Cursors.IBeam;
            label8.Font = new Font("Franklin Gothic Medium", 12F);
            label8.Location = new Point(685, 63);
            label8.Name = "label8";
            label8.Size = new Size(45, 21);
            label8.TabIndex = 45;
            label8.Text = "Tarih";
            // 
      
           
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { denemeToolStripMenuItem, müşterilerToolStripMenuItem, ürünlerToolStripMenuItem, stokToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1264, 24);
            menuStrip1.TabIndex = 34;
            menuStrip1.Text = "menuStrip1";
            // 
            // denemeToolStripMenuItem
            // 
            denemeToolStripMenuItem.Font = new Font("Georgia", 8.25F);
            denemeToolStripMenuItem.Name = "denemeToolStripMenuItem";
            denemeToolStripMenuItem.Size = new Size(86, 20);
            denemeToolStripMenuItem.Text = "ANASAYFA";
            denemeToolStripMenuItem.Click += btnGeri_Click;
            // 
            // müşterilerToolStripMenuItem
            // 
            müşterilerToolStripMenuItem.Font = new Font("Georgia", 8.25F);
            müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            müşterilerToolStripMenuItem.Size = new Size(94, 20);
            müşterilerToolStripMenuItem.Text = "MÜŞTERİLER";
            müşterilerToolStripMenuItem.Click += Musteriler_Click;
            // 
            // ürünlerToolStripMenuItem
            // 
            ürünlerToolStripMenuItem.Font = new Font("Georgia", 8.25F);
            ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            ürünlerToolStripMenuItem.Size = new Size(76, 20);
            ürünlerToolStripMenuItem.Text = "ÜRÜNLER";
            
            // 
            // stokToolStripMenuItem
            // 
            stokToolStripMenuItem.Font = new Font("Georgia", 8.25F);
            stokToolStripMenuItem.Name = "stokToolStripMenuItem";
            stokToolStripMenuItem.Size = new Size(51, 20);
            stokToolStripMenuItem.Text = "STOK";
            // 
            // FormUrunlerim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1264, 649);
            Controls.Add(menuStrip1);
            Controls.Add(textTarih);
            Controls.Add(label8);
            Controls.Add(dateTime);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(btnResimSec);
            Controls.Add(btnResimSil);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(txtAciklama);
            Controls.Add(txtFiyati);
            Controls.Add(txtKodu);
            Controls.Add(txtAdi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtArama);
            Controls.Add(pictureBoxResim);
            Controls.Add(btnSil);
            Controls.Add(btnDegistir);
            Controls.Add(btnGeri);
            Controls.Add(listViewUrunler);
            DoubleBuffered = true;
            Margin = new Padding(4);
            MinimumSize = new Size(1280, 650);
            Name = "FormUrunlerim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürünlerim";
            WindowState = FormWindowState.Maximized;
            MouseDown += MainForm_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBoxResim).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
        private Button btnResimSec;
        private Button btnResimSil;
        private Button btnIptal;
        private Button btnKaydet;
        private TextBox txtAciklama;
        private TextBox txtFiyati;
        private TextBox txtKodu;
        private TextBox txtAdi;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Label label5;
        private PictureBox pictureBox2;
        private Label label6;
        private ComboBox comboBox2;
        private Label label7;
        private DateTimePicker dateTime;
        private TextBox textTarih;
        private Label label8;
        private ToolStripMenuItem denemeToolStripMenuItem;
        private ToolStripMenuItem müşterilerToolStripMenuItem;
        private ToolStripMenuItem ürünlerToolStripMenuItem;
        private ToolStripMenuItem stokToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
    }
}
