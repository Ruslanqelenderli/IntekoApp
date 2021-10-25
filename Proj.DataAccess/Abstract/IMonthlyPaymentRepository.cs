using Proj.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.DataAccess.Abstract
{
    public interface IMonthlyPaymentRepository
    {
        bool Create(MonthlyPayment model);
        List<MonthlyPayment> GetUnPaidPayments(Guid productİd);
        bool UpdatePaidStatus(Guid monthlyPaymentId);
        MonthlyPayment GetById(Guid monthlyPaymentId);
        List<MonthlyPayment> GetByProductId(Guid productId);
    }
}
