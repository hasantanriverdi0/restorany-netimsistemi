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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }
        private void anasayfa_Activated(object sender, EventArgs e)
        {
            urun_list.Items.Clear();
            foreach (string urun in veri.urunListesi)
            {
                urun_list.Items.Add(urun);
            }
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            urun_list.Items.Clear();
            foreach (string urun in veri.urunListesi)
            {
                urun_list.Items.Add(urun);
            }
        }

        private void pnl_ekle_Click(object sender, EventArgs e)
        {
            ekle ekle = new ekle();
            ekle.Show();
            this.Hide();
        }

        private void pnl_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnl_sil_Click(object sender, EventArgs e)
        {
            if (urun_list.SelectedIndex != -1)
            {
                int seciliIndex = urun_list.SelectedIndex;

                // Merkezi listeden ürünü sil
                veri.urunListesi.RemoveAt(seciliIndex);

                // ListBox'tan ürünü sil
                urun_list.Items.RemoveAt(seciliIndex);

                MessageBox.Show("Ürün başarıyla silindi.", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz ürünü seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pnl_satis_Click(object sender, EventArgs e)
        {
            satis satisForm = new satis();
            satisForm.Show();
            this.Hide();
        }
    }
}
