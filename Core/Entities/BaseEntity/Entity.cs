using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.BaseEntity
{
    public class Entity<TIndex>
    {
        public TIndex Id { get; set; }
        public DateTime CreateDate { get; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }
        public bool Status { get; set; }

    }
}
