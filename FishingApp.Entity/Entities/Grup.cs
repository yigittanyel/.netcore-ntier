using FishingApp.Core.Primitives;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.Entity.Entities
{
    public class Grup:BaseEntity<int>
    {
        [MaxLength(50)]
        public string GrupAdi { get; set; }
        public virtual ICollection<Kullanici> Kullanici { get; set; }

    }
}
