using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.Entity.DTOs.Kampanya
{
    public class KampanyaToAddDTO
    {
        public bool KampanyaDurumu { get; set; }
        public int? SablonId { get; set; }
        public virtual string CreatedBy { get; set; } = "Undefined";
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
