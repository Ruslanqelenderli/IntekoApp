using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Business.Models
{
    public class ProductModel
    {
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string VoenPassword { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string ApproximateLocation { get; set; }
        public Guid CashId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string EmployeeWhoConnects { get; set; }
        public string EmployeeWhoSells { get; set; }
        public Guid PaymentId { get; set; }
        public decimal Price { get; set; }
        public decimal ServicePrice { get; set; }
        public decimal SellesPayment { get; set; }
        public decimal WrittenByOrxan { get; set; }
        public string İnfo { get; set; }
        public string PaymentStatus { get; set; }
        public decimal OfficeMncPercent { get; set; }
        public bool InitialPayment { get; set; }
        public decimal PriceDept { get; set; }
        public int? ContratNo { get; set; }
    }
}
