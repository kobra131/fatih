namespace KutuphaneOtomasyonu.Views
{
    partial class frmOgrenciListesi
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
            this.lkpBolumu = new DevExpress.XtraEditors.LookUpEdit();
            this.lkpFakulte = new DevExpress.XtraEditors.LookUpEdit();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.txtMemleketAdresi = new DevExpress.XtraEditors.TextEdit();
            this.txtAdres = new DevExpress.XtraEditors.TextEdit();
            this.txtCepTelefonu = new DevExpress.XtraEditors.TextEdit();
            this.txtSoyadi = new DevExpress.XtraEditors.TextEdit();
            this.txtAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grControl = new DevExpress.XtraGrid.GridControl();
            this.grView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_OgrenciId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Soyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_FakulteAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_BolumAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_CepTelefonu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_KayitTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sagtik_Ekle = new System.Windows.Forms.ToolStripMenuItem();
            this.sagtik_Duzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.sagtik_Sil = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpBolumu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFakulte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMemleketAdresi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCepTelefonu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            this.splitContainerControl1.Size = new System.Drawing.Size(996, 519);
            this.splitContainerControl1.SplitterPosition = 169;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.lkpBolumu);
            this.groupControl1.Controls.Add(this.lkpFakulte);
            this.groupControl1.Controls.Add(this.btnTemizle);
            this.groupControl1.Controls.Add(this.btnAra);
            this.groupControl1.Controls.Add(this.txtMemleketAdresi);
            this.groupControl1.Controls.Add(this.txtAdres);
            this.groupControl1.Controls.Add(this.txtCepTelefonu);
            this.groupControl1.Controls.Add(this.txtSoyadi);
            this.groupControl1.Controls.Add(this.txtAdi);
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
            this.groupControl1.Size = new System.Drawing.Size(169, 519);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Öğrenci Filtreleme";
            // 
            // lkpBolumu
            // 
            this.lkpBolumu.Location = new System.Drawing.Point(5, 179);
            this.lkpBolumu.Name = "lkpBolumu";
            this.lkpBolumu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpBolumu.Properties.NullText = "";
            this.lkpBolumu.Properties.PopupSizeable = false;
            this.lkpBolumu.Size = new System.Drawing.Size(159, 20);
            this.lkpBolumu.TabIndex = 3;
            // 
            // lkpFakulte
            // 
            this.lkpFakulte.Location = new System.Drawing.Point(5, 134);
            this.lkpFakulte.Name = "lkpFakulte";
            this.lkpFakulte.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpFakulte.Properties.NullText = "";
            this.lkpFakulte.Properties.PopupSizeable = false;
            this.lkpFakulte.Size = new System.Drawing.Size(159, 20);
            this.lkpFakulte.TabIndex = 2;
            this.lkpFakulte.EditValueChanged += new System.EventHandler(this.lkpFakulte_EditValueChanged);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(27, 340);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(108, 340);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(55, 23);
            this.btnAra.TabIndex = 9;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtMemleketAdresi
            // 
            this.txtMemleketAdresi.Location = new System.Drawing.Point(5, 313);
            this.txtMemleketAdresi.Name = "txtMemleketAdresi";
            this.txtMemleketAdresi.Size = new System.Drawing.Size(159, 20);
            this.txtMemleketAdresi.TabIndex = 7;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(5, 268);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(159, 20);
            this.txtAdres.TabIndex = 6;
            // 
            // txtCepTelefonu
            // 
            this.txtCepTelefonu.Location = new System.Drawing.Point(5, 224);
            this.txtCepTelefonu.Name = "txtCepTelefonu";
            this.txtCepTelefonu.Size = new System.Drawing.Size(159, 20);
            this.txtCepTelefonu.TabIndex = 4;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(5, 89);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(159, 20);
            this.txtSoyadi.TabIndex = 1;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(5, 44);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(159, 20);
            this.txtAdi.TabIndex = 0;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(7, 295);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(78, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Memleket Adresi";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(7, 250);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(28, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Adres";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(7, 206);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(64, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Cep Telefonu";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(7, 161);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Bölümü";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 116);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Fakültesi";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(7, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Soyadı";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(15, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Adı";
            // 
            // grControl
            // 
            this.grControl.ContextMenuStrip = this.contextMenuStrip1;
            this.grControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grControl.Location = new System.Drawing.Point(0, 0);
            this.grControl.MainView = this.grView;
            this.grControl.Name = "grControl";
            this.grControl.Size = new System.Drawing.Size(822, 519);
            this.grControl.TabIndex = 0;
            this.grControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grView});
            // 
            // grView
            // 
            this.grView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_OgrenciId,
            this.col_Adi,
            this.col_Soyadi,
            this.col_FakulteAdi,
            this.col_BolumAdi,
            this.col_CepTelefonu,
            this.col_KayitTarihi});
            this.grView.GridControl = this.grControl;
            this.grView.Name = "grView";
            this.grView.OptionsView.ShowGroupPanel = false;
            // 
            // col_OgrenciId
            // 
            this.col_OgrenciId.FieldName = "OgrenciId";
            this.col_OgrenciId.Name = "col_OgrenciId";
            this.col_OgrenciId.OptionsColumn.AllowEdit = false;
            this.col_OgrenciId.OptionsColumn.AllowFocus = false;
            this.col_OgrenciId.OptionsColumn.FixedWidth = true;
            this.col_OgrenciId.OptionsColumn.ReadOnly = true;
            // 
            // col_Adi
            // 
            this.col_Adi.Caption = "Adı";
            this.col_Adi.FieldName = "Adi";
            this.col_Adi.Name = "col_Adi";
            this.col_Adi.OptionsColumn.AllowEdit = false;
            this.col_Adi.OptionsColumn.AllowFocus = false;
            this.col_Adi.OptionsColumn.FixedWidth = true;
            this.col_Adi.OptionsColumn.ReadOnly = true;
            this.col_Adi.Visible = true;
            this.col_Adi.VisibleIndex = 0;
            this.col_Adi.Width = 100;
            // 
            // col_Soyadi
            // 
            this.col_Soyadi.Caption = "Soyadı";
            this.col_Soyadi.FieldName = "Soyadi";
            this.col_Soyadi.Name = "col_Soyadi";
            this.col_Soyadi.OptionsColumn.AllowEdit = false;
            this.col_Soyadi.OptionsColumn.AllowFocus = false;
            this.col_Soyadi.OptionsColumn.FixedWidth = true;
            this.col_Soyadi.OptionsColumn.ReadOnly = true;
            this.col_Soyadi.Visible = true;
            this.col_Soyadi.VisibleIndex = 1;
            this.col_Soyadi.Width = 100;
            // 
            // col_FakulteAdi
            // 
            this.col_FakulteAdi.Caption = "Fakültesi";
            this.col_FakulteAdi.FieldName = "FakulteAdi";
            this.col_FakulteAdi.Name = "col_FakulteAdi";
            this.col_FakulteAdi.OptionsColumn.AllowEdit = false;
            this.col_FakulteAdi.OptionsColumn.AllowFocus = false;
            this.col_FakulteAdi.OptionsColumn.FixedWidth = true;
            this.col_FakulteAdi.OptionsColumn.ReadOnly = true;
            this.col_FakulteAdi.Visible = true;
            this.col_FakulteAdi.VisibleIndex = 2;
            this.col_FakulteAdi.Width = 100;
            // 
            // col_BolumAdi
            // 
            this.col_BolumAdi.Caption = "Bölüm Adı";
            this.col_BolumAdi.FieldName = "BolumAdi";
            this.col_BolumAdi.Name = "col_BolumAdi";
            this.col_BolumAdi.OptionsColumn.AllowEdit = false;
            this.col_BolumAdi.OptionsColumn.AllowFocus = false;
            this.col_BolumAdi.OptionsColumn.FixedWidth = true;
            this.col_BolumAdi.OptionsColumn.ReadOnly = true;
            this.col_BolumAdi.Visible = true;
            this.col_BolumAdi.VisibleIndex = 3;
            this.col_BolumAdi.Width = 100;
            // 
            // col_CepTelefonu
            // 
            this.col_CepTelefonu.Caption = "Cep Telefonu";
            this.col_CepTelefonu.FieldName = "CepTelefonu";
            this.col_CepTelefonu.Name = "col_CepTelefonu";
            this.col_CepTelefonu.OptionsColumn.AllowEdit = false;
            this.col_CepTelefonu.OptionsColumn.AllowFocus = false;
            this.col_CepTelefonu.OptionsColumn.FixedWidth = true;
            this.col_CepTelefonu.OptionsColumn.ReadOnly = true;
            this.col_CepTelefonu.Visible = true;
            this.col_CepTelefonu.VisibleIndex = 4;
            // 
            // col_KayitTarihi
            // 
            this.col_KayitTarihi.Caption = "Kayıt Tarihi";
            this.col_KayitTarihi.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            this.col_KayitTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.col_KayitTarihi.FieldName = "KayitTarihi";
            this.col_KayitTarihi.Name = "col_KayitTarihi";
            this.col_KayitTarihi.OptionsColumn.AllowEdit = false;
            this.col_KayitTarihi.OptionsColumn.AllowFocus = false;
            this.col_KayitTarihi.OptionsColumn.FixedWidth = true;
            this.col_KayitTarihi.OptionsColumn.ReadOnly = true;
            this.col_KayitTarihi.Visible = true;
            this.col_KayitTarihi.VisibleIndex = 5;
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
            // frmOgrenciListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 519);
            this.Controls.Add(this.splitContainerControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOgrenciListesi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpBolumu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFakulte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMemleketAdresi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCepTelefonu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grControl;
        private DevExpress.XtraGrid.Views.Grid.GridView grView;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.TextEdit txtMemleketAdresi;
        private DevExpress.XtraEditors.TextEdit txtAdres;
        private DevExpress.XtraEditors.TextEdit txtCepTelefonu;
        private DevExpress.XtraEditors.TextEdit txtSoyadi;
        private DevExpress.XtraEditors.TextEdit txtAdi;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn col_OgrenciId;
        private DevExpress.XtraGrid.Columns.GridColumn col_Adi;
        private DevExpress.XtraGrid.Columns.GridColumn col_Soyadi;
        private DevExpress.XtraGrid.Columns.GridColumn col_FakulteAdi;
        private DevExpress.XtraGrid.Columns.GridColumn col_BolumAdi;
        private DevExpress.XtraGrid.Columns.GridColumn col_CepTelefonu;
        private DevExpress.XtraGrid.Columns.GridColumn col_KayitTarihi;
        private DevExpress.XtraEditors.LookUpEdit lkpFakulte;
        private DevExpress.XtraEditors.LookUpEdit lkpBolumu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sagtik_Ekle;
        private System.Windows.Forms.ToolStripMenuItem sagtik_Duzenle;
        private System.Windows.Forms.ToolStripMenuItem sagtik_Sil;
    }
}