using Proj.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Entity.Concrete
{
    public class Expensetyp : BaseEntity, IBaseEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
