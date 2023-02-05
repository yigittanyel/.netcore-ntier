using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.Entity.DTOs.Grup
{
    public class GrupToUpdateDTO
    {
        public int Id { get; set; }
        public string GrupAdi { get; set; }
        public virtual string? ModifiedBy { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
    }
}
