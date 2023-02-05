using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.Entity.DTOs.Kullanici
{
    public class KullaniciToDeleteDTO
    {
        public string KullaniciAdi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string PersonelKodu { get; set; }
        public string Eposta { get; set; }
        public string Sifre { get; set; }
        public string Rol { get; set; }
        public int? BirimId { get; set; }
        public virtual DateTime? DeletedDate { get; set; }
        public virtual string? DeletedBy { get; set; }
    }
}
