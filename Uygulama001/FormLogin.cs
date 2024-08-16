using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama001
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Form1_KeyDown); // KeyDown olayını tanımlıyoruz
        }
        public bool GirisYapildimi;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                girisYap_Click(sender, e); // Enter tuşuna basıldığında girisYap_Click metodu çağrılır
            }
        }

        private void girisYap_Click(object sender, EventArgs e)
        {
            if (username.Text == "admin" && password.Text == "58")
            {
                GirisYapildimi = true;
                this.Hide();
                FormAnasayfa formAnasayfa = new FormAnasayfa();
                formAnasayfa.ShowDialog();
            }
            else
            {
                GirisYapildimi = false;
                MessageBox.Show("Hatalı Giriş !");
            }
        }


    }
}
