using Proj.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Entity.Concrete
{
    public class Phone:BaseEntity,IBaseEntity<Guid>
    {
        
        public Guid Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public string Position { get; set; }
        public string Number { get; set; }
        public Product Product { get; set; }
        public Guid ProductId { get; set; }
    }
}
