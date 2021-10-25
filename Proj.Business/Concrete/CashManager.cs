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
    public class CashManager : ICashService
    {
        private readonly ICashRepository cashRepository;
        public CashManager(ICashRepository cashRepository)
        {
            this.cashRepository = cashRepository;
        }
        public bool Create(CashModel model)
        {
            if (model != null)
            {
                var entity = new Cash()
                {
                    Id = Guid.NewGuid(),
                    Name = model.Name
                };
                return cashRepository.Create(entity);
            }
            return false;
           
        }

        public List<Cash> GetAll()
        {
            return cashRepository.GetAll();
        }

        public Cash GetById(Guid id)
        {
            return cashRepository.GetById(id);
        }

        public Cash GetByName(string name)
        {
            return cashRepository.GetByName(name);
        }

        public bool Remove(Guid id)
        {
            if (id != null)
            {
                return cashRepository.Remove(id);
            }
            return false;
        }

        public bool Update(Cash entity)
        {
            if (entity != null)
            {
               
                return cashRepository.Update(entity);
            }
            return false;
        }
    }
}
