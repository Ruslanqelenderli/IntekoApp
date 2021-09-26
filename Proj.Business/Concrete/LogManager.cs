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
    public class LogManager : ILogService
    {
        private readonly ILogRepository logRepository;
        public LogManager(ILogRepository logRepository)
        {
            this.logRepository = logRepository;
        }
        public bool Create(LogModel model)
        {
            var entity = new Log()
            {
                Id = Guid.NewGuid(),
                Description = model.Description,
                CreateDate = model.CreateDate
            };
            return logRepository.Create(entity);
        }

        public List<Log> GetAll()
        {
            return logRepository.GetAll();
        }
    }
}
