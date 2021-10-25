using Proj.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Entity.Concrete
{
    public class Payment : BaseEntity, IBaseEntity<Guid>
    {
        public Payment()
        {
            Products = new HashSet<Product>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
