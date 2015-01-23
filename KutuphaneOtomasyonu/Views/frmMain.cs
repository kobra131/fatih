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
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            FormHelper.KitapEkle();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            FormHelper.OgrenciEkle();
        }

        private void btnKitapOduncVerme_Click(object sender, EventArgs e)
        {
            FormHelper.KitapOduncVerme();
        }

        private void btnOgrenciListesi_Click(object sender, EventArgs e)
        {
            FormHelper.OgrenciListesi();
        }

        private void btnKitapListesi_Click(object sender, EventArgs e)
        {
            FormHelper.KitapListesi();
        }

        private void btnKitapOduncListesi_Click(object sender, EventArgs e)
        {
            FormHelper.KitapOduncListesi();
        }

        private void btnFakulteEkle_Click(object sender, EventArgs e)
        {
            FormHelper.FakulteEkle();
        }

        private void btnBolumEkle_Click(object sender, EventArgs e)
        {
            FormHelper.BolumEkle();
        }
    }
}