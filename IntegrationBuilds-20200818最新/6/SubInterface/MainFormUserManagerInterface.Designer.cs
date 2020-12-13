namespace _6
{
    partial class MainFormUserManager
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
            this.txtOldPassWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPassWordManageFormOK = new System.Windows.Forms.Button();
            this.txtNewPassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxUserType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirmNewPassWord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtOldPassWord
            // 
            this.txtOldPassWord.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtOldPassWord.Location = new System.Drawing.Point(846, 463);
            this.txtOldPassWord.Name = "txtOldPassWord";
            this.txtOldPassWord.PasswordChar = '*';
            this.txtOldPassWord.Size = new System.Drawing.Size(125, 29);
            this.txtOldPassWord.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(651, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "原密码";
            // 
            // btnPassWordManageFormOK
            // 
            this.btnPassWordManageFormOK.BackColor = System.Drawing.Color.Lime;
            this.btnPassWordManageFormOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPassWordManageFormOK.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnPassWordManageFormOK.Location = new System.Drawing.Point(655, 608);
            this.btnPassWordManageFormOK.Name = "btnPassWordManageFormOK";
            this.btnPassWordManageFormOK.Size = new System.Drawing.Size(326, 69);
            this.btnPassWordManageFormOK.TabIndex = 19;
            this.btnPassWordManageFormOK.Text = "确认";
            this.btnPassWordManageFormOK.UseVisualStyleBackColor = false;
            this.btnPassWordManageFormOK.Click += new System.EventHandler(this.btnPassWordManageFormOK_Click);
            // 
            // txtNewPassWord
            // 
            this.txtNewPassWord.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtNewPassWord.Location = new System.Drawing.Point(846, 502);
            this.txtNewPassWord.Name = "txtNewPassWord";
            this.txtNewPassWord.PasswordChar = '*';
            this.txtNewPassWord.Size = new System.Drawing.Size(125, 29);
            this.txtNewPassWord.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(651, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "新密码";
            // 
            // cbxUserType
            // 
            this.cbxUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUserType.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbxUserType.FormattingEnabled = true;
            this.cbxUserType.Items.AddRange(new object[] {
            "管理员",
            "操作员"});
            this.cbxUserType.Location = new System.Drawing.Point(846, 421);
            this.cbxUserType.Name = "cbxUserType";
            this.cbxUserType.Size = new System.Drawing.Size(126, 27);
            this.cbxUserType.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(651, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "用户";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(651, 549);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "确认密码";
            // 
            // txtConfirmNewPassWord
            // 
            this.txtConfirmNewPassWord.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtConfirmNewPassWord.Location = new System.Drawing.Point(846, 543);
            this.txtConfirmNewPassWord.Name = "txtConfirmNewPassWord";
            this.txtConfirmNewPassWord.PasswordChar = '*';
            this.txtConfirmNewPassWord.Size = new System.Drawing.Size(125, 29);
            this.txtConfirmNewPassWord.TabIndex = 24;
            // 
            // MainFormUserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtConfirmNewPassWord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOldPassWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPassWordManageFormOK);
            this.Controls.Add(this.txtNewPassWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxUserType);
            this.Controls.Add(this.label1);
            this.Name = "MainFormUserManager";
            this.Size = new System.Drawing.Size(1720, 1009);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOldPassWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPassWordManageFormOK;
        private System.Windows.Forms.TextBox txtNewPassWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxUserType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfirmNewPassWord;
    }
}
