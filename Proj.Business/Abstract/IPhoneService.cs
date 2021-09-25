using Proj.Business.Models;
using Proj.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Business.Abstract
{
    public interface IPhoneService:IGenericService<PhoneModel,Guid>
    {
        List<Phone> GetAll();
        Phone GetByID(Guid id);
        List<Phone> GetProductId(Guid id);
    }
}
