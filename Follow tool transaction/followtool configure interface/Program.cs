using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SureWin
{
	static class Program
	{
		/// <summary>
		/// 配置文件路径
		/// </summary>
		public static string ConfigFile
		{
			get;
			private set;
		}

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			ConfigFile = System.IO.Path.Combine(Application.StartupPath, "Config.ini");
			Application.Run(new ConfigForm());
		}
	}//class
}
