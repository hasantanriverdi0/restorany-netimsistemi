namespace muzikdukkanıyonetimi
{
    partial class ekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ekle));
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_tur = new System.Windows.Forms.TextBox();
            this.txt_sayi = new System.Windows.Forms.TextBox();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.pnl_ekle = new System.Windows.Forms.Panel();
            this.pnl_geri = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txt_ad
            // 
            this.txt_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.Location = new System.Drawing.Point(82, 194);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(178, 26);
            this.txt_ad.TabIndex = 2;
            // 
            // txt_tur
            // 
            this.txt_tur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tur.Location = new System.Drawing.Point(81, 253);
            this.txt_tur.Name = "txt_tur";
            this.txt_tur.Size = new System.Drawing.Size(178, 26);
            this.txt_tur.TabIndex = 3;
            // 
            // txt_sayi
            // 
            this.txt_sayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sayi.Location = new System.Drawing.Point(81, 315);
            this.txt_sayi.Name = "txt_sayi";
            this.txt_sayi.Size = new System.Drawing.Size(178, 26);
            this.txt_sayi.TabIndex = 4;
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_fiyat.Location = new System.Drawing.Point(82, 379);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(178, 26);
            this.txt_fiyat.TabIndex = 5;
            // 
            // pnl_ekle
            // 
            this.pnl_ekle.BackColor = System.Drawing.Color.Transparent;
            this.pnl_ekle.Location = new System.Drawing.Point(61, 445);
            this.pnl_ekle.Name = "pnl_ekle";
            this.pnl_ekle.Size = new System.Drawing.Size(188, 52);
            this.pnl_ekle.TabIndex = 6;
            this.pnl_ekle.Click += new System.EventHandler(this.pnl_ekle_Click);
            // 
            // pnl_geri
            // 
            this.pnl_geri.BackColor = System.Drawing.Color.Transparent;
            this.pnl_geri.Location = new System.Drawing.Point(301, 445);
            this.pnl_geri.Name = "pnl_geri";
            this.pnl_geri.Size = new System.Drawing.Size(196, 52);
            this.pnl_geri.TabIndex = 7;
            this.pnl_geri.Click += new System.EventHandler(this.pnl_geri_Click);
            // 
            // ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 532);
            this.Controls.Add(this.pnl_geri);
            this.Controls.Add(this.pnl_ekle);
            this.Controls.Add(this.txt_fiyat);
            this.Controls.Add(this.txt_sayi);
            this.Controls.Add(this.txt_tur);
            this.Controls.Add(this.txt_ad);
            this.Name = "ekle";
            this.Text = "Restoran Yönetim Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_tur;
        private System.Windows.Forms.TextBox txt_sayi;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.Panel pnl_ekle;
        private System.Windows.Forms.Panel pnl_geri;
    }
}