using System;
using System.Windows.Forms;

namespace Uygulama001
{
    public partial class FormAnasayfa : Form
    {

        public FormAnasayfa()
        {
            InitializeComponent();
        }

        private void b_urunlerim_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUrunlerim form_urunlerim = new FormUrunlerim();
            form_urunlerim.ShowDialog();
        }



        private void b_musteriler_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMusteri form_musteri = new FormMusteri();
            form_musteri.ShowDialog();
        }

        private void login(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

    }
}
