namespace KutuphaneOtomasyonu.Views
{
    partial class frmOduncAlmaListesi
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
            this.grControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sagtik_TeslimAl = new System.Windows.Forms.ToolStripMenuItem();
            this.sagtik_TeslimAlmayiIptalEt = new System.Windows.Forms.ToolStripMenuItem();
            this.sagtik_OduncVermeyiSil = new System.Windows.Forms.ToolStripMenuItem();
            this.grView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFakulteAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBolumAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCepTelefonu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitapKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitapAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISBNNumarasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOduncVermeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeslimAlindi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeslimAlinmaTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitapOduncId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtKitapAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtKitapKodu = new DevExpress.XtraEditors.TextEdit();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.txtIsbn = new DevExpress.XtraEditors.TextEdit();
            this.txtAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtSoyadi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbTeslimDurumu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKitapAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKitapKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsbn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTeslimDurumu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grControl
            // 
            this.grControl.ContextMenuStrip = this.contextMenuStrip1;
            this.grControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grControl.Location = new System.Drawing.Point(0, 0);
            this.grControl.MainView = this.grView;
            this.grControl.Name = "grControl";
            this.grControl.Size = new System.Drawing.Size(1066, 617);
            this.grControl.TabIndex = 0;
            this.grControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grView});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sagtik_TeslimAl,
            this.sagtik_TeslimAlmayiIptalEt,
            this.sagtik_OduncVermeyiSil});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(189, 70);
            // 
            // sagtik_TeslimAl
            // 
            this.sagtik_TeslimAl.Enabled = false;
            this.sagtik_TeslimAl.Name = "sagtik_TeslimAl";
            this.sagtik_TeslimAl.Size = new System.Drawing.Size(188, 22);
            this.sagtik_TeslimAl.Text = "Teslim Al";
            this.sagtik_TeslimAl.Click += new System.EventHandler(this.sagtik_TeslimAl_Click);
            // 
            // sagtik_TeslimAlmayiIptalEt
            // 
            this.sagtik_TeslimAlmayiIptalEt.Enabled = false;
            this.sagtik_TeslimAlmayiIptalEt.Name = "sagtik_TeslimAlmayiIptalEt";
            this.sagtik_TeslimAlmayiIptalEt.Size = new System.Drawing.Size(188, 22);
            this.sagtik_TeslimAlmayiIptalEt.Text = "Teslim Almayı İptal Et";
            this.sagtik_TeslimAlmayiIptalEt.Click += new System.EventHandler(this.sagtik_TeslimAlmayiIptalEt_Click);
            // 
            // sagtik_OduncVermeyiSil
            // 
            this.sagtik_OduncVermeyiSil.Name = "sagtik_OduncVermeyiSil";
            this.sagtik_OduncVermeyiSil.Size = new System.Drawing.Size(188, 22);
            this.sagtik_OduncVermeyiSil.Text = "Ödünç Vermeyi Sil";
            this.sagtik_OduncVermeyiSil.Click += new System.EventHandler(this.sagtik_OduncVermeyiSil_Click);
            // 
            // grView
            // 
            this.grView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAdi,
            this.colSoyadi,
            this.colFakulteAdi,
            this.colBolumAdi,
            this.colCepTelefonu,
            this.colKitapKodu,
            this.colKitapAdi,
            this.colISBNNumarasi,
            this.colOduncVermeTarihi,
            this.colTeslimAlindi,
            this.colTeslimAlinmaTarihi,
            this.colKitapOduncId});
            this.grView.GridControl = this.grControl;
            this.grView.Name = "grView";
            this.grView.OptionsView.ShowGroupPanel = false;
            this.grView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grView_FocusedRowChanged);
            this.grView.GotFocus += new System.EventHandler(this.grView_GotFocus);
            this.grView.RowCountChanged += new System.EventHandler(this.grView_RowCountChanged);
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowEdit = false;
            this.colAdi.OptionsColumn.AllowFocus = false;
            this.colAdi.OptionsColumn.FixedWidth = true;
            this.colAdi.OptionsColumn.ReadOnly = true;
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 0;
            this.colAdi.Width = 100;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.OptionsColumn.AllowEdit = false;
            this.colSoyadi.OptionsColumn.AllowFocus = false;
            this.colSoyadi.OptionsColumn.FixedWidth = true;
            this.colSoyadi.OptionsColumn.ReadOnly = true;
            this.colSoyadi.Visible = true;
            this.colSoyadi.VisibleIndex = 1;
            this.colSoyadi.Width = 99;
            // 
            // colFakulteAdi
            // 
            this.colFakulteAdi.Caption = "Fakülte";
            this.colFakulteAdi.FieldName = "FakulteAdi";
            this.colFakulteAdi.Name = "colFakulteAdi";
            this.colFakulteAdi.OptionsColumn.AllowEdit = false;
            this.colFakulteAdi.OptionsColumn.AllowFocus = false;
            this.colFakulteAdi.OptionsColumn.FixedWidth = true;
            this.colFakulteAdi.OptionsColumn.ReadOnly = true;
            this.colFakulteAdi.Visible = true;
            this.colFakulteAdi.VisibleIndex = 2;
            this.colFakulteAdi.Width = 98;
            // 
            // colBolumAdi
            // 
            this.colBolumAdi.Caption = "Bölüm";
            this.colBolumAdi.FieldName = "BolumAdi";
            this.colBolumAdi.Name = "colBolumAdi";
            this.colBolumAdi.OptionsColumn.AllowEdit = false;
            this.colBolumAdi.OptionsColumn.AllowFocus = false;
            this.colBolumAdi.OptionsColumn.FixedWidth = true;
            this.colBolumAdi.OptionsColumn.ReadOnly = true;
            this.colBolumAdi.Visible = true;
            this.colBolumAdi.VisibleIndex = 3;
            this.colBolumAdi.Width = 98;
            // 
            // colCepTelefonu
            // 
            this.colCepTelefonu.AppearanceCell.Options.UseTextOptions = true;
            this.colCepTelefonu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCepTelefonu.Caption = "Cep Telefonu";
            this.colCepTelefonu.FieldName = "CepTelefonu";
            this.colCepTelefonu.Name = "colCepTelefonu";
            this.colCepTelefonu.OptionsColumn.AllowEdit = false;
            this.colCepTelefonu.OptionsColumn.AllowFocus = false;
            this.colCepTelefonu.OptionsColumn.FixedWidth = true;
            this.colCepTelefonu.OptionsColumn.ReadOnly = true;
            this.colCepTelefonu.Visible = true;
            this.colCepTelefonu.VisibleIndex = 4;
            this.colCepTelefonu.Width = 92;
            // 
            // colKitapKodu
            // 
            this.colKitapKodu.AppearanceCell.Options.UseTextOptions = true;
            this.colKitapKodu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colKitapKodu.FieldName = "KitapKodu";
            this.colKitapKodu.Name = "colKitapKodu";
            this.colKitapKodu.OptionsColumn.AllowEdit = false;
            this.colKitapKodu.OptionsColumn.AllowFocus = false;
            this.colKitapKodu.OptionsColumn.FixedWidth = true;
            this.colKitapKodu.OptionsColumn.ReadOnly = true;
            this.colKitapKodu.Visible = true;
            this.colKitapKodu.VisibleIndex = 5;
            this.colKitapKodu.Width = 92;
            // 
            // colKitapAdi
            // 
            this.colKitapAdi.Caption = "Kitap Adı";
            this.colKitapAdi.FieldName = "KitapAdi";
            this.colKitapAdi.Name = "colKitapAdi";
            this.colKitapAdi.OptionsColumn.AllowEdit = false;
            this.colKitapAdi.OptionsColumn.AllowFocus = false;
            this.colKitapAdi.OptionsColumn.FixedWidth = true;
            this.colKitapAdi.OptionsColumn.ReadOnly = true;
            this.colKitapAdi.Visible = true;
            this.colKitapAdi.VisibleIndex = 6;
            this.colKitapAdi.Width = 98;
            // 
            // colISBNNumarasi
            // 
            this.colISBNNumarasi.AppearanceCell.Options.UseTextOptions = true;
            this.colISBNNumarasi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colISBNNumarasi.Caption = "ISBN Numarası";
            this.colISBNNumarasi.FieldName = "ISBNNumarasi";
            this.colISBNNumarasi.Name = "colISBNNumarasi";
            this.colISBNNumarasi.OptionsColumn.AllowEdit = false;
            this.colISBNNumarasi.OptionsColumn.AllowFocus = false;
            this.colISBNNumarasi.OptionsColumn.FixedWidth = true;
            this.colISBNNumarasi.OptionsColumn.ReadOnly = true;
            this.colISBNNumarasi.Visible = true;
            this.colISBNNumarasi.VisibleIndex = 7;
            this.colISBNNumarasi.Width = 90;
            // 
            // colOduncVermeTarihi
            // 
            this.colOduncVermeTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colOduncVermeTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colOduncVermeTarihi.Caption = "Ödünç Verme Tarihi";
            this.colOduncVermeTarihi.DisplayFormat.FormatString = "dd.MM.yyyy";
            this.colOduncVermeTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colOduncVermeTarihi.FieldName = "OduncVermeTarihi";
            this.colOduncVermeTarihi.Name = "colOduncVermeTarihi";
            this.colOduncVermeTarihi.OptionsColumn.AllowEdit = false;
            this.colOduncVermeTarihi.OptionsColumn.AllowFocus = false;
            this.colOduncVermeTarihi.OptionsColumn.FixedWidth = true;
            this.colOduncVermeTarihi.OptionsColumn.ReadOnly = true;
            this.colOduncVermeTarihi.Visible = true;
            this.colOduncVermeTarihi.VisibleIndex = 8;
            this.colOduncVermeTarihi.Width = 125;
            // 
            // colTeslimAlindi
            // 
            this.colTeslimAlindi.AppearanceCell.Options.UseTextOptions = true;
            this.colTeslimAlindi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTeslimAlindi.Caption = "Teslim Alındı";
            this.colTeslimAlindi.FieldName = "TeslimAlindi";
            this.colTeslimAlindi.Name = "colTeslimAlindi";
            this.colTeslimAlindi.OptionsColumn.AllowEdit = false;
            this.colTeslimAlindi.OptionsColumn.AllowFocus = false;
            this.colTeslimAlindi.OptionsColumn.FixedWidth = true;
            this.colTeslimAlindi.OptionsColumn.ReadOnly = true;
            this.colTeslimAlindi.Visible = true;
            this.colTeslimAlindi.VisibleIndex = 9;
            this.colTeslimAlindi.Width = 74;
            // 
            // colTeslimAlinmaTarihi
            // 
            this.colTeslimAlinmaTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colTeslimAlinmaTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTeslimAlinmaTarihi.Caption = "Teslim Alınma Tarihi";
            this.colTeslimAlinmaTarihi.DisplayFormat.FormatString = "dd.MM.yyyy";
            this.colTeslimAlinmaTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTeslimAlinmaTarihi.FieldName = "TeslimAlinmaTarihi";
            this.colTeslimAlinmaTarihi.Name = "colTeslimAlinmaTarihi";
            this.colTeslimAlinmaTarihi.OptionsColumn.AllowEdit = false;
            this.colTeslimAlinmaTarihi.OptionsColumn.AllowFocus = false;
            this.colTeslimAlinmaTarihi.OptionsColumn.FixedWidth = true;
            this.colTeslimAlinmaTarihi.OptionsColumn.ReadOnly = true;
            this.colTeslimAlinmaTarihi.Visible = true;
            this.colTeslimAlinmaTarihi.VisibleIndex = 10;
            this.colTeslimAlinmaTarihi.Width = 125;
            // 
            // colKitapOduncId
            // 
            this.colKitapOduncId.FieldName = "KitapOduncId";
            this.colKitapOduncId.Name = "colKitapOduncId";
            this.colKitapOduncId.OptionsColumn.AllowShowHide = false;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(5, 180);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(179, 20);
            this.txtKitapAdi.TabIndex = 10;
            // 
            // txtKitapKodu
            // 
            this.txtKitapKodu.Location = new System.Drawing.Point(5, 135);
            this.txtKitapKodu.Name = "txtKitapKodu";
            this.txtKitapKodu.Size = new System.Drawing.Size(179, 20);
            this.txtKitapKodu.TabIndex = 10;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(48, 295);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(129, 295);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(55, 23);
            this.btnAra.TabIndex = 9;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(5, 224);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(179, 20);
            this.txtIsbn.TabIndex = 6;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(5, 44);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(179, 20);
            this.txtAdi.TabIndex = 0;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(5, 89);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(179, 20);
            this.txtSoyadi.TabIndex = 1;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(7, 206);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(70, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "ISBN Numarası";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(7, 251);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(69, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Teslim Durumu";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(7, 161);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Kitap Adı";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 116);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Kitap Kodu";
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
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.txtKitapAdi);
            this.groupControl1.Controls.Add(this.txtKitapKodu);
            this.groupControl1.Controls.Add(this.btnTemizle);
            this.groupControl1.Controls.Add(this.btnAra);
            this.groupControl1.Controls.Add(this.txtIsbn);
            this.groupControl1.Controls.Add(this.txtSoyadi);
            this.groupControl1.Controls.Add(this.txtAdi);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.cmbTeslimDurumu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(189, 617);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Filtreleme";
            // 
            // cmbTeslimDurumu
            // 
            this.cmbTeslimDurumu.EditValue = "Tümü";
            this.cmbTeslimDurumu.Location = new System.Drawing.Point(5, 269);
            this.cmbTeslimDurumu.Name = "cmbTeslimDurumu";
            this.cmbTeslimDurumu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTeslimDurumu.Properties.Items.AddRange(new object[] {
            "Tümü",
            "Teslim Alınanlar",
            "Teslim Alınmayanlar"});
            this.cmbTeslimDurumu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbTeslimDurumu.Size = new System.Drawing.Size(179, 20);
            this.cmbTeslimDurumu.TabIndex = 4;
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
            this.splitContainerControl1.Size = new System.Drawing.Size(1260, 617);
            this.splitContainerControl1.SplitterPosition = 189;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // frmOduncAlmaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 617);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmOduncAlmaListesi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödünç Alma Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKitapAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKitapKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsbn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTeslimDurumu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grControl;
        private DevExpress.XtraGrid.Views.Grid.GridView grView;
        private DevExpress.XtraGrid.Columns.GridColumn colAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn colFakulteAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBolumAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colCepTelefonu;
        private DevExpress.XtraGrid.Columns.GridColumn colKitapKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colKitapAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colISBNNumarasi;
        private DevExpress.XtraGrid.Columns.GridColumn colOduncVermeTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colTeslimAlindi;
        private DevExpress.XtraGrid.Columns.GridColumn colTeslimAlinmaTarihi;
        private DevExpress.XtraEditors.TextEdit txtKitapAdi;
        private DevExpress.XtraEditors.TextEdit txtKitapKodu;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.TextEdit txtIsbn;
        private DevExpress.XtraEditors.TextEdit txtAdi;
        private DevExpress.XtraEditors.TextEdit txtSoyadi;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sagtik_TeslimAl;
        private System.Windows.Forms.ToolStripMenuItem sagtik_TeslimAlmayiIptalEt;
        private System.Windows.Forms.ToolStripMenuItem sagtik_OduncVermeyiSil;
        private DevExpress.XtraGrid.Columns.GridColumn colKitapOduncId;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTeslimDurumu;
    }
}