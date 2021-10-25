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
    public class ExpenseTypeRepository:IExpenseTypeRepository
    {
        public bool Create(Expensetyp model)
        {
            try
            {
                using (var db = new IntekoDbContext())
                {
                    db.ExpenseTypes.Add(model);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Expensetyp> GetAll()
        {
            try
            {
                using (var db = new IntekoDbContext())
                {
                    return db.ExpenseTypes.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Expensetyp GetByID(Guid id)
        {
            try
            {
                using (var db = new IntekoDbContext())
                {
                    return db.ExpenseTypes.FirstOrDefault(x => x.Id == id);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Remove(Guid id)
        {
            try
            {
                using (var db = new IntekoDbContext())
                {
                    var model = db.ExpenseTypes.FirstOrDefault(x => x.Id == id);
                    db.ExpenseTypes.Remove(model);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(Expensetyp model)
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
