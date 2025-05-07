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
    public partial class ekle : Form
    {
        public ekle()
        {
            InitializeComponent();
        }

        private void pnl_ekle_Click(object sender, EventArgs e)
        {
            if (txt_ad.Text != "" && txt_tur.Text != "" && txt_sayi.Text != "" && txt_fiyat.Text != "")
            {
                // Yeni ürün oluştur
                string yeniUrun = $"Ürün Adı: {txt_ad.Text} - Ürün Türü: {txt_tur.Text} - Ürün Sayısı : {txt_sayi.Text} - Ürün Fiyatı : {txt_fiyat.Text}TL";

                // Ürünü merkezi listeye ekle
                veri.urunListesi.Add(yeniUrun);

                // anasayfa'ya dön
                anasayfa anaForm = new anasayfa();
                anaForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pnl_geri_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
