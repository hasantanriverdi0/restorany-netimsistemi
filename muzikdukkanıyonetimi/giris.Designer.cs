namespace muzikdukkanıyonetimi
{
    partial class giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.pnl_giris = new System.Windows.Forms.Panel();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.chc = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // pnl_giris
            // 
            this.pnl_giris.BackColor = System.Drawing.Color.Transparent;
            this.pnl_giris.Location = new System.Drawing.Point(61, 445);
            this.pnl_giris.Name = "pnl_giris";
            this.pnl_giris.Size = new System.Drawing.Size(434, 52);
            this.pnl_giris.TabIndex = 0;
            this.pnl_giris.Click += new System.EventHandler(this.pnl_giris_Click);
            // 
            // txt_ad
            // 
            this.txt_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.Location = new System.Drawing.Point(89, 220);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(216, 26);
            this.txt_ad.TabIndex = 1;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.Location = new System.Drawing.Point(89, 301);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(216, 26);
            this.txt_sifre.TabIndex = 2;
            // 
            // chc
            // 
            this.chc.AutoSize = true;
            this.chc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chc.Location = new System.Drawing.Point(89, 327);
            this.chc.Name = "chc";
            this.chc.Size = new System.Drawing.Size(86, 17);
            this.chc.TabIndex = 3;
            this.chc.Text = "Şifreyi Göster";
            this.chc.UseVisualStyleBackColor = true;
            this.chc.CheckedChanged += new System.EventHandler(this.chc_CheckedChanged);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 532);
            this.Controls.Add(this.chc);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.pnl_giris);
            this.Name = "giris";
            this.Text = "Restoran Yönetim Sistemi";
            this.Load += new System.EventHandler(this.giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_giris;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.CheckBox chc;
    }
}

