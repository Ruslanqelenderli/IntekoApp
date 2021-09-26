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
    public class PhoneManager : IPhoneService
    {
        #region fields
        private readonly IPhoneRepository phoneRepository;
        #endregion

        #region constructor
        public PhoneManager(IPhoneRepository phoneRepository)
        {
            this.phoneRepository = phoneRepository;
        }
        #endregion
        public bool Create(PhoneModel model)
        {
            if (model != null)
            {
                Phone entity = new Phone()
                {
                    Id = Guid.NewGuid(),
                    EmployeeName = model.EmployeeName,
                    EmployeeSurname = model.EmployeeSurname,
                    Number = model.Number,
                    Position = model.Position,
                    ProductId = model.ProductId
                };
                return phoneRepository.Create(entity);
            }
            return false;
        }

        public List<Phone> GetAll()
        {
            throw new NotImplementedException();
        }

        public Phone GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Phone> GetProductId(Guid id)
        {
            return phoneRepository.GetProductId(id);
        }

        public bool Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(PhoneModel model)
        {
            throw new NotImplementedException();
        }
    }
}
