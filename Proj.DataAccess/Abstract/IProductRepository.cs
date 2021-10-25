using Proj.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.DataAccess.Abstract
{
    public interface IProductRepository:IGenericRepository<Product,Guid>
    {
        void CheckStatus();
        void CheckPaid();
        bool SentMethod(Guid id,string monthName);
        bool PaidMethod(Guid id);
        void Numbering();
    }
}
