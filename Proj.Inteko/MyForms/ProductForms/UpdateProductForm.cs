using Proj.Business.Abstract;
using Proj.Business.Concrete;
using Proj.Business.Models;
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
    public partial class UpdateProductForm : Form
    {
        IProductService iProductService = new ProductManager(new ProductRepository());
        public UpdateProductForm()
        {
            InitializeComponent();
        }
        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            FillTextBox();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var model = iProductService.GetByID(Static.ProductİdForUpdate);
            bool initialPaymentStatus=false;
            if (rb_Paid.Checked == true)
            {
               initialPaymentStatus= true;
            }
           
            ProductModel productModel = new ProductModel()
            {
                Name = txb_Name.Text,
                Surname = txb_Surname.Text,
                CompanyName = txb_CompanyName.Text,
                VoenPassword = txb_VoenPassword.Text,
                District = txb_District.Text,
                Address = txb_Address.Text,
                İnfo = rtxb_Info.Text,
                ApproximateLocation = txb_ApproximateLocation.Text,
                CashireModel = txb_CashireModel.Text,
                ContractNO = Convert.ToDouble(txb_ContractNo.Text),
                EmployeeWhoConnects = txb_EmployeeWhoConnects.Text,
                EmployeeWhoSells = txb_EmployeeWhoSells.Text,
                TypeOfPayment = txb_TypeOfPayment.Text,
                Price = Convert.ToDecimal(txb_Price.Text),
                ServicePrice = Convert.ToDecimal(txb_ServicePrice.Text),
                SellesPayment = Convert.ToDecimal(txb_SellesPayment.Text),
                WrittenByOrxan = Convert.ToDecimal(txb_WrittenByOrxan.Text),
                TaxInterest = Convert.ToDecimal(txb_TaxInterest.Text),
                RegistrationDate = dt_RegistrationDate.Value,
                InitialPayment=initialPaymentStatus,
                PaymentStatus=model.PaymentStatus
            };

            var result = iProductService.Update(productModel);
            if (result)
            {
                MessageBox.Show("Uğurlu Əməliyyat");
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Uğurlu Əməliyyat");

            }


        }


        private void FillTextBox()
        {
            var model = iProductService.GetByID(Static.ProductİdForUpdate);
            txb_Name.Text = model.Name;
            txb_Surname.Text = model.Surname;
            txb_CompanyName.Text = model.CompanyName;
            txb_VoenPassword.Text = model.VoenPassword;
            txb_District.Text = model.District;
            txb_Address.Text = model.Address;
            rtxb_Info.Text = model.İnfo;
            txb_ApproximateLocation.Text = model.ApproximateLocation;
            txb_CashireModel.Text = model.CashireModel;
            txb_ContractNo.Text = model.ContractNO.ToString();
            txb_EmployeeWhoConnects.Text = model.EmployeeWhoConnects;
            txb_EmployeeWhoSells.Text = model.EmployeeWhoSells;
            txb_TypeOfPayment.Text = model.TypeOfPayment;
            txb_Price.Text = model.Price.ToString();
            txb_ServicePrice.Text = model.ServicePrice.ToString();
            txb_SellesPayment.Text = model.SellesPayment.ToString();
            txb_WrittenByOrxan.Text = model.WrittenByOrxan.ToString();
            txb_TaxInterest.Text = model.TaxInterest.ToString();
            dt_RegistrationDate.Text = model.RegistrationDate.ToString();
            if (model.InitialPayment == true)
            {
                rb_Paid.Checked = true;
            }
            else
            {
                rb_NotPaid.Checked = true;
            }
        }

        
    }
}
