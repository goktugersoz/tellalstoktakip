using Newtonsoft.Json.Linq;

namespace Uygulama001
{
    partial class FormMusteri
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMusteri));
            listViewMusteriler = new ListView();
            columnHeaderId = new ColumnHeader();
            columnHeaderAd = new ColumnHeader();
            columnHeaderTelefon = new ColumnHeader();
            columnHeaderTarih = new ColumnHeader();
            columnHeaderislem = new ColumnHeader();
            columnHeaderUcret = new ColumnHeader();
            columnHeaderBorc = new ColumnHeader();
            columnHeaderAciklama = new ColumnHeader();
            btnMusteriEkle = new Button();
            btnMusteriSil = new Button();
            btnGeri = new Button();
            txtArama = new TextBox();
            textAd = new TextBox();
            textAciklama = new TextBox();
            textislem = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            textTelefon = new MaskedTextBox();
            label1 = new Label();
            dateTime = new DateTimePicker();
            textTarih = new TextBox();
            btnMusteriDuzenle = new Button();
            btnKaydet = new Button();
            textUcret = new TextBox();
            textBorc = new TextBox();
            labelBorc = new Label();
            menuStrip1 = new MenuStrip();
            denemeToolStripMenuItem = new ToolStripMenuItem();
            müşterilerToolStripMenuItem = new ToolStripMenuItem();
            ürünlerToolStripMenuItem = new ToolStripMenuItem();
            stokToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listViewMusteriler
            // 
            listViewMusteriler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewMusteriler.BackColor = Color.FromArgb(197, 255, 252);
            listViewMusteriler.Columns.AddRange(new ColumnHeader[] { columnHeaderId, columnHeaderAd, columnHeaderTelefon, columnHeaderTarih, columnHeaderislem, columnHeaderUcret, columnHeaderBorc, columnHeaderAciklama });
            listViewMusteriler.FullRowSelect = true;
            listViewMusteriler.Location = new Point(313, 74);
            listViewMusteriler.Name = "listViewMusteriler";
            listViewMusteriler.Size = new Size(939, 485);
            listViewMusteriler.TabIndex = 22;
            listViewMusteriler.UseCompatibleStateImageBehavior = false;
            listViewMusteriler.View = View.Details;
            listViewMusteriler.SelectedIndexChanged += listViewMusteriler_SelectedIndexChanged;
            listViewMusteriler.KeyDown += listViewMusteriler_KeyDown;
            listViewMusteriler.MouseDoubleClick += listViewMusteriler_MouseDoubleClick;
            // 
            // columnHeaderId
            // 
            columnHeaderId.Text = "ID";
            columnHeaderId.Width = 35;
            // 
            // columnHeaderAd
            // 
            columnHeaderAd.Text = "Ad Soyad";
            columnHeaderAd.Width = 130;
            // 
            // columnHeaderTelefon
            // 
            columnHeaderTelefon.Text = "Telefon";
            columnHeaderTelefon.Width = 100;
            // 
            // columnHeaderTarih
            // 
            columnHeaderTarih.Text = "Tarih";
            columnHeaderTarih.Width = 110;
            // 
            // columnHeaderislem
            // 
            columnHeaderislem.Text = "İslem";
            columnHeaderislem.Width = 130;
            // 
            // columnHeaderUcret
            // 
            columnHeaderUcret.Text = "Ücret";
            columnHeaderUcret.Width = 75;
            // 
            // columnHeaderBorc
            // 
            columnHeaderBorc.Text = "Borç";
            columnHeaderBorc.Width = 75;
            // 
            // columnHeaderAciklama
            // 
            columnHeaderAciklama.Text = "Açıklama";
            columnHeaderAciklama.Width = 450;
            // 
            // btnMusteriEkle
            // 
            btnMusteriEkle.Anchor = AnchorStyles.Bottom;
            btnMusteriEkle.BackColor = Color.FromArgb(111, 204, 221);
            btnMusteriEkle.Cursor = Cursors.Hand;
            btnMusteriEkle.FlatAppearance.BorderSize = 2;
            btnMusteriEkle.FlatStyle = FlatStyle.Popup;
            btnMusteriEkle.Font = new Font("Georgia", 15F, FontStyle.Bold);
            btnMusteriEkle.ForeColor = Color.FromArgb(9, 32, 52);
            btnMusteriEkle.Location = new Point(420, 565);
            btnMusteriEkle.Name = "btnMusteriEkle";
            btnMusteriEkle.Size = new Size(158, 34);
            btnMusteriEkle.TabIndex = 10;
            btnMusteriEkle.Text = "Müşteri Ekle";
            btnMusteriEkle.UseVisualStyleBackColor = false;
            btnMusteriEkle.Click += btnMusteriEkle_Click;
            // 
            // btnMusteriSil
            // 
            btnMusteriSil.Anchor = AnchorStyles.Bottom;
            btnMusteriSil.AutoSize = true;
            btnMusteriSil.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMusteriSil.BackColor = Color.FromArgb(111, 204, 221);
            btnMusteriSil.Cursor = Cursors.Hand;
            btnMusteriSil.FlatAppearance.BorderSize = 2;
            btnMusteriSil.FlatStyle = FlatStyle.Popup;
            btnMusteriSil.Font = new Font("Georgia", 15F, FontStyle.Bold);
            btnMusteriSil.ForeColor = Color.FromArgb(9, 32, 52);
            btnMusteriSil.Location = new Point(828, 565);
            btnMusteriSil.Name = "btnMusteriSil";
            btnMusteriSil.Size = new Size(132, 34);
            btnMusteriSil.TabIndex = 12;
            btnMusteriSil.Text = "Müşteri Sil";
            btnMusteriSil.UseVisualStyleBackColor = false;
            btnMusteriSil.Click += btnMusteriSil_Click;
            // 
            // btnGeri
            // 
            btnGeri.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGeri.BackColor = Color.FromArgb(111, 204, 221);
            btnGeri.Cursor = Cursors.Hand;
            btnGeri.FlatAppearance.BorderSize = 2;
            btnGeri.FlatStyle = FlatStyle.Popup;
            btnGeri.Font = new Font("Georgia", 15F, FontStyle.Bold);
            btnGeri.ForeColor = Color.FromArgb(9, 32, 52);
            btnGeri.Location = new Point(1148, 21);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(104, 34);
            btnGeri.TabIndex = 21;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // txtArama
            // 
            txtArama.BackColor = Color.FromArgb(111, 204, 221);
            txtArama.BorderStyle = BorderStyle.FixedSingle;
            txtArama.Font = new Font("Segoe UI", 13.8F);
            txtArama.Location = new Point(313, 29);
            txtArama.Name = "txtArama";
            txtArama.PlaceholderText = "Arama Yap";
            txtArama.Size = new Size(224, 32);
            txtArama.TabIndex = 20;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // textAd
            // 
            textAd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textAd.BackColor = Color.FromArgb(111, 204, 221);
            textAd.BorderStyle = BorderStyle.FixedSingle;
            textAd.Cursor = Cursors.IBeam;
            textAd.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textAd.ForeColor = SystemColors.Desktop;
            textAd.Location = new Point(102, 131);
            textAd.MaximumSize = new Size(200, 32);
            textAd.MaxLength = 40;
            textAd.MinimumSize = new Size(140, 32);
            textAd.Name = "textAd";
            textAd.PlaceholderText = " Adı Soyad";
            textAd.Size = new Size(200, 32);
            textAd.TabIndex = 1;
            textAd.TextChanged += textAd_TextChanged;
            // 
            // textAciklama
            // 
            textAciklama.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textAciklama.BackColor = Color.FromArgb(111, 204, 221);
            textAciklama.BorderStyle = BorderStyle.FixedSingle;
            textAciklama.Font = new Font("Segoe UI", 12F);
            textAciklama.Location = new Point(102, 361);
            textAciklama.Multiline = true;
            textAciklama.Name = "textAciklama";
            textAciklama.PlaceholderText = "Açıklama veya Adres";
            textAciklama.Size = new Size(200, 228);
            textAciklama.TabIndex = 7;
            textAciklama.TextChanged += textBox6_TextChanged;
            // 
            // textislem
            // 
            textislem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textislem.BackColor = Color.FromArgb(111, 204, 221);
            textislem.BorderStyle = BorderStyle.FixedSingle;
            textislem.Cursor = Cursors.IBeam;
            textislem.Font = new Font("Segoe UI", 14F);
            textislem.Location = new Point(102, 285);
            textislem.MaximumSize = new Size(200, 32);
            textislem.MinimumSize = new Size(140, 32);
            textislem.Name = "textislem";
            textislem.PlaceholderText = " İşlem";
            textislem.Size = new Size(200, 32);
            textislem.TabIndex = 5;
            textislem.TextChanged += textislem_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Franklin Gothic Medium", 12F);
            label3.Location = new Point(39, 175);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 21;
            label3.Text = "Telefon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Franklin Gothic Medium", 12F);
            label4.Location = new Point(49, 291);
            label4.Name = "label4";
            label4.Size = new Size(47, 21);
            label4.TabIndex = 24;
            label4.Text = "İşlem";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Franklin Gothic Medium", 12F);
            label5.Location = new Point(49, 213);
            label5.Name = "label5";
            label5.Size = new Size(45, 21);
            label5.TabIndex = 23;
            label5.Text = "Ücret";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Cursor = Cursors.IBeam;
            label6.Font = new Font("Franklin Gothic Medium", 12F);
            label6.Location = new Point(51, 329);
            label6.Name = "label6";
            label6.Size = new Size(45, 21);
            label6.TabIndex = 22;
            label6.Text = "Tarih";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Cursor = Cursors.IBeam;
            label7.Font = new Font("Franklin Gothic Medium", 12F);
            label7.Location = new Point(23, 361);
            label7.Name = "label7";
            label7.Size = new Size(76, 21);
            label7.TabIndex = 26;
            label7.Text = "Açıklama";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(120, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(539, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // textTelefon
            // 
            textTelefon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textTelefon.BackColor = Color.FromArgb(111, 204, 221);
            textTelefon.BorderStyle = BorderStyle.FixedSingle;
            textTelefon.Font = new Font("Segoe UI", 14F);
            textTelefon.ForeColor = SystemColors.Desktop;
            textTelefon.Location = new Point(102, 169);
            textTelefon.Mask = "(599) 000-0000";
            textTelefon.MaximumSize = new Size(200, 32);
            textTelefon.MinimumSize = new Size(140, 32);
            textTelefon.Name = "textTelefon";
            textTelefon.Size = new Size(200, 32);
            textTelefon.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Franklin Gothic Medium", 12F);
            label1.Location = new Point(21, 137);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 31;
            label1.Text = "Ad Soyad";
            // 
            // dateTime
            // 
            dateTime.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dateTime.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTime.Format = DateTimePickerFormat.Custom;
            dateTime.ImeMode = ImeMode.NoControl;
            dateTime.Location = new Point(12, 32);
            dateTime.Name = "dateTime";
            dateTime.ShowUpDown = true;
            dateTime.Size = new Size(82, 23);
            dateTime.TabIndex = 20;
            dateTime.Visible = false;
            // 
            // textTarih
            // 
            textTarih.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textTarih.BackColor = Color.FromArgb(111, 204, 221);
            textTarih.BorderStyle = BorderStyle.FixedSingle;
            textTarih.Font = new Font("Segoe UI", 12F);
            textTarih.Location = new Point(102, 323);
            textTarih.MaximumSize = new Size(200, 32);
            textTarih.MinimumSize = new Size(140, 32);
            textTarih.Multiline = true;
            textTarih.Name = "textTarih";
            textTarih.Size = new Size(200, 32);
            textTarih.TabIndex = 6;
            textTarih.Text = "27.02.2024 20:35";
            // 
            // btnMusteriDuzenle
            // 
            btnMusteriDuzenle.Anchor = AnchorStyles.Bottom;
            btnMusteriDuzenle.BackColor = Color.FromArgb(111, 204, 221);
            btnMusteriDuzenle.Cursor = Cursors.Hand;
            btnMusteriDuzenle.FlatAppearance.BorderSize = 2;
            btnMusteriDuzenle.FlatStyle = FlatStyle.Popup;
            btnMusteriDuzenle.Font = new Font("Georgia", 15F, FontStyle.Bold);
            btnMusteriDuzenle.ForeColor = Color.FromArgb(9, 32, 52);
            btnMusteriDuzenle.Location = new Point(604, 565);
            btnMusteriDuzenle.Name = "btnMusteriDuzenle";
            btnMusteriDuzenle.Size = new Size(193, 34);
            btnMusteriDuzenle.TabIndex = 11;
            btnMusteriDuzenle.Text = "Müşteri Düzenle";
            btnMusteriDuzenle.UseVisualStyleBackColor = false;
            btnMusteriDuzenle.Click += btnMusteriDuzenle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Anchor = AnchorStyles.Bottom;
            btnKaydet.BackColor = Color.FromArgb(111, 204, 221);
            btnKaydet.Cursor = Cursors.Hand;
            btnKaydet.FlatAppearance.BorderSize = 2;
            btnKaydet.FlatStyle = FlatStyle.Popup;
            btnKaydet.Font = new Font("Georgia", 15F, FontStyle.Bold);
            btnKaydet.ForeColor = Color.FromArgb(9, 32, 52);
            btnKaydet.Location = new Point(987, 565);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(158, 34);
            btnKaydet.TabIndex = 13;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // textUcret
            // 
            textUcret.BackColor = Color.FromArgb(111, 204, 221);
            textUcret.BorderStyle = BorderStyle.FixedSingle;
            textUcret.Font = new Font("Segoe UI", 14F);
            textUcret.Location = new Point(102, 207);
            textUcret.MaximumSize = new Size(200, 32);
            textUcret.MaxLength = 4;
            textUcret.Name = "textUcret";
            textUcret.PlaceholderText = "Ücreti";
            textUcret.Size = new Size(200, 32);
            textUcret.TabIndex = 3;
            // 
            // textBorc
            // 
            textBorc.BackColor = Color.FromArgb(111, 204, 221);
            textBorc.BorderStyle = BorderStyle.FixedSingle;
            textBorc.Font = new Font("Segoe UI", 14F);
            textBorc.ForeColor = SystemColors.WindowText;
            textBorc.Location = new Point(102, 247);
            textBorc.MaximumSize = new Size(200, 32);
            textBorc.MaxLength = 4;
            textBorc.Name = "textBorc";
            textBorc.PlaceholderText = "Borcu";
            textBorc.Size = new Size(200, 32);
            textBorc.TabIndex = 4;
            // 
            // labelBorc
            // 
            labelBorc.AutoSize = true;
            labelBorc.BackColor = Color.Transparent;
            labelBorc.Font = new Font("Franklin Gothic Medium", 12F);
            labelBorc.Location = new Point(49, 253);
            labelBorc.Name = "labelBorc";
            labelBorc.Size = new Size(40, 21);
            labelBorc.TabIndex = 33;
            labelBorc.Text = "Borç";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { denemeToolStripMenuItem, müşterilerToolStripMenuItem, ürünlerToolStripMenuItem, stokToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1264, 24);
            menuStrip1.TabIndex = 34;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
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
            // 
            // ürünlerToolStripMenuItem
            // 
            ürünlerToolStripMenuItem.Font = new Font("Georgia", 8.25F);
            ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            ürünlerToolStripMenuItem.Size = new Size(76, 20);
            ürünlerToolStripMenuItem.Text = "ÜRÜNLER";
            ürünlerToolStripMenuItem.Click += Urunlerim_Click;
            // 
            // stokToolStripMenuItem
            // 
            stokToolStripMenuItem.Font = new Font("Georgia", 8.25F);
            stokToolStripMenuItem.Name = "stokToolStripMenuItem";
            stokToolStripMenuItem.Size = new Size(51, 20);
            stokToolStripMenuItem.Text = "STOK";
            // 
            // FormMusteri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1264, 611);
            Controls.Add(textBorc);
            Controls.Add(labelBorc);
            Controls.Add(textUcret);
            Controls.Add(btnKaydet);
            Controls.Add(btnMusteriDuzenle);
            Controls.Add(textTarih);
            Controls.Add(dateTime);
            Controls.Add(label1);
            Controls.Add(textTelefon);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(textAciklama);
            Controls.Add(textislem);
            Controls.Add(textAd);
            Controls.Add(txtArama);
            Controls.Add(btnGeri);
            Controls.Add(btnMusteriSil);
            Controls.Add(btnMusteriEkle);
            Controls.Add(listViewMusteriler);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1280, 650);
            Name = "FormMusteri";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tellal Elektronik - Müşteriler";
            WindowState = FormWindowState.Maximized;
            Load += FormMusteri_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ListView listViewMusteriler;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderAd;
        private System.Windows.Forms.ColumnHeader columnHeaderTelefon;
        private System.Windows.Forms.ColumnHeader columnHeaderTarih;
        private System.Windows.Forms.ColumnHeader columnHeaderislem;
        private System.Windows.Forms.ColumnHeader columnHeaderUcret;
        private System.Windows.Forms.ColumnHeader columnHeaderAciklama;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnMusteriSil;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.TextBox txtArama;
        private TextBox textAd;
        private TextBox textAciklama;
        private TextBox textislem;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private MaskedTextBox textTelefon;
        private Label label1;
        private DateTimePicker dateTime;
        private TextBox textTarih;
        private Button btnMusteriDuzenle;
        private Button btnKaydet;
        private TextBox textUcret;
        private TextBox textBorc;
        private Label labelBorc;
        private ColumnHeader columnHeaderBorc;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem denemeToolStripMenuItem;
        private ToolStripMenuItem müşterilerToolStripMenuItem;
        private ToolStripMenuItem ürünlerToolStripMenuItem;
        private ToolStripMenuItem stokToolStripMenuItem;
    }
}
