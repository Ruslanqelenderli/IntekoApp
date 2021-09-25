using Proj.Business.Abstract;
using Proj.Business.Concrete;
using Proj.Business.Enums;
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
    public partial class ControlForm : Form
    {
        IProductService productService = new ProductManager(new ProductRepository());
        public ControlForm()
        {

            InitializeComponent();
            GetAllProduct();
            productService.CheckPaid();
        }

        private void ControlForm_Load(object sender, EventArgs e)
        {
            btn_WasPaid.Visible = false;
            btn_Contact.Visible = false;
            btn_WasSent.Visible = false;
        }

        private void btn_AllProduct_Click(object sender, EventArgs e)
        {
            GetAllProduct();
        }
        private void btn_ItsTime_Click(object sender, EventArgs e)
        {
            productService.CheckStatus();
            GetItsTimeProduct();
        }

        private void btn_Sent_Click(object sender, EventArgs e)
        {
            GetSentProduct();
        }

        private void btn_Paid_Click(object sender, EventArgs e)
        {
            GetPaidProduct();
        }
        #region methods
        private void GetAllProduct()
        {
            var products = productService.GetAll().Select(x => new {
                x.Id,
                AdSoyad = x.Name + x.Surname,
                Obyekt_Adı = x.CompanyName,
                Vöen_Kod = x.VoenPassword,
                Rayon = x.District,
                Ünvan = x.Address,
                Təqribi_Yerləşmə = x.ApproximateLocation,
                Kassa_Modeli = x.CashireModel,
                Müq_No = x.ContractNO,
                Qeydiyyat_Tarixi = x.RegistrationDate,
                Qoşan_İşçi = x.EmployeeWhoConnects,
                Satan_İşçi = x.EmployeeWhoSells,
                Ödənişin_növü = x.TypeOfPayment,
                Yazılma_Qiymət = x.Price,
                Servis_Xidməti = x.ServicePrice,
                Toplam_Daxil_Olma = x.Price + x.ServicePrice,
                Satanın_Ödənişi = x.TaxInterest,
                Ofis_MNC = (x.Price - x.WrittenByOrxan) * 5 / 100,
                Yazan_Orxan = x.WrittenByOrxan,
                Vergi_Faizi = x.Price * 1 / 100,
                Son_Qalıq = x.Price
            }).ToList();

            dgv_Control.DataSource = products;
        }

        private void GetItsTimeProduct()
        {
            var products = productService.GetAll().Where(x => x.PaymentStatus == ProductStatus.ItsTime.ToString()).Select(x => new {
                x.Id,
                AdSoyad = x.Name + x.Surname,
                Obyekt_Adı = x.CompanyName,
                Vöen_Kod = x.VoenPassword,
                Rayon = x.District,
                Ünvan = x.Address,
                Təqribi_Yerləşmə = x.ApproximateLocation,
                Kassa_Modeli = x.CashireModel,
                Müq_No = x.ContractNO,
                Qeydiyyat_Tarixi = x.RegistrationDate,
                Qoşan_İşçi = x.EmployeeWhoConnects,
                Satan_İşçi = x.EmployeeWhoSells,
                Ödənişin_növü = x.TypeOfPayment,
                Yazılma_Qiymət = x.Price,
                Servis_Xidməti = x.ServicePrice,
                Toplam_Daxil_Olma = x.Price + x.ServicePrice,
                Satanın_Ödənişi = x.TaxInterest,
                Ofis_MNC = (x.Price - x.WrittenByOrxan) * 5 / 100,
                Yazan_Orxan = x.WrittenByOrxan,
                Vergi_Faizi = x.Price * 1 / 100,
                Son_Qalıq = x.Price
            }).ToList();

            dgv_Control.DataSource = products;
        }
        private void GetSentProduct()
        {
            var products = productService.GetAll().Where(x => x.PaymentStatus == ProductStatus.Sent.ToString()).Select(x => new {
                x.Id,
                AdSoyad = x.Name + x.Surname,
                Obyekt_Adı = x.CompanyName,
                Vöen_Kod = x.VoenPassword,
                Rayon = x.District,
                Ünvan = x.Address,
                Təqribi_Yerləşmə = x.ApproximateLocation,
                Kassa_Modeli = x.CashireModel,
                Müq_No = x.ContractNO,
                Qeydiyyat_Tarixi = x.RegistrationDate,
                Qoşan_İşçi = x.EmployeeWhoConnects,
                Satan_İşçi = x.EmployeeWhoSells,
                Ödənişin_növü = x.TypeOfPayment,
                Yazılma_Qiymət = x.Price,
                Servis_Xidməti = x.ServicePrice,
                Toplam_Daxil_Olma = x.Price + x.ServicePrice,
                Satanın_Ödənişi = x.TaxInterest,
                Ofis_MNC = (x.Price - x.WrittenByOrxan) * 5 / 100,
                Yazan_Orxan = x.WrittenByOrxan,
                Vergi_Faizi = x.Price * 1 / 100,
                Son_Qalıq = x.Price
            }).ToList();

            dgv_Control.DataSource = products;
        }
        private void GetPaidProduct()
        {
            var products = productService.GetAll().Where(x => x.PaymentStatus == ProductStatus.Paid.ToString()).Select(x => new {
                x.Id,
                AdSoyad = x.Name + x.Surname,
                Obyekt_Adı = x.CompanyName,
                Vöen_Kod = x.VoenPassword,
                Rayon = x.District,
                Ünvan = x.Address,
                Təqribi_Yerləşmə = x.ApproximateLocation,
                Kassa_Modeli = x.CashireModel,
                Müq_No = x.ContractNO,
                Qeydiyyat_Tarixi = x.RegistrationDate,
                Qoşan_İşçi = x.EmployeeWhoConnects,
                Satan_İşçi = x.EmployeeWhoSells,
                Ödənişin_növü = x.TypeOfPayment,
                Yazılma_Qiymət = x.Price,
                Servis_Xidməti = x.ServicePrice,
                Toplam_Daxil_Olma = x.Price + x.ServicePrice,
                Satanın_Ödənişi = x.TaxInterest,
                Ofis_MNC = (x.Price - x.WrittenByOrxan) * 5 / 100,
                Yazan_Orxan = x.WrittenByOrxan,
                Vergi_Faizi = x.Price * 1 / 100,
                Son_Qalıq = x.Price
            }).ToList();

            dgv_Control.DataSource = products;
        }


        #endregion

        private void dgv_Control_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Contact.Visible = true;
            btn_WasPaid.Visible = false;
            btn_WasSent.Visible = false;


            Guid id = (Guid)dgv_Control.CurrentRow.Cells[0].Value;
            var product=productService.GetByID(id);
            if(product.PaymentStatus==ProductStatus.ItsTime.ToString() || product.PaymentStatus == ProductStatus.ThereIsTime.ToString())
            {
                btn_WasSent.Visible = true;
            }

            if (product.PaymentStatus == ProductStatus.Sent.ToString())
            {
                btn_WasPaid.Visible = true;

            }


        }

        private void btn_Contact_Click(object sender, EventArgs e)
        {
            Guid id = (Guid)dgv_Control.CurrentRow.Cells[0].Value;
            Static.Id = id;
            PhoneNumberForm phoneNumberForm = new PhoneNumberForm();
            phoneNumberForm.ShowDialog();
        }

        public static class Static
        {
            public static Guid  Id { get; set; }
        }

        private void btn_WasSent_Click(object sender, EventArgs e)
        {
            Guid id = (Guid)dgv_Control.CurrentRow.Cells[0].Value;
            var result = productService.SentMethod(id);
            if (result)
            {
                MessageBox.Show("Uğurlu əməliyyat.");
                btn_WasSent.Visible = false;
            }
            else
            {
                MessageBox.Show("Uğursuz əməliyyat.");
            }
                

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_WasPaid_Click(object sender, EventArgs e)
        {
            Guid id = (Guid)dgv_Control.CurrentRow.Cells[0].Value;
            var result = productService.PaidMethod(id);
            if (result)
            {
                MessageBox.Show("Uğurlu əməliyyat.");
                btn_WasPaid.Visible = false;
            }
            else
            {
                MessageBox.Show("Uğursuz əməliyyat.");
            }
        }
    }
}
