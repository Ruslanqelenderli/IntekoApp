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
using static Proj.Inteko.MyForms.ProductForms.ControlForm;

namespace Proj.Inteko.MyForms.ProductForms
{
    public partial class PhoneNumberForm : Form
    {
        IPhoneService phoneService = new PhoneManager(new PhoneRepository());
        public PhoneNumberForm()
        {
            InitializeComponent();
            GetPhoneNumber();
        }

        private void dgv_PhoneList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }



        private void GetPhoneNumber()
        {
            var id = Static.Id;
            var phoneNumbers=phoneService.GetProductId(id).Select(x=>new { Ad_Soyad=x.EmployeeName+" "+x.EmployeeSurname,
                                                                           Vəzifə=x.Position,
                                                                           Nömrə=x.Number }).ToList();
            dgv_PhoneList.DataSource = phoneNumbers;
        }
    }
}
