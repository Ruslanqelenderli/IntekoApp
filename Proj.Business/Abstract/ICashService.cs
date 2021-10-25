using Proj.Business.Models;
using Proj.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Business.Abstract
{
    public interface ICashService
    {
        List<Cash> GetAll();
        bool Create(CashModel model);
        bool Update(Cash entity);
        bool Remove(Guid id);
        Cash GetById(Guid id);
        Cash GetByName(string name);
    }
}
