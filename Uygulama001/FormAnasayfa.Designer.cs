namespace Uygulama001
{
    partial class FormAnasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnasayfa));
            b_urunlerim = new Button();
            b_musteriler = new Button();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            denemeToolStripMenuItem = new ToolStripMenuItem();
            müşterilerToolStripMenuItem = new ToolStripMenuItem();
            ürünlerToolStripMenuItem = new ToolStripMenuItem();
            stokToolStripMenuItem = new ToolStripMenuItem();
            lOGİNToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // b_urunlerim
            // 
            b_urunlerim.Anchor = AnchorStyles.None;
            b_urunlerim.AutoSize = true;
            b_urunlerim.BackColor = Color.Transparent;
            b_urunlerim.BackgroundImage = (Image)resources.GetObject("b_urunlerim.BackgroundImage");
            b_urunlerim.BackgroundImageLayout = ImageLayout.Zoom;
            b_urunlerim.Cursor = Cursors.Hand;
            b_urunlerim.FlatAppearance.BorderSize = 0;
            b_urunlerim.FlatAppearance.MouseDownBackColor = Color.Transparent;
            b_urunlerim.FlatAppearance.MouseOverBackColor = Color.Transparent;
            b_urunlerim.FlatStyle = FlatStyle.Flat;
            b_urunlerim.ForeColor = Color.Transparent;
            b_urunlerim.Location = new Point(540, 434);
            b_urunlerim.Name = "b_urunlerim";
            b_urunlerim.Size = new Size(284, 114);
            b_urunlerim.TabIndex = 0;
            b_urunlerim.UseVisualStyleBackColor = false;
            b_urunlerim.Click += b_urunlerim_Click;
            // 
            // b_musteriler
            // 
            b_musteriler.Anchor = AnchorStyles.None;
            b_musteriler.AutoSize = true;
            b_musteriler.BackColor = Color.Transparent;
            b_musteriler.BackgroundImage = (Image)resources.GetObject("b_musteriler.BackgroundImage");
            b_musteriler.BackgroundImageLayout = ImageLayout.Zoom;
            b_musteriler.Cursor = Cursors.Hand;
            b_musteriler.FlatAppearance.BorderSize = 0;
            b_musteriler.FlatAppearance.MouseDownBackColor = Color.Transparent;
            b_musteriler.FlatAppearance.MouseOverBackColor = Color.Transparent;
            b_musteriler.FlatStyle = FlatStyle.Flat;
            b_musteriler.ForeColor = Color.Transparent;
            b_musteriler.Location = new Point(540, 554);
            b_musteriler.Name = "b_musteriler";
            b_musteriler.Size = new Size(284, 114);
            b_musteriler.TabIndex = 2;
            b_musteriler.UseVisualStyleBackColor = false;
            b_musteriler.Click += b_musteriler_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(488, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(388, 303);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { denemeToolStripMenuItem, müşterilerToolStripMenuItem, ürünlerToolStripMenuItem, stokToolStripMenuItem, lOGİNToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1364, 24);
            menuStrip1.TabIndex = 35;
            menuStrip1.Text = "menuStrip1";
            // 
            // denemeToolStripMenuItem
            // 
            denemeToolStripMenuItem.Font = new Font("Georgia", 8.25F);
            denemeToolStripMenuItem.Name = "denemeToolStripMenuItem";
            denemeToolStripMenuItem.Size = new Size(86, 20);
            denemeToolStripMenuItem.Text = "ANASAYFA";
            // 
            // müşterilerToolStripMenuItem
            // 
            müşterilerToolStripMenuItem.Font = new Font("Georgia", 8.25F);
            müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            müşterilerToolStripMenuItem.Size = new Size(94, 20);
            müşterilerToolStripMenuItem.Text = "MÜŞTERİLER";
            müşterilerToolStripMenuItem.Click += b_musteriler_Click;
            // 
            // ürünlerToolStripMenuItem
            // 
            ürünlerToolStripMenuItem.Font = new Font("Georgia", 8.25F);
            ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            ürünlerToolStripMenuItem.Size = new Size(76, 20);
            ürünlerToolStripMenuItem.Text = "ÜRÜNLER";
            ürünlerToolStripMenuItem.Click += b_urunlerim_Click;
            // 
            // stokToolStripMenuItem
            // 
            stokToolStripMenuItem.Font = new Font("Georgia", 8.25F);
            stokToolStripMenuItem.Name = "stokToolStripMenuItem";
            stokToolStripMenuItem.Size = new Size(51, 20);
            stokToolStripMenuItem.Text = "STOK";
            // 
            // lOGİNToolStripMenuItem
            // 
            lOGİNToolStripMenuItem.Name = "lOGİNToolStripMenuItem";
            lOGİNToolStripMenuItem.Size = new Size(54, 20);
            lOGİNToolStripMenuItem.Text = "LOGİN";
            lOGİNToolStripMenuItem.Click += login;
            // 
            // FormAnasayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1364, 711);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            Controls.Add(b_musteriler);
            Controls.Add(b_urunlerim);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1280, 750);
            Name = "FormAnasayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tellal Elektronik - Anasayfa";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button b_urunlerim;
        private Button b_musteriler;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem denemeToolStripMenuItem;
        private ToolStripMenuItem müşterilerToolStripMenuItem;
        private ToolStripMenuItem ürünlerToolStripMenuItem;
        private ToolStripMenuItem stokToolStripMenuItem;
        private ToolStripMenuItem lOGİNToolStripMenuItem;
    }
}
