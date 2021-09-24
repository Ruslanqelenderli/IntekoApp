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

namespace Proj.Inteko.MyForms.ManageForms
{
    public partial class RegisterForm : Form
    {
        
        public RegisterForm()
        {
            InitializeComponent();
        }

        

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (CheckTextBox())
            {
                if (CheckPassword())
                {
                    IUserService userService = new UserManager(new UserRepository());
                    var model = new UserModel()
                    {
                        Name = txb_Name.Text,
                        Surname = txb_Surname.Text,
                        UserName = txb_UserName.Text,
                        Email = txb_Email.Text,
                        PhoneNumber=txb_PhoneNumber.Text,
                        Password = txb_Password.Text
                    };
                    userService.Create(model);
                    string message = "İstifadəçi uğurla yaradıldı.Login səhifəsinə qayıtmaq istəyirsiniz?";
                    string title = "Bildiriş";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        this.Close();
                    }
                    else
                    {
                        ClearTextBox();
                    }
                }
                else
                {
                    MessageBox.Show("Şifrəni düzgün daxil edin.");
                }

            }
            else
            {
                MessageBox.Show("Bütün xanaları doldurun.");
            }
        }





        private bool CheckTextBox()
        {
            if (!string.IsNullOrEmpty(txb_Name.Text)
              && !string.IsNullOrEmpty(txb_Surname.Text)
              && !string.IsNullOrEmpty(txb_UserName.Text)
              && !string.IsNullOrEmpty(txb_Email.Text)
              && !string.IsNullOrEmpty(txb_PhoneNumber.Text)
              && !string.IsNullOrEmpty(txb_Password.Text)
              && !string.IsNullOrEmpty(txb_PasswordAgain.Text)
               )
            {
                return true;
            }
            return false;
        }
        private bool CheckPassword()
        {
            if (txb_Password.Text == txb_PasswordAgain.Text)
            {
                return true;
            }
            return false;
        }
        private void ClearTextBox()
        {
            txb_Name.Clear();
            txb_Surname.Clear();
            txb_Email.Clear();
            txb_UserName.Clear();
            txb_PhoneNumber.Clear();
            txb_Password.Clear();
            txb_PasswordAgain.Clear();
        }
    }
}
