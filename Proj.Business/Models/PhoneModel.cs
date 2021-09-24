using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Business.Models
{
    public class PhoneModel
    {
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public string Position { get; set; }
        public string Number { get; set; }
        public Guid ProductId { get; set; }
    }
}
