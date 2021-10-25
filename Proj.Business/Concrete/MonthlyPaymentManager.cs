using Proj.Business.Abstract;
using Proj.Business.Models;
using Proj.DataAccess.Abstract;
using Proj.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Business.Concrete
{
    public class MonthlyPaymentManager : IMonthlyPaymentService
    {
        private readonly IMonthlyPaymentRepository monthlyPaymentRepository;
        public MonthlyPaymentManager(IMonthlyPaymentRepository monthlyPaymentRepository)
        {
            this.monthlyPaymentRepository = monthlyPaymentRepository;
        }
        public bool Create(MonthlyPaymentModel model)
        {

            var entity = new MonthlyPayment()
            {
                Id = Guid.NewGuid(),
                MonthName = model.MonthName,
                Paid = model.Paid,
                ProductId = model.ProductId
            };
            return monthlyPaymentRepository.Create(entity);
        }

        public MonthlyPayment GetById(Guid monthlyPaymentId)
        {
            return monthlyPaymentRepository.GetById(monthlyPaymentId);
        }

        public List<MonthlyPayment> GetByProductId(Guid productId)
        {
            return monthlyPaymentRepository.GetByProductId(productId);
        }

        public List<MonthlyPayment> GetUnPaidPayments(Guid productİd)
        {
            return monthlyPaymentRepository.GetUnPaidPayments(productİd);
        }

        public bool UpdatePaidStatus(Guid monthlyPaymentId)
        {
            return monthlyPaymentRepository.UpdatePaidStatus(monthlyPaymentId);
        }
    }
}
