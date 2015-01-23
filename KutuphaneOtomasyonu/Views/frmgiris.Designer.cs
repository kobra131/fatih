namespace KutuphaneOtomasyonu.Views
{
    partial class frmgiris
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
            this.lblHata = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKulAdi = new System.Windows.Forms.TextBox();
            this.lblaciklama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHata
            // 
            this.lblHata.BackColor = System.Drawing.Color.Transparent;
            this.lblHata.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHata.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblHata.Location = new System.Drawing.Point(163, 200);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(312, 56);
            this.lblHata.TabIndex = 6;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.loginbuton;
            this.BtnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnLogin.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnLogin.Location = new System.Drawing.Point(415, 122);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(148, 66);
            this.BtnLogin.TabIndex = 10;
            this.BtnLogin.Text = "Giriş Yap";
            this.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(163, 162);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(143, 21);
            this.txtSifre.TabIndex = 9;
            // 
            // txtKulAdi
            // 
            this.txtKulAdi.Location = new System.Drawing.Point(163, 113);
            this.txtKulAdi.Name = "txtKulAdi";
            this.txtKulAdi.Size = new System.Drawing.Size(143, 21);
            this.txtKulAdi.TabIndex = 8;
            // 
            // lblaciklama
            // 
            this.lblaciklama.AutoSize = true;
            this.lblaciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblaciklama.Location = new System.Drawing.Point(57, 26);
            this.lblaciklama.Name = "lblaciklama";
            this.lblaciklama.Size = new System.Drawing.Size(463, 25);
            this.lblaciklama.TabIndex = 7;
            this.lblaciklama.Text = "Fatih Remzi Evran Kütüphane Otomasyonu";
            // 
            // frmgiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::KutuphaneOtomasyonu.Properties.Resources.arkaplan2;
            this.ClientSize = new System.Drawing.Size(616, 313);
            this.Controls.Add(this.lblHata);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKulAdi);
            this.Controls.Add(this.lblaciklama);
            this.Name = "frmgiris";
            this.Load += new System.EventHandler(this.frmgiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHata;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKulAdi;
        private System.Windows.Forms.Label lblaciklama;
    }
}