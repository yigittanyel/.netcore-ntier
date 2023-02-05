using FishingApp.Core.Primitives;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.Entity.Entities
{
    public class Kullanici:BaseEntity<int>
    {
        [MaxLength(50)]
        public string KullaniciAdi { get; set; }
        [MaxLength(50)]
        public string Ad { get; set; }
        [MaxLength(50)]
        public string Soyad { get; set; }
        [MaxLength(20)]
        public string PersonelKodu { get; set; }
        [MaxLength(50)]
        public string Eposta { get; set; }
        [MaxLength(50)]
        public string Sifre { get; set; }
        [MaxLength(10)]
        public string Rol { get; set; }
        public int? BirimId { get; set; }
        public virtual Birim Birim { get; set; }
        public virtual ICollection<Grup> Grups { get; set; }
    }
}
