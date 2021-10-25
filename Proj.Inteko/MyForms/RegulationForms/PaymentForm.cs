using Proj.Business.Abstract;
using Proj.Business.Concrete;
using Proj.Business.Models;
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

namespace Proj.Inteko.MyForms.RegulationForms
{
    public partial class PaymentForm : Form
    {
        IPaymentService paymentService = new PaymentManager(new PaymentRepository());
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegulationBridgeForm regulationBridgeForm = new RegulationBridgeForm();
            regulationBridgeForm.ShowDialog();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            Guid id = (Guid)dgv_Payment.CurrentRow.Cells[0].Value;
            if (id != null)
            {
                
                var result = paymentService.Remove(id);
                if (result)
                {
                    MessageBox.Show("Silindi");
                    GetAll();
                    Clear();
                    txb_UpdateName.ReadOnly = true;

                }
                else
                {
                    MessageBox.Show("Xəta");
                }
            }
            else
            {
                MessageBox.Show("Xəta");
            }
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {

            GetAll();
            dgv_Payment.Columns[0].Visible = false;
            txb_UpdateName.ReadOnly = true;
            btn_Remove.Visible = false;
        }



        private void GetAll()
        {
            var cashes = paymentService.GetAll().Select(x => new
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
            dgv_Payment.DataSource = cashes;
        }
        private void Clear()
        {
            txb_AddName.Clear();
            txb_UpdateName.Clear();
        }

        private void dgv_Payment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_UpdateName.ReadOnly = false;
            txb_UpdateName.Text = (string)dgv_Payment.CurrentRow.Cells[1].Value;
            btn_Remove.Visible = true;
        }
        

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txb_AddName.Text))
            {
                var model = new PaymentModel()
                {
                    Name = txb_AddName.Text
                };
                var result = paymentService.Create(model);
                if (result)
                {
                    MessageBox.Show("Əlavə olundu");
                    GetAll();
                    Clear();


                }
                else
                {
                    MessageBox.Show("Xəta");
                }
            }
            else
            {
                MessageBox.Show("Xananı doldurun");
            }
        }

        private void btn_Update_Click_1(object sender, EventArgs e)
        {
            Guid id = (Guid)dgv_Payment.CurrentRow.Cells[0].Value;
            var entity = paymentService.GetById(id);
            entity.Name = txb_UpdateName.Text;
            var result = paymentService.Update(entity);
            if (result)
            {
                MessageBox.Show("Yeniləndi");
                GetAll();
                Clear();
                txb_UpdateName.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Xəta");
            }
        }
    }
}
