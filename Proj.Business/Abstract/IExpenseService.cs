using Proj.Business.Models;
using Proj.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Business.Abstract
{
    public interface IExpenseService:IGenericService<ExpenseModel,Guid>
    {
        List<Expense> GetAll();
        Expense GetByID(Guid id);
        bool Update(Expense model);
    }
}
