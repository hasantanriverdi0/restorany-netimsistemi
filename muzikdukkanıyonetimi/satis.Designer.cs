namespace muzikdukkanıyonetimi
{
    partial class satis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(satis));
            this.pnl_geri = new System.Windows.Forms.Panel();
            this.pnl_sat = new System.Windows.Forms.Panel();
            this.urun_list2 = new System.Windows.Forms.ListBox();
            this.txt_musteriad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pnl_geri
            // 
            this.pnl_geri.BackColor = System.Drawing.Color.Transparent;
            this.pnl_geri.Location = new System.Drawing.Point(305, 447);
            this.pnl_geri.Name = "pnl_geri";
            this.pnl_geri.Size = new System.Drawing.Size(191, 52);
            this.pnl_geri.TabIndex = 9;
            this.pnl_geri.Click += new System.EventHandler(this.pnl_geri_Click);
            // 
            // pnl_sat
            // 
            this.pnl_sat.BackColor = System.Drawing.Color.Transparent;
            this.pnl_sat.Location = new System.Drawing.Point(62, 447);
            this.pnl_sat.Name = "pnl_sat";
            this.pnl_sat.Size = new System.Drawing.Size(189, 52);
            this.pnl_sat.TabIndex = 8;
            this.pnl_sat.Click += new System.EventHandler(this.pnl_sat_Click);
            // 
            // urun_list2
            // 
            this.urun_list2.FormattingEnabled = true;
            this.urun_list2.Location = new System.Drawing.Point(82, 201);
            this.urun_list2.Name = "urun_list2";
            this.urun_list2.Size = new System.Drawing.Size(370, 121);
            this.urun_list2.TabIndex = 10;
            // 
            // txt_musteriad
            // 
            this.txt_musteriad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_musteriad.Location = new System.Drawing.Point(82, 363);
            this.txt_musteriad.Name = "txt_musteriad";
            this.txt_musteriad.Size = new System.Drawing.Size(370, 26);
            this.txt_musteriad.TabIndex = 11;
            // 
            // satis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 532);
            this.Controls.Add(this.txt_musteriad);
            this.Controls.Add(this.urun_list2);
            this.Controls.Add(this.pnl_geri);
            this.Controls.Add(this.pnl_sat);
            this.Name = "satis";
            this.Text = "Restoran Yönetim Sistemi";
            this.Load += new System.EventHandler(this.satis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_geri;
        private System.Windows.Forms.Panel pnl_sat;
        private System.Windows.Forms.ListBox urun_list2;
        private System.Windows.Forms.TextBox txt_musteriad;
    }
}