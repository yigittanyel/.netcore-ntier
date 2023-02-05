using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.Entity.DTOs.Kampanya
{
    public class KampanyaToUpdateDTO
    {
        public bool KampanyaDurumu { get; set; }
        public int? SablonId { get; set; }
        public virtual string? ModifiedBy { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
    }
}
