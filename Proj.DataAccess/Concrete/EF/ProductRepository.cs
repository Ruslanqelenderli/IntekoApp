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
        public void CheckPaid()
        {
            try
            {
                using (var db = new IntekoDbContext())
                {
                    var products = db.Products.Where(x => x.PaymentStatus == "Paid").ToList();
                    var date = DateTime.Now.Day;
                    if (date == 1)
                    {
                        foreach (var product in products)
                        {

                            product.PaymentStatus = "ThereIsTime";
                            db.Entry(product).State = EntityState.Modified;
                            db.SaveChanges();

                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CheckStatus()
        {
            try
            {
                using (var db =new IntekoDbContext())
                {
                    var products=db.Products.Where(x=>x.PaymentStatus!= "Sent" && x.PaymentStatus != "Paid").ToList();

                    foreach (var product in products)
                    {
                        var productDay=product.RegistrationDate.Day;
                        var now = DateTime.Now.Day;

                        if (productDay + 1 == now || productDay>=now)
                        {
                            product.PaymentStatus = "ItsTime";
                            db.Entry(product).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

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
            try
            {
                using (var db = new IntekoDbContext())
                {

                    var products = db.Products.FirstOrDefault(x => x.Id == id);
                    return products;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool PaidMethod(Guid id)
        {
            try
            {
                using (var db = new IntekoDbContext())
                {
                    var product = db.Products.FirstOrDefault(x => x.Id == id);
                    product.PaymentStatus = "Paid";
                    db.Entry(product).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Remove(Product model)
        {
            throw new NotImplementedException();
        }

        public bool SentMethod(Guid id)
        {
            try
            {
                using (var db=new IntekoDbContext())
                {
                    var product = db.Products.FirstOrDefault(x => x.Id == id);
                    product.PaymentStatus = "Sent";
                    db.Entry(product).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(Product model)
        {
            throw new NotImplementedException();
        }
    }
}
