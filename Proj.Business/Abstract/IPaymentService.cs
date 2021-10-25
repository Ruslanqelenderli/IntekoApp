using Proj.Business.Models;
using Proj.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Business.Abstract
{
    public interface IPaymentService
    {
        List<Payment> GetAll();
        bool Create(PaymentModel model);
        bool Update(Payment entity);
        bool Remove(Guid id);
        Payment GetById(Guid id);
        Payment GetByName(string name);
    }
}
