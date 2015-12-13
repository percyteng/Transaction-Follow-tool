using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace SureWin
{
	/// <summary>
	/// 输入配置面板
	/// </summary>
	public partial class InputConfigPanel : UserControl
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
		/// 用户名改变时该事件被触发
		/// </summary>
		public event EventHandler UserNameChanged
		{
			add { this.txUsername.TextChanged += value; }
			remove { this.txUsername.TextChanged -= value; }
		}

		/// <summary>
		/// 构造一个新实例
		/// </summary>
		public InputConfigPanel()
		{
			this.InitializeComponent();
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

		//用户选择模式时
		private void cbInterfaceType_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (this.cbInterfaceType.SelectedIndex)
			{
                //case 1:
                //    this.txBrokerID.Enabled = false;
                //    this.txLicenseFileName.Enabled = true;
                //    this.btnBrowserLicenseFile.Enabled = true;
                //    this.txEntrustType.Enabled = true;
                //    return;
				default:
					this.txBrokerID.Enabled = true;
					this.txLicenseFileName.Enabled = false;
					this.btnBrowserLicenseFile.Enabled = false;
					this.txEntrustType.Enabled = false;
					return;
			}
		}

		/// <summary>
		/// 读取输入配置
		/// </summary>
		/// <param name="Key">键</param>
		/// <param name="Def">默认值</param>
		public static string GetProfile(string Key, string Def)
		{
			return ProcessUtility.GetPrivateProfileString("TraderIn", Key, Def, Program.ConfigFile);
		}

		/// <summary>
		/// 读取配置
		/// </summary>
		/// <param name="index">配置索引</param>
		public void ReadConfig(int index)
		{
			string si = (index + 1).ToString();
			this.cbInterfaceType.SelectedValue = GetProfile("Type_" + si, "1");
			this.txUsername.Text = GetProfile("UserID_" + si, "");
			this.txPassword.Text = GetProfile("UserPWD_" + si, "");
			this.txServer.Text = GetProfile("Trade_" + si, "");
			this.txBrokerID.Text = GetProfile("BrokerID_" + si, "");
			this.txLicenseStr.Text = GetProfile("LicenseStr_" + si, "");
			this.txLicenseFileName.Text = GetProfile("LicenseFileName_" + si, "");
			this.txEntrustType.Text = GetProfile("EntrustType_" + si, "");
		}

		/// <summary>
		/// 写入配置
		/// </summary>
		/// <param name="index">配置索引</param>
		/// <param name="writer">文本写入器</param>
		public void WriteConfig(int index, TextWriter writer)
		{
			string si = (index + 1).ToString();
			writer.WriteLine("Type_{0}={1}", si, this.cbInterfaceType.SelectedValue.ToString());
			writer.WriteLine("UserID_{0}={1}", si, this.txUsername.Text);
			writer.WriteLine("UserPWD_{0}={1}", si, this.txPassword.Text);
			writer.WriteLine("Trade_{0}={1}", si, this.txServer.Text);
			writer.WriteLine("LicenseStr_{0}={1}", si, this.txLicenseStr.Text.Trim());
			switch (this.cbInterfaceType.SelectedIndex)
			{
                //case 1:
                //    writer.WriteLine("LicenseFileName_{0}={1}", si, this.txLicenseFileName.Text);
                //    writer.WriteLine("EntrustType_{0}={1}", si, this.txEntrustType.Text);
                //    break;
				default:
					writer.WriteLine("BrokerID_{0}={1}", si, this.txBrokerID.Text);
					break;
			}
		}

		/// <summary>
		/// 浏览证书文件
		/// </summary>
		private void btnBrowserLicenseFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Title = "选择证书文件";
			dialog.FileName = this.txLicenseFileName.Text;
			if (dialog.ShowDialog(this) == DialogResult.OK)
			{
				this.txLicenseFileName.Text = dialog.FileName;
			}
		}
	}//class
}
