using Proj.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.DataAccess.Dal.Context
{
    public class IntekoDbContext:DbContext
    {
        public IntekoDbContext() : base("myDb") { }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Expensetyp> ExpenseTypes { get; set; }
        public DbSet<MonthlyPayment> MonthlyPayments { get; set; }
        public DbSet<Cash> Cashes { get; set; }
        public DbSet<Payment> Payments { get; set; }




    }
}
