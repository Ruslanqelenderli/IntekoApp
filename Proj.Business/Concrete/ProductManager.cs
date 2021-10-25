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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        public void CheckPaid()
        {
            productRepository.CheckPaid();
        }

        public void CheckStatus()
        {
            productRepository.CheckStatus();
        }
        public bool Create(ProductModel model)
        {
            if (model != null)
            {
                Product entity = new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = model.Name,
                    CompanyName = model.CompanyName,
                    VoenPassword = model.VoenPassword,
                    District = model.District,
                    Address = model.Address,
                    ApproximateLocation = model.ApproximateLocation,
                    CashId = model.CashId,
                    EmployeeWhoConnects = model.EmployeeWhoConnects,
                    EmployeeWhoSells = model.EmployeeWhoSells,
                    PaymentId = model.PaymentId,
                    Price = model.Price,
                    ServicePrice = model.ServicePrice,
                    SellesPayment = model.SellesPayment,
                    WrittenByOrxan = model.WrittenByOrxan,
                    RegistrationDate = model.RegistrationDate,
                    InitialPayment = model.InitialPayment,
                    İnfo = model.İnfo,
                    PaymentStatus = ProductStatus.ThereIsTime.ToString(),
                    OfficeMncPercent = model.OfficeMncPercent
                    
                };
                
                if (model.InitialPayment == false)
                {
                    entity.PriceDebt = model.Price;
                }
                else
                {
                    entity.PriceDebt = 0;
                }

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
            return productRepository.GetByID(id);
        }

        public void Numbering()
        {
            productRepository.Numbering();
        }

        public bool PaidMethod(Guid id)
        {
            return productRepository.PaidMethod(id);
        }

        public bool Remove(Guid id)
        {
            return productRepository.Remove(id);
        }

        public bool SentMethod(Guid id,string monthName)
        {
            return productRepository.SentMethod(id,monthName);
        }

        public bool Update(Product model)
        {
            return productRepository.Update(model);
        }

        public bool Update(ProductModel model)
        {
            if (model != null)
            {
                Product product = new Product()
                {
                    Id = Static.Static.ProductIdForUpdate,
                    Name = model.Name,
                    CompanyName = model.CompanyName,
                    VoenPassword = model.VoenPassword,
                    District = model.District,
                    Address = model.Address,
                    ApproximateLocation = model.ApproximateLocation,
                    CashId = model.CashId,
                    EmployeeWhoConnects = model.EmployeeWhoConnects,
                    EmployeeWhoSells = model.EmployeeWhoSells,
                    PaymentId = model.PaymentId,
                    Price = model.Price,
                    ServicePrice = model.ServicePrice,
                    SellesPayment = model.SellesPayment,
                    WrittenByOrxan = model.WrittenByOrxan,
                    RegistrationDate = model.RegistrationDate,
                    InitialPayment = model.InitialPayment,
                    İnfo = model.İnfo,
                    PaymentStatus = model.PaymentStatus,
                    

                };
                return productRepository.Update(product);
            }
            return false;
        }
    }
}
