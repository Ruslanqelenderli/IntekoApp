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
    public class PaymentRepository : IPaymentRepository
    {
        public bool Create(Payment entity)
        {
            try
            {
                using (var db = new IntekoDbContext())
                {
                    db.Payments.Add(entity);
                    db.SaveChanges();
                    return true;

                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Payment> GetAll()
        {
            try
            {
                using (var db = new IntekoDbContext())
                {

                    return db.Payments.ToList();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Payment GetById(Guid id)
        {
            try
            {
                using (var db =new IntekoDbContext())
                {
                    var entity = db.Payments.FirstOrDefault(x => x.Id == id);
                    return entity;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Payment GetByName(string name)
        {
            try
            {
                using (var db=new IntekoDbContext())
                {
                    var model = db.Payments.FirstOrDefault(x => x.Name == name);
                    return model;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Remove(Guid  id)
        {
            try
            {
                using (var db = new IntekoDbContext())
                {
                    var entity=db.Payments.FirstOrDefault(x => x.Id == id);
                    db.Payments.Remove(entity);
                    db.SaveChanges();
                    return true;

                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(Payment entity)
        {
            try
            {
                using (var db = new IntekoDbContext())
                {
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
