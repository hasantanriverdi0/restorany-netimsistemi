using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muzikdukkanıyonetimi
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void pnl_giris_Click(object sender, EventArgs e)
        {
            string adminAd = "admin";  // kayıtlı admin adı
            string adminSifre = "1234";  // kayıtlı admin şifresi

            if (txt_ad.Text == adminAd && txt_sifre.Text == adminSifre)
            {
                anasayfa anasayfaForm = new anasayfa();
                anasayfaForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chc_CheckedChanged(object sender, EventArgs e)
        {
            if (chc.Checked)
            {
                txt_sifre.UseSystemPasswordChar = false; // şifreyi göster
            }
            else
            {
                txt_sifre.UseSystemPasswordChar = true;  // şifreyi gizle
            }
        }

        private void giris_Load(object sender, EventArgs e)
        {
            txt_sifre.UseSystemPasswordChar = true;
        }
    }
}
