using Proj.Business.Abstract;
using Proj.Business.Concrete;
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

namespace Proj.Inteko.MyForms.ReportForms
{
    public partial class ExpenseForm : Form
    {
        IExpenseTypeService expenseType = new ExpenseTypeManager(new ExpenseTypeRepository());
        IExpenseService expense = new ExpenseManager(new ExpenseRepository());
        ILogService logService = new LogManager(new LogRepository());
        public ExpenseForm()
        {
            InitializeComponent();
            cmb_Type.DataSource = expenseType.GetAll().Select(x=>x.Name).ToList();
            GetAll();
        }

        private void ExpenseForm_Load(object sender, EventArgs e)
        {
            btn_Remove.Visible = false;
            btn_Update.Visible = false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (Check())
                {
                    ExpenseModel model = new ExpenseModel()
                    {
                        Type = cmb_Type.Text,
                        Description = rtxb_Info.Text,
                        Price = Convert.ToDecimal(txb_Price.Text),
                        CreateDate = dt_CreateDate.Value
                    };

                    var result = expense.Create(model);
                    if (result == true)
                    {
                        AddExpenseLog(Static.User, model.Type);
                        MessageBox.Show("Əlavə olundu");
                        GetAll();
                        Clean();
                    }
                    else
                    {
                        MessageBox.Show("Xəta");
                    }
                }
                else
                {
                    MessageBox.Show("Xanaları doldurun");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Qiyməti düzgün daxil edin");
            }
            
            
        }

        private bool Check()
        {
            if(!string.IsNullOrEmpty(txb_Price.Text)
                && !string.IsNullOrEmpty(rtxb_Info.Text)
                )
            {
                return true;
            }
            return false;
        }



        private void GetAll()
        {
            var expenses = expense.GetAll().Select(x => new
            {
                Id=x.Id,
                Növ=x.Type,
                Qiymət=x.Price,
                Məlumat=x.Description,
                Tarix=x.CreateDate
            }).ToList();
            dgv_Expenses.DataSource = expenses;
        }


        private void Clean()
        {
            txb_Price.Clear();
            rtxb_Info.Clear();
            cmb_Type.SelectedIndex = 0;
        }
        private void AddExpenseLog(User user, string expenseType)
        {
            LogModel model = new LogModel()
            {
                Description = user.UserName + " adlı istifadəçi " + expenseType + " növlü xərci daxil etdi.",
                CreateDate = DateTime.Now
            };
            var result = logService.Create(model);
            if (!result)
            {
                MessageBox.Show("Log Xətası.");
            }
        }
        private void RemoveExpenseLog(User user,string expenseType)
        {
            LogModel model = new LogModel()
            {
                Description = user.UserName + " adlı istifadəçi "+ expenseType + " novlu  xərci  sildi.",
                CreateDate = DateTime.Now
            };
            var result = logService.Create(model);
            if (!result)
            {
                MessageBox.Show("Log Xətası.");
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            var expenses = expense.GetAll().Where(x=>x.CreateDate>=dt_StartDate.Value && x.CreateDate<=dt_EndDate.Value).Select(x => new
            {
                Id = x.Id,
                Növ = x.Type,
                Qiymət = x.Price,
                Məlumat = x.Description,
                Tarix = x.CreateDate
            }).ToList();
            dgv_Expenses.DataSource = expenses;
        }

        private void btn_GetAll_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            Guid id = (Guid)dgv_Expenses.CurrentRow.Cells[0].Value;
            Expense model = expense.GetByID(id);
            string message = "Silmək İstədiyinizə Əminsizin?";
            string title = "Bildiriş";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialog = MessageBox.Show(message, title, buttons);
            if (dialog == DialogResult.Yes)
            {

                var result = expense.Remove(id);
                if (result)
                {
                    RemoveExpenseLog(Static.User,model.Type);
                    MessageBox.Show("Silindi.");
                    GetAll();

                }
                else
                {
                    MessageBox.Show("Xəta.");
                }

            }
        }

        private void dgv_Expenses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Remove.Visible = true;
            btn_Update.Visible = true;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Guid id = (Guid)dgv_Expenses.CurrentRow.Cells[0].Value;
            var model = expense.GetByID(id);
            Static.Expense = model;
            ExpenseUpdateForm expenseUpdateForm = new ExpenseUpdateForm();
            expenseUpdateForm.ShowDialog();
        }

        private void ExpenseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            ReportForm form = new ReportForm();
            form.ShowDialog();

        }
    }
}
