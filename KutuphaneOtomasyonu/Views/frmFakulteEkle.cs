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
    public partial class frmFakulteEkle : DevExpress.XtraEditors.XtraForm
    {
        public frmFakulteEkle()
        {
            InitializeComponent();
            this.controller = new Controllers.OgrenciController();
        }
        private Controllers.OgrenciController controller;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFakulteAdi.Text))
            {
                MessageHelper.ShowError("Fakülte adını giriniz!");
            }
            else
            {
                this.controller.FakulteEkle(txtFakulteAdi.Text);
                MessageHelper.ShowInformation("Fakülte başarı ile eklenmiştir.");
                this.Close();
            }
        }
    }
}