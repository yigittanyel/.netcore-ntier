using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.Entity.DTOs.Birim
{
    public class BirimToAddDTO
    {
        public string BirimAdi { get; set; }
        public virtual string CreatedBy { get; set; } = "Undefined";
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
