using Proj.Business.Abstract;
using Proj.Business.Concrete;
using Proj.Business.Models;
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
using static Proj.Inteko.MyForms.ProductForms.AddProductForm;

namespace Proj.Inteko.MyForms.ProductForms
{
    public partial class AddPhoneNumberForm : Form
    {
        IPhoneService phoneService = new PhoneManager(new PhoneRepository());
        public AddPhoneNumberForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddNumber_Click(object sender, EventArgs e)
        {
            Guid id = ProductInfo.ProductId;
            if (Check())
            {
                PhoneModel model = new PhoneModel()
                {
                    EmployeeName=txb_Name.Text,
                    EmployeeSurname=txb_Surname.Text,
                    Position=txb_Position.Text,
                    Number=txb_Number.Text,
                    ProductId=id
                };
                var added = phoneService.Create(model);
                if (added)
                {
                    string message = "Nömrə uğurla əlavə edildi.Yeni nömrə əlavə etmək istəryirsiniz?";
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
                    }
                
                    
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
            
        }



        private bool Check()
        {
            if(!string.IsNullOrEmpty(txb_Name.Text) &&
            !string.IsNullOrEmpty(txb_Surname.Text) &&
            !string.IsNullOrEmpty(txb_Position.Text) &&
            !string.IsNullOrEmpty(txb_Number.Text)
                )
            {
                return true;
            }
            else { return false; }
        }
        private void Clean()
        {
            txb_Name.Clear();
            txb_Surname.Clear();
            txb_Position.Clear();
            txb_Number.Clear();
        }
    }
}
