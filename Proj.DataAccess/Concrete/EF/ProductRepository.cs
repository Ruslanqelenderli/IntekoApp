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
                    var products=db.Products.Where(x=>x.PaymentStatus!= "Sent" ).Where(x=>x.PaymentStatus != "Paid").ToList();

                    foreach (var product in products)
                    {
                        var productDay=product.RegistrationDate.Day;
                        var productMonth=product.RegistrationDate.Month;
                        var now = DateTime.Now.Day;
                        var nowMonth = DateTime.Now.Month;

                        if ((productDay + 1 == now || productDay>=now)&&productMonth!=nowMonth)
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
                    products = db.Products.Include("Payment").Include("Cash").ToList();
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

        public void Numbering()
        {
            try
            {
                using (var db =new IntekoDbContext())
                {
                    var products = db.Products.OrderBy(x=>x.ContractNO).ToList();
                    int count = 1;
                    foreach (var product in products)
                    {
                        product.No = count;
                        count++;
                    }
                    db.SaveChanges();
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

        public bool Remove(Guid id)
        {
            try
            {
                using (var db = new IntekoDbContext())
                {
                    var product = db.Products.FirstOrDefault(x => x.Id == id);
                    db.Products.Remove(product);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool SentMethod(Guid id,string monthName)
        {
            try
            {
                using (var db=new IntekoDbContext())
                {
                    var product = db.Products.FirstOrDefault(x => x.Id == id);
                    product.PaymentStatus = "Sent";
                    product.SendDate = DateTime.Now;
                    var model = new MonthlyPayment()
                    {
                        Id = Guid.NewGuid(),
                        MonthName=monthName,
                        ProductId=product.Id,
                        Paid=false
                    };

                    db.MonthlyPayments.Add(model);
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
            try
            {
                using (var db = new IntekoDbContext())
                {
                    
                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
