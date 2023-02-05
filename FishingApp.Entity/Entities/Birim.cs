using FishingApp.Core.Primitives;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.Entity.Entities
{
    public class Birim : BaseEntity<int>
    {
        [MaxLength(50)]
        public string BirimAdi { get; set; }
        public virtual ICollection<Kullanici> Kullanicis { get; set; }
    }
}
