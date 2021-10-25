using Proj.DataAccess.Abstract;
using Proj.DataAccess.Dal.Context;
using Proj.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.DataAccess.Concrete.EF
{
    public class CashRepository : ICashRepository
    {
        public bool Create(Cash entity)
        {
            try
            {
                using (var db=new IntekoDbContext())
                {
                    db.Cashes.Add(entity);
                    db.SaveChanges();
                    return true;

                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Cash> GetAll()
        {
            try
            {
                using (var db = new IntekoDbContext())
                {
                    
                    return db.Cashes.ToList();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Cash GetById(Guid id)
        {
            try
            {
                using (var db=new IntekoDbContext())
                {
                    var model = db.Cashes.FirstOrDefault(x => x.Id == id);
                    return model;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Cash GetByName(string name)
        {
            try
            {
                using (var db =new IntekoDbContext())
                {
                    var model = db.Cashes.FirstOrDefault(x => x.Name == name);
                    return model;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Remove(Guid id)
        {
            try
            {
                using (var db = new IntekoDbContext())
                {
                    var entity = db.Cashes.FirstOrDefault(x => x.Id == id);
                    db.Cashes.Remove(entity);
                    db.SaveChanges();
                    return true;

                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(Cash entity)
        {
            try
            {
                using (var db = new IntekoDbContext())
                {
                    db.Entry(entity).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;

                }

            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
