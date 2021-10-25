using Proj.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Entity.Concrete
{
    public class Expense:BaseEntity,IBaseEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
