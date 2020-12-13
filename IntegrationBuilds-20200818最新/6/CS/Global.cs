using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _6
{
    class Global
    {
        /**********************主操作界面变量***********************/
        //用户类型
        public static string userType;
        //管理员密码
        public static string passWordAdministrator;
        //操作工密码
        public static string passWordHandlers;
        //是否切换英文界面
        public static string isEnglish;
        //单串片数
        public static string waferCountPerClass;
        /*********************检测配方变量************************/
        public static string isDalsaCam;//0表示是大华，1表示是DALSA
        //栅线数量：4-四栅；5-五栅；9-MBB9；12-MBB12。
        public static string mainLineNum;
        //电池片完整类型：false-半片；true-全片
        public static string isFullWafer;
        //是否为纵向双细栅电池片
        public static string subMainLineNum;
        //是否为双面串检
        public static string isDoubleDetect;
        //是否MES
        public static string isMESFun;
        //是否采用上位链路
        public static string isUpperLink;
        //主栅线间距
        public static string mainLineDistance;
        //电池串类型
        public static string stringType;
        //是否启用宽度分辨率校准
        public static string isUsingWidthResolutionCalibratePositiveA;
        public static string isUsingWidthResolutionCalibratePositiveB;
        public static string isUsingWidthResolutionCalibrateNegativeA;
        public static string isUsingWidthResolutionCalibrateNegativeB;
        //宽度分辨率
        public static string widthResolutionPositiveA;
        public static string widthResolutionPositiveB;
        public static string widthResolutionNegativeA;
        public static string widthResolutionNegativeB;
        //硅片宽度(单位mm)
        public static string waferWidth;
        public static string waferWidthPositiveA;
        public static string waferWidthPositiveB;
        public static string waferWidthNegativeA;
        public static string waferWidthNegativeB;
        //是否启用高度分辨率校准
        public static string isUsingHeightResolutionCalibratePositiveA;
        public static string isUsingHeightResolutionCalibratePositiveB;
        public static string isUsingHeightResolutionCalibrateNegativeA;
        public static string isUsingHeightResolutionCalibrateNegativeB;
        //高度分辨率
        public static string heightResolutionPositiveA;
        public static string heightResolutionPositiveB;
        public static string heightResolutionNegativeA;
        public static string heightResolutionNegativeB;
        //****新增参数*******
        //副栅线间距(单位mm)
        public static string viceLineInterval;

        //是否启用膜偏、露白检测
        public static string isUsingFilmShiftingDetectPositiveA;
        public static string isUsingFilmShiftingDetectPositiveB;
        public static string isUsingFilmShiftingDetectNegativeA;
        public static string isUsingFilmShiftingDetectNegativeB;
        //*****新增参数*******
        //屏蔽区域(mm)
        public static string topShieldLengthOfTopRegionPositiveA;
        public static string topShieldLengthOfTopRegionPositiveB;
        public static string topShieldLengthOfTopRegionNegativeA;
        public static string topShieldLengthOfTopRegionNegativeB;
        public static string bottomShieldLengthOfTopRegionPositiveA;
        public static string bottomShieldLengthOfTopRegionPositiveB;
        public static string bottomShieldLengthOfTopRegionNegativeA;
        public static string bottomShieldLengthOfTopRegionNegativeB;
        public static string topShieldLengthOfBottomRegionPositiveA;
        public static string topShieldLengthOfBottomRegionPositiveB;
        public static string topShieldLengthOfBottomRegionNegativeA;
        public static string topShieldLengthOfBottomRegionNegativeB;
        public static string bottomShieldLengthOfBottomRegionPositiveA;
        public static string bottomShieldLengthOfBottomRegionPositiveB;
        public static string bottomShieldLengthOfBottomRegionNegativeA;
        public static string bottomShieldLengthOfBottomRegionNegativeB;
        //*******************
        //主栅线定位阈值
        public static string locationMainLineThreshPositiveA;
        public static string locationMainLineThreshPositiveB;
        public static string locationMainLineThreshNegativeA;
        public static string locationMainLineThreshNegativeB;
        //贴膜宽度阈值(mm)
        public static string filmWidthThreshPositiveA;
        public static string filmWidthThreshPositiveB;
        public static string filmWidthThreshNegativeA;
        public static string filmWidthThreshNegativeB;
        //贴膜宽度补偿值(mm)
        public static string filmWidthOffSetPositiveA;
        public static string filmWidthOffSetPositiveB;
        public static string filmWidthOffSetNegativeA;
        public static string filmWidthOffSetNegativeB;
        //是否启用膜短、膜缺失检测
        public static string isUsingFilmMissDetectPositiveA;
        public static string isUsingFilmMissDetectPositiveB;
        public static string isUsingFilmMissDetectNegativeA;
        public static string isUsingFilmMissDetectNegativeB;
        //焊带宽度阈值(mm)
        public static string weldWidthThreshPositiveA;
        public static string weldWidthThreshPositiveB;
        public static string weldWidthThreshNegativeA;
        public static string weldWidthThreshNegativeB;
        //膜短膜缺失屏蔽距离(mm)
        public static string weldShieldLengthPositiveA;
        public static string weldShieldLengthPositiveB;
        public static string weldShieldLengthNegativeA;
        public static string weldShieldLengthNegativeB;
        //MBB九栅焊带检测参数
        //上半片头部大矩形检测位置(mm)
        public static string firstDetectPosForTopRegionPositiveA;
        public static string firstDetectPosForTopRegionPositiveB;
        public static string firstDetectPosForTopRegionNegativeA;
        public static string firstDetectPosForTopRegionNegativeB;
        //上半片靠近头部第一段窄区域检测位置(mm)
        public static string secondDetectPosForTopRegionPositiveA;
        public static string secondDetectPosForTopRegionPositiveB;
        public static string secondDetectPosForTopRegionNegativeA;
        public static string secondDetectPosForTopRegionNegativeB;
        //下半片头部大矩形区域检测位置(mm)
        public static string firstDetectPosForBottomRegionPositiveA;
        public static string firstDetectPosForBottomRegionPositiveB;
        public static string firstDetectPosForBottomRegionNegativeA;
        public static string firstDetectPosForBottomRegionNegativeB;
        //下半片靠近头部第一段窄区域检测位置(mm)
        public static string secondDetectPosForBottomRegionPositiveA;
        public static string secondDetectPosForBottomRegionPositiveB;
        public static string secondDetectPosForBottomRegionNegativeA;
        public static string secondDetectPosForBottomRegionNegativeB;


        //是否启用头尾膜检
        public static string isUsingHeadAndTailFilmShiftingDetectPositiveA;
        public static string isUsingHeadAndTailFilmShiftingDetectPositiveB;
        public static string isUsingHeadAndTailFilmShiftingDetectNegativeA;
        public static string isUsingHeadAndTailFilmShiftingDetectNegativeB;
        //头尾膜检宽度阈值(mm)
        public static string headAndTailFilmWidthThreshPositiveA;
        public static string headAndTailFilmWidthThreshPositiveB;
        public static string headAndTailFilmWidthThreshNegativeA;
        public static string headAndTailFilmWidthThreshNegativeB;
        //头尾膜检缩进距离(mm)
        public static string headAndTailFilmShieldLengthPositiveA;
        public static string headAndTailFilmShieldLengthPositiveB;
        public static string headAndTailFilmShieldLengthNegativeA;
        public static string headAndTailFilmShieldLengthNegativeB;
        //头尾膜检范围(mm)
        public static string headAndTailFilmDetectRangePositiveA;
        public static string headAndTailFilmDetectRangePositiveB;
        public static string headAndTailFilmDetectRangeNegativeA;
        public static string headAndTailFilmDetectRangeNegativeB;

        //是否开启上、下电池片Region边缘优化
        public static string isUsingWaferEdgeCalibrationPositiveA;
        public static string isUsingWaferEdgeCalibrationPositiveB;
        public static string isUsingWaferEdgeCalibrationNegativeA;
        public static string isUsingWaferEdgeCalibrationNegativeB;
        //上、下电池片Region边缘优化定位灰度差值
        public static string locationWaferEdgeThreshPositiveA;
        public static string locationWaferEdgeThreshPositiveB;
        public static string locationWaferEdgeThreshNegativeA;
        public static string locationWaferEdgeThreshNegativeB;
        //上、下电池片Region边缘优化区域膨胀像素
        public static string waferEdgeCalibrationRegionDilationPixelPositiveA;
        public static string waferEdgeCalibrationRegionDilationPixelPositiveB;
        public static string waferEdgeCalibrationRegionDilationPixelNegativeA;
        public static string waferEdgeCalibrationRegionDilationPixelNegativeB;

        //是否启用片间距检测
        public static string isUsingDistanceDetectPositiveA;
        public static string isUsingDistanceDetectPositiveB;
        public static string isUsingDistanceDetectNegativeA;
        public static string isUsingDistanceDetectNegativeB;
        //最小片间距阈值(mm)
        public static string minimumDistanceThreshPositiveA;
        public static string minimumDistanceThreshPositiveB;
        public static string minimumDistanceThreshNegativeA;
        public static string minimumDistanceThreshNegativeB;
        //最大片间距阈值(mm)
        public static string maxDistanceThreshPositiveA;
        public static string maxDistanceThreshPositiveB;
        public static string maxDistanceThreshNegativeA;
        public static string maxDistanceThreshNegativeB;
        //最小串间距阈值(mm)
        public static string classDistanceThreshPositiveA;
        public static string classDistanceThreshPositiveB;
        public static string classDistanceThreshNegativeA;
        public static string classDistanceThreshNegativeB;

        //是否启用边缺陷检测
        public static string isUsingEdgeDefectDetectPositiveA;
        public static string isUsingEdgeDefectDetectPositiveB;
        public static string isUsingEdgeDefectDetectNegativeA;
        public static string isUsingEdgeDefectDetectNegativeB;
        //边缘大缺陷宽度阈值(mm)
        public static string edgeBigDefectWidthThreshPositiveA;
        public static string edgeBigDefectWidthThreshPositiveB;
        public static string edgeBigDefectWidthThreshNegativeA;
        public static string edgeBigDefectWidthThreshNegativeB;
        //边缘大缺陷高度阈值(mm)
        public static string edgeBigDefectHeightThreshPositiveA;
        public static string edgeBigDefectHeightThreshPositiveB;
        public static string edgeBigDefectHeightThreshNegativeA;
        public static string edgeBigDefectHeightThreshNegativeB;
        //边缘小缺陷检测深度(mm)
        public static string edgeSmallDefectDetectDepthPositiveA;
        public static string edgeSmallDefectDetectDepthPositiveB;
        public static string edgeSmallDefectDetectDepthNegativeA;
        public static string edgeSmallDefectDetectDepthNegativeB;
        //边缘小缺陷与周围背景像素灰度差阈值
        public static string edgeSmallDefectGrayThreshPositiveA;
        public static string edgeSmallDefectGrayThreshPositiveB;
        public static string edgeSmallDefectGrayThreshNegativeA;
        public static string edgeSmallDefectGrayThreshNegativeB;
        //边缘小缺陷宽度阈值(mm)
        public static string edgeSmallDefectWidthThreshPositiveA;
        public static string edgeSmallDefectWidthThreshPositiveB;
        public static string edgeSmallDefectWidthThreshNegativeA;
        public static string edgeSmallDefectWidthThreshNegativeB;
        //边缘小缺陷高度阈值(mm)
        public static string edgeSmallDefectHeightThreshPositiveA;
        public static string edgeSmallDefectHeightThreshPositiveB;
        public static string edgeSmallDefectHeightThreshNegativeA;
        public static string edgeSmallDefectHeightThreshNegativeB;
        //边缘小缺陷灰度均值阈值
        public static string edgeSmallDefectGrayMeanThreshPositiveA;
        public static string edgeSmallDefectGrayMeanThreshPositiveB;
        public static string edgeSmallDefectGrayMeanThreshNegativeA;
        public static string edgeSmallDefectGrayMeanThreshNegativeB;
        //边缘小缺陷灰度方差阈值
        public static string edgeSmallDefectGrayDeviationThreshPositiveA;
        public static string edgeSmallDefectGrayDeviationThreshPositiveB;
        public static string edgeSmallDefectGrayDeviationThreshNegativeA;
        public static string edgeSmallDefectGrayDeviationThreshNegativeB;
        //角部缺陷阈值(边缘小缺陷检测深度*边缘小缺陷检测深度)：单晶默认0.7；多晶默认0.5
        public static string cornerDefectAreaRatioThreshPositiveA;
        public static string cornerDefectAreaRatioThreshPositiveB;
        public static string cornerDefectAreaRatioThreshNegativeA;
        public static string cornerDefectAreaRatioThreshNegativeB;

        //是否启用表面缺陷检测
        public static string isUsingSurfaceDefectDetectPositiveA;
        public static string isUsingSurfaceDefectDetectPositiveB;
        public static string isUsingSurfaceDefectDetectNegativeA;
        public static string isUsingSurfaceDefectDetectNegativeB;
        //表面缺陷与周围背景像素灰度差阈值
        public static string surfaceDefectGrayThreshPositiveA;
        public static string surfaceDefectGrayThreshPositiveB;
        public static string surfaceDefectGrayThreshNegativeA;
        public static string surfaceDefectGrayThreshNegativeB;
        //表面缺陷宽度阈值(mm)
        public static string surfaceDefectWidthThreshPositiveA;
        public static string surfaceDefectWidthThreshPositiveB;
        public static string surfaceDefectWidthThreshNegativeA;
        public static string surfaceDefectWidthThreshNegativeB;
        //表面缺陷高度阈值(mm)
        public static string surfaceDefectHeightThreshPositiveA;
        public static string surfaceDefectHeightThreshPositiveB;
        public static string surfaceDefectHeightThreshNegativeA;
        public static string surfaceDefectHeightThreshNegativeB;
        //表面缺陷缩进距离(mm)
        public static string surfaceDefectDetectIndentDepthPositiveA;
        public static string surfaceDefectDetectIndentDepthPositiveB;
        public static string surfaceDefectDetectIndentDepthNegativeA;
        public static string surfaceDefectDetectIndentDepthNegativeB;
        //纵向栅线屏蔽像素
        public static string surfaceDefectViceLineShieldWidthPositiveA;
        public static string surfaceDefectViceLineShieldWidthPositiveB;
        public static string surfaceDefectViceLineShieldWidthNegativeA;
        public static string surfaceDefectViceLineShieldWidthNegativeB;
        //纵向栅线屏蔽左侧位置补偿
        public static string surfaceDefectViceLineShieldLeftPosOffSetPositiveA;
        public static string surfaceDefectViceLineShieldLeftPosOffSetPositiveB;
        public static string surfaceDefectViceLineShieldLeftPosOffSetNegativeA;
        public static string surfaceDefectViceLineShieldLeftPosOffSetNegativeB;
        //纵向栅线屏蔽右侧位置补偿
        public static string surfaceDefectViceLineShieldRightPosOffSetPositiveA;
        public static string surfaceDefectViceLineShieldRightPosOffSetPositiveB;
        public static string surfaceDefectViceLineShieldRightPosOffSetNegativeA;
        public static string surfaceDefectViceLineShieldRightPosOffSetNegativeB;
        //*表面划痕与周围背景像素灰度差阈值
        public static string surfaceScratchGrayThreshPositiveA;
        public static string surfaceScratchGrayThreshPositiveB;
        public static string surfaceScratchGrayThreshNegativeA;
        public static string surfaceScratchGrayThreshNegativeB;
        //表面划痕宽度阈值(mm)
        public static string surfaceScratchWidthThreshPositiveA;
        public static string surfaceScratchWidthThreshPositiveB;
        public static string surfaceScratchWidthThreshNegativeA;
        public static string surfaceScratchWidthThreshNegativeB;
        //表面划痕高度阈值(mm)
        public static string surfaceScratchHeightThreshPositiveA;
        public static string surfaceScratchHeightThreshPositiveB;
        public static string surfaceScratchHeightThreshNegativeA;
        public static string surfaceScratchHeightThreshNegativeB;

        //是否启用断栅、氧化检测
        public static string isUsingBrokenLineDetectPositiveA;
        public static string isUsingBrokenLineDetectPositiveB;
        public static string isUsingBrokenLineDetectNegativeA;
        public static string isUsingBrokenLineDetectNegativeB;
        //断栅与周围背景像素灰度差阈值
        public static string brokenLineGrayThreshPositiveA;
        public static string brokenLineGrayThreshPositiveB;
        public static string brokenLineGrayThreshNegativeA;
        public static string brokenLineGrayThreshNegativeB;
        //断栅宽度阈值(mm)
        public static string brokenLineWidthThreshPositiveA;
        public static string brokenLineWidthThreshPositiveB;
        public static string brokenLineWidthThreshNegativeA;
        public static string brokenLineWidthThreshNegativeB;
        //断栅高度阈值(mm)
        public static string brokenLineHeightThreshPositiveA;
        public static string brokenLineHeightThreshPositiveB;
        public static string brokenLineHeightThreshNegativeA;
        public static string brokenLineHeightThreshNegativeB;
        //断栅检测缩进距离(mm)
        public static string brokenLineDetectIndentDepthPositiveA;
        public static string brokenLineDetectIndentDepthPositiveB;
        public static string brokenLineDetectIndentDepthNegativeA;
        public static string brokenLineDetectIndentDepthNegativeB;

        //是否启用起焊点检测
        public static string isUsingStartWeldingDetectPositiveA;
        public static string isUsingStartWeldingDetectPositiveB;
        public static string isUsingStartWeldingDetectNegativeA;
        public static string isUsingStartWeldingDetectNegativeB;
        //起焊点距边界最大距离阈值
        public static string startWeldingDistanceMaxThreshPositiveA;
        public static string startWeldingDistanceMaxThreshPositiveB;
        public static string startWeldingDistanceMaxThreshNegativeA;
        public static string startWeldingDistanceMaxThreshNegativeB;
        //起焊点距边界最小距离阈值
        public static string startWeldingDistanceMinThreshPositiveA;
        public static string startWeldingDistanceMinThreshPositiveB;
        public static string startWeldingDistanceMinThreshNegativeA;
        public static string startWeldingDistanceMinThreshNegativeB;

        //是否启用色差检测
        public static string isUsingSurfaceColorDiffDetectPositiveA;
        public static string isUsingSurfaceColorDiffDetectPositiveB;
        public static string isUsingSurfaceColorDiffDetectNegativeA;
        public static string isUsingSurfaceColorDiffDetectNegativeB;
        //色差灰度差阈值
        public static string surfaceColorDiffGrayThreshPositiveA;
        public static string surfaceColorDiffGrayThreshPositiveB;
        public static string surfaceColorDiffGrayThreshNegativeA;
        public static string surfaceColorDiffGrayThreshNegativeB;

        //是否保存图片
        public static string isSaveNGImage_PositiveA;
        public static string isSaveNGImage_PositiveB;
        public static string isSaveNGImage_NegativeA;
        public static string isSaveNGImage_NegativeB;
        public static string isSaveAllImage_PositiveA;
        public static string isSaveAllImage_PositiveB;
        public static string isSaveAllImage_NegativeA;
        public static string isSaveAllImage_NegativeB;
        public static string isSaveNGImageWithRoi_PositiveA;
        public static string isSaveNGImageWithRoi_PositiveB;
        public static string isSaveNGImageWithRoi_NegativeA;
        public static string isSaveNGImageWithRoi_NegativeB;
        //是否启用相机
        public static string isUsingCamera_PositiveA;
        public static string isUsingCamera_PositiveB;
        public static string isUsingCamera_NegativeA;
        public static string isUsingCamera_NegativeB;
        //重大故障串报警
        public static string isUsingAlarmFunction_PositiveA;
        public static string isUsingAlarmFunction_PositiveB;
        public static string isUsingAlarmFunction_NegativeA;
        public static string isUsingAlarmFunction_NegativeB;
        public static string maxAlamClusterCount_PositiveA;
        public static string maxAlamClusterCount_PositiveB;
        public static string maxAlamClusterCount_NegativeA;
        public static string maxAlamClusterCount_NegativeB;


        /**********************主界面数据统计***********************/
        //串总数
        public static string TotalCount_PositiveA, TotalCount_PositiveB;
        public static string TotalCount_NegativeA, TotalCount_NegativeB;
        //NG串总数
        public static string NGTotalCount_PositiveA, NGTotalCount_PositiveB;
        public static string NGTotalCount_NegativeA, NGTotalCount_NegativeB;
        //重大故障串数
        public static string MajorFailureCount_PositiveA, MajorFailureCount_PositiveB;
        public static string MajorFailureCount_NegativeA, MajorFailureCount_NegativeB;
        //膜偏/露白串数
        public static string FilmShiftingCount_PositiveA, FilmShiftingCount_PositiveB;
        public static string FilmShiftingCount_NegativeA, FilmShiftingCount_NegativeB;
        //膜缺失总数
        public static string FilmMissCount_PositiveA, FilmMissCount_PositiveB;
        public static string FilmMissCount_NegativeA, FilmMissCount_NegativeB;
        //头尾膜偏串总数
        public static string FilmShiftingHeadAndTailCountPositiveA, FilmShiftingHeadAndTailCountPositiveB;
        public static string FilmShiftingHeadAndTailCountNegativeA, FilmShiftingHeadAndTailCountNegativeB;
        //片间距NG总串
        public static string DistanceNGCount_PositiveA, DistanceNGCount_PositiveB;
        public static string DistanceNGCount_NegativeA, DistanceNGCount_NegativeB;
        //边角缺陷总串数
        public static string EdgeDefectCount_PositiveA, EdgeDefectCount_PositiveB;
        public static string EdgeDefectCount_NegativeA, EdgeDefectCount_NegativeB;
        //表面缺陷总串数
        public static string SurfaceDefectCount_PositiveA, SurfaceDefectCount_PositiveB;
        public static string SurfaceDefectCount_NegativeA, SurfaceDefectCount_NegativeB;
        //断栅总串数
        public static string BrokenLineCount_PositiveA, BrokenLineCount_PositiveB;
        public static string BrokenLineCount_NegativeA, BrokenLineCount_NegativeB;
        //起焊点异常串数
        public static string StartWeldingNGCount_PositiveA, StartWeldingNGCount_PositiveB;
        public static string StartWeldingNGCount_NegativeA, StartWeldingNGCount_NegativeB;
        //表面色差总串数
        public static string SurfaceColorDiffCount_PositiveA, SurfaceColorDiffCount_PositiveB;
        public static string SurfaceColorDiffCount_NegativeA, SurfaceColorDiffCount_NegativeB;

        //公有方法
        public static void SaveLog(string filePath, string msg)
        {
            FileStream fs = null;
            string fn = filePath;
            try
            {
                fs = new FileStream(fn, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                msg += "\r\n";
                fs.Seek(0, SeekOrigin.End);
                fs.Write(Encoding.Default.GetBytes(msg), 0, Encoding.Default.GetBytes(msg).Length);
            }
            catch { }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
