using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SureWin
{
	/// <summary>
	/// 输出配置面板
	/// </summary>
	public partial class OutputConfigPanel : UserControl
	{
		/// <summary>
		/// 获取或设置关联节点
		/// </summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public TreeNode Node
		{
			get;
			set;
		}

		/// <summary>
		/// 获取或设置用户名
		/// </summary>
		public string UserName
		{
			get { return this.txUsername.Text; }
			set { this.txUsername.Text = value; }
		}

		/// <summary>
		/// 构造一个新实例
		/// </summary>
		public OutputConfigPanel()
		{
			this.InitializeComponent();
			this.cbMode.SelectedIndex = 1;
			this.cbInterfaceType.DataSource = new StringPair[] {
				new StringPair("CTP", "1"),
				//new StringPair("恒生", "2"),
				//new StringPair("金仕达", "3"),
				//new StringPair("融航", "4"),
                //new StringPair("彭博", "5"),
				//new StringPair("金牛", "6"),
				new StringPair("速胜", "7"),
			};
			this.cbInterfaceType.DisplayMember = "Name";
			this.cbInterfaceType.ValueMember = "Value";
			this.cbInterfaceType.SelectedIndex = 0;
		}

		/// <summary>
		/// 用户名修改时
		/// </summary>
		private void txUsername_TextChanged(object sender, EventArgs e)
		{
			if (this.Node != null)
			{
				this.Node.Name =
				this.Node.Text = this.txUsername.Text;
			}
		}

		/// <summary>
		/// 读取输入配置
		/// </summary>
		/// <param name="Key">键</param>
		/// <param name="Def">默认值</param>
		public static string GetProfile(string Key, string Def)
		{
			return ProcessUtility.GetPrivateProfileString("TraderOut", Key, Def, Program.ConfigFile);
		}

		/// <summary>
		/// 读取配置
		/// </summary>
		/// <param name="index">配置索引</param>
		public void ReadConfig(int index)
		{
			decimal dTemp;
			string si = (index + 1).ToString();
			this.cbMode.SelectedItem = GetProfile("Mode_" + si, "B");
			this.cbInterfaceType.SelectedValue = GetProfile("Type_" + si, "1");
			if (decimal.TryParse(GetProfile("SimMode_" + si, "0"), out dTemp))
				this.ckSimulate.Checked = (dTemp == 1);
			this.txUsername.Text = GetProfile("UserID_" + si, "");
			this.txPassword.Text = GetProfile("UserPWD_" + si, "");
			this.txBrokerID.Text = GetProfile("BrokerID_" + si, "");
			this.txServer.Text = GetProfile("Trade_" + si, "");
			this.txAuthCode.Text = GetProfile("AuthCode_" + si, "");
			if (decimal.TryParse(GetProfile("OpenWaitTime_" + si, "0"), out dTemp))
				this.ndOpenWaitTime.Value = dTemp;
			if (decimal.TryParse(GetProfile("OpenFloatPrice_" + si, "0"), out dTemp))
				this.ndOpenFloatPrice.Value = dTemp;
			if (decimal.TryParse(GetProfile("OpenTryTimes_" + si, "0"), out dTemp))
				this.ndOpenTryTimes.Value = dTemp;
			if (decimal.TryParse(GetProfile("OpenRetryFloat_" + si, "1"), out dTemp))
				this.ndOpenRetryFloat.Value = dTemp;
			if (decimal.TryParse(GetProfile("CloseWaitTime_" + si, "0"), out dTemp))
				this.ndCloseWaitTime.Value = dTemp;
			if (decimal.TryParse(GetProfile("CloseFloatPrice_" + si, "0"), out dTemp))
				this.ndCloseFloatPrice.Value = dTemp;
			if (decimal.TryParse(GetProfile("CloseTryTimes_" + si, "0"), out dTemp))
				this.ndCloseTryTimes.Value = dTemp;
			if (decimal.TryParse(GetProfile("CloseRetryFloat_" + si, "1"), out dTemp))
				this.ndCloseRetryFloat.Value = dTemp;
		}

		/// <summary>
		/// 写入配置
		/// </summary>
		/// <param name="index">配置索引</param>
		/// <param name="writer">文本写入器</param>
		public void WriteConfig(int index, TextWriter writer)
		{
			string si = (index + 1).ToString();
			writer.WriteLine("Mode_{0}={1}", si, this.cbMode.SelectedItem);
			writer.WriteLine("Type_{0}={1}", si, this.cbInterfaceType.SelectedValue);
			writer.WriteLine("SimMode_{0}={1}", si, this.ckSimulate.Checked ? "1" : "0");
			writer.WriteLine("UserID_{0}={1}", si, this.txUsername.Text);
			writer.WriteLine("UserPWD_{0}={1}", si, this.txPassword.Text);
			writer.WriteLine("BrokerID_{0}={1}", si, this.txBrokerID.Text);
			writer.WriteLine("Trade_{0}={1}", si, this.txServer.Text);
			writer.WriteLine("AuthCode_{0}={1}", si, this.txAuthCode.Text);
			writer.WriteLine("OpenWaitTime_{0}={1}", si, this.ndOpenWaitTime.Value.ToString());
			writer.WriteLine("OpenFloatPrice_{0}={1}", si, this.ndOpenFloatPrice.Value.ToString());
			writer.WriteLine("OpenTryTimes_{0}={1}", si, this.ndOpenTryTimes.Value.ToString());
			writer.WriteLine("OpenRetryFloat_{0}={1}", si, this.ndOpenRetryFloat.Value.ToString());
			writer.WriteLine("CloseWaitTime_{0}={1}", si, this.ndCloseWaitTime.Value.ToString());
			writer.WriteLine("CloseFloatPrice_{0}={1}", si, this.ndCloseFloatPrice.Value.ToString());
			writer.WriteLine("CloseTryTimes_{0}={1}", si, this.ndCloseTryTimes.Value.ToString());
			writer.WriteLine("CloseRetryFloat_{0}={1}", si, this.ndCloseRetryFloat.Value.ToString());
		}

		/// <summary>
		/// 绘图
		/// </summary>
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics g = e.Graphics;
			g.TranslateTransform(this.AutoScrollPosition.X, this.AutoScrollPosition.Y);
			g.DrawLine(Pens.Gray, 20, 282, Width - 50, 282);
			g.DrawLine(Pens.Gray, 20, 422, Width - 50, 422);
		}

		/// <summary>
		/// 重新调整尺寸时
		/// </summary>
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			this.Invalidate(false);
		}

        private void cbMode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
	}//class
}
