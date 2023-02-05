using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.Entity.DTOs.KampanyaSonuc
{
    public class KampanyaSonucToUpdateDTO
    {
        public int Id { get; set; }
        public bool KampanyaSonucDurum { get; set; }
        public bool Tikladi { get; set; }
        public bool VeriGirdi { get; set; }
        public int? KampanyaId { get; set; }
        public int? KullaniciId { get; set; }
        public virtual string? ModifiedBy { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
    }
}
