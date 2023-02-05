using FishingApp.Core.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.Entity.Entities
{
    public class Kampanya:BaseEntity<int>
    {
        public bool KampanyaDurumu { get; set; }
        public int? SablonId { get; set; }
        public virtual Sablon Sablon { get; set; }
    }
}
