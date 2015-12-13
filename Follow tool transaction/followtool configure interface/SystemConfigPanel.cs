using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace SureWin
{
	/// <summary>
	/// 系统配置面板
	/// </summary>
	public partial class SystemConfigPanel : UserControl
	{
		/// <summary>
		/// 构造一个新实例
		/// </summary>
		public SystemConfigPanel()
		{
			this.InitializeComponent();
			System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
			this.label1.Text += assembly.GetName().Version.ToString();
	}
	}//class
}
