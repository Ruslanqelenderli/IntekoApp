using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.DataAccess.Abstract
{
    public interface IGenericRepository<TModel,IdType>
    {
        List<TModel> GetAll();
        bool Create(TModel model);
        bool Update(TModel model);
        bool Remove(IdType id);
        TModel GetByID(IdType id);
    }
}
