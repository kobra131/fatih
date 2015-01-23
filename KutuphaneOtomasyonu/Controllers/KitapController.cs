using KutuphaneOtomasyonu.Helpers;
using KutuphaneOtomasyonu.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace KutuphaneOtomasyonu.Controllers
{
    public class KitapController
    {
        public void KitapEkle(KitapViewModel model)
        {
            string sql = DBHelper.GetInsertQuery(DBHelper.TableNames.Kitaplar, new string[] { "Kategori", "KitapKodu", "KitapAdi", "YayinYili", "Yazari", "ISBNNumarasi", "SayfaSayisi", "AnahtarKelimeler" });
            var parameters = DBHelper.GetSqlParameters(model.Kategori, model.KitapKodu, model.KitapAdi, model.YayinYili, model.Yazari, model.ISBNNumarasi, model.SayfaSayisi, model.AnahtarKelimeler);
            DBHelper.ExecuteCommand(sql, parameters);
        }

        public void KitapGuncelle(KitapViewModel model)
        {
            string sql = DBHelper.GetUpdateQuery(DBHelper.TableNames.Kitaplar, new string[] { "Kategori", "KitapKodu", "KitapAdi", "YayinYili", "Yazari", "ISBNNumarasi", "SayfaSayisi", "AnahtarKelimeler" }, "KitapId=@KitapId");
            var parameters = DBHelper.GetSqlParameters(model.Kategori, model.KitapKodu, model.KitapAdi, model.YayinYili, model.Yazari, model.ISBNNumarasi, model.SayfaSayisi, model.AnahtarKelimeler).ToList();
            parameters.Add(new SqlParameter("@KitapId", model.KitapId));
            DBHelper.ExecuteCommand(sql, parameters.ToArray());

        }
        public List<KitapViewModel> GetKitapListesiOduncVerilmemisler()
        {
            string sql = string.Format("SELECT KitapId, KitapAdi FROM {0} WHERE KitapId NOT IN (SELECT KitapId FROM {1} WHERE TeslimAlindi=0)", DBHelper.TableNames.Kitaplar, DBHelper.TableNames.KitapOduncVerme);
            return DBHelper.SqlQueryList<KitapViewModel>(sql);
        }

        public bool KitapOduncOgrenciKontrol(int ogrenciId)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE OgrenciId=@p0 AND TeslimAlindi=0", DBHelper.TableNames.KitapOduncVerme);
            using (var table = DBHelper.SqlQueryDataTable(sql, new SqlParameter("@p0", ogrenciId)))
            {
                return table.Rows.Count == 0;
            }
        }
        public void KitapOduncVer(int ogrenciId, int kitapId, DateTime teslimAlmaTarihi)
        {
            string sql = DBHelper.GetInsertQuery(DBHelper.TableNames.KitapOduncVerme, new string[] { "KitapId", "OgrenciId", "OduncVermeTarihi", "TeslimAlindi", "TeslimAlinmaTarihi" });
            var parameters = DBHelper.GetSqlParameters(kitapId, ogrenciId, DateTime.Now, false, teslimAlmaTarihi);
            DBHelper.ExecuteCommand(sql, parameters);
        }
        public KitapViewModel GetKitap(int kitapId)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE KitapId=@p0", DBHelper.TableNames.Kitaplar);
            var parameters = DBHelper.GetSqlParameters(kitapId);
            return DBHelper.SqlQueryList<KitapViewModel>(sql, parameters).First();
        }
        public List<KitapViewModel> GetKitapListesi_Arama(KitapViewModel model)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE Kategori LIKE @p0 AND KitapKodu LIKE @p1 AND KitapAdi LIKE @p2 AND YayinYili LIKE @p3 AND Yazari LIKE @p4 AND ISBNNumarasi LIKE @p5 AND SayfaSayisi LIKE @p6 AND AnahtarKelimeler LIKE @p7", DBHelper.TableNames.Kitaplar);
            var parameters = DBHelper.GetSqlParameters(model.Kategori, model.KitapKodu, model.KitapAdi, model.YayinYili, model.Yazari, model.ISBNNumarasi, model.SayfaSayisi, model.AnahtarKelimeler);
            foreach (var param in parameters)
            {
                if (param.ParameterName == "@p6" && param.Value.ToString() == "0")
                {
                    param.Value = string.Empty;
                }
                param.Value = string.Format("%{0}%", param.Value);
            }
            return DBHelper.SqlQueryList<KitapViewModel>(sql, parameters);
        }

        public void KitapSil(int kitapId)
        {
            string sql = string.Format("DELETE FROM {0} WHERE KitapId=@p0", DBHelper.TableNames.Kitaplar);
            var parameters = DBHelper.GetSqlParameters(kitapId);
            DBHelper.ExecuteCommand(sql, parameters);

            sql = string.Format("DELETE FROM {0} WHERE KitapId=@p0", DBHelper.TableNames.KitapOduncVerme);
            parameters = DBHelper.GetSqlParameters(kitapId);
            DBHelper.ExecuteCommand(sql, parameters);
        }

        public DataTable GetOduncListesi(string adi, string soyadi, string kitapKodu, string kitapAdi, string isbn, byte teslimDurumu)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE Adi LIKE @p0 AND Soyadi LIKE @p1 AND KitapKodu LIKE @p2 AND KitapAdi LIKE @p3 AND ISBNNumarasi LIKE @p4", DBHelper.TableNames.KitapOduncVermeView);
            var parameters = DBHelper.GetSqlParameters(adi, soyadi, kitapKodu, kitapAdi, isbn).ToList();
            foreach (var param in parameters)
            {
                param.Value = string.Format("%{0}%", param.Value);
            }
            if (teslimDurumu > 0)
            {
                sql += " AND TeslimAlindi=@p5";
                parameters.Add(new SqlParameter("@p5", teslimDurumu == 1 ? true : false));
            }
            return DBHelper.SqlQueryDataTable(sql, parameters.ToArray());
        }

        public void TeslimAl(int oduncId)
        {
            string sql = DBHelper.GetUpdateQuery(DBHelper.TableNames.KitapOduncVerme, new string[] { "TeslimAlindi", }, "KitapOduncId=@p1");
            var parameters = DBHelper.GetSqlParameters(true, oduncId);
            DBHelper.ExecuteCommand(sql, parameters);
        }

        public void TeslimAlmayiIptalEt(int oduncId)
        {
            string sql = DBHelper.GetUpdateQuery(DBHelper.TableNames.KitapOduncVerme, new string[] { "TeslimAlindi", }, "KitapOduncId=@p1");
            var parameters = DBHelper.GetSqlParameters(false, oduncId);
            DBHelper.ExecuteCommand(sql, parameters);
        }

        public void OduncVermeyiSil(int oduncId)
        {
            string sql = string.Format("DELETE FROM {0} WHERE KitapOduncId=@p0", DBHelper.TableNames.KitapOduncVerme);
            var parameters = DBHelper.GetSqlParameters(oduncId);
            DBHelper.ExecuteCommand(sql, parameters);
        }
    }
}