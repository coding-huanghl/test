using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _6
{
    public partial class MainFormUserManager : UserControl
    {
        MainForm mainForm;

        public MainFormUserManager(MainForm temp)
        {
            InitializeComponent();
            mainForm = temp;
        }

        private void btnPassWordManageFormOK_Click(object sender, EventArgs e)
        {
            if (cbxUserType.SelectedItem == null) return;
            if ((cbxUserType.SelectedItem.ToString() == "管理员") || (cbxUserType.SelectedItem.ToString() == "Administrator"))
            {
                if (txtOldPassWord.Text == Global.passWordAdministrator)
                {
                    if (txtNewPassWord.Text == txtConfirmNewPassWord.Text)
                    {
                        Global.passWordAdministrator = txtNewPassWord.Text;
                        Config.WriteIniData("Config", "PassWordAdministrator", Global.passWordAdministrator, mainForm.defaultRecipePath);
                        MessageBox.Show("密码修改成功！");
                    }
                    else
                        MessageBox.Show("两次密码输入不一致，请重新输入！！！");                   
                }
                else
                {
                    MessageBox.Show("原密码错误，请重新输入！！！");

                }

            }


            if ((cbxUserType.SelectedItem.ToString() == "操作员") || (cbxUserType.SelectedItem.ToString() == "Handlers"))
            {
                if (txtOldPassWord.Text == Global.passWordHandlers)
                {
                    if (txtNewPassWord.Text == txtConfirmNewPassWord.Text)
                    {
                        Global.passWordHandlers = txtNewPassWord.Text;
                        Config.WriteIniData("Config", "PassWordHandlers", Global.passWordHandlers, mainForm.defaultRecipePath);
                        MessageBox.Show("密码修改成功！");
                    }
                    else
                        MessageBox.Show("两次密码输入不一致，请重新输入！！！");                    
                }
                else
                {
                    MessageBox.Show("原密码错误，请重新输入！！！");
                }

            }
        }
    }
}
