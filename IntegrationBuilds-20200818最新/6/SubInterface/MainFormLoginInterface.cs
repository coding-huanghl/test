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
    public partial class MainFormLoginInterface : UserControl
    {
        MainForm mainForm ;
       


        public MainFormLoginInterface(MainForm  temp)
        {
            InitializeComponent();
            mainForm = temp;
            
        }
        

        private void MainFormLoginInterface_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt32( Global.isEnglish) == 0 )
            {
                cb_UserType.Items.Clear();
                cb_UserType.Items.Add("管理员");
                cb_UserType.Items.Add("操作工");
            }
            else
            {
                cb_UserType.Items.Clear();
                cb_UserType.Items.Add("Administrator");
                cb_UserType.Items.Add("Operator");
            }

        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            if (cb_UserType.SelectedItem == null) return;
            if (cb_UserType.SelectedItem.ToString() == "管理员" || cb_UserType.SelectedItem.ToString() == "Administrator")
            {
                if (tb_PassWord.Text == Global.passWordAdministrator)
                {
                    //管理员登陆成功，更改主界面显示
                   
                    mainForm.btnMainFormPositiveInterface.Enabled = true;
                    if(Convert.ToBoolean(Convert.ToInt32(Global.isDoubleDetect)))
                    {
                        mainForm.btnMainFormNegativeInterface.Enabled = true;
                    }
                    else
                    {
                        mainForm.btnMainFormNegativeInterface.Enabled = false;
                    }
                    mainForm.btnMainFormRecipe.Enabled = true;
                    mainForm.btnMainFormStatistics.Enabled = true;
                    mainForm.btnMainFormNGStatistics.Enabled = true;
                    mainForm.btnMainFormUserLogin.Enabled = true;
                    mainForm.btnMainFormUserManager.Enabled = true;
                    mainForm.btnMainFormExit.Enabled = true;
                    
                    mainForm.mfPositiveInterface.Visible = true;
                    mainForm.mfNegativeInterface.Visible = false;
                    mainForm.mfParameterInterface.Visible = false;
                    mainForm.mfStatisticsInterface.Visible = false;
                    mainForm.mfNGStatisticsInterface.Visible = false;
                    mainForm.mfLoginInterface.Visible = false;
                    mainForm.mfUserManagerInterface.Visible = false;

                    mainForm.btnMainFormPositiveInterface.BackColor = Color.Lime;
                    mainForm.btnMainFormNegativeInterface.BackColor = Color.White;
                    mainForm.btnMainFormRecipe.BackColor = Color.White;
                    mainForm.btnMainFormStatistics.BackColor = Color.White;
                    mainForm.btnMainFormNGStatistics.BackColor = Color.White;
                    mainForm.btnMainFormUserLogin.BackColor = Color.White;
                    mainForm.btnMainFormUserManager.BackColor = Color.White;

                   

                    Global.userType = "1";

                    //刷新主界面状态信息
                    if (!Convert.ToBoolean(Convert.ToInt32(Global.isEnglish)))
                    {
                        mainForm.lblCurrentUser.Text = "管理员";
                        mainForm.lblCurrentState.Text = "程序停止";
                    }
                    else
                    {
                        mainForm.lblCurrentUser.Text = "Administrator";
                        mainForm.lblCurrentState.Text = "Program Stop";
                    }
                }
                else
                {
                    MessageBox.Show("密码错误");
                }

            }
            else if (cb_UserType.SelectedItem.ToString() == "操作工" || cb_UserType.SelectedItem.ToString() == "Operator")
            {
                if (tb_PassWord.Text == Global.passWordHandlers)
                {
                    
                    //操作工登陆成功，更改主界面显示
                    mainForm.btnMainFormPositiveInterface.Enabled = true;
                    if (Convert.ToBoolean(Convert.ToInt32(Global.isDoubleDetect)))
                    {
                        mainForm.btnMainFormNegativeInterface.Enabled = true;
                    }
                    else
                    {
                        mainForm.btnMainFormNegativeInterface.Enabled = false;
                    }
                    mainForm.btnMainFormRecipe.Enabled = false;
                    mainForm.btnMainFormStatistics.Enabled = true;
                    mainForm.btnMainFormNGStatistics.Enabled = true;
                    mainForm.btnMainFormUserLogin.Enabled = true;
                    mainForm.btnMainFormUserManager.Enabled = false;
                    mainForm.btnMainFormExit.Enabled = true;
                    
                    mainForm.mfPositiveInterface.Visible = true;
                    mainForm.mfNegativeInterface.Visible = false;
                    mainForm.mfParameterInterface.Visible = false;
                    mainForm.mfStatisticsInterface.Visible = false;
                    mainForm.mfNGStatisticsInterface.Visible = false;
                    mainForm.mfLoginInterface.Visible = false;
                    mainForm.mfUserManagerInterface.Visible = false;

                    mainForm.btnMainFormPositiveInterface.BackColor = Color.Lime;
                    mainForm.btnMainFormNegativeInterface.BackColor = Color.White;
                    mainForm.btnMainFormRecipe.BackColor = Color.White;
                    mainForm.btnMainFormStatistics.BackColor = Color.White;
                    mainForm.btnMainFormNGStatistics.BackColor = Color.White;
                    mainForm.btnMainFormUserLogin.BackColor = Color.White;
                    mainForm.btnMainFormUserManager.BackColor = Color.White;


                    Global.userType = "2";

                    //刷新主界面状态信息
                    if (!Convert.ToBoolean(Convert.ToInt32(Global.isEnglish)))
                    {
                        mainForm.lblCurrentUser.Text = "操作员";
                        mainForm.lblCurrentState.Text = "程序停止";
                    }
                    else
                    {
                        mainForm.lblCurrentUser.Text = "Operator";
                        mainForm.lblCurrentState.Text = "Program Stop";
                    }
                }
                else
                {
                    MessageBox.Show("密码错误");
                }

            }
        }
    }
}
