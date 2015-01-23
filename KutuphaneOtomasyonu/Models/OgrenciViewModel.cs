using System;

namespace KutuphaneOtomasyonu.Models
{
    public class OgrenciViewModel
    {
        public int OgrenciId { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int FakulteId { get; set; }
        public int BolumId { get; set; }
        public string Adres { get; set; }
        public string MemleketAdres { get; set; }
        public DateTime KayitTarihi { get; set; }
        public string CepTelefonu { get; set; }

    }
}
