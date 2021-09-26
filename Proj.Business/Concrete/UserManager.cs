using Proj.Business.Abstract;
using Proj.Business.Enums;
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
    public class UserManager : IUserService
    {

        #region fields
        private readonly IUserRepository userRepository;
        #endregion


        #region constructor
        public UserManager(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        #endregion


        #region methods
        public bool Create(UserModel userModel)
        {
            if (userModel != null)
            {
                var model = new User();
                model.Id = Guid.NewGuid();
                model.Name = userModel.Name;
                model.Surname = userModel.Surname;
                model.UserName = userModel.UserName;
                model.Email = userModel.Email;
                model.PhoneNumber = userModel.PhoneNumber;
                model.Password = userModel.Password;
                model.Status = Status.Employee.ToString();

                return userRepository.Create(model);
            }
            return false;
           
        }

        public List<User> GetAll()
        {
            return userRepository.GetAll();
        }

        public User GetByID(Guid id)
        {
            return userRepository.GetByID(id);
        }

        public bool Remove(Guid id)
        {
            
                return userRepository.Remove(id);
            
        }

        public bool Update(UserModel userModel)
        {
            if (userModel != null)
            {
                var model = new User();
                model.Name = userModel.Name;
                model.Surname = userModel.Surname;
                model.UserName = userModel.UserName;
                model.Email = userModel.Email;
                model.PhoneNumber = userModel.PhoneNumber;
                model.Password = userModel.Password;
                model.Status = Status.Employee.ToString();
                return userRepository.Update(model);
            }
            return false;
        }
        #endregion

    }
}
