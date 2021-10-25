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
    public class PaymentManager : IPaymentService
    {
        private readonly IPaymentRepository paymentRepository;
        public PaymentManager(IPaymentRepository paymentRepository)
        {
            this.paymentRepository = paymentRepository;
        }
        public bool Create(PaymentModel model)
        {
            if (model != null)
            {
                var entity = new Payment()
                {
                    Id = Guid.NewGuid(),
                    Name = model.Name
                };
                return paymentRepository.Create(entity);
            }
            return false;

        }

        public List<Payment> GetAll()
        {
            return paymentRepository.GetAll();
        }

        public Payment GetById(Guid id)
        {
            return paymentRepository.GetById(id);
        }

        public Payment GetByName(string name)
        {
            return paymentRepository.GetByName(name);
        }

        public bool Remove(Guid id)
        {
            if (id != null)
            {
                return paymentRepository.Remove(id);
            }
            return false;
        }

        public bool Update(Payment entity)
        {
            if (entity != null)
            {

                return paymentRepository.Update(entity);
            }
            return false;
        }
    }
}
