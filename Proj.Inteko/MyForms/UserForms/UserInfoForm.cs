using Proj.Business.Abstract;
using Proj.Business.Concrete;
using Proj.Business.Models;
using Proj.Business.Static;
using Proj.DataAccess.Concrete.EF;
using Proj.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj.Inteko.MyForms.UserForms
{
    public partial class UserInfoForm : Form
    {
        IUserService userService = new UserManager(new UserRepository());
        ILogService logService = new LogManager(new LogRepository());
        public UserInfoForm()
        {
            InitializeComponent();
            GetAllUser();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserInfoForm_Load(object sender, EventArgs e)
        {
            btn_Remove.Visible = false;

        }

        private void dgv_UserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Remove.Visible = true;
            
        }


        private void GetAllUser()
        {
            var users=userService.GetAll().Select(x => new
            {
                Id=x.Id,
                Ad = x.Name,
                Soyad = x.Surname,
                IstifadəçiAdı = x.UserName,
                ElektronPoçt = x.Email,
                Telefon = x.PhoneNumber,
                Rol = x.Status,
                Şifrə = x.Password

            }).ToList();
            dgv_UserList.DataSource = users;
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            Guid id = (Guid)dgv_UserList.CurrentRow.Cells[0].Value;
            string message = "Silmək İstədiyinizə Əminsizin?";
            string title = "Bildiriş";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialog = MessageBox.Show(message, title, buttons);
            if (dialog == DialogResult.Yes)
            {
                if (id != Static.User.Id)
                {
                    var user = Static.User;
                    var deletedUser = userService.GetByID(id);
                    var result = userService.Remove(id);
                    
                    if (result)
                    {
                        MessageBox.Show("Silindi.");
                        AccountRemoveLog(user, deletedUser);
                        GetAllUser();

                    }
                    else
                    {
                        MessageBox.Show("Xəta.");
                    }
                }
                else
                {
                    MessageBox.Show("Giriş etdiyiniz hesab silinmir.");
                }
                
            }

        }
        private void AccountRemoveLog(User user,User deletedUser )
        {
            LogModel model = new LogModel()
            {
                Description = user.UserName + " istifadəçisi " + deletedUser.UserName +" istifadəçisini sildi.",
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
