using Proj.Business.Models;
using Proj.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Business.Abstract
{
    public interface IExpenseTypeService:IGenericService<ExpenseTypeModel,Guid>
    {
        List<Expensetyp> GetAll();
        Expensetyp GetByID(Guid id);
        bool Update(Expensetyp model);
    }
}
