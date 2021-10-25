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
    public class MonthlyPaymentRepository : IMonthlyPaymentRepository
    {
        public bool Create(MonthlyPayment model)
        {
            try
            {
                using (var db = new IntekoDbContext())
                {
                    db.MonthlyPayments.Add(model);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public MonthlyPayment GetById(Guid monthlyPaymentId)
        {
            try
            {
                using (var db=new IntekoDbContext())
                {
                   return db.MonthlyPayments.FirstOrDefault(x => x.Id==monthlyPaymentId);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<MonthlyPayment> GetByProductId(Guid productId)
        {
            try
            {
                using (var db = new IntekoDbContext())
                {
                    return db.MonthlyPayments.Include("Product").Where(x => x.ProductId == productId).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<MonthlyPayment> GetUnPaidPayments(Guid productİd)
        {
            try
            {
                using (var db = new IntekoDbContext())
                {
                    
                    return db.MonthlyPayments.Include("Product").Where(x=>x.ProductId==productİd && x.Paid==false).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool UpdatePaidStatus(Guid monthlyPaymentId)
        {
            try
            {
                using (var db = new IntekoDbContext())
                {
                    var entity =db.MonthlyPayments.FirstOrDefault(x => x.Id == monthlyPaymentId);
                    entity.Paid = true;
                    db.Entry(entity).State = EntityState.Modified;
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
