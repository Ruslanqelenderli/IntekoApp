using Proj.Business.Abstract;
using Proj.Business.Concrete;
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

namespace Proj.Inteko.MyForms.RegulationForms
{
    public partial class CashForm : Form
    {
        ICashService cashService = new CashManager(new CashRepository());
        public CashForm()
        {
            InitializeComponent();
        }

        private void CashForm_Load(object sender, EventArgs e)
        {
            
            GetAll();
            dgv_Cash.Columns[0].Visible = false;
            txb_UpdateName.ReadOnly = true;
            btn_Remove.Visible = false;
            
        }

        private void GetAll()
        {
            var cashes = cashService.GetAll().Select(x => new
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
            dgv_Cash.DataSource = cashes;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txb_AddName.Text))
            {
                var model = new CashModel()
                {
                    Name = txb_AddName.Text
                };
                var result = cashService.Create(model);
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
        private void Clear()
        {
            txb_AddName.Clear();
            txb_UpdateName.Clear();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            Guid id = (Guid)dgv_Cash.CurrentRow.Cells[0].Value;
            if (id != null)
            {
                var result = cashService.Remove(id);
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

        private void dgv_Cash_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txb_UpdateName.ReadOnly = false;
            txb_UpdateName.Text= (string)dgv_Cash.CurrentRow.Cells[1].Value;
            btn_Remove.Visible = true;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Guid id = (Guid)dgv_Cash.CurrentRow.Cells[0].Value;
            var entity = cashService.GetById(id);
            entity.Name = txb_UpdateName.Text;
            var result = cashService.Update(entity);
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

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegulationBridgeForm regulationBridgeForm = new RegulationBridgeForm();
            regulationBridgeForm.ShowDialog();
        }
    }
}
