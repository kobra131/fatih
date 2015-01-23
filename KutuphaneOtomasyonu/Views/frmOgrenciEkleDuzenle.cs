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
    public partial class frmOgrenciEkleDuzenle : DevExpress.XtraEditors.XtraForm
    {
        public frmOgrenciEkleDuzenle()
        {
            InitializeComponent();
            this.Text = "Öğrenci Ekle";
            this.controller = new Controllers.OgrenciController();
            this.lkpFakulte.SetToLookUpSettings(this.controller.GetFakulteListesi(), "Fakülte Adı", "FakulteAdi", "FakulteId");
        }
        public frmOgrenciEkleDuzenle(int duzenlenecekOgrenciId)
            : this()
        {
            this.Text = "Öğrenci Düzenle";
            this.duzenlenecekOgrenciId = duzenlenecekOgrenciId;
            var ogrenci = this.controller.GetOgrenci(duzenlenecekOgrenciId);
            txtAdi.Text = ogrenci.Adi;
            txtAdres.Text = ogrenci.Adres;
            txtCepTelefonu.Text = ogrenci.CepTelefonu;
            txtKayitTarihi.Text = ogrenci.KayitTarihi.ToString("dd.MM.yyyy");
            txtMemleketAdres.Text = ogrenci.MemleketAdres;
            txtSoyadi.Text = ogrenci.Soyadi;
            lkpFakulte.EditValue = ogrenci.FakulteId;
            lkpBolumu.EditValue = ogrenci.BolumId;
            txtAdi.Focus();
        }

        private Controllers.OgrenciController controller;
        private int duzenlenecekOgrenciId = -1;

        private void lkpFakulte_EditValueChanged(object sender, EventArgs e)
        {
            this.lkpBolumu.SetToLookUpSettings(this.controller.GetFakulteBolumListesi((int)this.lkpFakulte.EditValue), "Bölüm Adı", "BolumAdi", "BolumId");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var model = new Models.OgrenciViewModel
            {
                Adi = txtAdi.Text,
                Adres = txtAdres.Text,
                CepTelefonu = txtCepTelefonu.Text,
                FakulteId = (int)lkpFakulte.EditValue,
                KayitTarihi = DateTime.Now,
                MemleketAdres = txtMemleketAdres.Text,
                Soyadi = txtSoyadi.Text,
                BolumId = (int)lkpBolumu.EditValue
            };
            string bilgiMesaji = null;
            if (this.duzenlenecekOgrenciId > 0)
            {
                model.OgrenciId = duzenlenecekOgrenciId;
                this.controller.OgrenciGuncelle(model);
                bilgiMesaji = "Öğrenci başarı ile güncellenmiştir.";
            }
            else
            {
                this.controller.OgrenciEkle(model);
                bilgiMesaji = "Öğrenci başarı ile eklenmiştir.";
            }
            MessageHelper.ShowInformation(bilgiMesaji);
            this.Close();
        }
    }
}