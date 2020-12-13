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
    public partial class MainFormStatisticsInterface : UserControl
    {
        MainForm mainForm;

        public MainFormStatisticsInterface(MainForm temp)
        {
            InitializeComponent();
            mainForm = temp;
            
        }

        private void btnStatisticsFormClear_Click(object sender, EventArgs e)
        {
            mainForm.ClassNGNumA = 0;
            mainForm.ClassNGNumB = 0;
            mainForm.HistoryNGNegativeA = new string[Convert.ToInt32( Global.waferCountPerClass) + 3];
            mainForm.HistoryNGNegativeB = new string[Convert.ToInt32(Global.waferCountPerClass) + 3];
            mainForm.HistoryNGPositiveA = new string[Convert.ToInt32(Global.waferCountPerClass) + 3];
            mainForm.HistoryNGPositiveB = new string[Convert.ToInt32(Global.waferCountPerClass) + 3];
            mainForm.HistoryNGPositiveAList.Clear();
            mainForm.HistoryNGPositiveBList.Clear();
            mainForm.HistoryNGNegativeAList.Clear();
            mainForm.HistoryNGNegativeBList.Clear();
            lblFirstCluster1.Text = "***";
            lblFirstCluster2.Text = "***";
            lblFirstCluster3.Text = "***";
            lblFirstCluster4.Text = "***";
            lblFirstCluster5.Text = "***";
            lblFirstCluster6.Text = "***";
            lblFirstCluster7.Text = "***";
            lblFirstCluster8.Text = "***";
            lblFirstCluster9.Text = "***";
            lblFirstCluster10.Text = "***";
            lblFirstCluster11.Text = "***";
            lblFirstCluster12.Text = "***";
            lblFirstCluster1.BackColor = System.Drawing.Color.LimeGreen;
            lblFirstCluster2.BackColor = System.Drawing.Color.LimeGreen;
            lblFirstCluster3.BackColor = System.Drawing.Color.LimeGreen;
            lblFirstCluster4.BackColor = System.Drawing.Color.LimeGreen;
            lblFirstCluster5.BackColor = System.Drawing.Color.LimeGreen;
            lblFirstCluster6.BackColor = System.Drawing.Color.LimeGreen;
            lblFirstCluster7.BackColor = System.Drawing.Color.LimeGreen;
            lblFirstCluster8.BackColor = System.Drawing.Color.LimeGreen;
            lblFirstCluster9.BackColor = System.Drawing.Color.LimeGreen;
            lblFirstCluster10.BackColor = System.Drawing.Color.LimeGreen;
            lblFirstCluster11.BackColor = System.Drawing.Color.LimeGreen;
            lblFirstCluster12.BackColor = System.Drawing.Color.LimeGreen;

            lblSecondCluster12.Text = "***";
            lblSecondCluster11.Text = "***";
            lblSecondCluster10.Text = "***";
            lblSecondCluster9.Text = "***";
            lblSecondCluster8.Text = "***";
            lblSecondCluster7.Text = "***";
            lblSecondCluster6.Text = "***";
            lblSecondCluster5.Text = "***";
            lblSecondCluster4.Text = "***";
            lblSecondCluster3.Text = "***";
            lblSecondCluster2.Text = "***";
            lblSecondCluster1.Text = "***";
            lblSecondCluster12.BackColor = System.Drawing.Color.LimeGreen;
            lblSecondCluster11.BackColor = System.Drawing.Color.LimeGreen;
            lblSecondCluster10.BackColor = System.Drawing.Color.LimeGreen;
            lblSecondCluster9.BackColor = System.Drawing.Color.LimeGreen;
            lblSecondCluster8.BackColor = System.Drawing.Color.LimeGreen;
            lblSecondCluster7.BackColor = System.Drawing.Color.LimeGreen;
            lblSecondCluster6.BackColor = System.Drawing.Color.LimeGreen;
            lblSecondCluster5.BackColor = System.Drawing.Color.LimeGreen;
            lblSecondCluster4.BackColor = System.Drawing.Color.LimeGreen;
            lblSecondCluster3.BackColor = System.Drawing.Color.LimeGreen;
            lblSecondCluster2.BackColor = System.Drawing.Color.LimeGreen;
            lblSecondCluster1.BackColor = System.Drawing.Color.LimeGreen;

            lblThirdCluster12.Text = "***";
            lblThirdCluster11.Text = "***";
            lblThirdCluster10.Text = "***";
            lblThirdCluster9.Text = "***";
            lblThirdCluster8.Text = "***";
            lblThirdCluster7.Text = "***";
            lblThirdCluster6.Text = "***";
            lblThirdCluster5.Text = "***";
            lblThirdCluster4.Text = "***";
            lblThirdCluster3.Text = "***";
            lblThirdCluster2.Text = "***";
            lblThirdCluster1.Text = "***";
            lblThirdCluster12.BackColor = System.Drawing.Color.LimeGreen;
            lblThirdCluster11.BackColor = System.Drawing.Color.LimeGreen;
            lblThirdCluster10.BackColor = System.Drawing.Color.LimeGreen;
            lblThirdCluster9.BackColor = System.Drawing.Color.LimeGreen;
            lblThirdCluster8.BackColor = System.Drawing.Color.LimeGreen;
            lblThirdCluster7.BackColor = System.Drawing.Color.LimeGreen;
            lblThirdCluster6.BackColor = System.Drawing.Color.LimeGreen;
            lblThirdCluster5.BackColor = System.Drawing.Color.LimeGreen;
            lblThirdCluster4.BackColor = System.Drawing.Color.LimeGreen;
            lblThirdCluster3.BackColor = System.Drawing.Color.LimeGreen;
            lblThirdCluster2.BackColor = System.Drawing.Color.LimeGreen;
            lblThirdCluster1.BackColor = System.Drawing.Color.LimeGreen;

            lblFourthCluster12.Text = "***";
            lblFourthCluster11.Text = "***";
            lblFourthCluster10.Text = "***";
            lblFourthCluster9.Text = "***";
            lblFourthCluster8.Text = "***";
            lblFourthCluster7.Text = "***";
            lblFourthCluster6.Text = "***";
            lblFourthCluster5.Text = "***";
            lblFourthCluster4.Text = "***";
            lblFourthCluster3.Text = "***";
            lblFourthCluster2.Text = "***";
            lblFourthCluster1.Text = "***";
            lblFourthCluster12.BackColor = System.Drawing.Color.LimeGreen;
            lblFourthCluster11.BackColor = System.Drawing.Color.LimeGreen;
            lblFourthCluster10.BackColor = System.Drawing.Color.LimeGreen;
            lblFourthCluster9.BackColor = System.Drawing.Color.LimeGreen;
            lblFourthCluster8.BackColor = System.Drawing.Color.LimeGreen;
            lblFourthCluster7.BackColor = System.Drawing.Color.LimeGreen;
            lblFourthCluster6.BackColor = System.Drawing.Color.LimeGreen;
            lblFourthCluster5.BackColor = System.Drawing.Color.LimeGreen;
            lblFourthCluster4.BackColor = System.Drawing.Color.LimeGreen;
            lblFourthCluster3.BackColor = System.Drawing.Color.LimeGreen;
            lblFourthCluster2.BackColor = System.Drawing.Color.LimeGreen;
            lblFourthCluster1.BackColor = System.Drawing.Color.LimeGreen;



            lblFifthCluster12.Text = "***";
            lblFifthCluster11.Text = "***";
            lblFifthCluster10.Text = "***";
            lblFifthCluster9.Text = "***";
            lblFifthCluster8.Text = "***";
            lblFifthCluster7.Text = "***";
            lblFifthCluster6.Text = "***";
            lblFifthCluster5.Text = "***";
            lblFifthCluster4.Text = "***";
            lblFifthCluster3.Text = "***";
            lblFifthCluster2.Text = "***";
            lblFifthCluster1.Text = "***";
            lblFifthCluster12.BackColor = System.Drawing.Color.LimeGreen;
            lblFifthCluster11.BackColor = System.Drawing.Color.LimeGreen;
            lblFifthCluster10.BackColor = System.Drawing.Color.LimeGreen;
            lblFifthCluster9.BackColor = System.Drawing.Color.LimeGreen;
            lblFifthCluster8.BackColor = System.Drawing.Color.LimeGreen;
            lblFifthCluster7.BackColor = System.Drawing.Color.LimeGreen;
            lblFifthCluster6.BackColor = System.Drawing.Color.LimeGreen;
            lblFifthCluster5.BackColor = System.Drawing.Color.LimeGreen;
            lblFifthCluster4.BackColor = System.Drawing.Color.LimeGreen;
            lblFifthCluster3.BackColor = System.Drawing.Color.LimeGreen;
            lblFifthCluster2.BackColor = System.Drawing.Color.LimeGreen;
            lblFifthCluster1.BackColor = System.Drawing.Color.LimeGreen;

            lblSixthCluster12.Text = "***";
            lblSixthCluster11.Text = "***";
            lblSixthCluster10.Text = "***";
            lblSixthCluster9.Text = "***";
            lblSixthCluster8.Text = "***";
            lblSixthCluster7.Text = "***";
            lblSixthCluster6.Text = "***";
            lblSixthCluster5.Text = "***";
            lblSixthCluster4.Text = "***";
            lblSixthCluster3.Text = "***";
            lblSixthCluster2.Text = "***";
            lblSixthCluster1.Text = "***";
            lblSixthCluster12.BackColor = System.Drawing.Color.LimeGreen;
            lblSixthCluster11.BackColor = System.Drawing.Color.LimeGreen;
            lblSixthCluster10.BackColor = System.Drawing.Color.LimeGreen;
            lblSixthCluster9.BackColor = System.Drawing.Color.LimeGreen;
            lblSixthCluster8.BackColor = System.Drawing.Color.LimeGreen;
            lblSixthCluster7.BackColor = System.Drawing.Color.LimeGreen;
            lblSixthCluster6.BackColor = System.Drawing.Color.LimeGreen;
            lblSixthCluster5.BackColor = System.Drawing.Color.LimeGreen;
            lblSixthCluster4.BackColor = System.Drawing.Color.LimeGreen;
            lblSixthCluster3.BackColor = System.Drawing.Color.LimeGreen;
            lblSixthCluster2.BackColor = System.Drawing.Color.LimeGreen;
            lblSixthCluster1.BackColor = System.Drawing.Color.LimeGreen;

            lblSeventhCluster12.Text = "***";
            lblSeventhCluster11.Text = "***";
            lblSeventhCluster10.Text = "***";
            lblSeventhCluster9.Text = "***";
            lblSeventhCluster8.Text = "***";
            lblSeventhCluster7.Text = "***";
            lblSeventhCluster6.Text = "***";
            lblSeventhCluster5.Text = "***";
            lblSeventhCluster4.Text = "***";
            lblSeventhCluster3.Text = "***";
            lblSeventhCluster2.Text = "***";
            lblSeventhCluster1.Text = "***";
            lblSeventhCluster12.BackColor = System.Drawing.Color.LimeGreen;
            lblSeventhCluster11.BackColor = System.Drawing.Color.LimeGreen;
            lblSeventhCluster10.BackColor = System.Drawing.Color.LimeGreen;
            lblSeventhCluster9.BackColor = System.Drawing.Color.LimeGreen;
            lblSeventhCluster8.BackColor = System.Drawing.Color.LimeGreen;
            lblSeventhCluster7.BackColor = System.Drawing.Color.LimeGreen;
            lblSeventhCluster6.BackColor = System.Drawing.Color.LimeGreen;
            lblSeventhCluster5.BackColor = System.Drawing.Color.LimeGreen;
            lblSeventhCluster4.BackColor = System.Drawing.Color.LimeGreen;
            lblSeventhCluster3.BackColor = System.Drawing.Color.LimeGreen;
            lblSeventhCluster2.BackColor = System.Drawing.Color.LimeGreen;
            lblSeventhCluster1.BackColor = System.Drawing.Color.LimeGreen;

            lblEighthCluster12.Text = "***";
            lblEighthCluster11.Text = "***";
            lblEighthCluster10.Text = "***";
            lblEighthCluster9.Text = "***";
            lblEighthCluster8.Text = "***";
            lblEighthCluster7.Text = "***";
            lblEighthCluster6.Text = "***";
            lblEighthCluster5.Text = "***";
            lblEighthCluster4.Text = "***";
            lblEighthCluster3.Text = "***";
            lblEighthCluster2.Text = "***";
            lblEighthCluster1.Text = "***";
            lblEighthCluster12.BackColor = System.Drawing.Color.LimeGreen;
            lblEighthCluster11.BackColor = System.Drawing.Color.LimeGreen;
            lblEighthCluster10.BackColor = System.Drawing.Color.LimeGreen;
            lblEighthCluster9.BackColor = System.Drawing.Color.LimeGreen;
            lblEighthCluster8.BackColor = System.Drawing.Color.LimeGreen;
            lblEighthCluster7.BackColor = System.Drawing.Color.LimeGreen;
            lblEighthCluster6.BackColor = System.Drawing.Color.LimeGreen;
            lblEighthCluster5.BackColor = System.Drawing.Color.LimeGreen;
            lblEighthCluster4.BackColor = System.Drawing.Color.LimeGreen;
            lblEighthCluster3.BackColor = System.Drawing.Color.LimeGreen;
            lblEighthCluster2.BackColor = System.Drawing.Color.LimeGreen;
            lblEighthCluster1.BackColor = System.Drawing.Color.LimeGreen;

            lblNinthCluster12.Text = "***";
            lblNinthCluster11.Text = "***";
            lblNinthCluster10.Text = "***";
            lblNinthCluster9.Text = "***";
            lblNinthCluster8.Text = "***";
            lblNinthCluster7.Text = "***";
            lblNinthCluster6.Text = "***";
            lblNinthCluster5.Text = "***";
            lblNinthCluster4.Text = "***";
            lblNinthCluster3.Text = "***";
            lblNinthCluster2.Text = "***";
            lblNinthCluster1.Text = "***";
            lblNinthCluster12.BackColor = System.Drawing.Color.LimeGreen;
            lblNinthCluster11.BackColor = System.Drawing.Color.LimeGreen;
            lblNinthCluster10.BackColor = System.Drawing.Color.LimeGreen;
            lblNinthCluster9.BackColor = System.Drawing.Color.LimeGreen;
            lblNinthCluster8.BackColor = System.Drawing.Color.LimeGreen;
            lblNinthCluster7.BackColor = System.Drawing.Color.LimeGreen;
            lblNinthCluster6.BackColor = System.Drawing.Color.LimeGreen;
            lblNinthCluster5.BackColor = System.Drawing.Color.LimeGreen;
            lblNinthCluster4.BackColor = System.Drawing.Color.LimeGreen;
            lblNinthCluster3.BackColor = System.Drawing.Color.LimeGreen;
            lblNinthCluster2.BackColor = System.Drawing.Color.LimeGreen;
            lblNinthCluster1.BackColor = System.Drawing.Color.LimeGreen;

            lblTenthCluster12.Text = "***";
            lblTenthCluster11.Text = "***";
            lblTenthCluster10.Text = "***";
            lblTenthCluster9.Text = "***";
            lblTenthCluster8.Text = "***";
            lblTenthCluster7.Text = "***";
            lblTenthCluster6.Text = "***";
            lblTenthCluster5.Text = "***";
            lblTenthCluster4.Text = "***";
            lblTenthCluster3.Text = "***";
            lblTenthCluster2.Text = "***";
            lblTenthCluster1.Text = "***";
            lblTenthCluster12.BackColor = System.Drawing.Color.LimeGreen;
            lblTenthCluster11.BackColor = System.Drawing.Color.LimeGreen;
            lblTenthCluster10.BackColor = System.Drawing.Color.LimeGreen;
            lblTenthCluster9.BackColor = System.Drawing.Color.LimeGreen;
            lblTenthCluster8.BackColor = System.Drawing.Color.LimeGreen;
            lblTenthCluster7.BackColor = System.Drawing.Color.LimeGreen;
            lblTenthCluster6.BackColor = System.Drawing.Color.LimeGreen;
            lblTenthCluster5.BackColor = System.Drawing.Color.LimeGreen;
            lblTenthCluster4.BackColor = System.Drawing.Color.LimeGreen;
            lblTenthCluster3.BackColor = System.Drawing.Color.LimeGreen;
            lblTenthCluster2.BackColor = System.Drawing.Color.LimeGreen;
            lblTenthCluster1.BackColor = System.Drawing.Color.LimeGreen;

            lblEleventhCluster12.Text = "***";
            lblEleventhCluster11.Text = "***";
            lblEleventhCluster10.Text = "***";
            lblEleventhCluster9.Text = "***";
            lblEleventhCluster8.Text = "***";
            lblEleventhCluster7.Text = "***";
            lblEleventhCluster6.Text = "***";
            lblEleventhCluster5.Text = "***";
            lblEleventhCluster4.Text = "***";
            lblEleventhCluster3.Text = "***";
            lblEleventhCluster2.Text = "***";
            lblEleventhCluster1.Text = "***";
            lblEleventhCluster12.BackColor = System.Drawing.Color.LimeGreen;
            lblEleventhCluster11.BackColor = System.Drawing.Color.LimeGreen;
            lblEleventhCluster10.BackColor = System.Drawing.Color.LimeGreen;
            lblEleventhCluster9.BackColor = System.Drawing.Color.LimeGreen;
            lblEleventhCluster8.BackColor = System.Drawing.Color.LimeGreen;
            lblEleventhCluster7.BackColor = System.Drawing.Color.LimeGreen;
            lblEleventhCluster6.BackColor = System.Drawing.Color.LimeGreen;
            lblEleventhCluster5.BackColor = System.Drawing.Color.LimeGreen;
            lblEleventhCluster4.BackColor = System.Drawing.Color.LimeGreen;
            lblEleventhCluster3.BackColor = System.Drawing.Color.LimeGreen;
            lblEleventhCluster2.BackColor = System.Drawing.Color.LimeGreen;
            lblEleventhCluster1.BackColor = System.Drawing.Color.LimeGreen;
            lblCurrentClusterA1.Text = "***";
            lblCurrentClusterA2.Text = "***";
            lblCurrentClusterA3.Text = "***";
            lblCurrentClusterA4.Text = "***";
            lblCurrentClusterA5.Text = "***";
            lblCurrentClusterA6.Text = "***";
            lblCurrentClusterA7.Text = "***";
            lblCurrentClusterA8.Text = "***";
            lblCurrentClusterA9.Text = "***";
            lblCurrentClusterA10.Text = "***";
            lblCurrentClusterA11.Text = "***";
            lblCurrentClusterA12.Text = "***";
            lblCurrentClusterA1.BackColor = System.Drawing.Color.LimeGreen;
            lblCurrentClusterA2.BackColor = System.Drawing.Color.LimeGreen;
            lblCurrentClusterA3.BackColor = System.Drawing.Color.LimeGreen;
            lblCurrentClusterA4.BackColor = System.Drawing.Color.LimeGreen;
            lblCurrentClusterA5.BackColor = System.Drawing.Color.LimeGreen;
            lblCurrentClusterA6.BackColor = System.Drawing.Color.LimeGreen;
            lblCurrentClusterA7.BackColor = System.Drawing.Color.LimeGreen;
            lblCurrentClusterA8.BackColor = System.Drawing.Color.LimeGreen;
            lblCurrentClusterA9.BackColor = System.Drawing.Color.LimeGreen;
            lblCurrentClusterA10.BackColor = System.Drawing.Color.LimeGreen;
            lblCurrentClusterA11.BackColor = System.Drawing.Color.LimeGreen;
            lblCurrentClusterA12.BackColor = System.Drawing.Color.LimeGreen;

            lblTwelfthCluster12.Text = "***";
            lblTwelfthCluster11.Text = "***";
            lblTwelfthCluster10.Text = "***";
            lblTwelfthCluster9.Text = "***";
            lblTwelfthCluster8.Text = "***";
            lblTwelfthCluster7.Text = "***";
            lblTwelfthCluster6.Text = "***";
            lblTwelfthCluster5.Text = "***";
            lblTwelfthCluster4.Text = "***";
            lblTwelfthCluster3.Text = "***";
            lblTwelfthCluster2.Text = "***";
            lblTwelfthCluster1.Text = "***";
            lblTwelfthCluster12.BackColor = System.Drawing.Color.LimeGreen;
            lblTwelfthCluster11.BackColor = System.Drawing.Color.LimeGreen;
            lblTwelfthCluster10.BackColor = System.Drawing.Color.LimeGreen;
            lblTwelfthCluster9.BackColor = System.Drawing.Color.LimeGreen;
            lblTwelfthCluster8.BackColor = System.Drawing.Color.LimeGreen;
            lblTwelfthCluster7.BackColor = System.Drawing.Color.LimeGreen;
            lblTwelfthCluster6.BackColor = System.Drawing.Color.LimeGreen;
            lblTwelfthCluster5.BackColor = System.Drawing.Color.LimeGreen;
            lblTwelfthCluster4.BackColor = System.Drawing.Color.LimeGreen;
            lblTwelfthCluster3.BackColor = System.Drawing.Color.LimeGreen;
            lblTwelfthCluster2.BackColor = System.Drawing.Color.LimeGreen;
            lblTwelfthCluster1.BackColor = System.Drawing.Color.LimeGreen;

            lblCurrentClusterB1.Text = "***";
            lblCurrentClusterB2.Text = "***";
            lblCurrentClusterB3.Text = "***";
            lblCurrentClusterB4.Text = "***";
            lblCurrentClusterB5.Text = "***";
            lblCurrentClusterB6.Text = "***";
            lblCurrentClusterB7.Text = "***";
            lblCurrentClusterB8.Text = "***";
            lblCurrentClusterB9.Text = "***";
            lblCurrentClusterB10.Text = "***";
            lblCurrentClusterB11.Text = "***";
            lblCurrentClusterB12.Text = "***";
            lblCurrentClusterB1.BackColor = System.Drawing.Color.LimeGreen;
            lblCurrentClusterB2.BackColor = System.Drawing.Color.LimeGreen;
            lblCurrentClusterB3.BackColor = System.Drawing.Color.LimeGreen;
            lblCurrentClusterB4.BackColor = System.Drawing.Color.LimeGreen;
            lblCurrentClusterB5.BackColor = System.Drawing.Color.LimeGreen;
            lblCurrentClusterB6.BackColor = System.Drawing.Color.LimeGreen;
            lblCurrentClusterB7.BackColor = System.Drawing.Color.LimeGreen;
            lblCurrentClusterB8.BackColor = System.Drawing.Color.LimeGreen;
            lblCurrentClusterB9.BackColor = System.Drawing.Color.LimeGreen;
            lblCurrentClusterB10.BackColor = System.Drawing.Color.LimeGreen;
            lblCurrentClusterB11.BackColor = System.Drawing.Color.LimeGreen;
            lblCurrentClusterB12.BackColor = System.Drawing.Color.LimeGreen;

            lblFirstSide.Text = "***";
            lblSecondSide.Text = "***";
            lblThirdSide.Text = "***";
            lblFourthSide.Text = "***";
            lblFifthSide.Text = "***";
            lblSixthSide.Text = "***";
            lblSeventhSide.Text = "***";
            lblEighthSide.Text = "***";
            lblNinthSide.Text = "***";
            lblTenthSide.Text = "***";
            lblEleventhSide.Text = "***";
            lblTwelfthSide.Text = "***";
        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
