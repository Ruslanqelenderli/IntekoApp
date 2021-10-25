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
    public partial class PaidForm : Form
    {
        IProductService productService = new ProductManager(new ProductRepository());
        IMonthlyPaymentService monthlyPayment = new MonthlyPaymentManager(new MonthlyPaymentRepository());
        public PaidForm()
        {
            InitializeComponent();
        }

        private void brn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PaidForm_Load(object sender, EventArgs e)
        {
            btn_Paid.Visible = true;
            dgv_Payments.Visible = true;
            lbl_PriceDeptHeader.Visible = false;
            lbl_DebtQuantity.Visible = false;
            lbl_Price.Visible = false;
            txb_Price.Visible = false;
            btn_AddPriceDebt.Visible = false;
            var model = productService.GetByID(Static.ProductIdForPaid);
            if (model.PriceDebt > 0)
            {
                lbl_PriceDeptHeader.Visible = true;
                lbl_DebtQuantity.Visible = true;
                lbl_Price.Visible = true;
                txb_Price.Visible = true;
                btn_AddPriceDebt.Visible = true;
                lbl_DebtQuantity.Text = model.PriceDebt.ToString();
            }
            GetAll();
            if ( dgv_Payments.Rows.Count == 0)
            {
                btn_Paid.Visible = false;
                dgv_Payments.Visible = false;
            }



        }

        private void btn_AddPriceDebt_Click(object sender, EventArgs e)
        {
            try
            {
                if (Check())
                {
                    var model = productService.GetByID(Static.ProductIdForPaid);
                    model.PriceDebt -= Convert.ToDecimal(txb_Price.Text);
                    if (model.PriceDebt < 0)
                    {
                        model.PriceDebt = 0;
                    }
                    if (model.PriceDebt == 0)
                    {
                        model.InitialPayment = true;
                    }
                    var result = productService.Update(model);
                    if (result)
                    {
                        MessageBox.Show("Uğurlu əməliyyat.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Xəta.");
                    }
                }
                else
                {
                    MessageBox.Show("Xananı doldurun");
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Qiyməti düzgün daxil edin");
            }
            
        }

        private bool Check()
        {
            if (!string.IsNullOrEmpty(txb_Price.Text))
            {
                return true;
            }
            return false;
        }


        private void GetAll()
        {
            var payments = monthlyPayment.GetUnPaidPayments(Static.ProductIdForPaid).Select(x=>new { 
                Id=x.Id,
                Müəssisə_adı=x.Product.CompanyName,
                Ayın_adı=x.MonthName,

            }).ToList();
            dgv_Payments.DataSource = payments;
        }

        private void btn_Paid_Click(object sender, EventArgs e)
        {
            Guid id = (Guid)dgv_Payments.CurrentRow.Cells[0].Value;
            var model = monthlyPayment.GetById(id);
            var result = monthlyPayment.UpdatePaidStatus(id);
            if (result) 
            {
                MessageBox.Show("Uğurlu əməliyyat");
                GetAll();
                if (dgv_Payments.Rows.Count == 0)
                {
                    btn_Paid.Visible = false;
                    dgv_Payments.Visible = false;
                };
                var monthlyPayments = monthlyPayment.GetByProductId(model.ProductId).Where(x=>x.Paid==false).ToList();
                if (monthlyPayments.Count == 0)
                {
                    var productEntity=productService.GetByID(model.ProductId);
                    productEntity.PaymentStatus = Business.Enums.ProductStatus.Paid.ToString();
                    var productResult = productService.Update(productEntity);
                    
                }
            }
            else
            {
                MessageBox.Show("Uğursuz əməliyyat");
            }
        }
    }
}
