using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HalconDotNet;

namespace _6
{
    public partial class MainFormNegativeInterface : UserControl
    {
        private MainForm mainForm;
        public HTuple hWindowIDOne, hWindowIDTwo;
        public MainFormNegativeInterface(MainForm temp)
        {
            InitializeComponent();
            mainForm = temp;
        }

        private void btnNegativeInterfaceRun_Click(object sender, EventArgs e)
        {
            //链接相机
            if (mainForm.ConnectCamerasNegative())
            {
                //刷新配方参数
                mainForm.RefreshRecipeGlobalParameter();
                mainForm.RefreshRecipeParameterNegativeA();
                mainForm.RefreshRecipeParameterNegativeB();

                mainForm.InitNGArray();
                //开始检测
                mainForm.bl_IsRunNegative = true;
                mainForm.bl_IsReDetectNegative = false;
                //清空采集图像队列
                mainForm.ImageQueueNegativeA.Clear();
                mainForm.ImageQueueNegativeB.Clear();

                btnNegativeInterfaceReDetectA.Enabled = false;
                btnNegativeInterfaceReDetectB.Enabled = false;

                #region 刷新主界面状态
                if (!Convert.ToBoolean(Convert.ToInt32(Global.isEnglish)))
                {
                    mainForm.lblCurrentState.Text = "程序运行中...";
                }
                else
                {
                    mainForm.lblCurrentState.Text = "Program Runing...";
                }

                mainForm.lblCurrentState.BackColor = System.Drawing.Color.Green;
                if (Global.userType == "1")
                {
                    if (!Convert.ToBoolean(Convert.ToInt32(Global.isEnglish)))
                    {
                        mainForm.lblCurrentUser.Text = "管理员";
                    }
                    else
                    {
                        mainForm.lblCurrentUser.Text = "Administrator";
                    }

                }
                else if (Global.userType == "2")
                {
                    if (!Convert.ToBoolean(Convert.ToInt32(Global.isEnglish)))
                    {
                        mainForm.lblCurrentUser.Text = "操作员";
                    }
                    else
                    {
                        mainForm.lblCurrentUser.Text = "Handles";
                    }

                }
                #endregion
                Global.SaveLog("D:\\Program Files\\Config\\033\\参数修改日志.txt",
                       DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss:ff") + "背面程序运行");
            }
        }

        private void btnNegativeInterfaceStop_Click(object sender, EventArgs e)
        {
            //停止检测
            mainForm.bl_IsRunNegative = false;

            btnNegativeInterfaceReDetectA.Enabled = true;
            btnNegativeInterfaceReDetectB.Enabled = true;


            if (!Convert.ToBoolean(Convert.ToInt32(Global.isEnglish)))
            {
                mainForm.lblCurrentState.Text = "程序已停止！";
            }
            else
            {
                mainForm.lblCurrentState.Text = "Program Stop！";
            }

            mainForm.lblCurrentState.BackColor = System.Drawing.Color.Red;
            //停止后NG数据加入列表，变量重置
            string singleClassNGNegativeAStr = null;
            foreach (string str in mainForm.singleClassNGNegativeA.Info)
            {
                if (str != null)
                {
                    singleClassNGNegativeAStr = str;
                    break;
                }
            }
            if (singleClassNGNegativeAStr != null)
            {
                mainForm.idOfNegativeA++;
                mainForm.singleClassNGNegativeA.UpdateDone = false;
                mainForm.singleClassNGNegativeAList.Add(mainForm.singleClassNGNegativeA);

                mainForm.singleClassNGNegativeA = new SingleClassNG();

            }

            string singleClassNGNegativeBStr = null;
            foreach (string str in mainForm.singleClassNGNegativeB.Info)
            {
                if (str != null)
                {
                    singleClassNGNegativeBStr = str;
                    break;
                }
            }
            if (singleClassNGNegativeBStr != null)
            {
                mainForm.idOfNegativeB++;
                mainForm.singleClassNGNegativeB.UpdateDone = false;
                mainForm.singleClassNGNegativeBList.Add(mainForm.singleClassNGNegativeB);

                mainForm.singleClassNGNegativeB = new SingleClassNG();

            }

            mainForm.InitNGArryNegative();
            Global.SaveLog("D:\\Program Files\\Config\\033\\参数修改日志.txt",
                       DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss:ff") + " 背面程序停止");
        }

        private void btnNegativeInterfaceReDetectA_Click(object sender, EventArgs e)
        {
            OpenFileDialog _openRecipe = new OpenFileDialog();
            _openRecipe.Filter = "图像(*.bmp)|*.jpg||*.bmp";
            if (_openRecipe.ShowDialog() == DialogResult.OK)
            {
                string filePathName = _openRecipe.FileName;
                HObject tempImageReDetectA;
                HOperatorSet.GenEmptyObj(out tempImageReDetectA);
                HOperatorSet.ReadImage(out tempImageReDetectA, filePathName);
                //HTuple w, h;
                //HOperatorSet.GetImageSize(tempImageReDetectA, out w, out h);
                //HOperatorSet.SetPart(WindowsHandleNegativeA, 0, 0, h, w);
                //HOperatorSet.DispObj(tempImageReDetectA, WindowsHandleNegativeA);
                mainForm.RefreshRecipeGlobalParameter();
                mainForm.RefreshRecipeParameterNegativeA();
                lock (mainForm.LockObjectNegativeA)
                {
                    mainForm.ImageQueueNegativeA.Enqueue(tempImageReDetectA);
                    mainForm.bl_IsReDetectNegative = true;
                }
            }
        }

        private void btnNegativeInterfaceReDetectB_Click(object sender, EventArgs e)
        {
            OpenFileDialog _openRecipe = new OpenFileDialog();
            _openRecipe.Filter = "图像(*.bmp)|*.jpg||*.bmp";
            if (_openRecipe.ShowDialog() == DialogResult.OK)
            {
                string filePathName = _openRecipe.FileName;
                HObject tempImageReDetectB;
                HOperatorSet.GenEmptyObj(out tempImageReDetectB);
                HOperatorSet.ReadImage(out tempImageReDetectB, filePathName);
                //HTuple w, h;
                //HOperatorSet.GetImageSize(tempImageReDetectB, out w, out h);
                //HOperatorSet.SetPart(WindowsHandleNegativeB, 0, 0, h, w);
                //HOperatorSet.DispObj(tempImageReDetectB, WindowsHandleNegativeB);
                mainForm.RefreshRecipeGlobalParameter();
                mainForm.RefreshRecipeParameterNegativeB();
                lock (mainForm.LockObjectNegativeB)
                {
                    mainForm.ImageQueueNegativeB.Enqueue(tempImageReDetectB);
                    mainForm.bl_IsReDetectNegative = true;
                }
            }
        }

        private void chkParameterAssistantROI_CheckedChanged(object sender, EventArgs e)
        {
            mainForm.IsOpenParameterAssistantROINegative = new HTuple(Convert.ToInt32(chkParameterAssistantROI.Checked));
        }

        //移动图片变量
        bool bl_IsMove, bl_IsMoveB;
        public HTuple hv_r1, hv_c1, hv_r2, hv_c2;             //窗口左上角、右下角 图像坐标
        public double[] dbl_Position = new double[4];        //图片平移起始位置坐标值
        public HTuple hv_r1B, hv_c1B, hv_r2B, hv_c2B;             //窗口左上角、右下角 图像坐标
        public double[] dbl_PositionB = new double[4];        //图片平移起始位置坐标值

        void GetPos(out HTuple row, out HTuple col)
        {
            HTuple button = null;
            try
            {
                HOperatorSet.GetMposition(hWindowIDOne, out row, out col, out button);
            }
            catch
            {
                row = 0;
                col = 0;
            }
        }

        void checkImgPos()
        {
            if (hv_r1 <= 0 || hv_r1 >= mainForm.ImageHeightNegativeA)
                hv_r1 = (HTuple)0;
            if (hv_c1 <= 0 || hv_c1 >= mainForm.ImageHeightNegativeA)
                hv_c1 = (HTuple)0;
            if (hv_r2 <= 0 || hv_r2 >= mainForm.ImageHeightNegativeA)
                hv_r2 = (HTuple)mainForm.ImageHeightNegativeA - 1;
            if (hv_c2 <= 0 || hv_c2 >= mainForm.ImageWidthNegativeA)
                hv_c2 = (HTuple)mainForm.ImageWidthNegativeA - 1;

            if ((int)(new HTuple(hv_r1.TupleEqual(hv_r2))) != 0)
                hv_r2 = hv_r1 + 1;
            if ((int)(new HTuple(hv_c1.TupleEqual(hv_c2))) != 0)
                hv_c2 = hv_c1 + 1;
        }

        private void hWindowControl3_HMouseDown(object sender, HMouseEventArgs e)
        {
            if (mainForm.ho_MainImageNegativeA == null) return;
            try
            {
                HTuple row, col;
                GetPos(out row, out col);
                dbl_Position[0] = col;
                dbl_Position[1] = row;
                bl_IsMove = true;

            }
            catch { }
        }

        private void hWindowControl3_HMouseMove(object sender, HMouseEventArgs e)
        {
            HTuple x = 0, y = 0, z = 0;

            x = e.X;
            y = e.Y;

            if (mainForm.ho_MainImageNegativeA != null && mainForm.ImageHeightNegativeA != null)
            {
                try
                {
                    HOperatorSet.GetGrayval(mainForm.ho_MainImageNegativeA, y, x, out z);
                }
                catch
                {
                    if (x > 4096)
                    {
                        x = 4096;
                    }
                    if (y > mainForm.ImageHeightNegativeA)
                    {
                        y = mainForm.ImageHeightNegativeA;
                    }
                }

                lblPointInfoRowA.Text = y.TupleInt().ToString();
                lblPointInfoColumnA.Text = x.TupleInt().ToString();
                lblPointInfoGrayValueA.Text = z.ToString();
            }


            if (!bl_IsMove) return;
            try
            {
                HTuple row, col;
                GetPos(out row, out col);

                dbl_Position[2] = col;
                dbl_Position[3] = row;

                double[] vec = { dbl_Position[2] - dbl_Position[0], dbl_Position[3] - dbl_Position[1] };
                hv_c1 = hv_c1 - vec[0];
                hv_c2 = hv_c2 - vec[0];
                hv_r1 = hv_r1 - vec[1];
                hv_r2 = hv_r2 - vec[1];
                HOperatorSet.SetPart(hWindowIDOne, hv_r1, hv_c1, hv_r2, hv_c2);

                //清除halconWindow窗口 ，避免闪屏
                HSystem.SetSystem("flush_graphic", "false");
                HOperatorSet.ClearWindow(hWindowIDOne);
                HSystem.SetSystem("flush_graphic", "true");

#if CPlusPlus
                ShowImage(DE.htup_WindowHandle, DE.bl_showdefect);
#else
                HOperatorSet.DispObj(mainForm.ho_MainImageNegativeA, hWindowIDOne);
#endif

            }
            catch { }
        }

        private void hWindowControl3_HMouseUp(object sender, HMouseEventArgs e)
        {
            bl_IsMove = false;
        }

        private void hWindowControl3_HMouseWheel(object sender, HMouseEventArgs e)
        {
            try
            {
                if (mainForm.ho_MainImageNegativeA != null)
                {
                    double ratio = 2.0;
                    if (e.Delta > 0) ratio = 0.5;
                    HTuple row1, col1, row2, col2;
                    row1 = e.Y - (e.Y - hWindowControl3.ImagePart.Y) * ratio;
                    col1 = e.X - (e.X - hWindowControl3.ImagePart.X) * ratio;
                    row2 = e.Y + (hWindowControl3.ImagePart.Bottom - e.Y) * ratio;
                    col2 = e.X + (hWindowControl3.ImagePart.Right - e.X) * ratio;
                    row1 = row1 > 0 ? row1 : (HTuple)0;
                    col1 = col1 > 0 ? col1 : (HTuple)0;
                    row2 = row2 < mainForm.ImageHeightNegativeA ? row2 : mainForm.ImageHeightNegativeA;
                    col2 = col2 < mainForm.ImageWidthNegativeA ? col2 : mainForm.ImageWidthNegativeA;
                    HOperatorSet.SetPart(hWindowIDOne, row1, col1, row2, col2);
                    HOperatorSet.DispObj(mainForm.ho_MainImageNegativeA, hWindowIDOne);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            if (mainForm.ho_MainImageNegativeA == null) return;
            try
            {
                HTuple row = null, col = null, button = null;
                try
                {
                    HOperatorSet.GetMposition(hWindowIDOne, out row, out col, out button);
                }
                catch
                {
                    row = 0;
                    col = 0;
                }

                if (e.Delta > 0)
                {
                    checkImgPos();
                    hv_r1 = (row - (row - hv_r1) / 2).TupleRound();
                    hv_c1 = (col - (col - hv_c1) / 2).TupleRound();
                    hv_r2 = (row - (row - hv_r2) / 2).TupleRound();
                    hv_c2 = (col - (col - hv_c2) / 2).TupleRound();
                    checkImgPos();
                }
                else
                {
                    checkImgPos();
                    hv_r1 = (row - (row - hv_r1) * 2).TupleRound();
                    hv_c1 = (col - (col - hv_c1) * 2).TupleRound();
                    hv_r2 = (row - (row - hv_r2) * 2).TupleRound();
                    hv_c2 = (col - (col - hv_c2) * 2).TupleRound();
                    checkImgPos();
                }
                HOperatorSet.SetPart(hWindowIDOne, hv_r1, hv_c1, hv_r2, hv_c2);
                HOperatorSet.DispObj(mainForm.ho_MainImageNegativeA, hWindowIDOne);
#if CPlusPlus
                ShowImage(DE.htup_WindowHandle, DE.bl_showdefect);
#else
                //DT_CSharp.ShowImage_CSharp(hobj_ImageZoom, WindowsHandleNegativeA);
#endif
            }
            catch { }
        }

        void GetPosB(out HTuple row, out HTuple col)
        {
            HTuple button = null;
            try
            {
                HOperatorSet.GetMposition(hWindowIDTwo, out row, out col, out button);
            }
            catch
            {
                row = 0;
                col = 0;
            }
        }

        void checkImgPosB()
        {
            if (hv_r1 <= 0 || hv_r1 >= mainForm.ImageHeightNegativeB)
                hv_r1 = (HTuple)0;
            if (hv_c1 <= 0 || hv_c1 >= mainForm.ImageHeightNegativeB)
                hv_c1 = (HTuple)0;
            if (hv_r2 <= 0 || hv_r2 >= mainForm.ImageHeightNegativeB)
                hv_r2 = (HTuple)mainForm.ImageHeightNegativeB - 1;
            if (hv_c2 <= 0 || hv_c2 >= mainForm.ImageWidthNegativeB)
                hv_c2 = (HTuple)mainForm.ImageWidthNegativeB - 1;

            if ((int)(new HTuple(hv_r1.TupleEqual(hv_r2))) != 0)
                hv_r2 = hv_r1 + 1;
            if ((int)(new HTuple(hv_c1.TupleEqual(hv_c2))) != 0)
                hv_c2 = hv_c1 + 1;
        }

        private void hWindowControl4_HMouseDown(object sender, HMouseEventArgs e)
        {
            if (mainForm.ho_MainImageNegativeB == null) return;
            try
            {
                HTuple row, col;
                GetPosB(out row, out col);
                dbl_PositionB[0] = col;
                dbl_PositionB[1] = row;
                bl_IsMoveB = true;

            }
            catch { }
        }

        private void hWindowControl4_HMouseMove(object sender, HMouseEventArgs e)
        {
            HTuple x = 0, y = 0, z = 0;

            x = e.X;
            y = e.Y;

            if (mainForm.ho_MainImageNegativeB != null && mainForm.ImageHeightNegativeB != null)
            {
                try
                {
                    HOperatorSet.GetGrayval(mainForm.ho_MainImageNegativeB, y, x, out z);
                }
                catch
                {
                    if (x > 4096)
                    {
                        x = 4096;
                    }
                    if (y > mainForm.ImageHeightNegativeB)
                    {
                        y = mainForm.ImageHeightNegativeB;
                    }
                }

                lblPointInfoRowB.Text = y.TupleInt().ToString();
                lblPointInfoColumnB.Text = x.TupleInt().ToString();
                lblPointInfoGrayValueB.Text = z.ToString();
            }


            if (!bl_IsMoveB) return;
            try
            {
                HTuple row, col;
                GetPosB(out row, out col);

                dbl_PositionB[2] = col;
                dbl_PositionB[3] = row;

                double[] vecB = { dbl_PositionB[2] - dbl_PositionB[0], dbl_PositionB[3] - dbl_PositionB[1] };
                hv_c1B = hv_c1B - vecB[0];
                hv_c2B = hv_c2B - vecB[0];
                hv_r1B = hv_r1B - vecB[1];
                hv_r2B = hv_r2B - vecB[1];
                HOperatorSet.SetPart(hWindowIDTwo, hv_r1B, hv_c1B, hv_r2B, hv_c2B);

                //清除halconWindow窗口 ，避免闪屏
                HSystem.SetSystem("flush_graphic", "false");
                HOperatorSet.ClearWindow(hWindowIDTwo);
                HSystem.SetSystem("flush_graphic", "true");

#if CPlusPlus
                ShowImage(DE.htup_WindowHandle, DE.bl_showdefect);
#else
                HOperatorSet.DispObj(mainForm.ho_MainImageNegativeB, hWindowIDTwo);
#endif

            }
            catch { }
        }

        private void hWindowControl4_HMouseUp(object sender, HMouseEventArgs e)
        {
            bl_IsMoveB = false;
        }

        private void hWindowControl4_HMouseWheel(object sender, HMouseEventArgs e)
        {
            try
            {
                if (mainForm.ho_MainImageNegativeB != null)
                {
                    double ratio = 2.0;
                    if (e.Delta > 0) ratio = 0.5;
                    HTuple row1, col1, row2, col2;
                    row1 = e.Y - (e.Y - hWindowControl4.ImagePart.Y) * ratio;
                    col1 = e.X - (e.X - hWindowControl4.ImagePart.X) * ratio;
                    row2 = e.Y + (hWindowControl4.ImagePart.Bottom - e.Y) * ratio;
                    col2 = e.X + (hWindowControl4.ImagePart.Right - e.X) * ratio;
                    row1 = row1 > 0 ? row1 : (HTuple)0;
                    col1 = col1 > 0 ? col1 : (HTuple)0;
                    row2 = row2 < mainForm.ImageHeightNegativeB ? row2 : mainForm.ImageHeightNegativeB;
                    col2 = col2 < mainForm.ImageWidthNegativeB ? col2 : mainForm.ImageWidthNegativeB;
                    HOperatorSet.SetPart(hWindowIDTwo, row1, col1, row2, col2);
                    HOperatorSet.DispObj(mainForm.ho_MainImageNegativeB, hWindowIDTwo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            if (mainForm.ho_MainImageNegativeB == null) return;
            try
            {
                HTuple row = null, col = null, button = null;
                try
                {
                    HOperatorSet.GetMposition(hWindowIDTwo, out row, out col, out button);
                }
                catch
                {
                    row = 0;
                    col = 0;
                }

                if (e.Delta > 0)
                {
                    checkImgPosB();
                    hv_r1B = (row - (row - hv_r1B) / 2).TupleRound();
                    hv_c1B = (col - (col - hv_c1B) / 2).TupleRound();
                    hv_r2B = (row - (row - hv_r2B) / 2).TupleRound();
                    hv_c2B = (col - (col - hv_c2B) / 2).TupleRound();
                    checkImgPosB();
                }
                else
                {
                    checkImgPosB();
                    hv_r1B = (row - (row - hv_r1B) * 2).TupleRound();
                    hv_c1B = (col - (col - hv_c1B) * 2).TupleRound();
                    hv_r2B = (row - (row - hv_r2B) * 2).TupleRound();
                    hv_c2B = (col - (col - hv_c2B) * 2).TupleRound();
                    checkImgPosB();
                }
                HOperatorSet.SetPart(hWindowIDTwo, hv_r1B, hv_c1B, hv_r2B, hv_c2B);
                HOperatorSet.DispObj(mainForm.ho_MainImageNegativeB, hWindowIDTwo);
#if CPlusPlus
                ShowImage(DE.htup_WindowHandle, DE.bl_showdefect);
#else
                //DT_CSharp.ShowImage_CSharp(hobj_ImageZoom, WindowsHandleNegativeA);
#endif
            }
            catch { }
        }

        private void MainFormNegativeInterface_Load(object sender, EventArgs e)
        {
            hWindowIDOne = hWindowControl3.HalconID;
            hWindowIDTwo = hWindowControl4.HalconID;
        }
    }
}
