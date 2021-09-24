using Proj.Business.Models;
using Proj.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Business.Abstract
{
   public  interface IProductService:IGenericService<ProductModel,Guid>
    {
        List<Product> GetAll();
        Product GetByID(Guid id);
    }
}
