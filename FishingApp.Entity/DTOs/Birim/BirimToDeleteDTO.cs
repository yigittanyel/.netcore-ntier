using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.Entity.DTOs.Birim
{
    public class BirimToDeleteDTO
    {
        public string BirimAdi { get; set; }
        public virtual DateTime? DeletedDate { get; set; }
        public virtual string? DeletedBy { get; set; }
    }
}
