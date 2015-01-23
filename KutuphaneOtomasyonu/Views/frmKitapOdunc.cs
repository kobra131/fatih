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
    public partial class frmKitapOdunc : DevExpress.XtraEditors.XtraForm
    {
        public frmKitapOdunc()
        {
            InitializeComponent();
            this.kitapController = new Controllers.KitapController();
            lkpKitap.SetToLookUpSettings(kitapController.GetKitapListesiOduncVerilmemisler(), "Kitap Adı", "KitapAdi", "KitapId");

            Controllers.OgrenciController ogrenciController = new Controllers.OgrenciController();
            lkpOgrenci.SetToLookUpSettings(ogrenciController.GetOgrenciListesiLookUpEdit(), "Öğrenci", "Adi", "OgrenciId");
        }

        Controllers.KitapController kitapController;

        private void btnOduncVer_Click(object sender, EventArgs e)
        {
            if (lkpOgrenci.EditValue == null || lkpKitap.EditValue == null || string.IsNullOrEmpty(dtGeriAlmaTarihi.Text))
            {
                MessageHelper.ShowError("Tüm alanları doldurunuz!");
                return;
            }
            this.kitapController.KitapOduncVer((int)this.lkpOgrenci.EditValue, (int)this.lkpKitap.EditValue, this.dtGeriAlmaTarihi.DateTime);
            MessageHelper.ShowInformation("Ödünç verme tamamlandı..");
            this.Close();
        }

        private void lkpOgrenci_EditValueChanged(object sender, EventArgs e)
        {
            if (lkpOgrenci.EditValue != null)
            {
                int id = (int)lkpOgrenci.EditValue;
                bool result = this.kitapController.KitapOduncOgrenciKontrol(id);
                if (!result && !MessageHelper.ShowQuestion("Bu öğrencide ödünç verilmiş bir kitap bulunmaktadır. İşleme devam edilsin mi ?"))
                {
                    this.lkpOgrenci.EditValue = null;
                }
            }
        }
    }
}