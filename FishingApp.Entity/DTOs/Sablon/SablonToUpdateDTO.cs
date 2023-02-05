using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.Entity.DTOs.Sablon
{
    public class SablonToUpdateDTO
    {
        public string SablonAdi { get; set; }
        public string İcerik { get; set; }
        public int? KullaniciId { get; set; }
        public int? GrupId { get; set; }
        public virtual string? ModifiedBy { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
    }
}
