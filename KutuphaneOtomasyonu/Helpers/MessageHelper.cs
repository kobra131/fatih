using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Helpers
{
    public static class MessageHelper
    {
        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Uygulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowInformation(string message)
        {
            MessageBox.Show(message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static bool ShowQuestion(string message)
        {
            return MessageBox.Show(message, "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
        public static bool BosKayitKontrol(Object referansObje)
        {
            bool HataYakala = false;


            foreach (PropertyInfo info in referansObje.GetType().GetProperties())
            {

                if (info.GetValue(referansObje, null) == null || string.IsNullOrEmpty(info.GetValue(referansObje, null).ToString()))
                    HataYakala = true;

            }
            return HataYakala;
        }
        public static void HataGoster(string hataMesaji)
        {

            MessageBox.Show(hataMesaji, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

    }
}
