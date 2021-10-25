using Proj.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Entity.Concrete
{
    public class MonthlyPayment : BaseEntity, IBaseEntity<Guid>
    {
        public Guid Id { get; set; }
        public string MonthName { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public bool Paid { get; set; }
    }
}
