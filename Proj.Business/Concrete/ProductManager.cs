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
    public class ProductManager : IProductService
    {
        #region fields
        private readonly IProductRepository productRepository;
        #endregion

        #region constructor
        public ProductManager(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        #endregion
        public bool Create(ProductModel model)
        {
            if (model != null)
            {
                Product entity = new Product()
                {
                    Id=Guid.NewGuid(),
                    Name = model.Name,
                    Surname = model.Surname,
                    CompanyName = model.CompanyName,
                    VoenPassword=model.VoenPassword,
                    District=model.District,
                    Address=model.Address,
                    ApproximateLocation=model.ApproximateLocation,
                    CashireModel=model.CashireModel,
                    ContractNO=model.ContractNO,
                    EmployeeWhoConnects=model.EmployeeWhoConnects,
                    EmployeeWhoSells=model.EmployeeWhoSells,
                    TypeOfPayment=model.TypeOfPayment,
                    Price=model.Price,
                    ServicePrice=model.ServicePrice,
                    SellesPayment=model.SellesPayment,
                    WrittenByOrxan=model.WrittenByOrxan,
                    TaxInterest=model.TaxInterest,
                    RegistrationDate=model.RegistrationDate,
                    InitialPayment=model.InitialPayment,
                    İnfo=model.İnfo,
                    PaymentStatus=ProductStatus.ThereIsTime.ToString()
                    

                };
                return productRepository.Create(entity);
            }
            return false;
        }

        public List<Product> GetAll()
        {
            return productRepository.GetAll();
        }

        public Product GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(ProductModel model)
        {
            throw new NotImplementedException();
        }

        public bool Update(ProductModel model)
        {
            throw new NotImplementedException();
        }
    }
}
