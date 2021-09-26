using Proj.DataAccess.Abstract;
using Proj.DataAccess.Dal.Context;
using Proj.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.DataAccess.Concrete.EF
{
    public class LogRepository : ILogRepository
    {
        public bool Create(Log model)
        {
            try
            {
                using (var db =new IntekoDbContext())
                {
                    db.Logs.Add(model);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Log> GetAll()
        {
            try
            {
                using (var db = new IntekoDbContext())
                {
                    return db.Logs.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
