using Proj.Business.Abstract;
using Proj.Business.Concrete;
using Proj.Business.Models;
using Proj.Business.Static;
using Proj.DataAccess.Concrete.EF;
using Proj.Entity.Concrete;
using Proj.Inteko.MyForms.LogForms;
using Proj.Inteko.MyForms.ProductForms;
using Proj.Inteko.MyForms.RegulationForms;
using Proj.Inteko.MyForms.ReportForms;
using Proj.Inteko.MyForms.UserForms;
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
    public partial class DirectorBridgeForm : Form
    {
        ILogService logService = new LogManager(new LogRepository());
        public DirectorBridgeForm()
        {
            InitializeComponent();
        }

        

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            var user = Static.User;
            LogoutLog(user);
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void btn_Control_Click(object sender, EventArgs e)
        {
            ControlForm controlForm = new ControlForm();
            controlForm.ShowDialog();
        }

        private void btn_AddUpdate_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }

        private void btn_EmployeeInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserInfoForm userInfoForm = new UserInfoForm();
            userInfoForm.ShowDialog();
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

        private void btn_Log_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogForm logForm = new LogForm();
            logForm.ShowDialog();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportForm reportForm = new ReportForm();
            reportForm.ShowDialog();
        }

        private void btn_Regulations_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegulationBridgeForm regulationBridgeForm = new RegulationBridgeForm();
            regulationBridgeForm.ShowDialog();
        }
    }
}
