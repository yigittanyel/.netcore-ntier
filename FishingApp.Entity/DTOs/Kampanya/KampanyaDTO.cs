using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.Entity.DTOs.Kampanya
{
    public class KampanyaDTO
    {
        public int Id { get; set; }
        public bool KampanyaDurumu { get; set; }
        public int? SablonId { get; set; }
    }
}
