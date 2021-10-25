using Proj.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.DataAccess.Abstract
{
    public interface IPaymentRepository
    {
        List<Payment> GetAll();
        bool Create(Payment entity);
        bool Update(Payment entity);
        bool Remove(Guid id);
        Payment GetById(Guid id);
        Payment GetByName(string name);
    }
}
