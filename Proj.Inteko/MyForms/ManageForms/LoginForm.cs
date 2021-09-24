using Proj.Business.Abstract;
using Proj.Business.Concrete;
using Proj.Business.Enums;
using Proj.DataAccess.Concrete.EF;
using Proj.Inteko.MyForms.BridgeForms;
using Proj.Inteko.MyForms.ManageForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj.Inteko.MyForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.ShowDialog();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (CheckTextBox())
            {
                IUserService userService = new UserManager(new UserRepository());
                var users = userService.GetAll();
                string username = txb_UserName.Text;
                string password = txb_Password.Text;
                bool check = false;
                foreach (var user in users)
                {
                    if(user.UserName==username && user.Password == password)
                    {
                        check = true;
                        if (user.Status == Status.Director.ToString())
                        {
                            MessageBox.Show("Director");
                        }
                        else
                        {
                            EmployeeBridgeForm employeeBridgeForm = new EmployeeBridgeForm();
                            employeeBridgeForm.ShowDialog();

                            
                        }
                    }
                    
                }
                if (!check)
                {
                    MessageBox.Show("İstifadəçi adı və ya parol səhvdir.");
                }
              
                
            }
            else
            {
                MessageBox.Show("Bütün xanaları doldurun.");
            }
        }



        private bool CheckTextBox()
        {
            if (!string.IsNullOrEmpty(txb_UserName.Text)
              &&!string.IsNullOrEmpty(txb_Password.Text)
               )
            {
                return true;
            }
            return false;
        }
    }
}
