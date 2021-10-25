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
    public partial class ExpenseUpdateForm : Form
    {
        IExpenseTypeService expenseType = new ExpenseTypeManager(new ExpenseTypeRepository());
        IExpenseService expense = new ExpenseManager(new ExpenseRepository());
        ILogService logService = new LogManager(new LogRepository());
        public ExpenseUpdateForm()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExpenseUpdateForm_Load(object sender, EventArgs e)
        {
            cmb_Type.DataSource = expenseType.GetAll().Select(x => x.Name).ToList();
            var model = Static.Expense;
            txb_Price.Text = model.Price.ToString();
            cmb_Type.SelectedItem = model.Type;
            dt_Date.Value = model.CreateDate;
            rtxb_Info.Text = model.Description;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (Check())
                {
                    var model = Static.Expense;
                    model.CreateDate = dt_Date.Value;
                    model.Price = Convert.ToDecimal(txb_Price.Text);
                    model.Description = rtxb_Info.Text;
                    model.Type = cmb_Type.SelectedItem.ToString();

                    var result = expense.Update(model);
                    if (result == true)
                    {
                        UpdateExpenseLog(Static.User, model.Type);
                        MessageBox.Show("Uğurlu əməliyyat");

                    }
                    else
                    {
                        MessageBox.Show("Xəta");
                    }
                }
                else
                {
                    MessageBox.Show("Xanaları doldurun.");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Qiyməti düzgün daxil edin.");
            }
            
        }
        private bool Check()
        {
            if (!string.IsNullOrEmpty(txb_Price.Text)
                && !string.IsNullOrEmpty(rtxb_Info.Text)
                )
            {
                return true;
            }
            return false;
        }
        private void UpdateExpenseLog(User user, string expenseType)
        {
            LogModel model = new LogModel()
            {
                Description = user.UserName + " adlı istifadəçi " + expenseType + " növlü xərcə düzəliş etdi.",
                CreateDate = DateTime.Now
            };
            var result = logService.Create(model);
            if (!result)
            {
                MessageBox.Show("Log Xətası.");
            }
        }
    }
}
