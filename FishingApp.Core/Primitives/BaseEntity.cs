using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.Core.Primitives
{
    public abstract class BaseEntity<T> : IBaseEntity
    {
        [Key]
        public virtual T Id { get; set; }
        [MaxLength(50)]
        public virtual string CreatedBy { get; set; } = "Undefined";
        [MaxLength(50)]
        public virtual string? ModifiedBy { get; set; }
        [MaxLength(50)]
        public virtual string? DeletedBy { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual DateTime? DeletedDate { get; set; }
        public virtual bool IsDeleted { get; set; } = false;
    }
}
