using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.Entity.DTOs.Kampanya
{
    public class KampanyaToDeleteDTO
    {
        public bool KampanyaDurumu { get; set; }
        public int? SablonId { get; set; }
        public virtual DateTime? DeletedDate { get; set; }
        public virtual string? DeletedBy { get; set; }
    }
}
