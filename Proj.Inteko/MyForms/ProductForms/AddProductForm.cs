using MySqlX.XDevAPI;
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

namespace Proj.Inteko.MyForms.ProductForms
{
    public partial class AddProductForm : Form
    {
        IProductService productService = new ProductManager(new ProductRepository());
        public AddProductForm()
        {
            InitializeComponent();
            GetAllProduct();
        }

        
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                bool initialPaymentStatus=false;
                if (rb_Paid.Checked == true)
                {
                    initialPaymentStatus = true;
                }
                ProductModel model = new ProductModel()
                {
                    Name=txb_Name.Text,
                    Surname=txb_Surname.Text,
                    CompanyName=txb_CompanyName.Text,
                    VoenPassword=txb_VoenPassword.Text,
                    District=txb_District.Text,
                    Address=txb_Address.Text,
                    ApproximateLocation=txb_ApproximateLocation.Text,
                    CashireModel=txb_CashireModel.Text,
                    ContractNO=Convert.ToDouble(txb_ContractNo.Text),
                    EmployeeWhoConnects=txb_EmployeeWhoConnects.Text,
                    EmployeeWhoSells=txb_EmployeeWhoSells.Text,
                    Price=Convert.ToDecimal(txb_Price.Text),
                    ServicePrice= Convert.ToDecimal(txb_ServicePrice.Text),
                    SellesPayment= Convert.ToDecimal(txb_SellesPayment.Text),
                    WrittenByOrxan= Convert.ToDecimal(txb_WrittenByOrxan.Text),
                    TaxInterest= Convert.ToDecimal(txb_TaxInterest.Text),
                    RegistrationDate=dt_RegistrationDate.Value,
                    İnfo=rtxb_Info.Text,
                    TypeOfPayment=txb_TypeOfPayment.Text,
                    InitialPayment= initialPaymentStatus,
                    PaymentStatus=ProductStatus.ThereIsTime.ToString()

                };
                bool added = productService.Create(model);
                if (added)
                {
                    MessageBox.Show("Əlavə Olundu.");
                    GetAllProduct();
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

        private void dgv_AllProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Phone.Visible = true;
        }
        private void AddProductForm_Load(object sender, EventArgs e)
        {
            btn_Phone.Visible = false;
        }
        private void btn_Phone_Click(object sender, EventArgs e)
        {
            Guid id = (Guid)dgv_AllProduct.CurrentRow.Cells[0].Value;

            ProductInfo.ProductId = id;

            AddPhoneNumberForm addPhoneNumberForm = new AddPhoneNumberForm();
            addPhoneNumberForm.ShowDialog();
        }
        private void GetAllProduct()
        {
            var products = productService.GetAll().Select(x=>new{
                x.Id,
                AdSoyad=x.Name+x.Surname,
                Obyekt_Adı=x.CompanyName,
                Vöen_Kod=x.VoenPassword,
                Rayon=x.District,
                Ünvan=x.Address,
                Təqribi_Yerləşmə=x.ApproximateLocation,
                Kassa_Modeli=x.CashireModel,
                Müq_No=x.ContractNO,
                Qeydiyyat_Tarixi=x.RegistrationDate,
                Qoşan_İşçi=x.EmployeeWhoConnects,
                Satan_İşçi=x.EmployeeWhoSells,
                Ödənişin_növü=x.TypeOfPayment,
                Yazılma_Qiymət=x.Price,
                Servis_Xidməti=x.ServicePrice,
                Toplam_Daxil_Olma=x.Price+x.ServicePrice,
                Satanın_Ödənişi=x.TaxInterest,
                Ofis_MNC= (x.Price-x.WrittenByOrxan)*5/100,
                Yazan_Orxan=x.WrittenByOrxan,
                Vergi_Faizi=x.Price*1/100,
                Son_Qalıq=x.Price
            }).ToList();

            dgv_AllProduct.DataSource = products;
        }
        private bool Check()
        {
            if(!string.IsNullOrEmpty(txb_Name.Text)
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
                && !string.IsNullOrEmpty(txb_TypeOfPayment.Text)
                && !string.IsNullOrEmpty(txb_Price.Text)
                && !string.IsNullOrEmpty(txb_ServicePrice.Text)
                && !string.IsNullOrEmpty(txb_SellesPayment.Text)
                && !string.IsNullOrEmpty(txb_WrittenByOrxan.Text)
                && !string.IsNullOrEmpty(txb_TaxInterest.Text)
                && !string.IsNullOrEmpty(rtxb_Info.Text)
                )
            {
                if((rb_Paid.Checked == true || rb_NotPaid.Checked == true))
                {
                    return true;
                }
                
            }
            return false;
        }

        public static class ProductInfo
        {
            public static Guid ProductId { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
