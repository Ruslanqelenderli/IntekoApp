using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Business.Abstract
{
    public interface IGenericService<TModel,IdType>
    {
        
        bool Create(TModel model);
        bool Remove(IdType id);
        
    }
}
