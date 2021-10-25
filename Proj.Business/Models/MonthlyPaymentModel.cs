using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Business.Models
{
    public class MonthlyPaymentModel
    {
        public string MonthName { get; set; }
        public Guid ProductId { get; set; }
        public bool Paid { get; set; }
    }
}
