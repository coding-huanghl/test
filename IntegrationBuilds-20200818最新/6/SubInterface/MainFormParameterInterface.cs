using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _6
{
    public partial class MainFormParameterInterface : UserControl
    {
        MainForm mainForm;
       
        public MainFormParameterInterface(MainForm tempForm)
        {
            InitializeComponent();
            mainForm = tempForm;
        }

        private void MainFormParameterInterface_Load(object sender, EventArgs e)
        {
            //刷新配方界面
            this.RefreshRecipeInfo();
            if(Global.isEnglish=="0")
            {
                cbxStringType.Items.Clear();
                cbxStringType.Items.Add("负间距");
                cbxStringType.Items.Add("小间距");
                cbxStringType.Items.Add("常规间距");
                cbxStringType.SelectedItem = Global.stringType;
            }
            else
            {
                cbxStringType.Items.Clear();
                cbxStringType.Items.Add("Negative Gap");
                cbxStringType.Items.Add("Small Gap");
                cbxStringType.Items.Add("Normal Gap");
                if (Global.stringType == "常规间距")
                {
                    cbxStringType.SelectedItem = "Normal Gap";
                }
                if (Global.stringType == "小间距")
                {
                    cbxStringType.SelectedItem = "Small Gap";
                }
                if (Global.stringType == "负间距")
                {
                    cbxStringType.SelectedItem = "Negative Gap";
                }
            }
        }

        private void RefreshRecipeInfo()
        {
            //公有检测配方初始化
            txtMainLineDistance.Text = Global.mainLineDistance;
            cbxWaferCountPerClass.Text = Global.waferCountPerClass;
            if (Convert.ToBoolean(Convert.ToInt32(Global.isDalsaCam)))
            {
                chkIsDalsaCam.Checked = true;
            }
            else
            {
                chkIsDalsaCam.Checked = false;
            }
            cbxMainLineNum.SelectedItem = Global.mainLineNum;
            if (Convert.ToBoolean(Convert.ToInt32(Global.isFullWafer)))
            {
                chxIsFullWafer.Checked = true;
            }
            else
            {
                chxIsFullWafer.Checked = false;
            }
            cbxSubMainLineNum.SelectedItem = Global.subMainLineNum;
           
            
                cbxStringType.SelectedItem = Global.stringType;
           
            if (Convert.ToBoolean(Convert.ToInt32(Global.isDoubleDetect)))
            {
                chxIsDoubleDetect.Checked = true;
            }
            else
            {
                chxIsDoubleDetect.Checked = false;
            }

            if (Convert.ToBoolean(Convert.ToInt32(Global.isMESFun)))
            {
                chxIsMESFun.Checked = true;
            }
            else
            {
                chxIsMESFun.Checked = false;
            }
            if (Convert.ToBoolean(Convert.ToInt32(Global.isUpperLink)))
            {
                chxIsUpperLink.Checked = true;
            }
            else
            {
                chxIsUpperLink.Checked = false;
            }

            #region//A侧正面检测配方初始化
            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingFilmShiftingDetectPositiveA)))
            {
                chkIsUsingFilmShiftingDetect_PositiveA.Checked = true;
            }
            else
            {
                chkIsUsingFilmShiftingDetect_PositiveA.Checked = false;
            }
            txtTopShieldLengthOfTopRegion_PositiveA.Text = Global.topShieldLengthOfTopRegionPositiveA;
            txtBottomShieldLengthOfTopRegion_PositiveA.Text = Global.bottomShieldLengthOfTopRegionPositiveA;
            txtTopShieldLengthOfBottomRegion_PositiveA.Text = Global.topShieldLengthOfBottomRegionPositiveA;
            txtBottomShieldLengthOfBottomRegion_PositiveA.Text = Global.bottomShieldLengthOfBottomRegionPositiveA;
            txtLocationMainLineThresh_PositiveA.Text = Global.locationMainLineThreshPositiveA;
            txtFilmWidthThresh_PositiveA.Text = Global.filmWidthThreshPositiveA;
            txtFilmWidthOffSet_PositiveA.Text = Global.filmWidthOffSetPositiveA;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingFilmMissDetectPositiveA)))
            {
                chkIsUsingFilmMissDetect_PositiveA.Checked = true;
            }
            else
            {
                chkIsUsingFilmMissDetect_PositiveA.Checked = false;
            }
            txtWeldWidthThresh_PositiveA.Text = Global.weldWidthThreshPositiveA;
            txtWeldShieldLength_PositiveA.Text = Global.weldShieldLengthPositiveA;

            txtFirstDetectPosForTopRegion_PositiveA.Text = Global.firstDetectPosForTopRegionPositiveA;
            txtSecondDetectPosForTopRegion_PositiveA.Text = Global.secondDetectPosForTopRegionPositiveA;
            txtFirstDetectPosForBottomRegion_PositiveA.Text = Global.firstDetectPosForBottomRegionPositiveA;
            txtSecondDetectPosForBottomRegion_PositiveA.Text = Global.secondDetectPosForBottomRegionPositiveA;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingHeadAndTailFilmShiftingDetectPositiveA)))
            {
                chkIsUsingFilmShiftingHeadAndTailDetect_PositiveA.Checked = true;
            }
            else
            {
                chkIsUsingFilmShiftingHeadAndTailDetect_PositiveA.Checked = false;
            }
            txtHeadAndTailFilmWidthThresh_PositiveA.Text = Global.headAndTailFilmWidthThreshPositiveA;
            txtHeadAndTailFilmShieldLength_PositiveA.Text = Global.headAndTailFilmShieldLengthPositiveA;
            txtHeadAndTailFilmDetectRange_PositiveA.Text = Global.headAndTailFilmDetectRangePositiveA;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingWidthResolutionCalibratePositiveA)))
            {
                chkIsUsingWidthResolutionCalibrate_PositiveA.Checked = true;
            }
            else
            {
                chkIsUsingWidthResolutionCalibrate_PositiveA.Checked = false;
            }
            txtWaferWidth_PositiveA.Text = Global.waferWidthPositiveA;
            txtWidthResolution_PositiveA.Text = Global.widthResolutionPositiveA;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingHeightResolutionCalibratePositiveA)))
            {
                chkIsUsingHeightResolutionCalibrate_PositiveA.Checked = true;
            }
            else
            {
                chkIsUsingHeightResolutionCalibrate_PositiveA.Checked = false;
            }
            txtViceLineInterval_PositiveA.Text = Global.viceLineInterval;
            txtHeightResolution_PositiveA.Text = Global.heightResolutionPositiveA;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingWaferEdgeCalibrationPositiveA)))
            {
                chkIsUsingWaferEdgeCalibration_PositiveA.Checked = true;
            }
            else
            {
                chkIsUsingWaferEdgeCalibration_PositiveA.Checked = false;
            }
            txtLocationWaferEdgeThresh_PositiveA.Text = Global.locationWaferEdgeThreshPositiveA;
            txtWaferEdgeCalibrationRegionDilationPixel_PositiveA.Text = Global.waferEdgeCalibrationRegionDilationPixelPositiveA;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingDistanceDetectPositiveA)))
            {
                chkIsUsingDistanceDetect_PositiveA.Checked = true;
            }
            else
            {
                chkIsUsingDistanceDetect_PositiveA.Checked = false;
            }
            txtMinimumDistanceThresh_PositiveA.Text = Global.minimumDistanceThreshPositiveA;
            txtMaxDistanceThresh_PositiveA.Text = Global.maxDistanceThreshPositiveA;
            txtClassDistanceThresh_PositiveA.Text = Global.classDistanceThreshPositiveA;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingEdgeDefectDetectPositiveA)))
            {
                chkIsUsingEdgeDefectDetect_PositiveA.Checked = true;
            }
            else
            {
                chkIsUsingEdgeDefectDetect_PositiveA.Checked = false;
            }
            txtEdgeBigDefectWidthThresh_PositiveA.Text = Global.edgeBigDefectWidthThreshPositiveA;
            txtEdgeBigDefectHeightThresh_PositiveA.Text = Global.edgeBigDefectHeightThreshPositiveA;
            txtEdgeSmallDefectDetectDepth_PositiveA.Text = Global.edgeSmallDefectDetectDepthPositiveA;
            txtEdgeSmallDefectGrayThresh_PositiveA.Text = Global.edgeSmallDefectGrayThreshPositiveA;
            txtEdgeSmallDefectWidthThresh_PositiveA.Text = Global.edgeSmallDefectWidthThreshPositiveA;
            txtEdgeSmallDefectHeightThresh_PositiveA.Text = Global.edgeSmallDefectHeightThreshPositiveA;
            txtEdgeSmallDefectGrayMeanThresh_PositiveA.Text = Global.edgeSmallDefectGrayMeanThreshPositiveA;
            txtEdgeSmallDefectGrayDeviationThresh_PositiveA.Text = Global.edgeSmallDefectGrayDeviationThreshPositiveA;
            txtCornerDefectAreaRatioThresh_PositiveA.Text = Global.cornerDefectAreaRatioThreshPositiveA;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingSurfaceDefectDetectPositiveA)))
            {
                chkIsUsingSurfaceDefectDetect_PositiveA.Checked = true;
            }
            else
            {
                chkIsUsingSurfaceDefectDetect_PositiveA.Checked = false;
            }
            txtSurfaceDefectGrayThresh_PositiveA.Text = Global.surfaceDefectGrayThreshPositiveA;
            txtSurfaceDefectWidthThresh_PositiveA.Text = Global.surfaceDefectWidthThreshPositiveA;
            txtSurfaceDefectHeightThresh_PositiveA.Text = Global.surfaceDefectHeightThreshPositiveA;
            txtSurfaceDefectDetectIndentDepth_PositiveA.Text = Global.surfaceDefectDetectIndentDepthPositiveA;
            txtSurfaceDefectViceLineShieldWidth_PositiveA.Text = Global.surfaceDefectViceLineShieldWidthPositiveA;
            txtSurfaceDefectViceLineShieldLeftPosOffSet_PositiveA.Text = Global.surfaceDefectViceLineShieldLeftPosOffSetPositiveA;
            txtSurfaceDefectViceLineShieldRightPosOffSet_PositiveA.Text = Global.surfaceDefectViceLineShieldRightPosOffSetPositiveA;
            txtSurfaceScratchGrayThresh_PositiveA.Text = Global.surfaceScratchGrayThreshPositiveA;
            txtSurfaceScratchWidthThresh_PositiveA.Text = Global.surfaceScratchWidthThreshPositiveA;
            txtSurfaceScratchHeightThresh_PositiveA.Text = Global.surfaceScratchHeightThreshPositiveA;


            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingBrokenLineDetectPositiveA)))
            {
                chkIsUsingBrokenLineDetect_PositiveA.Checked = true;
            }
            else
            {
                chkIsUsingBrokenLineDetect_PositiveA.Checked = false;
            }
            txtBrokenLineGrayThresh_PositiveA.Text = Global.brokenLineGrayThreshPositiveA;
            txtBrokenLineWidthThresh_PositiveA.Text = Global.brokenLineWidthThreshPositiveA;
            txtBrokenLineHeightThresh_PositiveA.Text = Global.brokenLineHeightThreshPositiveA;
            txtBrokenLineDetectIndentDepth_PositiveA.Text = Global.brokenLineDetectIndentDepthPositiveA;
            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingStartWeldingDetectPositiveA)))
            {
                chkIsUsingStartWeldingDetect_PositiveA.Checked = true;
            }
            else
            {
                chkIsUsingStartWeldingDetect_PositiveA.Checked = false;
            }
            txtStartWeldingDistanceMinThresh_PositiveA.Text = Global.startWeldingDistanceMinThreshPositiveA;
            txtStartWeldingDistanceMaxThresh_PositiveA.Text = Global.startWeldingDistanceMaxThreshPositiveA;
            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingSurfaceColorDiffDetectPositiveA)))
            {
                chkIsUsingSurfaceColorDiffDetect_PositiveA.Checked = true;
            }
            else
            {
                chkIsUsingSurfaceColorDiffDetect_PositiveA.Checked = false;
            }
            txtSurfaceColorDiffGrayThresh_PositiveA.Text = Global.surfaceColorDiffGrayThreshPositiveA;
            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingAlarmFunction_PositiveA)))
            {
                chkIsUsingAlarmFunction_PositiveA.Checked = true;
            }
            else
            {
                chkIsUsingAlarmFunction_PositiveA.Checked = false;
            }
            txtMaxAlamClusterCount_PositiveA.Text = Global.maxAlamClusterCount_PositiveA;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isSaveAllImage_PositiveA)))
            {
                chkIsSaveAllImage_PositiveA.Checked = true;
            }
            else
            {
                chkIsSaveAllImage_PositiveA.Checked = false;
            }
            if (Convert.ToBoolean(Convert.ToInt32(Global.isSaveNGImage_PositiveA)))
            {
                chkIsSaveNGImage_PositiveA.Checked = true;
            }
            else
            {
                chkIsSaveNGImage_PositiveA.Checked = false;
            }
            if (Convert.ToBoolean(Convert.ToInt32(Global.isSaveNGImageWithRoi_PositiveA)))
            {
                chkIsSaveNGImageWithRoi_PositiveA.Checked = true;
            }
            else
            {
                chkIsSaveNGImageWithRoi_PositiveA.Checked = false;
            }
            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingCamera_PositiveA)))
            {
                chkIsUsingCamera_PositiveA.Checked = true;
            }
            else
            {
                chkIsUsingCamera_PositiveA.Checked = false;
            }
            #endregion

            #region//B侧正面检测配方初始化
            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingFilmShiftingDetectPositiveB)))
            {
                chkIsUsingFilmShiftingDetect_PositiveB.Checked = true;
            }
            else
            {
                chkIsUsingFilmShiftingDetect_PositiveB.Checked = false;
            }
            txtTopShieldLengthOfTopRegion_PositiveB.Text = Global.topShieldLengthOfTopRegionPositiveB;
            txtBottomShieldLengthOfTopRegion_PositiveB.Text = Global.bottomShieldLengthOfTopRegionPositiveB;
            txtTopShieldLengthOfBottomRegion_PositiveB.Text = Global.topShieldLengthOfBottomRegionPositiveB;
            txtBottomShieldLengthOfBottomRegion_PositiveB.Text = Global.bottomShieldLengthOfBottomRegionPositiveB;
            txtLocationMainLineThresh_PositiveB.Text = Global.locationMainLineThreshPositiveB;
            txtFilmWidthThresh_PositiveB.Text = Global.filmWidthThreshPositiveB;
            txtFilmWidthOffSet_PositiveB.Text = Global.filmWidthOffSetPositiveB;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingFilmMissDetectPositiveB)))
            {
                chkIsUsingFilmMissDetect_PositiveB.Checked = true;
            }
            else
            {
                chkIsUsingFilmMissDetect_PositiveB.Checked = false;
            }
            txtWeldWidthThresh_PositiveB.Text = Global.weldWidthThreshPositiveB;
            txtWeldShieldLength_PositiveB.Text = Global.weldShieldLengthPositiveB;

            txtFirstDetectPosForTopRegion_PositiveB.Text = Global.firstDetectPosForTopRegionPositiveB;
            txtSecondDetectPosForTopRegion_PositiveB.Text = Global.secondDetectPosForTopRegionPositiveB;
            txtFirstDetectPosForBottomRegion_PositiveB.Text = Global.firstDetectPosForBottomRegionPositiveB;
            txtSecondDetectPosForBottomRegion_PositiveB.Text = Global.secondDetectPosForBottomRegionPositiveB;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingHeadAndTailFilmShiftingDetectPositiveB)))
            {
                chkIsUsingFilmShiftingHeadAndTailDetect_PositiveB.Checked = true;
            }
            else
            {
                chkIsUsingFilmShiftingHeadAndTailDetect_PositiveB.Checked = false;
            }
            txtHeadAndTailFilmWidthThresh_PositiveB.Text = Global.headAndTailFilmWidthThreshPositiveB;
            txtHeadAndTailFilmShieldLength_PositiveB.Text = Global.headAndTailFilmShieldLengthPositiveB;
            txtHeadAndTailFilmDetectRange_PositiveB.Text = Global.headAndTailFilmDetectRangePositiveB;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingWidthResolutionCalibratePositiveB)))
            {
                chkIsUsingWidthResolutionCalibrate_PositiveB.Checked = true;
            }
            else
            {
                chkIsUsingWidthResolutionCalibrate_PositiveB.Checked = false;
            }
            txtWaferWidth_PositiveB.Text = Global.waferWidthPositiveB;
            txtWidthResolution_PositiveB.Text = Global.widthResolutionPositiveB;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingHeightResolutionCalibratePositiveB)))
            {
                chkIsUsingHeightResolutionCalibrate_PositiveB.Checked = true;
            }
            else
            {
                chkIsUsingHeightResolutionCalibrate_PositiveB.Checked = false;
            }
            txtViceLineInterval_PositiveB.Text = Global.viceLineInterval;
            txtHeightResolution_PositiveB.Text = Global.heightResolutionPositiveB;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingWaferEdgeCalibrationPositiveB)))
            {
                chkIsUsingWaferEdgeCalibration_PositiveB.Checked = true;
            }
            else
            {
                chkIsUsingWaferEdgeCalibration_PositiveB.Checked = false;
            }
            txtLocationWaferEdgeThresh_PositiveB.Text = Global.locationWaferEdgeThreshPositiveB;
            txtWaferEdgeCalibrationRegionDilationPixel_PositiveB.Text = Global.waferEdgeCalibrationRegionDilationPixelPositiveB;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingDistanceDetectPositiveB)))
            {
                chkIsUsingDistanceDetect_PositiveB.Checked = true;
            }
            else
            {
                chkIsUsingDistanceDetect_PositiveB.Checked = false;
            }
            txtMinimumDistanceThresh_PositiveB.Text = Global.minimumDistanceThreshPositiveB;
            txtMaxDistanceThresh_PositiveB.Text = Global.maxDistanceThreshPositiveB;
            txtClassDistanceThresh_PositiveB.Text = Global.classDistanceThreshPositiveB;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingEdgeDefectDetectPositiveB)))
            {
                chkIsUsingEdgeDefectDetect_PositiveB.Checked = true;
            }
            else
            {
                chkIsUsingEdgeDefectDetect_PositiveB.Checked = false;
            }
            txtEdgeBigDefectWidthThresh_PositiveB.Text = Global.edgeBigDefectWidthThreshPositiveB;
            txtEdgeBigDefectHeightThresh_PositiveB.Text = Global.edgeBigDefectHeightThreshPositiveB;
            txtEdgeSmallDefectDetectDepth_PositiveB.Text = Global.edgeSmallDefectDetectDepthPositiveB;
            txtEdgeSmallDefectGrayThresh_PositiveB.Text = Global.edgeSmallDefectGrayThreshPositiveB;
            txtEdgeSmallDefectWidthThresh_PositiveB.Text = Global.edgeSmallDefectWidthThreshPositiveB;
            txtEdgeSmallDefectHeightThresh_PositiveB.Text = Global.edgeSmallDefectHeightThreshPositiveB;
            txtEdgeSmallDefectGrayMeanThresh_PositiveB.Text = Global.edgeSmallDefectGrayMeanThreshPositiveB;
            txtEdgeSmallDefectGrayDeviationThresh_PositiveB.Text = Global.edgeSmallDefectGrayDeviationThreshPositiveB;
            txtCornerDefectAreaRatioThresh_PositiveB.Text = Global.cornerDefectAreaRatioThreshPositiveB;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingSurfaceDefectDetectPositiveB)))
            {
                chkIsUsingSurfaceDefectDetect_PositiveB.Checked = true;
            }
            else
            {
                chkIsUsingSurfaceDefectDetect_PositiveB.Checked = false;
            }
            txtSurfaceDefectGrayThresh_PositiveB.Text = Global.surfaceDefectGrayThreshPositiveB;
            txtSurfaceDefectWidthThresh_PositiveB.Text = Global.surfaceDefectWidthThreshPositiveB;
            txtSurfaceDefectHeightThresh_PositiveB.Text = Global.surfaceDefectHeightThreshPositiveB;
            txtSurfaceDefectDetectIndentDepth_PositiveB.Text = Global.surfaceDefectDetectIndentDepthPositiveB;
            txtSurfaceDefectViceLineShieldWidth_PositiveB.Text = Global.surfaceDefectViceLineShieldWidthPositiveB;
            txtSurfaceDefectViceLineShieldLeftPosOffSet_PositiveB.Text = Global.surfaceDefectViceLineShieldLeftPosOffSetPositiveB;
            txtSurfaceDefectViceLineShieldRightPosOffSet_PositiveB.Text = Global.surfaceDefectViceLineShieldRightPosOffSetPositiveB;
            txtSurfaceScratchGrayThresh_PositiveB.Text = Global.surfaceScratchGrayThreshPositiveB;
            txtSurfaceScratchWidthThresh_PositiveB.Text = Global.surfaceScratchWidthThreshPositiveB;
            txtSurfaceScratchHeightThresh_PositiveB.Text = Global.surfaceScratchHeightThreshPositiveB;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingBrokenLineDetectPositiveB)))
            {
                chkIsUsingBrokenLineDetect_PositiveB.Checked = true;
            }
            else
            {
                chkIsUsingBrokenLineDetect_PositiveB.Checked = false;
            }
            txtBrokenLineGrayThresh_PositiveB.Text = Global.brokenLineGrayThreshPositiveB;
            txtBrokenLineWidthThresh_PositiveB.Text = Global.brokenLineWidthThreshPositiveB;
            txtBrokenLineHeightThresh_PositiveB.Text = Global.brokenLineHeightThreshPositiveB;
            txtBrokenLineDetectIndentDepth_PositiveB.Text = Global.brokenLineDetectIndentDepthPositiveB;
            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingStartWeldingDetectPositiveB)))
            {
                chkIsUsingStartWeldingDetect_PositiveB.Checked = true;
            }
            else
            {
                chkIsUsingStartWeldingDetect_PositiveB.Checked = false;
            }
            txtStartWeldingDistanceMinThresh_PositiveB.Text = Global.startWeldingDistanceMinThreshPositiveB;
            txtStartWeldingDistanceMaxThresh_PositiveB.Text = Global.startWeldingDistanceMaxThreshPositiveB;
            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingSurfaceColorDiffDetectPositiveB)))
            {
                chkIsUsingSurfaceColorDiffDetect_PositiveB.Checked = true;
            }
            else
            {
                chkIsUsingSurfaceColorDiffDetect_PositiveB.Checked = false;
            }
            txtSurfaceColorDiffGrayThresh_PositiveB.Text = Global.surfaceColorDiffGrayThreshPositiveB;
            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingAlarmFunction_PositiveB)))
            {
                chkIsUsingAlarmFunction_PositiveB.Checked = true;
            }
            else
            {
                chkIsUsingAlarmFunction_PositiveB.Checked = false;
            }
            txtMaxAlamClusterCount_PositiveB.Text = Global.maxAlamClusterCount_PositiveB;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isSaveAllImage_PositiveB)))
            {
                chkIsSaveAllImage_PositiveB.Checked = true;
            }
            else
            {
                chkIsSaveAllImage_PositiveB.Checked = false;
            }
            if (Convert.ToBoolean(Convert.ToInt32(Global.isSaveNGImage_PositiveB)))
            {
                chkIsSaveNGImage_PositiveB.Checked = true;
            }
            else
            {
                chkIsSaveNGImage_PositiveB.Checked = false;
            }
            if (Convert.ToBoolean(Convert.ToInt32(Global.isSaveNGImageWithRoi_PositiveB)))
            {
                chkIsSaveNGImageWithRoi_PositiveB.Checked = true;
            }
            else
            {
                chkIsSaveNGImageWithRoi_PositiveB.Checked = false;
            }
            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingCamera_PositiveB)))
            {
                chkIsUsingCamera_PositiveB.Checked = true;
            }
            else
            {
                chkIsUsingCamera_PositiveB.Checked = false;
            }
            #endregion

            #region//A侧背面检测配方初始化
            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingFilmShiftingDetectNegativeA)))
            {
                chkIsUsingFilmShiftingDetect_NegativeA.Checked = true;
            }
            else
            {
                chkIsUsingFilmShiftingDetect_NegativeA.Checked = false;
            }
            txtTopShieldLengthOfTopRegion_NegativeA.Text = Global.topShieldLengthOfTopRegionNegativeA;
            txtBottomShieldLengthOfTopRegion_NegativeA.Text = Global.bottomShieldLengthOfTopRegionNegativeA;
            txtTopShieldLengthOfBottomRegion_NegativeA.Text = Global.topShieldLengthOfBottomRegionNegativeA;
            txtBottomShieldLengthOfBottomRegion_NegativeA.Text = Global.bottomShieldLengthOfBottomRegionNegativeA;
            txtLocationMainLineThresh_NegativeA.Text = Global.locationMainLineThreshNegativeA;
            txtFilmWidthThresh_NegativeA.Text = Global.filmWidthThreshNegativeA;
            txtFilmWidthOffSet_NegativeA.Text = Global.filmWidthOffSetNegativeA;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingFilmMissDetectNegativeA)))
            {
                chkIsUsingFilmMissDetect_NegativeA.Checked = true;
            }
            else
            {
                chkIsUsingFilmMissDetect_NegativeA.Checked = false;
            }
            txtWeldWidthThresh_NegativeA.Text = Global.weldWidthThreshNegativeA;

            txtFirstDetectPosForTopRegion_NegativeA.Text = Global.firstDetectPosForTopRegionNegativeA;
            txtSecondDetectPosForTopRegion_NegativeA.Text = Global.secondDetectPosForTopRegionNegativeA;
            txtFirstDetectPosForBottomRegion_NegativeA.Text = Global.firstDetectPosForBottomRegionNegativeA;
            txtSecondDetectPosForBottomRegion_NegativeA.Text = Global.secondDetectPosForBottomRegionNegativeA;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingHeadAndTailFilmShiftingDetectNegativeA)))
            {
                chkIsUsingFilmShiftingHeadAndTailDetect_NegativeA.Checked = true;
            }
            else
            {
                chkIsUsingFilmShiftingHeadAndTailDetect_NegativeA.Checked = false;
            }
            txtHeadAndTailFilmWidthThresh_NegativeA.Text = Global.headAndTailFilmWidthThreshNegativeA;
            txtHeadAndTailFilmShieldLength_NegativeA.Text = Global.headAndTailFilmShieldLengthNegativeA;
            txtHeadAndTailFilmDetectRange_NegativeA.Text = Global.headAndTailFilmDetectRangeNegativeA;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingWidthResolutionCalibrateNegativeA)))
            {
                chkIsUsingWidthResolutionCalibrate_NegativeA.Checked = true;
            }
            else
            {
                chkIsUsingWidthResolutionCalibrate_NegativeA.Checked = false;
            }
            txtWaferWidth_NegativeA.Text = Global.waferWidthNegativeA;
            txtWidthResolution_NegativeA.Text = Global.widthResolutionNegativeA;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingHeightResolutionCalibrateNegativeA)))
            {
                chkIsUsingHeightResolutionCalibrate_NegativeA.Checked = true;
            }
            else
            {
                chkIsUsingHeightResolutionCalibrate_NegativeA.Checked = false;
            }
            txtViceLineInterval_NegativeA.Text = Global.viceLineInterval;
            txtHeightResolution_NegativeA.Text = Global.heightResolutionNegativeA;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingWaferEdgeCalibrationNegativeA)))
            {
                chkIsUsingWaferEdgeCalibration_NegativeA.Checked = true;
            }
            else
            {
                chkIsUsingWaferEdgeCalibration_NegativeA.Checked = false;
            }
            txtLocationWaferEdgeThresh_NegativeA.Text = Global.locationWaferEdgeThreshNegativeA;
            txtWaferEdgeCalibrationRegionDilationPixel_NegativeA.Text = Global.waferEdgeCalibrationRegionDilationPixelNegativeA;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingDistanceDetectNegativeA)))
            {
                chkIsUsingDistanceDetect_NegativeA.Checked = true;
            }
            else
            {
                chkIsUsingDistanceDetect_NegativeA.Checked = false;
            }
            txtMinimumDistanceThresh_NegativeA.Text = Global.minimumDistanceThreshNegativeA;
            txtMaxDistanceThresh_NegativeA.Text = Global.maxDistanceThreshNegativeA;
            txtClassDistanceThresh_NegativeA.Text = Global.classDistanceThreshNegativeA;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingEdgeDefectDetectNegativeA)))
            {
                chkIsUsingEdgeDefectDetect_NegativeA.Checked = true;
            }
            else
            {
                chkIsUsingEdgeDefectDetect_NegativeA.Checked = false;
            }
            txtEdgeBigDefectWidthThresh_NegativeA.Text = Global.edgeBigDefectWidthThreshNegativeA;
            txtEdgeBigDefectHeightThresh_NegativeA.Text = Global.edgeBigDefectHeightThreshNegativeA;
            txtEdgeSmallDefectDetectDepth_NegativeA.Text = Global.edgeSmallDefectDetectDepthNegativeA;
            txtEdgeSmallDefectGrayThresh_NegativeA.Text = Global.edgeSmallDefectGrayThreshNegativeA;
            txtEdgeSmallDefectWidthThresh_NegativeA.Text = Global.edgeSmallDefectWidthThreshNegativeA;
            txtEdgeSmallDefectHeightThresh_NegativeA.Text = Global.edgeSmallDefectHeightThreshNegativeA;
            txtEdgeSmallDefectGrayMeanThresh_NegativeA.Text = Global.edgeSmallDefectGrayMeanThreshNegativeA;
            txtEdgeSmallDefectGrayDeviationThresh_NegativeA.Text = Global.edgeSmallDefectGrayDeviationThreshNegativeA;
            txtCornerDefectAreaRatioThresh_NegativeA.Text = Global.cornerDefectAreaRatioThreshNegativeA;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingSurfaceDefectDetectNegativeA)))
            {
                chkIsUsingSurfaceDefectDetect_NegativeA.Checked = true;
            }
            else
            {
                chkIsUsingSurfaceDefectDetect_NegativeA.Checked = false;
            }
            txtSurfaceDefectGrayThresh_NegativeA.Text = Global.surfaceDefectGrayThreshNegativeA;
            txtSurfaceDefectWidthThresh_NegativeA.Text = Global.surfaceDefectWidthThreshNegativeA;
            txtSurfaceDefectHeightThresh_NegativeA.Text = Global.surfaceDefectHeightThreshNegativeA;
            txtSurfaceDefectDetectIndentDepth_NegativeA.Text = Global.surfaceDefectDetectIndentDepthNegativeA;
            txtSurfaceDefectViceLineShieldWidth_NegativeA.Text = Global.surfaceDefectViceLineShieldWidthNegativeA;
            txtSurfaceDefectViceLineShieldLeftPosOffSet_NegativeA.Text = Global.surfaceDefectViceLineShieldLeftPosOffSetNegativeA;
            txtSurfaceDefectViceLineShieldRightPosOffSet_NegativeA.Text = Global.surfaceDefectViceLineShieldRightPosOffSetNegativeA;
            txtSurfaceScratchGrayThresh_NegativeA.Text = Global.surfaceScratchGrayThreshNegativeA;
            txtSurfaceScratchWidthThresh_NegativeA.Text = Global.surfaceScratchWidthThreshNegativeA;
            txtSurfaceScratchHeightThresh_NegativeA.Text = Global.surfaceScratchHeightThreshNegativeA;


            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingBrokenLineDetectNegativeA)))
            {
                chkIsUsingBrokenLineDetect_NegativeA.Checked = true;
            }
            else
            {
                chkIsUsingBrokenLineDetect_NegativeA.Checked = false;
            }
            txtBrokenLineGrayThresh_NegativeA.Text = Global.brokenLineGrayThreshNegativeA;
            txtBrokenLineWidthThresh_NegativeA.Text = Global.brokenLineWidthThreshNegativeA;
            txtBrokenLineHeightThresh_NegativeA.Text = Global.brokenLineHeightThreshNegativeA;
            txtBrokenLineDetectIndentDepth_NegativeA.Text = Global.brokenLineDetectIndentDepthNegativeA;
            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingStartWeldingDetectNegativeA)))
            {
                chkIsUsingStartWeldingDetect_NegativeA.Checked = true;
            }
            else
            {
                chkIsUsingStartWeldingDetect_NegativeA.Checked = false;
            }
            txtStartWeldingDistanceMinThresh_NegativeA.Text = Global.startWeldingDistanceMinThreshNegativeA;
            txtStartWeldingDistanceMaxThresh_NegativeA.Text = Global.startWeldingDistanceMaxThreshNegativeA;
            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingSurfaceColorDiffDetectNegativeA)))
            {
                chkIsUsingSurfaceColorDiffDetect_NegativeA.Checked = true;
            }
            else
            {
                chkIsUsingSurfaceColorDiffDetect_NegativeA.Checked = false;
            }
            txtSurfaceColorDiffGrayThresh_NegativeA.Text = Global.surfaceColorDiffGrayThreshNegativeA;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingAlarmFunction_NegativeA)))
            {
                chkIsUsingAlarmFunction_NegativeA.Checked = true;
            }
            else
            {
                chkIsUsingAlarmFunction_NegativeA.Checked = false;
            }
            txtMaxAlamClusterCount_NegativeA.Text = Global.maxAlamClusterCount_NegativeA;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isSaveAllImage_NegativeA)))
            {
                chkIsSaveAllImage_NegativeA.Checked = true;
            }
            else
            {
                chkIsSaveAllImage_NegativeA.Checked = false;
            }
            if (Convert.ToBoolean(Convert.ToInt32(Global.isSaveNGImage_NegativeA)))
            {
                chkIsSaveNGImage_NegativeA.Checked = true;
            }
            else
            {
                chkIsSaveNGImage_NegativeA.Checked = false;
            }
            if (Convert.ToBoolean(Convert.ToInt32(Global.isSaveNGImageWithRoi_NegativeA)))
            {
                chkIsSaveNGImageWithRoi_NegativeA.Checked = true;
            }
            else
            {
                chkIsSaveNGImageWithRoi_NegativeA.Checked = false;
            }
            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingCamera_NegativeA)))
            {
                chkIsUsingCamera_NegativeA.Checked = true;
            }
            else
            {
                chkIsUsingCamera_NegativeA.Checked = false;
            }
            #endregion

            #region//B侧背面检测配方初始化
            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingFilmShiftingDetectNegativeB)))
            {
                chkIsUsingFilmShiftingDetect_NegativeB.Checked = true;
            }
            else
            {
                chkIsUsingFilmShiftingDetect_NegativeB.Checked = false;
            }
            txtTopShieldLengthOfTopRegion_NegativeB.Text = Global.topShieldLengthOfTopRegionNegativeB;
            txtBottomShieldLengthOfTopRegion_NegativeB.Text = Global.bottomShieldLengthOfTopRegionNegativeB;
            txtTopShieldLengthOfBottomRegion_NegativeB.Text = Global.topShieldLengthOfBottomRegionNegativeB;
            txtBottomShieldLengthOfBottomRegion_NegativeB.Text = Global.bottomShieldLengthOfBottomRegionNegativeB;
            txtLocationMainLineThresh_NegativeB.Text = Global.locationMainLineThreshNegativeB;
            txtFilmWidthThresh_NegativeB.Text = Global.filmWidthThreshNegativeB;
            txtFilmWidthOffSet_NegativeB.Text = Global.filmWidthOffSetNegativeB;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingFilmMissDetectNegativeB)))
            {
                chkIsUsingFilmMissDetect_NegativeB.Checked = true;
            }
            else
            {
                chkIsUsingFilmMissDetect_NegativeB.Checked = false;
            }
            txtWeldWidthThresh_NegativeB.Text = Global.weldWidthThreshNegativeB;

            txtFirstDetectPosForTopRegion_NegativeB.Text = Global.firstDetectPosForTopRegionNegativeB;
            txtSecondDetectPosForTopRegion_NegativeB.Text = Global.secondDetectPosForTopRegionNegativeB;
            txtFirstDetectPosForBottomRegion_NegativeB.Text = Global.firstDetectPosForBottomRegionNegativeB;
            txtSecondDetectPosForBottomRegion_NegativeB.Text = Global.secondDetectPosForBottomRegionNegativeB;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingHeadAndTailFilmShiftingDetectNegativeB)))
            {
                chkIsUsingFilmShiftingHeadAndTailDetect_NegativeB.Checked = true;
            }
            else
            {
                chkIsUsingFilmShiftingHeadAndTailDetect_NegativeB.Checked = false;
            }
            txtHeadAndTailFilmWidthThresh_NegativeB.Text = Global.headAndTailFilmWidthThreshNegativeB;
            txtHeadAndTailFilmShieldLength_NegativeB.Text = Global.headAndTailFilmShieldLengthNegativeB;
            txtHeadAndTailFilmDetectRange_NegativeB.Text = Global.headAndTailFilmDetectRangeNegativeB;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingWidthResolutionCalibrateNegativeB)))
            {
                chkIsUsingWidthResolutionCalibrate_NegativeB.Checked = true;
            }
            else
            {
                chkIsUsingWidthResolutionCalibrate_NegativeB.Checked = false;
            }
            txtWaferWidth_NegativeB.Text = Global.waferWidthNegativeB;
            txtWidthResolution_NegativeB.Text = Global.widthResolutionNegativeB;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingHeightResolutionCalibrateNegativeB)))
            {
                chkIsUsingHeightResolutionCalibrate_NegativeB.Checked = true;
            }
            else
            {
                chkIsUsingHeightResolutionCalibrate_NegativeB.Checked = false;
            }
            txtViceLineInterval_NegativeB.Text = Global.viceLineInterval;
            txtHeightResolution_NegativeB.Text = Global.heightResolutionNegativeB;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingWaferEdgeCalibrationNegativeB)))
            {
                chkIsUsingWaferEdgeCalibration_NegativeB.Checked = true;
            }
            else
            {
                chkIsUsingWaferEdgeCalibration_NegativeB.Checked = false;
            }
            txtLocationWaferEdgeThresh_NegativeB.Text = Global.locationWaferEdgeThreshNegativeB;
            txtWaferEdgeCalibrationRegionDilationPixel_NegativeB.Text = Global.waferEdgeCalibrationRegionDilationPixelNegativeB;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingDistanceDetectNegativeB)))
            {
                chkIsUsingDistanceDetect_NegativeB.Checked = true;
            }
            else
            {
                chkIsUsingDistanceDetect_NegativeB.Checked = false;
            }
            txtMinimumDistanceThresh_NegativeB.Text = Global.minimumDistanceThreshNegativeB;
            txtMaxDistanceThresh_NegativeB.Text = Global.maxDistanceThreshNegativeB;
            txtClassDistanceThresh_NegativeB.Text = Global.classDistanceThreshNegativeB;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingEdgeDefectDetectNegativeB)))
            {
                chkIsUsingEdgeDefectDetect_NegativeB.Checked = true;
            }
            else
            {
                chkIsUsingEdgeDefectDetect_NegativeB.Checked = false;
            }
            txtEdgeBigDefectWidthThresh_NegativeB.Text = Global.edgeBigDefectWidthThreshNegativeB;
            txtEdgeBigDefectHeightThresh_NegativeB.Text = Global.edgeBigDefectHeightThreshNegativeB;
            txtEdgeSmallDefectDetectDepth_NegativeB.Text = Global.edgeSmallDefectDetectDepthNegativeB;
            txtEdgeSmallDefectGrayThresh_NegativeB.Text = Global.edgeSmallDefectGrayThreshNegativeB;
            txtEdgeSmallDefectWidthThresh_NegativeB.Text = Global.edgeSmallDefectWidthThreshNegativeB;
            txtEdgeSmallDefectHeightThresh_NegativeB.Text = Global.edgeSmallDefectHeightThreshNegativeB;
            txtEdgeSmallDefectGrayMeanThresh_NegativeB.Text = Global.edgeSmallDefectGrayMeanThreshNegativeB;
            txtEdgeSmallDefectGrayDeviationThresh_NegativeB.Text = Global.edgeSmallDefectGrayDeviationThreshNegativeB;
            txtCornerDefectAreaRatioThresh_NegativeB.Text = Global.cornerDefectAreaRatioThreshNegativeB;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingSurfaceDefectDetectNegativeB)))
            {
                chkIsUsingSurfaceDefectDetect_NegativeB.Checked = true;
            }
            else
            {
                chkIsUsingSurfaceDefectDetect_NegativeB.Checked = false;
            }
            txtSurfaceDefectGrayThresh_NegativeB.Text = Global.surfaceDefectGrayThreshNegativeB;
            txtSurfaceDefectWidthThresh_NegativeB.Text = Global.surfaceDefectWidthThreshNegativeB;
            txtSurfaceDefectHeightThresh_NegativeB.Text = Global.surfaceDefectHeightThreshNegativeB;
            txtSurfaceDefectDetectIndentDepth_NegativeB.Text = Global.surfaceDefectDetectIndentDepthNegativeB;
            txtSurfaceDefectViceLineShieldWidth_NegativeB.Text = Global.surfaceDefectViceLineShieldWidthNegativeB;
            txtSurfaceDefectViceLineShieldLeftPosOffSet_NegativeB.Text = Global.surfaceDefectViceLineShieldLeftPosOffSetNegativeB;
            txtSurfaceDefectViceLineShieldRightPosOffSet_NegativeB.Text = Global.surfaceDefectViceLineShieldRightPosOffSetNegativeB;
            txtSurfaceScratchGrayThresh_NegativeB.Text = Global.surfaceScratchGrayThreshNegativeB;
            txtSurfaceScratchWidthThresh_NegativeB.Text = Global.surfaceScratchWidthThreshNegativeB;
            txtSurfaceScratchHeightThresh_NegativeB.Text = Global.surfaceScratchHeightThreshNegativeB;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingBrokenLineDetectNegativeB)))
            {
                chkIsUsingBrokenLineDetect_NegativeB.Checked = true;
            }
            else
            {
                chkIsUsingBrokenLineDetect_NegativeB.Checked = false;
            }
            txtBrokenLineGrayThresh_NegativeB.Text = Global.brokenLineGrayThreshNegativeB;
            txtBrokenLineWidthThresh_NegativeB.Text = Global.brokenLineWidthThreshNegativeB;
            txtBrokenLineHeightThresh_NegativeB.Text = Global.brokenLineHeightThreshNegativeB;
            txtBrokenLineDetectIndentDepth_NegativeB.Text = Global.brokenLineDetectIndentDepthNegativeB;
            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingStartWeldingDetectNegativeB)))
            {
                chkIsUsingStartWeldingDetect_NegativeB.Checked = true;
            }
            else
            {
                chkIsUsingStartWeldingDetect_NegativeB.Checked = false;
            }
            txtStartWeldingDistanceMinThresh_NegativeB.Text = Global.startWeldingDistanceMinThreshNegativeB;
            txtStartWeldingDistanceMaxThresh_NegativeB.Text = Global.startWeldingDistanceMaxThreshNegativeB;
            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingSurfaceColorDiffDetectNegativeB)))
            {
                chkIsUsingSurfaceColorDiffDetect_NegativeB.Checked = true;
            }
            else
            {
                chkIsUsingSurfaceColorDiffDetect_NegativeB.Checked = false;
            }
            txtSurfaceColorDiffGrayThresh_NegativeB.Text = Global.surfaceColorDiffGrayThreshNegativeB;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingAlarmFunction_NegativeB)))
            {
                chkIsUsingAlarmFunction_NegativeB.Checked = true;
            }
            else
            {
                chkIsUsingAlarmFunction_NegativeB.Checked = false;
            }
            txtMaxAlamClusterCount_NegativeB.Text = Global.maxAlamClusterCount_NegativeB;

            if (Convert.ToBoolean(Convert.ToInt32(Global.isSaveAllImage_NegativeB)))
            {
                chkIsSaveAllImage_NegativeB.Checked = true;
            }
            else
            {
                chkIsSaveAllImage_NegativeB.Checked = false;
            }
            if (Convert.ToBoolean(Convert.ToInt32(Global.isSaveNGImage_NegativeB)))
            {
                chkIsSaveNGImage_NegativeB.Checked = true;
            }
            else
            {
                chkIsSaveNGImage_NegativeB.Checked = false;
            }
            if (Convert.ToBoolean(Convert.ToInt32(Global.isSaveNGImageWithRoi_NegativeB)))
            {
                chkIsSaveNGImageWithRoi_NegativeB.Checked = true;
            }
            else
            {
                chkIsSaveNGImageWithRoi_NegativeB.Checked = false;
            }
            if (Convert.ToBoolean(Convert.ToInt32(Global.isUsingCamera_NegativeB)))
            {
                chkIsUsingCamera_NegativeB.Checked = true;
            }
            else
            {
                chkIsUsingCamera_NegativeB.Checked = false;
            }
            #endregion
        }

        private void btnLoadRecipe_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "D:\\Program Files\\Config\\033\\";
            openFileDialog.Filter = "串检配方文件|*.ini";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                mainForm.ReadConfig(openFileDialog.FileName);
                this.RefreshRecipeInfo();
                mainForm.RefreshRecipeGlobalParameter();
                mainForm.RefreshRecipeParameterPositiveA();
                mainForm.RefreshRecipeParameterPositiveB();
                mainForm.RefreshRecipeParameterNegativeA();
                mainForm.RefreshRecipeParameterNegativeB();

                mainForm.InitNGArray();
                //this.SaveDefaultRecipe();
                MessageBox.Show("参数已加载！");
            }
        }

        private void btnSaveRecipe_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();//定义新的文件保存位置控件
            saveFileDialog.InitialDirectory = "D:\\Program Files\\Config\\033\\";
            saveFileDialog.Filter = "ini文件(*.ini)|*.ini";//设置文件后缀的过滤
            if (saveFileDialog.ShowDialog() == DialogResult.OK)//如果有文件保存路径
            {
                this.SaveOtherRecipe(saveFileDialog.FileName);
            }
        }
        //参数日志保存(参数)
        private void ChangeConfigLog(string oriParameter, string newParameter, string parameterName)
        {
            if (newParameter.Trim() != oriParameter.Trim())
            {
                Global.SaveLog("D:\\Program Files\\Config\\033\\参数修改日志.txt",
                        DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss:ff") + " 管理员将" + parameterName + "从" + oriParameter + "改为" + newParameter);
            }

        }
        //参数日志保存(功能切除和开启)
        private void ChangeFuncConfigLog(string oriParameter, bool newParameter, string parameterName)
        {
            if (newParameter== true & oriParameter.Trim() == "0")
            {
                Global.SaveLog("D:\\Program Files\\Config\\033\\参数修改日志.txt",
                        DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss:ff") + " 管理员将" + parameterName +"开启");
            }
            if (newParameter == false & oriParameter.Trim() == "1")
            {
                Global.SaveLog("D:\\Program Files\\Config\\033\\参数修改日志.txt",
                        DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss:ff") + " 管理员将" + parameterName + "切除");
            }

        }
        //读修改前参数
        private void ReadTempParameters()
        {
            RefreshRecipeInfo();

        }
        private void btnParameterFormOK_Click(object sender, EventArgs e)
        {
            if ((isNumberic(txtTopShieldLengthOfTopRegion_PositiveA.Text) || isDouble(txtTopShieldLengthOfTopRegion_PositiveA.Text))
                && (isNumberic(txtBottomShieldLengthOfTopRegion_PositiveA.Text) || isDouble(txtBottomShieldLengthOfTopRegion_PositiveA.Text))
                && (isNumberic(txtTopShieldLengthOfBottomRegion_PositiveA.Text) || isDouble(txtTopShieldLengthOfBottomRegion_PositiveA.Text))
                && (isNumberic(txtBottomShieldLengthOfBottomRegion_PositiveA.Text) || isDouble(txtBottomShieldLengthOfBottomRegion_PositiveA.Text))
                && (isNumberic(txtLocationMainLineThresh_PositiveA.Text))
                && (isNumberic(txtFilmWidthThresh_PositiveA.Text) || isDouble(txtFilmWidthThresh_PositiveA.Text))
                && (isNumberic(txtFilmWidthOffSet_PositiveA.Text) || isDouble(txtFilmWidthOffSet_PositiveA.Text))
                && (isNumberic(txtWeldWidthThresh_PositiveA.Text) || isDouble(txtWeldWidthThresh_PositiveA.Text))
                && (isNumberic(txtHeadAndTailFilmWidthThresh_PositiveA.Text) || isDouble(txtHeadAndTailFilmWidthThresh_PositiveA.Text))
                && (isNumberic(txtHeadAndTailFilmShieldLength_PositiveA.Text) || isDouble(txtHeadAndTailFilmShieldLength_PositiveA.Text))
                && (isNumberic(txtHeadAndTailFilmDetectRange_PositiveA.Text) || isDouble(txtHeadAndTailFilmDetectRange_PositiveA.Text))
                && (isNumberic(txtWaferWidth_PositiveA.Text) || isDouble(txtWaferWidth_PositiveA.Text))
                && (isNumberic(txtWidthResolution_PositiveA.Text) || isDouble(txtWidthResolution_PositiveA.Text))
                && (isNumberic(txtViceLineInterval_PositiveA.Text) || isDouble(txtViceLineInterval_PositiveA.Text))
                && (isNumberic(txtHeightResolution_PositiveA.Text) || isDouble(txtHeightResolution_PositiveA.Text))
                && (isNumberic(txtFirstDetectPosForTopRegion_PositiveA.Text) || isDouble(txtFirstDetectPosForTopRegion_PositiveA.Text))
                && (isNumberic(txtSecondDetectPosForTopRegion_PositiveA.Text) || isDouble(txtSecondDetectPosForTopRegion_PositiveA.Text))
                && (isNumberic(txtFirstDetectPosForBottomRegion_PositiveA.Text) || isDouble(txtFirstDetectPosForBottomRegion_PositiveA.Text))
                && (isNumberic(txtSecondDetectPosForBottomRegion_PositiveA.Text) || isDouble(txtSecondDetectPosForBottomRegion_PositiveA.Text))
                && (isNumberic(txtLocationWaferEdgeThresh_PositiveA.Text))
                && (isNumberic(txtWaferEdgeCalibrationRegionDilationPixel_PositiveA.Text))
                && (isNumberic(txtMinimumDistanceThresh_PositiveA.Text) || isDouble(txtMinimumDistanceThresh_PositiveA.Text))
                && (isNumberic(txtMaxDistanceThresh_PositiveA.Text) || isDouble(txtMaxDistanceThresh_PositiveA.Text))
                && (isNumberic(txtClassDistanceThresh_PositiveA.Text) || isDouble(txtClassDistanceThresh_PositiveA.Text))
                && (isNumberic(txtEdgeBigDefectWidthThresh_PositiveA.Text) || isDouble(txtEdgeBigDefectWidthThresh_PositiveA.Text))
                && (isNumberic(txtEdgeBigDefectHeightThresh_PositiveA.Text) || isDouble(txtEdgeBigDefectHeightThresh_PositiveA.Text))
                && (isNumberic(txtEdgeSmallDefectDetectDepth_PositiveA.Text) || isDouble(txtEdgeSmallDefectDetectDepth_PositiveA.Text))
                && (isNumberic(txtEdgeSmallDefectGrayThresh_PositiveA.Text))
                && (isNumberic(txtEdgeSmallDefectWidthThresh_PositiveA.Text) || isDouble(txtEdgeSmallDefectWidthThresh_PositiveA.Text))
                && (isNumberic(txtEdgeSmallDefectHeightThresh_PositiveA.Text) || isDouble(txtEdgeSmallDefectHeightThresh_PositiveA.Text))
                && (isNumberic(txtEdgeSmallDefectGrayMeanThresh_PositiveA.Text) || isDouble(txtEdgeSmallDefectGrayMeanThresh_PositiveA.Text))
                && (isNumberic(txtEdgeSmallDefectGrayDeviationThresh_PositiveA.Text) || isDouble(txtEdgeSmallDefectGrayDeviationThresh_PositiveA.Text))
                && (isNumberic(txtCornerDefectAreaRatioThresh_PositiveA.Text) || isDouble(txtCornerDefectAreaRatioThresh_PositiveA.Text))
                && (isNumberic(txtSurfaceDefectGrayThresh_PositiveA.Text))
                && (isNumberic(txtSurfaceDefectWidthThresh_PositiveA.Text) || isDouble(txtSurfaceDefectWidthThresh_PositiveA.Text))
                && (isNumberic(txtSurfaceDefectHeightThresh_PositiveA.Text) || isDouble(txtSurfaceDefectHeightThresh_PositiveA.Text))
                && (isNumberic(txtSurfaceDefectDetectIndentDepth_PositiveA.Text) || isDouble(txtSurfaceDefectDetectIndentDepth_PositiveA.Text))
                && (isNumberic(txtSurfaceDefectViceLineShieldWidth_PositiveA.Text))
                && (isNumberic(txtSurfaceDefectViceLineShieldLeftPosOffSet_PositiveA.Text))
                && (isNumberic(txtSurfaceDefectViceLineShieldRightPosOffSet_PositiveA.Text))
                && (isNumberic(txtMaxAlamClusterCount_PositiveA.Text))

                && (isNumberic(txtTopShieldLengthOfTopRegion_PositiveB.Text) || isDouble(txtTopShieldLengthOfTopRegion_PositiveB.Text))
                && (isNumberic(txtBottomShieldLengthOfTopRegion_PositiveB.Text) || isDouble(txtBottomShieldLengthOfTopRegion_PositiveB.Text))
                && (isNumberic(txtTopShieldLengthOfBottomRegion_PositiveB.Text) || isDouble(txtTopShieldLengthOfBottomRegion_PositiveB.Text))
                && (isNumberic(txtBottomShieldLengthOfBottomRegion_PositiveB.Text) || isDouble(txtBottomShieldLengthOfBottomRegion_PositiveB.Text))
                && (isNumberic(txtLocationMainLineThresh_PositiveB.Text))
                && (isNumberic(txtFilmWidthThresh_PositiveB.Text) || isDouble(txtFilmWidthThresh_PositiveB.Text))
                && (isNumberic(txtFilmWidthOffSet_PositiveB.Text) || isDouble(txtFilmWidthOffSet_PositiveB.Text))
                && (isNumberic(txtWeldWidthThresh_PositiveB.Text) || isDouble(txtWeldWidthThresh_PositiveB.Text))
                && (isNumberic(txtHeadAndTailFilmWidthThresh_PositiveB.Text) || isDouble(txtHeadAndTailFilmWidthThresh_PositiveB.Text))
                && (isNumberic(txtHeadAndTailFilmShieldLength_PositiveB.Text) || isDouble(txtHeadAndTailFilmShieldLength_PositiveB.Text))
                && (isNumberic(txtHeadAndTailFilmDetectRange_PositiveB.Text) || isDouble(txtHeadAndTailFilmDetectRange_PositiveB.Text))
                && (isNumberic(txtWaferWidth_PositiveB.Text) || isDouble(txtWaferWidth_PositiveB.Text))
                && (isNumberic(txtWidthResolution_PositiveB.Text) || isDouble(txtWidthResolution_PositiveB.Text))
                && (isNumberic(txtViceLineInterval_PositiveB.Text) || isDouble(txtViceLineInterval_PositiveB.Text))
                && (isNumberic(txtHeightResolution_PositiveB.Text) || isDouble(txtHeightResolution_PositiveB.Text))
                 && (isNumberic(txtFirstDetectPosForTopRegion_PositiveB.Text) || isDouble(txtFirstDetectPosForTopRegion_PositiveB.Text))
                && (isNumberic(txtSecondDetectPosForTopRegion_PositiveB.Text) || isDouble(txtSecondDetectPosForTopRegion_PositiveB.Text))
                && (isNumberic(txtFirstDetectPosForBottomRegion_PositiveB.Text) || isDouble(txtFirstDetectPosForBottomRegion_PositiveB.Text))
                && (isNumberic(txtSecondDetectPosForBottomRegion_PositiveB.Text) || isDouble(txtSecondDetectPosForBottomRegion_PositiveB.Text))
                && (isNumberic(txtLocationWaferEdgeThresh_PositiveB.Text))
                && (isNumberic(txtWaferEdgeCalibrationRegionDilationPixel_PositiveB.Text))
                && (isNumberic(txtMinimumDistanceThresh_PositiveB.Text) || isDouble(txtMinimumDistanceThresh_PositiveB.Text))
                && (isNumberic(txtMaxDistanceThresh_PositiveB.Text) || isDouble(txtMaxDistanceThresh_PositiveB.Text))
                && (isNumberic(txtClassDistanceThresh_PositiveB.Text) || isDouble(txtClassDistanceThresh_PositiveB.Text))
                && (isNumberic(txtEdgeBigDefectWidthThresh_PositiveB.Text) || isDouble(txtEdgeBigDefectWidthThresh_PositiveB.Text))
                && (isNumberic(txtEdgeBigDefectHeightThresh_PositiveB.Text) || isDouble(txtEdgeBigDefectHeightThresh_PositiveB.Text))
                && (isNumberic(txtEdgeSmallDefectDetectDepth_PositiveB.Text) || isDouble(txtEdgeSmallDefectDetectDepth_PositiveB.Text))
                && (isNumberic(txtEdgeSmallDefectGrayThresh_PositiveB.Text))
                && (isNumberic(txtEdgeSmallDefectWidthThresh_PositiveB.Text) || isDouble(txtEdgeSmallDefectWidthThresh_PositiveB.Text))
                && (isNumberic(txtEdgeSmallDefectHeightThresh_PositiveB.Text) || isDouble(txtEdgeSmallDefectHeightThresh_PositiveB.Text))
                && (isNumberic(txtEdgeSmallDefectGrayMeanThresh_PositiveB.Text) || isDouble(txtEdgeSmallDefectGrayMeanThresh_PositiveB.Text))
                && (isNumberic(txtEdgeSmallDefectGrayDeviationThresh_PositiveB.Text) || isDouble(txtEdgeSmallDefectGrayDeviationThresh_PositiveB.Text))
                && (isNumberic(txtCornerDefectAreaRatioThresh_PositiveB.Text) || isDouble(txtCornerDefectAreaRatioThresh_PositiveB.Text))
                && (isNumberic(txtSurfaceDefectGrayThresh_PositiveB.Text))
                && (isNumberic(txtSurfaceDefectWidthThresh_PositiveB.Text) || isDouble(txtSurfaceDefectWidthThresh_PositiveB.Text))
                && (isNumberic(txtSurfaceDefectHeightThresh_PositiveB.Text) || isDouble(txtSurfaceDefectHeightThresh_PositiveB.Text))
                && (isNumberic(txtSurfaceDefectDetectIndentDepth_PositiveB.Text) || isDouble(txtSurfaceDefectDetectIndentDepth_PositiveB.Text))
                && (isNumberic(txtSurfaceDefectViceLineShieldWidth_PositiveB.Text))
                && (isNumberic(txtSurfaceDefectViceLineShieldLeftPosOffSet_PositiveB.Text))
                && (isNumberic(txtSurfaceDefectViceLineShieldRightPosOffSet_PositiveB.Text))
                && (isNumberic(txtMaxAlamClusterCount_PositiveB.Text))
                
                && (isNumberic(txtTopShieldLengthOfTopRegion_NegativeA.Text) || isDouble(txtTopShieldLengthOfTopRegion_NegativeA.Text))
                && (isNumberic(txtBottomShieldLengthOfTopRegion_NegativeA.Text) || isDouble(txtBottomShieldLengthOfTopRegion_NegativeA.Text))
                && (isNumberic(txtTopShieldLengthOfBottomRegion_NegativeA.Text) || isDouble(txtTopShieldLengthOfBottomRegion_NegativeA.Text))
                && (isNumberic(txtBottomShieldLengthOfBottomRegion_NegativeA.Text) || isDouble(txtBottomShieldLengthOfBottomRegion_NegativeA.Text))
                && (isNumberic(txtLocationMainLineThresh_NegativeA.Text))
                && (isNumberic(txtFilmWidthThresh_NegativeA.Text) || isDouble(txtFilmWidthThresh_NegativeA.Text))
                && (isNumberic(txtFilmWidthOffSet_NegativeA.Text) || isDouble(txtFilmWidthOffSet_NegativeA.Text))
                && (isNumberic(txtWeldWidthThresh_NegativeA.Text) || isDouble(txtWeldWidthThresh_NegativeA.Text))
                && (isNumberic(txtHeadAndTailFilmWidthThresh_NegativeA.Text) || isDouble(txtHeadAndTailFilmWidthThresh_NegativeA.Text))
                && (isNumberic(txtHeadAndTailFilmShieldLength_NegativeA.Text) || isDouble(txtHeadAndTailFilmShieldLength_NegativeA.Text))
                && (isNumberic(txtHeadAndTailFilmDetectRange_NegativeA.Text) || isDouble(txtHeadAndTailFilmDetectRange_NegativeA.Text))
                && (isNumberic(txtWaferWidth_NegativeA.Text) || isDouble(txtWaferWidth_NegativeA.Text))
                && (isNumberic(txtWidthResolution_NegativeA.Text) || isDouble(txtWidthResolution_NegativeA.Text))
                && (isNumberic(txtViceLineInterval_NegativeA.Text) || isDouble(txtViceLineInterval_NegativeA.Text))
                && (isNumberic(txtHeightResolution_NegativeA.Text) || isDouble(txtHeightResolution_NegativeA.Text))
                && (isNumberic(txtFirstDetectPosForTopRegion_NegativeA.Text) || isDouble(txtFirstDetectPosForTopRegion_NegativeA.Text))
                && (isNumberic(txtSecondDetectPosForTopRegion_NegativeA.Text) || isDouble(txtSecondDetectPosForTopRegion_NegativeA.Text))
                && (isNumberic(txtFirstDetectPosForBottomRegion_NegativeA.Text) || isDouble(txtFirstDetectPosForBottomRegion_NegativeA.Text))
                && (isNumberic(txtSecondDetectPosForBottomRegion_NegativeA.Text) || isDouble(txtSecondDetectPosForBottomRegion_NegativeA.Text))
                && (isNumberic(txtLocationWaferEdgeThresh_NegativeA.Text))
                && (isNumberic(txtWaferEdgeCalibrationRegionDilationPixel_NegativeA.Text))
                && (isNumberic(txtMinimumDistanceThresh_NegativeA.Text) || isDouble(txtMinimumDistanceThresh_NegativeA.Text))
                && (isNumberic(txtMaxDistanceThresh_NegativeA.Text) || isDouble(txtMaxDistanceThresh_NegativeA.Text))
                && (isNumberic(txtClassDistanceThresh_NegativeA.Text) || isDouble(txtClassDistanceThresh_NegativeA.Text))
                && (isNumberic(txtEdgeBigDefectWidthThresh_NegativeA.Text) || isDouble(txtEdgeBigDefectWidthThresh_NegativeA.Text))
                && (isNumberic(txtEdgeBigDefectHeightThresh_NegativeA.Text) || isDouble(txtEdgeBigDefectHeightThresh_NegativeA.Text))
                && (isNumberic(txtEdgeSmallDefectDetectDepth_NegativeA.Text) || isDouble(txtEdgeSmallDefectDetectDepth_NegativeA.Text))
                && (isNumberic(txtEdgeSmallDefectGrayThresh_NegativeA.Text))
                && (isNumberic(txtEdgeSmallDefectWidthThresh_NegativeA.Text) || isDouble(txtEdgeSmallDefectWidthThresh_NegativeA.Text))
                && (isNumberic(txtEdgeSmallDefectHeightThresh_NegativeA.Text) || isDouble(txtEdgeSmallDefectHeightThresh_NegativeA.Text))
                && (isNumberic(txtEdgeSmallDefectGrayMeanThresh_NegativeA.Text) || isDouble(txtEdgeSmallDefectGrayMeanThresh_NegativeA.Text))
                && (isNumberic(txtEdgeSmallDefectGrayDeviationThresh_NegativeA.Text) || isDouble(txtEdgeSmallDefectGrayDeviationThresh_NegativeA.Text))
                && (isNumberic(txtCornerDefectAreaRatioThresh_NegativeA.Text) || isDouble(txtCornerDefectAreaRatioThresh_NegativeA.Text))
                && (isNumberic(txtSurfaceDefectGrayThresh_NegativeA.Text))
                && (isNumberic(txtSurfaceDefectWidthThresh_NegativeA.Text) || isDouble(txtSurfaceDefectWidthThresh_NegativeA.Text))
                && (isNumberic(txtSurfaceDefectHeightThresh_NegativeA.Text) || isDouble(txtSurfaceDefectHeightThresh_NegativeA.Text))
                && (isNumberic(txtSurfaceDefectDetectIndentDepth_NegativeA.Text) || isDouble(txtSurfaceDefectDetectIndentDepth_NegativeA.Text))
                && (isNumberic(txtSurfaceDefectViceLineShieldWidth_NegativeA.Text))
                && (isNumberic(txtSurfaceDefectViceLineShieldLeftPosOffSet_NegativeA.Text))
                && (isNumberic(txtSurfaceDefectViceLineShieldRightPosOffSet_NegativeA.Text))
                && (isNumberic(txtMaxAlamClusterCount_NegativeA.Text))
                 && (isNumberic(txtMainLineDistance.Text) || isDouble(txtMainLineDistance.Text))

                && (isNumberic(txtTopShieldLengthOfTopRegion_NegativeB.Text) || isDouble(txtTopShieldLengthOfTopRegion_NegativeB.Text))
                && (isNumberic(txtBottomShieldLengthOfTopRegion_NegativeB.Text) || isDouble(txtBottomShieldLengthOfTopRegion_NegativeB.Text))
                && (isNumberic(txtTopShieldLengthOfBottomRegion_NegativeB.Text) || isDouble(txtTopShieldLengthOfBottomRegion_NegativeB.Text))
                && (isNumberic(txtBottomShieldLengthOfBottomRegion_NegativeB.Text) || isDouble(txtBottomShieldLengthOfBottomRegion_NegativeB.Text))
                && (isNumberic(txtLocationMainLineThresh_NegativeB.Text))
                && (isNumberic(txtFilmWidthThresh_NegativeB.Text) || isDouble(txtFilmWidthThresh_NegativeB.Text))
                && (isNumberic(txtFilmWidthOffSet_NegativeB.Text) || isDouble(txtFilmWidthOffSet_NegativeB.Text))
                && (isNumberic(txtWeldWidthThresh_NegativeB.Text) || isDouble(txtWeldWidthThresh_NegativeB.Text))
                && (isNumberic(txtHeadAndTailFilmWidthThresh_NegativeB.Text) || isDouble(txtHeadAndTailFilmWidthThresh_NegativeB.Text))
                && (isNumberic(txtHeadAndTailFilmShieldLength_NegativeB.Text) || isDouble(txtHeadAndTailFilmShieldLength_NegativeB.Text))
                && (isNumberic(txtHeadAndTailFilmDetectRange_NegativeB.Text) || isDouble(txtHeadAndTailFilmDetectRange_NegativeB.Text))
                && (isNumberic(txtWaferWidth_NegativeB.Text) || isDouble(txtWaferWidth_NegativeB.Text))
                && (isNumberic(txtWidthResolution_NegativeB.Text) || isDouble(txtWidthResolution_NegativeB.Text))
                && (isNumberic(txtViceLineInterval_NegativeB.Text) || isDouble(txtViceLineInterval_NegativeB.Text))
                && (isNumberic(txtHeightResolution_NegativeB.Text) || isDouble(txtHeightResolution_NegativeB.Text))
                && (isNumberic(txtFirstDetectPosForTopRegion_NegativeB.Text) || isDouble(txtFirstDetectPosForTopRegion_NegativeB.Text))
                && (isNumberic(txtSecondDetectPosForTopRegion_NegativeB.Text) || isDouble(txtSecondDetectPosForTopRegion_NegativeB.Text))
                && (isNumberic(txtFirstDetectPosForBottomRegion_NegativeB.Text) || isDouble(txtFirstDetectPosForBottomRegion_NegativeB.Text))
                && (isNumberic(txtSecondDetectPosForBottomRegion_NegativeB.Text) || isDouble(txtSecondDetectPosForBottomRegion_NegativeB.Text))
                && (isNumberic(txtLocationWaferEdgeThresh_NegativeB.Text))
                && (isNumberic(txtWaferEdgeCalibrationRegionDilationPixel_NegativeB.Text))
                && (isNumberic(txtMinimumDistanceThresh_NegativeB.Text) || isDouble(txtMinimumDistanceThresh_NegativeB.Text))
                && (isNumberic(txtMaxDistanceThresh_NegativeB.Text) || isDouble(txtMaxDistanceThresh_NegativeB.Text))
                && (isNumberic(txtClassDistanceThresh_NegativeB.Text) || isDouble(txtClassDistanceThresh_NegativeB.Text))
                && (isNumberic(txtEdgeBigDefectWidthThresh_NegativeB.Text) || isDouble(txtEdgeBigDefectWidthThresh_NegativeB.Text))
                && (isNumberic(txtEdgeBigDefectHeightThresh_NegativeB.Text) || isDouble(txtEdgeBigDefectHeightThresh_NegativeB.Text))
                && (isNumberic(txtEdgeSmallDefectDetectDepth_NegativeB.Text) || isDouble(txtEdgeSmallDefectDetectDepth_NegativeB.Text))
                && (isNumberic(txtEdgeSmallDefectGrayThresh_NegativeB.Text))
                && (isNumberic(txtEdgeSmallDefectWidthThresh_NegativeB.Text) || isDouble(txtEdgeSmallDefectWidthThresh_NegativeB.Text))
                && (isNumberic(txtEdgeSmallDefectHeightThresh_NegativeB.Text) || isDouble(txtEdgeSmallDefectHeightThresh_NegativeB.Text))
                && (isNumberic(txtEdgeSmallDefectGrayMeanThresh_NegativeB.Text) || isDouble(txtEdgeSmallDefectGrayMeanThresh_NegativeB.Text))
                && (isNumberic(txtEdgeSmallDefectGrayDeviationThresh_NegativeB.Text) || isDouble(txtEdgeSmallDefectGrayDeviationThresh_NegativeB.Text))
                && (isNumberic(txtCornerDefectAreaRatioThresh_NegativeB.Text) || isDouble(txtCornerDefectAreaRatioThresh_NegativeB.Text))
                && (isNumberic(txtSurfaceDefectGrayThresh_NegativeB.Text))
                && (isNumberic(txtSurfaceDefectWidthThresh_NegativeB.Text) || isDouble(txtSurfaceDefectWidthThresh_NegativeB.Text))
                && (isNumberic(txtSurfaceDefectHeightThresh_NegativeB.Text) || isDouble(txtSurfaceDefectHeightThresh_NegativeB.Text))
                && (isNumberic(txtSurfaceDefectDetectIndentDepth_NegativeB.Text) || isDouble(txtSurfaceDefectDetectIndentDepth_NegativeB.Text))
                && (isNumberic(txtSurfaceDefectViceLineShieldWidth_NegativeB.Text))
                && (isNumberic(txtSurfaceDefectViceLineShieldLeftPosOffSet_NegativeB.Text))
                && (isNumberic(txtSurfaceDefectViceLineShieldRightPosOffSet_NegativeB.Text))
                && (isNumberic(txtMaxAlamClusterCount_NegativeB.Text)))
            {
                //记录修改日志
                #region 公有配方修改日志
                ChangeConfigLog(Global.mainLineNum, cbxMainLineNum.Text, "主栅数量");
                ChangeConfigLog(Global.mainLineDistance, txtMainLineDistance.Text, "主栅线间距");
                ChangeConfigLog(Global.waferCountPerClass, cbxWaferCountPerClass.Text, "单串片数");
                ChangeConfigLog(Global.subMainLineNum, cbxSubMainLineNum.Text, "纵向细栅数量");
                ChangeConfigLog(Global.stringType, cbxStringType.Text, "电池串类型");
                ChangeFuncConfigLog(Global.isDoubleDetect, chxIsDoubleDetect.Checked, "双面串检");
                ChangeFuncConfigLog(Global.isFullWafer, chxIsFullWafer.Checked, "全片");
                ChangeFuncConfigLog(Global.isMESFun, chxIsMESFun.Checked, "MES");
                ChangeFuncConfigLog(Global.isUpperLink, chxIsUpperLink.Checked, "上位链路");
                #endregion
                #region A侧正面日志记录
                ChangeConfigLog(Global.topShieldLengthOfTopRegionPositiveA, txtTopShieldLengthOfTopRegion_PositiveA.Text, "A侧正面上半片上屏蔽高度");
                ChangeConfigLog(Global.bottomShieldLengthOfTopRegionPositiveA, txtBottomShieldLengthOfTopRegion_PositiveA.Text, "A侧正面上半片下屏蔽高度");
                ChangeConfigLog(Global.topShieldLengthOfBottomRegionPositiveA, txtTopShieldLengthOfBottomRegion_PositiveA.Text, "A侧正面下半片上屏蔽高度");
                ChangeConfigLog(Global.bottomShieldLengthOfBottomRegionPositiveA, txtBottomShieldLengthOfBottomRegion_PositiveA.Text, "A侧正面下半片下屏蔽高度");
                ChangeConfigLog(Global.locationMainLineThreshPositiveA, txtLocationMainLineThresh_PositiveA.Text, "A侧正面主删线定位阈值");
                ChangeConfigLog(Global.filmWidthThreshPositiveA, txtFilmWidthThresh_PositiveA.Text, "A侧正面贴膜宽度阈值");
                ChangeConfigLog(Global.filmWidthOffSetPositiveA, txtFilmWidthOffSet_PositiveA.Text, "A侧正面贴膜宽度补偿值");

                ChangeConfigLog(Global.weldWidthThreshPositiveA, txtWeldWidthThresh_PositiveA.Text, "A侧正面膜/焊带缺失阈值");
                ChangeConfigLog(Global.weldShieldLengthPositiveA, txtWeldShieldLength_PositiveA.Text, "A侧正面膜/焊带缺失屏蔽阈值");

                ChangeConfigLog(Global.firstDetectPosForTopRegionPositiveA, txtFirstDetectPosForTopRegion_PositiveA.Text, "A侧正面上半片检测点1POS");
                ChangeConfigLog(Global.secondDetectPosForTopRegionPositiveA, txtSecondDetectPosForTopRegion_PositiveA.Text, "A侧正面上半片检测点2POS");
                ChangeConfigLog(Global.firstDetectPosForBottomRegionPositiveA, txtFirstDetectPosForBottomRegion_PositiveA.Text, "A侧正面下半片检测点1POS");
                ChangeConfigLog(Global.secondDetectPosForBottomRegionPositiveA, txtSecondDetectPosForBottomRegion_PositiveA.Text, "A侧正面下半片检测点2POS");

                ChangeConfigLog(Global.headAndTailFilmWidthThreshPositiveA, txtHeadAndTailFilmWidthThresh_PositiveA.Text, "A侧正面头尾贴膜检测宽度阈值");
                ChangeConfigLog(Global.headAndTailFilmShieldLengthPositiveA, txtHeadAndTailFilmShieldLength_PositiveA.Text, "A侧正面都为膜检缩进距离");
                ChangeConfigLog(Global.headAndTailFilmDetectRangePositiveA, txtHeadAndTailFilmDetectRange_PositiveA.Text, "A侧正面头尾膜检范围");

                ChangeConfigLog(Global.waferWidthPositiveA, txtWaferWidth_PositiveA.Text, "A侧正面主删线宽度");
                ChangeConfigLog(Global.widthResolutionPositiveA, txtWidthResolution_PositiveA.Text, "A侧正面宽度分辨率");

                ChangeConfigLog(Global.viceLineInterval, txtViceLineInterval_PositiveA.Text, "A侧正面副栅线间距");
                ChangeConfigLog(Global.heightResolutionPositiveA, txtHeightResolution_PositiveA.Text, "A侧正面高度分辨率");

                ChangeConfigLog(Global.locationWaferEdgeThreshPositiveA, txtLocationWaferEdgeThresh_PositiveA.Text, "A侧正面边缘优化定位阈值");
                ChangeConfigLog(Global.waferEdgeCalibrationRegionDilationPixelPositiveA, txtWaferEdgeCalibrationRegionDilationPixel_PositiveA.Text, "A侧正面边缘膨胀像素（Pixel）");

                ChangeConfigLog(Global.minimumDistanceThreshPositiveA, txtMinimumDistanceThresh_PositiveA.Text, "A侧正面最小片间距阈值");
                ChangeConfigLog(Global.maxDistanceThreshPositiveA, txtMaxDistanceThresh_PositiveA.Text, "A侧正面最大片间距阈值");
                ChangeConfigLog(Global.classDistanceThreshPositiveA, txtClassDistanceThresh_PositiveA.Text, "A侧正面串间距阈值");

                ChangeConfigLog(Global.edgeBigDefectWidthThreshPositiveA, txtEdgeBigDefectWidthThresh_PositiveA.Text, "A侧正面大缺陷宽度阈值");
                ChangeConfigLog(Global.edgeBigDefectHeightThreshPositiveA, txtEdgeBigDefectHeightThresh_PositiveA.Text, "A侧正面大缺陷高度阈值");
                ChangeConfigLog(Global.edgeSmallDefectDetectDepthPositiveA, txtEdgeSmallDefectDetectDepth_PositiveA.Text, "A侧正面小缺陷检测深度");
                ChangeConfigLog(Global.edgeSmallDefectGrayThreshPositiveA, txtEdgeSmallDefectGrayThresh_PositiveA.Text, "A侧正面小缺陷背景灰度差阈值");
                ChangeConfigLog(Global.edgeSmallDefectWidthThreshPositiveA, txtEdgeSmallDefectWidthThresh_PositiveA.Text, "A侧正面小缺陷宽度阈值");
                ChangeConfigLog(Global.edgeSmallDefectHeightThreshPositiveA, txtEdgeSmallDefectHeightThresh_PositiveA.Text, "A侧正面小缺陷高度阈值");
                ChangeConfigLog(Global.edgeSmallDefectGrayMeanThreshPositiveA, txtEdgeSmallDefectGrayMeanThresh_PositiveA.Text, "A侧正面小缺陷灰度均值阈值");
                ChangeConfigLog(Global.edgeSmallDefectGrayDeviationThreshPositiveA, txtEdgeSmallDefectGrayDeviationThresh_PositiveA.Text, "A侧正面小缺陷灰度方差阈值");
                ChangeConfigLog(Global.cornerDefectAreaRatioThreshPositiveA, txtCornerDefectAreaRatioThresh_PositiveA.Text, "A侧正面角部缺陷面积比例阈值");

                ChangeConfigLog(Global.surfaceDefectGrayThreshPositiveA, txtSurfaceDefectGrayThresh_PositiveA.Text, "A侧正面缺陷背景灰度差阈值");
                ChangeConfigLog(Global.surfaceDefectWidthThreshPositiveA, txtSurfaceDefectWidthThresh_PositiveA.Text, "A侧正面缺陷宽度阈值");
                ChangeConfigLog(Global.surfaceDefectHeightThreshPositiveA, txtSurfaceDefectHeightThresh_PositiveA.Text, "A侧正面缺陷宽度阈值");
                ChangeConfigLog(Global.surfaceDefectDetectIndentDepthPositiveA, txtSurfaceDefectDetectIndentDepth_PositiveA.Text, "A侧正面检测缩进距离");
                ChangeConfigLog(Global.surfaceDefectViceLineShieldWidthPositiveA, txtSurfaceDefectViceLineShieldWidth_PositiveA.Text, "A侧正面纵向细栅区域宽度（Pixel）");
                ChangeConfigLog(Global.surfaceDefectViceLineShieldLeftPosOffSetPositiveA, txtSurfaceDefectViceLineShieldLeftPosOffSet_PositiveA.Text, "A侧正面纵向细栅左侧补偿（Pixel）");
                ChangeConfigLog(Global.surfaceDefectViceLineShieldRightPosOffSetPositiveA, txtSurfaceDefectViceLineShieldRightPosOffSet_PositiveA.Text, "A侧正面纵向细栅右侧补偿（Pixel）");
                ChangeConfigLog(Global.surfaceScratchGrayThreshPositiveA, txtSurfaceScratchGrayThresh_PositiveA.Text, "A侧正面划痕背景灰度差阈值");
                ChangeConfigLog(Global.surfaceScratchWidthThreshPositiveA, txtSurfaceScratchWidthThresh_PositiveA.Text, "A侧正面划痕宽度阈值");
                ChangeConfigLog(Global.surfaceScratchHeightThreshPositiveA, txtSurfaceScratchHeightThresh_PositiveA.Text, "A侧正面划痕高度阈值");

                ChangeConfigLog(Global.brokenLineGrayThreshPositiveA, txtBrokenLineGrayThresh_PositiveA.Text, "A侧正面断栅背景灰度差阈值");
                ChangeConfigLog(Global.brokenLineWidthThreshPositiveA, txtBrokenLineWidthThresh_PositiveA.Text, "A侧正面断栅宽度阈值");
                ChangeConfigLog(Global.brokenLineHeightThreshPositiveA, txtBrokenLineHeightThresh_PositiveA.Text, "A侧正面断栅高度阈值");
                ChangeConfigLog(Global.brokenLineDetectIndentDepthPositiveA, txtBrokenLineDetectIndentDepth_PositiveA.Text, "A侧正面检测缩进距离");

                ChangeConfigLog(Global.startWeldingDistanceMinThreshPositiveA, txtStartWeldingDistanceMinThresh_PositiveA.Text, "A侧正面最小起焊点阈值");
                ChangeConfigLog(Global.startWeldingDistanceMaxThreshPositiveA, txtStartWeldingDistanceMaxThresh_PositiveA.Text, "A侧正面最大起焊点阈值");

                ChangeConfigLog(Global.surfaceColorDiffGrayThreshPositiveA, txtSurfaceColorDiffGrayThresh_PositiveA.Text, "A侧正面色差灰度差阈值");


                ChangeFuncConfigLog(Global.isUsingFilmShiftingDetectPositiveA, chkIsUsingFilmShiftingDetect_PositiveA.Checked, "A侧正面露白/膜偏检测");
                ChangeFuncConfigLog(Global.isUsingFilmMissDetectPositiveA, chkIsUsingFilmMissDetect_PositiveA.Checked, "A侧正面膜短/膜失检测");
                ChangeFuncConfigLog(Global.isUsingHeadAndTailFilmShiftingDetectPositiveA, chkIsUsingFilmShiftingHeadAndTailDetect_PositiveA.Checked, "A侧正面头尾膜偏检测");
                ChangeFuncConfigLog(Global.isUsingWidthResolutionCalibratePositiveA, chkIsUsingWidthResolutionCalibrate_PositiveA.Checked, "A侧正面宽度分辨率校准");
                ChangeFuncConfigLog(Global.isUsingHeightResolutionCalibratePositiveA, chkIsUsingHeightResolutionCalibrate_PositiveA.Checked, "A侧正面高度分辨率校准");
                ChangeFuncConfigLog(Global.isUsingWaferEdgeCalibrationPositiveA, chkIsUsingWaferEdgeCalibration_PositiveA.Checked, "A侧正面边缘优化");
                ChangeFuncConfigLog(Global.isUsingDistanceDetectPositiveA, chkIsUsingDistanceDetect_PositiveA.Checked, "A侧正面片/串间距");
                ChangeFuncConfigLog(Global.isUsingStartWeldingDetectPositiveA, chkIsUsingStartWeldingDetect_PositiveA.Checked, "A侧正面起焊点");
                ChangeFuncConfigLog(Global.isUsingEdgeDefectDetectPositiveA, chkIsUsingEdgeDefectDetect_PositiveA.Checked, "A侧正面边/角缺陷检测");
                ChangeFuncConfigLog(Global.isUsingSurfaceDefectDetectPositiveA, chkIsUsingSurfaceDefectDetect_PositiveA.Checked, "A侧正面表面缺陷检测");
                ChangeFuncConfigLog(Global.isUsingBrokenLineDetectPositiveA, chkIsUsingBrokenLineDetect_PositiveA.Checked, "A侧正面断栅检测");
                ChangeFuncConfigLog(Global.isUsingSurfaceColorDiffDetectPositiveA, chkIsUsingSurfaceColorDiffDetect_PositiveA.Checked, "A侧正面色差检测");
                
                ChangeFuncConfigLog(Global.isSaveAllImage_PositiveA, chkIsSaveAllImage_PositiveA.Checked, "A侧正面保存全部图片");
                ChangeFuncConfigLog(Global.isSaveNGImage_PositiveA, chkIsSaveNGImage_PositiveA.Checked, "A侧正面保存NG图片");
                ChangeFuncConfigLog(Global.isSaveNGImageWithRoi_PositiveA, chkIsSaveNGImageWithRoi_PositiveA.Checked, "A侧正面保存Ng图片（检测框）");
                ChangeFuncConfigLog(Global.isUsingCamera_PositiveA, chkIsUsingCamera_PositiveA.Checked, "A侧正面相机");
               
                #endregion
                #region A侧背面日志记录
                ChangeConfigLog(Global.topShieldLengthOfTopRegionNegativeA, txtTopShieldLengthOfTopRegion_NegativeA.Text, "A侧背面上半片上屏蔽高度");
                ChangeConfigLog(Global.bottomShieldLengthOfTopRegionNegativeA, txtBottomShieldLengthOfTopRegion_NegativeA.Text, "A侧背面上半片下屏蔽高度");
                ChangeConfigLog(Global.topShieldLengthOfBottomRegionNegativeA, txtTopShieldLengthOfBottomRegion_NegativeA.Text, "A侧背面下半片上屏蔽高度");
                ChangeConfigLog(Global.bottomShieldLengthOfBottomRegionNegativeA, txtBottomShieldLengthOfBottomRegion_NegativeA.Text, "A侧背面下半片下屏蔽高度");
                ChangeConfigLog(Global.locationMainLineThreshNegativeA, txtLocationMainLineThresh_NegativeA.Text, "A侧背面主删线定位阈值");
                ChangeConfigLog(Global.filmWidthThreshNegativeA, txtFilmWidthThresh_NegativeA.Text, "A侧背面贴膜宽度阈值");
                ChangeConfigLog(Global.filmWidthOffSetNegativeA, txtFilmWidthOffSet_NegativeA.Text, "A侧背面贴膜宽度补偿值");

                ChangeConfigLog(Global.weldWidthThreshNegativeA, txtWeldWidthThresh_NegativeA.Text, "A侧背面膜/焊带缺失阈值");

                ChangeConfigLog(Global.firstDetectPosForTopRegionNegativeA, txtFirstDetectPosForTopRegion_NegativeA.Text, "A侧背面上半片检测点1POS");
                ChangeConfigLog(Global.secondDetectPosForTopRegionNegativeA, txtSecondDetectPosForTopRegion_NegativeA.Text, "A侧背面上半片检测点2POS");
                ChangeConfigLog(Global.firstDetectPosForBottomRegionNegativeA, txtFirstDetectPosForBottomRegion_NegativeA.Text, "A侧背面下半片检测点1POS");
                ChangeConfigLog(Global.secondDetectPosForBottomRegionNegativeA, txtSecondDetectPosForBottomRegion_NegativeA.Text, "A侧背面下半片检测点2POS");

                ChangeConfigLog(Global.headAndTailFilmWidthThreshNegativeA, txtHeadAndTailFilmWidthThresh_NegativeA.Text, "A侧背面头尾贴膜检测宽度阈值");
                ChangeConfigLog(Global.headAndTailFilmShieldLengthNegativeA, txtHeadAndTailFilmShieldLength_NegativeA.Text, "A侧背面都为膜检缩进距离");
                ChangeConfigLog(Global.headAndTailFilmDetectRangeNegativeA, txtHeadAndTailFilmDetectRange_NegativeA.Text, "A侧背面头尾膜检范围");

                ChangeConfigLog(Global.waferWidthNegativeA, txtWaferWidth_NegativeA.Text, "A侧背面主删线宽度");
                ChangeConfigLog(Global.widthResolutionNegativeA, txtWidthResolution_NegativeA.Text, "A侧背面宽度分辨率");

                ChangeConfigLog(Global.viceLineInterval, txtViceLineInterval_NegativeA.Text, "A侧背面副栅线间距");
                ChangeConfigLog(Global.heightResolutionNegativeA, txtHeightResolution_NegativeA.Text, "A侧背面高度分辨率");

                ChangeConfigLog(Global.locationWaferEdgeThreshNegativeA, txtLocationWaferEdgeThresh_NegativeA.Text, "A侧背面边缘优化定位阈值");
                ChangeConfigLog(Global.waferEdgeCalibrationRegionDilationPixelNegativeA, txtWaferEdgeCalibrationRegionDilationPixel_NegativeA.Text, "A侧背面边缘膨胀像素（Pixel）");

                ChangeConfigLog(Global.minimumDistanceThreshNegativeA, txtMinimumDistanceThresh_NegativeA.Text, "A侧背面最小片间距阈值");
                ChangeConfigLog(Global.maxDistanceThreshNegativeA, txtMaxDistanceThresh_NegativeA.Text, "A侧背面最大片间距阈值");
                ChangeConfigLog(Global.classDistanceThreshNegativeA, txtClassDistanceThresh_NegativeA.Text, "A侧背面串间距阈值");

                ChangeConfigLog(Global.edgeBigDefectWidthThreshNegativeA, txtEdgeBigDefectWidthThresh_NegativeA.Text, "A侧背面大缺陷宽度阈值");
                ChangeConfigLog(Global.edgeBigDefectHeightThreshNegativeA, txtEdgeBigDefectHeightThresh_NegativeA.Text, "A侧背面大缺陷高度阈值");
                ChangeConfigLog(Global.edgeSmallDefectDetectDepthNegativeA, txtEdgeSmallDefectDetectDepth_NegativeA.Text, "A侧背面小缺陷检测深度");
                ChangeConfigLog(Global.edgeSmallDefectGrayThreshNegativeA, txtEdgeSmallDefectGrayThresh_NegativeA.Text, "A侧背面小缺陷背景灰度差阈值");
                ChangeConfigLog(Global.edgeSmallDefectWidthThreshNegativeA, txtEdgeSmallDefectWidthThresh_NegativeA.Text, "A侧背面小缺陷宽度阈值");
                ChangeConfigLog(Global.edgeSmallDefectHeightThreshNegativeA, txtEdgeSmallDefectHeightThresh_NegativeA.Text, "A侧背面小缺陷高度阈值");
                ChangeConfigLog(Global.edgeSmallDefectGrayMeanThreshNegativeA, txtEdgeSmallDefectGrayMeanThresh_NegativeA.Text, "A侧背面小缺陷灰度均值阈值");
                ChangeConfigLog(Global.edgeSmallDefectGrayDeviationThreshNegativeA, txtEdgeSmallDefectGrayDeviationThresh_NegativeA.Text, "A侧背面小缺陷灰度方差阈值");
                ChangeConfigLog(Global.cornerDefectAreaRatioThreshNegativeA, txtCornerDefectAreaRatioThresh_NegativeA.Text, "A侧背面角部缺陷面积比例阈值");

                ChangeConfigLog(Global.surfaceDefectGrayThreshNegativeA, txtSurfaceDefectGrayThresh_NegativeA.Text, "A侧背面缺陷背景灰度差阈值");
                ChangeConfigLog(Global.surfaceDefectWidthThreshNegativeA, txtSurfaceDefectWidthThresh_NegativeA.Text, "A侧背面缺陷宽度阈值");
                ChangeConfigLog(Global.surfaceDefectHeightThreshNegativeA, txtSurfaceDefectHeightThresh_NegativeA.Text, "A侧背面缺陷宽度阈值");
                ChangeConfigLog(Global.surfaceDefectDetectIndentDepthNegativeA, txtSurfaceDefectDetectIndentDepth_NegativeA.Text, "A侧背面检测缩进距离");
                ChangeConfigLog(Global.surfaceDefectViceLineShieldWidthNegativeA, txtSurfaceDefectViceLineShieldWidth_NegativeA.Text, "A侧背面纵向细栅区域宽度（Pixel）");
                ChangeConfigLog(Global.surfaceDefectViceLineShieldLeftPosOffSetNegativeA, txtSurfaceDefectViceLineShieldLeftPosOffSet_NegativeA.Text, "A侧背面纵向细栅左侧补偿（Pixel）");
                ChangeConfigLog(Global.surfaceDefectViceLineShieldRightPosOffSetNegativeA, txtSurfaceDefectViceLineShieldRightPosOffSet_NegativeA.Text, "A侧背面纵向细栅右侧补偿（Pixel）");
                ChangeConfigLog(Global.surfaceScratchGrayThreshNegativeA, txtSurfaceScratchGrayThresh_NegativeA.Text, "A侧背面划痕背景灰度差阈值");
                ChangeConfigLog(Global.surfaceScratchWidthThreshNegativeA, txtSurfaceScratchWidthThresh_NegativeA.Text, "A侧背面划痕宽度阈值");
                ChangeConfigLog(Global.surfaceScratchHeightThreshNegativeA, txtSurfaceScratchHeightThresh_NegativeA.Text, "A侧背面划痕高度阈值");

                ChangeConfigLog(Global.brokenLineGrayThreshNegativeA, txtBrokenLineGrayThresh_NegativeA.Text, "A侧背面断栅背景灰度差阈值");
                ChangeConfigLog(Global.brokenLineWidthThreshNegativeA, txtBrokenLineWidthThresh_NegativeA.Text, "A侧背面断栅宽度阈值");
                ChangeConfigLog(Global.brokenLineHeightThreshNegativeA, txtBrokenLineHeightThresh_NegativeA.Text, "A侧背面断栅高度阈值");
                ChangeConfigLog(Global.brokenLineDetectIndentDepthNegativeA, txtBrokenLineDetectIndentDepth_NegativeA.Text, "A侧背面检测缩进距离");

                ChangeConfigLog(Global.startWeldingDistanceMinThreshNegativeA, txtStartWeldingDistanceMinThresh_NegativeA.Text, "A侧背面最小起焊点阈值");
                ChangeConfigLog(Global.startWeldingDistanceMaxThreshNegativeA, txtStartWeldingDistanceMaxThresh_NegativeA.Text, "A侧背面最大起焊点阈值");

                ChangeConfigLog(Global.surfaceColorDiffGrayThreshNegativeA, txtSurfaceColorDiffGrayThresh_NegativeA.Text, "A侧背面色差灰度差阈值");


                ChangeFuncConfigLog(Global.isUsingFilmShiftingDetectNegativeA, chkIsUsingFilmShiftingDetect_NegativeA.Checked, "A侧背面露白/膜偏检测");
                ChangeFuncConfigLog(Global.isUsingFilmMissDetectNegativeA, chkIsUsingFilmMissDetect_NegativeA.Checked, "A侧背面膜短/膜失检测");
                ChangeFuncConfigLog(Global.isUsingHeadAndTailFilmShiftingDetectNegativeA, chkIsUsingFilmShiftingHeadAndTailDetect_NegativeA.Checked, "A侧背面头尾膜偏检测");
                ChangeFuncConfigLog(Global.isUsingWidthResolutionCalibrateNegativeA, chkIsUsingWidthResolutionCalibrate_NegativeA.Checked, "A侧背面宽度分辨率校准");
                ChangeFuncConfigLog(Global.isUsingHeightResolutionCalibrateNegativeA, chkIsUsingHeightResolutionCalibrate_NegativeA.Checked, "A侧背面高度分辨率校准");
                ChangeFuncConfigLog(Global.isUsingWaferEdgeCalibrationNegativeA, chkIsUsingWaferEdgeCalibration_NegativeA.Checked, "A侧背面边缘优化");
                ChangeFuncConfigLog(Global.isUsingDistanceDetectNegativeA, chkIsUsingDistanceDetect_NegativeA.Checked, "A侧背面片/串间距");
                ChangeFuncConfigLog(Global.isUsingStartWeldingDetectNegativeA, chkIsUsingStartWeldingDetect_NegativeA.Checked, "A侧背面起焊点");
                ChangeFuncConfigLog(Global.isUsingEdgeDefectDetectNegativeA, chkIsUsingEdgeDefectDetect_NegativeA.Checked, "A侧背面边/角缺陷检测");
                ChangeFuncConfigLog(Global.isUsingSurfaceDefectDetectNegativeA, chkIsUsingSurfaceDefectDetect_NegativeA.Checked, "A侧背面表面缺陷检测");
                ChangeFuncConfigLog(Global.isUsingBrokenLineDetectNegativeA, chkIsUsingBrokenLineDetect_NegativeA.Checked, "A侧背面断栅检测");
                ChangeFuncConfigLog(Global.isUsingSurfaceColorDiffDetectNegativeA, chkIsUsingSurfaceColorDiffDetect_NegativeA.Checked, "A侧背面色差检测");

                ChangeFuncConfigLog(Global.isSaveAllImage_NegativeA, chkIsSaveAllImage_NegativeA.Checked, "A侧背面保存全部图片");
                ChangeFuncConfigLog(Global.isSaveNGImage_NegativeA, chkIsSaveNGImage_NegativeA.Checked, "A侧背面保存NG图片");
                ChangeFuncConfigLog(Global.isSaveNGImageWithRoi_NegativeA, chkIsSaveNGImageWithRoi_NegativeA.Checked, "A侧背面保存Ng图片（检测框）");
                ChangeFuncConfigLog(Global.isUsingCamera_NegativeA, chkIsUsingCamera_NegativeA.Checked, "A侧背面相机");
                #endregion
                #region B侧正面日志记录
                ChangeConfigLog(Global.topShieldLengthOfTopRegionPositiveB, txtTopShieldLengthOfTopRegion_PositiveB.Text, "B侧正面上半片上屏蔽高度");
                ChangeConfigLog(Global.bottomShieldLengthOfTopRegionPositiveB, txtBottomShieldLengthOfTopRegion_PositiveB.Text, "B侧正面上半片下屏蔽高度");
                ChangeConfigLog(Global.topShieldLengthOfBottomRegionPositiveB, txtTopShieldLengthOfBottomRegion_PositiveB.Text, "B侧正面下半片上屏蔽高度");
                ChangeConfigLog(Global.bottomShieldLengthOfBottomRegionPositiveB, txtBottomShieldLengthOfBottomRegion_PositiveB.Text, "B侧正面下半片下屏蔽高度");
                ChangeConfigLog(Global.locationMainLineThreshPositiveB, txtLocationMainLineThresh_PositiveB.Text, "B侧正面主删线定位阈值");
                ChangeConfigLog(Global.filmWidthThreshPositiveB, txtFilmWidthThresh_PositiveB.Text, "B侧正面贴膜宽度阈值");
                ChangeConfigLog(Global.filmWidthOffSetPositiveB, txtFilmWidthOffSet_PositiveB.Text, "B侧正面贴膜宽度补偿值");

                ChangeConfigLog(Global.weldWidthThreshPositiveB, txtWeldWidthThresh_PositiveB.Text, "B侧正面膜/焊带缺失阈值");
                ChangeConfigLog(Global.weldShieldLengthPositiveB, txtWeldShieldLength_PositiveB.Text, "B侧正面膜/焊带缺失屏蔽阈值");


                ChangeConfigLog(Global.firstDetectPosForTopRegionPositiveB, txtFirstDetectPosForTopRegion_PositiveB.Text, "B侧正面上半片检测点1POS");
                ChangeConfigLog(Global.secondDetectPosForTopRegionPositiveB, txtSecondDetectPosForTopRegion_PositiveB.Text, "B侧正面上半片检测点2POS");
                ChangeConfigLog(Global.firstDetectPosForBottomRegionPositiveB, txtFirstDetectPosForBottomRegion_PositiveB.Text, "B侧正面下半片检测点1POS");
                ChangeConfigLog(Global.secondDetectPosForBottomRegionPositiveB, txtSecondDetectPosForBottomRegion_PositiveB.Text, "B侧正面下半片检测点2POS");

                ChangeConfigLog(Global.headAndTailFilmWidthThreshPositiveB, txtHeadAndTailFilmWidthThresh_PositiveB.Text, "B侧正面头尾贴膜检测宽度阈值");
                ChangeConfigLog(Global.headAndTailFilmShieldLengthPositiveB, txtHeadAndTailFilmShieldLength_PositiveB.Text, "B侧正面都为膜检缩进距离");
                ChangeConfigLog(Global.headAndTailFilmDetectRangePositiveB, txtHeadAndTailFilmDetectRange_PositiveB.Text, "B侧正面头尾膜检范围");

                ChangeConfigLog(Global.waferWidthPositiveB, txtWaferWidth_PositiveB.Text, "B侧正面主删线宽度");
                ChangeConfigLog(Global.widthResolutionPositiveB, txtWidthResolution_PositiveB.Text, "B侧正面宽度分辨率");

                ChangeConfigLog(Global.viceLineInterval, txtViceLineInterval_PositiveB.Text, "B侧正面副栅线间距");
                ChangeConfigLog(Global.heightResolutionPositiveB, txtHeightResolution_PositiveB.Text, "B侧正面高度分辨率");

                ChangeConfigLog(Global.locationWaferEdgeThreshPositiveB, txtLocationWaferEdgeThresh_PositiveB.Text, "B侧正面边缘优化定位阈值");
                ChangeConfigLog(Global.waferEdgeCalibrationRegionDilationPixelPositiveB, txtWaferEdgeCalibrationRegionDilationPixel_PositiveB.Text, "B侧正面边缘膨胀像素（Pixel）");

                ChangeConfigLog(Global.minimumDistanceThreshPositiveB, txtMinimumDistanceThresh_PositiveB.Text, "B侧正面最小片间距阈值");
                ChangeConfigLog(Global.maxDistanceThreshPositiveB, txtMaxDistanceThresh_PositiveB.Text, "B侧正面最大片间距阈值");
                ChangeConfigLog(Global.classDistanceThreshPositiveB, txtClassDistanceThresh_PositiveB.Text, "B侧正面串间距阈值");

                ChangeConfigLog(Global.edgeBigDefectWidthThreshPositiveB, txtEdgeBigDefectWidthThresh_PositiveB.Text, "B侧正面大缺陷宽度阈值");
                ChangeConfigLog(Global.edgeBigDefectHeightThreshPositiveB, txtEdgeBigDefectHeightThresh_PositiveB.Text, "B侧正面大缺陷高度阈值");
                ChangeConfigLog(Global.edgeSmallDefectDetectDepthPositiveB, txtEdgeSmallDefectDetectDepth_PositiveB.Text, "B侧正面小缺陷检测深度");
                ChangeConfigLog(Global.edgeSmallDefectGrayThreshPositiveB, txtEdgeSmallDefectGrayThresh_PositiveB.Text, "B侧正面小缺陷背景灰度差阈值");
                ChangeConfigLog(Global.edgeSmallDefectWidthThreshPositiveB, txtEdgeSmallDefectWidthThresh_PositiveB.Text, "B侧正面小缺陷宽度阈值");
                ChangeConfigLog(Global.edgeSmallDefectHeightThreshPositiveB, txtEdgeSmallDefectHeightThresh_PositiveB.Text, "B侧正面小缺陷高度阈值");
                ChangeConfigLog(Global.edgeSmallDefectGrayMeanThreshPositiveB, txtEdgeSmallDefectGrayMeanThresh_PositiveB.Text, "B侧正面小缺陷灰度均值阈值");
                ChangeConfigLog(Global.edgeSmallDefectGrayDeviationThreshPositiveB, txtEdgeSmallDefectGrayDeviationThresh_PositiveB.Text, "B侧正面小缺陷灰度方差阈值");
                ChangeConfigLog(Global.cornerDefectAreaRatioThreshPositiveB, txtCornerDefectAreaRatioThresh_PositiveB.Text, "B侧正面角部缺陷面积比例阈值");

                ChangeConfigLog(Global.surfaceDefectGrayThreshPositiveB, txtSurfaceDefectGrayThresh_PositiveB.Text, "B侧正面缺陷背景灰度差阈值");
                ChangeConfigLog(Global.surfaceDefectWidthThreshPositiveB, txtSurfaceDefectWidthThresh_PositiveB.Text, "B侧正面缺陷宽度阈值");
                ChangeConfigLog(Global.surfaceDefectHeightThreshPositiveB, txtSurfaceDefectHeightThresh_PositiveB.Text, "B侧正面缺陷宽度阈值");
                ChangeConfigLog(Global.surfaceDefectDetectIndentDepthPositiveB, txtSurfaceDefectDetectIndentDepth_PositiveB.Text, "B侧正面检测缩进距离");
                ChangeConfigLog(Global.surfaceDefectViceLineShieldWidthPositiveB, txtSurfaceDefectViceLineShieldWidth_PositiveB.Text, "B侧正面纵向细栅区域宽度（Pixel）");
                ChangeConfigLog(Global.surfaceDefectViceLineShieldLeftPosOffSetPositiveB, txtSurfaceDefectViceLineShieldLeftPosOffSet_PositiveB.Text, "B侧正面纵向细栅左侧补偿（Pixel）");
                ChangeConfigLog(Global.surfaceDefectViceLineShieldRightPosOffSetPositiveB, txtSurfaceDefectViceLineShieldRightPosOffSet_PositiveB.Text, "B侧正面纵向细栅右侧补偿（Pixel）");
                ChangeConfigLog(Global.surfaceScratchGrayThreshPositiveB, txtSurfaceScratchGrayThresh_PositiveB.Text, "B侧正面划痕背景灰度差阈值");
                ChangeConfigLog(Global.surfaceScratchWidthThreshPositiveB, txtSurfaceScratchWidthThresh_PositiveB.Text, "B侧正面划痕宽度阈值");
                ChangeConfigLog(Global.surfaceScratchHeightThreshPositiveB, txtSurfaceScratchHeightThresh_PositiveB.Text, "B侧正面划痕高度阈值");

                ChangeConfigLog(Global.brokenLineGrayThreshPositiveB, txtBrokenLineGrayThresh_PositiveB.Text, "B侧正面断栅背景灰度差阈值");
                ChangeConfigLog(Global.brokenLineWidthThreshPositiveB, txtBrokenLineWidthThresh_PositiveB.Text, "B侧正面断栅宽度阈值");
                ChangeConfigLog(Global.brokenLineHeightThreshPositiveB, txtBrokenLineHeightThresh_PositiveB.Text, "B侧正面断栅高度阈值");
                ChangeConfigLog(Global.brokenLineDetectIndentDepthPositiveB, txtBrokenLineDetectIndentDepth_PositiveB.Text, "B侧正面检测缩进距离");

                ChangeConfigLog(Global.startWeldingDistanceMinThreshPositiveB, txtStartWeldingDistanceMinThresh_PositiveB.Text, "B侧正面最小起焊点阈值");
                ChangeConfigLog(Global.startWeldingDistanceMaxThreshPositiveB, txtStartWeldingDistanceMaxThresh_PositiveB.Text, "B侧正面最大起焊点阈值");

                ChangeConfigLog(Global.surfaceColorDiffGrayThreshPositiveB, txtSurfaceColorDiffGrayThresh_PositiveB.Text, "B侧正面色差灰度差阈值");


                ChangeFuncConfigLog(Global.isUsingFilmShiftingDetectPositiveB, chkIsUsingFilmShiftingDetect_PositiveB.Checked, "B侧正面露白/膜偏检测");
                ChangeFuncConfigLog(Global.isUsingFilmMissDetectPositiveB, chkIsUsingFilmMissDetect_PositiveB.Checked, "B侧正面膜短/膜失检测");
                ChangeFuncConfigLog(Global.isUsingHeadAndTailFilmShiftingDetectPositiveB, chkIsUsingFilmShiftingHeadAndTailDetect_PositiveB.Checked, "B侧正面头尾膜偏检测");
                ChangeFuncConfigLog(Global.isUsingWidthResolutionCalibratePositiveB, chkIsUsingWidthResolutionCalibrate_PositiveB.Checked, "B侧正面宽度分辨率校准");
                ChangeFuncConfigLog(Global.isUsingHeightResolutionCalibratePositiveB, chkIsUsingHeightResolutionCalibrate_PositiveB.Checked, "B侧正面高度分辨率校准");
                ChangeFuncConfigLog(Global.isUsingWaferEdgeCalibrationPositiveB, chkIsUsingWaferEdgeCalibration_PositiveB.Checked, "B侧正面边缘优化");
                ChangeFuncConfigLog(Global.isUsingDistanceDetectPositiveB, chkIsUsingDistanceDetect_PositiveB.Checked, "B侧正面片/串间距");
                ChangeFuncConfigLog(Global.isUsingStartWeldingDetectPositiveB, chkIsUsingStartWeldingDetect_PositiveB.Checked, "B侧正面起焊点");
                ChangeFuncConfigLog(Global.isUsingEdgeDefectDetectPositiveB, chkIsUsingEdgeDefectDetect_PositiveB.Checked, "B侧正面边/角缺陷检测");
                ChangeFuncConfigLog(Global.isUsingSurfaceDefectDetectPositiveB, chkIsUsingSurfaceDefectDetect_PositiveB.Checked, "B侧正面表面缺陷检测");
                ChangeFuncConfigLog(Global.isUsingBrokenLineDetectPositiveB, chkIsUsingBrokenLineDetect_PositiveB.Checked, "B侧正面断栅检测");
                ChangeFuncConfigLog(Global.isUsingSurfaceColorDiffDetectPositiveB, chkIsUsingSurfaceColorDiffDetect_PositiveB.Checked, "B侧正面色差检测");

                ChangeFuncConfigLog(Global.isSaveAllImage_PositiveB, chkIsSaveAllImage_PositiveB.Checked, "B侧正面保存全部图片");
                ChangeFuncConfigLog(Global.isSaveNGImage_PositiveB, chkIsSaveNGImage_PositiveB.Checked, "B侧正面保存NG图片");
                ChangeFuncConfigLog(Global.isSaveNGImageWithRoi_PositiveB, chkIsSaveNGImageWithRoi_PositiveB.Checked, "B侧正面保存Ng图片（检测框）");
                ChangeFuncConfigLog(Global.isUsingCamera_PositiveB, chkIsUsingCamera_PositiveB.Checked, "B侧正面相机");

                #endregion
                #region B侧背面日志记录
                ChangeConfigLog(Global.topShieldLengthOfTopRegionNegativeB, txtTopShieldLengthOfTopRegion_NegativeB.Text, "B侧背面上半片上屏蔽高度");
                ChangeConfigLog(Global.bottomShieldLengthOfTopRegionNegativeB, txtBottomShieldLengthOfTopRegion_NegativeB.Text, "B侧背面上半片下屏蔽高度");
                ChangeConfigLog(Global.topShieldLengthOfBottomRegionNegativeB, txtTopShieldLengthOfBottomRegion_NegativeB.Text, "B侧背面下半片上屏蔽高度");
                ChangeConfigLog(Global.bottomShieldLengthOfBottomRegionNegativeB, txtBottomShieldLengthOfBottomRegion_NegativeB.Text, "B侧背面下半片下屏蔽高度");
                ChangeConfigLog(Global.locationMainLineThreshNegativeB, txtLocationMainLineThresh_NegativeB.Text, "B侧背面主删线定位阈值");
                ChangeConfigLog(Global.filmWidthThreshNegativeB, txtFilmWidthThresh_NegativeB.Text, "B侧背面贴膜宽度阈值");
                ChangeConfigLog(Global.filmWidthOffSetNegativeB, txtFilmWidthOffSet_NegativeB.Text, "B侧背面贴膜宽度补偿值");

                ChangeConfigLog(Global.weldWidthThreshNegativeB, txtWeldWidthThresh_NegativeB.Text, "B侧背面膜/焊带缺失阈值");

                ChangeConfigLog(Global.firstDetectPosForTopRegionNegativeB, txtFirstDetectPosForTopRegion_NegativeB.Text, "B侧背面上半片检测点1POS");
                ChangeConfigLog(Global.secondDetectPosForTopRegionNegativeB, txtSecondDetectPosForTopRegion_NegativeB.Text, "B侧背面上半片检测点2POS");
                ChangeConfigLog(Global.firstDetectPosForBottomRegionNegativeB, txtFirstDetectPosForBottomRegion_NegativeB.Text, "B侧背面下半片检测点1POS");
                ChangeConfigLog(Global.secondDetectPosForBottomRegionNegativeB, txtSecondDetectPosForBottomRegion_NegativeB.Text, "B侧背面下半片检测点2POS");

                ChangeConfigLog(Global.headAndTailFilmWidthThreshNegativeB, txtHeadAndTailFilmWidthThresh_NegativeB.Text, "B侧背面头尾贴膜检测宽度阈值");
                ChangeConfigLog(Global.headAndTailFilmShieldLengthNegativeB, txtHeadAndTailFilmShieldLength_NegativeB.Text, "B侧背面都为膜检缩进距离");
                ChangeConfigLog(Global.headAndTailFilmDetectRangeNegativeB, txtHeadAndTailFilmDetectRange_NegativeB.Text, "B侧背面头尾膜检范围");

                ChangeConfigLog(Global.waferWidthNegativeB, txtWaferWidth_NegativeB.Text, "B侧背面主删线宽度");
                ChangeConfigLog(Global.widthResolutionNegativeB, txtWidthResolution_NegativeB.Text, "B侧背面宽度分辨率");

                ChangeConfigLog(Global.viceLineInterval, txtViceLineInterval_NegativeB.Text, "B侧背面副栅线间距");
                ChangeConfigLog(Global.heightResolutionNegativeB, txtHeightResolution_NegativeB.Text, "B侧背面高度分辨率");

                ChangeConfigLog(Global.locationWaferEdgeThreshNegativeB, txtLocationWaferEdgeThresh_NegativeB.Text, "B侧背面边缘优化定位阈值");
                ChangeConfigLog(Global.waferEdgeCalibrationRegionDilationPixelNegativeB, txtWaferEdgeCalibrationRegionDilationPixel_NegativeB.Text, "B侧背面边缘膨胀像素（Pixel）");

                ChangeConfigLog(Global.minimumDistanceThreshNegativeB, txtMinimumDistanceThresh_NegativeB.Text, "B侧背面最小片间距阈值");
                ChangeConfigLog(Global.maxDistanceThreshNegativeB, txtMaxDistanceThresh_NegativeB.Text, "B侧背面最大片间距阈值");
                ChangeConfigLog(Global.classDistanceThreshNegativeB, txtClassDistanceThresh_NegativeB.Text, "B侧背面串间距阈值");

                ChangeConfigLog(Global.edgeBigDefectWidthThreshNegativeB, txtEdgeBigDefectWidthThresh_NegativeB.Text, "B侧背面大缺陷宽度阈值");
                ChangeConfigLog(Global.edgeBigDefectHeightThreshNegativeB, txtEdgeBigDefectHeightThresh_NegativeB.Text, "B侧背面大缺陷高度阈值");
                ChangeConfigLog(Global.edgeSmallDefectDetectDepthNegativeB, txtEdgeSmallDefectDetectDepth_NegativeB.Text, "B侧背面小缺陷检测深度");
                ChangeConfigLog(Global.edgeSmallDefectGrayThreshNegativeB, txtEdgeSmallDefectGrayThresh_NegativeB.Text, "B侧背面小缺陷背景灰度差阈值");
                ChangeConfigLog(Global.edgeSmallDefectWidthThreshNegativeB, txtEdgeSmallDefectWidthThresh_NegativeB.Text, "B侧背面小缺陷宽度阈值");
                ChangeConfigLog(Global.edgeSmallDefectHeightThreshNegativeB, txtEdgeSmallDefectHeightThresh_NegativeB.Text, "B侧背面小缺陷高度阈值");
                ChangeConfigLog(Global.edgeSmallDefectGrayMeanThreshNegativeB, txtEdgeSmallDefectGrayMeanThresh_NegativeB.Text, "B侧背面小缺陷灰度均值阈值");
                ChangeConfigLog(Global.edgeSmallDefectGrayDeviationThreshNegativeB, txtEdgeSmallDefectGrayDeviationThresh_NegativeB.Text, "B侧背面小缺陷灰度方差阈值");
                ChangeConfigLog(Global.cornerDefectAreaRatioThreshNegativeB, txtCornerDefectAreaRatioThresh_NegativeB.Text, "B侧背面角部缺陷面积比例阈值");

                ChangeConfigLog(Global.surfaceDefectGrayThreshNegativeB, txtSurfaceDefectGrayThresh_NegativeB.Text, "B侧背面缺陷背景灰度差阈值");
                ChangeConfigLog(Global.surfaceDefectWidthThreshNegativeB, txtSurfaceDefectWidthThresh_NegativeB.Text, "B侧背面缺陷宽度阈值");
                ChangeConfigLog(Global.surfaceDefectHeightThreshNegativeB, txtSurfaceDefectHeightThresh_NegativeB.Text, "B侧背面缺陷宽度阈值");
                ChangeConfigLog(Global.surfaceDefectDetectIndentDepthNegativeB, txtSurfaceDefectDetectIndentDepth_NegativeB.Text, "B侧背面检测缩进距离");
                ChangeConfigLog(Global.surfaceDefectViceLineShieldWidthNegativeB, txtSurfaceDefectViceLineShieldWidth_NegativeB.Text, "B侧背面纵向细栅区域宽度（Pixel）");
                ChangeConfigLog(Global.surfaceDefectViceLineShieldLeftPosOffSetNegativeB, txtSurfaceDefectViceLineShieldLeftPosOffSet_NegativeB.Text, "B侧背面纵向细栅左侧补偿（Pixel）");
                ChangeConfigLog(Global.surfaceDefectViceLineShieldRightPosOffSetNegativeB, txtSurfaceDefectViceLineShieldRightPosOffSet_NegativeB.Text, "B侧背面纵向细栅右侧补偿（Pixel）");
                ChangeConfigLog(Global.surfaceScratchGrayThreshNegativeB, txtSurfaceScratchGrayThresh_NegativeB.Text, "B侧背面划痕背景灰度差阈值");
                ChangeConfigLog(Global.surfaceScratchWidthThreshNegativeB, txtSurfaceScratchWidthThresh_NegativeB.Text, "B侧背面划痕宽度阈值");
                ChangeConfigLog(Global.surfaceScratchHeightThreshNegativeB, txtSurfaceScratchHeightThresh_NegativeB.Text, "B侧背面划痕高度阈值");

                ChangeConfigLog(Global.brokenLineGrayThreshNegativeB, txtBrokenLineGrayThresh_NegativeB.Text, "B侧背面断栅背景灰度差阈值");
                ChangeConfigLog(Global.brokenLineWidthThreshNegativeB, txtBrokenLineWidthThresh_NegativeB.Text, "B侧背面断栅宽度阈值");
                ChangeConfigLog(Global.brokenLineHeightThreshNegativeB, txtBrokenLineHeightThresh_NegativeB.Text, "B侧背面断栅高度阈值");
                ChangeConfigLog(Global.brokenLineDetectIndentDepthNegativeB, txtBrokenLineDetectIndentDepth_NegativeB.Text, "B侧背面检测缩进距离");

                ChangeConfigLog(Global.startWeldingDistanceMinThreshNegativeB, txtStartWeldingDistanceMinThresh_NegativeB.Text, "B侧背面最小起焊点阈值");
                ChangeConfigLog(Global.startWeldingDistanceMaxThreshNegativeB, txtStartWeldingDistanceMaxThresh_NegativeB.Text, "B侧背面最大起焊点阈值");

                ChangeConfigLog(Global.surfaceColorDiffGrayThreshNegativeB, txtSurfaceColorDiffGrayThresh_NegativeB.Text, "B侧背面色差灰度差阈值");


                ChangeFuncConfigLog(Global.isUsingFilmShiftingDetectNegativeB, chkIsUsingFilmShiftingDetect_NegativeB.Checked, "B侧背面露白/膜偏检测");
                ChangeFuncConfigLog(Global.isUsingFilmMissDetectNegativeB, chkIsUsingFilmMissDetect_NegativeB.Checked, "B侧背面膜短/膜失检测");
                ChangeFuncConfigLog(Global.isUsingHeadAndTailFilmShiftingDetectNegativeB, chkIsUsingFilmShiftingHeadAndTailDetect_NegativeB.Checked, "B侧背面头尾膜偏检测");
                ChangeFuncConfigLog(Global.isUsingWidthResolutionCalibrateNegativeB, chkIsUsingWidthResolutionCalibrate_NegativeB.Checked, "B侧背面宽度分辨率校准");
                ChangeFuncConfigLog(Global.isUsingHeightResolutionCalibrateNegativeB, chkIsUsingHeightResolutionCalibrate_NegativeB.Checked, "B侧背面高度分辨率校准");
                ChangeFuncConfigLog(Global.isUsingWaferEdgeCalibrationNegativeB, chkIsUsingWaferEdgeCalibration_NegativeB.Checked, "B侧背面边缘优化");
                ChangeFuncConfigLog(Global.isUsingDistanceDetectNegativeB, chkIsUsingDistanceDetect_NegativeB.Checked, "B侧背面片/串间距");
                ChangeFuncConfigLog(Global.isUsingStartWeldingDetectNegativeB, chkIsUsingStartWeldingDetect_NegativeB.Checked, "B侧背面起焊点");
                ChangeFuncConfigLog(Global.isUsingEdgeDefectDetectNegativeB, chkIsUsingEdgeDefectDetect_NegativeB.Checked, "B侧背面边/角缺陷检测");
                ChangeFuncConfigLog(Global.isUsingSurfaceDefectDetectNegativeB, chkIsUsingSurfaceDefectDetect_NegativeB.Checked, "B侧背面表面缺陷检测");
                ChangeFuncConfigLog(Global.isUsingBrokenLineDetectNegativeB, chkIsUsingBrokenLineDetect_NegativeB.Checked, "B侧背面断栅检测");
                ChangeFuncConfigLog(Global.isUsingSurfaceColorDiffDetectNegativeB, chkIsUsingSurfaceColorDiffDetect_NegativeB.Checked, "B侧背面色差检测");

                ChangeFuncConfigLog(Global.isSaveAllImage_NegativeB, chkIsSaveAllImage_NegativeB.Checked, "B侧背面保存全部图片");
                ChangeFuncConfigLog(Global.isSaveNGImage_NegativeB, chkIsSaveNGImage_NegativeB.Checked, "B侧背面保存NG图片");
                ChangeFuncConfigLog(Global.isSaveNGImageWithRoi_NegativeB, chkIsSaveNGImageWithRoi_NegativeB.Checked, "B侧背面保存Ng图片（检测框）");
                ChangeFuncConfigLog(Global.isUsingCamera_NegativeB, chkIsUsingCamera_NegativeB.Checked, "B侧背面相机");
                #endregion
                #region  公有检测配方初始化
                Global.waferCountPerClass = cbxWaferCountPerClass.Text;
                Global.mainLineDistance = txtMainLineDistance.Text;
                if (chkIsDalsaCam.Checked)
                {
                    Global.isDalsaCam = "1";
                }
                else
                {
                    Global.isDalsaCam = "0";
                }
                Global.mainLineNum = cbxMainLineNum.Text;
                if (chxIsFullWafer.Checked)
                {
                    Global.isFullWafer = "1";
                }
                else
                {
                    Global.isFullWafer = "0";
                }

                Global.subMainLineNum = cbxSubMainLineNum.Text;
                Global.stringType = cbxStringType.Text;
                if (Global.isEnglish == "0")
                {
                    Global.stringType = cbxStringType.Text;
                }
                else
                {
                    if (cbxStringType.Text == "Negative Gap")
                    {
                        Global.stringType = "负间距";
                    }
                    if (cbxStringType.Text == "Small Gap")
                    {
                        Global.stringType = "小间距";
                    }   
                    if (cbxStringType.Text == "Normal Gap")
                    {
                        Global.stringType = "常规间距";
                    }
                }
                mainForm.SetWindowHandlerSize();
                if (chxIsDoubleDetect.Checked)
                {
                    Global.isDoubleDetect = "1";
                }
                else
                {
                    Global.isDoubleDetect = "0";
                }
                if (chxIsMESFun.Checked)
                {
                    Global.isMESFun = "1";
                }
                else
                {
                    Global.isMESFun = "0";
                }
                if (chxIsUpperLink.Checked)
                {
                    Global.isUpperLink = "1";
                }
                else
                {
                    Global.isUpperLink = "0";
                }
                #endregion
                #region//A侧正面检测配方初始化
                if (chkIsUsingFilmShiftingDetect_PositiveA.Checked)
                {
                    Global.isUsingFilmShiftingDetectPositiveA = "1";
                }
                else
                {
                    Global.isUsingFilmShiftingDetectPositiveA = "0";
                }
                Global.topShieldLengthOfTopRegionPositiveA = txtTopShieldLengthOfTopRegion_PositiveA.Text;
                Global.bottomShieldLengthOfTopRegionPositiveA = txtBottomShieldLengthOfTopRegion_PositiveA.Text;
                Global.topShieldLengthOfBottomRegionPositiveA = txtTopShieldLengthOfBottomRegion_PositiveA.Text;
                Global.bottomShieldLengthOfBottomRegionPositiveA = txtBottomShieldLengthOfBottomRegion_PositiveA.Text;
                Global.locationMainLineThreshPositiveA = txtLocationMainLineThresh_PositiveA.Text;
                Global.filmWidthThreshPositiveA = txtFilmWidthThresh_PositiveA.Text;
                Global.filmWidthOffSetPositiveA = txtFilmWidthOffSet_PositiveA.Text;

                if (chkIsUsingFilmMissDetect_PositiveA.Checked)
                {
                    Global.isUsingFilmMissDetectPositiveA = "1";
                }
                else
                {
                    Global.isUsingFilmMissDetectPositiveA = "0";
                }
                Global.weldWidthThreshPositiveA = txtWeldWidthThresh_PositiveA.Text;
                Global.weldShieldLengthPositiveA = txtWeldShieldLength_PositiveA.Text;

                Global.firstDetectPosForTopRegionPositiveA = txtFirstDetectPosForTopRegion_PositiveA.Text;
                Global.secondDetectPosForTopRegionPositiveA = txtSecondDetectPosForTopRegion_PositiveA.Text;
                Global.firstDetectPosForBottomRegionPositiveA = txtFirstDetectPosForBottomRegion_PositiveA.Text;
                Global.secondDetectPosForBottomRegionPositiveA = txtSecondDetectPosForBottomRegion_PositiveA.Text;

                if (chkIsUsingFilmShiftingHeadAndTailDetect_PositiveA.Checked)
                {
                    Global.isUsingHeadAndTailFilmShiftingDetectPositiveA = "1";
                }
                else
                {
                    Global.isUsingHeadAndTailFilmShiftingDetectPositiveA = "0";
                }
                Global.headAndTailFilmWidthThreshPositiveA = txtHeadAndTailFilmWidthThresh_PositiveA.Text;
                Global.headAndTailFilmShieldLengthPositiveA = txtHeadAndTailFilmShieldLength_PositiveA.Text;
                Global.headAndTailFilmDetectRangePositiveA = txtHeadAndTailFilmDetectRange_PositiveA.Text;

                if (chkIsUsingWidthResolutionCalibrate_PositiveA.Checked)
                {
                    Global.isUsingWidthResolutionCalibratePositiveA = "1";
                }
                else
                {
                    Global.isUsingWidthResolutionCalibratePositiveA = "0";
                }
                Global.waferWidthPositiveA = txtWaferWidth_PositiveA.Text;
                Global.widthResolutionPositiveA = txtWidthResolution_PositiveA.Text;
                //txtWaferWidth_PositiveB.Text = txtWaferWidth_PositiveA.Text;
                //txtWaferWidth_NegativeA.Text = txtWaferWidth_PositiveA.Text;
                //txtWaferWidth_NegativeB.Text = txtWaferWidth_PositiveA.Text;

                if (chkIsUsingHeightResolutionCalibrate_PositiveA.Checked)
                {
                    Global.isUsingHeightResolutionCalibratePositiveA = "1";
                }
                else
                {
                    Global.isUsingHeightResolutionCalibratePositiveA = "0";
                }
                Global.viceLineInterval = txtViceLineInterval_PositiveA.Text;
                Global.heightResolutionPositiveA = txtHeightResolution_PositiveA.Text;

                if (chkIsUsingWaferEdgeCalibration_PositiveA.Checked)
                {
                    Global.isUsingWaferEdgeCalibrationPositiveA = "1";
                }
                else
                {
                    Global.isUsingWaferEdgeCalibrationPositiveA = "0";
                }
                Global.locationWaferEdgeThreshPositiveA = txtLocationWaferEdgeThresh_PositiveA.Text;
                Global.waferEdgeCalibrationRegionDilationPixelPositiveA = txtWaferEdgeCalibrationRegionDilationPixel_PositiveA.Text;

                if (chkIsUsingDistanceDetect_PositiveA.Checked)
                {
                    Global.isUsingDistanceDetectPositiveA = "1";
                }
                else
                {
                    Global.isUsingDistanceDetectPositiveA = "0";
                }
                Global.minimumDistanceThreshPositiveA = txtMinimumDistanceThresh_PositiveA.Text;
                Global.maxDistanceThreshPositiveA = txtMaxDistanceThresh_PositiveA.Text;
                Global.classDistanceThreshPositiveA = txtClassDistanceThresh_PositiveA.Text;

                if (chkIsUsingEdgeDefectDetect_PositiveA.Checked)
                {
                    Global.isUsingEdgeDefectDetectPositiveA = "1";
                }
                else
                {
                    Global.isUsingEdgeDefectDetectPositiveA = "0";
                }
                Global.edgeBigDefectWidthThreshPositiveA = txtEdgeBigDefectWidthThresh_PositiveA.Text;
                Global.edgeBigDefectHeightThreshPositiveA = txtEdgeBigDefectHeightThresh_PositiveA.Text;
                Global.edgeSmallDefectDetectDepthPositiveA = txtEdgeSmallDefectDetectDepth_PositiveA.Text;
                Global.edgeSmallDefectGrayThreshPositiveA = txtEdgeSmallDefectGrayThresh_PositiveA.Text;
                Global.edgeSmallDefectWidthThreshPositiveA = txtEdgeSmallDefectWidthThresh_PositiveA.Text;
                Global.edgeSmallDefectHeightThreshPositiveA = txtEdgeSmallDefectHeightThresh_PositiveA.Text;
                Global.edgeSmallDefectGrayMeanThreshPositiveA = txtEdgeSmallDefectGrayMeanThresh_PositiveA.Text;
                Global.edgeSmallDefectGrayDeviationThreshPositiveA = txtEdgeSmallDefectGrayDeviationThresh_PositiveA.Text;
                Global.cornerDefectAreaRatioThreshPositiveA = txtCornerDefectAreaRatioThresh_PositiveA.Text;

                if (chkIsUsingSurfaceDefectDetect_PositiveA.Checked)
                {
                    Global.isUsingSurfaceDefectDetectPositiveA = "1";
                }
                else
                {
                    Global.isUsingSurfaceDefectDetectPositiveA = "0";
                }
                Global.surfaceDefectGrayThreshPositiveA = txtSurfaceDefectGrayThresh_PositiveA.Text;
                Global.surfaceDefectWidthThreshPositiveA = txtSurfaceDefectWidthThresh_PositiveA.Text;
                Global.surfaceDefectHeightThreshPositiveA = txtSurfaceDefectHeightThresh_PositiveA.Text;
                Global.surfaceDefectDetectIndentDepthPositiveA = txtSurfaceDefectDetectIndentDepth_PositiveA.Text;
                Global.surfaceDefectViceLineShieldWidthPositiveA = txtSurfaceDefectViceLineShieldWidth_PositiveA.Text;
                Global.surfaceDefectViceLineShieldLeftPosOffSetPositiveA = txtSurfaceDefectViceLineShieldLeftPosOffSet_PositiveA.Text;
                Global.surfaceDefectViceLineShieldRightPosOffSetPositiveA = txtSurfaceDefectViceLineShieldRightPosOffSet_PositiveA.Text;
                if (Convert.ToInt32(txtSurfaceScratchGrayThresh_PositiveA.Text) < 128)
                {
                    Global.surfaceScratchGrayThreshPositiveA = txtSurfaceScratchGrayThresh_PositiveA.Text;
                }
                else
                {
                    txtSurfaceScratchGrayThresh_PositiveA.Text = "127";
                    Global.surfaceScratchGrayThreshPositiveA = txtSurfaceScratchGrayThresh_PositiveA.Text;
                }
               
                Global.surfaceScratchWidthThreshPositiveA = txtSurfaceScratchWidthThresh_PositiveA.Text;
                Global.surfaceScratchHeightThreshPositiveA = txtSurfaceScratchHeightThresh_PositiveA.Text;

                if (chkIsUsingBrokenLineDetect_PositiveA.Checked)
                {
                    Global.isUsingBrokenLineDetectPositiveA = "1";
                }
                else
                {
                    Global.isUsingBrokenLineDetectPositiveA = "0";
                }
                Global.brokenLineGrayThreshPositiveA = txtBrokenLineGrayThresh_PositiveA.Text;
                Global.brokenLineWidthThreshPositiveA = txtBrokenLineWidthThresh_PositiveA.Text;
                Global.brokenLineHeightThreshPositiveA = txtBrokenLineHeightThresh_PositiveA.Text;
                Global.brokenLineDetectIndentDepthPositiveA = txtBrokenLineDetectIndentDepth_PositiveA.Text;
                if (chkIsUsingStartWeldingDetect_PositiveA.Checked)
                {
                    Global.isUsingStartWeldingDetectPositiveA = "1";
                }
                else
                {
                    Global.isUsingStartWeldingDetectPositiveA = "0";
                }
                Global.startWeldingDistanceMinThreshPositiveA = txtStartWeldingDistanceMinThresh_PositiveA.Text;
                Global.startWeldingDistanceMaxThreshPositiveA = txtStartWeldingDistanceMaxThresh_PositiveA.Text;
                if (chkIsUsingSurfaceColorDiffDetect_PositiveA.Checked)
                {
                    Global.isUsingSurfaceColorDiffDetectPositiveA = "1";
                }
                else
                {
                    Global.isUsingSurfaceColorDiffDetectPositiveA = "0";
                }
                Global.surfaceColorDiffGrayThreshPositiveA = txtSurfaceColorDiffGrayThresh_PositiveA.Text;
                if (chkIsUsingAlarmFunction_PositiveA.Checked)
                {
                    Global.isUsingAlarmFunction_PositiveA = "1";
                }
                else
                {
                    Global.isUsingAlarmFunction_PositiveA = "0";
                }
                Global.maxAlamClusterCount_PositiveA = txtMaxAlamClusterCount_PositiveA.Text;

                if (chkIsSaveAllImage_PositiveA.Checked)
                {
                    Global.isSaveAllImage_PositiveA = "1";
                }
                else
                {
                    Global.isSaveAllImage_PositiveA = "0";
                }
                if (chkIsSaveNGImage_PositiveA.Checked)
                {
                    Global.isSaveNGImage_PositiveA = "1";
                }
                else
                {
                    Global.isSaveNGImage_PositiveA = "0";
                }
                if (chkIsSaveNGImageWithRoi_PositiveA.Checked)
                {
                    Global.isSaveNGImageWithRoi_PositiveA = "1";
                }
                else
                {
                    Global.isSaveNGImageWithRoi_PositiveA = "0";
                }
                if (chkIsUsingCamera_PositiveA.Checked)
                {
                    Global.isUsingCamera_PositiveA = "1";
                }
                else
                {
                    Global.isUsingCamera_PositiveA = "0";
                }
                #endregion

                #region//B侧正面检测配方初始化
                if (chkIsUsingFilmShiftingDetect_PositiveB.Checked)
                {
                    Global.isUsingFilmShiftingDetectPositiveB = "1";
                }
                else
                {
                    Global.isUsingFilmShiftingDetectPositiveB = "0";
                }
                Global.topShieldLengthOfTopRegionPositiveB = txtTopShieldLengthOfTopRegion_PositiveB.Text;
                Global.bottomShieldLengthOfTopRegionPositiveB = txtBottomShieldLengthOfTopRegion_PositiveB.Text;
                Global.topShieldLengthOfBottomRegionPositiveB = txtTopShieldLengthOfBottomRegion_PositiveB.Text;
                Global.bottomShieldLengthOfBottomRegionPositiveB = txtBottomShieldLengthOfBottomRegion_PositiveB.Text;
                Global.locationMainLineThreshPositiveB = txtLocationMainLineThresh_PositiveB.Text;
                Global.filmWidthThreshPositiveB = txtFilmWidthThresh_PositiveB.Text;
                Global.filmWidthOffSetPositiveB = txtFilmWidthOffSet_PositiveB.Text;

                if (chkIsUsingFilmMissDetect_PositiveB.Checked)
                {
                    Global.isUsingFilmMissDetectPositiveB = "1";
                }
                else
                {
                    Global.isUsingFilmMissDetectPositiveB = "0";
                }
                Global.weldWidthThreshPositiveB = txtWeldWidthThresh_PositiveB.Text;
                Global.weldShieldLengthPositiveB = txtWeldShieldLength_PositiveB.Text;

                Global.firstDetectPosForTopRegionPositiveB = txtFirstDetectPosForTopRegion_PositiveB.Text;
                Global.secondDetectPosForTopRegionPositiveB = txtSecondDetectPosForTopRegion_PositiveB.Text;
                Global.firstDetectPosForBottomRegionPositiveB = txtFirstDetectPosForBottomRegion_PositiveB.Text;
                Global.secondDetectPosForBottomRegionPositiveB = txtSecondDetectPosForBottomRegion_PositiveB.Text;

                if (chkIsUsingFilmShiftingHeadAndTailDetect_PositiveB.Checked)
                {
                    Global.isUsingHeadAndTailFilmShiftingDetectPositiveB = "1";
                }
                else
                {
                    Global.isUsingHeadAndTailFilmShiftingDetectPositiveB = "0";
                }
                Global.headAndTailFilmWidthThreshPositiveB = txtHeadAndTailFilmWidthThresh_PositiveB.Text;
                Global.headAndTailFilmShieldLengthPositiveB = txtHeadAndTailFilmShieldLength_PositiveB.Text;
                Global.headAndTailFilmDetectRangePositiveB = txtHeadAndTailFilmDetectRange_PositiveB.Text;

                if (chkIsUsingWidthResolutionCalibrate_PositiveB.Checked)
                {
                    Global.isUsingWidthResolutionCalibratePositiveB = "1";
                }
                else
                {
                    Global.isUsingWidthResolutionCalibratePositiveB = "0";
                }
                Global.waferWidthPositiveB = txtWaferWidth_PositiveB.Text;
                Global.widthResolutionPositiveB = txtWidthResolution_PositiveB.Text;

                //txtWaferWidth_PositiveA.Text = txtWaferWidth_PositiveB.Text;
                //txtWaferWidth_NegativeA.Text = txtWaferWidth_PositiveB.Text;
                //txtWaferWidth_NegativeB.Text = txtWaferWidth_PositiveB.Text;

                if (chkIsUsingHeightResolutionCalibrate_PositiveB.Checked)
                {
                    Global.isUsingHeightResolutionCalibratePositiveB = "1";
                }
                else
                {
                    Global.isUsingHeightResolutionCalibratePositiveB = "0";
                }
                Global.viceLineInterval = txtViceLineInterval_PositiveB.Text;
                Global.heightResolutionPositiveB = txtHeightResolution_PositiveB.Text;

                if (chkIsUsingWaferEdgeCalibration_PositiveB.Checked)
                {
                    Global.isUsingWaferEdgeCalibrationPositiveB = "1";
                }
                else
                {
                    Global.isUsingWaferEdgeCalibrationPositiveB = "0";
                }
                Global.locationWaferEdgeThreshPositiveB = txtLocationWaferEdgeThresh_PositiveB.Text;
                Global.waferEdgeCalibrationRegionDilationPixelPositiveB = txtWaferEdgeCalibrationRegionDilationPixel_PositiveB.Text;

                if (chkIsUsingDistanceDetect_PositiveB.Checked)
                {
                    Global.isUsingDistanceDetectPositiveB = "1";
                }
                else
                {
                    Global.isUsingDistanceDetectPositiveB = "0";
                }
                Global.minimumDistanceThreshPositiveB = txtMinimumDistanceThresh_PositiveB.Text;
                Global.maxDistanceThreshPositiveB = txtMaxDistanceThresh_PositiveB.Text;
                Global.classDistanceThreshPositiveB = txtClassDistanceThresh_PositiveB.Text;

                if (chkIsUsingEdgeDefectDetect_PositiveB.Checked)
                {
                    Global.isUsingEdgeDefectDetectPositiveB = "1";
                }
                else
                {
                    Global.isUsingEdgeDefectDetectPositiveB = "0";
                }
                Global.edgeBigDefectWidthThreshPositiveB = txtEdgeBigDefectWidthThresh_PositiveB.Text;
                Global.edgeBigDefectHeightThreshPositiveB = txtEdgeBigDefectHeightThresh_PositiveB.Text;
                Global.edgeSmallDefectDetectDepthPositiveB = txtEdgeSmallDefectDetectDepth_PositiveB.Text;
                Global.edgeSmallDefectGrayThreshPositiveB = txtEdgeSmallDefectGrayThresh_PositiveB.Text;
                Global.edgeSmallDefectWidthThreshPositiveB = txtEdgeSmallDefectWidthThresh_PositiveB.Text;
                Global.edgeSmallDefectHeightThreshPositiveB = txtEdgeSmallDefectHeightThresh_PositiveB.Text;
                Global.edgeSmallDefectGrayMeanThreshPositiveB = txtEdgeSmallDefectGrayMeanThresh_PositiveB.Text;
                Global.edgeSmallDefectGrayDeviationThreshPositiveB = txtEdgeSmallDefectGrayDeviationThresh_PositiveB.Text;
                Global.cornerDefectAreaRatioThreshPositiveB = txtCornerDefectAreaRatioThresh_PositiveB.Text;

                if (chkIsUsingSurfaceDefectDetect_PositiveB.Checked)
                {
                    Global.isUsingSurfaceDefectDetectPositiveB = "1";
                }
                else
                {
                    Global.isUsingSurfaceDefectDetectPositiveB = "0";
                }
                Global.surfaceDefectGrayThreshPositiveB = txtSurfaceDefectGrayThresh_PositiveB.Text;
                Global.surfaceDefectWidthThreshPositiveB = txtSurfaceDefectWidthThresh_PositiveB.Text;
                Global.surfaceDefectHeightThreshPositiveB = txtSurfaceDefectHeightThresh_PositiveB.Text;
                Global.surfaceDefectDetectIndentDepthPositiveB = txtSurfaceDefectDetectIndentDepth_PositiveB.Text;
                Global.surfaceDefectViceLineShieldWidthPositiveB = txtSurfaceDefectViceLineShieldWidth_PositiveB.Text;
                Global.surfaceDefectViceLineShieldLeftPosOffSetPositiveB = txtSurfaceDefectViceLineShieldLeftPosOffSet_PositiveB.Text;
                Global.surfaceDefectViceLineShieldRightPosOffSetPositiveB = txtSurfaceDefectViceLineShieldRightPosOffSet_PositiveB.Text;
                Global.surfaceScratchGrayThreshPositiveB = txtSurfaceScratchGrayThresh_PositiveB.Text;
                Global.surfaceScratchWidthThreshPositiveB = txtSurfaceScratchWidthThresh_PositiveB.Text;
                Global.surfaceScratchHeightThreshPositiveB = txtSurfaceScratchHeightThresh_PositiveB.Text;

                if (chkIsUsingBrokenLineDetect_PositiveB.Checked)
                {
                    Global.isUsingBrokenLineDetectPositiveB = "1";
                }
                else
                {
                    Global.isUsingBrokenLineDetectPositiveB = "0";
                }
                Global.brokenLineGrayThreshPositiveB = txtBrokenLineGrayThresh_PositiveB.Text;
                Global.brokenLineWidthThreshPositiveB = txtBrokenLineWidthThresh_PositiveB.Text;
                Global.brokenLineHeightThreshPositiveB = txtBrokenLineHeightThresh_PositiveB.Text;
                Global.brokenLineDetectIndentDepthPositiveB = txtBrokenLineDetectIndentDepth_PositiveB.Text;
                if (chkIsUsingStartWeldingDetect_PositiveB.Checked)
                {
                    Global.isUsingStartWeldingDetectPositiveB = "1";
                }
                else
                {
                    Global.isUsingStartWeldingDetectPositiveB = "0";
                }
                Global.startWeldingDistanceMinThreshPositiveB = txtStartWeldingDistanceMinThresh_PositiveB.Text;
                Global.startWeldingDistanceMaxThreshPositiveB = txtStartWeldingDistanceMaxThresh_PositiveB.Text;
                if (chkIsUsingSurfaceColorDiffDetect_PositiveB.Checked)
                {
                    Global.isUsingSurfaceColorDiffDetectPositiveB = "1";
                }
                else
                {
                    Global.isUsingSurfaceColorDiffDetectPositiveB = "0";
                }
                Global.surfaceColorDiffGrayThreshPositiveB = txtSurfaceColorDiffGrayThresh_PositiveB.Text;
                if (chkIsUsingAlarmFunction_PositiveB.Checked)
                {
                    Global.isUsingAlarmFunction_PositiveB = "1";
                }
                else
                {
                    Global.isUsingAlarmFunction_PositiveB = "0";
                }
                Global.maxAlamClusterCount_PositiveB = txtMaxAlamClusterCount_PositiveB.Text;

                if (chkIsSaveAllImage_PositiveB.Checked)
                {
                    Global.isSaveAllImage_PositiveB = "1";
                }
                else
                {
                    Global.isSaveAllImage_PositiveB = "0";
                }
                if (chkIsSaveNGImage_PositiveB.Checked)
                {
                    Global.isSaveNGImage_PositiveB = "1";
                }
                else
                {
                    Global.isSaveNGImage_PositiveB = "0";
                }
                if (chkIsSaveNGImageWithRoi_PositiveB.Checked)
                {
                    Global.isSaveNGImageWithRoi_PositiveB = "1";
                }
                else
                {
                    Global.isSaveNGImageWithRoi_PositiveB = "0";
                }
                if (chkIsUsingCamera_PositiveB.Checked)
                {
                    Global.isUsingCamera_PositiveB = "1";
                }
                else
                {
                    Global.isUsingCamera_PositiveB = "0";
                }
                #endregion

                #region//A侧背面检测配方初始化
                if (chkIsUsingFilmShiftingDetect_NegativeA.Checked)
                {
                    Global.isUsingFilmShiftingDetectNegativeA = "1";
                }
                else
                {
                    Global.isUsingFilmShiftingDetectNegativeA = "0";
                }
                Global.topShieldLengthOfTopRegionNegativeA = txtTopShieldLengthOfTopRegion_NegativeA.Text;
                Global.bottomShieldLengthOfTopRegionNegativeA = txtBottomShieldLengthOfTopRegion_NegativeA.Text;
                Global.topShieldLengthOfBottomRegionNegativeA = txtTopShieldLengthOfBottomRegion_NegativeA.Text;
                Global.bottomShieldLengthOfBottomRegionNegativeA = txtBottomShieldLengthOfBottomRegion_NegativeA.Text;
                Global.locationMainLineThreshNegativeA = txtLocationMainLineThresh_NegativeA.Text;
                Global.filmWidthThreshNegativeA = txtFilmWidthThresh_NegativeA.Text;
                Global.filmWidthOffSetNegativeA = txtFilmWidthOffSet_NegativeA.Text;

                if (chkIsUsingFilmMissDetect_NegativeA.Checked)
                {
                    Global.isUsingFilmMissDetectNegativeA = "1";
                }
                else
                {
                    Global.isUsingFilmMissDetectNegativeA = "0";
                }
                Global.weldWidthThreshNegativeA = txtWeldWidthThresh_NegativeA.Text;

                Global.firstDetectPosForTopRegionNegativeA = txtFirstDetectPosForTopRegion_NegativeA.Text;
                Global.secondDetectPosForTopRegionNegativeA = txtSecondDetectPosForTopRegion_NegativeA.Text;
                Global.firstDetectPosForBottomRegionNegativeA = txtFirstDetectPosForBottomRegion_NegativeA.Text;
                Global.secondDetectPosForBottomRegionNegativeA = txtSecondDetectPosForBottomRegion_NegativeA.Text;

                if (chkIsUsingFilmShiftingHeadAndTailDetect_NegativeA.Checked)
                {
                    Global.isUsingHeadAndTailFilmShiftingDetectNegativeA = "1";
                }
                else
                {
                    Global.isUsingHeadAndTailFilmShiftingDetectNegativeA = "0";
                }
                Global.headAndTailFilmWidthThreshNegativeA = txtHeadAndTailFilmWidthThresh_NegativeA.Text;
                Global.headAndTailFilmShieldLengthNegativeA = txtHeadAndTailFilmShieldLength_NegativeA.Text;
                Global.headAndTailFilmDetectRangeNegativeA = txtHeadAndTailFilmDetectRange_NegativeA.Text;

                if (chkIsUsingWidthResolutionCalibrate_NegativeA.Checked)
                {
                    Global.isUsingWidthResolutionCalibrateNegativeA = "1";
                }
                else
                {
                    Global.isUsingWidthResolutionCalibrateNegativeA = "0";
                }
                Global.waferWidthNegativeA = txtWaferWidth_NegativeA.Text;
                Global.widthResolutionNegativeA = txtWidthResolution_NegativeA.Text;
                //txtWaferWidth_PositiveB.Text = txtWaferWidth_NegativeA.Text;
                //txtWaferWidth_PositiveA.Text = txtWaferWidth_NegativeA.Text;
                //txtWaferWidth_NegativeB.Text = txtWaferWidth_NegativeA.Text;

                if (chkIsUsingHeightResolutionCalibrate_NegativeA.Checked)
                {
                    Global.isUsingHeightResolutionCalibrateNegativeA = "1";
                }
                else
                {
                    Global.isUsingHeightResolutionCalibrateNegativeA = "0";
                }
                Global.viceLineInterval = txtViceLineInterval_NegativeA.Text;
                Global.heightResolutionNegativeA = txtHeightResolution_NegativeA.Text;

                if (chkIsUsingWaferEdgeCalibration_NegativeA.Checked)
                {
                    Global.isUsingWaferEdgeCalibrationNegativeA = "1";
                }
                else
                {
                    Global.isUsingWaferEdgeCalibrationNegativeA = "0";
                }
                Global.locationWaferEdgeThreshNegativeA = txtLocationWaferEdgeThresh_NegativeA.Text;
                Global.waferEdgeCalibrationRegionDilationPixelNegativeA = txtWaferEdgeCalibrationRegionDilationPixel_NegativeA.Text;

                if (chkIsUsingDistanceDetect_NegativeA.Checked)
                {
                    Global.isUsingDistanceDetectNegativeA = "1";
                }
                else
                {
                    Global.isUsingDistanceDetectNegativeA = "0";
                }
                Global.minimumDistanceThreshNegativeA = txtMinimumDistanceThresh_NegativeA.Text;
                Global.maxDistanceThreshNegativeA = txtMaxDistanceThresh_NegativeA.Text;
                Global.classDistanceThreshNegativeA = txtClassDistanceThresh_NegativeA.Text;

                if (chkIsUsingEdgeDefectDetect_NegativeA.Checked)
                {
                    Global.isUsingEdgeDefectDetectNegativeA = "1";
                }
                else
                {
                    Global.isUsingEdgeDefectDetectNegativeA = "0";
                }
                Global.edgeBigDefectWidthThreshNegativeA = txtEdgeBigDefectWidthThresh_NegativeA.Text;
                Global.edgeBigDefectHeightThreshNegativeA = txtEdgeBigDefectHeightThresh_NegativeA.Text;
                Global.edgeSmallDefectDetectDepthNegativeA = txtEdgeSmallDefectDetectDepth_NegativeA.Text;
                Global.edgeSmallDefectGrayThreshNegativeA = txtEdgeSmallDefectGrayThresh_NegativeA.Text;
                Global.edgeSmallDefectWidthThreshNegativeA = txtEdgeSmallDefectWidthThresh_NegativeA.Text;
                Global.edgeSmallDefectHeightThreshNegativeA = txtEdgeSmallDefectHeightThresh_NegativeA.Text;
                Global.edgeSmallDefectGrayMeanThreshNegativeA = txtEdgeSmallDefectGrayMeanThresh_NegativeA.Text;
                Global.edgeSmallDefectGrayDeviationThreshNegativeA = txtEdgeSmallDefectGrayDeviationThresh_NegativeA.Text;
                Global.cornerDefectAreaRatioThreshNegativeA = txtCornerDefectAreaRatioThresh_NegativeA.Text;

                if (chkIsUsingSurfaceDefectDetect_NegativeA.Checked)
                {
                    Global.isUsingSurfaceDefectDetectNegativeA = "1";
                }
                else
                {
                    Global.isUsingSurfaceDefectDetectNegativeA = "0";
                }
                Global.surfaceDefectGrayThreshNegativeA = txtSurfaceDefectGrayThresh_NegativeA.Text;
                Global.surfaceDefectWidthThreshNegativeA = txtSurfaceDefectWidthThresh_NegativeA.Text;
                Global.surfaceDefectHeightThreshNegativeA = txtSurfaceDefectHeightThresh_NegativeA.Text;
                Global.surfaceDefectDetectIndentDepthNegativeA = txtSurfaceDefectDetectIndentDepth_NegativeA.Text;
                Global.surfaceDefectViceLineShieldWidthNegativeA = txtSurfaceDefectViceLineShieldWidth_NegativeA.Text;
                Global.surfaceDefectViceLineShieldLeftPosOffSetNegativeA = txtSurfaceDefectViceLineShieldLeftPosOffSet_NegativeA.Text;
                Global.surfaceDefectViceLineShieldRightPosOffSetNegativeA = txtSurfaceDefectViceLineShieldRightPosOffSet_NegativeA.Text;
                Global.surfaceScratchGrayThreshNegativeA = txtSurfaceScratchGrayThresh_NegativeA.Text;
                Global.surfaceScratchWidthThreshNegativeA = txtSurfaceScratchWidthThresh_NegativeA.Text;
                Global.surfaceScratchHeightThreshNegativeA = txtSurfaceScratchHeightThresh_NegativeA.Text;

                if (chkIsUsingBrokenLineDetect_NegativeA.Checked)
                {
                    Global.isUsingBrokenLineDetectNegativeA = "1";
                }
                else
                {
                    Global.isUsingBrokenLineDetectNegativeA = "0";
                }
                Global.brokenLineGrayThreshNegativeA = txtBrokenLineGrayThresh_NegativeA.Text;
                Global.brokenLineWidthThreshNegativeA = txtBrokenLineWidthThresh_NegativeA.Text;
                Global.brokenLineHeightThreshNegativeA = txtBrokenLineHeightThresh_NegativeA.Text;
                Global.brokenLineDetectIndentDepthNegativeA = txtBrokenLineDetectIndentDepth_NegativeA.Text;
                if (chkIsUsingStartWeldingDetect_NegativeA.Checked)
                {
                    Global.isUsingStartWeldingDetectNegativeA = "1";
                }
                else
                {
                    Global.isUsingStartWeldingDetectNegativeA = "0";
                }
                Global.startWeldingDistanceMinThreshNegativeA = txtStartWeldingDistanceMinThresh_NegativeA.Text;
                Global.startWeldingDistanceMaxThreshNegativeA = txtStartWeldingDistanceMaxThresh_NegativeA.Text;
                if (chkIsUsingSurfaceColorDiffDetect_NegativeA.Checked)
                {
                    Global.isUsingSurfaceColorDiffDetectNegativeA = "1";
                }
                else
                {
                    Global.isUsingSurfaceColorDiffDetectNegativeA = "0";
                }
                Global.surfaceColorDiffGrayThreshNegativeA = txtSurfaceColorDiffGrayThresh_NegativeA.Text;
                if (chkIsUsingAlarmFunction_NegativeA.Checked)
                {
                    Global.isUsingAlarmFunction_NegativeA = "1";
                }
                else
                {
                    Global.isUsingAlarmFunction_NegativeA = "0";
                }
                Global.maxAlamClusterCount_NegativeA = txtMaxAlamClusterCount_NegativeA.Text;

                if (chkIsSaveAllImage_NegativeA.Checked)
                {
                    Global.isSaveAllImage_NegativeA = "1";
                }
                else
                {
                    Global.isSaveAllImage_NegativeA = "0";
                }
                if (chkIsSaveNGImage_NegativeA.Checked)
                {
                    Global.isSaveNGImage_NegativeA = "1";
                }
                else
                {
                    Global.isSaveNGImage_NegativeA = "0";
                }
                if (chkIsSaveNGImageWithRoi_NegativeA.Checked)
                {
                    Global.isSaveNGImageWithRoi_NegativeA = "1";
                }
                else
                {
                    Global.isSaveNGImageWithRoi_NegativeA = "0";
                }
                if (chkIsUsingCamera_NegativeA.Checked)
                {
                    Global.isUsingCamera_NegativeA = "1";
                }
                else
                {
                    Global.isUsingCamera_NegativeA = "0";
                }
                #endregion

                #region//B侧背面检测配方初始化
                if (chkIsUsingFilmShiftingDetect_NegativeB.Checked)
                {
                    Global.isUsingFilmShiftingDetectNegativeB = "1";
                }
                else
                {
                    Global.isUsingFilmShiftingDetectNegativeB = "0";
                }
                Global.topShieldLengthOfTopRegionNegativeB = txtTopShieldLengthOfTopRegion_NegativeB.Text;
                Global.bottomShieldLengthOfTopRegionNegativeB = txtBottomShieldLengthOfTopRegion_NegativeB.Text;
                Global.topShieldLengthOfBottomRegionNegativeB = txtTopShieldLengthOfBottomRegion_NegativeB.Text;
                Global.bottomShieldLengthOfBottomRegionNegativeB = txtBottomShieldLengthOfBottomRegion_NegativeB.Text;
                Global.locationMainLineThreshNegativeB = txtLocationMainLineThresh_NegativeB.Text;
                Global.filmWidthThreshNegativeB = txtFilmWidthThresh_NegativeB.Text;
                Global.filmWidthOffSetNegativeB = txtFilmWidthOffSet_NegativeB.Text;

                if (chkIsUsingFilmMissDetect_NegativeB.Checked)
                {
                    Global.isUsingFilmMissDetectNegativeB = "1";
                }
                else
                {
                    Global.isUsingFilmMissDetectNegativeB = "0";
                }
                Global.weldWidthThreshNegativeB = txtWeldWidthThresh_NegativeB.Text;

                Global.firstDetectPosForTopRegionNegativeB = txtFirstDetectPosForTopRegion_NegativeB.Text;
                Global.secondDetectPosForTopRegionNegativeB = txtSecondDetectPosForTopRegion_NegativeB.Text;
                Global.firstDetectPosForBottomRegionNegativeB = txtFirstDetectPosForBottomRegion_NegativeB.Text;
                Global.secondDetectPosForBottomRegionNegativeB = txtSecondDetectPosForBottomRegion_NegativeB.Text;

                if (chkIsUsingFilmShiftingHeadAndTailDetect_NegativeB.Checked)
                {
                    Global.isUsingHeadAndTailFilmShiftingDetectNegativeB = "1";
                }
                else
                {
                    Global.isUsingHeadAndTailFilmShiftingDetectNegativeB = "0";
                }
                Global.headAndTailFilmWidthThreshNegativeB = txtHeadAndTailFilmWidthThresh_NegativeB.Text;
                Global.headAndTailFilmShieldLengthNegativeB = txtHeadAndTailFilmShieldLength_NegativeB.Text;
                Global.headAndTailFilmDetectRangeNegativeB = txtHeadAndTailFilmDetectRange_NegativeB.Text;

                if (chkIsUsingWidthResolutionCalibrate_NegativeB.Checked)
                {
                    Global.isUsingWidthResolutionCalibrateNegativeB = "1";
                }
                else
                {
                    Global.isUsingWidthResolutionCalibrateNegativeB = "0";
                }
                Global.waferWidthNegativeB = txtWaferWidth_NegativeB.Text;
                Global.widthResolutionNegativeB = txtWidthResolution_NegativeB.Text;
                //txtWaferWidth_PositiveA.Text = txtWaferWidth_NegativeB.Text;
                //txtWaferWidth_PositiveB.Text = txtWaferWidth_NegativeB.Text;
                //txtWaferWidth_NegativeA.Text = txtWaferWidth_NegativeB.Text;
                if (chkIsUsingHeightResolutionCalibrate_NegativeB.Checked)
                {
                    Global.isUsingHeightResolutionCalibrateNegativeB = "1";
                }
                else
                {
                    Global.isUsingHeightResolutionCalibrateNegativeB = "0";
                }
                Global.viceLineInterval = txtViceLineInterval_NegativeB.Text;
                Global.heightResolutionNegativeB = txtHeightResolution_NegativeB.Text;

                if (chkIsUsingWaferEdgeCalibration_NegativeB.Checked)
                {
                    Global.isUsingWaferEdgeCalibrationNegativeB = "1";
                }
                else
                {
                    Global.isUsingWaferEdgeCalibrationNegativeB = "0";
                }
                Global.locationWaferEdgeThreshNegativeB = txtLocationWaferEdgeThresh_NegativeB.Text;
                Global.waferEdgeCalibrationRegionDilationPixelNegativeB = txtWaferEdgeCalibrationRegionDilationPixel_NegativeB.Text;

                if (chkIsUsingDistanceDetect_NegativeB.Checked)
                {
                    Global.isUsingDistanceDetectNegativeB = "1";
                }
                else
                {
                    Global.isUsingDistanceDetectNegativeB = "0";
                }
                Global.minimumDistanceThreshNegativeB = txtMinimumDistanceThresh_NegativeB.Text;
                Global.maxDistanceThreshNegativeB = txtMaxDistanceThresh_NegativeB.Text;
                Global.classDistanceThreshNegativeB = txtClassDistanceThresh_NegativeB.Text;

                if (chkIsUsingEdgeDefectDetect_NegativeB.Checked)
                {
                    Global.isUsingEdgeDefectDetectNegativeB = "1";
                }
                else
                {
                    Global.isUsingEdgeDefectDetectNegativeB = "0";
                }
                Global.edgeBigDefectWidthThreshNegativeB = txtEdgeBigDefectWidthThresh_NegativeB.Text;
                Global.edgeBigDefectHeightThreshNegativeB = txtEdgeBigDefectHeightThresh_NegativeB.Text;
                Global.edgeSmallDefectDetectDepthNegativeB = txtEdgeSmallDefectDetectDepth_NegativeB.Text;
                Global.edgeSmallDefectGrayThreshNegativeB = txtEdgeSmallDefectGrayThresh_NegativeB.Text;
                Global.edgeSmallDefectWidthThreshNegativeB = txtEdgeSmallDefectWidthThresh_NegativeB.Text;
                Global.edgeSmallDefectHeightThreshNegativeB = txtEdgeSmallDefectHeightThresh_NegativeB.Text;
                Global.edgeSmallDefectGrayMeanThreshNegativeB = txtEdgeSmallDefectGrayMeanThresh_NegativeB.Text;
                Global.edgeSmallDefectGrayDeviationThreshNegativeB = txtEdgeSmallDefectGrayDeviationThresh_NegativeB.Text;
                Global.cornerDefectAreaRatioThreshNegativeB = txtCornerDefectAreaRatioThresh_NegativeB.Text;

                if (chkIsUsingSurfaceDefectDetect_NegativeB.Checked)
                {
                    Global.isUsingSurfaceDefectDetectNegativeB = "1";
                }
                else
                {
                    Global.isUsingSurfaceDefectDetectNegativeB = "0";
                }
                Global.surfaceDefectGrayThreshNegativeB = txtSurfaceDefectGrayThresh_NegativeB.Text;
                Global.surfaceDefectWidthThreshNegativeB = txtSurfaceDefectWidthThresh_NegativeB.Text;
                Global.surfaceDefectHeightThreshNegativeB = txtSurfaceDefectHeightThresh_NegativeB.Text;
                Global.surfaceDefectDetectIndentDepthNegativeB = txtSurfaceDefectDetectIndentDepth_NegativeB.Text;
                Global.surfaceDefectViceLineShieldWidthNegativeB = txtSurfaceDefectViceLineShieldWidth_NegativeB.Text;
                Global.surfaceDefectViceLineShieldLeftPosOffSetNegativeB = txtSurfaceDefectViceLineShieldLeftPosOffSet_NegativeB.Text;
                Global.surfaceDefectViceLineShieldRightPosOffSetNegativeB = txtSurfaceDefectViceLineShieldRightPosOffSet_NegativeB.Text;
                Global.surfaceScratchGrayThreshNegativeB = txtSurfaceScratchGrayThresh_NegativeB.Text;
                Global.surfaceScratchWidthThreshNegativeB = txtSurfaceScratchWidthThresh_NegativeB.Text;
                Global.surfaceScratchHeightThreshNegativeB = txtSurfaceScratchHeightThresh_NegativeB.Text;

                if (chkIsUsingBrokenLineDetect_NegativeB.Checked)
                {
                    Global.isUsingBrokenLineDetectNegativeB = "1";
                }
                else
                {
                    Global.isUsingBrokenLineDetectNegativeB = "0";
                }
                Global.brokenLineGrayThreshNegativeB = txtBrokenLineGrayThresh_NegativeB.Text;
                Global.brokenLineWidthThreshNegativeB = txtBrokenLineWidthThresh_NegativeB.Text;
                Global.brokenLineHeightThreshNegativeB = txtBrokenLineHeightThresh_NegativeB.Text;
                Global.brokenLineDetectIndentDepthNegativeB = txtBrokenLineDetectIndentDepth_NegativeB.Text;
                if (chkIsUsingStartWeldingDetect_NegativeB.Checked)
                {
                    Global.isUsingStartWeldingDetectNegativeB = "1";
                }
                else
                {
                    Global.isUsingStartWeldingDetectNegativeB = "0";
                }
                Global.startWeldingDistanceMinThreshNegativeB = txtStartWeldingDistanceMinThresh_NegativeB.Text;
                Global.startWeldingDistanceMaxThreshNegativeB = txtStartWeldingDistanceMaxThresh_NegativeB.Text;
                if (chkIsUsingSurfaceColorDiffDetect_NegativeB.Checked)
                {
                    Global.isUsingSurfaceColorDiffDetectNegativeB = "1";
                }
                else
                {
                    Global.isUsingSurfaceColorDiffDetectNegativeB = "0";
                }
                Global.surfaceColorDiffGrayThreshNegativeB = txtSurfaceColorDiffGrayThresh_NegativeB.Text;
                if (chkIsUsingAlarmFunction_NegativeB.Checked)
                {
                    Global.isUsingAlarmFunction_NegativeB = "1";
                }
                else
                {
                    Global.isUsingAlarmFunction_NegativeB = "0";
                }
                Global.maxAlamClusterCount_NegativeB = txtMaxAlamClusterCount_NegativeB.Text;

                if (chkIsSaveAllImage_NegativeB.Checked)
                {
                    Global.isSaveAllImage_NegativeB = "1";
                }
                else
                {
                    Global.isSaveAllImage_NegativeB = "0";
                }
                if (chkIsSaveNGImage_NegativeB.Checked)
                {
                    Global.isSaveNGImage_NegativeB = "1";
                }
                else
                {
                    Global.isSaveNGImage_NegativeB = "0";
                }
                if (chkIsSaveNGImageWithRoi_NegativeB.Checked)
                {
                    Global.isSaveNGImageWithRoi_NegativeB = "1";
                }
                else
                {
                    Global.isSaveNGImageWithRoi_NegativeB = "0";
                }
                if (chkIsUsingCamera_NegativeB.Checked)
                {
                    Global.isUsingCamera_NegativeB = "1";
                }
                else
                {
                    Global.isUsingCamera_NegativeB = "0";
                }
                #endregion

                //背面关闭起焊点等功能
                if (Convert.ToInt32(Global.mainLineNum) >= 9)
                {
                    Global.isUsingStartWeldingDetectNegativeA = "0";
                    Global.isUsingStartWeldingDetectNegativeB = "0";

                    Global.isUsingEdgeDefectDetectNegativeA = "0";
                    Global.isUsingEdgeDefectDetectNegativeB = "0";

                    Global.isUsingSurfaceColorDiffDetectNegativeA = "0";
                    Global.isUsingSurfaceColorDiffDetectNegativeB = "0";

                    //Global.isUsingSurfaceDefectDetectNegativeA = "0";
                    //Global.isUsingSurfaceDefectDetectNegativeB = "0";

                    Global.isUsingBrokenLineDetectNegativeA = "0";
                    Global.isUsingBrokenLineDetectNegativeB = "0";

                    txtStartWeldingDistanceMinThresh_PositiveA.Enabled = false;
                    txtStartWeldingDistanceMinThresh_PositiveB.Enabled = false;
                    txtStartWeldingDistanceMinThresh_NegativeA.Enabled = false;
                    txtStartWeldingDistanceMinThresh_NegativeB.Enabled = false;

                    txtStartWeldingDistanceMaxThresh_PositiveA.Enabled = false;
                    txtStartWeldingDistanceMaxThresh_PositiveB.Enabled = false;
                    txtStartWeldingDistanceMaxThresh_NegativeA.Enabled = false;
                    txtStartWeldingDistanceMaxThresh_NegativeB.Enabled = false;

                }
                else
                {
                    txtStartWeldingDistanceMinThresh_PositiveA.Enabled = true;
                    txtStartWeldingDistanceMinThresh_PositiveB.Enabled = true;
                    txtStartWeldingDistanceMinThresh_NegativeA.Enabled = true;
                    txtStartWeldingDistanceMinThresh_NegativeB.Enabled = true;

                    txtStartWeldingDistanceMaxThresh_PositiveA.Enabled = true;
                    txtStartWeldingDistanceMaxThresh_PositiveB.Enabled = true;
                    txtStartWeldingDistanceMaxThresh_NegativeA.Enabled = true;
                    txtStartWeldingDistanceMaxThresh_NegativeB.Enabled = true;
                }
                mainForm.RefreshRecipeGlobalParameter();
                mainForm.RefreshRecipeParameterPositiveA();
                mainForm.RefreshRecipeParameterPositiveB();
                mainForm.RefreshRecipeParameterNegativeA();
                mainForm.RefreshRecipeParameterNegativeB();
                mainForm.RefreshTcpIPLabelState();
                mainForm.InitNGArray();
                SaveDefaultRecipe();
                if (Global.isEnglish=="0")
                {
                    MessageBox.Show("配方参数已保存！");
                    
                }
                else
                {
                    MessageBox.Show("Recipe Has Bean Saved！");
                }
                
                
            }
            else
            {
                if (Global.isEnglish == "0")
                {
                    MessageBox.Show("配方输入框存在非法字符！！！");

                }
                else
                {
                    MessageBox.Show("Illegal Parameters！");
                }
                
                return;
            }
        }

        public void SaveDefaultRecipe()
        {
            
            Config.WriteIniData("Config", "PassWordAdministrator", Global.passWordAdministrator, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "PassWordHandlers", Global.passWordHandlers, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsEnglish", Global.isEnglish, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "WaferCountPerClass", Global.waferCountPerClass, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsDalsaCam", Global.isDalsaCam, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "MainLineNum", Global.mainLineNum, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "MainLineDistance", Global.mainLineDistance, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsFullWafer", Global.isFullWafer, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SubMainLineNum", Global.subMainLineNum, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "StringType", Global.stringType, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsDoubleDetect", Global.isDoubleDetect, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsMESFun", Global.isMESFun, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUpperLink", Global.isUpperLink, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingWidthResolutionCalibratePositiveA", Global.isUsingWidthResolutionCalibratePositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingWidthResolutionCalibratePositiveB", Global.isUsingWidthResolutionCalibratePositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "WidthResolutionPositiveA", Global.widthResolutionPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "WidthResolutionPositiveB", Global.widthResolutionPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "WaferWidth", Global.waferWidth, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "WaferWidthPositiveA", Global.waferWidthPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "WaferWidthPositiveB", Global.waferWidthPositiveB, mainForm.defaultRecipePath);
            
            Config.WriteIniData("Config", "IsUsingHeightResolutionCalibratePositiveA", Global.isUsingHeightResolutionCalibratePositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingHeightResolutionCalibratePositiveB", Global.isUsingHeightResolutionCalibratePositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "HeightResolutionPositiveA", Global.heightResolutionPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "HeightResolutionPositiveB", Global.heightResolutionPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "ViceLineInterval", Global.viceLineInterval, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingFilmShiftingDetectPositiveA", Global.isUsingFilmShiftingDetectPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingFilmShiftingDetectPositiveB", Global.isUsingFilmShiftingDetectPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "TopShieldLengthOfTopRegionPositiveA", Global.topShieldLengthOfTopRegionPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "TopShieldLengthOfTopRegionPositiveB", Global.topShieldLengthOfTopRegionPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "BottomShieldLengthOfTopRegionPositiveA", Global.bottomShieldLengthOfTopRegionPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "BottomShieldLengthOfTopRegionPositiveB", Global.bottomShieldLengthOfTopRegionPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "TopShieldLengthOfBottomRegionPositiveA", Global.topShieldLengthOfBottomRegionPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "TopShieldLengthOfBottomRegionPositiveB", Global.topShieldLengthOfBottomRegionPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "BottomShieldLengthOfBottomRegionPositiveA", Global.bottomShieldLengthOfBottomRegionPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "BottomShieldLengthOfBottomRegionPositiveB", Global.bottomShieldLengthOfBottomRegionPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "LocationMainLineThreshPositiveA", Global.locationMainLineThreshPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "LocationMainLineThreshPositiveB", Global.locationMainLineThreshPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "FilmWidthThreshPositiveA", Global.filmWidthThreshPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "FilmWidthThreshPositiveB", Global.filmWidthThreshPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "FilmWidthOffSetPositiveA", Global.filmWidthOffSetPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "FilmWidthOffSetPositiveB", Global.filmWidthOffSetPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingFilmMissDetectPositiveA", Global.isUsingFilmMissDetectPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingFilmMissDetectPositiveB", Global.isUsingFilmMissDetectPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "WeldWidthThreshPositiveA", Global.weldWidthThreshPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "WeldWidthThreshPositiveB", Global.weldWidthThreshPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "WeldShieldLengthPositiveA", Global.weldShieldLengthPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "WeldShieldLengthPositiveB", Global.weldShieldLengthPositiveB, mainForm.defaultRecipePath);

            Config.WriteIniData("Config", "FirstDetectPosForTopRegionPositiveA", Global.firstDetectPosForTopRegionPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "FirstDetectPosForTopRegionPositiveB", Global.firstDetectPosForTopRegionPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SecondDetectPosForTopRegionPositiveA", Global.secondDetectPosForTopRegionPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SecondDetectPosForTopRegionPositiveB", Global.secondDetectPosForTopRegionPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "FirstDetectPosForBottomRegionPositiveA", Global.firstDetectPosForBottomRegionPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "FirstDetectPosForBottomRegionPositiveB", Global.firstDetectPosForBottomRegionPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SecondDetectPosForBottomRegionPositiveA", Global.secondDetectPosForBottomRegionPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SecondDetectPosForBottomRegionPositiveB", Global.secondDetectPosForBottomRegionPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingHeadAndTailFilmShiftingDetectPositiveA", Global.isUsingHeadAndTailFilmShiftingDetectPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingHeadAndTailFilmShiftingDetectPositiveB", Global.isUsingHeadAndTailFilmShiftingDetectPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "HeadAndTailFilmWidthThreshPositiveA", Global.headAndTailFilmWidthThreshPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "HeadAndTailFilmWidthThreshPositiveB", Global.headAndTailFilmWidthThreshPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "HeadAndTailFilmShieldLengthPositiveA", Global.headAndTailFilmShieldLengthPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "HeadAndTailFilmShieldLengthPositiveB", Global.headAndTailFilmShieldLengthPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "HeadAndTailFilmDetectRangePositiveA", Global.headAndTailFilmDetectRangePositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "HeadAndTailFilmDetectRangePositiveB", Global.headAndTailFilmDetectRangePositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingWaferEdgeCalibrationPositiveA", Global.isUsingWaferEdgeCalibrationPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingWaferEdgeCalibrationPositiveB", Global.isUsingWaferEdgeCalibrationPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "LocationWaferEdgeThreshPositiveA", Global.locationWaferEdgeThreshPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "LocationWaferEdgeThreshPositiveB", Global.locationWaferEdgeThreshPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "WaferEdgeCalibrationRegionDilationPixelPositiveA", Global.waferEdgeCalibrationRegionDilationPixelPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "WaferEdgeCalibrationRegionDilationPixelPositiveB", Global.waferEdgeCalibrationRegionDilationPixelPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingDistanceDetectPositiveA", Global.isUsingDistanceDetectPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingDistanceDetectPositiveB", Global.isUsingDistanceDetectPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "MinimumDistanceThreshPositiveA", Global.minimumDistanceThreshPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "MinimumDistanceThreshPositiveB", Global.minimumDistanceThreshPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "MaxDistanceThreshPositiveA", Global.maxDistanceThreshPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "MaxDistanceThreshPositiveB", Global.maxDistanceThreshPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "ClassDistanceThreshPositiveA", Global.classDistanceThreshPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "ClassDistanceThreshPositiveB", Global.classDistanceThreshPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingEdgeDefectDetectPositiveA", Global.isUsingEdgeDefectDetectPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingEdgeDefectDetectPositiveB", Global.isUsingEdgeDefectDetectPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeBigDefectWidthThreshPositiveA", Global.edgeBigDefectWidthThreshPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeBigDefectWidthThreshPositiveB", Global.edgeBigDefectWidthThreshPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeBigDefectHeightThreshPositiveA", Global.edgeBigDefectHeightThreshPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeBigDefectHeightThreshPositiveB", Global.edgeBigDefectHeightThreshPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeSmallDefectDetectDepthPositiveA", Global.edgeSmallDefectDetectDepthPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeSmallDefectDetectDepthPositiveB", Global.edgeSmallDefectDetectDepthPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeSmallDefectGrayThreshPositiveA", Global.edgeSmallDefectGrayThreshPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeSmallDefectGrayThreshPositiveB", Global.edgeSmallDefectGrayThreshPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeSmallDefectWidthThreshPositiveA", Global.edgeSmallDefectWidthThreshPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeSmallDefectWidthThreshPositiveB", Global.edgeSmallDefectWidthThreshPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeSmallDefectHeightThreshPositiveA", Global.edgeSmallDefectHeightThreshPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeSmallDefectHeightThreshPositiveB", Global.edgeSmallDefectHeightThreshPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeSmallDefectGrayMeanThreshPositiveA", Global.edgeSmallDefectGrayMeanThreshPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeSmallDefectGrayMeanThreshPositiveB", Global.edgeSmallDefectGrayMeanThreshPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeSmallDefectGrayDeviationThreshPositiveA", Global.edgeSmallDefectGrayDeviationThreshPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeSmallDefectGrayDeviationThreshPositiveB", Global.edgeSmallDefectGrayDeviationThreshPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "CornerDefectAreaRatioThreshPositiveA", Global.cornerDefectAreaRatioThreshPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "CornerDefectAreaRatioThreshPositiveB", Global.cornerDefectAreaRatioThreshPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingSurfaceDefectDetectPositiveA", Global.isUsingSurfaceDefectDetectPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingSurfaceDefectDetectPositiveB", Global.isUsingSurfaceDefectDetectPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectGrayThreshPositiveA", Global.surfaceDefectGrayThreshPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectGrayThreshPositiveB", Global.surfaceDefectGrayThreshPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectWidthThreshPositiveA", Global.surfaceDefectWidthThreshPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectWidthThreshPositiveB", Global.surfaceDefectWidthThreshPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectHeightThreshPositiveA", Global.surfaceDefectHeightThreshPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectHeightThreshPositiveB", Global.surfaceDefectHeightThreshPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectDetectIndentDepthPositiveA", Global.surfaceDefectDetectIndentDepthPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectDetectIndentDepthPositiveB", Global.surfaceDefectDetectIndentDepthPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectViceLineShieldWidthPositiveA", Global.surfaceDefectViceLineShieldWidthPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectViceLineShieldWidthPositiveB", Global.surfaceDefectViceLineShieldWidthPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectViceLineShieldLeftPosOffSetPositiveA", Global.surfaceDefectViceLineShieldLeftPosOffSetPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectViceLineShieldLeftPosOffSetPositiveB", Global.surfaceDefectViceLineShieldLeftPosOffSetPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectViceLineShieldRightPosOffSetPositiveA", Global.surfaceDefectViceLineShieldRightPosOffSetPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectViceLineShieldRightPosOffSetPositiveB", Global.surfaceDefectViceLineShieldRightPosOffSetPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceScratchGrayThreshPositiveA", Global.surfaceScratchGrayThreshPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceScratchGrayThreshPositiveB", Global.surfaceScratchGrayThreshPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceScratchWidthThreshPositiveA", Global.surfaceScratchWidthThreshPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceScratchWidthThreshPositiveB", Global.surfaceScratchWidthThreshPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceScratchHeightThreshPositiveA", Global.surfaceScratchHeightThreshPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceScratchHeightThreshPositiveB", Global.surfaceScratchHeightThreshPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingBrokenLineDetectPositiveA", Global.isUsingBrokenLineDetectPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingBrokenLineDetectPositiveB", Global.isUsingBrokenLineDetectPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "BrokenLineGrayThreshPositiveA", Global.brokenLineGrayThreshPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "BrokenLineGrayThreshPositiveB", Global.brokenLineGrayThreshPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "BrokenLineWidthThreshPositiveA", Global.brokenLineWidthThreshPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "BrokenLineWidthThreshPositiveB", Global.brokenLineWidthThreshPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "BrokenLineHeightThreshPositiveA", Global.brokenLineHeightThreshPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "BrokenLineHeightThreshPositiveB", Global.brokenLineHeightThreshPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "BrokenLineDetectIndentDepthPositiveA", Global.brokenLineDetectIndentDepthPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "BrokenLineDetectIndentDepthPositiveB", Global.brokenLineDetectIndentDepthPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingStartWeldingDetectPositiveA", Global.isUsingStartWeldingDetectPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingStartWeldingDetectPositiveB", Global.isUsingStartWeldingDetectPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "StartWeldingDistanceMaxThreshPositiveA", Global.startWeldingDistanceMaxThreshPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "StartWeldingDistanceMaxThreshPositiveB", Global.startWeldingDistanceMaxThreshPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "StartWeldingDistanceMinThreshPositiveA", Global.startWeldingDistanceMinThreshPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "StartWeldingDistanceMinThreshPositiveB", Global.startWeldingDistanceMinThreshPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingSurfaceColorDiffDetectPositiveA", Global.isUsingSurfaceColorDiffDetectPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingSurfaceColorDiffDetectPositiveB", Global.isUsingSurfaceColorDiffDetectPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceColorDiffGrayThreshPositiveA", Global.surfaceColorDiffGrayThreshPositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceColorDiffGrayThreshPositiveB", Global.surfaceColorDiffGrayThreshPositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsSaveNGImage_PositiveA", Global.isSaveNGImage_PositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsSaveNGImage_PositiveB", Global.isSaveNGImage_PositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsSaveAllImage_PositiveA", Global.isSaveAllImage_PositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsSaveAllImage_PositiveB", Global.isSaveAllImage_PositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsSaveNGImageWithRoi_PositiveA", Global.isSaveNGImageWithRoi_PositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsSaveNGImageWithRoi_PositiveB", Global.isSaveNGImageWithRoi_PositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingCamera_PositiveA", Global.isUsingCamera_PositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingCamera_PositiveB", Global.isUsingCamera_PositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingAlarmFunction_PositiveA", Global.isUsingAlarmFunction_PositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingAlarmFunction_PositiveB", Global.isUsingAlarmFunction_PositiveB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "MaxAlamClusterCount_PositiveA", Global.maxAlamClusterCount_PositiveA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "MaxAlamClusterCount_PositiveB", Global.maxAlamClusterCount_PositiveB, mainForm.defaultRecipePath);

            Config.WriteIniData("Config", "WaferWidthNegativeA", Global.waferWidthNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "WaferWidthNegativeB", Global.waferWidthNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingWidthResolutionCalibrateNegativeA", Global.isUsingWidthResolutionCalibrateNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingWidthResolutionCalibrateNegativeB", Global.isUsingWidthResolutionCalibrateNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "WidthResolutionNegativeA", Global.widthResolutionNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "WidthResolutionNegativeB", Global.widthResolutionNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "WaferWidth", Global.waferWidth, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingHeightResolutionCalibrateNegativeA", Global.isUsingHeightResolutionCalibrateNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingHeightResolutionCalibrateNegativeB", Global.isUsingHeightResolutionCalibrateNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "HeightResolutionNegativeA", Global.heightResolutionNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "HeightResolutionNegativeB", Global.heightResolutionNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "ViceLineInterval", Global.viceLineInterval, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingFilmShiftingDetectNegativeA", Global.isUsingFilmShiftingDetectNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingFilmShiftingDetectNegativeB", Global.isUsingFilmShiftingDetectNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "TopShieldLengthOfTopRegionNegativeA", Global.topShieldLengthOfTopRegionNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "TopShieldLengthOfTopRegionNegativeB", Global.topShieldLengthOfTopRegionNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "BottomShieldLengthOfTopRegionNegativeA", Global.bottomShieldLengthOfTopRegionNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "BottomShieldLengthOfTopRegionNegativeB", Global.bottomShieldLengthOfTopRegionNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "TopShieldLengthOfBottomRegionNegativeA", Global.topShieldLengthOfBottomRegionNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "TopShieldLengthOfBottomRegionNegativeB", Global.topShieldLengthOfBottomRegionNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "BottomShieldLengthOfBottomRegionNegativeA", Global.bottomShieldLengthOfBottomRegionNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "BottomShieldLengthOfBottomRegionNegativeB", Global.bottomShieldLengthOfBottomRegionNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "LocationMainLineThreshNegativeA", Global.locationMainLineThreshNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "LocationMainLineThreshNegativeB", Global.locationMainLineThreshNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "FilmWidthThreshNegativeA", Global.filmWidthThreshNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "FilmWidthThreshNegativeB", Global.filmWidthThreshNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "FilmWidthOffSetNegativeA", Global.filmWidthOffSetNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "FilmWidthOffSetNegativeB", Global.filmWidthOffSetNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingFilmMissDetectNegativeA", Global.isUsingFilmMissDetectNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingFilmMissDetectNegativeB", Global.isUsingFilmMissDetectNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "WeldWidthThreshNegativeA", Global.weldWidthThreshNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "WeldWidthThreshNegativeB", Global.weldWidthThreshNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "FirstDetectPosForTopRegionNegativeA", Global.firstDetectPosForTopRegionNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "FirstDetectPosForTopRegionNegativeB", Global.firstDetectPosForTopRegionNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SecondDetectPosForTopRegionNegativeA", Global.secondDetectPosForTopRegionNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SecondDetectPosForTopRegionNegativeB", Global.secondDetectPosForTopRegionNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "FirstDetectPosForBottomRegionNegativeA", Global.firstDetectPosForBottomRegionNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "FirstDetectPosForBottomRegionNegativeB", Global.firstDetectPosForBottomRegionNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SecondDetectPosForBottomRegionNegativeA", Global.secondDetectPosForBottomRegionNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SecondDetectPosForBottomRegionNegativeB", Global.secondDetectPosForBottomRegionNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingHeadAndTailFilmShiftingDetectNegativeA", Global.isUsingHeadAndTailFilmShiftingDetectNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingHeadAndTailFilmShiftingDetectNegativeB", Global.isUsingHeadAndTailFilmShiftingDetectNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "HeadAndTailFilmWidthThreshNegativeA", Global.headAndTailFilmWidthThreshNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "HeadAndTailFilmWidthThreshNegativeB", Global.headAndTailFilmWidthThreshNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "HeadAndTailFilmShieldLengthNegativeA", Global.headAndTailFilmShieldLengthNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "HeadAndTailFilmShieldLengthNegativeB", Global.headAndTailFilmShieldLengthNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "HeadAndTailFilmDetectRangeNegativeA", Global.headAndTailFilmDetectRangeNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "HeadAndTailFilmDetectRangeNegativeB", Global.headAndTailFilmDetectRangeNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingWaferEdgeCalibrationNegativeA", Global.isUsingWaferEdgeCalibrationNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingWaferEdgeCalibrationNegativeB", Global.isUsingWaferEdgeCalibrationNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "LocationWaferEdgeThreshNegativeA", Global.locationWaferEdgeThreshNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "LocationWaferEdgeThreshNegativeB", Global.locationWaferEdgeThreshNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "WaferEdgeCalibrationRegionDilationPixelNegativeA", Global.waferEdgeCalibrationRegionDilationPixelNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "WaferEdgeCalibrationRegionDilationPixelNegativeB", Global.waferEdgeCalibrationRegionDilationPixelNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingDistanceDetectNegativeA", Global.isUsingDistanceDetectNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingDistanceDetectNegativeB", Global.isUsingDistanceDetectNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "MinimumDistanceThreshNegativeA", Global.minimumDistanceThreshNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "MinimumDistanceThreshNegativeB", Global.minimumDistanceThreshNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "MaxDistanceThreshNegativeA", Global.maxDistanceThreshNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "MaxDistanceThreshNegativeB", Global.maxDistanceThreshNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "ClassDistanceThreshNegativeA", Global.classDistanceThreshNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "ClassDistanceThreshNegativeB", Global.classDistanceThreshNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingEdgeDefectDetectNegativeA", Global.isUsingEdgeDefectDetectNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingEdgeDefectDetectNegativeB", Global.isUsingEdgeDefectDetectNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeBigDefectWidthThreshNegativeA", Global.edgeBigDefectWidthThreshNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeBigDefectWidthThreshNegativeB", Global.edgeBigDefectWidthThreshNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeBigDefectHeightThreshNegativeA", Global.edgeBigDefectHeightThreshNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeBigDefectHeightThreshNegativeB", Global.edgeBigDefectHeightThreshNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeSmallDefectDetectDepthNegativeA", Global.edgeSmallDefectDetectDepthNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeSmallDefectDetectDepthNegativeB", Global.edgeSmallDefectDetectDepthNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeSmallDefectGrayThreshNegativeA", Global.edgeSmallDefectGrayThreshNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeSmallDefectGrayThreshNegativeB", Global.edgeSmallDefectGrayThreshNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeSmallDefectWidthThreshNegativeA", Global.edgeSmallDefectWidthThreshNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeSmallDefectWidthThreshNegativeB", Global.edgeSmallDefectWidthThreshNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeSmallDefectHeightThreshNegativeA", Global.edgeSmallDefectHeightThreshNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeSmallDefectHeightThreshNegativeB", Global.edgeSmallDefectHeightThreshNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeSmallDefectGrayMeanThreshNegativeA", Global.edgeSmallDefectGrayMeanThreshNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeSmallDefectGrayMeanThreshNegativeB", Global.edgeSmallDefectGrayMeanThreshNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeSmallDefectGrayDeviationThreshNegativeA", Global.edgeSmallDefectGrayDeviationThreshNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "EdgeSmallDefectGrayDeviationThreshNegativeB", Global.edgeSmallDefectGrayDeviationThreshNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "CornerDefectAreaRatioThreshNegativeA", Global.cornerDefectAreaRatioThreshNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "CornerDefectAreaRatioThreshNegativeB", Global.cornerDefectAreaRatioThreshNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingSurfaceDefectDetectNegativeA", Global.isUsingSurfaceDefectDetectNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingSurfaceDefectDetectNegativeB", Global.isUsingSurfaceDefectDetectNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectGrayThreshNegativeA", Global.surfaceDefectGrayThreshNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectGrayThreshNegativeB", Global.surfaceDefectGrayThreshNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectWidthThreshNegativeA", Global.surfaceDefectWidthThreshNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectWidthThreshNegativeB", Global.surfaceDefectWidthThreshNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectHeightThreshNegativeA", Global.surfaceDefectHeightThreshNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectHeightThreshNegativeB", Global.surfaceDefectHeightThreshNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectDetectIndentDepthNegativeA", Global.surfaceDefectDetectIndentDepthNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectDetectIndentDepthNegativeB", Global.surfaceDefectDetectIndentDepthNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectViceLineShieldWidthNegativeA", Global.surfaceDefectViceLineShieldWidthNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectViceLineShieldWidthNegativeB", Global.surfaceDefectViceLineShieldWidthNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectViceLineShieldLeftPosOffSetNegativeA", Global.surfaceDefectViceLineShieldLeftPosOffSetNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectViceLineShieldLeftPosOffSetNegativeB", Global.surfaceDefectViceLineShieldLeftPosOffSetNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectViceLineShieldRightPosOffSetNegativeA", Global.surfaceDefectViceLineShieldRightPosOffSetNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceDefectViceLineShieldRightPosOffSetNegativeB", Global.surfaceDefectViceLineShieldRightPosOffSetNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceScratchGrayThreshNegativeA", Global.surfaceScratchGrayThreshNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceScratchGrayThreshNegativeB", Global.surfaceScratchGrayThreshNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceScratchWidthThreshNegativeA", Global.surfaceScratchWidthThreshNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceScratchWidthThreshNegativeB", Global.surfaceScratchWidthThreshNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceScratchHeightThreshNegativeA", Global.surfaceScratchHeightThreshNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceScratchHeightThreshNegativeB", Global.surfaceScratchHeightThreshNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingBrokenLineDetectNegativeA", Global.isUsingBrokenLineDetectNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingBrokenLineDetectNegativeB", Global.isUsingBrokenLineDetectNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "BrokenLineGrayThreshNegativeA", Global.brokenLineGrayThreshNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "BrokenLineGrayThreshNegativeB", Global.brokenLineGrayThreshNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "BrokenLineWidthThreshNegativeA", Global.brokenLineWidthThreshNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "BrokenLineWidthThreshNegativeB", Global.brokenLineWidthThreshNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "BrokenLineHeightThreshNegativeA", Global.brokenLineHeightThreshNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "BrokenLineHeightThreshNegativeB", Global.brokenLineHeightThreshNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "BrokenLineDetectIndentDepthNegativeA", Global.brokenLineDetectIndentDepthNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "BrokenLineDetectIndentDepthNegativeB", Global.brokenLineDetectIndentDepthNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingStartWeldingDetectNegativeA", Global.isUsingStartWeldingDetectNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingStartWeldingDetectNegativeB", Global.isUsingStartWeldingDetectNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "StartWeldingDistanceMaxThreshNegativeA", Global.startWeldingDistanceMaxThreshNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "StartWeldingDistanceMaxThreshNegativeB", Global.startWeldingDistanceMaxThreshNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "StartWeldingDistanceMinThreshNegativeA", Global.startWeldingDistanceMinThreshNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "StartWeldingDistanceMinThreshNegativeB", Global.startWeldingDistanceMinThreshNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingSurfaceColorDiffDetectNegativeA", Global.isUsingSurfaceColorDiffDetectNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingSurfaceColorDiffDetectNegativeB", Global.isUsingSurfaceColorDiffDetectNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceColorDiffGrayThreshNegativeA", Global.surfaceColorDiffGrayThreshNegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "SurfaceColorDiffGrayThreshNegativeB", Global.surfaceColorDiffGrayThreshNegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsSaveNGImage_NegativeA", Global.isSaveNGImage_NegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsSaveNGImage_NegativeB", Global.isSaveNGImage_NegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsSaveAllImage_NegativeA", Global.isSaveAllImage_NegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsSaveAllImage_NegativeB", Global.isSaveAllImage_NegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsSaveNGImageWithRoi_NegativeA", Global.isSaveNGImageWithRoi_NegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsSaveNGImageWithRoi_NegativeB", Global.isSaveNGImageWithRoi_NegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingCamera_NegativeA", Global.isUsingCamera_NegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingCamera_NegativeB", Global.isUsingCamera_NegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingAlarmFunction_NegativeA", Global.isUsingAlarmFunction_NegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "IsUsingAlarmFunction_NegativeB", Global.isUsingAlarmFunction_NegativeB, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "MaxAlamClusterCount_NegativeA", Global.maxAlamClusterCount_NegativeA, mainForm.defaultRecipePath);
            Config.WriteIniData("Config", "MaxAlamClusterCount_NegativeB", Global.maxAlamClusterCount_NegativeB, mainForm.defaultRecipePath);
        }
        public void SaveOtherRecipe(string path)
        {
            if ((isNumberic(txtTopShieldLengthOfTopRegion_PositiveA.Text) || isDouble(txtTopShieldLengthOfTopRegion_PositiveA.Text))
                && (isNumberic(txtBottomShieldLengthOfTopRegion_PositiveA.Text) || isDouble(txtBottomShieldLengthOfTopRegion_PositiveA.Text))
                && (isNumberic(txtTopShieldLengthOfBottomRegion_PositiveA.Text) || isDouble(txtTopShieldLengthOfBottomRegion_PositiveA.Text))
                && (isNumberic(txtBottomShieldLengthOfBottomRegion_PositiveA.Text) || isDouble(txtBottomShieldLengthOfBottomRegion_PositiveA.Text))
                && (isNumberic(txtLocationMainLineThresh_PositiveA.Text))
                && (isNumberic(txtFilmWidthThresh_PositiveA.Text) || isDouble(txtFilmWidthThresh_PositiveA.Text))
                && (isNumberic(txtFilmWidthOffSet_PositiveA.Text) || isDouble(txtFilmWidthOffSet_PositiveA.Text))
                && (isNumberic(txtWeldWidthThresh_PositiveA.Text) || isDouble(txtWeldWidthThresh_PositiveA.Text))
                && (isNumberic(txtHeadAndTailFilmWidthThresh_PositiveA.Text) || isDouble(txtHeadAndTailFilmWidthThresh_PositiveA.Text))
                && (isNumberic(txtHeadAndTailFilmShieldLength_PositiveA.Text) || isDouble(txtHeadAndTailFilmShieldLength_PositiveA.Text))
                && (isNumberic(txtHeadAndTailFilmDetectRange_PositiveA.Text) || isDouble(txtHeadAndTailFilmDetectRange_PositiveA.Text))
                && (isNumberic(txtWaferWidth_PositiveA.Text) || isDouble(txtWaferWidth_PositiveA.Text))
                && (isNumberic(txtWidthResolution_PositiveA.Text) || isDouble(txtWidthResolution_PositiveA.Text))
                && (isNumberic(txtViceLineInterval_PositiveA.Text) || isDouble(txtViceLineInterval_PositiveA.Text))
                && (isNumberic(txtHeightResolution_PositiveA.Text) || isDouble(txtHeightResolution_PositiveA.Text))
                && (isNumberic(txtLocationWaferEdgeThresh_PositiveA.Text))
                && (isNumberic(txtWaferEdgeCalibrationRegionDilationPixel_PositiveA.Text))
                && (isNumberic(txtMinimumDistanceThresh_PositiveA.Text) || isDouble(txtMinimumDistanceThresh_PositiveA.Text))
                && (isNumberic(txtMaxDistanceThresh_PositiveA.Text) || isDouble(txtMaxDistanceThresh_PositiveA.Text))
                && (isNumberic(txtClassDistanceThresh_PositiveA.Text) || isDouble(txtClassDistanceThresh_PositiveA.Text))
                && (isNumberic(txtEdgeBigDefectWidthThresh_PositiveA.Text) || isDouble(txtEdgeBigDefectWidthThresh_PositiveA.Text))
                && (isNumberic(txtEdgeBigDefectHeightThresh_PositiveA.Text) || isDouble(txtEdgeBigDefectHeightThresh_PositiveA.Text))
                && (isNumberic(txtEdgeSmallDefectDetectDepth_PositiveA.Text) || isDouble(txtEdgeSmallDefectDetectDepth_PositiveA.Text))
                && (isNumberic(txtEdgeSmallDefectGrayThresh_PositiveA.Text))
                && (isNumberic(txtEdgeSmallDefectWidthThresh_PositiveA.Text) || isDouble(txtEdgeSmallDefectWidthThresh_PositiveA.Text))
                && (isNumberic(txtEdgeSmallDefectHeightThresh_PositiveA.Text) || isDouble(txtEdgeSmallDefectHeightThresh_PositiveA.Text))
                && (isNumberic(txtEdgeSmallDefectGrayMeanThresh_PositiveA.Text) || isDouble(txtEdgeSmallDefectGrayMeanThresh_PositiveA.Text))
                && (isNumberic(txtEdgeSmallDefectGrayDeviationThresh_PositiveA.Text) || isDouble(txtEdgeSmallDefectGrayDeviationThresh_PositiveA.Text))
                && (isNumberic(txtCornerDefectAreaRatioThresh_PositiveA.Text) || isDouble(txtCornerDefectAreaRatioThresh_PositiveA.Text))
                && (isNumberic(txtSurfaceDefectGrayThresh_PositiveA.Text))
                && (isNumberic(txtSurfaceDefectWidthThresh_PositiveA.Text) || isDouble(txtSurfaceDefectWidthThresh_PositiveA.Text))
                && (isNumberic(txtSurfaceDefectHeightThresh_PositiveA.Text) || isDouble(txtSurfaceDefectHeightThresh_PositiveA.Text))
                && (isNumberic(txtSurfaceDefectDetectIndentDepth_PositiveA.Text) || isDouble(txtSurfaceDefectDetectIndentDepth_PositiveA.Text))
                && (isNumberic(txtSurfaceDefectViceLineShieldWidth_PositiveA.Text))
                && (isNumberic(txtSurfaceDefectViceLineShieldLeftPosOffSet_PositiveA.Text))
                && (isNumberic(txtSurfaceDefectViceLineShieldRightPosOffSet_PositiveA.Text))
                && (isNumberic(txtMaxAlamClusterCount_PositiveA.Text))

                && (isNumberic(txtMainLineDistance.Text) || isDouble(txtMainLineDistance.Text))

                && (isNumberic(txtTopShieldLengthOfTopRegion_PositiveB.Text) || isDouble(txtTopShieldLengthOfTopRegion_PositiveB.Text))
                && (isNumberic(txtBottomShieldLengthOfTopRegion_PositiveB.Text) || isDouble(txtBottomShieldLengthOfTopRegion_PositiveB.Text))
                && (isNumberic(txtTopShieldLengthOfBottomRegion_PositiveB.Text) || isDouble(txtTopShieldLengthOfBottomRegion_PositiveB.Text))
                && (isNumberic(txtBottomShieldLengthOfBottomRegion_PositiveB.Text) || isDouble(txtBottomShieldLengthOfBottomRegion_PositiveB.Text))
                && (isNumberic(txtLocationMainLineThresh_PositiveB.Text))
                && (isNumberic(txtFilmWidthThresh_PositiveB.Text) || isDouble(txtFilmWidthThresh_PositiveB.Text))
                && (isNumberic(txtFilmWidthOffSet_PositiveB.Text) || isDouble(txtFilmWidthOffSet_PositiveB.Text))
                && (isNumberic(txtWeldWidthThresh_PositiveB.Text) || isDouble(txtWeldWidthThresh_PositiveB.Text))
                && (isNumberic(txtHeadAndTailFilmWidthThresh_PositiveB.Text) || isDouble(txtHeadAndTailFilmWidthThresh_PositiveB.Text))
                && (isNumberic(txtHeadAndTailFilmShieldLength_PositiveB.Text) || isDouble(txtHeadAndTailFilmShieldLength_PositiveB.Text))
                && (isNumberic(txtHeadAndTailFilmDetectRange_PositiveB.Text) || isDouble(txtHeadAndTailFilmDetectRange_PositiveB.Text))
                && (isNumberic(txtWaferWidth_PositiveB.Text) || isDouble(txtWaferWidth_PositiveB.Text))
                && (isNumberic(txtWidthResolution_PositiveB.Text) || isDouble(txtWidthResolution_PositiveB.Text))
                && (isNumberic(txtViceLineInterval_PositiveB.Text) || isDouble(txtViceLineInterval_PositiveB.Text))
                && (isNumberic(txtHeightResolution_PositiveB.Text) || isDouble(txtHeightResolution_PositiveB.Text))
                && (isNumberic(txtLocationWaferEdgeThresh_PositiveB.Text))
                && (isNumberic(txtWaferEdgeCalibrationRegionDilationPixel_PositiveB.Text))
                && (isNumberic(txtMinimumDistanceThresh_PositiveB.Text) || isDouble(txtMinimumDistanceThresh_PositiveB.Text))
                && (isNumberic(txtMaxDistanceThresh_PositiveB.Text) || isDouble(txtMaxDistanceThresh_PositiveB.Text))
                && (isNumberic(txtClassDistanceThresh_PositiveB.Text) || isDouble(txtClassDistanceThresh_PositiveB.Text))
                && (isNumberic(txtEdgeBigDefectWidthThresh_PositiveB.Text) || isDouble(txtEdgeBigDefectWidthThresh_PositiveB.Text))
                && (isNumberic(txtEdgeBigDefectHeightThresh_PositiveB.Text) || isDouble(txtEdgeBigDefectHeightThresh_PositiveB.Text))
                && (isNumberic(txtEdgeSmallDefectDetectDepth_PositiveB.Text) || isDouble(txtEdgeSmallDefectDetectDepth_PositiveB.Text))
                && (isNumberic(txtEdgeSmallDefectGrayThresh_PositiveB.Text))
                && (isNumberic(txtEdgeSmallDefectWidthThresh_PositiveB.Text) || isDouble(txtEdgeSmallDefectWidthThresh_PositiveB.Text))
                && (isNumberic(txtEdgeSmallDefectHeightThresh_PositiveB.Text) || isDouble(txtEdgeSmallDefectHeightThresh_PositiveB.Text))
                && (isNumberic(txtEdgeSmallDefectGrayMeanThresh_PositiveB.Text) || isDouble(txtEdgeSmallDefectGrayMeanThresh_PositiveB.Text))
                && (isNumberic(txtEdgeSmallDefectGrayDeviationThresh_PositiveB.Text) || isDouble(txtEdgeSmallDefectGrayDeviationThresh_PositiveB.Text))
                && (isNumberic(txtCornerDefectAreaRatioThresh_PositiveB.Text) || isDouble(txtCornerDefectAreaRatioThresh_PositiveB.Text))
                && (isNumberic(txtSurfaceDefectGrayThresh_PositiveB.Text))
                && (isNumberic(txtSurfaceDefectWidthThresh_PositiveB.Text) || isDouble(txtSurfaceDefectWidthThresh_PositiveB.Text))
                && (isNumberic(txtSurfaceDefectHeightThresh_PositiveB.Text) || isDouble(txtSurfaceDefectHeightThresh_PositiveB.Text))
                && (isNumberic(txtSurfaceDefectDetectIndentDepth_PositiveB.Text) || isDouble(txtSurfaceDefectDetectIndentDepth_PositiveB.Text))
                && (isNumberic(txtSurfaceDefectViceLineShieldWidth_PositiveB.Text))
                && (isNumberic(txtSurfaceDefectViceLineShieldLeftPosOffSet_PositiveB.Text))
                && (isNumberic(txtSurfaceDefectViceLineShieldRightPosOffSet_PositiveB.Text))
                && (isNumberic(txtMaxAlamClusterCount_PositiveB.Text))

                && (isNumberic(txtTopShieldLengthOfTopRegion_NegativeA.Text) || isDouble(txtTopShieldLengthOfTopRegion_NegativeA.Text))
                && (isNumberic(txtBottomShieldLengthOfTopRegion_NegativeA.Text) || isDouble(txtBottomShieldLengthOfTopRegion_NegativeA.Text))
                && (isNumberic(txtTopShieldLengthOfBottomRegion_NegativeA.Text) || isDouble(txtTopShieldLengthOfBottomRegion_NegativeA.Text))
                && (isNumberic(txtBottomShieldLengthOfBottomRegion_NegativeA.Text) || isDouble(txtBottomShieldLengthOfBottomRegion_NegativeA.Text))
                && (isNumberic(txtLocationMainLineThresh_NegativeA.Text))
                && (isNumberic(txtFilmWidthThresh_NegativeA.Text) || isDouble(txtFilmWidthThresh_NegativeA.Text))
                && (isNumberic(txtFilmWidthOffSet_NegativeA.Text) || isDouble(txtFilmWidthOffSet_NegativeA.Text))
                && (isNumberic(txtWeldWidthThresh_NegativeA.Text) || isDouble(txtWeldWidthThresh_NegativeA.Text))
                && (isNumberic(txtHeadAndTailFilmWidthThresh_NegativeA.Text) || isDouble(txtHeadAndTailFilmWidthThresh_NegativeA.Text))
                && (isNumberic(txtHeadAndTailFilmShieldLength_NegativeA.Text) || isDouble(txtHeadAndTailFilmShieldLength_NegativeA.Text))
                && (isNumberic(txtHeadAndTailFilmDetectRange_NegativeA.Text) || isDouble(txtHeadAndTailFilmDetectRange_NegativeA.Text))
                && (isNumberic(txtWaferWidth_NegativeA.Text) || isDouble(txtWaferWidth_NegativeA.Text))
                && (isNumberic(txtWidthResolution_NegativeA.Text) || isDouble(txtWidthResolution_NegativeA.Text))
                && (isNumberic(txtViceLineInterval_NegativeA.Text) || isDouble(txtViceLineInterval_NegativeA.Text))
                && (isNumberic(txtHeightResolution_NegativeA.Text) || isDouble(txtHeightResolution_NegativeA.Text))
                && (isNumberic(txtLocationWaferEdgeThresh_NegativeA.Text))
                && (isNumberic(txtWaferEdgeCalibrationRegionDilationPixel_NegativeA.Text))
                && (isNumberic(txtMinimumDistanceThresh_NegativeA.Text) || isDouble(txtMinimumDistanceThresh_NegativeA.Text))
                && (isNumberic(txtMaxDistanceThresh_NegativeA.Text) || isDouble(txtMaxDistanceThresh_NegativeA.Text))
                && (isNumberic(txtClassDistanceThresh_NegativeA.Text) || isDouble(txtClassDistanceThresh_NegativeA.Text))
                && (isNumberic(txtEdgeBigDefectWidthThresh_NegativeA.Text) || isDouble(txtEdgeBigDefectWidthThresh_NegativeA.Text))
                && (isNumberic(txtEdgeBigDefectHeightThresh_NegativeA.Text) || isDouble(txtEdgeBigDefectHeightThresh_NegativeA.Text))
                && (isNumberic(txtEdgeSmallDefectDetectDepth_NegativeA.Text) || isDouble(txtEdgeSmallDefectDetectDepth_NegativeA.Text))
                && (isNumberic(txtEdgeSmallDefectGrayThresh_NegativeA.Text))
                && (isNumberic(txtEdgeSmallDefectWidthThresh_NegativeA.Text) || isDouble(txtEdgeSmallDefectWidthThresh_NegativeA.Text))
                && (isNumberic(txtEdgeSmallDefectHeightThresh_NegativeA.Text) || isDouble(txtEdgeSmallDefectHeightThresh_NegativeA.Text))
                && (isNumberic(txtEdgeSmallDefectGrayMeanThresh_NegativeA.Text) || isDouble(txtEdgeSmallDefectGrayMeanThresh_NegativeA.Text))
                && (isNumberic(txtEdgeSmallDefectGrayDeviationThresh_NegativeA.Text) || isDouble(txtEdgeSmallDefectGrayDeviationThresh_NegativeA.Text))
                && (isNumberic(txtCornerDefectAreaRatioThresh_NegativeA.Text) || isDouble(txtCornerDefectAreaRatioThresh_NegativeA.Text))
                && (isNumberic(txtSurfaceDefectGrayThresh_NegativeA.Text))
                && (isNumberic(txtSurfaceDefectWidthThresh_NegativeA.Text) || isDouble(txtSurfaceDefectWidthThresh_NegativeA.Text))
                && (isNumberic(txtSurfaceDefectHeightThresh_NegativeA.Text) || isDouble(txtSurfaceDefectHeightThresh_NegativeA.Text))
                && (isNumberic(txtSurfaceDefectDetectIndentDepth_NegativeA.Text) || isDouble(txtSurfaceDefectDetectIndentDepth_NegativeA.Text))
                && (isNumberic(txtSurfaceDefectViceLineShieldWidth_NegativeA.Text))
                && (isNumberic(txtSurfaceDefectViceLineShieldLeftPosOffSet_NegativeA.Text))
                && (isNumberic(txtSurfaceDefectViceLineShieldRightPosOffSet_NegativeA.Text))
                && (isNumberic(txtMaxAlamClusterCount_NegativeA.Text))

                && (isNumberic(txtTopShieldLengthOfTopRegion_NegativeB.Text) || isDouble(txtTopShieldLengthOfTopRegion_NegativeB.Text))
                && (isNumberic(txtBottomShieldLengthOfTopRegion_NegativeB.Text) || isDouble(txtBottomShieldLengthOfTopRegion_NegativeB.Text))
                && (isNumberic(txtTopShieldLengthOfBottomRegion_NegativeB.Text) || isDouble(txtTopShieldLengthOfBottomRegion_NegativeB.Text))
                && (isNumberic(txtBottomShieldLengthOfBottomRegion_NegativeB.Text) || isDouble(txtBottomShieldLengthOfBottomRegion_NegativeB.Text))
                && (isNumberic(txtLocationMainLineThresh_NegativeB.Text))
                && (isNumberic(txtFilmWidthThresh_NegativeB.Text) || isDouble(txtFilmWidthThresh_NegativeB.Text))
                && (isNumberic(txtFilmWidthOffSet_NegativeB.Text) || isDouble(txtFilmWidthOffSet_NegativeB.Text))
                && (isNumberic(txtWeldWidthThresh_NegativeB.Text) || isDouble(txtWeldWidthThresh_NegativeB.Text))
                && (isNumberic(txtHeadAndTailFilmWidthThresh_NegativeB.Text) || isDouble(txtHeadAndTailFilmWidthThresh_NegativeB.Text))
                && (isNumberic(txtHeadAndTailFilmShieldLength_NegativeB.Text) || isDouble(txtHeadAndTailFilmShieldLength_NegativeB.Text))
                && (isNumberic(txtHeadAndTailFilmDetectRange_NegativeB.Text) || isDouble(txtHeadAndTailFilmDetectRange_NegativeB.Text))
                && (isNumberic(txtWaferWidth_NegativeB.Text) || isDouble(txtWaferWidth_NegativeB.Text))
                && (isNumberic(txtWidthResolution_NegativeB.Text) || isDouble(txtWidthResolution_NegativeB.Text))
                && (isNumberic(txtViceLineInterval_NegativeB.Text) || isDouble(txtViceLineInterval_NegativeB.Text))
                && (isNumberic(txtHeightResolution_NegativeB.Text) || isDouble(txtHeightResolution_NegativeB.Text))
                && (isNumberic(txtLocationWaferEdgeThresh_NegativeB.Text))
                && (isNumberic(txtWaferEdgeCalibrationRegionDilationPixel_NegativeB.Text))
                && (isNumberic(txtMinimumDistanceThresh_NegativeB.Text) || isDouble(txtMinimumDistanceThresh_NegativeB.Text))
                && (isNumberic(txtMaxDistanceThresh_NegativeB.Text) || isDouble(txtMaxDistanceThresh_NegativeB.Text))
                && (isNumberic(txtClassDistanceThresh_NegativeB.Text) || isDouble(txtClassDistanceThresh_NegativeB.Text))
                && (isNumberic(txtEdgeBigDefectWidthThresh_NegativeB.Text) || isDouble(txtEdgeBigDefectWidthThresh_NegativeB.Text))
                && (isNumberic(txtEdgeBigDefectHeightThresh_NegativeB.Text) || isDouble(txtEdgeBigDefectHeightThresh_NegativeB.Text))
                && (isNumberic(txtEdgeSmallDefectDetectDepth_NegativeB.Text) || isDouble(txtEdgeSmallDefectDetectDepth_NegativeB.Text))
                && (isNumberic(txtEdgeSmallDefectGrayThresh_NegativeB.Text))
                && (isNumberic(txtEdgeSmallDefectWidthThresh_NegativeB.Text) || isDouble(txtEdgeSmallDefectWidthThresh_NegativeB.Text))
                && (isNumberic(txtEdgeSmallDefectHeightThresh_NegativeB.Text) || isDouble(txtEdgeSmallDefectHeightThresh_NegativeB.Text))
                && (isNumberic(txtEdgeSmallDefectGrayMeanThresh_NegativeB.Text) || isDouble(txtEdgeSmallDefectGrayMeanThresh_NegativeB.Text))
                && (isNumberic(txtEdgeSmallDefectGrayDeviationThresh_NegativeB.Text) || isDouble(txtEdgeSmallDefectGrayDeviationThresh_NegativeB.Text))
                && (isNumberic(txtCornerDefectAreaRatioThresh_NegativeB.Text) || isDouble(txtCornerDefectAreaRatioThresh_NegativeB.Text))
                && (isNumberic(txtSurfaceDefectGrayThresh_NegativeB.Text))
                && (isNumberic(txtSurfaceDefectWidthThresh_NegativeB.Text) || isDouble(txtSurfaceDefectWidthThresh_NegativeB.Text))
                && (isNumberic(txtSurfaceDefectHeightThresh_NegativeB.Text) || isDouble(txtSurfaceDefectHeightThresh_NegativeB.Text))
                && (isNumberic(txtSurfaceDefectDetectIndentDepth_NegativeB.Text) || isDouble(txtSurfaceDefectDetectIndentDepth_NegativeB.Text))
                && (isNumberic(txtSurfaceDefectViceLineShieldWidth_NegativeB.Text))
                && (isNumberic(txtSurfaceDefectViceLineShieldLeftPosOffSet_NegativeB.Text))
                && (isNumberic(txtSurfaceDefectViceLineShieldRightPosOffSet_NegativeB.Text))
                && (isNumberic(txtMaxAlamClusterCount_NegativeB.Text)))
            {
                Config.WriteIniData("Config", "PassWordAdministrator", Global.passWordAdministrator, path);
                Config.WriteIniData("Config", "PassWordHandlers", Global.passWordHandlers, path);
                Config.WriteIniData("Config", "IsEnglish", Global.isEnglish, path);
                Config.WriteIniData("Config", "WaferCountPerClass", cbxWaferCountPerClass.Text, path);
                if (chkIsDalsaCam.Checked)
                {
                    Config.WriteIniData("Config", "IsDalsaCam", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsDalsaCam", "0", path);
                }
                if (cbxMainLineNum.Text !="")
                {
                    Config.WriteIniData("Config", "MainLineNum", cbxMainLineNum.Text, path);
                }
                else
                {
                    Config.WriteIniData("Config", "MainLineNum", "5", path);
                }

                if (txtMainLineDistance.Text != "")
                {
                    Config.WriteIniData("Config", "MainLineDistance", txtMainLineDistance.Text, path);
                }
                else
                {
                    Config.WriteIniData("Config", "MainLineDistance", "16.8", path);
                }
                if (cbxStringType.Text != "")
                {
                    Config.WriteIniData("Config", "StringType", cbxStringType.Text, path);
                }
                else
                {
                    Config.WriteIniData("Config", "StringType", "常规间距", path);
                }
                if (chxIsFullWafer.Checked)
                {
                    Config.WriteIniData("Config", "IsFullWafer", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsFullWafer", "0", path);
                }
                if (cbxSubMainLineNum.Text == "0")
                {
                    Config.WriteIniData("Config", "SubMainLineNum", "0", path);
                }
                else if(cbxSubMainLineNum.Text == "1")
                {
                    Config.WriteIniData("Config", "SubMainLineNum", "1", path);
                }
                else if(cbxSubMainLineNum.Text == "2")
                {
                    Config.WriteIniData("Config", "SubMainLineNum", "2", path);
                }
                else if (cbxSubMainLineNum.Text == "3")
                {
                    Config.WriteIniData("Config", "SubMainLineNum", "3", path);
                }
                if (chxIsDoubleDetect.Checked)
                {
                    Config.WriteIniData("Config", "IsDoubleDetect", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsDoubleDetect", "0", path);
                }
                if (chxIsMESFun.Checked)
                {
                    Config.WriteIniData("Config", "IsMESFun", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsMESFun", "0", path);
                }
                if (chxIsUpperLink.Checked)
                {
                    Config.WriteIniData("Config", "IsUpperLink", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUpperLink", "0", path);
                }
                #region 正面配方参数
                if (chkIsUsingWidthResolutionCalibrate_PositiveA.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingWidthResolutionCalibratePositiveA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingWidthResolutionCalibratePositiveA", "0", path);
                }
                if (chkIsUsingWidthResolutionCalibrate_PositiveB.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingWidthResolutionCalibratePositiveB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingWidthResolutionCalibratePositiveB", "0", path);
                }
                Config.WriteIniData("Config", "WidthResolutionPositiveA", txtWidthResolution_PositiveA.Text, path);
                Config.WriteIniData("Config", "WidthResolutionPositiveB", txtWidthResolution_PositiveB.Text, path);
                Config.WriteIniData("Config", "WaferWidthPositiveA", txtWaferWidth_PositiveA.Text, path);
                Config.WriteIniData("Config", "WaferWidthPositiveB", txtWaferWidth_PositiveB.Text, path);
                if (chkIsUsingHeightResolutionCalibrate_PositiveA.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingHeightResolutionCalibratePositiveA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingHeightResolutionCalibratePositiveA", "0", path);
                }
                if (chkIsUsingHeightResolutionCalibrate_PositiveB.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingHeightResolutionCalibratePositiveB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingHeightResolutionCalibratePositiveB", "0", path);
                }
                Config.WriteIniData("Config", "HeightResolutionPositiveA", txtHeightResolution_PositiveA.Text, path);
                Config.WriteIniData("Config", "HeightResolutionPositiveB", txtHeightResolution_PositiveB.Text, path);
                Config.WriteIniData("Config", "ViceLineInterval", txtViceLineInterval_PositiveA.Text, path);
                if (chkIsUsingFilmShiftingDetect_PositiveA.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingFilmShiftingDetectPositiveA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingFilmShiftingDetectPositiveA", "0", path);
                }
                if (chkIsUsingFilmShiftingDetect_PositiveB.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingFilmShiftingDetectPositiveB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingFilmShiftingDetectPositiveB", "0", path);
                }
                Config.WriteIniData("Config", "TopShieldLengthOfTopRegionPositiveA", txtTopShieldLengthOfTopRegion_PositiveA.Text, path);
                Config.WriteIniData("Config", "TopShieldLengthOfTopRegionPositiveB", txtTopShieldLengthOfTopRegion_PositiveB.Text, path);
                Config.WriteIniData("Config", "BottomShieldLengthOfTopRegionPositiveA", txtBottomShieldLengthOfTopRegion_PositiveA.Text, path);
                Config.WriteIniData("Config", "BottomShieldLengthOfTopRegionPositiveB", txtBottomShieldLengthOfTopRegion_PositiveB.Text, path);
                Config.WriteIniData("Config", "TopShieldLengthOfBottomRegionPositiveA", txtTopShieldLengthOfBottomRegion_PositiveA.Text, path);
                Config.WriteIniData("Config", "TopShieldLengthOfBottomRegionPositiveB", txtTopShieldLengthOfBottomRegion_PositiveB.Text, path);
                Config.WriteIniData("Config", "BottomShieldLengthOfBottomRegionPositiveA", txtBottomShieldLengthOfBottomRegion_PositiveA.Text, path);
                Config.WriteIniData("Config", "BottomShieldLengthOfBottomRegionPositiveB", txtBottomShieldLengthOfBottomRegion_PositiveB.Text, path);
                Config.WriteIniData("Config", "LocationMainLineThreshPositiveA", txtLocationMainLineThresh_PositiveA.Text, path);
                Config.WriteIniData("Config", "LocationMainLineThreshPositiveB", txtLocationMainLineThresh_PositiveB.Text, path);
                Config.WriteIniData("Config", "FilmWidthThreshPositiveA", txtFilmWidthThresh_PositiveA.Text, path);
                Config.WriteIniData("Config", "FilmWidthThreshPositiveB", txtFilmWidthThresh_PositiveB.Text, path);
                Config.WriteIniData("Config", "FilmWidthOffSetPositiveA", txtFilmWidthOffSet_PositiveA.Text, path);
                Config.WriteIniData("Config", "FilmWidthOffSetPositiveB", txtFilmWidthOffSet_PositiveB.Text, path);
                if (chkIsUsingFilmMissDetect_PositiveA.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingFilmMissDetectPositiveA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingFilmMissDetectPositiveA", "0", path);
                }
                if (chkIsUsingFilmMissDetect_PositiveB.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingFilmMissDetectPositiveB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingFilmMissDetectPositiveB", "0", path);
                }
                Config.WriteIniData("Config", "WeldWidthThreshPositiveA", txtWeldWidthThresh_PositiveA.Text, path);
                Config.WriteIniData("Config", "WeldWidthThreshPositiveB", txtWeldWidthThresh_PositiveB.Text, path);
                Config.WriteIniData("Config", "FirstDetectPosForTopRegionPositiveA", txtFirstDetectPosForTopRegion_PositiveA.Text, path);
                Config.WriteIniData("Config", "FirstDetectPosForTopRegionPositiveB", txtFirstDetectPosForTopRegion_PositiveB.Text, path);
                Config.WriteIniData("Config", "SecondDetectPosForTopRegionPositiveA", txtSecondDetectPosForTopRegion_PositiveA.Text, path);
                Config.WriteIniData("Config", "SecondDetectPosForTopRegionPositiveB", txtSecondDetectPosForTopRegion_PositiveB.Text, path);
                Config.WriteIniData("Config", "FirstDetectPosForBottomRegionPositiveA", txtFirstDetectPosForBottomRegion_PositiveA.Text, path);
                Config.WriteIniData("Config", "FirstDetectPosForBottomRegionPositiveB", txtFirstDetectPosForBottomRegion_PositiveB.Text, path);
                Config.WriteIniData("Config", "SecondDetectPosForBottomRegionPositiveA", txtSecondDetectPosForBottomRegion_PositiveA.Text, path);
                Config.WriteIniData("Config", "SecondDetectPosForBottomRegionPositiveB", txtSecondDetectPosForBottomRegion_PositiveB.Text, path);
                if (chkIsUsingFilmShiftingHeadAndTailDetect_PositiveA.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingHeadAndTailFilmShiftingDetectPositiveA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingHeadAndTailFilmShiftingDetectPositiveA", "0", path);
                }
                if (chkIsUsingFilmShiftingHeadAndTailDetect_PositiveB.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingHeadAndTailFilmShiftingDetectPositiveB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingHeadAndTailFilmShiftingDetectPositiveB", "0", path);
                }
                Config.WriteIniData("Config", "HeadAndTailFilmWidthThreshPositiveA", txtHeadAndTailFilmWidthThresh_PositiveA.Text, path);
                Config.WriteIniData("Config", "HeadAndTailFilmWidthThreshPositiveB", txtHeadAndTailFilmWidthThresh_PositiveB.Text, path);
                Config.WriteIniData("Config", "HeadAndTailFilmShieldLengthPositiveA", txtHeadAndTailFilmShieldLength_PositiveA.Text, path);
                Config.WriteIniData("Config", "HeadAndTailFilmShieldLengthPositiveB", txtHeadAndTailFilmShieldLength_PositiveB.Text, path);
                Config.WriteIniData("Config", "HeadAndTailFilmDetectRangePositiveA", txtHeadAndTailFilmDetectRange_PositiveA.Text, path);
                Config.WriteIniData("Config", "HeadAndTailFilmDetectRangePositiveB", txtHeadAndTailFilmDetectRange_PositiveB.Text, path);
                if (chkIsUsingWaferEdgeCalibration_PositiveA.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingWaferEdgeCalibrationPositiveA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingWaferEdgeCalibrationPositiveA", "0", path);
                }
                if (chkIsUsingWaferEdgeCalibration_PositiveB.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingWaferEdgeCalibrationPositiveB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingWaferEdgeCalibrationPositiveB", "0", path);
                }
                Config.WriteIniData("Config", "LocationWaferEdgeThreshPositiveA", txtLocationWaferEdgeThresh_PositiveA.Text, path);
                Config.WriteIniData("Config", "LocationWaferEdgeThreshPositiveB", txtLocationWaferEdgeThresh_PositiveB.Text, path);
                Config.WriteIniData("Config", "WaferEdgeCalibrationRegionDilationPixelPositiveA", txtWaferEdgeCalibrationRegionDilationPixel_PositiveA.Text, path);
                Config.WriteIniData("Config", "WaferEdgeCalibrationRegionDilationPixelPositiveB", txtWaferEdgeCalibrationRegionDilationPixel_PositiveB.Text, path);
                if (chkIsUsingDistanceDetect_PositiveA.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingDistanceDetectPositiveA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingDistanceDetectPositiveA", "0", path);
                }
                if (chkIsUsingDistanceDetect_PositiveB.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingDistanceDetectPositiveB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingDistanceDetectPositiveB", "0", path);
                }
                Config.WriteIniData("Config", "MinimumDistanceThreshPositiveA", txtMinimumDistanceThresh_PositiveA.Text, path);
                Config.WriteIniData("Config", "MinimumDistanceThreshPositiveB", txtMinimumDistanceThresh_PositiveB.Text, path);
                Config.WriteIniData("Config", "MaxDistanceThreshPositiveA", txtMaxDistanceThresh_PositiveA.Text, path);
                Config.WriteIniData("Config", "MaxDistanceThreshPositiveB", txtMaxDistanceThresh_PositiveB.Text, path);
                Config.WriteIniData("Config", "ClassDistanceThreshPositiveA", txtClassDistanceThresh_PositiveA.Text, path);
                Config.WriteIniData("Config", "ClassDistanceThreshPositiveB", txtClassDistanceThresh_PositiveB.Text, path);
                if (chkIsUsingEdgeDefectDetect_PositiveA.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingEdgeDefectDetectPositiveA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingEdgeDefectDetectPositiveA", "0", path);
                }
                if (chkIsUsingEdgeDefectDetect_PositiveB.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingEdgeDefectDetectPositiveB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingEdgeDefectDetectPositiveB", "0", path);
                }
                Config.WriteIniData("Config", "EdgeBigDefectWidthThreshPositiveA", txtEdgeBigDefectWidthThresh_PositiveA.Text, path);
                Config.WriteIniData("Config", "EdgeBigDefectWidthThreshPositiveB", txtEdgeBigDefectWidthThresh_PositiveB.Text, path);
                Config.WriteIniData("Config", "EdgeBigDefectHeightThreshPositiveA", txtEdgeBigDefectHeightThresh_PositiveA.Text, path);
                Config.WriteIniData("Config", "EdgeBigDefectHeightThreshPositiveB", txtEdgeBigDefectHeightThresh_PositiveB.Text, path);
                Config.WriteIniData("Config", "EdgeSmallDefectDetectDepthPositiveA", txtEdgeSmallDefectDetectDepth_PositiveA.Text, path);
                Config.WriteIniData("Config", "EdgeSmallDefectDetectDepthPositiveB", txtEdgeSmallDefectDetectDepth_PositiveB.Text, path);
                Config.WriteIniData("Config", "EdgeSmallDefectGrayThreshPositiveA", txtEdgeSmallDefectGrayThresh_PositiveA.Text, path);
                Config.WriteIniData("Config", "EdgeSmallDefectGrayThreshPositiveB", txtEdgeSmallDefectGrayThresh_PositiveB.Text, path);
                Config.WriteIniData("Config", "EdgeSmallDefectWidthThreshPositiveA", txtEdgeSmallDefectWidthThresh_PositiveA.Text, path);
                Config.WriteIniData("Config", "EdgeSmallDefectWidthThreshPositiveB", txtEdgeSmallDefectWidthThresh_PositiveB.Text, path);
                Config.WriteIniData("Config", "EdgeSmallDefectHeightThreshPositiveA", txtEdgeSmallDefectHeightThresh_PositiveA.Text, path);
                Config.WriteIniData("Config", "EdgeSmallDefectHeightThreshPositiveB", txtEdgeSmallDefectHeightThresh_PositiveB.Text, path);
                Config.WriteIniData("Config", "EdgeSmallDefectGrayMeanThreshPositiveA", txtEdgeSmallDefectGrayMeanThresh_PositiveA.Text, path);
                Config.WriteIniData("Config", "EdgeSmallDefectGrayMeanThreshPositiveB", txtEdgeSmallDefectGrayMeanThresh_PositiveB.Text, path);
                Config.WriteIniData("Config", "EdgeSmallDefectGrayDeviationThreshPositiveA", txtEdgeSmallDefectGrayDeviationThresh_PositiveA.Text, path);
                Config.WriteIniData("Config", "EdgeSmallDefectGrayDeviationThreshPositiveB", txtEdgeSmallDefectGrayDeviationThresh_PositiveB.Text, path);
                Config.WriteIniData("Config", "CornerDefectAreaRatioThreshPositiveA", txtCornerDefectAreaRatioThresh_PositiveA.Text, path);
                Config.WriteIniData("Config", "CornerDefectAreaRatioThreshPositiveB", txtCornerDefectAreaRatioThresh_PositiveB.Text, path);
                if (chkIsUsingSurfaceDefectDetect_PositiveA.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingSurfaceDefectDetectPositiveA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingSurfaceDefectDetectPositiveA", "0", path);
                }
                if (chkIsUsingSurfaceDefectDetect_PositiveB.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingSurfaceDefectDetectPositiveB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingSurfaceDefectDetectPositiveB", "0", path);
                }
                Config.WriteIniData("Config", "SurfaceDefectGrayThreshPositiveA", txtSurfaceDefectGrayThresh_PositiveA.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectGrayThreshPositiveB", txtSurfaceDefectGrayThresh_PositiveB.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectWidthThreshPositiveA", txtSurfaceDefectWidthThresh_PositiveA.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectWidthThreshPositiveB", txtSurfaceDefectWidthThresh_PositiveB.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectHeightThreshPositiveA", txtSurfaceDefectHeightThresh_PositiveA.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectHeightThreshPositiveB", txtSurfaceDefectHeightThresh_PositiveB.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectDetectIndentDepthPositiveA", txtSurfaceDefectDetectIndentDepth_PositiveA.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectDetectIndentDepthPositiveB", txtSurfaceDefectDetectIndentDepth_PositiveB.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectViceLineShieldWidthPositiveA", txtSurfaceDefectViceLineShieldWidth_PositiveA.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectViceLineShieldWidthPositiveB", txtSurfaceDefectViceLineShieldWidth_PositiveB.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectViceLineShieldLeftPosOffSetPositiveA", txtSurfaceDefectViceLineShieldLeftPosOffSet_PositiveA.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectViceLineShieldLeftPosOffSetPositiveB", txtSurfaceDefectViceLineShieldLeftPosOffSet_PositiveB.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectViceLineShieldRightPosOffSetPositiveA", txtSurfaceDefectViceLineShieldRightPosOffSet_PositiveA.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectViceLineShieldRightPosOffSetPositiveB", txtSurfaceDefectViceLineShieldRightPosOffSet_PositiveB.Text, path);

                if (Convert.ToInt32(txtSurfaceScratchGrayThresh_PositiveA.Text) < 128)
                {
                    Config.WriteIniData("Config", "SurfaceScratchGrayThreshPositiveA", txtSurfaceScratchGrayThresh_PositiveA.Text, path);

                }
                else
                {
                    txtSurfaceScratchGrayThresh_PositiveA.Text = "127";
                    Config.WriteIniData("Config", "SurfaceScratchGrayThreshPositiveA", txtSurfaceScratchGrayThresh_PositiveA.Text, path);

                }

                if (Convert.ToInt32(txtSurfaceScratchGrayThresh_PositiveB.Text) < 128)
                {
                    Config.WriteIniData("Config", "SurfaceScratchGrayThreshPositiveB", txtSurfaceScratchGrayThresh_PositiveB.Text, path);

                }
                else
                {
                    txtSurfaceScratchGrayThresh_PositiveB.Text = "127";
                    Config.WriteIniData("Config", "SurfaceScratchGrayThreshPositiveB", txtSurfaceScratchGrayThresh_PositiveB.Text, path);

                }
                Config.WriteIniData("Config", "SurfaceScratchWidthThreshPositiveA", txtSurfaceScratchWidthThresh_PositiveA.Text, path);
                Config.WriteIniData("Config", "SurfaceScratchWidthThreshPositiveB", txtSurfaceScratchWidthThresh_PositiveB.Text, path);
                Config.WriteIniData("Config", "SurfaceScratchHeightThreshPositiveA", txtSurfaceScratchHeightThresh_PositiveA.Text, path);
                Config.WriteIniData("Config", "SurfaceScratchHeightThreshPositiveB", txtSurfaceScratchHeightThresh_PositiveB.Text, path);
                if (chkIsUsingBrokenLineDetect_PositiveA.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingBrokenLineDetectPositiveA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingBrokenLineDetectPositiveA", "0", path);
                }
                if (chkIsUsingBrokenLineDetect_PositiveB.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingBrokenLineDetectPositiveB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingBrokenLineDetectPositiveB", "0", path);
                }
                Config.WriteIniData("Config", "BrokenLineGrayThreshPositiveA", txtBrokenLineGrayThresh_PositiveA.Text, path);
                Config.WriteIniData("Config", "BrokenLineGrayThreshPositiveB", txtBrokenLineGrayThresh_PositiveB.Text, path);
                Config.WriteIniData("Config", "BrokenLineWidthThreshPositiveA", txtBrokenLineWidthThresh_PositiveA.Text, path);
                Config.WriteIniData("Config", "BrokenLineWidthThreshPositiveB", txtBrokenLineWidthThresh_PositiveB.Text, path);
                Config.WriteIniData("Config", "BrokenLineHeightThreshPositiveA", txtBrokenLineHeightThresh_PositiveA.Text, path);
                Config.WriteIniData("Config", "BrokenLineHeightThreshPositiveB", txtBrokenLineHeightThresh_PositiveB.Text, path);
                Config.WriteIniData("Config", "BrokenLineDetectIndentDepthPositiveA", txtBrokenLineDetectIndentDepth_PositiveA.Text, path);
                Config.WriteIniData("Config", "BrokenLineDetectIndentDepthPositiveB", txtBrokenLineDetectIndentDepth_PositiveB.Text, path);
                if (chkIsUsingStartWeldingDetect_PositiveA.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingStartWeldingDetectPositiveA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingStartWeldingDetectPositiveA", "0", path);
                }
                if (chkIsUsingStartWeldingDetect_PositiveB.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingStartWeldingDetectPositiveB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingStartWeldingDetectPositiveB", "0", path);
                }
                Config.WriteIniData("Config", "StartWeldingDistanceMinThreshPositiveA", txtStartWeldingDistanceMinThresh_PositiveA.Text, path);
                Config.WriteIniData("Config", "StartWeldingDistanceMinThreshPositiveB", txtStartWeldingDistanceMinThresh_PositiveB.Text, path);
                Config.WriteIniData("Config", "StartWeldingDistanceMaxThreshPositiveA", txtStartWeldingDistanceMaxThresh_PositiveA.Text, path);
                Config.WriteIniData("Config", "StartWeldingDistanceMaxThreshPositiveB", txtStartWeldingDistanceMaxThresh_PositiveB.Text, path);
                if (chkIsUsingSurfaceColorDiffDetect_PositiveA.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingSurfaceColorDiffDetectPositiveA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingSurfaceColorDiffDetectPositiveA", "0", path);
                }
                if (chkIsUsingSurfaceColorDiffDetect_PositiveB.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingSurfaceColorDiffDetectPositiveB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingSurfaceColorDiffDetectPositiveB", "0", path);
                }
                Config.WriteIniData("Config", "SurfaceColorDiffGrayThreshPositiveA", txtSurfaceColorDiffGrayThresh_PositiveA.Text, path);
                Config.WriteIniData("Config", "SurfaceColorDiffGrayThreshPositiveB", txtSurfaceColorDiffGrayThresh_PositiveB.Text, path);

                if (chkIsSaveNGImage_PositiveA.Checked)
                {
                    Config.WriteIniData("Config", "IsSaveNGImage_PositiveA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsSaveNGImage_PositiveA", "0", path);
                }
                if (chkIsSaveNGImage_PositiveB.Checked)
                {
                    Config.WriteIniData("Config", "IsSaveNGImage_PositiveB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsSaveNGImage_PositiveB", "0", path);
                }
                if (chkIsSaveAllImage_PositiveA.Checked)
                {
                    Config.WriteIniData("Config", "IsSaveAllImage_PositiveA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsSaveAllImage_PositiveA", "0", path);
                }
                if (chkIsSaveAllImage_PositiveB.Checked)
                {
                    Config.WriteIniData("Config", "IsSaveAllImage_PositiveB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsSaveAllImage_PositiveB", "0", path);
                }
                if (chkIsSaveNGImageWithRoi_PositiveA.Checked)
                {
                    Config.WriteIniData("Config", "IsSaveNGImageWithRoi_PositiveA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsSaveNGImageWithRoi_PositiveA", "0", path);
                }
                if (chkIsSaveNGImageWithRoi_PositiveB.Checked)
                {
                    Config.WriteIniData("Config", "IsSaveNGImageWithRoi_PositiveB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsSaveNGImageWithRoi_PositiveB", "0", path);
                }
                if (chkIsUsingCamera_PositiveA.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingCamera_PositiveA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingCamera_PositiveA", "0", path);
                }
                if (chkIsUsingCamera_PositiveB.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingCamera_PositiveB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingCamera_PositiveB", "0", path);
                }
                if (chkIsUsingAlarmFunction_PositiveA.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingAlarmFunction_PositiveA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingAlarmFunction_PositiveA", "0", path);
                }
                if (chkIsUsingAlarmFunction_PositiveB.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingAlarmFunction_PositiveB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingAlarmFunction_PositiveB", "0", path);
                }
                Config.WriteIniData("Config", "MaxAlamClusterCount_PositiveA", txtMaxAlamClusterCount_PositiveA.Text, path);
                Config.WriteIniData("Config", "MaxAlamClusterCount_PositiveB", txtMaxAlamClusterCount_PositiveB.Text, path);

                //保存主界面统计参数
                Config.WriteIniData("Config", "TotalCount_PositiveA", mainForm.mfNGStatisticsInterface.lblTotalCountPositiveA.Text, path);
                Config.WriteIniData("Config", "NGTotalCount_PositiveA", mainForm.mfNGStatisticsInterface.lblNGTotalCountPositiveA.Text, path);
                Config.WriteIniData("Config", "MajorFailureCount_PositiveA", mainForm.mfNGStatisticsInterface.lblMajorFailureCountPositiveA.Text, path);
                Config.WriteIniData("Config", "FilmShiftingCount_PositiveA", mainForm.mfNGStatisticsInterface.lblFilmShiftingCountPositiveA.Text, path);
                Config.WriteIniData("Config", "FilmMissCount_PositiveA", mainForm.mfNGStatisticsInterface.lblFilmMissCountPositiveA.Text, path);
                Config.WriteIniData("Config", "FilmShiftingHeadAndTailCountPositiveA", mainForm.mfNGStatisticsInterface.lblFilmShiftingHeadAndTailCountPositiveA.Text, path);
                Config.WriteIniData("Config", "DistanceNGCount_PositiveA", mainForm.mfNGStatisticsInterface.lblDistanceNGCountPositiveA.Text, path);
                Config.WriteIniData("Config", "EdgeDefectCount_PositiveA", mainForm.mfNGStatisticsInterface.lblEdgeDefectCountPositiveA.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectCount_PositiveA", mainForm.mfNGStatisticsInterface.lblSurfaceDefectCountPositiveA.Text, path);
                Config.WriteIniData("Config", "BrokenLineCount_PositiveA", mainForm.mfNGStatisticsInterface.lblBrokenLineCountPositiveA.Text, path);
                Config.WriteIniData("Config", "StartWeldingNGCount_PositiveA", mainForm.mfNGStatisticsInterface.lblStartWeldingNGCountPositiveA.Text, path);
                Config.WriteIniData("Config", "SurfaceColorDiffCount_PositiveA", mainForm.mfNGStatisticsInterface.lblSurfaceColorDiffCountPositiveA.Text, path);

                Config.WriteIniData("Config", "TotalCount_PositiveB", mainForm.mfNGStatisticsInterface.lblTotalCountPositiveB.Text, path);
                Config.WriteIniData("Config", "NGTotalCount_PositiveB", mainForm.mfNGStatisticsInterface.lblNGTotalCountPositiveB.Text, path);
                Config.WriteIniData("Config", "MajorFailureCount_PositiveB", mainForm.mfNGStatisticsInterface.lblMajorFailureCountPositiveB.Text, path);
                Config.WriteIniData("Config", "FilmShiftingCount_PositiveB", mainForm.mfNGStatisticsInterface.lblFilmShiftingCountPositiveB.Text, path);
                Config.WriteIniData("Config", "FilmMissCount_PositiveB", mainForm.mfNGStatisticsInterface.lblFilmMissCountPositiveB.Text, path);
                Config.WriteIniData("Config", "FilmShiftingHeadAndTailCountPositiveB", mainForm.mfNGStatisticsInterface.lblFilmShiftingHeadAndTailCountPositiveB.Text, path);
                Config.WriteIniData("Config", "DistanceNGCount_PositiveB", mainForm.mfNGStatisticsInterface.lblDistanceNGCountPositiveB.Text, path);
                Config.WriteIniData("Config", "EdgeDefectCount_PositiveB", mainForm.mfNGStatisticsInterface.lblEdgeDefectCountPositiveB.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectCount_PositiveB", mainForm.mfNGStatisticsInterface.lblSurfaceDefectCountPositiveB.Text, path);
                Config.WriteIniData("Config", "BrokenLineCount_PositiveB", mainForm.mfNGStatisticsInterface.lblBrokenLineCountPositiveB.Text, path);
                Config.WriteIniData("Config", "StartWeldingNGCount_PositiveB", mainForm.mfNGStatisticsInterface.lblStartWeldingNGCountPositiveB.Text, path);
                Config.WriteIniData("Config", "SurfaceColorDiffCount_PositiveB", mainForm.mfNGStatisticsInterface.lblSurfaceColorDiffCountPositiveB.Text, path);
                #endregion

                #region 背面配方参数
                if (chkIsUsingWidthResolutionCalibrate_NegativeA.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingWidthResolutionCalibrateNegativeA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingWidthResolutionCalibrateNegativeA", "0", path);
                }
                if (chkIsUsingWidthResolutionCalibrate_NegativeB.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingWidthResolutionCalibrateNegativeB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingWidthResolutionCalibrateNegativeB", "0", path);
                }
                Config.WriteIniData("Config", "WidthResolutionNegativeA", txtWidthResolution_NegativeA.Text, path);
                Config.WriteIniData("Config", "WidthResolutionNegativeB", txtWidthResolution_NegativeB.Text, path);
                
                Config.WriteIniData("Config", "WaferWidthNegativeA", txtWaferWidth_NegativeA.Text, path);
                Config.WriteIniData("Config", "WaferWidthNegativeB", txtWaferWidth_NegativeB.Text, path);
                if (chkIsUsingHeightResolutionCalibrate_NegativeA.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingHeightResolutionCalibrateNegativeA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingHeightResolutionCalibrateNegativeA", "0", path);
                }
                if (chkIsUsingHeightResolutionCalibrate_NegativeB.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingHeightResolutionCalibrateNegativeB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingHeightResolutionCalibrateNegativeB", "0", path);
                }
                Config.WriteIniData("Config", "HeightResolutionNegativeA", txtHeightResolution_NegativeA.Text, path);
                Config.WriteIniData("Config", "HeightResolutionNegativeB", txtHeightResolution_NegativeB.Text, path);
                Config.WriteIniData("Config", "ViceLineInterval", txtViceLineInterval_NegativeA.Text, path);
                if (chkIsUsingFilmShiftingDetect_NegativeA.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingFilmShiftingDetectNegativeA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingFilmShiftingDetectNegativeA", "0", path);
                }
                if (chkIsUsingFilmShiftingDetect_NegativeB.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingFilmShiftingDetectNegativeB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingFilmShiftingDetectNegativeB", "0", path);
                }
                Config.WriteIniData("Config", "TopShieldLengthOfTopRegionNegativeA", txtTopShieldLengthOfTopRegion_NegativeA.Text, path);
                Config.WriteIniData("Config", "TopShieldLengthOfTopRegionNegativeB", txtTopShieldLengthOfTopRegion_NegativeB.Text, path);
                Config.WriteIniData("Config", "BottomShieldLengthOfTopRegionNegativeA", txtBottomShieldLengthOfTopRegion_NegativeA.Text, path);
                Config.WriteIniData("Config", "BottomShieldLengthOfTopRegionNegativeB", txtBottomShieldLengthOfTopRegion_NegativeB.Text, path);
                Config.WriteIniData("Config", "TopShieldLengthOfBottomRegionNegativeA", txtTopShieldLengthOfBottomRegion_NegativeA.Text, path);
                Config.WriteIniData("Config", "TopShieldLengthOfBottomRegionNegativeB", txtTopShieldLengthOfBottomRegion_NegativeB.Text, path);
                Config.WriteIniData("Config", "BottomShieldLengthOfBottomRegionNegativeA", txtBottomShieldLengthOfBottomRegion_NegativeA.Text, path);
                Config.WriteIniData("Config", "BottomShieldLengthOfBottomRegionNegativeB", txtBottomShieldLengthOfBottomRegion_NegativeB.Text, path);
                Config.WriteIniData("Config", "LocationMainLineThreshNegativeA", txtLocationMainLineThresh_NegativeA.Text, path);
                Config.WriteIniData("Config", "LocationMainLineThreshNegativeB", txtLocationMainLineThresh_NegativeB.Text, path);
                Config.WriteIniData("Config", "FilmWidthThreshNegativeA", txtFilmWidthThresh_NegativeA.Text, path);
                Config.WriteIniData("Config", "FilmWidthThreshNegativeB", txtFilmWidthThresh_NegativeB.Text, path);
                Config.WriteIniData("Config", "FilmWidthOffSetNegativeA", txtFilmWidthOffSet_NegativeA.Text, path);
                Config.WriteIniData("Config", "FilmWidthOffSetNegativeB", txtFilmWidthOffSet_NegativeB.Text, path);
                if (chkIsUsingFilmMissDetect_NegativeA.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingFilmMissDetectNegativeA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingFilmMissDetectNegativeA", "0", path);
                }
                if (chkIsUsingFilmMissDetect_NegativeB.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingFilmMissDetectNegativeB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingFilmMissDetectNegativeB", "0", path);
                }
                Config.WriteIniData("Config", "WeldWidthThreshNegativeA", txtWeldWidthThresh_NegativeA.Text, path);
                Config.WriteIniData("Config", "WeldWidthThreshNegativeB", txtWeldWidthThresh_NegativeB.Text, path);
                Config.WriteIniData("Config", "FirstDetectPosForTopRegionNegativeA", txtFirstDetectPosForTopRegion_NegativeA.Text, path);
                Config.WriteIniData("Config", "FirstDetectPosForTopRegionNegativeB", txtFirstDetectPosForTopRegion_NegativeB.Text, path);
                Config.WriteIniData("Config", "SecondDetectPosForTopRegionNegativeA", txtSecondDetectPosForTopRegion_NegativeA.Text, path);
                Config.WriteIniData("Config", "SecondDetectPosForTopRegionNegativeB", txtSecondDetectPosForTopRegion_NegativeB.Text, path);
                Config.WriteIniData("Config", "FirstDetectPosForBottomRegionNegativeA", txtFirstDetectPosForBottomRegion_NegativeA.Text, path);
                Config.WriteIniData("Config", "FirstDetectPosForBottomRegionNegativeB", txtFirstDetectPosForBottomRegion_NegativeB.Text, path);
                Config.WriteIniData("Config", "SecondDetectPosForBottomRegionNegativeA", txtSecondDetectPosForBottomRegion_NegativeA.Text, path);
                Config.WriteIniData("Config", "SecondDetectPosForBottomRegionNegativeB", txtSecondDetectPosForBottomRegion_NegativeB.Text, path);
                if (chkIsUsingFilmShiftingHeadAndTailDetect_NegativeA.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingHeadAndTailFilmShiftingDetectNegativeA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingHeadAndTailFilmShiftingDetectNegativeA", "0", path);
                }
                if (chkIsUsingFilmShiftingHeadAndTailDetect_NegativeB.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingHeadAndTailFilmShiftingDetectNegativeB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingHeadAndTailFilmShiftingDetectNegativeB", "0", path);
                }
                Config.WriteIniData("Config", "HeadAndTailFilmWidthThreshNegativeA", txtHeadAndTailFilmWidthThresh_NegativeA.Text, path);
                Config.WriteIniData("Config", "HeadAndTailFilmWidthThreshNegativeB", txtHeadAndTailFilmWidthThresh_NegativeB.Text, path);
                Config.WriteIniData("Config", "HeadAndTailFilmShieldLengthNegativeA", txtHeadAndTailFilmShieldLength_NegativeA.Text, path);
                Config.WriteIniData("Config", "HeadAndTailFilmShieldLengthNegativeB", txtHeadAndTailFilmShieldLength_NegativeB.Text, path);
                Config.WriteIniData("Config", "HeadAndTailFilmDetectRangeNegativeA", txtHeadAndTailFilmDetectRange_NegativeA.Text, path);
                Config.WriteIniData("Config", "HeadAndTailFilmDetectRangeNegativeB", txtHeadAndTailFilmDetectRange_NegativeB.Text, path);
                if (chkIsUsingWaferEdgeCalibration_NegativeA.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingWaferEdgeCalibrationNegativeA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingWaferEdgeCalibrationNegativeA", "0", path);
                }
                if (chkIsUsingWaferEdgeCalibration_NegativeB.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingWaferEdgeCalibrationNegativeB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingWaferEdgeCalibrationNegativeB", "0", path);
                }
                Config.WriteIniData("Config", "LocationWaferEdgeThreshNegativeA", txtLocationWaferEdgeThresh_NegativeA.Text, path);
                Config.WriteIniData("Config", "LocationWaferEdgeThreshNegativeB", txtLocationWaferEdgeThresh_NegativeB.Text, path);
                Config.WriteIniData("Config", "WaferEdgeCalibrationRegionDilationPixelNegativeA", txtWaferEdgeCalibrationRegionDilationPixel_NegativeA.Text, path);
                Config.WriteIniData("Config", "WaferEdgeCalibrationRegionDilationPixelNegativeB", txtWaferEdgeCalibrationRegionDilationPixel_NegativeB.Text, path);
                if (chkIsUsingDistanceDetect_NegativeA.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingDistanceDetectNegativeA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingDistanceDetectNegativeA", "0", path);
                }
                if (chkIsUsingDistanceDetect_NegativeB.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingDistanceDetectNegativeB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingDistanceDetectNegativeB", "0", path);
                }
                Config.WriteIniData("Config", "MinimumDistanceThreshNegativeA", txtMinimumDistanceThresh_NegativeA.Text, path);
                Config.WriteIniData("Config", "MinimumDistanceThreshNegativeB", txtMinimumDistanceThresh_NegativeB.Text, path);
                Config.WriteIniData("Config", "MaxDistanceThreshNegativeA", txtMaxDistanceThresh_NegativeA.Text, path);
                Config.WriteIniData("Config", "MaxDistanceThreshNegativeB", txtMaxDistanceThresh_NegativeB.Text, path);
                Config.WriteIniData("Config", "ClassDistanceThreshNegativeA", txtClassDistanceThresh_NegativeA.Text, path);
                Config.WriteIniData("Config", "ClassDistanceThreshNegativeB", txtClassDistanceThresh_NegativeB.Text, path);
                if (chkIsUsingEdgeDefectDetect_NegativeA.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingEdgeDefectDetectNegativeA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingEdgeDefectDetectNegativeA", "0", path);
                }
                if (chkIsUsingEdgeDefectDetect_NegativeB.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingEdgeDefectDetectNegativeB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingEdgeDefectDetectNegativeB", "0", path);
                }
                Config.WriteIniData("Config", "EdgeBigDefectWidthThreshNegativeA", txtEdgeBigDefectWidthThresh_NegativeA.Text, path);
                Config.WriteIniData("Config", "EdgeBigDefectWidthThreshNegativeB", txtEdgeBigDefectWidthThresh_NegativeB.Text, path);
                Config.WriteIniData("Config", "EdgeBigDefectHeightThreshNegativeA", txtEdgeBigDefectHeightThresh_NegativeA.Text, path);
                Config.WriteIniData("Config", "EdgeBigDefectHeightThreshNegativeB", txtEdgeBigDefectHeightThresh_NegativeB.Text, path);
                Config.WriteIniData("Config", "EdgeSmallDefectDetectDepthNegativeA", txtEdgeSmallDefectDetectDepth_NegativeA.Text, path);
                Config.WriteIniData("Config", "EdgeSmallDefectDetectDepthNegativeB", txtEdgeSmallDefectDetectDepth_NegativeB.Text, path);
                Config.WriteIniData("Config", "EdgeSmallDefectGrayThreshNegativeA", txtEdgeSmallDefectGrayThresh_NegativeA.Text, path);
                Config.WriteIniData("Config", "EdgeSmallDefectGrayThreshNegativeB", txtEdgeSmallDefectGrayThresh_NegativeB.Text, path);
                Config.WriteIniData("Config", "EdgeSmallDefectWidthThreshNegativeA", txtEdgeSmallDefectWidthThresh_NegativeA.Text, path);
                Config.WriteIniData("Config", "EdgeSmallDefectWidthThreshNegativeB", txtEdgeSmallDefectWidthThresh_NegativeB.Text, path);
                Config.WriteIniData("Config", "EdgeSmallDefectHeightThreshNegativeA", txtEdgeSmallDefectHeightThresh_NegativeA.Text, path);
                Config.WriteIniData("Config", "EdgeSmallDefectHeightThreshNegativeB", txtEdgeSmallDefectHeightThresh_NegativeB.Text, path);
                Config.WriteIniData("Config", "EdgeSmallDefectGrayMeanThreshNegativeA", txtEdgeSmallDefectGrayMeanThresh_NegativeA.Text, path);
                Config.WriteIniData("Config", "EdgeSmallDefectGrayMeanThreshNegativeB", txtEdgeSmallDefectGrayMeanThresh_NegativeB.Text, path);
                Config.WriteIniData("Config", "EdgeSmallDefectGrayDeviationThreshNegativeA", txtEdgeSmallDefectGrayDeviationThresh_NegativeA.Text, path);
                Config.WriteIniData("Config", "EdgeSmallDefectGrayDeviationThreshNegativeB", txtEdgeSmallDefectGrayDeviationThresh_NegativeB.Text, path);
                Config.WriteIniData("Config", "CornerDefectAreaRatioThreshNegativeA", txtCornerDefectAreaRatioThresh_NegativeA.Text, path);
                Config.WriteIniData("Config", "CornerDefectAreaRatioThreshNegativeB", txtCornerDefectAreaRatioThresh_NegativeB.Text, path);
                if (chkIsUsingSurfaceDefectDetect_NegativeA.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingSurfaceDefectDetectNegativeA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingSurfaceDefectDetectNegativeA", "0", path);
                }
                if (chkIsUsingSurfaceDefectDetect_NegativeB.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingSurfaceDefectDetectNegativeB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingSurfaceDefectDetectNegativeB", "0", path);
                }
                Config.WriteIniData("Config", "SurfaceDefectGrayThreshNegativeA", txtSurfaceDefectGrayThresh_NegativeA.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectGrayThreshNegativeB", txtSurfaceDefectGrayThresh_NegativeB.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectWidthThreshNegativeA", txtSurfaceDefectWidthThresh_NegativeA.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectWidthThreshNegativeB", txtSurfaceDefectWidthThresh_NegativeB.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectHeightThreshNegativeA", txtSurfaceDefectHeightThresh_NegativeA.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectHeightThreshNegativeB", txtSurfaceDefectHeightThresh_NegativeB.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectDetectIndentDepthNegativeA", txtSurfaceDefectDetectIndentDepth_NegativeA.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectDetectIndentDepthNegativeB", txtSurfaceDefectDetectIndentDepth_NegativeB.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectViceLineShieldWidthNegativeA", txtSurfaceDefectViceLineShieldWidth_NegativeA.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectViceLineShieldWidthNegativeB", txtSurfaceDefectViceLineShieldWidth_NegativeB.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectViceLineShieldLeftPosOffSetNegativeA", txtSurfaceDefectViceLineShieldLeftPosOffSet_NegativeA.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectViceLineShieldLeftPosOffSetNegativeB", txtSurfaceDefectViceLineShieldLeftPosOffSet_NegativeB.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectViceLineShieldRightPosOffSetNegativeA", txtSurfaceDefectViceLineShieldRightPosOffSet_NegativeA.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectViceLineShieldRightPosOffSetNegativeB", txtSurfaceDefectViceLineShieldRightPosOffSet_NegativeB.Text, path);
                Config.WriteIniData("Config", "SurfaceScratchGrayThreshNegativeA", txtSurfaceScratchGrayThresh_NegativeA.Text, path);
                Config.WriteIniData("Config", "SurfaceScratchGrayThreshNegativeB", txtSurfaceScratchGrayThresh_NegativeB.Text, path);
                Config.WriteIniData("Config", "SurfaceScratchWidthThreshNegativeA", txtSurfaceScratchWidthThresh_NegativeA.Text, path);
                Config.WriteIniData("Config", "SurfaceScratchWidthThreshNegativeB", txtSurfaceScratchWidthThresh_NegativeB.Text, path);
                Config.WriteIniData("Config", "SurfaceScratchHeightThreshNegativeA", txtSurfaceScratchHeightThresh_NegativeA.Text, path);
                Config.WriteIniData("Config", "SurfaceScratchHeightThreshNegativeB", txtSurfaceScratchHeightThresh_NegativeB.Text, path);
                if (chkIsUsingBrokenLineDetect_NegativeA.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingBrokenLineDetectNegativeA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingBrokenLineDetectNegativeA", "0", path);
                }
                if (chkIsUsingBrokenLineDetect_NegativeB.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingBrokenLineDetectNegativeB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingBrokenLineDetectNegativeB", "0", path);
                }
                Config.WriteIniData("Config", "BrokenLineGrayThreshNegativeA", txtBrokenLineGrayThresh_NegativeA.Text, path);
                Config.WriteIniData("Config", "BrokenLineGrayThreshNegativeB", txtBrokenLineGrayThresh_NegativeB.Text, path);
                Config.WriteIniData("Config", "BrokenLineWidthThreshNegativeA", txtBrokenLineWidthThresh_NegativeA.Text, path);
                Config.WriteIniData("Config", "BrokenLineWidthThreshNegativeB", txtBrokenLineWidthThresh_NegativeB.Text, path);
                Config.WriteIniData("Config", "BrokenLineHeightThreshNegativeA", txtBrokenLineHeightThresh_NegativeA.Text, path);
                Config.WriteIniData("Config", "BrokenLineHeightThreshNegativeB", txtBrokenLineHeightThresh_NegativeB.Text, path);
                Config.WriteIniData("Config", "BrokenLineDetectIndentDepthNegativeA", txtBrokenLineDetectIndentDepth_NegativeA.Text, path);
                Config.WriteIniData("Config", "BrokenLineDetectIndentDepthNegativeB", txtBrokenLineDetectIndentDepth_NegativeB.Text, path);
                if (chkIsUsingStartWeldingDetect_NegativeA.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingStartWeldingDetectNegativeA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingStartWeldingDetectNegativeA", "0", path);
                }
                if (chkIsUsingStartWeldingDetect_NegativeB.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingStartWeldingDetectNegativeB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingStartWeldingDetectNegativeB", "0", path);
                }
                Config.WriteIniData("Config", "StartWeldingDistanceMinThreshNegativeA", txtStartWeldingDistanceMinThresh_NegativeA.Text, path);
                Config.WriteIniData("Config", "StartWeldingDistanceMinThreshNegativeB", txtStartWeldingDistanceMinThresh_NegativeB.Text, path);
                Config.WriteIniData("Config", "StartWeldingDistanceMaxThreshNegativeA", txtStartWeldingDistanceMaxThresh_NegativeA.Text, path);
                Config.WriteIniData("Config", "StartWeldingDistanceMaxThreshNegativeB", txtStartWeldingDistanceMaxThresh_NegativeB.Text, path);
                if (chkIsUsingSurfaceColorDiffDetect_NegativeA.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingSurfaceColorDiffDetectNegativeA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingSurfaceColorDiffDetectNegativeA", "0", path);
                }
                if (chkIsUsingSurfaceColorDiffDetect_NegativeB.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingSurfaceColorDiffDetectNegativeB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingSurfaceColorDiffDetectNegativeB", "0", path);
                }
                Config.WriteIniData("Config", "SurfaceColorDiffGrayThreshNegativeA", txtSurfaceColorDiffGrayThresh_NegativeA.Text, path);
                Config.WriteIniData("Config", "SurfaceColorDiffGrayThreshNegativeB", txtSurfaceColorDiffGrayThresh_NegativeB.Text, path);

                if (chkIsSaveNGImage_NegativeA.Checked)
                {
                    Config.WriteIniData("Config", "IsSaveNGImage_NegativeA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsSaveNGImage_NegativeA", "0", path);
                }
                if (chkIsSaveNGImage_NegativeB.Checked)
                {
                    Config.WriteIniData("Config", "IsSaveNGImage_NegativeB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsSaveNGImage_NegativeB", "0", path);
                }
                if (chkIsSaveAllImage_NegativeA.Checked)
                {
                    Config.WriteIniData("Config", "IsSaveAllImage_NegativeA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsSaveAllImage_NegativeA", "0", path);
                }
                if (chkIsSaveAllImage_NegativeB.Checked)
                {
                    Config.WriteIniData("Config", "IsSaveAllImage_NegativeB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsSaveAllImage_NegativeB", "0", path);
                }
                if (chkIsSaveNGImageWithRoi_NegativeA.Checked)
                {
                    Config.WriteIniData("Config", "IsSaveNGImageWithRoi_NegativeA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsSaveNGImageWithRoi_NegativeA", "0", path);
                }
                if (chkIsSaveNGImageWithRoi_NegativeB.Checked)
                {
                    Config.WriteIniData("Config", "IsSaveNGImageWithRoi_NegativeB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsSaveNGImageWithRoi_NegativeB", "0", path);
                }
                if (chkIsUsingCamera_NegativeA.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingCamera_NegativeA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingCamera_NegativeA", "0", path);
                }
                if (chkIsUsingCamera_NegativeB.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingCamera_NegativeB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingCamera_NegativeB", "0", path);
                }
                if (chkIsUsingAlarmFunction_NegativeA.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingAlarmFunction_NegativeA", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingAlarmFunction_NegativeA", "0", path);
                }
                if (chkIsUsingAlarmFunction_NegativeB.Checked)
                {
                    Config.WriteIniData("Config", "IsUsingAlarmFunction_NegativeB", "1", path);
                }
                else
                {
                    Config.WriteIniData("Config", "IsUsingAlarmFunction_NegativeB", "0", path);
                }
                Config.WriteIniData("Config", "MaxAlamClusterCount_NegativeA", txtMaxAlamClusterCount_NegativeA.Text, path);
                Config.WriteIniData("Config", "MaxAlamClusterCount_NegativeB", txtMaxAlamClusterCount_NegativeB.Text, path);

                //保存主界面统计参数
                Config.WriteIniData("Config", "TotalCount_NegativeA", mainForm.mfNGStatisticsInterface.lblTotalCountNegativeA.Text, path);
                Config.WriteIniData("Config", "NGTotalCount_NegativeA", mainForm.mfNGStatisticsInterface.lblNGTotalCountNegativeA.Text, path);
                Config.WriteIniData("Config", "MajorFailureCount_NegativeA", mainForm.mfNGStatisticsInterface.lblMajorFailureCountNegativeA.Text, path);
                Config.WriteIniData("Config", "FilmShiftingCount_NegativeA", mainForm.mfNGStatisticsInterface.lblFilmShiftingCountNegativeA.Text, path);
                Config.WriteIniData("Config", "FilmMissCount_NegativeA", mainForm.mfNGStatisticsInterface.lblFilmMissCountNegativeA.Text, path);
                Config.WriteIniData("Config", "FilmShiftingHeadAndTailCountNegativeA", mainForm.mfNGStatisticsInterface.lblFilmShiftingHeadAndTailCountNegativeA.Text, path);
                Config.WriteIniData("Config", "DistanceNGCount_NegativeA", mainForm.mfNGStatisticsInterface.lblDistanceNGCountNegativeA.Text, path);
                Config.WriteIniData("Config", "EdgeDefectCount_NegativeA", mainForm.mfNGStatisticsInterface.lblEdgeDefectCountNegativeA.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectCount_NegativeA", mainForm.mfNGStatisticsInterface.lblSurfaceDefectCountNegativeA.Text, path);
                Config.WriteIniData("Config", "BrokenLineCount_NegativeA", mainForm.mfNGStatisticsInterface.lblBrokenLineCountNegativeA.Text, path);
                Config.WriteIniData("Config", "StartWeldingNGCount_NegativeA", mainForm.mfNGStatisticsInterface.lblStartWeldingNGCountNegativeA.Text, path);
                Config.WriteIniData("Config", "SurfaceColorDiffCount_NegativeA", mainForm.mfNGStatisticsInterface.lblSurfaceColorDiffCountNegativeA.Text, path);

                Config.WriteIniData("Config", "TotalCount_NegativeB", mainForm.mfNGStatisticsInterface.lblTotalCountNegativeB.Text, path);
                Config.WriteIniData("Config", "NGTotalCount_NegativeB", mainForm.mfNGStatisticsInterface.lblNGTotalCountNegativeB.Text, path);
                Config.WriteIniData("Config", "MajorFailureCount_NegativeB", mainForm.mfNGStatisticsInterface.lblMajorFailureCountNegativeB.Text, path);
                Config.WriteIniData("Config", "FilmShiftingCount_NegativeB", mainForm.mfNGStatisticsInterface.lblFilmShiftingCountNegativeB.Text, path);
                Config.WriteIniData("Config", "FilmMissCount_NegativeB", mainForm.mfNGStatisticsInterface.lblFilmMissCountNegativeB.Text, path);
                Config.WriteIniData("Config", "FilmShiftingHeadAndTailCountNegativeB", mainForm.mfNGStatisticsInterface.lblFilmShiftingHeadAndTailCountNegativeB.Text, path);
                Config.WriteIniData("Config", "DistanceNGCount_NegativeB", mainForm.mfNGStatisticsInterface.lblDistanceNGCountNegativeB.Text, path);
                Config.WriteIniData("Config", "EdgeDefectCount_NegativeB", mainForm.mfNGStatisticsInterface.lblEdgeDefectCountNegativeB.Text, path);
                Config.WriteIniData("Config", "SurfaceDefectCount_NegativeB", mainForm.mfNGStatisticsInterface.lblSurfaceDefectCountNegativeB.Text, path);
                Config.WriteIniData("Config", "BrokenLineCount_NegativeB", mainForm.mfNGStatisticsInterface.lblBrokenLineCountNegativeB.Text, path);
                Config.WriteIniData("Config", "StartWeldingNGCount_NegativeB", mainForm.mfNGStatisticsInterface.lblStartWeldingNGCountNegativeB.Text, path);
                Config.WriteIniData("Config", "SurfaceColorDiffCount_NegativeB", mainForm.mfNGStatisticsInterface.lblSurfaceColorDiffCountNegativeB.Text, path);
                #endregion
                if (Global.isEnglish=="0")
                {
                    MessageBox.Show("配方参数已另存！");
                }
                else
                {
                    MessageBox.Show("Recipe Has Bean Saved！");
                }
                
            }
            else
            {
                if (Global.isEnglish == "0")
                {
                    MessageBox.Show("配方输入框存在非法字符！！！");

                }
                else
                {
                    MessageBox.Show("Illegal Parameters！");
                }
                return;
            }
        }

        protected bool isNumberic(string message)
        {
            //是否为整数
            System.Text.RegularExpressions.Regex rex =
            new System.Text.RegularExpressions.Regex(@"^(\-|\+)?\d+$");

            if (rex.IsMatch(message))
            {
                return true;
            }
            else
                return false;
        }
        protected bool isDouble(string message)
        {
            //是否为浮点数
            System.Text.RegularExpressions.Regex rex =
            new System.Text.RegularExpressions.Regex(@"^(-?\d+)(\.\d+)?$");

            if (rex.IsMatch(message))
            {
                return true;
            }
            else
                return false;
        }

        private void chxIsDoubleDetect_CheckedChanged(object sender, EventArgs e)
        {
            if(chxIsDoubleDetect.Checked)
            {
                mainForm.btnMainFormNegativeInterface.Enabled = true;
            }
            else
            {
                mainForm.btnMainFormNegativeInterface.Enabled = false;
            }
        }

        public  void cbxMainLineNum_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32( cbxMainLineNum.Text )>=9 )
            {
                
                //A正面
                txtTopShieldLengthOfTopRegion_PositiveA.Enabled = false;
                txtTopShieldLengthOfBottomRegion_PositiveA.Enabled = false;
                txtBottomShieldLengthOfTopRegion_PositiveA.Enabled = false;
                txtBottomShieldLengthOfBottomRegion_PositiveA.Enabled = false;
                //txtFilmWidthOffSet_PositiveA.Enabled = false;
                txtHeadAndTailFilmShieldLength_PositiveA.Enabled = false;
                txtHeadAndTailFilmDetectRange_PositiveA.Enabled = false;
                txtWeldShieldLength_PositiveA.Enabled = false;
                //txtHeadAndTailFilmWidthThresh_PositiveA.Enabled = false;
                //groupBox3.Enabled = false;
                
                if (Global.isEnglish == "0")
                {
                    label9.Text = "检测点1Pos宽度(mm)";
                    label13.Text = "检测点2Pos宽度(mm)";
                    label10.Text = "膜/焊带缺失判断阈值";
                    label16.Text = "电池片宽度(mm)";
                }
                else
                {
                    label9.Text = "Width of Insp Point-Pos 1 (mm)";
                    label13.Text = "Width of Insp Point-Pos 2 (mm)";
                    label10.Text = "Film/Ribbon Missing Thr";
                    label16.Text = "Cell Width(mm)";
                }
                
                //B正面
                txtTopShieldLengthOfTopRegion_PositiveB.Enabled = false;
                txtTopShieldLengthOfBottomRegion_PositiveB.Enabled = false;
                txtBottomShieldLengthOfTopRegion_PositiveB.Enabled = false;
                txtBottomShieldLengthOfBottomRegion_PositiveB.Enabled = false;
                //txtFilmWidthOffSet_PositiveB.Enabled = false;
                txtHeadAndTailFilmShieldLength_PositiveB.Enabled = false;
                txtHeadAndTailFilmDetectRange_PositiveB.Enabled = false;
                txtWeldShieldLength_PositiveB.Enabled = false;
                //txtHeadAndTailFilmWidthThresh_PositiveB.Enabled = false;
                // groupBox14.Enabled = false;
                if (Global.isEnglish == "0")
                {
                    label88.Text = "检测点1Pos宽度(mm)";
                    label85.Text = "检测点2Pos宽度(mm)";
                    label87.Text = "膜/焊带缺失判断阈值";
                    label70.Text = "电池片宽度(mm)";
                }
                else
                {
                    label88.Text = "Width of Insp Point-Pos 1 (mm)";
                    label85.Text = "Width of Insp Point-Pos 2 (mm)";
                    label87.Text = "Film/Ribbon Missing Thr";
                    label70.Text = "Cell Width(mm)";
                }
                
                //A反面
                txtTopShieldLengthOfTopRegion_NegativeA.Enabled = false;
                txtTopShieldLengthOfBottomRegion_NegativeA.Enabled = false;
                txtBottomShieldLengthOfTopRegion_NegativeA.Enabled = false;
                txtBottomShieldLengthOfBottomRegion_NegativeA.Enabled = false;
                //txtFilmWidthOffSet_NegativeA.Enabled = false;
                txtHeadAndTailFilmShieldLength_NegativeA.Enabled = false;
                txtHeadAndTailFilmDetectRange_NegativeA.Enabled = false;
                //txtWeldWidthThresh_NegativeA.Enabled = false;
                //txtHeadAndTailFilmWidthThresh_NegativeA.Enabled = false;
                groupBox30.Enabled = false;
                groupBox34.Enabled = false;
                //groupBox33.Enabled = false;
                groupBox28.Enabled = false;
                groupBox13.Enabled = false;
                
                if (Global.isEnglish == "0")
                {
                    label145.Text = "检测点1Pos宽度(mm)";
                    label142.Text = "检测点2Pos宽度(mm)";
                    label144.Text = "膜/焊带缺失判断阈值";
                    label133.Text = "电池片宽度(mm)";

                    chkIsUsingFilmMissDetect_NegativeA.Text = "背面蓝色";
                }
                else
                {
                    label145.Text = "Width of Insp Point-Pos 1 (mm)";
                    label142.Text = "Width of Insp Point-Pos 2 (mm)";
                    label144.Text = "Film/Ribbon Missing Thr";
                    label133.Text = "Cell Width(mm)";

                    chkIsUsingFilmMissDetect_NegativeA.Text = "Cell Back Blue";
                }

                //B反面
                txtTopShieldLengthOfTopRegion_NegativeB.Enabled = false;
                txtTopShieldLengthOfBottomRegion_NegativeB.Enabled = false;
                txtBottomShieldLengthOfTopRegion_NegativeB.Enabled = false;
                txtBottomShieldLengthOfBottomRegion_NegativeB.Enabled = false;
                //txtFilmWidthOffSet_NegativeB.Enabled = false;
                txtHeadAndTailFilmShieldLength_NegativeB.Enabled = false;
                txtHeadAndTailFilmDetectRange_NegativeB.Enabled = false;
                //txtWeldWidthThresh_NegativeB.Enabled = false;
                //txtHeadAndTailFilmWidthThresh_NegativeB.Enabled = false;
                groupBox42.Enabled = false;
                groupBox45.Enabled = false;
                groupBox40.Enabled = false;
                //groupBox44.Enabled = false;
                groupBox29.Enabled = false;
             
                if (Global.isEnglish == "0")
                {
                    label195.Text = "检测点1Pos宽度(mm)";
                    label192.Text = "检测点2Pos宽度(mm)";
                    label194.Text = "膜/焊带缺失判断阈值";
                    label183.Text = "电池片宽度(mm)";
                    chkIsUsingFilmMissDetect_NegativeB.Text = "背面蓝色";
                }
                else
                {
                    label195.Text = "Width of Insp Point-Pos 1 (mm)";
                    label192.Text = "Width of Insp Point-Pos 2 (mm)";
                    label194.Text = "Film/Ribbon Missing Thr";
                    label183.Text = "Cell Width(mm)";

                    chkIsUsingFilmMissDetect_NegativeB.Text = "Cell Back Blue";
                }
            }
            else
            {
                //A正面
                txtTopShieldLengthOfTopRegion_PositiveA.Enabled = true;
                txtTopShieldLengthOfBottomRegion_PositiveA.Enabled = true;
                txtBottomShieldLengthOfTopRegion_PositiveA.Enabled = true;
                txtBottomShieldLengthOfBottomRegion_PositiveA.Enabled = true;
                txtFilmWidthOffSet_PositiveA.Enabled = true;
                txtHeadAndTailFilmShieldLength_PositiveA.Enabled = true;
                txtHeadAndTailFilmDetectRange_PositiveA.Enabled = true;
                txtWeldShieldLength_PositiveA.Enabled = true;
                //txtHeadAndTailFilmWidthThresh_PositiveA.Enabled = true ;
                //groupBox3.Enabled = true;
                if (Global.isEnglish == "0")
                {
                    label9.Text = "贴膜宽度阈值(mm)";
                    label13.Text = "头尾贴膜宽度阈值(mm)";
                    label10.Text = "贴膜宽度补偿值(mm)";
                    label16.Text = "主栅线宽度(mm)";
                }
                else
                {
                    label9.Text = "Film Width Thr (mm)";
                    label13.Text = "H/T Film Width Thr (mm)";
                    label10.Text = "Film Width Comp. (mm)";
                    label16.Text = "Busbar Width(mm)";
                }
               
                //B正面
                txtTopShieldLengthOfTopRegion_PositiveB.Enabled = true;
                txtTopShieldLengthOfBottomRegion_PositiveB.Enabled = true;
                txtBottomShieldLengthOfTopRegion_PositiveB.Enabled = true;
                txtBottomShieldLengthOfBottomRegion_PositiveB.Enabled = true;
                txtFilmWidthOffSet_PositiveB.Enabled = true;
                txtHeadAndTailFilmShieldLength_PositiveB.Enabled = true;
                txtHeadAndTailFilmDetectRange_PositiveB.Enabled = true;
                txtWeldShieldLength_PositiveB.Enabled = true ;
                //txtHeadAndTailFilmWidthThresh_PositiveB.Enabled = true ;
                //groupBox14.Enabled = true;
                if (Global.isEnglish == "0")
                {
                    label88.Text = "贴膜宽度阈值(mm)";
                    label85.Text = "头尾贴膜宽度阈值(mm)";
                    label87.Text = "贴膜宽度补偿值(mm)";
                    label70.Text = "主栅线宽度(mm)";
                }
                else
                {
                    label88.Text = "Film Width Thr (mm)";
                    label85.Text = "H/T Film Width Thr (mm)";
                    label87.Text = "Film Width Comp. (mm)";
                    label70.Text = "BusBar Width(mm)";
                }
                
                //A反面
                txtTopShieldLengthOfTopRegion_NegativeA.Enabled = true;
                txtTopShieldLengthOfBottomRegion_NegativeA.Enabled = true;
                txtBottomShieldLengthOfTopRegion_NegativeA.Enabled = true;
                txtBottomShieldLengthOfBottomRegion_NegativeA.Enabled = true;
                txtFilmWidthOffSet_NegativeA.Enabled = true;
                txtHeadAndTailFilmShieldLength_NegativeA.Enabled = true;
                txtHeadAndTailFilmDetectRange_NegativeA.Enabled = true;
                txtWeldWidthThresh_NegativeA.Enabled = true;
                txtHeadAndTailFilmWidthThresh_NegativeA.Enabled = true;
                groupBox30.Enabled = true;
                groupBox34.Enabled = true;
                groupBox33.Enabled = true;
                groupBox28.Enabled = true;
                groupBox13.Enabled = true;
                if (Global.isEnglish == "0")
                {
                    label145.Text = "贴膜宽度阈值(mm)";
                    label142.Text = "头尾贴膜宽度阈值(mm)";
                    label144.Text = "贴膜宽度补偿值(mm)";
                    label133.Text = "主栅线宽度(mm)";
                }
                else
                {
                    label145.Text = "Film Width Thr (mm)";
                    label142.Text = "H/T Film Width Thr (mm)";
                    label144.Text = "Film Width Comp. (mm)";
                    label133.Text = "Busbar Width(mm)";
                }
                //B反面
                txtTopShieldLengthOfTopRegion_NegativeB.Enabled = true;
                txtTopShieldLengthOfBottomRegion_NegativeB.Enabled = true;
                txtBottomShieldLengthOfTopRegion_NegativeB.Enabled = true;
                txtBottomShieldLengthOfBottomRegion_NegativeB.Enabled = true;
                txtFilmWidthOffSet_NegativeB.Enabled = true;
                txtHeadAndTailFilmShieldLength_NegativeB.Enabled = true;
                txtHeadAndTailFilmDetectRange_NegativeB.Enabled = true;
                txtWeldWidthThresh_NegativeB.Enabled = true;
                txtHeadAndTailFilmWidthThresh_NegativeB.Enabled = true;
                groupBox42.Enabled = true;
                groupBox45.Enabled = true;
                groupBox40.Enabled = true;
                groupBox44.Enabled = true;
                groupBox29.Enabled = true;
                if (Global.isEnglish == "0")
                {
                    label195.Text = "贴膜宽度阈值(mm)";
                    label192.Text = "头尾贴膜宽度阈值(mm)";
                    label194.Text = "贴膜宽度补偿值(mm)";
                    label183.Text = "主栅线宽度(mm)";
                }
                else
                {
                    label195.Text = "Film Width Thr (mm)";
                    label192.Text = "H/T Film Width Thr (mm)";
                    label194.Text = "Film Width Comp. (mm)";
                    label183.Text = "Busbar Width(mm)";
                }
            }
        }

        private void btnOpenChangeLog_Click(object sender, EventArgs e)
        {
            string path = "D:/Program Files/Config/033/参数修改日志.txt";
           if (File.Exists(path) == true)
            {
                System.Diagnostics.Process.Start(path);
            }
        }

        private void btnWeldWidthThresh_PositiveA_Help_Click(object sender, EventArgs e)
        {

        }

        private void chkIsSaveNGImageWithRoi_PositiveA_CheckedChanged(object sender, EventArgs e)
        {
            if(chkIsSaveNGImageWithRoi_PositiveA.Checked)
            {
                chkIsSaveNGImage_PositiveA.Checked = true;
            }
        }

        private void chkIsSaveNGImageWithRoi_PositiveB_CheckedChanged(object sender, EventArgs e)
        {
            if(chkIsSaveNGImageWithRoi_PositiveB.Checked)
            {
                chkIsSaveNGImage_PositiveB.Checked = true;
            }
        }
    }
}
