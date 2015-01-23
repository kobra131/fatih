namespace KutuphaneOtomasyonu.Models
{
    public class KitapViewModel
    {
        public int KitapId { get; set; }
        public string Kategori { get; set; }
        public string KitapKodu { get; set; }
        public string KitapAdi { get; set; }
        public string YayinYili { get; set; }
        public string Yazari { get; set; }
        public string ISBNNumarasi { get; set; }
        public int SayfaSayisi { get; set; }
        public string AnahtarKelimeler { get; set; }
    }
}
