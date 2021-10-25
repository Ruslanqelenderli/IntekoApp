using Proj.Business.Abstract;
using Proj.Business.Models;
using Proj.DataAccess.Abstract;
using Proj.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Business.Concrete
{
    public class ExpenseManager : IExpenseService
    {
        private IExpenseRepository expenseRepsoitory;
        public ExpenseManager(IExpenseRepository expenseRepsoitory)
        {
            this.expenseRepsoitory = expenseRepsoitory;
        }
        public bool Create(ExpenseModel model)
        {
            if (model != null)
            {
                var entity = new Expense()
                {
                    Id=Guid.NewGuid(),
                    Description=model.Description,
                    CreateDate=model.CreateDate,
                    Price=model.Price,
                    Type=model.Type

                };
                return expenseRepsoitory.Create(entity);
            }
            return false;
        }

        public List<Expense> GetAll()
        {
            return expenseRepsoitory.GetAll();
        }

        public Expense GetByID(Guid id)
        {
            return expenseRepsoitory.GetByID(id);
        }

        

        public bool Remove(Guid id)
        {
            if (id != null)
            {
                return expenseRepsoitory.Remove(id);
            }
            return false;
        }

        public bool Update(Expense model)
        {
            if (model != null)
            {
                return expenseRepsoitory.Update(model);
            }
            return false;
        }
    }
}
