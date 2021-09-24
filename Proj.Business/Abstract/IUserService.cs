using Proj.Business.Models;
using Proj.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Business.Abstract
{
    public interface IUserService:IGenericService<UserModel,Guid>
    {
        List<User> GetAll();
        User GetByID(Guid id);
    }
}
