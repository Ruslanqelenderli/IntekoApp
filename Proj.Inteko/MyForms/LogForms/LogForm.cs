using Proj.Business.Abstract;
using Proj.Business.Concrete;
using Proj.DataAccess.Concrete.EF;
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

namespace Proj.Inteko.MyForms.LogForms
{
    public partial class LogForm : Form
    {
        ILogService logService = new LogManager(new LogRepository());
        public LogForm()
        {
            InitializeComponent();
            GetAllLog();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            DirectorBridgeForm directorBridgeForm = new DirectorBridgeForm();
            directorBridgeForm.ShowDialog();
        }




        private void GetAllLog()
        {
            var logs = logService.GetAll().OrderByDescending(x=>x.CreateDate).Select(x => new
            {

                Açıqlama = x.Description,
                Tarix = x.CreateDate.ToString("dd-MM-yyyy HH-mm-ss")
            }).ToList();

            dgv_AllLog.DataSource = logs;
        }

        private void LogForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_AllLog_Click(object sender, EventArgs e)
        {
            GetAllLog();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            var expenses = logService.GetAll().OrderByDescending(x => x.CreateDate).Where(x => x.CreateDate >= dt_StartDate.Value && x.CreateDate <= dt_EndDate.Value).Select(x => new
            {
                Açıqlama = x.Description,
                Tarix = x.CreateDate.ToString("dd-MM-yyyy HH-mm-ss")
            }).ToList();
            dgv_AllLog.DataSource = expenses;
        }

        private void LogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            DirectorBridgeForm directorBridgeForm = new DirectorBridgeForm();
            directorBridgeForm.ShowDialog();
        }
    }
}
