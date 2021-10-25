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
        void CheckStatus();
        void CheckPaid();
        bool SentMethod(Guid id,string monthName);
        bool PaidMethod(Guid id);

        bool Update(ProductModel model);
        bool Update(Product model);
        void Numbering();
    }
}
