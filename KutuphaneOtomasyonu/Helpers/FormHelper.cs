using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KutuphaneOtomasyonu.Helpers
{
    public static class FormHelper
    {
        
        private static void ShowDialog<TForm>(params object[] constructorArgs) 
            where TForm : DevExpress.XtraEditors.XtraForm 
        {   
            ((TForm)Activator.CreateInstance(typeof(TForm), constructorArgs)).ShowDialog();
        }
        public static void KitapEkle()
        {
            ShowDialog<Views.frmKitapEkleDuzenle>();
        }
        public static void KitapDuzenle(int kitapId)
        {
            ShowDialog<Views.frmKitapEkleDuzenle>(kitapId);
        }

        public static void OgrenciEkle()
        {
            ShowDialog<Views.frmOgrenciEkleDuzenle>();
        }
        public static void OgrenciDuzenle(int ogrenciId)
        {
            ShowDialog<Views.frmOgrenciEkleDuzenle>(ogrenciId);
        }
        public static void KitapOduncVerme()
        {
            ShowDialog<Views.frmKitapOdunc>();
        }
        public static void OgrenciListesi()
        {
            ShowDialog<Views.frmOgrenciListesi>();
        }

        public static void KitapListesi()
        {
            ShowDialog<Views.frmKitapListesi>();
        }

        public static void KitapOduncListesi()
        {
            ShowDialog<Views.frmOduncAlmaListesi>();
        }
        public static void FakulteEkle()
        {
            ShowDialog<Views.frmFakulteEkle>();
        }

        public static void BolumEkle()
        {
            ShowDialog<Views.frmBolumEkle>();
        }
    }
}
