namespace SureWin
{
	partial class PairConfigPanel
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
			this.inputPanel.UserNameChanged -= this.inputPanel_UserNameChanged;
		}

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ndMultiple = new System.Windows.Forms.NumericUpDown();
            this.txInputUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txProductFilter = new System.Windows.Forms.TextBox();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ndMultiple)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "输入用户:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "倍率:";
            // 
            // ndMultiple
            // 
            this.ndMultiple.Location = new System.Drawing.Point(86, 52);
            this.ndMultiple.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.ndMultiple.Name = "ndMultiple";
            this.ndMultiple.Size = new System.Drawing.Size(60, 21);
            this.ndMultiple.TabIndex = 3;
            this.ndMultiple.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // txInputUser
            // 
            this.txInputUser.Location = new System.Drawing.Point(86, 19);
            this.txInputUser.Name = "txInputUser";
            this.txInputUser.ReadOnly = true;
            this.txInputUser.Size = new System.Drawing.Size(146, 21);
            this.txInputUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "品种筛选:";
            // 
            // txProductFilter
            // 
            this.txProductFilter.Location = new System.Drawing.Point(86, 89);
            this.txProductFilter.Multiline = true;
            this.txProductFilter.Name = "txProductFilter";
            this.txProductFilter.Size = new System.Drawing.Size(146, 52);
            this.txProductFilter.TabIndex = 5;
            this.txProductFilter.Text = "ALL";
            this.mainToolTip.SetToolTip(this.txProductFilter, "配置要跟单的特定品种，配置格式如：\r\nIF|SR|ru\r\n该字段填“ALL”，跟单所有品种。\r\n若该字段留空，则禁用所有品种。");
            // 
            // PairConfigPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.txProductFilter);
            this.Controls.Add(this.txInputUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ndMultiple);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "PairConfigPanel";
            this.Size = new System.Drawing.Size(268, 156);
            this.Load += new System.EventHandler(this.PairConfigPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ndMultiple)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown ndMultiple;
		private System.Windows.Forms.TextBox txInputUser;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txProductFilter;
		private System.Windows.Forms.ToolTip mainToolTip;
	}
}
