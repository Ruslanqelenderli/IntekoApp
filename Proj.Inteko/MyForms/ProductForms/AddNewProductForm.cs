using Proj.Business.Abstract;
using Proj.Business.Concrete;
using Proj.Business.Enums;
using Proj.Business.Models;
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
using static Proj.Inteko.MyForms.ProductForms.AddProductForm;

namespace Proj.Inteko.MyForms.ProductForms
{
    public partial class AddNewProductForm : Form
    {
        IProductService productService = new ProductManager(new ProductRepository());
        public AddNewProductForm()
        {
            InitializeComponent();
        }

        private void AddNewProductForm_Load(object sender, EventArgs e)
        {
            WriteProductInfo();
            var typeOfPayment = new[]
            {
                "Nəğd","Köçürmə"
            };
            cmb_TypeOfPayment.DataSource = typeOfPayment;
        }


        private void WriteProductInfo()
        {
            var model = productService.GetByID(ProductInfo.ProductId);
            txb_Name.Text = model.Name;
            txb_CompanyName.Text = model.CompanyName;
            txb_VoenPassword.Text = model.VoenPassword;
            txb_Name.ReadOnly = true;
            txb_Surname.ReadOnly = true;
            txb_VoenPassword.ReadOnly = true;
            txb_CompanyName.ReadOnly = true;

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (Check())
                {
                    var product = productService.GetByID(ProductInfo.ProductId);
                    bool initialPaymentStatus = false;
                    if (rb_Paid.Checked == true)
                    {
                        initialPaymentStatus = true;
                    }
                    ProductModel model = new ProductModel()
                    {
                        Name = txb_Name.Text,
                        CompanyName = txb_CompanyName.Text,
                        VoenPassword = txb_VoenPassword.Text,
                        District = txb_District.Text,
                        Address = txb_Address.Text,
                        ApproximateLocation = txb_ApproximateLocation.Text,
                        EmployeeWhoConnects = txb_EmployeeWhoConnects.Text,
                        EmployeeWhoSells = txb_EmployeeWhoSells.Text,
                        Price = Convert.ToDecimal(txb_Price.Text),
                        ServicePrice = Convert.ToDecimal(txb_ServicePrice.Text),
                        SellesPayment = Convert.ToDecimal(txb_SellesPayment.Text),
                        WrittenByOrxan = Convert.ToDecimal(txb_WrittenByOrxan.Text),
                        RegistrationDate = dt_RegistrationDate.Value,
                        İnfo = rtxb_Info.Text,
                        InitialPayment = initialPaymentStatus,
                        PaymentStatus = ProductStatus.ThereIsTime.ToString(),
                        OfficeMncPercent = Convert.ToDecimal(txb_OfficeMncPercent.Text),
                        ContratNo=product.ContractNO

                    };
                    bool added = productService.Create(model);
                    if (added)
                    {
                        string message = "Müəssisə uğurla əlavə edildi.Yeni Müəssisə əlavə etmək istəryirsiniz?";
                        string title = "Bildiriş";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.No)
                        {

                            this.Close();
                        }
                        else
                        {
                            CleanTextBox();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xəta.");
                    }
                }
                else
                {
                    MessageBox.Show("Bütün xanaları doldurun.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Qiymətləri düzgün daxil edin.");
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
        private void CleanTextBox()
        {
            
            txb_District.Clear();
            txb_Address.Clear();
            rtxb_Info.Clear();
            txb_ApproximateLocation.Clear();
            txb_CashireModel.Clear();
            txb_EmployeeWhoConnects.Clear();
            txb_EmployeeWhoSells.Clear();
            txb_Price.Clear();
            txb_ServicePrice.Clear();
            txb_SellesPayment.Clear();
            txb_WrittenByOrxan.Clear();
            txb_OfficeMncPercent.Clear();
            rb_Paid.Checked = false;
            rb_NotPaid.Checked = false;
        }
    }
}
