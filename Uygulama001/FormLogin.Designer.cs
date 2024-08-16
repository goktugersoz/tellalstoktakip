using System.ComponentModel;

namespace Uygulama001
{
    partial class FormLogin
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


        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormLogin));
            pictureBox1 = new PictureBox();
            username = new TextBox();
            password = new TextBox();
            girisYap = new Button();
            label1 = new Label();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(281, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 194);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // username
            // 
            username.BackColor = Color.PowderBlue;
            username.Location = new Point(248, 267);
            username.Name = "username";
            username.PlaceholderText = "Kullanıcı Adınız";
            username.Size = new Size(319, 23);
            username.TabIndex = 5;
            // 
            // password
            // 
            password.BackColor = Color.PowderBlue;
            password.Location = new Point(248, 305);
            password.Name = "password";
            password.PlaceholderText = "Şifreniz";
            password.Size = new Size(319, 23);
            password.TabIndex = 6;
            password.UseSystemPasswordChar = true;
            // 
            // girisYap
            // 
            girisYap.BackColor = Color.PowderBlue;
            girisYap.Location = new Point(322, 366);
            girisYap.Name = "girisYap";
            girisYap.Size = new Size(165, 34);
            girisYap.TabIndex = 7;
            girisYap.Text = "Giriş Yap ";
            girisYap.UseVisualStyleBackColor = false;
            girisYap.Click += girisYap_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(684, 439);
            label1.Name = "label1";
            label1.Size = new Size(138, 13);
            label1.TabIndex = 1;
            label1.Text = "Gardaş Technologies , Inc\r\n";
            // 
            // FormLogin
            // 
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(834, 461);
            Controls.Add(label1);
            Controls.Add(girisYap);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MinimumSize = new Size(750, 450);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tellal Elektronik - Login";
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button girisYap;
        private TextBox password;
        private TextBox username;
        private PictureBox pictureBox1;
        private Label label1;
    }
}