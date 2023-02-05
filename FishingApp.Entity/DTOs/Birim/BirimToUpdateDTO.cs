using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.Entity.DTOs.Birim
{
    public class BirimToUpdateDTO
    {
        public int Id { get; set; }
        public string BirimAdi { get; set; }
        public virtual string? ModifiedBy { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
    }
}
