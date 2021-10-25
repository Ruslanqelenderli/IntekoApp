using Proj.Inteko.MyForms.BridgeForms;
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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void btn_ExpenceType_Click(object sender, EventArgs e)
        {
            ExpenseTypeForm expenseTypeForm = new ExpenseTypeForm();
            expenseTypeForm.ShowDialog();
            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            DirectorBridgeForm form = new DirectorBridgeForm();
            form.ShowDialog();
        }

        private void btn_Expense_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExpenseForm expenseForm = new ExpenseForm();
            expenseForm.ShowDialog();
        }
    }
}
