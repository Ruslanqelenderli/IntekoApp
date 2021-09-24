using Proj.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.DataAccess.Abstract
{
    public interface IPhoneRepository:IGenericRepository<Phone,Guid>
    {
    }
}
