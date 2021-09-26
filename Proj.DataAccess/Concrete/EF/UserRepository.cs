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
    public class UserRepository : IUserRepository
    {
        
        public bool Create(User model)
        {
            try
            {
                using (var db = new IntekoDbContext())
                {
                    db.Users.Add(model);
                    db.SaveChanges();
                    return true;
                }
                
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public List<User> GetAll()
        {
            try
            {
                using (var db = new IntekoDbContext())
                {
                    var users = new List<User>();
                    users = db.Users.ToList();
                    return users;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public User GetByID(Guid id)
        {
            try
            {
                using (var db = new IntekoDbContext())
                {
                    var user = new User();
                    user = db.Users.FirstOrDefault(x => x.Id == id);
                    return user;
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
                    var model = db.Users.FirstOrDefault(x => x.Id == id);
                    db.Users.Remove(model);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(User model)
        {
            try
            {
                using (var db = new IntekoDbContext())
                {
                    db.Entry(model).State = EntityState.Modified;
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
