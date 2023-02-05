using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.Entity.DTOs.Grup
{
    public class GrupToDeleteDTO
    {
        public string GrupAdi { get; set; }
        public virtual DateTime? DeletedDate { get; set; }
        public virtual string? DeletedBy { get; set; }
    }
}
