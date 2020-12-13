namespace _6
{
    partial class MainFormLoginInterface
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_OK = new System.Windows.Forms.Button();
            this.tb_PassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_UserType = new System.Windows.Forms.ComboBox();
            this.lb_UserType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_OK
            // 
            this.bt_OK.BackColor = System.Drawing.Color.Lime;
            this.bt_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_OK.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.bt_OK.Location = new System.Drawing.Point(703, 547);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(303, 69);
            this.bt_OK.TabIndex = 11;
            this.bt_OK.Text = "确定";
            this.bt_OK.UseVisualStyleBackColor = false;
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // tb_PassWord
            // 
            this.tb_PassWord.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_PassWord.Location = new System.Drawing.Point(836, 460);
            this.tb_PassWord.Name = "tb_PassWord";
            this.tb_PassWord.PasswordChar = '*';
            this.tb_PassWord.Size = new System.Drawing.Size(170, 29);
            this.tb_PassWord.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(699, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "登入密码";
            // 
            // cb_UserType
            // 
            this.cb_UserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_UserType.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.cb_UserType.FormattingEnabled = true;
            this.cb_UserType.Items.AddRange(new object[] {
            "管理员",
            "操作工"});
            this.cb_UserType.Location = new System.Drawing.Point(836, 399);
            this.cb_UserType.Name = "cb_UserType";
            this.cb_UserType.Size = new System.Drawing.Size(170, 27);
            this.cb_UserType.TabIndex = 8;
            // 
            // lb_UserType
            // 
            this.lb_UserType.AutoSize = true;
            this.lb_UserType.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.lb_UserType.Location = new System.Drawing.Point(699, 399);
            this.lb_UserType.Name = "lb_UserType";
            this.lb_UserType.Size = new System.Drawing.Size(93, 19);
            this.lb_UserType.TabIndex = 7;
            this.lb_UserType.Text = "用户类型";
            // 
            // MainFormLoginInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.tb_PassWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_UserType);
            this.Controls.Add(this.lb_UserType);
            this.Name = "MainFormLoginInterface";
            this.Size = new System.Drawing.Size(1720, 1009);
            this.Load += new System.EventHandler(this.MainFormLoginInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.TextBox tb_PassWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_UserType;
        public System.Windows.Forms.ComboBox cb_UserType;
    }
}
