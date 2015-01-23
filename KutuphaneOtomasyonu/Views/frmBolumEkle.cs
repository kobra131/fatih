using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KutuphaneOtomasyonu.Helpers;

namespace KutuphaneOtomasyonu.Views
{
    public partial class frmBolumEkle : DevExpress.XtraEditors.XtraForm
    {
        public frmBolumEkle()
        {
            InitializeComponent();
            this.controller = new Controllers.OgrenciController();
            this.lkpFakulte.SetToLookUpSettings(this.controller.GetFakulteListesi(), "Fakülte Adı", "FakulteAdi", "FakulteId");
        }
        private Controllers.OgrenciController controller;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lkpFakulte.EditValue == null || string.IsNullOrEmpty(txtBolumAdi.Text))
            {
                MessageHelper.ShowError("Tüm alanları doldurunuz!");
            }
            else
            {
                this.controller.BolumEkle((int)lkpFakulte.EditValue, txtBolumAdi.Text);
                MessageHelper.ShowInformation("Bölüm başarı ile eklenmiştir.");
                this.Close();
            }
        }
    }
}