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
    public class ExpenseTypeManager : IExpenseTypeService
    {
        private IExpenseTypeRepository expenseTypeRepsoitory;
        public ExpenseTypeManager(IExpenseTypeRepository expenseTypeRepsoitory)
        {
            this.expenseTypeRepsoitory = expenseTypeRepsoitory;
        }
        public bool Create(ExpenseTypeModel model)
        {
            if (model != null)
            {
                var entity = new Expensetyp()
                {
                    Id = Guid.NewGuid(),
                    Name = model.Name

                };
                return expenseTypeRepsoitory.Create(entity);
            }
            return false;
        }

        public List<Expensetyp> GetAll()
        {
            return expenseTypeRepsoitory.GetAll();
        }

        public Expensetyp GetByID(Guid id)
        {
            return expenseTypeRepsoitory.GetByID(id);
        }


        public bool Remove(Guid id)
        {
            if (id != null)
            {
                return expenseTypeRepsoitory.Remove(id);
            }
            return false;
        }

        public bool Update(Expensetyp model)
        {
            if (model != null)
            {
                return expenseTypeRepsoitory.Update(model);
            }
            return false;
        }
    }
}
