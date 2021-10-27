using Proj.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Entity.Concrete
{
    public class Cash : BaseEntity, IBaseEntity<Guid>
    {
        public Cash()
        {
            Products = new HashSet<Product>();
        }
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
