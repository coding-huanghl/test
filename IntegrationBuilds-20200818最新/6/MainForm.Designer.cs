using System;

namespace _6
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (!IsHandleCreated)
            {
                this.Close();
            }
        }


        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCurrentUserTitle = new System.Windows.Forms.Label();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.lblCurrentStateTitle = new System.Windows.Forms.Label();
            this.lblCurrentState = new System.Windows.Forms.Label();
            this.timer_AutoTimeAndDeleteOldFiles = new System.Windows.Forms.Timer(this.components);
            this.timer_AutoConnectTcpWithPlc_PositiveA = new System.Windows.Forms.Timer(this.components);
            this.timer_AutoConnectTcpWithPlc_PositiveB = new System.Windows.Forms.Timer(this.components);
            this.timer_AutoCreateCSVFiles = new System.Windows.Forms.Timer(this.components);
            this.pnlMainFormTitle = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.btnMainFormExit = new System.Windows.Forms.Button();
            this.btnMainFormUserManager = new System.Windows.Forms.Button();
            this.btnMainFormUserLogin = new System.Windows.Forms.Button();
            this.btnMainFormNGStatistics = new System.Windows.Forms.Button();
            this.btnMainFormStatistics = new System.Windows.Forms.Button();
            this.btnMainFormRecipe = new System.Windows.Forms.Button();
            this.btnMainFormNegativeInterface = new System.Windows.Forms.Button();
            this.btnMainFormPositiveInterface = new System.Windows.Forms.Button();
            this.pnlMainFormMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLanguageSwitch = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pnlMainFormContentView = new System.Windows.Forms.Panel();
            this.pnlLanguage = new System.Windows.Forms.Panel();
            this.rdbtnEnglish = new System.Windows.Forms.RadioButton();
            this.rdbtnChinese = new System.Windows.Forms.RadioButton();
            this.timer_AutoConnectTcpWithPlc_NegativeA = new System.Windows.Forms.Timer(this.components);
            this.timer_AutoConnectTcpWithPlc_NegativeB = new System.Windows.Forms.Timer(this.components);
            this.l2TCPClientSend2PLC = new L2TCPClient.L2TCPClient();
            this.timer_AutoReadNGNum = new System.Windows.Forms.Timer(this.components);
            this.pnlMainFormTitle.SuspendLayout();
            this.pnlMainFormMenu.SuspendLayout();
            this.pnlMainFormContentView.SuspendLayout();
            this.pnlLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurrentUserTitle
            // 
            this.lblCurrentUserTitle.AutoSize = true;
            this.lblCurrentUserTitle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurrentUserTitle.Location = new System.Drawing.Point(1033, 48);
            this.lblCurrentUserTitle.Name = "lblCurrentUserTitle";
            this.lblCurrentUserTitle.Size = new System.Drawing.Size(88, 16);
            this.lblCurrentUserTitle.TabIndex = 100;
            this.lblCurrentUserTitle.Text = "当前用户：";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurrentUser.Location = new System.Drawing.Point(1125, 49);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(32, 16);
            this.lblCurrentUser.TabIndex = 101;
            this.lblCurrentUser.Text = "***";
            // 
            // lblCurrentStateTitle
            // 
            this.lblCurrentStateTitle.AutoSize = true;
            this.lblCurrentStateTitle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurrentStateTitle.Location = new System.Drawing.Point(1248, 47);
            this.lblCurrentStateTitle.Name = "lblCurrentStateTitle";
            this.lblCurrentStateTitle.Size = new System.Drawing.Size(88, 16);
            this.lblCurrentStateTitle.TabIndex = 102;
            this.lblCurrentStateTitle.Text = "当前状态：";
            // 
            // lblCurrentState
            // 
            this.lblCurrentState.AutoSize = true;
            this.lblCurrentState.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurrentState.Location = new System.Drawing.Point(1340, 48);
            this.lblCurrentState.Name = "lblCurrentState";
            this.lblCurrentState.Size = new System.Drawing.Size(28, 14);
            this.lblCurrentState.TabIndex = 103;
            this.lblCurrentState.Text = "***";
            // 
            // timer_AutoTimeAndDeleteOldFiles
            // 
            this.timer_AutoTimeAndDeleteOldFiles.Enabled = true;
            this.timer_AutoTimeAndDeleteOldFiles.Interval = 1000;
            this.timer_AutoTimeAndDeleteOldFiles.Tick += new System.EventHandler(this.timer_AutoTimeAndDeleteOldFiles_Tick);
            // 
            // timer_AutoConnectTcpWithPlc_PositiveA
            // 
            this.timer_AutoConnectTcpWithPlc_PositiveA.Enabled = true;
            this.timer_AutoConnectTcpWithPlc_PositiveA.Interval = 1000;
            this.timer_AutoConnectTcpWithPlc_PositiveA.Tick += new System.EventHandler(this.timer_AutoConnectTcpWithPlc_PositiveA_Tick);
            // 
            // timer_AutoConnectTcpWithPlc_PositiveB
            // 
            this.timer_AutoConnectTcpWithPlc_PositiveB.Enabled = true;
            this.timer_AutoConnectTcpWithPlc_PositiveB.Interval = 1000;
            this.timer_AutoConnectTcpWithPlc_PositiveB.Tick += new System.EventHandler(this.timer_AutoConnectTcpWithPlc_PositiveB_Tick);
            // 
            // timer_AutoCreateCSVFiles
            // 
            this.timer_AutoCreateCSVFiles.Enabled = true;
            this.timer_AutoCreateCSVFiles.Interval = 2000;
            this.timer_AutoCreateCSVFiles.Tick += new System.EventHandler(this.timer_AutoCreateCSVFiles_Tick);
            // 
            // pnlMainFormTitle
            // 
            this.pnlMainFormTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMainFormTitle.Controls.Add(this.button2);
            this.pnlMainFormTitle.Controls.Add(this.label3);
            this.pnlMainFormTitle.Controls.Add(this.label2);
            this.pnlMainFormTitle.Controls.Add(this.label1);
            this.pnlMainFormTitle.Controls.Add(this.label93);
            this.pnlMainFormTitle.Controls.Add(this.lblCurrentUserTitle);
            this.pnlMainFormTitle.Controls.Add(this.lblCurrentState);
            this.pnlMainFormTitle.Controls.Add(this.lblCurrentStateTitle);
            this.pnlMainFormTitle.Controls.Add(this.lblCurrentUser);
            this.pnlMainFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainFormTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlMainFormTitle.Name = "pnlMainFormTitle";
            this.pnlMainFormTitle.Size = new System.Drawing.Size(1872, 83);
            this.pnlMainFormTitle.TabIndex = 156;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 109;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(969, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 106;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(802, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 105;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 104;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold);
            this.label93.Location = new System.Drawing.Point(258, 9);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(769, 64);
            this.label93.TabIndex = 0;
            this.label93.Text = "太阳能电池串多功能检测系统";
            // 
            // btnMainFormExit
            // 
            this.btnMainFormExit.BackColor = System.Drawing.Color.Red;
            this.btnMainFormExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMainFormExit.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMainFormExit.Location = new System.Drawing.Point(3, 691);
            this.btnMainFormExit.Name = "btnMainFormExit";
            this.btnMainFormExit.Size = new System.Drawing.Size(138, 80);
            this.btnMainFormExit.TabIndex = 0;
            this.btnMainFormExit.Text = "安全退出";
            this.btnMainFormExit.UseVisualStyleBackColor = false;
            this.btnMainFormExit.Click += new System.EventHandler(this.btnMainFormExit_Click);
            // 
            // btnMainFormUserManager
            // 
            this.btnMainFormUserManager.BackColor = System.Drawing.Color.White;
            this.btnMainFormUserManager.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMainFormUserManager.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMainFormUserManager.Location = new System.Drawing.Point(3, 519);
            this.btnMainFormUserManager.Name = "btnMainFormUserManager";
            this.btnMainFormUserManager.Size = new System.Drawing.Size(138, 80);
            this.btnMainFormUserManager.TabIndex = 0;
            this.btnMainFormUserManager.Text = "用户管理";
            this.btnMainFormUserManager.UseVisualStyleBackColor = false;
            this.btnMainFormUserManager.Click += new System.EventHandler(this.btnMainFormUserManager_Click);
            // 
            // btnMainFormUserLogin
            // 
            this.btnMainFormUserLogin.BackColor = System.Drawing.Color.White;
            this.btnMainFormUserLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMainFormUserLogin.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMainFormUserLogin.Location = new System.Drawing.Point(3, 433);
            this.btnMainFormUserLogin.Name = "btnMainFormUserLogin";
            this.btnMainFormUserLogin.Size = new System.Drawing.Size(138, 80);
            this.btnMainFormUserLogin.TabIndex = 0;
            this.btnMainFormUserLogin.Text = "登录";
            this.btnMainFormUserLogin.UseVisualStyleBackColor = false;
            this.btnMainFormUserLogin.Click += new System.EventHandler(this.btnMainFormUserLogin_Click);
            // 
            // btnMainFormNGStatistics
            // 
            this.btnMainFormNGStatistics.BackColor = System.Drawing.Color.White;
            this.btnMainFormNGStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMainFormNGStatistics.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMainFormNGStatistics.Location = new System.Drawing.Point(3, 347);
            this.btnMainFormNGStatistics.Name = "btnMainFormNGStatistics";
            this.btnMainFormNGStatistics.Size = new System.Drawing.Size(138, 80);
            this.btnMainFormNGStatistics.TabIndex = 0;
            this.btnMainFormNGStatistics.Text = "当班统计";
            this.btnMainFormNGStatistics.UseVisualStyleBackColor = false;
            this.btnMainFormNGStatistics.Click += new System.EventHandler(this.btnMainFormNGStatistics_Click);
            // 
            // btnMainFormStatistics
            // 
            this.btnMainFormStatistics.BackColor = System.Drawing.Color.White;
            this.btnMainFormStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMainFormStatistics.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMainFormStatistics.Location = new System.Drawing.Point(3, 261);
            this.btnMainFormStatistics.Name = "btnMainFormStatistics";
            this.btnMainFormStatistics.Size = new System.Drawing.Size(138, 80);
            this.btnMainFormStatistics.TabIndex = 0;
            this.btnMainFormStatistics.Text = "NG串查看";
            this.btnMainFormStatistics.UseVisualStyleBackColor = false;
            this.btnMainFormStatistics.Click += new System.EventHandler(this.btnMainFormStatistics_Click);
            // 
            // btnMainFormRecipe
            // 
            this.btnMainFormRecipe.BackColor = System.Drawing.Color.White;
            this.btnMainFormRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMainFormRecipe.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMainFormRecipe.Location = new System.Drawing.Point(3, 175);
            this.btnMainFormRecipe.Name = "btnMainFormRecipe";
            this.btnMainFormRecipe.Size = new System.Drawing.Size(138, 80);
            this.btnMainFormRecipe.TabIndex = 0;
            this.btnMainFormRecipe.Text = "参数设置";
            this.btnMainFormRecipe.UseVisualStyleBackColor = false;
            this.btnMainFormRecipe.Click += new System.EventHandler(this.btnMainFormRecipe_Click);
            // 
            // btnMainFormNegativeInterface
            // 
            this.btnMainFormNegativeInterface.BackColor = System.Drawing.Color.White;
            this.btnMainFormNegativeInterface.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMainFormNegativeInterface.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMainFormNegativeInterface.Location = new System.Drawing.Point(3, 89);
            this.btnMainFormNegativeInterface.Name = "btnMainFormNegativeInterface";
            this.btnMainFormNegativeInterface.Size = new System.Drawing.Size(138, 80);
            this.btnMainFormNegativeInterface.TabIndex = 0;
            this.btnMainFormNegativeInterface.Text = "背面串检";
            this.btnMainFormNegativeInterface.UseVisualStyleBackColor = false;
            this.btnMainFormNegativeInterface.Click += new System.EventHandler(this.btnMainFormNegativeInterface_Click);
            // 
            // btnMainFormPositiveInterface
            // 
            this.btnMainFormPositiveInterface.BackColor = System.Drawing.Color.White;
            this.btnMainFormPositiveInterface.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMainFormPositiveInterface.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMainFormPositiveInterface.Location = new System.Drawing.Point(3, 3);
            this.btnMainFormPositiveInterface.Name = "btnMainFormPositiveInterface";
            this.btnMainFormPositiveInterface.Size = new System.Drawing.Size(138, 80);
            this.btnMainFormPositiveInterface.TabIndex = 0;
            this.btnMainFormPositiveInterface.Text = "正面串检";
            this.btnMainFormPositiveInterface.UseVisualStyleBackColor = false;
            this.btnMainFormPositiveInterface.Click += new System.EventHandler(this.btnMainFormPositiveInterface_Click);
            // 
            // pnlMainFormMenu
            // 
            this.pnlMainFormMenu.Controls.Add(this.btnMainFormPositiveInterface);
            this.pnlMainFormMenu.Controls.Add(this.btnMainFormNegativeInterface);
            this.pnlMainFormMenu.Controls.Add(this.btnMainFormRecipe);
            this.pnlMainFormMenu.Controls.Add(this.btnMainFormStatistics);
            this.pnlMainFormMenu.Controls.Add(this.btnMainFormNGStatistics);
            this.pnlMainFormMenu.Controls.Add(this.btnMainFormUserLogin);
            this.pnlMainFormMenu.Controls.Add(this.btnMainFormUserManager);
            this.pnlMainFormMenu.Controls.Add(this.btnLanguageSwitch);
            this.pnlMainFormMenu.Controls.Add(this.btnMainFormExit);
            this.pnlMainFormMenu.Controls.Add(this.lblVersion);
            this.pnlMainFormMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMainFormMenu.Location = new System.Drawing.Point(0, 83);
            this.pnlMainFormMenu.Name = "pnlMainFormMenu";
            this.pnlMainFormMenu.Size = new System.Drawing.Size(144, 1017);
            this.pnlMainFormMenu.TabIndex = 157;
            // 
            // btnLanguageSwitch
            // 
            this.btnLanguageSwitch.BackColor = System.Drawing.Color.White;
            this.btnLanguageSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLanguageSwitch.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLanguageSwitch.Location = new System.Drawing.Point(3, 605);
            this.btnLanguageSwitch.Name = "btnLanguageSwitch";
            this.btnLanguageSwitch.Size = new System.Drawing.Size(138, 80);
            this.btnLanguageSwitch.TabIndex = 2;
            this.btnLanguageSwitch.Text = "语言切换";
            this.btnLanguageSwitch.UseVisualStyleBackColor = false;
            this.btnLanguageSwitch.Click += new System.EventHandler(this.btnLanguageSwitch_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(3, 774);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(127, 23);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "1.1.1.201202";
            // 
            // pnlMainFormContentView
            // 
            this.pnlMainFormContentView.BackColor = System.Drawing.Color.White;
            this.pnlMainFormContentView.Controls.Add(this.pnlLanguage);
            this.pnlMainFormContentView.Location = new System.Drawing.Point(147, 86);
            this.pnlMainFormContentView.Name = "pnlMainFormContentView";
            this.pnlMainFormContentView.Size = new System.Drawing.Size(1725, 1014);
            this.pnlMainFormContentView.TabIndex = 158;
            // 
            // pnlLanguage
            // 
            this.pnlLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLanguage.BackColor = System.Drawing.Color.Lime;
            this.pnlLanguage.Controls.Add(this.rdbtnEnglish);
            this.pnlLanguage.Controls.Add(this.rdbtnChinese);
            this.pnlLanguage.Location = new System.Drawing.Point(3, 570);
            this.pnlLanguage.Name = "pnlLanguage";
            this.pnlLanguage.Size = new System.Drawing.Size(191, 157);
            this.pnlLanguage.TabIndex = 1;
            this.pnlLanguage.Visible = false;
            this.pnlLanguage.Leave += new System.EventHandler(this.pnlLanguage_Leave);
            // 
            // rdbtnEnglish
            // 
            this.rdbtnEnglish.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbtnEnglish.Location = new System.Drawing.Point(18, 91);
            this.rdbtnEnglish.Name = "rdbtnEnglish";
            this.rdbtnEnglish.Size = new System.Drawing.Size(125, 30);
            this.rdbtnEnglish.TabIndex = 3;
            this.rdbtnEnglish.TabStop = true;
            this.rdbtnEnglish.Text = "English";
            this.rdbtnEnglish.UseVisualStyleBackColor = true;
            this.rdbtnEnglish.CheckedChanged += new System.EventHandler(this.rdbtnEnglish_CheckedChanged);
            // 
            // rdbtnChinese
            // 
            this.rdbtnChinese.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbtnChinese.Location = new System.Drawing.Point(18, 34);
            this.rdbtnChinese.Name = "rdbtnChinese";
            this.rdbtnChinese.Size = new System.Drawing.Size(125, 30);
            this.rdbtnChinese.TabIndex = 2;
            this.rdbtnChinese.TabStop = true;
            this.rdbtnChinese.Text = "中文";
            this.rdbtnChinese.UseVisualStyleBackColor = true;
            this.rdbtnChinese.CheckedChanged += new System.EventHandler(this.rdbtnChinese_CheckedChanged);
            // 
            // timer_AutoConnectTcpWithPlc_NegativeA
            // 
            this.timer_AutoConnectTcpWithPlc_NegativeA.Enabled = true;
            this.timer_AutoConnectTcpWithPlc_NegativeA.Interval = 1000;
            this.timer_AutoConnectTcpWithPlc_NegativeA.Tick += new System.EventHandler(this.timer_AutoConnectTcpWithPlc_NegativeA_Tick);
            // 
            // timer_AutoConnectTcpWithPlc_NegativeB
            // 
            this.timer_AutoConnectTcpWithPlc_NegativeB.Enabled = true;
            this.timer_AutoConnectTcpWithPlc_NegativeB.Interval = 1000;
            this.timer_AutoConnectTcpWithPlc_NegativeB.Tick += new System.EventHandler(this.timer_AutoConnectTcpWithPlc_NegativeB_Tick);
            // 
            // l2TCPClientSend2PLC
            // 
            this.l2TCPClientSend2PLC.Active = false;
            this.l2TCPClientSend2PLC.ServerIP = "172.168.155.201";
            this.l2TCPClientSend2PLC.ServerPort = 8501;
            this.l2TCPClientSend2PLC.DataReceived += new L2TCPClient.L2TCPClient.DataReceivedEventHandler(this.l2TCPClientSend2PLC_DataReceived);
            // 
            // timer_AutoReadNGNum
            // 
            this.timer_AutoReadNGNum.Enabled = true;
            this.timer_AutoReadNGNum.Interval = 2000;
            this.timer_AutoReadNGNum.Tick += new System.EventHandler(this.timer_AutoReadNGNum_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(988, 368);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMainFormContentView);
            this.Controls.Add(this.pnlMainFormMenu);
            this.Controls.Add(this.pnlMainFormTitle);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(2560, 1080);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "无锡奥特维科技股份有限公司";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.pnlMainFormTitle.ResumeLayout(false);
            this.pnlMainFormTitle.PerformLayout();
            this.pnlMainFormMenu.ResumeLayout(false);
            this.pnlMainFormMenu.PerformLayout();
            this.pnlMainFormContentView.ResumeLayout(false);
            this.pnlLanguage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCurrentUserTitle;
        private System.Windows.Forms.Label lblCurrentStateTitle;
        private System.Windows.Forms.Timer timer_AutoTimeAndDeleteOldFiles;
        private System.Windows.Forms.Timer timer_AutoConnectTcpWithPlc_PositiveA;
        private System.Windows.Forms.Timer timer_AutoConnectTcpWithPlc_PositiveB;
        private System.Windows.Forms.Timer timer_AutoCreateCSVFiles;
        private System.Windows.Forms.Panel pnlMainFormTitle;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.FlowLayoutPanel pnlMainFormMenu;
        private System.Windows.Forms.Panel pnlMainFormContentView;
        private System.Windows.Forms.Timer timer_AutoConnectTcpWithPlc_NegativeA;
        private System.Windows.Forms.Timer timer_AutoConnectTcpWithPlc_NegativeB;
        public System.Windows.Forms.Label lblCurrentState;
        public System.Windows.Forms.Label lblCurrentUser;
        public System.Windows.Forms.Button btnMainFormPositiveInterface;
        public System.Windows.Forms.Button btnMainFormNegativeInterface;
        public System.Windows.Forms.Button btnMainFormRecipe;
        public System.Windows.Forms.Button btnMainFormStatistics;
        public System.Windows.Forms.Button btnMainFormExit;
        public System.Windows.Forms.Button btnMainFormUserManager;
        public System.Windows.Forms.Button btnMainFormUserLogin;
        public System.Windows.Forms.Button btnMainFormNGStatistics;
        public System.Windows.Forms.Button btnLanguageSwitch;
        private System.Windows.Forms.Panel pnlLanguage;
        private System.Windows.Forms.RadioButton rdbtnEnglish;
        private System.Windows.Forms.RadioButton rdbtnChinese;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private L2TCPClient.L2TCPClient l2TCPClientSend2PLC;
        private System.Windows.Forms.Timer timer_AutoReadNGNum;
    }
}

