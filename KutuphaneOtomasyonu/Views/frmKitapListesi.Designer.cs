namespace KutuphaneOtomasyonu.Views
{
    partial class frmKitapListesi
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
            this.components = new System.ComponentModel.Container();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtYayinYili = new DevExpress.XtraEditors.TextEdit();
            this.txtKategorisi = new DevExpress.XtraEditors.TextEdit();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.txtAnahtarKelimeler = new DevExpress.XtraEditors.TextEdit();
            this.txtSayfaSayisi = new DevExpress.XtraEditors.TextEdit();
            this.txtIsbn = new DevExpress.XtraEditors.TextEdit();
            this.txtYazari = new DevExpress.XtraEditors.TextEdit();
            this.txtKitapAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sagtik_Ekle = new System.Windows.Forms.ToolStripMenuItem();
            this.sagtik_Duzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.sagtik_Sil = new System.Windows.Forms.ToolStripMenuItem();
            this.grView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_KitapId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Kategori = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_KitapKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_KitapAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_YayinYili = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Yazari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ISBN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_SayfaSayisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_AnahtarKelimeler = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYayinYili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKategorisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnahtarKelimeler.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSayfaSayisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsbn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYazari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKitapAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1;
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.grControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1250, 519);
            this.splitContainerControl1.SplitterPosition = 189;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.txtYayinYili);
            this.groupControl1.Controls.Add(this.txtKategorisi);
            this.groupControl1.Controls.Add(this.btnTemizle);
            this.groupControl1.Controls.Add(this.btnAra);
            this.groupControl1.Controls.Add(this.txtAnahtarKelimeler);
            this.groupControl1.Controls.Add(this.txtSayfaSayisi);
            this.groupControl1.Controls.Add(this.txtIsbn);
            this.groupControl1.Controls.Add(this.txtYazari);
            this.groupControl1.Controls.Add(this.txtKitapAdi);
            this.groupControl1.Controls.Add(this.txtKodu);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(189, 519);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Kitap Filtreleme";
            // 
            // txtYayinYili
            // 
            this.txtYayinYili.Location = new System.Drawing.Point(5, 180);
            this.txtYayinYili.Name = "txtYayinYili";
            this.txtYayinYili.Size = new System.Drawing.Size(179, 20);
            this.txtYayinYili.TabIndex = 10;
            // 
            // txtKategorisi
            // 
            this.txtKategorisi.Location = new System.Drawing.Point(5, 135);
            this.txtKategorisi.Name = "txtKategorisi";
            this.txtKategorisi.Size = new System.Drawing.Size(179, 20);
            this.txtKategorisi.TabIndex = 10;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(46, 383);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(127, 383);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(55, 23);
            this.btnAra.TabIndex = 9;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAnahtarKelimeler
            // 
            this.txtAnahtarKelimeler.Location = new System.Drawing.Point(3, 357);
            this.txtAnahtarKelimeler.Name = "txtAnahtarKelimeler";
            this.txtAnahtarKelimeler.Size = new System.Drawing.Size(181, 20);
            this.txtAnahtarKelimeler.TabIndex = 7;
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(5, 313);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Properties.Mask.EditMask = "d";
            this.txtSayfaSayisi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSayfaSayisi.Size = new System.Drawing.Size(179, 20);
            this.txtSayfaSayisi.TabIndex = 7;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(5, 268);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(179, 20);
            this.txtIsbn.TabIndex = 6;
            // 
            // txtYazari
            // 
            this.txtYazari.Location = new System.Drawing.Point(5, 224);
            this.txtYazari.Name = "txtYazari";
            this.txtYazari.Size = new System.Drawing.Size(179, 20);
            this.txtYazari.TabIndex = 4;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(5, 89);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(179, 20);
            this.txtKitapAdi.TabIndex = 1;
            // 
            // txtKodu
            // 
            this.txtKodu.Location = new System.Drawing.Point(5, 44);
            this.txtKodu.Name = "txtKodu";
            this.txtKodu.Size = new System.Drawing.Size(179, 20);
            this.txtKodu.TabIndex = 0;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(5, 339);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(84, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Anahtar Kelimeler";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(7, 295);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(58, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Sayfa Sayısı";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(7, 250);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(70, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "ISBN Numarası";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(7, 206);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(29, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Yazarı";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(7, 161);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Yayın Yılı";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 116);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Kategorisi";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(7, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Kitap Adı";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kitap Kodu";
            // 
            // grControl
            // 
            this.grControl.ContextMenuStrip = this.contextMenuStrip1;
            this.grControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grControl.Location = new System.Drawing.Point(0, 0);
            this.grControl.MainView = this.grView;
            this.grControl.Name = "grControl";
            this.grControl.Size = new System.Drawing.Size(1056, 519);
            this.grControl.TabIndex = 0;
            this.grControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grView});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sagtik_Ekle,
            this.sagtik_Duzenle,
            this.sagtik_Sil});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            // 
            // sagtik_Ekle
            // 
            this.sagtik_Ekle.Name = "sagtik_Ekle";
            this.sagtik_Ekle.Size = new System.Drawing.Size(152, 22);
            this.sagtik_Ekle.Text = "Ekle";
            this.sagtik_Ekle.Click += new System.EventHandler(this.sagtik_Ekle_Click);
            // 
            // sagtik_Duzenle
            // 
            this.sagtik_Duzenle.Name = "sagtik_Duzenle";
            this.sagtik_Duzenle.Size = new System.Drawing.Size(152, 22);
            this.sagtik_Duzenle.Text = "Düzenle";
            this.sagtik_Duzenle.Click += new System.EventHandler(this.sagtik_Duzenle_Click);
            // 
            // sagtik_Sil
            // 
            this.sagtik_Sil.Name = "sagtik_Sil";
            this.sagtik_Sil.Size = new System.Drawing.Size(152, 22);
            this.sagtik_Sil.Text = "Sil";
            this.sagtik_Sil.Click += new System.EventHandler(this.sagtik_Sil_Click);
            // 
            // grView
            // 
            this.grView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_KitapId,
            this.col_Kategori,
            this.col_KitapKodu,
            this.col_KitapAdi,
            this.col_YayinYili,
            this.col_Yazari,
            this.col_ISBN,
            this.col_SayfaSayisi,
            this.col_AnahtarKelimeler});
            this.grView.GridControl = this.grControl;
            this.grView.Name = "grView";
            this.grView.OptionsView.ShowGroupPanel = false;
            // 
            // col_KitapId
            // 
            this.col_KitapId.FieldName = "KitapId";
            this.col_KitapId.Name = "col_KitapId";
            this.col_KitapId.OptionsColumn.AllowEdit = false;
            this.col_KitapId.OptionsColumn.AllowFocus = false;
            this.col_KitapId.OptionsColumn.FixedWidth = true;
            this.col_KitapId.OptionsColumn.ReadOnly = true;
            // 
            // col_Kategori
            // 
            this.col_Kategori.Caption = "Kategorisi";
            this.col_Kategori.FieldName = "Kategori";
            this.col_Kategori.Name = "col_Kategori";
            this.col_Kategori.OptionsColumn.AllowEdit = false;
            this.col_Kategori.OptionsColumn.AllowFocus = false;
            this.col_Kategori.OptionsColumn.FixedWidth = true;
            this.col_Kategori.OptionsColumn.ReadOnly = true;
            this.col_Kategori.Visible = true;
            this.col_Kategori.VisibleIndex = 0;
            this.col_Kategori.Width = 100;
            // 
            // col_KitapKodu
            // 
            this.col_KitapKodu.Caption = "Kodu";
            this.col_KitapKodu.FieldName = "KitapKodu";
            this.col_KitapKodu.Name = "col_KitapKodu";
            this.col_KitapKodu.OptionsColumn.AllowEdit = false;
            this.col_KitapKodu.OptionsColumn.AllowFocus = false;
            this.col_KitapKodu.OptionsColumn.FixedWidth = true;
            this.col_KitapKodu.OptionsColumn.ReadOnly = true;
            this.col_KitapKodu.Visible = true;
            this.col_KitapKodu.VisibleIndex = 1;
            // 
            // col_KitapAdi
            // 
            this.col_KitapAdi.Caption = "Adı";
            this.col_KitapAdi.FieldName = "KitapAdi";
            this.col_KitapAdi.Name = "col_KitapAdi";
            this.col_KitapAdi.OptionsColumn.AllowEdit = false;
            this.col_KitapAdi.OptionsColumn.AllowFocus = false;
            this.col_KitapAdi.OptionsColumn.FixedWidth = true;
            this.col_KitapAdi.OptionsColumn.ReadOnly = true;
            this.col_KitapAdi.Visible = true;
            this.col_KitapAdi.VisibleIndex = 2;
            this.col_KitapAdi.Width = 100;
            // 
            // col_YayinYili
            // 
            this.col_YayinYili.Caption = "Yayın Yılı";
            this.col_YayinYili.FieldName = "YayinYili";
            this.col_YayinYili.Name = "col_YayinYili";
            this.col_YayinYili.OptionsColumn.AllowEdit = false;
            this.col_YayinYili.OptionsColumn.AllowFocus = false;
            this.col_YayinYili.OptionsColumn.FixedWidth = true;
            this.col_YayinYili.OptionsColumn.ReadOnly = true;
            this.col_YayinYili.Visible = true;
            this.col_YayinYili.VisibleIndex = 3;
            this.col_YayinYili.Width = 100;
            // 
            // col_Yazari
            // 
            this.col_Yazari.Caption = "Yazarı";
            this.col_Yazari.FieldName = "Yazari";
            this.col_Yazari.Name = "col_Yazari";
            this.col_Yazari.OptionsColumn.AllowEdit = false;
            this.col_Yazari.OptionsColumn.AllowFocus = false;
            this.col_Yazari.OptionsColumn.FixedWidth = true;
            this.col_Yazari.OptionsColumn.ReadOnly = true;
            this.col_Yazari.Visible = true;
            this.col_Yazari.VisibleIndex = 4;
            this.col_Yazari.Width = 100;
            // 
            // col_ISBN
            // 
            this.col_ISBN.Caption = "ISBN";
            this.col_ISBN.FieldName = "ISBNNumarasi";
            this.col_ISBN.Name = "col_ISBN";
            this.col_ISBN.OptionsColumn.AllowEdit = false;
            this.col_ISBN.OptionsColumn.AllowFocus = false;
            this.col_ISBN.OptionsColumn.FixedWidth = true;
            this.col_ISBN.OptionsColumn.ReadOnly = true;
            this.col_ISBN.Visible = true;
            this.col_ISBN.VisibleIndex = 5;
            this.col_ISBN.Width = 50;
            // 
            // col_SayfaSayisi
            // 
            this.col_SayfaSayisi.Caption = "Sayfa Sayısı";
            this.col_SayfaSayisi.FieldName = "SayfaSayisi";
            this.col_SayfaSayisi.Name = "col_SayfaSayisi";
            this.col_SayfaSayisi.OptionsColumn.AllowEdit = false;
            this.col_SayfaSayisi.OptionsColumn.AllowFocus = false;
            this.col_SayfaSayisi.OptionsColumn.FixedWidth = true;
            this.col_SayfaSayisi.OptionsColumn.ReadOnly = true;
            this.col_SayfaSayisi.Visible = true;
            this.col_SayfaSayisi.VisibleIndex = 6;
            // 
            // col_AnahtarKelimeler
            // 
            this.col_AnahtarKelimeler.Caption = "Anahtar Kelimeler";
            this.col_AnahtarKelimeler.FieldName = "AnahtarKelimeler";
            this.col_AnahtarKelimeler.Name = "col_AnahtarKelimeler";
            this.col_AnahtarKelimeler.OptionsColumn.AllowEdit = false;
            this.col_AnahtarKelimeler.OptionsColumn.AllowFocus = false;
            this.col_AnahtarKelimeler.OptionsColumn.FixedWidth = true;
            this.col_AnahtarKelimeler.OptionsColumn.ReadOnly = true;
            this.col_AnahtarKelimeler.Visible = true;
            this.col_AnahtarKelimeler.VisibleIndex = 7;
            this.col_AnahtarKelimeler.Width = 150;
            // 
            // frmKitapListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 519);
            this.Controls.Add(this.splitContainerControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKitapListesi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYayinYili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKategorisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnahtarKelimeler.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSayfaSayisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsbn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYazari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKitapAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grControl;
        private DevExpress.XtraGrid.Views.Grid.GridView grView;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.TextEdit txtSayfaSayisi;
        private DevExpress.XtraEditors.TextEdit txtIsbn;
        private DevExpress.XtraEditors.TextEdit txtYazari;
        private DevExpress.XtraEditors.TextEdit txtKitapAdi;
        private DevExpress.XtraEditors.TextEdit txtKodu;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn col_KitapId;
        private DevExpress.XtraGrid.Columns.GridColumn col_Kategori;
        private DevExpress.XtraGrid.Columns.GridColumn col_KitapKodu;
        private DevExpress.XtraGrid.Columns.GridColumn col_KitapAdi;
        private DevExpress.XtraGrid.Columns.GridColumn col_YayinYili;
        private DevExpress.XtraGrid.Columns.GridColumn col_Yazari;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sagtik_Ekle;
        private System.Windows.Forms.ToolStripMenuItem sagtik_Duzenle;
        private System.Windows.Forms.ToolStripMenuItem sagtik_Sil;
        private DevExpress.XtraEditors.TextEdit txtYayinYili;
        private DevExpress.XtraEditors.TextEdit txtKategorisi;
        private DevExpress.XtraEditors.TextEdit txtAnahtarKelimeler;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Columns.GridColumn col_ISBN;
        private DevExpress.XtraGrid.Columns.GridColumn col_SayfaSayisi;
        private DevExpress.XtraGrid.Columns.GridColumn col_AnahtarKelimeler;
    }
}