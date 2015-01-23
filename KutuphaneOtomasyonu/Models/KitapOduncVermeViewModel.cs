namespace KutuphaneOtomasyonu.Models
{
    using System;
    public class KitapOduncVermeViewModel
    {
        public int KitapOduncId { get; set; }
        public int KitapId { get; set; }
        public int OgrenciId { get; set; }
        public DateTime OduncVermeTarihi { get; set; }
        public DateTime GeriAlmaTarihi { get; set; }
    }
}
