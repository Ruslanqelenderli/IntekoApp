using Microsoft.Office.Interop.Excel;
using Proj.Business.Abstract;
using Proj.Business.Concrete;
using Proj.Business.Enums;
using Proj.Business.Models;
using Proj.Business.Static;
using Proj.DataAccess.Concrete.EF;
using Proj.Entity.Concrete;
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
        IMonthlyPaymentService monthlyPayment = new MonthlyPaymentManager(new MonthlyPaymentRepository());
        IPhoneService phoneService = new PhoneManager(new PhoneRepository());
        public ControlForm()
        {

            InitializeComponent();
            GetAllProduct();
            productService.CheckPaid();
        }

        private void ControlForm_Load(object sender, EventArgs e)
        {
            ButtonFalse();
            btn_Update.Visible = false;
            
            btn_Remove.Visible = false;
            lbl_Revenue.Visible = false;
            lbl_RevenuePrice.Visible = false;
            dt_EndDate.Visible = false;
            dt_StartDate.Visible = false;
            btn_Search.Visible = false;
            dgv_Control.Columns[0].Visible = false;
            DelayCheck();


        }

        private void btn_AllProduct_Click(object sender, EventArgs e)
        {
            dt_EndDate.Visible = false;
            dt_StartDate.Visible = false;
            btn_Search.Visible = false;
            lbl_Revenue.Visible = false;
            lbl_RevenuePrice.Visible = false;
            GetAllProduct();
            ButtonFalse();

        }
        private void btn_ItsTime_Click(object sender, EventArgs e)
        {
            dt_EndDate.Visible = false;
            dt_StartDate.Visible = false;
            btn_Search.Visible = false;
            lbl_Revenue.Visible = false;
            lbl_RevenuePrice.Visible = false;
            productService.CheckStatus();
            GetItsTimeProduct();
            ButtonFalse();

        }

        private void btn_Sent_Click(object sender, EventArgs e)
        {
            dt_EndDate.Visible = true;
            dt_StartDate.Visible = true;
            btn_Search.Visible = true;
            lbl_Revenue.Visible = true;
            lbl_RevenuePrice.Visible = true;
            ButtonFalse();
            lbl_RevenuePrice.Text= GetSentProduct().ToString();

        }

        private void btn_Paid_Click(object sender, EventArgs e)
        {
            dt_EndDate.Visible = false;
            dt_StartDate.Visible = false;
            btn_Search.Visible = false;
            lbl_Revenue.Visible = false;
            lbl_RevenuePrice.Visible = false;
            GetServicePaidProduct();
            ButtonFalse();

        }
        #region methods
        private void GetAllProduct()
        {
            productService.Numbering();
            var products = productService.GetAll().OrderBy(x => x.ContractNO).ToList().Select(x => new {
                x.Id,
                No=x.No,
                Ad_Soyad = x.Name,
                Obyekt_Adı = x.CompanyName,
                Vöen_Kod = x.VoenPassword,
                Rayon = x.District,
                Ünvan = x.Address,
                Təqribi_Yerləşmə = x.ApproximateLocation,
                Kassa_Modeli = x.CashireModel,
                Müq_No ="E-" + x.ContractNO,
                Qeydiyyat_Tarixi = x.RegistrationDate,
                Qoşan_İşçi = x.EmployeeWhoConnects,
                Satan_İşçi = x.EmployeeWhoSells,
                Ödənişin_növü = x.TypeOfPayment,
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

            dgv_Control.DataSource = products;
        }

        private void GetItsTimeProduct()
        {
            var products = productService.GetAll().Where(x => x.PaymentStatus == ProductStatus.ItsTime.ToString()).OrderBy(x=>x.ContractNO).ToList().Select(x => new {
                x.Id,
                No=x.No,
                Ad_Soyad = x.Name,
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
                Satanın_Ödənişi = x.Price * x.SellesPayment / 100,
                Ofis_MNC = (x.Price-(x.Price+x.ServicePrice)*5/100 - x.WrittenByOrxan) * x.OfficeMncPercent / 100,
                Yazan_Orxan = x.WrittenByOrxan,
                Vergi_Faizi = (x.Price + x.ServicePrice) * 5 / 100,
                Son_Qalıq = x.Price+x.ServicePrice  - x.WrittenByOrxan - ((x.Price - (x.Price + x.ServicePrice) * 5 / 100 - x.WrittenByOrxan) * x.OfficeMncPercent / 100) - (x.Price + x.ServicePrice) * 5 / 100,
                Fitrə = (x.Price + x.ServicePrice - x.WrittenByOrxan - ((x.Price - (x.Price + x.ServicePrice) * 5 / 100 - x.WrittenByOrxan) * x.OfficeMncPercent / 100) - (x.Price + x.ServicePrice) * 5 / 100) * 1 / 100
            }).ToList();

            dgv_Control.DataSource = products;
        }
        private decimal GetSentProduct()
        {
            productService.Numbering();
            var productsSelect = productService.GetAll().Where(x => x.PaymentStatus == ProductStatus.Sent.ToString()).OrderBy(x=>x.ContractNO).ToList().Select(x => new {
                x.Id,
                No=x.No,
                Ad_Soyad = x.Name ,
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
                Satanın_Ödənişi = x.Price * x.SellesPayment / 100,
                Ofis_MNC = (x.Price - x.WrittenByOrxan) * x.OfficeMncPercent / 100,
                Yazan_Orxan = x.WrittenByOrxan,
                Vergi_Faizi = (x.Price + x.ServicePrice) * 5 / 100,
                Son_Qalıq = x.Price + x.ServicePrice - x.WrittenByOrxan - ((x.Price - x.WrittenByOrxan) * x.OfficeMncPercent / 100) - (x.Price + x.ServicePrice) * 5 / 100,
                Fitrə = (x.Price + x.ServicePrice - x.WrittenByOrxan - ((x.Price - x.WrittenByOrxan) * x.OfficeMncPercent / 100) - (x.Price + x.ServicePrice) * 5 / 100) * 1 / 100
            }).ToList();


            dgv_Control.DataSource = productsSelect;

            decimal commonPrice=0;
            var products = productService.GetAll().Where(x => x.PaymentStatus == ProductStatus.Sent.ToString());
            foreach (var product in productsSelect)
            {
                commonPrice += product.Servis_Xidməti;
                
            }
            foreach (var product in products)
            {
                if (product.InitialPayment != true)
                {
                    commonPrice += product.Price;
                }
                

            }
            return commonPrice;
        }
        private decimal GetSentProduct(DateTime startDate,DateTime endDate)
        {
            var productsSelect = productService.GetAll().Where(x=>x.SendDate>=startDate && x.SendDate<=endDate).Where(x => x.PaymentStatus == ProductStatus.Sent.ToString() || x.PriceDebt > 0).Select(x => new {
                x.Id,
                Ad_Soyad = x.Name,
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
                Satanın_Ödənişi = x.Price * x.SellesPayment / 100,
                Ofis_MNC = (x.Price - x.WrittenByOrxan) * x.OfficeMncPercent / 100,
                Yazan_Orxan = x.WrittenByOrxan,
                Vergi_Faizi = (x.Price + x.ServicePrice) * 5 / 100,
                Son_Qalıq = x.Price + x.ServicePrice - x.WrittenByOrxan - ((x.Price - x.WrittenByOrxan) * x.OfficeMncPercent / 100) - (x.Price + x.ServicePrice) * 5 / 100,
                Fitrə = (x.Price + x.ServicePrice - x.WrittenByOrxan - ((x.Price - x.WrittenByOrxan) * x.OfficeMncPercent / 100) - (x.Price + x.ServicePrice) * 5 / 100) * 1 / 100
            }).ToList();


            dgv_Control.DataSource = productsSelect;

            decimal commonPrice = 0;
            var products = productService.GetAll().Where(x => x.PaymentStatus == ProductStatus.Sent.ToString());
            foreach (var product in productsSelect)
            {
                commonPrice += product.Servis_Xidməti;

            }
            foreach (var product in products)
            {
                if (product.InitialPayment != true)
                {
                    commonPrice += product.Price;
                }


            }
            return commonPrice;
        }
        private void GetServicePaidProduct()
        {
            productService.Numbering();
            var products = productService.GetAll().Where(x => x.PaymentStatus == ProductStatus.Paid.ToString()).OrderBy(x=>x.ContractNO).ToList().Select(x => new {
                x.Id,
                No=x.No,
                Ad_Soyad = x.Name,
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
                Satanın_Ödənişi = x.Price * x.SellesPayment / 100,
                Ofis_MNC = (x.Price - x.WrittenByOrxan) * x.OfficeMncPercent / 100,
                Yazan_Orxan = x.WrittenByOrxan,
                Vergi_Faizi = (x.Price + x.ServicePrice) * 5 / 100,
                Son_Qalıq = x.Price + x.ServicePrice - x.WrittenByOrxan - ((x.Price - x.WrittenByOrxan) * x.OfficeMncPercent / 100) - (x.Price + x.ServicePrice) * 5 / 100,
                Fitrə = (x.Price + x.ServicePrice - x.WrittenByOrxan - ((x.Price - x.WrittenByOrxan) * x.OfficeMncPercent / 100) - (x.Price + x.ServicePrice) * 5 / 100) * 1 / 100
            }).ToList();

            dgv_Control.DataSource = products;
        }
        private void GetInitialUnPaidProduct()
        {
            productService.Numbering();
            var products = productService.GetAll().Where(x => x.PriceDebt>0).OrderBy(x=>x.ContractNO).ToList().Select(x => new {
                x.Id,
                No=x.No,
                Ad_Soyad = x.Name, 
                Obyekt_Adı = x.CompanyName,
                Vöen_Kod = x.VoenPassword,
                Rayon = x.District,
                Ünvan = x.Address,
                Təqribi_Yerləşmə = x.ApproximateLocation,
                Kassa_Modeli = x.Cash.Name,
                Müq_No = x.ContractNO,
                Qeydiyyat_Tarixi = x.RegistrationDate,
                Qoşan_İşçi = x.EmployeeWhoConnects,
                Satan_İşçi = x.EmployeeWhoSells,
                Ödənişin_növü = x.Payment.Name,
                Yazılma_Qiymət = x.Price,
                Yazılma_borcu=x.PriceDebt,
                Servis_Xidməti = x.ServicePrice,
                Toplam_Daxil_Olma = x.Price + x.ServicePrice,
                Satanın_Ödənişi = x.Price * x.SellesPayment / 100,
                Ofis_MNC = (x.Price - x.WrittenByOrxan) * x.OfficeMncPercent / 100,
                Yazan_Orxan = x.WrittenByOrxan,
                Vergi_Faizi = (x.Price + x.ServicePrice) * 5 / 100,
                Son_Qalıq = x.Price + x.ServicePrice - x.WrittenByOrxan - ((x.Price - x.WrittenByOrxan) * x.OfficeMncPercent / 100) - (x.Price + x.ServicePrice) * 5 / 100,
                Fitrə = (x.Price + x.ServicePrice - x.WrittenByOrxan - ((x.Price - x.WrittenByOrxan) * x.OfficeMncPercent / 100) - (x.Price + x.ServicePrice) * 5 / 100) * 1 / 100
            }).ToList();

            dgv_Control.DataSource = products;
        }


        #endregion

        private void dgv_Control_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Contact.Visible = true;
            btn_Details.Visible = true;
            btn_WasPaid.Visible = false;
            btn_WasSent.Visible = false;
            
           


            Guid id = (Guid)dgv_Control.CurrentRow.Cells[0].Value;
            var product=productService.GetByID(id);
            if(product.PaymentStatus==ProductStatus.ItsTime.ToString() || product.PaymentStatus == ProductStatus.ThereIsTime.ToString())
            {
                btn_WasSent.Visible = true;
            }

            if (product.PaymentStatus == ProductStatus.Sent.ToString() || product.PriceDebt>0)
            {
                btn_WasPaid.Visible = true;
                Static.ProductIdForPaid = id;
            }

            

            if (Static.User.Status == Status.Director.ToString())
            {
                btn_Update.Visible = true;
                btn_Remove.Visible = true;
            }



        }

        private void btn_Contact_Click(object sender, EventArgs e)
        {
            Guid id = (Guid)dgv_Control.CurrentRow.Cells[0].Value;
            Static.Id = id;
            List<Phone> phoneNumbers = phoneService.GetProductId(id);
            if (phoneNumbers.Count == 0)
            {
                MessageBox.Show("Bu müştərinin telefon nömrəsi yoxdur.Zəhmət olmasa əlavə edin.");
            }
            else
            {
                PhoneNumberForm phoneNumberForm = new PhoneNumberForm();
                phoneNumberForm.ShowDialog();
            }
            
            
        }

        

        private void btn_WasSent_Click(object sender, EventArgs e)
        {
            Guid id = (Guid)dgv_Control.CurrentRow.Cells[0].Value;
            var month = DateTime.Now.Month;
            var monthName = ConvertMonthName(month);
            var result = productService.SentMethod(id,monthName);
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
            PaidForm paidForm = new PaidForm();
            paidForm.ShowDialog();
        }

        

        private void ExportToExcel()
        {
              Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                
                Workbook workbook = excel.Workbooks.Add(Type.Missing);

                excel.Visible = true;
                Worksheet ws = workbook.Sheets["Sheet1"]; 
                ws = workbook.ActiveSheet;
                ws.Name = "Exported from gridview";
                for (int i = 1; i < dgv_Control.Columns.Count + 1; i++)
                {
                    ws.Cells[1, i] = dgv_Control.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgv_Control.Rows.Count ; i++)
                {
                    for (int j = 0; j < dgv_Control.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1] = dgv_Control.Rows[i].Cells[j].Value.ToString();
                    }
                }
                

           
        }

        private void exxeləIxracToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exceləIxracToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void ButtonFalse()
        {
            btn_WasPaid.Visible = false;
            btn_Contact.Visible = false;
            btn_WasSent.Visible = false;
            btn_Details.Visible = false;
            
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            Guid id = (Guid)dgv_Control.CurrentRow.Cells[0].Value;
            string message = "Silmək İstədiyinizə Əminsizin?";
            string title = "Bildiriş";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialog = MessageBox.Show(message, title, buttons);
            if (dialog == DialogResult.Yes)
            {

                var result = productService.Remove(id);
                if (result)
                {
                    MessageBox.Show("Silindi.");
                    GetAllProduct();

                }
                else
                {
                    MessageBox.Show("Xəta.");
                }
            }
            
            
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Guid id = (Guid)dgv_Control.CurrentRow.Cells[0].Value;
            Static.ProductIdForUpdate = id;
            UpdateProductForm updateProductForm = new UpdateProductForm();
            updateProductForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            DateTime startDate = dt_StartDate.Value;
            DateTime endDate = dt_EndDate.Value;
            lbl_RevenuePrice.Text = GetSentProduct(startDate, endDate).ToString();
        }


        private string ConvertMonthName(int id)
        {
            if (id == 1)
            {
                return "Yanvar";
            }
            else if (id == 2)
            {
                return "Fevral";
            }
            else if (id == 3)
            {
                return "Mart";
            }
            else if (id == 4)
            {
                return "Aprel";
            }
            else if (id == 5)
            {
                return "May";
            }
            else if (id == 6)
            {
                return "Iyun";
            }
            else if (id == 7)
            {
                return "Iyul";
            }
            else if (id == 8)
            {
                return "Avqust";
            }
            else if (id == 9)
            {
                return "Sentyabr";
            }
            else if (id == 10)
            {
                return "Oktyabr";
            }
            else if (id == 11)
            {
                return "Noyabr";
            }
            else
            {
                return "Dekabr";
            }
        }


        private void DelayCheck()
        {
            var nowDay = DateTime.Now.Day;
            var nowMonth = DateTime.Now.Month;
            if (nowMonth == 1)
            {
                nowMonth = 13;
            }
            var models=productService.GetAll().Where(x=>x.PaymentStatus=="Sent").ToList();
            if (models != null)
            {
                foreach (var model in models)
                {
                    if (model.SendDate.Value.Day == nowDay && nowMonth - model.SendDate.Value.Month == 1)
                    {
                        var monthName = ConvertMonthName(DateTime.Now.Month);
                        var monthlymodel = new MonthlyPaymentModel()
                        {
                            MonthName = monthName,
                            Paid = false,
                            ProductId = model.Id
                        };
                        var result = monthlyPayment.Create(monthlymodel);
                        if (!result)
                        {
                            MessageBox.Show("Xəta");
                        }
                        else
                        {
                            model.SendDate = DateTime.Now;
                            productService.Update(model);
                        }
                    }
                }
            }
            
        }

        private void btn_DeptProduct_Click(object sender, EventArgs e)
        {
            dt_EndDate.Visible = false;
            dt_StartDate.Visible = false;
            btn_Search.Visible = false;
            lbl_Revenue.Visible = false;
            lbl_RevenuePrice.Visible = false;
            GetInitialUnPaidProduct();
        }

        private void btn_Details_Click(object sender, EventArgs e)
        {
            Guid id = (Guid)dgv_Control.CurrentRow.Cells[0].Value;
            Static.ProductIdForDetails = id;
            ProductDetailsForm detailsForm = new ProductDetailsForm();
            detailsForm.ShowDialog();


        }

        
    }
}
