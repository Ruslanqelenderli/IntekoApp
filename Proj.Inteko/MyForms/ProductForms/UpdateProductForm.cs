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
        ICashService cashService = new CashManager(new CashRepository());
        IPaymentService paymentService = new PaymentManager(new PaymentRepository());

        public UpdateProductForm()
        {
            InitializeComponent();
        }
        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            
            var typeOfPayment = new[]
            {
                "Nəğd","Köçürmə"
            };
            cmb_TypeOfPayment.DataSource = typeOfPayment;
            FillTextBox();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (Check())
                {
                    var model = iProductService.GetByID(Static.ProductIdForUpdate);
                    bool initialPaymentStatus = false;
                    if (rb_Paid.Checked == true)
                    {
                        initialPaymentStatus = true;
                    }
                    var cash = cashService.GetByName();
                    var payment = paymentService.GetByName();
                    ProductModel productModel = new ProductModel()
                    {
                        Name = txb_Name.Text,
                        CompanyName = txb_CompanyName.Text,
                        VoenPassword = txb_VoenPassword.Text,
                        District = txb_District.Text,
                        Address = txb_Address.Text,
                        İnfo = rtxb_Info.Text,
                        ApproximateLocation = txb_ApproximateLocation.Text,
                        CashId = cash.Id,
                        EmployeeWhoConnects = txb_EmployeeWhoConnects.Text,
                        EmployeeWhoSells = txb_EmployeeWhoSells.Text,
                        PaymentId = payment.Id,
                        Price = Convert.ToDecimal(txb_Price.Text),
                        ServicePrice = Convert.ToDecimal(txb_ServicePrice.Text),
                        SellesPayment = Convert.ToDecimal(txb_SellesPayment.Text),
                        OfficeMncPercent = Convert.ToDecimal(txb_OfficeMncPercent.Text),
                        WrittenByOrxan = Convert.ToDecimal(txb_WrittenByOrxan.Text),
                        RegistrationDate = dt_RegistrationDate.Value,
                        InitialPayment = initialPaymentStatus,
                        PaymentStatus = model.PaymentStatus
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
                else
                {
                    MessageBox.Show("Xanaları doldurun.");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Qiymətləri düzgün daxil edin");
            }
            
            


        }
        private bool Check()
        {
            if (!string.IsNullOrEmpty(txb_Name.Text)
                && !string.IsNullOrEmpty(txb_Surname.Text)
                && !string.IsNullOrEmpty(txb_CompanyName.Text)
                && !string.IsNullOrEmpty(txb_VoenPassword.Text)
                && !string.IsNullOrEmpty(txb_District.Text)
                && !string.IsNullOrEmpty(txb_Address.Text)
                && !string.IsNullOrEmpty(txb_ApproximateLocation.Text)
                && !string.IsNullOrEmpty(txb_CashireModel.Text)
                && !string.IsNullOrEmpty(txb_ContractNo.Text)
                && !string.IsNullOrEmpty(txb_EmployeeWhoConnects.Text)
                && !string.IsNullOrEmpty(txb_EmployeeWhoSells.Text)
                && !string.IsNullOrEmpty(txb_Price.Text)
                && !string.IsNullOrEmpty(txb_ServicePrice.Text)
                && !string.IsNullOrEmpty(txb_SellesPayment.Text)
                && !string.IsNullOrEmpty(txb_WrittenByOrxan.Text)
                && !string.IsNullOrEmpty(rtxb_Info.Text)
                )
            {
                if ((rb_Paid.Checked == true || rb_NotPaid.Checked == true))
                {
                    return true;
                }

            }
            return false;
        }

        private void FillTextBox(Guid cashId,Guid paymentId)
        {
            var cash = cashService.GetById(cashId);
            var payment = paymentService.GetById(paymentId);
            var model = iProductService.GetByID(Static.ProductIdForUpdate);
            txb_Name.Text = model.Name;
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
            cmb_TypeOfPayment.SelectedItem = model.TypeOfPayment;
            txb_Price.Text = model.Price.ToString();
            txb_ServicePrice.Text = model.ServicePrice.ToString();
            txb_SellesPayment.Text = model.SellesPayment.ToString();
            txb_WrittenByOrxan.Text = model.WrittenByOrxan.ToString();
            txb_OfficeMncPercent.Text = model.OfficeMncPercent.ToString();
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
