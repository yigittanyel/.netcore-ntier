using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.Entity.DTOs.KampanyaSonuc
{
    public class KampanyaSonucToDeleteDTO
    {
        public bool KampanyaSonucDurum { get; set; }
        public bool Tikladi { get; set; }
        public bool VeriGirdi { get; set; }
        public int? KampanyaId { get; set; }
        public int? KullaniciId { get; set; }
        public virtual DateTime? DeletedDate { get; set; }
        public virtual string? DeletedBy { get; set; }
    }
}
