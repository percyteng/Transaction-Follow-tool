namespace SureWin
{
	partial class OutputConfigPanel
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
            this.txBrokerID = new System.Windows.Forms.TextBox();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.txUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txServer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.ndOpenFloatPrice = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ndOpenWaitTime = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ndOpenTryTimes = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.ndCloseFloatPrice = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.ndCloseTryTimes = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ckSimulate = new System.Windows.Forms.CheckBox();
            this.ndCloseWaitTime = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txAuthCode = new System.Windows.Forms.TextBox();
            this.cbInterfaceType = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.ndOpenRetryFloat = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ndCloseRetryFloat = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ndOpenFloatPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndOpenWaitTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndOpenTryTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndCloseFloatPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndCloseTryTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndCloseWaitTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndOpenRetryFloat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndCloseRetryFloat)).BeginInit();
            this.SuspendLayout();
            // 
            // txBrokerID
            // 
            this.txBrokerID.Location = new System.Drawing.Point(123, 188);
            this.txBrokerID.Name = "txBrokerID";
            this.txBrokerID.Size = new System.Drawing.Size(167, 21);
            this.txBrokerID.TabIndex = 11;
            // 
            // txPassword
            // 
            this.txPassword.Location = new System.Drawing.Point(123, 154);
            this.txPassword.Name = "txPassword";
            this.txPassword.PasswordChar = '*';
            this.txPassword.Size = new System.Drawing.Size(167, 21);
            this.txPassword.TabIndex = 9;
            // 
            // txUsername
            // 
            this.txUsername.Location = new System.Drawing.Point(123, 120);
            this.txUsername.Name = "txUsername";
            this.txUsername.Size = new System.Drawing.Size(167, 21);
            this.txUsername.TabIndex = 7;
            this.txUsername.TextChanged += new System.EventHandler(this.txUsername_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "期货公司代码:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "密码:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "用户名:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "服务器地址:";
            // 
            // txServer
            // 
            this.txServer.Location = new System.Drawing.Point(123, 222);
            this.txServer.Name = "txServer";
            this.txServer.Size = new System.Drawing.Size(167, 21);
            this.txServer.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "执行模式:";
            // 
            // cbMode
            // 
            this.cbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cbMode.Location = new System.Drawing.Point(123, 19);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(167, 20);
            this.cbMode.TabIndex = 1;
            this.cbMode.SelectedIndexChanged += new System.EventHandler(this.cbMode_SelectedIndexChanged);
            // 
            // ndOpenFloatPrice
            // 
            this.ndOpenFloatPrice.Location = new System.Drawing.Point(123, 325);
            this.ndOpenFloatPrice.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.ndOpenFloatPrice.Name = "ndOpenFloatPrice";
            this.ndOpenFloatPrice.Size = new System.Drawing.Size(83, 21);
            this.ndOpenFloatPrice.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "开仓第一次超价:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "开仓撤单等待:";
            // 
            // ndOpenWaitTime
            // 
            this.ndOpenWaitTime.Location = new System.Drawing.Point(123, 291);
            this.ndOpenWaitTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ndOpenWaitTime.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.ndOpenWaitTime.Name = "ndOpenWaitTime";
            this.ndOpenWaitTime.Size = new System.Drawing.Size(83, 21);
            this.ndOpenWaitTime.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(212, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "(秒)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 364);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 22;
            this.label11.Text = "开仓重试:";
            // 
            // ndOpenTryTimes
            // 
            this.ndOpenTryTimes.Location = new System.Drawing.Point(123, 360);
            this.ndOpenTryTimes.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.ndOpenTryTimes.Name = "ndOpenTryTimes";
            this.ndOpenTryTimes.Size = new System.Drawing.Size(83, 21);
            this.ndOpenTryTimes.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 469);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 12);
            this.label12.TabIndex = 31;
            this.label12.Text = "平仓第一次超价:";
            // 
            // ndCloseFloatPrice
            // 
            this.ndCloseFloatPrice.Location = new System.Drawing.Point(123, 465);
            this.ndCloseFloatPrice.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.ndCloseFloatPrice.Name = "ndCloseFloatPrice";
            this.ndCloseFloatPrice.Size = new System.Drawing.Size(83, 21);
            this.ndCloseFloatPrice.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 504);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 34;
            this.label13.Text = "平仓重试:";
            // 
            // ndCloseTryTimes
            // 
            this.ndCloseTryTimes.Location = new System.Drawing.Point(123, 500);
            this.ndCloseTryTimes.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.ndCloseTryTimes.Name = "ndCloseTryTimes";
            this.ndCloseTryTimes.Size = new System.Drawing.Size(83, 21);
            this.ndCloseTryTimes.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(212, 364);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 24;
            this.label14.Text = "(次)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(212, 504);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 36;
            this.label15.Text = "(次)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 4;
            this.label16.Text = "模拟盘:";
            // 
            // ckSimulate
            // 
            this.ckSimulate.AutoSize = true;
            this.ckSimulate.Location = new System.Drawing.Point(123, 89);
            this.ckSimulate.Name = "ckSimulate";
            this.ckSimulate.Size = new System.Drawing.Size(15, 14);
            this.ckSimulate.TabIndex = 5;
            this.ckSimulate.UseVisualStyleBackColor = true;
            // 
            // ndCloseWaitTime
            // 
            this.ndCloseWaitTime.Location = new System.Drawing.Point(123, 430);
            this.ndCloseWaitTime.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.ndCloseWaitTime.Name = "ndCloseWaitTime";
            this.ndCloseWaitTime.Size = new System.Drawing.Size(83, 21);
            this.ndCloseWaitTime.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 434);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 12);
            this.label17.TabIndex = 28;
            this.label17.Text = "平仓撤单等待:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(212, 434);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 12);
            this.label18.TabIndex = 30;
            this.label18.Text = "(秒)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(22, 260);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 12);
            this.label19.TabIndex = 14;
            this.label19.Text = "授权代码:";
            // 
            // txAuthCode
            // 
            this.txAuthCode.Location = new System.Drawing.Point(123, 256);
            this.txAuthCode.Name = "txAuthCode";
            this.txAuthCode.Size = new System.Drawing.Size(167, 21);
            this.txAuthCode.TabIndex = 15;
            // 
            // cbInterfaceType
            // 
            this.cbInterfaceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInterfaceType.FormattingEnabled = true;
            this.cbInterfaceType.Location = new System.Drawing.Point(123, 53);
            this.cbInterfaceType.Name = "cbInterfaceType";
            this.cbInterfaceType.Size = new System.Drawing.Size(167, 20);
            this.cbInterfaceType.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(22, 56);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 12);
            this.label20.TabIndex = 2;
            this.label20.Text = "接口类型:";
            // 
            // ndOpenRetryFloat
            // 
            this.ndOpenRetryFloat.Location = new System.Drawing.Point(123, 395);
            this.ndOpenRetryFloat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ndOpenRetryFloat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndOpenRetryFloat.Name = "ndOpenRetryFloat";
            this.ndOpenRetryFloat.Size = new System.Drawing.Size(83, 21);
            this.ndOpenRetryFloat.TabIndex = 26;
            this.ndOpenRetryFloat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(22, 399);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(95, 12);
            this.label21.TabIndex = 25;
            this.label21.Text = "开仓重试超价差:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 539);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 37;
            this.label5.Text = "平仓重试超价差:";
            // 
            // ndCloseRetryFloat
            // 
            this.ndCloseRetryFloat.Location = new System.Drawing.Point(123, 535);
            this.ndCloseRetryFloat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndCloseRetryFloat.Name = "ndCloseRetryFloat";
            this.ndCloseRetryFloat.Size = new System.Drawing.Size(83, 21);
            this.ndCloseRetryFloat.TabIndex = 38;
            this.ndCloseRetryFloat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "(倍最小变动价位)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(212, 399);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(101, 12);
            this.label22.TabIndex = 27;
            this.label22.Text = "(倍最小变动价位)";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(212, 469);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(101, 12);
            this.label23.TabIndex = 33;
            this.label23.Text = "(倍最小变动价位)";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(212, 539);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(101, 12);
            this.label24.TabIndex = 39;
            this.label24.Text = "(倍最小变动价位)";
            // 
            // OutputConfigPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(5, 20);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.ndCloseRetryFloat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ndOpenRetryFloat);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.cbInterfaceType);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.ndCloseWaitTime);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.ckSimulate);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ndCloseTryTimes);
            this.Controls.Add(this.ndOpenTryTimes);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ndOpenWaitTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ndCloseFloatPrice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ndOpenFloatPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbMode);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txAuthCode);
            this.Controls.Add(this.txServer);
            this.Controls.Add(this.txBrokerID);
            this.Controls.Add(this.txPassword);
            this.Controls.Add(this.txUsername);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OutputConfigPanel";
            this.Size = new System.Drawing.Size(331, 587);
            ((System.ComponentModel.ISupportInitialize)(this.ndOpenFloatPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndOpenWaitTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndOpenTryTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndCloseFloatPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndCloseTryTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndCloseWaitTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndOpenRetryFloat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndCloseRetryFloat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txBrokerID;
		private System.Windows.Forms.TextBox txPassword;
		private System.Windows.Forms.TextBox txUsername;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txServer;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbMode;
		private System.Windows.Forms.NumericUpDown ndOpenFloatPrice;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.NumericUpDown ndOpenWaitTime;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.NumericUpDown ndOpenTryTimes;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.NumericUpDown ndCloseFloatPrice;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.NumericUpDown ndCloseTryTimes;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.CheckBox ckSimulate;
		private System.Windows.Forms.NumericUpDown ndCloseWaitTime;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox txAuthCode;
		private System.Windows.Forms.ComboBox cbInterfaceType;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.NumericUpDown ndOpenRetryFloat;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown ndCloseRetryFloat;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
	}
}
