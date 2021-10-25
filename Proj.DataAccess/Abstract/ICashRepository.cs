using Proj.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.DataAccess.Abstract
{
    public interface ICashRepository
    {
        List<Cash> GetAll();
        bool Create(Cash entity);
        bool Update(Cash entity);
        bool Remove(Guid id);
        Cash GetById(Guid id);
        Cash GetByName(string name);
    }
}
