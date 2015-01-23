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
using KutuphaneOtomasyonu.Models;

namespace KutuphaneOtomasyonu.Views
{
    public partial class frmKitapEkleDuzenle : DevExpress.XtraEditors.XtraForm
    {
        public frmKitapEkleDuzenle()
        {
            InitializeComponent();
            this.kitapController = new Controllers.KitapController();
            this.Text = "Kitap Ekle";            

        }
        public frmKitapEkleDuzenle(int kitapId)
            : this()
        {
            this.Text = "Kitap Düzenle";
            this.btnKaydet.Text = "Düzenle";
            this.duzenlenecekKitapId = kitapId;
            var kitap = this.kitapController.GetKitap(kitapId);
            txtAnahtarKelimeler.Text = kitap.AnahtarKelimeler;
            txtIsbn.Text = kitap.ISBNNumarasi;
            txtKategori.Text = kitap.Kategori;
            txtKitapAdi.Text = kitap.KitapAdi;
            txtKitapKodu.Text = kitap.KitapKodu;
            txtSayfaSayisi.Text = kitap.SayfaSayisi.ToString();
            txtYayinYili.Text = kitap.YayinYili;
            txtYazari.Text = kitap.Yazari;
        }

        private int duzenlenecekKitapId = -1;
        private Controllers.KitapController kitapController;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            KitapViewModel model = new KitapViewModel
            {
                AnahtarKelimeler = txtAnahtarKelimeler.Text,
                SayfaSayisi = int.Parse(txtSayfaSayisi.Text),
                ISBNNumarasi = txtIsbn.Text,
                Yazari = txtYazari.Text,
                YayinYili = txtYayinYili.Text,
                KitapAdi = txtKitapAdi.Text,
                KitapKodu = txtKitapKodu.Text,
                Kategori = txtKategori.Text
            };

            string bilgiMesaji = string.Empty;
            if (this.duzenlenecekKitapId > 0)
            {
                model.KitapId = this.duzenlenecekKitapId;
                this.kitapController.KitapGuncelle(model);
                bilgiMesaji = "Kitap başarı ile güncellenmiştir.";
            }
            else
            {
                this.kitapController.KitapEkle(model);
                bilgiMesaji = "Kitap başarı ile kaydedilmiştir.";
            }
            MessageHelper.ShowInformation(bilgiMesaji);
            this.Close();

        }


    }
}