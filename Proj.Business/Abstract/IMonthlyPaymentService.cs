using Proj.Business.Models;
using Proj.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Business.Abstract
{
    public interface IMonthlyPaymentService
    {
        bool Create(MonthlyPaymentModel model);
        List<MonthlyPayment> GetUnPaidPayments(Guid productİd);
        bool UpdatePaidStatus(Guid monthlyPaymentId);
        MonthlyPayment GetById(Guid monthlyPaymentId);
        List<MonthlyPayment> GetByProductId(Guid productId);
    }
}
