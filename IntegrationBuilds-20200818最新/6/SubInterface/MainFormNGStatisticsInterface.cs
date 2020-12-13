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
    public partial class MainFormNGStatisticsInterface : UserControl
    {
        MainForm mainForm;
        public MainFormNGStatisticsInterface(MainForm temp)
        {
            InitializeComponent();
            mainForm = temp;
        }
        
        private void timer_AutoResetDataAt0803And2030_Tick(object sender, EventArgs e)
        {
            //ClearMemory();
            try
            {
                //DateTime time = DateTime.Now;
                string dd = DateTime.Now.ToString("HHmmss");
                if ((Convert.ToInt32(dd) > 083000 && Convert.ToInt32(dd) < 083003) || (Convert.ToInt32(dd) > 203000 && Convert.ToInt32(dd) < 203003))
                {
                    lblTotalCountPositiveA.Text = "0";
                    lblNGTotalCountPositiveA.Text = "0";
                    lblMajorFailureCountPositiveA.Text = "0";
                    lblFilmShiftingCountPositiveA.Text = "0";
                    lblFilmMissCountPositiveA.Text = "0";
                    lblFilmShiftingHeadAndTailCountPositiveA.Text = "0";
                    lblDistanceNGCountPositiveA.Text = "0";
                    lblEdgeDefectCountPositiveA.Text = "0";
                    lblSurfaceDefectCountPositiveA.Text = "0";
                    lblBrokenLineCountPositiveA.Text = "0";
                    lblStartWeldingNGCountPositiveA.Text = "0";
                    lblSurfaceColorDiffCountPositiveA.Text = "0";

                    lblTotalCountNegativeA.Text = "0";
                    lblNGTotalCountNegativeA.Text = "0";
                    lblMajorFailureCountNegativeA.Text = "0";
                    lblFilmShiftingCountNegativeA.Text = "0";
                    lblFilmMissCountNegativeA.Text = "0";
                    lblFilmShiftingHeadAndTailCountNegativeA.Text = "0";
                    lblDistanceNGCountNegativeA.Text = "0";
                    lblEdgeDefectCountNegativeA.Text = "0";
                    lblSurfaceDefectCountNegativeA.Text = "0";
                    lblBrokenLineCountNegativeA.Text = "0";
                    lblStartWeldingNGCountNegativeA.Text = "0";
                    lblSurfaceColorDiffCountNegativeA.Text = "0";

                    lblTotalCountPositiveB.Text = "0";
                    lblNGTotalCountPositiveB.Text = "0";
                    lblMajorFailureCountPositiveB.Text = "0";
                    lblFilmShiftingCountPositiveB.Text = "0";
                    lblFilmMissCountPositiveB.Text = "0";
                    lblFilmShiftingHeadAndTailCountPositiveB.Text = "0";
                    lblDistanceNGCountPositiveB.Text = "0";
                    lblEdgeDefectCountPositiveB.Text = "0";
                    lblSurfaceDefectCountPositiveB.Text = "0";
                    lblBrokenLineCountPositiveB.Text = "0";
                    lblStartWeldingNGCountPositiveB.Text = "0";
                    lblSurfaceColorDiffCountPositiveB.Text = "0";
                    
                    lblTotalCountNegativeB.Text = "0";
                    lblNGTotalCountNegativeB.Text = "0";
                    lblMajorFailureCountNegativeB.Text = "0";
                    lblFilmShiftingCountNegativeB.Text = "0";
                    lblFilmMissCountNegativeB.Text = "0";
                    lblFilmShiftingHeadAndTailCountNegativeB.Text = "0";
                    lblDistanceNGCountNegativeB.Text = "0";
                    lblEdgeDefectCountNegativeB.Text = "0";
                    lblSurfaceDefectCountNegativeB.Text = "0";
                    lblBrokenLineCountNegativeB.Text = "0";
                    lblStartWeldingNGCountNegativeB.Text = "0";
                    lblSurfaceColorDiffCountNegativeB.Text = "0";
                }
            }
            catch
            {
                return;
            }
        }
        public void ClearStaticsPositiveA()//清空A正面数据
        {
            mainForm.TotalFilmShiftingCountPerClassPositiveA = 0;
            mainForm.TotalFilmMissCountPerClassPositiveA = 0;
            mainForm.TotalFilmShiftingOfHeadAndTailCountPerClassPositiveA = 0;
            mainForm.TotalDistanceNGCountPerClassPositiveA = 0;
            mainForm.TotalEdgeDefectCountPerClassPositiveA = 0;
            mainForm.TotalSurfaceDefectCountPerClassPositiveA = 0;
            mainForm.TotalBrokenLineCountPerClassPositiveA = 0;
            mainForm.TotalStartingWeldingNGCountPerClassPositiveA = 0;
            mainForm.TotalEmptyPlateCountPerClassPositiveA = 0;

            mainForm.TotalDistanceNGCountNegativeA = 0;
            mainForm.TotalFilmShiftingOfHeadAndTailCountNegativeA = 0;
            mainForm.TotalCountPositiveA = 0;
            mainForm.NGTotalCountPositiveA = 0;
            mainForm.MajorFailureCountPositiveA = 0;
            mainForm.TotalFilmShiftingCountPositiveA = 0;
            mainForm.TotalFilmMissCountPositiveA = 0;
            mainForm.TotalFilmShiftingOfHeadAndTailCountPositiveA = 0;
            mainForm.TotalDistanceNGCountPositiveA = 0;
            mainForm.TotalEdgeDefectCountPositiveA = 0;
            mainForm.TotalSurfaceDefectCountPositiveA = 0;
            mainForm.TotalBrokenLineCountPositiveA = 0;
            mainForm.TotalStartingWeldingNGCountPositiveA = 0;
            mainForm.TotalSurfaceColorDiffCountPositiveA = 0;
            mainForm.TotalLinearityNGCountPositiveA = 0;
            mainForm.TotalEmptyPlateCountPositiveA = 0;

            mainForm.ClearAllCurrentClusterStatePositiveA(1);
            Config.WriteIniData("Config", "TotalCount_PositiveA", lblTotalCountPositiveA.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "NGTotalCount_PositiveA", lblNGTotalCountPositiveA.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "MajorFailureCount_PositiveA", lblMajorFailureCountPositiveA.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "FilmShiftingCount_PositiveA", lblFilmShiftingCountPositiveA.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "FilmMissCount_PositiveA", lblFilmMissCountPositiveA.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "FilmShiftingHeadAndTailCountPositiveA", lblFilmShiftingHeadAndTailCountPositiveA.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "DistanceNGCount_PositiveA", lblDistanceNGCountPositiveA.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeDefectCount_PositiveA", lblEdgeDefectCountPositiveA.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectCount_PositiveA", lblSurfaceDefectCountPositiveA.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "BrokenLineCount_PositiveA", lblBrokenLineCountPositiveA.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "StartWeldingNGCount_PositiveA", lblStartWeldingNGCountPositiveA.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceColorDiffCount_PositiveA", lblSurfaceColorDiffCountPositiveA.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "FilmShiftingHeadAndTailCountNegativeA", lblCellMissingCountPositiveA.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "DistanceNGCount_NegativeA", lblAlgorithmExceptionCountPositiveA.Text, mainForm.defaultRecipePath);


            

           
           
            mainForm.IsFirstWaferOfFirstClassPositiveA = false;
        }
        public void ClearStaticsPositiveB()//清空B正面数据
        {
            mainForm.TotalFilmShiftingCountPerClassPositiveB = 0;
            mainForm.TotalFilmMissCountPerClassPositiveB = 0;
            mainForm.TotalFilmShiftingOfHeadAndTailCountPerClassPositiveB = 0;
            mainForm.TotalDistanceNGCountPerClassPositiveB = 0;
            mainForm.TotalEdgeDefectCountPerClassPositiveB = 0;
            mainForm.TotalSurfaceDefectCountPerClassPositiveB = 0;
            mainForm.TotalBrokenLineCountPerClassPositiveB = 0;
            mainForm.TotalStartingWeldingNGCountPerClassPositiveB = 0;
            mainForm.TotalEmptyPlateCountPerClassPositiveB = 0;

            mainForm.TotalDistanceNGCountNegativeB = 0;
            mainForm.TotalFilmShiftingOfHeadAndTailCountNegativeB = 0;
            mainForm.TotalCountPositiveB = 0;
            mainForm.NGTotalCountPositiveB = 0;
            mainForm.MajorFailureCountPositiveB = 0;
            mainForm.TotalFilmShiftingCountPositiveB = 0;
            mainForm.TotalFilmMissCountPositiveB = 0;
            mainForm.TotalFilmShiftingOfHeadAndTailCountPositiveB = 0;
            mainForm.TotalDistanceNGCountPositiveB = 0;
            mainForm.TotalEdgeDefectCountPositiveB = 0;
            mainForm.TotalSurfaceDefectCountPositiveB = 0;
            mainForm.TotalBrokenLineCountPositiveB = 0;
            mainForm.TotalStartingWeldingNGCountPositiveB = 0;
            mainForm.TotalSurfaceColorDiffCountPositiveB = 0;
            mainForm.TotalLinearityNGCountPositiveB = 0;
            mainForm.TotalEmptyPlateCountPositiveB = 0;

            mainForm.ClearAllCurrentClusterStatePositiveB(1);

            mainForm.IsFirstWaferOfFirstClassPositiveB = false;
            Config.WriteIniData("Config", "TotalCount_PositiveB", lblTotalCountPositiveB.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "NGTotalCount_PositiveB", lblNGTotalCountPositiveB.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "MajorFailureCount_PositiveB", lblMajorFailureCountPositiveB.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "FilmShiftingCount_PositiveB", lblFilmShiftingCountPositiveB.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "FilmMissCount_PositiveB", lblFilmMissCountPositiveB.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "FilmShiftingHeadAndTailCountPositiveB", lblFilmShiftingHeadAndTailCountPositiveB.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "DistanceNGCount_PositiveB", lblDistanceNGCountPositiveB.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeDefectCount_PositiveB", lblEdgeDefectCountPositiveB.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectCount_PositiveB", lblSurfaceDefectCountPositiveB.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "BrokenLineCount_PositiveB", lblBrokenLineCountPositiveB.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "StartWeldingNGCount_PositiveB", lblStartWeldingNGCountPositiveB.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceColorDiffCount_PositiveB", lblSurfaceColorDiffCountPositiveB.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "FilmShiftingHeadAndTailCountNegativeB", lblCellMissingCountPositiveB.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "DistanceNGCount_NegativeB", lblAlgorithmExceptionCountPositiveB.Text, mainForm.defaultRecipePath);

        }
        public void ClearStaticsNegativeA()//清空A背面数据
        {
            mainForm.TotalFilmShiftingCountPerClassNegativeA = 0;
            mainForm.TotalFilmMissCountPerClassNegativeA = 0;
            mainForm.TotalFilmShiftingOfHeadAndTailCountPerClassNegativeA = 0;
            mainForm.TotalDistanceNGCountPerClassNegativeA = 0;
            mainForm.TotalEdgeDefectCountPerClassNegativeA = 0;
            mainForm.TotalSurfaceDefectCountPerClassNegativeA = 0;
            mainForm.TotalBrokenLineCountPerClassNegativeA = 0;
            mainForm.TotalStartingWeldingNGCountPerClassNegativeA = 0;
            mainForm.TotalEmptyPlateCountPerClassNegativeA = 0;

            mainForm.TotalCountNegativeA = 0;
            mainForm.NGTotalCountNegativeA = 0;
            mainForm.MajorFailureCountNegativeA = 0;
            mainForm.TotalFilmShiftingCountNegativeA = 0;
            mainForm.TotalFilmMissCountNegativeA = 0;
            //mainForm.TotalFilmShiftingOfHeadAndTailCountNegativeA = 0;
            //mainForm.TotalDistanceNGCountNegativeA = 0;
            mainForm.TotalEdgeDefectCountNegativeA = 0;
            mainForm.TotalSurfaceDefectCountNegativeA = 0;
            mainForm.TotalBrokenLineCountNegativeA = 0;
            mainForm.TotalStartingWeldingNGCountNegativeA = 0;
            mainForm.TotalSurfaceColorDiffCountNegativeA = 0;
            mainForm.TotalLinearityNGCountNegativeA = 0;
            mainForm.TotalEmptyPlateCountNegativeA = 0;

            mainForm.ClearAllCurrentClusterStateNegativeA(1);

            mainForm.IsFirstWaferOfFirstClassNegativeA = false;
            Config.WriteIniData("Config", "TotalCount_NegativeA", lblTotalCountNegativeA.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "NGTotalCount_NegativeA", lblNGTotalCountNegativeA.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "MajorFailureCount_NegativeA", lblMajorFailureCountNegativeA.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "FilmShiftingCount_NegativeA", lblFilmShiftingCountNegativeA.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "FilmMissCount_NegativeA", lblFilmMissCountNegativeA.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeDefectCount_NegativeA", lblEdgeDefectCountNegativeA.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectCount_NegativeA", lblSurfaceDefectCountNegativeA.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "BrokenLineCount_NegativeA", lblBrokenLineCountNegativeA.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "StartWeldingNGCount_NegativeA", lblStartWeldingNGCountNegativeA.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceColorDiffCount_NegativeA", lblSurfaceColorDiffCountNegativeA.Text, mainForm.defaultRecipePath);

        }
        public void ClearStaticsNegativeB()//清空B背面数据
        {
            mainForm.TotalFilmShiftingCountPerClassNegativeB = 0;
            mainForm.TotalFilmMissCountPerClassNegativeB = 0;
            mainForm.TotalFilmShiftingOfHeadAndTailCountPerClassNegativeB = 0;
            mainForm.TotalDistanceNGCountPerClassNegativeB = 0;
            mainForm.TotalEdgeDefectCountPerClassNegativeB = 0;
            mainForm.TotalSurfaceDefectCountPerClassNegativeB = 0;
            mainForm.TotalBrokenLineCountPerClassNegativeB = 0;
            mainForm.TotalStartingWeldingNGCountPerClassNegativeB = 0;
            mainForm.TotalEmptyPlateCountPerClassNegativeB = 0;

            mainForm.TotalCountNegativeB = 0;
            mainForm.NGTotalCountNegativeB = 0;
            mainForm.MajorFailureCountNegativeB = 0;
            mainForm.TotalFilmShiftingCountNegativeB = 0;
            mainForm.TotalFilmMissCountNegativeB = 0;
            //mainForm.TotalFilmShiftingOfHeadAndTailCountNegativeB = 0;
            //mainForm.TotalDistanceNGCountNegativeB = 0;
            mainForm.TotalEdgeDefectCountNegativeB = 0;
            mainForm.TotalSurfaceDefectCountNegativeB = 0;
            mainForm.TotalBrokenLineCountNegativeB = 0;
            mainForm.TotalStartingWeldingNGCountNegativeB = 0;
            mainForm.TotalSurfaceColorDiffCountNegativeB = 0;
            mainForm.TotalLinearityNGCountNegativeB = 0;
            mainForm.TotalEmptyPlateCountNegativeB = 0;

            mainForm.ClearAllCurrentClusterStateNegativeB(1);


            mainForm.IsFirstWaferOfFirstClassNegativeB = false;
            Config.WriteIniData("Config", "TotalCount_NegativeB", lblTotalCountNegativeB.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "NGTotalCount_NegativeB", lblNGTotalCountNegativeB.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "MajorFailureCount_NegativeB", lblMajorFailureCountNegativeB.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "FilmShiftingCount_NegativeB", lblFilmShiftingCountNegativeB.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "FilmMissCount_NegativeB", lblFilmMissCountNegativeB.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeDefectCount_NegativeB", lblEdgeDefectCountNegativeB.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectCount_NegativeB", lblSurfaceDefectCountNegativeB.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "BrokenLineCount_NegativeB", lblBrokenLineCountNegativeB.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "StartWeldingNGCount_NegativeB", lblStartWeldingNGCountNegativeB.Text, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceColorDiffCount_NegativeB", lblSurfaceColorDiffCountNegativeB.Text, mainForm.defaultRecipePath);

        }
        public void btnClearStaticsPositiveA_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要将A侧正面NG串计数清零吗?", "确认", messButton);

            if (dr == DialogResult.OK)//如果点击“确定”按钮
            {
                ClearStaticsPositiveA();
            }       
        }

        public void btnClearStaticsPositiveB_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要将B侧正面NG串计数清零吗?", "确认", messButton);

            if (dr == DialogResult.OK)//如果点击“确定”按钮
            {
                ClearStaticsPositiveB();
            }          
        }

        public void btnClearStaticsNegativeA_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要将A侧背面NG串计数清零吗?", "确认", messButton);

            if (dr == DialogResult.OK)//如果点击“确定”按钮
            {
                ClearStaticsNegativeA();
            }      
        }

        public void btnClearStaticsNegativeB_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要将B侧背面NG串计数清零吗?", "确认", messButton);

            if (dr == DialogResult.OK)//如果点击“确定”按钮
            {
                ClearStaticsNegativeB();
            }         
        }
    }
}
