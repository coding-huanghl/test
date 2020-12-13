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
    public partial class MainFormPositiveInterface : UserControl
    {
        private MainForm mainForm;
        public HTuple hWindowIDOne, hWindowIDTwo, hWindowIDOne1, hWindowIDOne2, hWindowIDOne3, hWindowIDTwo1, hWindowIDTwo2, hWindowIDTwo3;
        public MainFormPositiveInterface(MainForm temp)
        {
            InitializeComponent();
            mainForm = temp;
            CheckForIllegalCrossThreadCalls = false;
            chkCalibrationPositiveA.Checked = false;
            btnCalibrationPositiveA.Enabled = false;
            chkCalibrationPositiveB.Checked = false;
            btnCalibrationPositiveB.Enabled = false;

        }

        private void btnPositiveInterfaceRun_Click(object sender, EventArgs e)
        {
           
            //链接相机
            if (mainForm.ConnectCamerasPositive())
            {
                //刷新配方参数
                mainForm.RefreshRecipeGlobalParameter();
                mainForm.RefreshRecipeParameterPositiveA();
                mainForm.RefreshRecipeParameterPositiveB();

                mainForm.InitNGArray();
                //开始检测
                mainForm.bl_IsRunPositive = true;
                mainForm.bl_IsReDetectPositive = false;
                //清空采集图像队列
                mainForm.ImageQueuePositiveA.Clear();
                mainForm.ImageQueuePositiveB.Clear();
                
                btnPositiveInterfaceReDetectA.Enabled = false;
                btnPositiveInterfaceReDetectB.Enabled = false;

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
                       DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss:ff") + " 正面程序运行");
            }
        }


        private void btnPositiveInterfaceStop_Click(object sender, EventArgs e)
        {
            //停止检测
            mainForm.bl_IsRunPositive = false;

            btnPositiveInterfaceReDetectA.Enabled = true;
            btnPositiveInterfaceReDetectB.Enabled = true;

            
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
            string singleClassNGPositiveAStr = null;
            foreach (string str in mainForm.singleClassNGPositiveA.Info)
            {
                if (str != null)
                {
                    singleClassNGPositiveAStr = str;
                    break;
                }
            }
            if (singleClassNGPositiveAStr != null)
            {
                //isSingleClassOKPositiveB = false;
                mainForm.idOfPositiveA++;
                mainForm.singleClassNGPositiveA.UpdateDone = false;
                mainForm.singleClassNGPositiveAList.Add(mainForm.singleClassNGPositiveA);
                mainForm.singleClassNGPositiveA = new SingleClassNG();
            }


            string singleClassNGPositiveBStr = null;
            foreach (string str in mainForm.singleClassNGPositiveB.Info)
            {
                if (str != null)
                {
                    singleClassNGPositiveBStr = str;
                    break;
                }
            }
            if (singleClassNGPositiveBStr != null)
            {
                mainForm.idOfPositiveB++;
                //isSingleClassOKPositiveB = false;
                mainForm.singleClassNGPositiveB.UpdateDone = false;
                mainForm.singleClassNGPositiveBList.Add(mainForm.singleClassNGPositiveB);
                mainForm.singleClassNGPositiveB = new SingleClassNG();
            }

            mainForm.InitNGArryPositive();
            Global.SaveLog("D:\\Program Files\\Config\\033\\参数修改日志.txt",
                        DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss:ff") + " 正面程序停止" );
        }

        private void btnPositiveInterfaceReDetectA_Click(object sender, EventArgs e)
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
                //HOperatorSet.SetPart(WindowsHandlePositiveA, 0, 0, h, w);
                //HOperatorSet.DispObj(tempImageReDetectA, WindowsHandlePositiveA);

                mainForm.RefreshRecipeGlobalParameter();
                mainForm.RefreshRecipeParameterPositiveA();
                lock (mainForm.LockObjectPositiveA)
                {
                   
                    mainForm.ImageQueuePositiveA.Enqueue(tempImageReDetectA);   
                    mainForm.bl_IsReDetectPositive = true;
                }
            }
        }

        private void btnPositiveInterfaceReDetectB_Click(object sender, EventArgs e)
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
                //HOperatorSet.SetPart(WindowsHandlePositiveB, 0, 0, h, w);
                //HOperatorSet.DispObj(tempImageReDetectB, WindowsHandlePositiveB);
                mainForm.RefreshRecipeGlobalParameter();
                mainForm.RefreshRecipeParameterPositiveB();
                lock (mainForm.LockObjectPositiveB)
                {
                    mainForm.ImageQueuePositiveB.Enqueue(tempImageReDetectB);
                    mainForm.bl_IsReDetectPositive = true;
                }
            }
        }

        private void chkParameterAssistantROI_CheckedChanged(object sender, EventArgs e)
        {
            mainForm.IsOpenParameterAssistantROIPositive = new HTuple(Convert.ToInt32(chkParameterAssistantROI.Checked));
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
            if (hv_r1 <= 0 || hv_r1 >= mainForm.ImageHeightPositiveA)
                hv_r1 = (HTuple)0;
            if (hv_c1 <= 0 || hv_c1 >= mainForm.ImageHeightPositiveA)
                hv_c1 = (HTuple)0;
            if (hv_r2 <= 0 || hv_r2 >= mainForm.ImageHeightPositiveA)
                hv_r2 = (HTuple)mainForm.ImageHeightPositiveA - 1;
            if (hv_c2 <= 0 || hv_c2 >= mainForm.ImageWidthPositiveA)
                hv_c2 = (HTuple)mainForm.ImageWidthPositiveA - 1;

            if ((int)(new HTuple(hv_r1.TupleEqual(hv_r2))) != 0)
                hv_r2 = hv_r1 + 1;
            if ((int)(new HTuple(hv_c1.TupleEqual(hv_c2))) != 0)
                hv_c2 = hv_c1 + 1;
        }
        
        private void hWindowControl1_HMouseDown(object sender, HMouseEventArgs e)
        {
            if (mainForm.ho_MainImagePositiveA == null) return;
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

        private void hWindowControl1_HMouseMove(object sender, HMouseEventArgs e)
        {
            HTuple x = 0, y = 0, z = 0;

            x = e.X;
            y = e.Y;

            if (mainForm.ho_MainImagePositiveA != null && mainForm.ImageHeightPositiveA != null)
            {
                try
                {
                    HOperatorSet.GetGrayval(mainForm.ho_MainImagePositiveA, y, x, out z);
                }
                catch
                {
                    if (x > 4096)
                    {
                        x = 4096;
                    }
                    if (y > mainForm.ImageHeightPositiveA)
                    {
                        y = mainForm.ImageHeightPositiveA;
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
                HOperatorSet.DispObj(mainForm.ho_MainImagePositiveA, hWindowIDOne);
#endif

            }
            catch { }
        }

        private void lblTcpConnectedStateA_Click(object sender, EventArgs e)
        {

        }

        private void btnCalibrationPositiveB_Click(object sender, EventArgs e)
        {
            if (Global.stringType == "负间距")
            {
                try
                {
                    if (mainForm.ho_MainImagePositiveB == null)
                    {
                        MessageBox.Show("B没有图像,请复测一张图像");
                        return;
                    }
                    HOperatorSet.SetColor(hWindowControl2.HalconWindow, "green");
                    HOperatorSet.DrawRectangle1(hWindowControl2.HalconWindow, out rowStart, out columnStart, out rowEnd, out columnEnd);
                    mainForm.CalibrationPositiveB(rowStart, columnStart, rowEnd, columnEnd);


                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("此类型工艺不需要标定");
                chkCalibrationPositiveB.Checked = false;
            }

        }

        private void chkCalibrationPositiveB_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCalibrationPositiveB.Checked)
            {
                btnCalibrationPositiveB.Enabled = true;
            }
            else
            {
                btnCalibrationPositiveB.Enabled = false;
            }
        }

        private void btnSaveAsCalibrationPositiveA_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();//定义新的文件保存位置控件
            saveFileDialog.InitialDirectory = "D:\\Program Files\\Config\\033\\";
            saveFileDialog.Filter = "shm文件(*.shm)|*.shm";//设置文件后缀的过滤
            if (saveFileDialog.ShowDialog() == DialogResult.OK)//如果有文件保存路径
            {
                string newFilePath = saveFileDialog.FileName.ToString();

                if (!System.IO.File.Exists(newFilePath))
                {
                    System.IO.File.Copy(lblCalibrationPositiveA.Text, newFilePath);
                    lblCalibrationPositiveA.Text = newFilePath;
                }
                else
                {
                    if (lblCalibrationPositiveA.Text != newFilePath)
                    {
                        System.IO.File.Delete(newFilePath);
                        System.IO.File.Copy(lblCalibrationPositiveA.Text, newFilePath);
                        lblCalibrationPositiveA.Text = newFilePath;
                    }
                }
                // this.SaveOtherRecipe(saveFileDialog.FileName);
            }
        }

        private void btnSaveAsCalibrationPositiveB_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();//定义新的文件保存位置控件
            saveFileDialog.InitialDirectory = "D:\\Program Files\\Config\\033\\";
            saveFileDialog.Filter = "shm文件(*.shm)|*.shm";//设置文件后缀的过滤
            if (saveFileDialog.ShowDialog() == DialogResult.OK)//如果有文件保存路径
            {
                string newFilePath = saveFileDialog.FileName.ToString();

                if (!System.IO.File.Exists(newFilePath))
                {
                    System.IO.File.Copy(lblCalibrationPositiveB.Text, newFilePath);
                    lblCalibrationPositiveB.Text = newFilePath;
                }
                else
                {
                    if (lblCalibrationPositiveB.Text != newFilePath)
                    {
                        System.IO.File.Delete(newFilePath);
                        System.IO.File.Copy(lblCalibrationPositiveB.Text, newFilePath);
                        lblCalibrationPositiveB.Text = newFilePath;
                    }
                }
                // this.SaveOtherRecipe(saveFileDialog.FileName);
            }
        }

        private void btnReadCalibrationPositiveA_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "D:\\Program Files\\Config\\033\\";
            openFileDialog.Filter = "shm文件(*.shm) | *.shm";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                mainForm.HFuncPositiveA.ReadModel(out mainForm.ho_ModelContoursPositiveA, openFileDialog.FileName, out mainForm.ho_ModelIDPositiveA);
                lblCalibrationPositiveA.Text = openFileDialog.FileName;
            }
        }

        private void btnReadCalibrationPositiveB_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "D:\\Program Files\\Config\\033\\";
            openFileDialog.Filter = "shm文件(*.shm) | *.shm";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                mainForm.HFuncPositiveB.ReadModel(out mainForm.ho_ModelContoursPositiveB, openFileDialog.FileName, out mainForm.ho_ModelIDPositiveB);
                lblCalibrationPositiveB.Text = openFileDialog.FileName;
            }
        }

        private void hWindowControl1_HMouseUp(object sender, HMouseEventArgs e)
        {
            bl_IsMove = false;
        }
        HDevelopExport CalibrationPositiveA = new HDevelopExport();
        public HTuple rowStart, columnStart, rowEnd, columnEnd;

        private void btnCalibrationPositive_Click(object sender, EventArgs e)
        {
            if (Global.stringType== "负间距")
            {
                try
                {
                    if (mainForm.ho_MainImagePositiveA == null)
                    {
                        MessageBox.Show("A没有图像,请复测一张图像");
                        return;
                    }
                    HOperatorSet.SetColor(hWindowControl1.HalconWindow, "green");
                    HOperatorSet.DrawRectangle1(hWindowControl1.HalconWindow, out rowStart, out columnStart, out rowEnd, out columnEnd);
                    mainForm.CalibrationPositiveA(rowStart, columnStart, rowEnd, columnEnd);
                  

                }
                catch
                {
                   
                }
            }
            else
            {
                MessageBox.Show("此类型工艺不需要标定");
                chkCalibrationPositiveA.Checked = false;
            }
            
            

        }

        private void chkCalibrationPositive_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkCalibrationPositiveA.Checked)
            {
                btnCalibrationPositiveA.Enabled = true;
            }
            else
            {
                btnCalibrationPositiveA.Enabled = false;
            }
        }

        private void chkCalibrationPositive_CheckedChanged(object sender, EventArgs e)
        {
            if(chkCalibrationPositiveA.Checked)
            {
                btnCalibrationPositiveA.Enabled = true;
            }
            else
            {
                btnCalibrationPositiveA.Enabled = false;
            }
        }

        private void hWindowControl1_HMouseWheel(object sender, HMouseEventArgs e)
        {
            try
            {
                if (mainForm.ho_MainImagePositiveA != null)
                {
                    double ratio = 2.0;
                    if (e.Delta > 0) ratio = 0.5;
                    HTuple row1, col1, row2, col2;
                    row1 = e.Y - (e.Y - hWindowControl1.ImagePart.Y) * ratio;
                    col1 = e.X - (e.X - hWindowControl1.ImagePart.X) * ratio;
                    row2 = e.Y + (hWindowControl1.ImagePart.Bottom - e.Y) * ratio;
                    col2 = e.X + (hWindowControl1.ImagePart.Right - e.X) * ratio;
                    row1 = row1 > 0 ? row1 : (HTuple)0;
                    col1 = col1 > 0 ? col1 : (HTuple)0;
                    row2 = row2 < mainForm.ImageHeightPositiveA ? row2 : mainForm.ImageHeightPositiveA;
                    col2 = col2 < mainForm.ImageWidthPositiveA ? col2 : mainForm.ImageWidthPositiveA;
                    HOperatorSet.SetPart(hWindowIDOne, row1, col1, row2, col2);
                    HOperatorSet.DispObj(mainForm.ho_MainImagePositiveA, hWindowIDOne);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            if (mainForm.ho_MainImagePositiveA == null) return;
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
                HOperatorSet.DispObj(mainForm.ho_MainImagePositiveA, hWindowIDOne);
#if CPlusPlus
                ShowImage(DE.htup_WindowHandle, DE.bl_showdefect);
#else
                //DT_CSharp.ShowImage_CSharp(hobj_ImageZoom, WindowsHandlePositiveA);
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
            if (hv_r1 <= 0 || hv_r1 >= mainForm.ImageHeightPositiveB)
                hv_r1 = (HTuple)0;
            if (hv_c1 <= 0 || hv_c1 >= mainForm.ImageHeightPositiveB)
                hv_c1 = (HTuple)0;
            if (hv_r2 <= 0 || hv_r2 >= mainForm.ImageHeightPositiveB)
                hv_r2 = (HTuple)mainForm.ImageHeightPositiveB - 1;
            if (hv_c2 <= 0 || hv_c2 >= mainForm.ImageWidthPositiveB)
                hv_c2 = (HTuple)mainForm.ImageWidthPositiveB - 1;

            if ((int)(new HTuple(hv_r1.TupleEqual(hv_r2))) != 0)
                hv_r2 = hv_r1 + 1;
            if ((int)(new HTuple(hv_c1.TupleEqual(hv_c2))) != 0)
                hv_c2 = hv_c1 + 1;
        }

        private void hWindowControl2_HMouseDown(object sender, HMouseEventArgs e)
        {
            if (mainForm.ho_MainImagePositiveB == null) return;
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

        private void hWindowControl2_HMouseMove(object sender, HMouseEventArgs e)
        {
            HTuple x = 0, y = 0, z = 0;

            x = e.X;
            y = e.Y;

            if (mainForm.ho_MainImagePositiveB != null && mainForm.ImageHeightPositiveB != null)
            {
                try
                {
                    HOperatorSet.GetGrayval(mainForm.ho_MainImagePositiveB, y, x, out z);
                }
                catch
                {
                    if (x > 4096)
                    {
                        x = 4096;
                    }
                    if (y > mainForm.ImageHeightPositiveB)
                    {
                        y = mainForm.ImageHeightPositiveB;
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
                HOperatorSet.DispObj(mainForm.ho_MainImagePositiveB, hWindowIDTwo);
#endif

            }
            catch { }
        }

        private void hWindowControl2_HMouseUp(object sender, HMouseEventArgs e)
        {
            bl_IsMoveB = false;
        }

        private void hWindowControl2_HMouseWheel(object sender, HMouseEventArgs e)
        {
            try
            {
                if (mainForm.ho_MainImagePositiveB != null)
                {
                    double ratio = 2.0;
                    if (e.Delta > 0) ratio = 0.5;
                    HTuple row1, col1, row2, col2;
                    row1 = e.Y - (e.Y - hWindowControl2.ImagePart.Y) * ratio;
                    col1 = e.X - (e.X - hWindowControl2.ImagePart.X) * ratio;
                    row2 = e.Y + (hWindowControl2.ImagePart.Bottom - e.Y) * ratio;
                    col2 = e.X + (hWindowControl2.ImagePart.Right - e.X) * ratio;
                    row1 = row1 > 0 ? row1 : (HTuple)0;
                    col1 = col1 > 0 ? col1 : (HTuple)0;
                    row2 = row2 < mainForm.ImageHeightPositiveB ? row2 : mainForm.ImageHeightPositiveB;
                    col2 = col2 < mainForm.ImageWidthPositiveB ? col2 : mainForm.ImageWidthPositiveB;
                    HOperatorSet.SetPart(hWindowIDTwo, row1, col1, row2, col2);
                    HOperatorSet.DispObj(mainForm.ho_MainImagePositiveB, hWindowIDTwo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            if (mainForm.ho_MainImagePositiveB == null) return;
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
                HOperatorSet.DispObj(mainForm.ho_MainImagePositiveB, hWindowIDTwo);
#if CPlusPlus
                ShowImage(DE.htup_WindowHandle, DE.bl_showdefect);
#else
                //DT_CSharp.ShowImage_CSharp(hobj_ImageZoom, WindowsHandlePositiveA);
#endif
            }
            catch { }
        }

        private void MainFormPositiveInterface_Load(object sender, EventArgs e)
        {
            hWindowIDOne = hWindowControl1.HalconID;
            hWindowIDOne1 = hWindowControl1.HalconID;
            hWindowIDOne2 = hWindowControl3.HalconID;
            hWindowIDOne3 = hWindowControl4.HalconID;
            hWindowIDTwo = hWindowControl2.HalconID;
            hWindowIDTwo1 = hWindowControl2.HalconID;
            hWindowIDTwo2 = hWindowControl5.HalconID;
            hWindowIDTwo3 = hWindowControl6.HalconID;



        }
       
    }
}
