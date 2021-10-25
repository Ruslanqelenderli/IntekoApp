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
    public partial class ExpenseTypeForm : Form
    {
        IExpenseTypeService expenseTypeService = new ExpenseTypeManager(new ExpenseTypeRepository());
        ILogService logService = new LogManager(new LogRepository());
        public ExpenseTypeForm()
        {
            InitializeComponent();
            GetAll();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            if (Check())
            {
                ExpenseTypeModel model = new ExpenseTypeModel()
                {
                    Name = txb_Name.Text
                };
                var added = expenseTypeService.Create(model);
                if (added)
                {
                    AddExpenseTypeLog(Static.User, model.Name);
                    string message = "Xərc növü uğurla əlavə edildi.Yeni xərc növü əlavə etmək istəryirsiniz?";
                    string title = "Bildiriş";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.No)
                    {

                        this.Close();
                    }
                    else
                    {
                        Clean();
                        GetAll();
                    }


                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
            else
            {
                MessageBox.Show("Xərc növü daxil edin.");
            }
            
        }
        private bool Check()
        {
            if (!string.IsNullOrEmpty(txb_Name.Text)
                )
            {
                return true;
            }
            else { return false; }
        }
        private void Clean()
        {
            txb_Name.Clear();

        }
        private void GetAll()
        {
            var expenseTypes = expenseTypeService.GetAll().Select(x => new
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
            dgv_ExpenseTypes.DataSource = expenseTypes;
        }
        private void AddExpenseTypeLog(User user, string expenseType)
        {
            LogModel model = new LogModel()
            {
                Description =user.UserName + " adlı istifadəçi " + expenseType + " adlı xərc növünü daxil etdi.",
                CreateDate = DateTime.Now
            };
            var result = logService.Create(model);
            if (!result)
            {
                MessageBox.Show("Log Xətası.");
            }
        }
        private void UpdateExpenseTypeLog(User user, string expenseType)
        {
            LogModel model = new LogModel()
            {
                Description = user.UserName + " adlı istifadəçi " + expenseType + " adlı xərc növünə düzəliş etdi.",
                CreateDate = DateTime.Now
            };
            var result = logService.Create(model);
            if (!result)
            {
                MessageBox.Show("Log Xətası.");
            }
        }
        private void RemoveExpenseTypeLog(User user, string expenseType)
        {
            LogModel model = new LogModel()
            {
                Description = user.UserName + " adlı istifadəçi " + expenseType + " adlı xərc növünü sildi.",
                CreateDate = DateTime.Now
            };
            var result = logService.Create(model);
            if (!result)
            {
                MessageBox.Show("Log Xətası.");
            }
        }

        private void ExpenseTypeForm_Load(object sender, EventArgs e)
        {
            btn_Remove.Visible = false;
        }

        private void dgv_ExpenseTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Remove.Visible = true;
            Guid id = (Guid)dgv_ExpenseTypes.CurrentRow.Cells[0].Value;
            var model = expenseTypeService.GetByID(id);
            txb_UpdateType.Text = model.Name.ToString();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            Guid id = (Guid)dgv_ExpenseTypes.CurrentRow.Cells[0].Value;
            string message = "Silmək İstədiyinizə Əminsizin?";
            string title = "Bildiriş";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialog = MessageBox.Show(message, title, buttons);
            if (dialog == DialogResult.Yes)
            {
                var model = expenseTypeService.GetByID(id);
                var result = expenseTypeService.Remove(id);
                
                if (result)
                {
                    RemoveExpenseTypeLog(Static.User, model.Name);
                    MessageBox.Show("Silindi.");
                    GetAll();
                    txb_UpdateType.Clear();

                }
                else
                {
                    MessageBox.Show("Xəta.");
                }

            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txb_UpdateType.Text))
            {
                Guid id = (Guid)dgv_ExpenseTypes.CurrentRow.Cells[0].Value;
                var model = expenseTypeService.GetByID(id);
                model.Name = txb_UpdateType.Text;
                var result = expenseTypeService.Update(model);
                if (result == true)
                {
                    UpdateExpenseTypeLog(Static.User, model.Name);
                    MessageBox.Show("Uğurlu əməliyyat");
                    GetAll();
                }
                else
                {
                    MessageBox.Show("Xəta");
                }
            }
            else
            {
                MessageBox.Show("Ad daxil edin");
                Guid id = (Guid)dgv_ExpenseTypes.CurrentRow.Cells[0].Value;
                var model = expenseTypeService.GetByID(id);
                txb_UpdateType.Text = model.Name;
            }
            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
