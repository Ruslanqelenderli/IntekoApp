using Proj.Business.Abstract;
using Proj.Business.Concrete;
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
            this.Close();
        }




        private void GetAllLog()
        {
            var logs = logService.GetAll().Select(x => new
            {

                Açıqlama = x.Description,
                Tarix = x.CreateDate.ToString("dd-MM-yyyy hh-mm-ss")
            }).OrderByDescending(x=>x.Tarix).ToList();

            dgv_AllLog.DataSource = logs;
        }

        private void LogForm_Load(object sender, EventArgs e)
        {

        }
    }
}
