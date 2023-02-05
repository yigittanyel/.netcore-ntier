using FishingApp.Core.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.Entity.Entities
{
    public class KampanyaSonuc:BaseEntity<int>
    {
        public bool KampanyaSonucDurum { get; set; }
        public bool Tikladi { get; set; }
        public bool VeriGirdi { get; set; }
        public int? KampanyaId { get; set; }
        public virtual Kampanya Kampanya { get; set; }
        public int? KullaniciId { get; set; }
        public virtual Kullanici Kullanici { get; set; }

    }
}
