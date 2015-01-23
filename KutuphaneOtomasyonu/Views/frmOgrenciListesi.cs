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
    public partial class frmOgrenciListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmOgrenciListesi()
        {
            InitializeComponent();
            this.controller = new Controllers.OgrenciController();
            this.lkpFakulte.SetToLookUpSettings(this.controller.GetFakulteListesi(), "Fakülte Adı", "FakulteAdi", "FakulteId");
        }
        private Controllers.OgrenciController controller;

        private void lkpFakulte_EditValueChanged(object sender, EventArgs e)
        {
            this.lkpBolumu.SetToLookUpSettings(this.controller.GetFakulteBolumListesi((int)this.lkpFakulte.EditValue), "Bölüm Adı", "BolumAdi", "BolumId");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            this.grControl.DataSource = this.controller.GetOgrenciListesi_Arama(new Models.OgrenciViewModel
            {
                Adi = txtAdi.Text,
                Adres = txtAdres.Text,
                BolumId = lkpBolumu.EditValue == null ? 0 : (int)lkpBolumu.EditValue,
                CepTelefonu = txtCepTelefonu.Text,
                MemleketAdres = txtMemleketAdresi.Text,
                Soyadi = txtSoyadi.Text,
                FakulteId = lkpFakulte.EditValue == null ? 0 : (int)lkpFakulte.EditValue,
            });
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtSoyadi.ResetText();
            txtMemleketAdresi.ResetText();
            txtCepTelefonu.ResetText();
            txtAdres.ResetText();
            txtAdi.ResetText();
            lkpFakulte.EditValue = null;
            lkpBolumu.EditValue = null;
            btnAra.PerformClick();
        }

        private void sagtik_Ekle_Click(object sender, EventArgs e)
        {
            FormHelper.OgrenciEkle();
            btnAra.PerformClick();
        }

        private void sagtik_Duzenle_Click(object sender, EventArgs e)
        {
            if (grView.RowCount > 0)
            {
                FormHelper.OgrenciDuzenle((int)grView.GetFocusedRowCellValue(col_OgrenciId));
                btnAra.PerformClick();
            }
        }

        private void sagtik_Sil_Click(object sender, EventArgs e)
        {
            if (grView.RowCount > 0 && MessageHelper.ShowQuestion("Öğrenci silinecektir emin misiniz?"))
            {
                this.controller.OgrenciSil((int)grView.GetFocusedRowCellValue(col_OgrenciId));
                btnAra.PerformClick();
            }

        }
    }
}