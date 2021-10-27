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
        ICashService cashService = new CashManager(new CashRepository());
        IPaymentService paymentService = new PaymentManager(new PaymentRepository());
        public AddProductForm()
        {
            InitializeComponent();
            GetAllProduct();
            dgv_AllProduct.Columns[0].Visible = false;
        }

        
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (Check())
                {
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
                        OfficeMncPercent = Convert.ToDecimal(txb_OfficeMncPercent.Text)

                    };
                    bool added = productService.Create(model);
                    if (added)
                    {
                        MessageBox.Show("Əlavə Olundu.");
                        CleanTextBox();
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
            catch (Exception)
            {

                MessageBox.Show("Qiymətləri düzgün daxil edin.");
            }
            
        }

        private void dgv_AllProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Phone.Visible = true;
            btn_AddNewCompany.Visible = true;
            Guid id = (Guid)dgv_AllProduct.CurrentRow.Cells[0].Value;
            ProductInfo.ProductId = id;

        }
        private void AddProductForm_Load(object sender, EventArgs e)
        {
            btn_Phone.Visible = false;
            btn_AddNewCompany.Visible = false;
            SetCashAndPaymentType();


        }

        private void SetCashAndPaymentType()
        {
            var payments = paymentService.GetAll();
            var cashes = cashService.GetAll();
            foreach (var cash in cashes)
            {
                cmb_CashireModel.Items.Add(cash.Name);
            }
            foreach (var payment in payments)
            {
                cmb_TypeOfPayment.Items.Add(payment.Name);
            }
        }
        private void btn_Phone_Click(object sender, EventArgs e)
        {
            

            AddPhoneNumberForm addPhoneNumberForm = new AddPhoneNumberForm();
            addPhoneNumberForm.ShowDialog();
        }
        private void GetAllProduct()
        {

            productService.Numbering();
            var productsgridview = productService.GetAll().OrderBy(x => x.ContractNO).ToList().Select(x => new {
                    x.Id,
                    No=x.No,
                    Ad_Soyad = x.Name,
                    Obyekt_Adı = x.CompanyName,
                    Vöen_Kod = x.VoenPassword,
                    Rayon = x.District,
                    Ünvan = x.Address,
                    Təqribi_Yerləşmə = x.ApproximateLocation,
                    Müq_No ="E-" +x.ContractNO,
                    Qeydiyyat_Tarixi = x.RegistrationDate,
                    Qoşan_İşçi = x.EmployeeWhoConnects,
                    Satan_İşçi = x.EmployeeWhoSells,
                    Yazılma_Qiymət = x.Price,
                    Servis_Xidməti = x.ServicePrice,
                    Toplam_Daxil_Olma = x.Price + x.ServicePrice,
                    Satanın_Ödənişi = x.Price * x.SellesPayment / 100,
                    Ofis_MNC = (x.Price - x.WrittenByOrxan) * x.OfficeMncPercent / 100,
                    Yazan_Orxan = x.WrittenByOrxan,
                    Vergi_Faizi = (x.Price + x.ServicePrice) * 5 / 100,
                    Son_Qalıq = x.Price + x.ServicePrice - x.WrittenByOrxan - ((x.Price - x.WrittenByOrxan) * x.OfficeMncPercent / 100) - (x.Price + x.ServicePrice) * 5 / 100,
                    Fitrə = (x.Price + x.ServicePrice - x.WrittenByOrxan - ((x.Price - x.WrittenByOrxan) * x.OfficeMncPercent / 100) - (x.Price + x.ServicePrice) * 5 / 100) * 1 / 100
               }).ToList();
                
            
            

            dgv_AllProduct.DataSource = productsgridview;
            




        }
        
        private bool Check()
        {
            if(!string.IsNullOrEmpty(txb_Name.Text)
                && !string.IsNullOrEmpty(txb_CompanyName.Text)
                && !string.IsNullOrEmpty(txb_VoenPassword.Text)
                && !string.IsNullOrEmpty(txb_District.Text)
                && !string.IsNullOrEmpty(txb_Address.Text)
                && !string.IsNullOrEmpty(txb_ApproximateLocation.Text)
                && !string.IsNullOrEmpty(txb_EmployeeWhoConnects.Text)
                && !string.IsNullOrEmpty(txb_EmployeeWhoSells.Text)
                && !string.IsNullOrEmpty(txb_Price.Text)
                && !string.IsNullOrEmpty(txb_ServicePrice.Text)
                && !string.IsNullOrEmpty(txb_SellesPayment.Text)
                && !string.IsNullOrEmpty(txb_WrittenByOrxan.Text)
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
        private void CleanTextBox()
        {
            txb_Name.Clear();
            txb_CompanyName.Clear();
            txb_VoenPassword.Clear();
            txb_District.Clear();
            txb_Address.Clear();
            rtxb_Info.Clear();
            txb_ApproximateLocation.Clear();
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

        public static class ProductInfo
        {
            public static Guid ProductId { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_TypeOfPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgv_AllProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txb_EmployeeWhoSells_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_AddNewCompany_Click(object sender, EventArgs e)
        {
            AddNewProductForm productForm = new AddNewProductForm();
            productForm.Show();
        }
    }
}
