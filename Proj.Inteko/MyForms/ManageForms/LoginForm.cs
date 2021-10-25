using Proj.Business.Abstract;
using Proj.Business.Concrete;
using Proj.Business.Enums;
using Proj.Business.Models;
using Proj.Business.Static;
using Proj.DataAccess.Concrete.EF;
using Proj.Entity.Concrete;
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
        ILogService logService = new LogManager(new LogRepository());
        IUserService userService = new UserManager(new UserRepository());
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm form = new RegisterForm();
            form.ShowDialog();
            
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (CheckTextBox())
            {
                
                var users = userService.GetAll();
                string username = txb_UserName.Text;
                string password = txb_Password.Text;
                bool check = false;
                foreach (var user in users)
                {
                    if(user.UserName.ToLower()==username.ToLower() && user.Password == password)
                    {
                        check = true;
                        if (user.Status == Status.Director.ToString())
                        {
                            LoginLog(user);
                            Static.User = user;
                            DirectorBridgeForm employeeBridgeForm = new DirectorBridgeForm();
                            this.Hide();
                            employeeBridgeForm.ShowDialog();
                        }
                        else
                        {
                            LoginLog(user);
                            Static.User = user;
                            EmployeeBridgeForm employeeBridgeForm = new EmployeeBridgeForm();
                            this.Hide();
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
        private void LoginLog(User user)
        {
            LogModel model = new LogModel()
            {
                Description = user.UserName + " istifadəçisi giriş etdi.",
                CreateDate = DateTime.Now
            };
            var result = logService.Create(model);
            if (!result)
            {
                MessageBox.Show("Log Xətası.");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btn_Login;
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
