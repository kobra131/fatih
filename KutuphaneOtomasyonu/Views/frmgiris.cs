using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KutuphaneOtomasyonu.Models;
using KutuphaneOtomasyonu.Helpers;

namespace KutuphaneOtomasyonu.Views
{
    public partial class frmgiris : DevExpress.XtraEditors.XtraForm
    {
        public frmgiris()
        {
            InitializeComponent();
        }
        private string adminUser = string.Empty;
        private DataRow user = null;

        private void frmgiris_Load(object sender, EventArgs e)
        {
            txtKulAdi.Focus();

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            GirisViewModel admin = new GirisViewModel();
            admin.UserName = txtKulAdi.Text;
            admin.Password = txtSifre.Text;

            txtSifre.PasswordChar = '*';



            if (MessageHelper.BosKayitKontrol(admin) == true)
            {
                lblHata.Text = "Lütfen kullanıcı bilgilerinizi girin!";
                return;
            }
            else
            {


                try
                {

                    user = DBHelper.DataRowGetir(string.Format("select ID from Giris where UserName='{0}' and Password='{1}'", admin.UserName, admin.Password));


                }
                catch (Exception ex)
                {

                    MessageHelper.HataGoster(ex.Message);
                }

                if (user == null)
                {

                    lblHata.Text = "Kullanıcı adı veya parola hatalı!";

                    txtSifre.Focus();
                }
                else
                {
                    this.Hide();
                    new frmMain().Show();

                }

            }
        }
    }
}