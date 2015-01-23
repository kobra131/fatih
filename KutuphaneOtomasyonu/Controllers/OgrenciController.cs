namespace KutuphaneOtomasyonu.Controllers
{
    using KutuphaneOtomasyonu.Helpers;
    using KutuphaneOtomasyonu.Models;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    public class OgrenciController
    {
        public List<FakulteViewModel> GetFakulteListesi()
        {
            string sql = string.Format("SELECT * FROM {0}", DBHelper.TableNames.Fakulteler);
            return DBHelper.SqlQueryList<FakulteViewModel>(sql);
        }
        public List<FakulteBolumViewModel> GetFakulteBolumListesi(int fakulteId)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE FakulteId=@p0", DBHelper.TableNames.FakulteBolumleri);
            return DBHelper.SqlQueryList<FakulteBolumViewModel>(sql, new SqlParameter("@p0", fakulteId));
        }
        public void OgrenciGuncelle(OgrenciViewModel model)
        {
            string sql = DBHelper.GetUpdateQuery(DBHelper.TableNames.Ogrenciler, new string[] { "Adi", "Soyadi", "FakulteId", "BolumId", "Adres", "MemleketAdres", "KayitTarihi", "CepTelefonu" }, "OgrenciId=@OgrenciId");
            var parameters = DBHelper.GetSqlParameters(model.Adi, model.Soyadi, model.FakulteId, model.BolumId, model.Adres, model.MemleketAdres, model.KayitTarihi, model.CepTelefonu).ToList();
            parameters.Add(new SqlParameter("@OgrenciId", model.OgrenciId));
            DBHelper.ExecuteCommand(sql, parameters.ToArray());
        }

        public void OgrenciEkle(OgrenciViewModel model)
        {
            string sql = DBHelper.GetInsertQuery(DBHelper.TableNames.Ogrenciler, new string[] { "Adi", "Soyadi", "FakulteId", "BolumId", "Adres", "MemleketAdres", "KayitTarihi", "CepTelefonu" });
            var parameters = DBHelper.GetSqlParameters(model.Adi, model.Soyadi, model.FakulteId, model.BolumId, model.Adres, model.MemleketAdres, model.KayitTarihi, model.CepTelefonu);
            DBHelper.ExecuteCommand(sql, parameters);
        }
        public OgrenciViewModel GetOgrenci(int ogrenciId)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE OgrenciId=@p0", DBHelper.TableNames.Ogrenciler);
            var parameters = DBHelper.GetSqlParameters(ogrenciId);
            return DBHelper.SqlQueryList<OgrenciViewModel>(sql, parameters).First();
        }
        public List<OgrenciViewModel> GetOgrenciListesi()
        {
            string sql = string.Format("SELECT * FROM {0}", DBHelper.TableNames.Ogrenciler);
            return DBHelper.SqlQueryList<OgrenciViewModel>(sql);
        }
        public List<OgrenciViewModel> GetOgrenciListesiLookUpEdit()
        {
            string sql = string.Format("SELECT OgrenciId, (Adi + ' ' + Soyadi) AS Adi FROM {0}", DBHelper.TableNames.Ogrenciler);
            return DBHelper.SqlQueryList<OgrenciViewModel>(sql);
        }
        public DataTable GetOgrenciListesi_Arama(OgrenciViewModel model)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE Adi LIKE @p0 AND Soyadi LIKE @p1 AND Adres LIKE @p2 AND MemleketAdres LIKE @p3 AND CepTelefonu LIKE @p4 ", DBHelper.TableNames.OgrenciListesiView);
            if (model.FakulteId > 0)
            {
                sql += string.Format("AND FakulteId={0} ", model.FakulteId);
            }
            if (model.BolumId > 0)
            {
                sql += string.Format("AND BolumId={0}", model.BolumId);
            }
            var parameters = DBHelper.GetSqlParameters(model.Adi, model.Soyadi, model.Adres, model.MemleketAdres, model.CepTelefonu);
            foreach (var param in parameters)
            {
                param.Value = string.Format("%{0}%", param.Value);
            }
            return DBHelper.SqlQueryDataTable(sql, parameters);
        }

        public void OgrenciSil(int ogrenciId)
        {
            string sql = string.Format("DELETE FROM {0} WHERE OgrenciId=@p0", DBHelper.TableNames.Ogrenciler);
            var parameters = DBHelper.GetSqlParameters(ogrenciId);
            DBHelper.ExecuteCommand(sql, parameters);

            sql = string.Format("DELETE FROM {0} WHERE OgrenciId=@p0", DBHelper.TableNames.KitapOduncVerme);
            parameters = DBHelper.GetSqlParameters(ogrenciId);
            DBHelper.ExecuteCommand(sql, parameters);
        }

        public void FakulteEkle(string fakulteAdi)
        {
            string sql = DBHelper.GetInsertQuery(DBHelper.TableNames.Fakulteler, new string[] { "FakulteAdi" });
            var parameters = DBHelper.GetSqlParameters(fakulteAdi);
            DBHelper.ExecuteCommand(sql, parameters);
        }

        public void BolumEkle(int fakulteId, string bolumAdi)
        {
            string sql = DBHelper.GetInsertQuery(DBHelper.TableNames.FakulteBolumleri, new string[] { "FakulteId", "BolumAdi" });
            var parameters = DBHelper.GetSqlParameters(fakulteId, bolumAdi);
            DBHelper.ExecuteCommand(sql, parameters);
        }
    }
}
