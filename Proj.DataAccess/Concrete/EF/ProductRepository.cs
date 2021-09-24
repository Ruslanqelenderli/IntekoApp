using Proj.DataAccess.Abstract;
using Proj.DataAccess.Dal.Context;
using Proj.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.DataAccess.Concrete.EF
{
    public class ProductRepository : IProductRepository
    {
        public bool Create(Product model)
        {
            try
            {
                using (var db = new IntekoDbContext())
                {
                    db.Products.Add(model);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Product> GetAll()
        {
            try
            {
                using (var db = new IntekoDbContext())
                {
                    var products = new List<Product>();
                    products = db.Products.ToList();
                    return products;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Product GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Product model)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product model)
        {
            throw new NotImplementedException();
        }
    }
}
