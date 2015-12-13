namespace SureWin
{
	partial class InputConfigPanel
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
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txUsername = new System.Windows.Forms.TextBox();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txBrokerID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbInterfaceType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txLicenseStr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txLicenseFileName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txServer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txEntrustType = new System.Windows.Forms.TextBox();
            this.btnBrowserLicenseFile = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "密码:";
            // 
            // txUsername
            // 
            this.txUsername.Location = new System.Drawing.Point(111, 52);
            this.txUsername.Name = "txUsername";
            this.txUsername.Size = new System.Drawing.Size(167, 21);
            this.txUsername.TabIndex = 3;
            this.txUsername.TextChanged += new System.EventHandler(this.txUsername_TextChanged);
            // 
            // txPassword
            // 
            this.txPassword.Location = new System.Drawing.Point(111, 86);
            this.txPassword.Name = "txPassword";
            this.txPassword.PasswordChar = '*';
            this.txPassword.Size = new System.Drawing.Size(167, 21);
            this.txPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "期货公司代码:";
            // 
            // txBrokerID
            // 
            this.txBrokerID.Location = new System.Drawing.Point(111, 120);
            this.txBrokerID.Name = "txBrokerID";
            this.txBrokerID.Size = new System.Drawing.Size(167, 21);
            this.txBrokerID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "接口类型:";
            // 
            // cbInterfaceType
            // 
            this.cbInterfaceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInterfaceType.FormattingEnabled = true;
            this.cbInterfaceType.Location = new System.Drawing.Point(111, 19);
            this.cbInterfaceType.Name = "cbInterfaceType";
            this.cbInterfaceType.Size = new System.Drawing.Size(167, 20);
            this.cbInterfaceType.TabIndex = 1;
            this.cbInterfaceType.SelectedIndexChanged += new System.EventHandler(this.cbInterfaceType_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "授权代码:";
            // 
            // txLicenseStr
            // 
            this.txLicenseStr.Location = new System.Drawing.Point(111, 188);
            this.txLicenseStr.Name = "txLicenseStr";
            this.txLicenseStr.Size = new System.Drawing.Size(167, 21);
            this.txLicenseStr.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "授权文件:";
            // 
            // txLicenseFileName
            // 
            this.txLicenseFileName.Location = new System.Drawing.Point(111, 222);
            this.txLicenseFileName.Name = "txLicenseFileName";
            this.txLicenseFileName.Size = new System.Drawing.Size(167, 21);
            this.txLicenseFileName.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "服务器地址:";
            // 
            // txServer
            // 
            this.txServer.Location = new System.Drawing.Point(111, 154);
            this.txServer.Name = "txServer";
            this.txServer.Size = new System.Drawing.Size(167, 21);
            this.txServer.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "委托方式:";
            // 
            // txEntrustType
            // 
            this.txEntrustType.Location = new System.Drawing.Point(111, 256);
            this.txEntrustType.MaxLength = 5;
            this.txEntrustType.Name = "txEntrustType";
            this.txEntrustType.Size = new System.Drawing.Size(167, 21);
            this.txEntrustType.TabIndex = 16;
            // 
            // btnBrowserLicenseFile
            // 
            this.btnBrowserLicenseFile.Image = global::SureWin.Properties.Resources.browser;
            this.btnBrowserLicenseFile.Location = new System.Drawing.Point(281, 221);
            this.btnBrowserLicenseFile.Name = "btnBrowserLicenseFile";
            this.btnBrowserLicenseFile.Size = new System.Drawing.Size(27, 23);
            this.btnBrowserLicenseFile.TabIndex = 14;
            this.toolTip.SetToolTip(this.btnBrowserLicenseFile, "浏览授权文件…");
            this.btnBrowserLicenseFile.UseVisualStyleBackColor = true;
            this.btnBrowserLicenseFile.Click += new System.EventHandler(this.btnBrowserLicenseFile_Click);
            // 
            // InputConfigPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.btnBrowserLicenseFile);
            this.Controls.Add(this.cbInterfaceType);
            this.Controls.Add(this.txEntrustType);
            this.Controls.Add(this.txLicenseFileName);
            this.Controls.Add(this.txServer);
            this.Controls.Add(this.txLicenseStr);
            this.Controls.Add(this.txBrokerID);
            this.Controls.Add(this.txPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txUsername);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "InputConfigPanel";
            this.Size = new System.Drawing.Size(311, 298);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txUsername;
		private System.Windows.Forms.TextBox txPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txBrokerID;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbInterfaceType;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txLicenseStr;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txLicenseFileName;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txServer;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txEntrustType;
		private System.Windows.Forms.Button btnBrowserLicenseFile;
		private System.Windows.Forms.ToolTip toolTip;
	}
}
