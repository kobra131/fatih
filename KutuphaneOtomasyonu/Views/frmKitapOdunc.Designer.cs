namespace KutuphaneOtomasyonu.Views
{
    partial class frmKitapOdunc
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lkpOgrenci = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lkpKitap = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtGeriAlmaTarihi = new DevExpress.XtraEditors.DateEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnOduncVer = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lkpOgrenci.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpKitap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGeriAlmaTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGeriAlmaTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Alan Öğrenci";
            // 
            // lkpOgrenci
            // 
            this.lkpOgrenci.Location = new System.Drawing.Point(99, 9);
            this.lkpOgrenci.Name = "lkpOgrenci";
            this.lkpOgrenci.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpOgrenci.Properties.NullText = "";
            this.lkpOgrenci.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lkpOgrenci.Size = new System.Drawing.Size(203, 20);
            this.lkpOgrenci.TabIndex = 0;
            this.lkpOgrenci.EditValueChanged += new System.EventHandler(this.lkpOgrenci_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Alınan Kitap";
            // 
            // lkpKitap
            // 
            this.lkpKitap.Location = new System.Drawing.Point(99, 35);
            this.lkpKitap.Name = "lkpKitap";
            this.lkpKitap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpKitap.Properties.NullText = "";
            this.lkpKitap.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lkpKitap.Size = new System.Drawing.Size(203, 20);
            this.lkpKitap.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 66);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Geri Alınma Tarihi";
            // 
            // dtGeriAlmaTarihi
            // 
            this.dtGeriAlmaTarihi.EditValue = null;
            this.dtGeriAlmaTarihi.Location = new System.Drawing.Point(99, 63);
            this.dtGeriAlmaTarihi.Name = "dtGeriAlmaTarihi";
            this.dtGeriAlmaTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtGeriAlmaTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtGeriAlmaTarihi.Size = new System.Drawing.Size(203, 20);
            this.dtGeriAlmaTarihi.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnOduncVer);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 90);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(315, 33);
            this.panelControl1.TabIndex = 3;
            // 
            // btnOduncVer
            // 
            this.btnOduncVer.Location = new System.Drawing.Point(235, 5);
            this.btnOduncVer.Name = "btnOduncVer";
            this.btnOduncVer.Size = new System.Drawing.Size(75, 23);
            this.btnOduncVer.TabIndex = 0;
            this.btnOduncVer.Text = "Ödünç Ver";
            this.btnOduncVer.Click += new System.EventHandler(this.btnOduncVer_Click);
            // 
            // frmKitapOdunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 123);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.dtGeriAlmaTarihi);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lkpKitap);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lkpOgrenci);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKitapOdunc";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Ödünç Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.lkpOgrenci.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpKitap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGeriAlmaTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGeriAlmaTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lkpOgrenci;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lkpKitap;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dtGeriAlmaTarihi;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnOduncVer;
    }
}