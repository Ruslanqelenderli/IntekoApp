using Proj.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Business.Static
{
    public static class Static
    {
        public static User User { get; set; }
        public static Expense Expense { get; set; }
        public static Guid Id { get; set; }
        public static Guid ProductIdForUpdate { get; set; }
        public static Guid ProductIdForDetails { get; set; }
        public static Guid ProductIdForPaid { get; set; }
        public static Guid CashId { get; set; }
        public static Guid PaymentId { get; set; }
    }
}
