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
    public class ExpenseRepository : IExpenseRepository
    {
        public bool Create(Expense model)
        {
            try
            {
                using (var db=new IntekoDbContext())
                {
                    db.Expenses.Add(model);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Expense> GetAll()
        {
            try
            {
                using (var db = new IntekoDbContext())
                {
                    return db.Expenses.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Expense GetByID(Guid id)
        {
            try
            {
                using (var db = new IntekoDbContext())
                {
                    return db.Expenses.FirstOrDefault(x => x.Id == id);
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
                    var model = db.Expenses.FirstOrDefault(x => x.Id==id);
                    db.Expenses.Remove(model);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(Expense model)
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
