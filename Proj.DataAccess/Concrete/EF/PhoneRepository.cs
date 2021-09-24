﻿using Proj.DataAccess.Abstract;
using Proj.DataAccess.Dal.Context;
using Proj.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.DataAccess.Concrete.EF
{
    public class PhoneRepository : IPhoneRepository
    {
        public bool Create(Phone model)
        {
            try
            {
                using (var db = new IntekoDbContext())
                {
                    db.Phone.Add(model);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Phone> GetAll()
        {
            throw new NotImplementedException();
        }

        public Phone GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Phone model)
        {
            throw new NotImplementedException();
        }

        public bool Update(Phone model)
        {
            throw new NotImplementedException();
        }
    }
}
