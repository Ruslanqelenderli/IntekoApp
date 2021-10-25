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

namespace Proj.Inteko.MyForms.RegulationForms
{
    public partial class RegulationBridgeForm : Form
    {
        public RegulationBridgeForm()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            DirectorBridgeForm directorBridgeForm = new DirectorBridgeForm();
            directorBridgeForm.ShowDialog();
            
        }

        private void btn_Cash_Click(object sender, EventArgs e)
        {
            this.Hide();
            CashForm cashForm = new CashForm();
            cashForm.ShowDialog();
        }

        private void btn_Payment_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentForm form = new PaymentForm();
            form.ShowDialog();
        }
    }
}
