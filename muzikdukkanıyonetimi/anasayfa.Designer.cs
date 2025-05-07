namespace muzikdukkanıyonetimi
{
    partial class anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.pnl_ekle = new System.Windows.Forms.Panel();
            this.pnl_sil = new System.Windows.Forms.Panel();
            this.pnl_satis = new System.Windows.Forms.Panel();
            this.pnl_cikis = new System.Windows.Forms.Panel();
            this.urun_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // pnl_ekle
            // 
            this.pnl_ekle.BackColor = System.Drawing.Color.Transparent;
            this.pnl_ekle.Location = new System.Drawing.Point(63, 445);
            this.pnl_ekle.Name = "pnl_ekle";
            this.pnl_ekle.Size = new System.Drawing.Size(90, 52);
            this.pnl_ekle.TabIndex = 0;
            this.pnl_ekle.Click += new System.EventHandler(this.pnl_ekle_Click);
            // 
            // pnl_sil
            // 
            this.pnl_sil.BackColor = System.Drawing.Color.Transparent;
            this.pnl_sil.Location = new System.Drawing.Point(173, 447);
            this.pnl_sil.Name = "pnl_sil";
            this.pnl_sil.Size = new System.Drawing.Size(100, 52);
            this.pnl_sil.TabIndex = 1;
            this.pnl_sil.Click += new System.EventHandler(this.pnl_sil_Click);
            // 
            // pnl_satis
            // 
            this.pnl_satis.BackColor = System.Drawing.Color.Transparent;
            this.pnl_satis.Location = new System.Drawing.Point(289, 445);
            this.pnl_satis.Name = "pnl_satis";
            this.pnl_satis.Size = new System.Drawing.Size(94, 52);
            this.pnl_satis.TabIndex = 1;
            this.pnl_satis.Click += new System.EventHandler(this.pnl_satis_Click);
            // 
            // pnl_cikis
            // 
            this.pnl_cikis.BackColor = System.Drawing.Color.Transparent;
            this.pnl_cikis.Location = new System.Drawing.Point(400, 447);
            this.pnl_cikis.Name = "pnl_cikis";
            this.pnl_cikis.Size = new System.Drawing.Size(97, 52);
            this.pnl_cikis.TabIndex = 1;
            this.pnl_cikis.Click += new System.EventHandler(this.pnl_cikis_Click);
            // 
            // urun_list
            // 
            this.urun_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urun_list.FormattingEnabled = true;
            this.urun_list.HorizontalExtent = 600;
            this.urun_list.HorizontalScrollbar = true;
            this.urun_list.ItemHeight = 16;
            this.urun_list.Location = new System.Drawing.Point(65, 150);
            this.urun_list.Name = "urun_list";
            this.urun_list.Size = new System.Drawing.Size(423, 276);
            this.urun_list.TabIndex = 2;
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 532);
            this.Controls.Add(this.urun_list);
            this.Controls.Add(this.pnl_cikis);
            this.Controls.Add(this.pnl_satis);
            this.Controls.Add(this.pnl_sil);
            this.Controls.Add(this.pnl_ekle);
            this.Name = "anasayfa";
            this.Text = "Restoran Yönetim Sistemi";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ekle;
        private System.Windows.Forms.Panel pnl_sil;
        private System.Windows.Forms.Panel pnl_satis;
        private System.Windows.Forms.Panel pnl_cikis;
        private System.Windows.Forms.ListBox urun_list;
    }
}