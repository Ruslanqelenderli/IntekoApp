using Proj.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Entity.Concrete
{
    public class Product : BaseEntity, IBaseEntity<Guid>
    {
        public Product()
        {
            Phones = new HashSet<Phone>();
            MonthlyPayments = new HashSet<MonthlyPayment>();
        }
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string  CompanyName { get; set; }
        public string  VoenPassword { get; set; }
        public string  District { get; set; }
        public string  Address { get; set; }
        public string  ApproximateLocation { get; set; }
        public Guid CashId { get; set; }
        public Cash Cash { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int  ContractNO { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string EmployeeWhoConnects { get; set; }
        public string EmployeeWhoSells { get; set; }
        public Guid PaymentId { get; set; }
        public Payment Payment { get; set; }
        public decimal Price { get; set; }
        public decimal ServicePrice { get; set; }
        public decimal SellesPayment { get; set; }
        public decimal WrittenByOrxan { get; set; }
        public string  İnfo { get; set; }
        public string PaymentStatus { get; set; }
        public bool InitialPayment { get; set; }
        public decimal OfficeMncPercent { get; set; }
        public decimal PriceDebt { get; set; }
        public DateTime? SendDate { get; set; }
        public int UnpaidMonths { get; set; }
        public int? No { get; set; }
        public IEnumerable<Phone> Phones { get; set; }
        public IEnumerable<MonthlyPayment> MonthlyPayments { get; set; }
       



        }
}
