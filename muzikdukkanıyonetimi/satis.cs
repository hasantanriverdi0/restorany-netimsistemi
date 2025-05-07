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
    public partial class satis : Form
    {
        public satis()
        {
            InitializeComponent();
        }

        private void satis_Load(object sender, EventArgs e)
        {
            urun_list2.Items.Clear();
            foreach (string urun in veri.urunListesi)
            {
                urun_list2.Items.Add(urun);
            }
        }

        private void pnl_sat_Click(object sender, EventArgs e)
        {
            if (urun_list2.SelectedIndex != -1 && txt_musteriad.Text.Trim() != "")
            {
                int seciliIndex = urun_list2.SelectedIndex;
                string seciliUrun = veri.urunListesi[seciliIndex];
                string musteriAd = txt_musteriad.Text.Trim();

                string[] bol = seciliUrun.Split(new string[] { " - " }, StringSplitOptions.None);
                string sayiKismi = bol[2]; // "Ürün Sayısı : 9"
                int mevcutSayi = int.Parse(sayiKismi.Split(':')[1].Trim());

                if (mevcutSayi > 0)
                {
                    // Onay sorusu
                    DialogResult sonuc = MessageBox.Show(
                        $"{musteriAd} adlı müşteriye 1 adet {bol[0].Replace("Ürün Adı: ", "")} satmak istediğinize emin misiniz?",
                        "Satışı Onayla",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (sonuc == DialogResult.Yes)
                    {
                        int yeniSayi = mevcutSayi - 1;
                        string guncelUrun = $"{bol[0]} - {bol[1]} - Ürün Sayısı : {yeniSayi} - {bol[3]}";

                        // Listeyi güncelle
                        veri.urunListesi[seciliIndex] = guncelUrun;

                        MessageBox.Show("Satış başarıyla gerçekleştirildi.", "Satış Onayı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Listbox'ı güncelle
                        urun_list2.Items.Clear();
                        foreach (string urun in veri.urunListesi)
                        {
                            urun_list2.Items.Add(urun);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Stokta ürün kalmamış.", "Stok Tükenmiş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen müşteri adı girin ve bir ürün seçin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pnl_geri_Click(object sender, EventArgs e)
        {
            anasayfa anaForm = new anasayfa();
            anaForm.Show();
            this.Hide();
        }
    }
}
