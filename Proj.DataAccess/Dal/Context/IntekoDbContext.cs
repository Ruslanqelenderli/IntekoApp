using Proj.Entity.Concrete;
using System;
using System.Collections.Generic;
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
        public DbSet<Phone> Phone { get; set; }
    }
}
