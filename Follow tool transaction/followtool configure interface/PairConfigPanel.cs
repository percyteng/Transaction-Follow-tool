using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace SureWin
{
	/// <summary>
	/// 配对面板
	/// </summary>
	public partial class PairConfigPanel : UserControl
	{
		//输出面板
		private OutputConfigPanel outputPanel;
		//输入面板
		private InputConfigPanel inputPanel;

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
			get { return this.txInputUser.Text; }
			set { this.txInputUser.Text = value; }
		}

		/// <summary>
		/// 构造一个新实例
		/// </summary>
		/// <param name="inputPanel">输入面板</param>
		/// <param name="outputPanel">输出面板</param>
		public PairConfigPanel(OutputConfigPanel outputPanel, InputConfigPanel inputPanel)
		{
			this.outputPanel = outputPanel;
			this.inputPanel = inputPanel;
			this.inputPanel.UserNameChanged += inputPanel_UserNameChanged;
			this.InitializeComponent();
		}

		/// <summary>
		/// 输入用户名改变时该方法被调用
		/// </summary>
		void inputPanel_UserNameChanged(object sender, EventArgs e)
		{
			this.txInputUser.Text = this.inputPanel.UserName;
			this.Node.Name =
			this.Node.Text = this.inputPanel.UserName;
		}

		/// <summary>
		/// 读取输入配置
		/// </summary>
		/// <param name="Key">键</param>
		/// <param name="Def">默认值</param>
		public static string GetProfile(string Key, string Def)
		{
			return ProcessUtility.GetPrivateProfileString("RelationShip", Key, Def, Program.ConfigFile);
		}

		/// <summary>
		/// 读取配置
		/// </summary>
		/// <param name="index">配置索引</param>
		public void ReadConfig(int index)
		{
			string si = (index + 1).ToString();
			decimal dTemp;
			if (decimal.TryParse(GetProfile("Multiple_" + si, "0"), out dTemp))
				this.ndMultiple.Value = dTemp;
			this.txProductFilter.Text = GetProfile("Instruments_" + si, "");
		}

		/// <summary>
		/// 写入配置
		/// </summary>
		/// <param name="index">配置索引</param>
		/// <param name="writer">文本写入器</param>
		public void WriteConfig(int index, TextWriter writer)
		{
			string si = (index + 1).ToString();
			writer.WriteLine("Out_{0}={1}", si, this.outputPanel.UserName);
			writer.WriteLine("In_{0}={1}", si, this.inputPanel.UserName);
			writer.WriteLine("Multiple_{0}={1}", si, this.ndMultiple.Value.ToString());
			writer.WriteLine("Instruments_{0}={1}", si, this.txProductFilter.Text);
		}

        private void PairConfigPanel_Load(object sender, EventArgs e)
        {

        }
	}//class
}
