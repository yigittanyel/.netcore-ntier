using FishingApp.Core.Primitives;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.Entity.Entities
{
    public class Sablon:BaseEntity<int>
    {
        [MaxLength(100)]
        public string SablonAdi { get; set; }
        public string İcerik { get; set; }
        public int? KullaniciId { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public int? GrupId { get; set; }
        public virtual Grup Grup { get; set; }
        public ICollection<Kampanya> Kampanyas { get; set; }
    }
}
