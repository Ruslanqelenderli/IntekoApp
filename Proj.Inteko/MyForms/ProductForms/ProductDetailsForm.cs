using Proj.Business.Abstract;
using Proj.Business.Concrete;
using Proj.Business.Static;
using Proj.DataAccess.Concrete.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj.Inteko.MyForms.ProductForms
{
    public partial class ProductDetailsForm : Form
    {
        IMonthlyPaymentService monthlyPayment = new MonthlyPaymentManager(new MonthlyPaymentRepository());
        public ProductDetailsForm()
        {
            InitializeComponent();
        }

        private void ProductDetailsForm_Load(object sender, EventArgs e)
        {
            GetProductDetails(Static.ProductIdForDetails);
        }

        private void GetProductDetails(Guid id)
        {
            
            var details = monthlyPayment.GetByProductId(id).Select(x => new
            {
                Müəssisənin_adı=x.Product.CompanyName,
                Ay=x.MonthName,
                Ödəmə= Payment(x.Paid)
            }).ToList();

             string Payment(bool result)
            {
                string paid;
                if (result)
                {
                    paid = "Ödənilib";
                    return paid;
                }
                else
                {
                    paid = "Ödənilməyib";
                    return paid;
                }
            }
            dgv_Details.DataSource = details;

        }
    }
}
