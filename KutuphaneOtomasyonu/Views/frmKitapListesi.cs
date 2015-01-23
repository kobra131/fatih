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
    public partial class frmKitapListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmKitapListesi()
        {
            InitializeComponent();
            this.controller = new Controllers.KitapController();
        }
        private Controllers.KitapController controller;

        private void btnAra_Click(object sender, EventArgs e)
        {
            this.grControl.DataSource = this.controller.GetKitapListesi_Arama(new Models.KitapViewModel
            {
                AnahtarKelimeler = txtAnahtarKelimeler.Text,
                ISBNNumarasi = txtIsbn.Text,
                Kategori = txtKategorisi.Text,
                KitapAdi = txtKitapAdi.Text,
                KitapKodu = txtKodu.Text,
                SayfaSayisi = int.Parse(string.IsNullOrEmpty(txtSayfaSayisi.Text) ? "0" : txtSayfaSayisi.Text),
                YayinYili = txtYayinYili.Text,
                Yazari = txtYazari.Text

            });
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupControl1.Controls)
            {
                if (item is TextEdit)
                {
                    item.ResetText();
                }
            }           
            btnAra.PerformClick();
        }

        private void sagtik_Ekle_Click(object sender, EventArgs e)
        {
            FormHelper.KitapEkle();
            btnAra.PerformClick();
        }

        private void sagtik_Duzenle_Click(object sender, EventArgs e)
        {
            if (grView.RowCount > 0)
            {
                FormHelper.KitapDuzenle((int)grView.GetFocusedRowCellValue(col_KitapId));
                btnAra.PerformClick();
            }
        }

        private void sagtik_Sil_Click(object sender, EventArgs e)
        {
            if (grView.RowCount > 0 && MessageHelper.ShowQuestion("Öğrenci silinecektir emin misiniz?"))
            {
                this.controller.KitapSil((int)grView.GetFocusedRowCellValue(col_KitapId));
                btnAra.PerformClick();
            }

        }
    }
}