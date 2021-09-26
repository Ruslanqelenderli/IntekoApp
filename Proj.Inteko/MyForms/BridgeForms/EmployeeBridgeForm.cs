using Proj.Business.Abstract;
using Proj.Business.Concrete;
using Proj.Business.Models;
using Proj.Business.Static;
using Proj.DataAccess.Concrete.EF;
using Proj.Entity.Concrete;
using Proj.Inteko.MyForms.ProductForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj.Inteko.MyForms.BridgeForms
{
    public partial class EmployeeBridgeForm : Form
    {
        ILogService logService = new LogManager(new LogRepository());
        public EmployeeBridgeForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }

        private void EmployeeBridgeForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var user = Static.User;
            LogoutLog(user);
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlForm controlForm = new ControlForm();
            controlForm.ShowDialog();
        }
        private void LogoutLog(User user)
        {
            LogModel model = new LogModel()
            {
                Description = user.UserName + " istifadəçisi çıxış etdi.",
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
