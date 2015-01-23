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
    public partial class frmOduncAlmaListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmOduncAlmaListesi()
        {
            InitializeComponent();
            this.controller = new Controllers.KitapController();
        }
        private Controllers.KitapController controller;

        private void btnAra_Click(object sender, EventArgs e)
        {
            this.grControl.DataSource = this.controller.GetOduncListesi(txtAdi.Text, txtSoyadi.Text, txtKitapKodu.Text, txtKitapAdi.Text, txtIsbn.Text, (byte)cmbTeslimDurumu.SelectedIndex);
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
            cmbTeslimDurumu.SelectedIndex = 0;
            btnAra.PerformClick();
        }


        private void sagtik_TeslimAl_Click(object sender, EventArgs e)
        {
            if (MessageHelper.ShowQuestion("Teslim alma işlemi yapılacaktır emin misiniz?"))
            {
                this.controller.TeslimAl((int)grView.GetFocusedRowCellValue(colKitapOduncId));
                this.btnAra.PerformClick();
            }
        }

        private void grView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (grView.FocusedRowHandle > 0)
            {
                if ((bool)grView.GetFocusedRowCellValue(colTeslimAlindi))
                {
                    sagtik_TeslimAl.Enabled = false;
                    sagtik_TeslimAlmayiIptalEt.Enabled = true;
                }
                else
                {
                    sagtik_TeslimAl.Enabled = true;
                    sagtik_TeslimAlmayiIptalEt.Enabled = false;
                }
            }
        }

        private void grView_GotFocus(object sender, EventArgs e)
        {
            grView_FocusedRowChanged(null, null);
        }

        private void sagtik_TeslimAlmayiIptalEt_Click(object sender, EventArgs e)
        {
            if (MessageHelper.ShowQuestion("Teslim alma işlemi iptal edilecektir emin misiniz?"))
            {
                this.controller.TeslimAlmayiIptalEt((int)grView.GetFocusedRowCellValue(colKitapOduncId));
                this.btnAra.PerformClick();
            }
        }

        private void sagtik_OduncVermeyiSil_Click(object sender, EventArgs e)
        {
            if (MessageHelper.ShowQuestion("Kayıt silinecektir emin misiniz?"))
            {
                this.controller.OduncVermeyiSil((int)grView.GetFocusedRowCellValue(colKitapOduncId));
                this.btnAra.PerformClick();
            }
        }

        private void grView_RowCountChanged(object sender, EventArgs e)
        {
            sagtik_OduncVermeyiSil.Enabled = this.grView.RowCount > 0;
        }
    }
}