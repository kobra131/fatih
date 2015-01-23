namespace KutuphaneOtomasyonu.Views
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnKitapEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnOgrenci = new DevExpress.XtraEditors.SimpleButton();
            this.btnKitapOduncVerme = new DevExpress.XtraEditors.SimpleButton();
            this.btnOgrenciListesi = new DevExpress.XtraEditors.SimpleButton();
            this.btnKitapListesi = new DevExpress.XtraEditors.SimpleButton();
            this.btnKitapOduncListesi = new DevExpress.XtraEditors.SimpleButton();
            this.btnFakulteEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnBolumEkle = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(12, 12);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(75, 23);
            this.btnKitapEkle.TabIndex = 0;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.Location = new System.Drawing.Point(93, 12);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(75, 23);
            this.btnOgrenci.TabIndex = 1;
            this.btnOgrenci.Text = "Öğrenci Ekle";
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // btnKitapOduncVerme
            // 
            this.btnKitapOduncVerme.Location = new System.Drawing.Point(263, 12);
            this.btnKitapOduncVerme.Name = "btnKitapOduncVerme";
            this.btnKitapOduncVerme.Size = new System.Drawing.Size(104, 23);
            this.btnKitapOduncVerme.TabIndex = 2;
            this.btnKitapOduncVerme.Text = "Kitap Ödünç Verme";
            this.btnKitapOduncVerme.Click += new System.EventHandler(this.btnKitapOduncVerme_Click);
            // 
            // btnOgrenciListesi
            // 
            this.btnOgrenciListesi.Location = new System.Drawing.Point(174, 12);
            this.btnOgrenciListesi.Name = "btnOgrenciListesi";
            this.btnOgrenciListesi.Size = new System.Drawing.Size(83, 23);
            this.btnOgrenciListesi.TabIndex = 3;
            this.btnOgrenciListesi.Text = "Öğrenci Listesi";
            this.btnOgrenciListesi.Click += new System.EventHandler(this.btnOgrenciListesi_Click);
            // 
            // btnKitapListesi
            // 
            this.btnKitapListesi.Location = new System.Drawing.Point(12, 41);
            this.btnKitapListesi.Name = "btnKitapListesi";
            this.btnKitapListesi.Size = new System.Drawing.Size(75, 23);
            this.btnKitapListesi.TabIndex = 4;
            this.btnKitapListesi.Text = "Kitap Listesi";
            this.btnKitapListesi.Click += new System.EventHandler(this.btnKitapListesi_Click);
            // 
            // btnKitapOduncListesi
            // 
            this.btnKitapOduncListesi.Location = new System.Drawing.Point(93, 41);
            this.btnKitapOduncListesi.Name = "btnKitapOduncListesi";
            this.btnKitapOduncListesi.Size = new System.Drawing.Size(108, 23);
            this.btnKitapOduncListesi.TabIndex = 5;
            this.btnKitapOduncListesi.Text = "Kitap Ödünç Listesi";
            this.btnKitapOduncListesi.Click += new System.EventHandler(this.btnKitapOduncListesi_Click);
            // 
            // btnFakulteEkle
            // 
            this.btnFakulteEkle.Location = new System.Drawing.Point(207, 41);
            this.btnFakulteEkle.Name = "btnFakulteEkle";
            this.btnFakulteEkle.Size = new System.Drawing.Size(75, 23);
            this.btnFakulteEkle.TabIndex = 6;
            this.btnFakulteEkle.Text = "Fakülte Ekle";
            this.btnFakulteEkle.Click += new System.EventHandler(this.btnFakulteEkle_Click);
            // 
            // btnBolumEkle
            // 
            this.btnBolumEkle.Location = new System.Drawing.Point(288, 41);
            this.btnBolumEkle.Name = "btnBolumEkle";
            this.btnBolumEkle.Size = new System.Drawing.Size(75, 23);
            this.btnBolumEkle.TabIndex = 6;
            this.btnBolumEkle.Text = "Bölüm Ekle";
            this.btnBolumEkle.Click += new System.EventHandler(this.btnBolumEkle_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 331);
            this.Controls.Add(this.btnBolumEkle);
            this.Controls.Add(this.btnFakulteEkle);
            this.Controls.Add(this.btnKitapOduncListesi);
            this.Controls.Add(this.btnKitapListesi);
            this.Controls.Add(this.btnOgrenciListesi);
            this.Controls.Add(this.btnKitapOduncVerme);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.btnKitapEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Otomasyonu | Fatih Remzi EVRAN";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnKitapEkle;
        private DevExpress.XtraEditors.SimpleButton btnOgrenci;
        private DevExpress.XtraEditors.SimpleButton btnKitapOduncVerme;
        private DevExpress.XtraEditors.SimpleButton btnOgrenciListesi;
        private DevExpress.XtraEditors.SimpleButton btnKitapListesi;
        private DevExpress.XtraEditors.SimpleButton btnKitapOduncListesi;
        private DevExpress.XtraEditors.SimpleButton btnFakulteEkle;
        private DevExpress.XtraEditors.SimpleButton btnBolumEkle;
    }
}