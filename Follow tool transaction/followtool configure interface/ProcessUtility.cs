using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;
using DllImportAttribute = System.Runtime.InteropServices.DllImportAttribute;
using StringBuilder = System.Text.StringBuilder;

namespace SureWin
{
	/// <summary>
	/// 提供进程访问功能
	/// </summary>
	public static class ProcessUtility
	{
		/// <summary>
		/// 发送消息
		/// </summary>
		/// <returns>消息处理结果</returns>
		/// <param name="hWnd">窗口句柄</param>
		/// <param name="lParam">second message parameter</param>
		/// <param name="Msg">message</param>
		/// <param name="wParam">first message parameter</param>
		[DllImport("User32.dll", EntryPoint = "SendMessage")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, ref WindowMessageType lParam);

		/// <summary>
		/// 使指定窗口闪烁
		/// </summary>
		/// <param name="hWnd">窗口句柄</param>
		/// <param name="bInvert">是否反转的标志</param>
		/// <returns>如窗口在调用前处于活动状态，则返回TRUE（非零）。</returns>
		[DllImport("User32.dll", EntryPoint = "FlashWindow")]
		public static extern bool FlashWindow(IntPtr hWnd, bool bInvert);

		/// <summary>
		/// 使指定窗口闪烁
		/// </summary>
		/// <param name="hWnd">窗口句柄</param>
		/// <param name="nCmdShow">指定窗口如何显示</param>
		/// <returns>如果窗口当前可见，则返回值为非零。如果窗口当前被隐藏，则返回值为零。</returns>
		[DllImport("User32.dll", EntryPoint = "ShowWindow")]
		public static extern bool ShowWindow(IntPtr hWnd, ShowWindowCmds nCmdShow);

		/// <summary>
		/// //设置窗体为活动窗体
		/// </summary>
		/// <param name="hWnd">窗口句柄</param>
		/// <returns>如果窗口设入了前台，返回值为非零；如果窗口未被设入前台，返回值为零。</returns>
		[DllImport("User32.dll", EntryPoint = "SetForegroundWindow")]
		public static extern bool SetForegroundWindow(IntPtr hWnd);

		/// <summary>
		/// 写入私有配置文件
		/// </summary>
		/// <param name="section">配置节</param>
		/// <param name="key">键</param>
		/// <param name="val">值</param>
		/// <param name="filePath">文件路径</param>
		/// <returns>非零表示成功，零表示失败。</returns>
		[DllImport("kernel32", EntryPoint = "WritePrivateProfileString")]
		public static extern int WritePrivateProfileString(string section, string key, string val, string filePath);

		/// <summary>
		/// 读取私有配置文件
		/// </summary>
		/// <param name="section">配置节</param>
		/// <param name="key">键</param>
		/// <param name="def">默认值</param>
		/// <param name="retVal">读取到的值</param>
		/// <param name="size">字符串缓冲区大小</param>
		/// <param name="filePath">文件路径</param>
		/// <returns>复制到retVal缓冲区的字节数量，其中不包括那些NULL中止字符。如retVal缓冲区不够大，不能容下全部信息，就返回nSize-1（若lpApplicationName或lpKeyName为NULL，则返回nSize-2）</returns>
		[DllImport("kernel32", EntryPoint = "GetPrivateProfileString")]
		public static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

		/// <summary>
		/// 读取私有配置文件
		/// </summary>
		/// <param name="section">配置节</param>
		/// <param name="key">键</param>
		/// <param name="def">默认值</param>
		/// <param name="filePath">文件路径</param>
		/// <returns>读取到的值</returns>
		public static string GetPrivateProfileString(string section, string key, string def, string filePath)
		{
			StringBuilder sbuf = new StringBuilder(1024);
			GetPrivateProfileString(section, key, def, sbuf, 1024, filePath);
			return sbuf.ToString();
		}

		/// <summary>
		/// 发送文本消息
		/// </summary>
		/// <param name="hWnd">窗口句柄</param>
		/// <param name="Text">要发送的文本</param>
		/// <returns>消息处理结果</returns>
		public static int SendTextMessage(IntPtr hWnd, string Text)
		{
			WindowMessageType wmt = new WindowMessageType();
			wmt.dwData = (IntPtr)100;
			wmt.lpData = Text;
			wmt.cbData = (Text.Length + 1) * 2;
			return SendMessage(hWnd, 0x004A, 0, ref wmt);
		}

		/// <summary>
		/// 发送数值消息
		/// </summary>
		/// <param name="hWnd">窗口句柄</param>
		/// <param name="Msg">message</param>
		/// <param name="wParam">first message parameter</param>
		public static int SendMessage(IntPtr hWnd, int Msg, int wParam)
		{
			WindowMessageType wmt = new WindowMessageType();
			wmt.dwData = (IntPtr)100;
			return SendMessage(hWnd, Msg, wParam, ref wmt);
		}

		/// <summary>
		/// 获取其他正在运行的实例
		/// </summary>
		public static Process GetRunInstance()
		{
			System.Diagnostics.Process current = System.Diagnostics.Process.GetCurrentProcess();
			System.Diagnostics.Process[] ps = System.Diagnostics.Process.GetProcessesByName(current.ProcessName);

			foreach (System.Diagnostics.Process p in ps)
			{
				if (p.Id != current.Id)
					try
					{
						if (p.MainModule.FileName == current.MainModule.FileName)
							return p;
					}
					catch { }
			}
			return null;
		}

		/// <summary>
		/// 向管道发送字节消息
		/// </summary>
		/// <param name="PipeName">管道名称</param>
		/// <param name="Msg">字节消息</param>
		public static void SendPipeByte(string PipeName, byte Msg)
		{
			using (System.IO.Pipes.NamedPipeClientStream pipe = new System.IO.Pipes.NamedPipeClientStream(".", PipeName, System.IO.Pipes.PipeDirection.Out))
			{
				pipe.Connect(3000);
				pipe.WriteByte(Msg);
				pipe.Close();
			}
		}

		/// <summary>
		/// 检查是否只有一个实例
		/// </summary>
		/// <param name="args">命令行参数</param>
		/// <returns>true只有一个实例 false存在多个实例</returns>
		public static bool CheckOneInstance(string[] args)
		{
			System.Diagnostics.Process p = ProcessUtility.GetRunInstance();
			if (p == null) return true;

			try
			{
				ProcessUtility.FlashWindow(p.MainWindowHandle, true);
				if (args != null && args.Length > 0)
					ProcessUtility.SendTextMessage(p.MainWindowHandle, string.Join("\n", args));
				else
					ProcessUtility.SendMessage(p.MainWindowHandle, 0xA001, 0);
			}
			catch { }
			return false;
		}

		/// <summary>
		/// 调用运行系统命令
		/// </summary>
		/// <param name="Filename">命令</param>
		/// <param name="Arguments">参数</param>
		/// <returns>返回命令的返回值</returns>
		public static int RunCmd(string Filename, string Arguments)
		{
			ProcessStartInfo startInfo = new ProcessStartInfo(Filename, Arguments);
			startInfo.CreateNoWindow = true;
			startInfo.UseShellExecute = false;
			startInfo.RedirectStandardOutput = true;
			using (Process process = Process.Start(startInfo))
			{
				process.WaitForExit();
				return process.ExitCode;
			}
		}
	}//class


	/// <summary>
	/// 显示窗体的命令
	/// </summary>
	public enum ShowWindowCmds : int
	{
		/// <summary>隐藏窗口并激活其他窗口。</summary>
		SW_HIDE = 0,
		/// <summary>激活并显示一个窗口。如果窗口被最小化或最大化，系统将其恢复到原来的尺寸和大小。应用程序在第一次显示窗口的时候应该指定此标志。</summary>
		SW_SHOWNORMAL = 1,
		/// <summary>激活窗口并将其最大化。</summary>
		SW_SHOWMAXIMIZED = 2,
		/// <summary>激活窗口并将其最小化。</summary>
		SW_SHOWMINIMIZED = 3,
		/// <summary>最大化指定的窗口。</summary>
		SW_MAXIMIZE = 3,
		/// <summary>以窗口最近一次的大小和状态显示窗口。激活窗口仍然维持激活状态。</summary>
		SW_SHOWNOACTIVATE = 4,
		/// <summary>在窗口原来的位置以原来的尺寸激活和显示窗口。</summary>
		SW_SHOW = 5,
		/// <summary>最小化指定的窗口并且激活在Z序中的下一个顶层窗口。</summary>
		SW_MINIMIZE = 6,
		/// <summary>窗口最小化，激活窗口仍然维持激活状态。</summary>
		SW_SHOWMINNOACTIVE = 7,
		/// <summary>以窗口原来的状态显示窗口。激活窗口仍然维持激活状态。</summary>
		SW_SHOWNA = 8,
		/// <summary>激活并显示窗口。如果窗口最小化或最大化，则系统将窗口恢复到原来的尺寸和位置。在恢复最小化窗口时，应用程序应该指定这个标志。</summary>
		SW_RESTORE = 9,
		/// <summary>依据在STARTUPINFO结构中指定的SW_FLAG标志设定显示状态，STARTUPINFO 结构是由启动应用程序的程序传递给CreateProcess函数的。</summary>
		SW_SHOWDEFAULT = 10,
		/// <summary>在WindowNT5.0中最小化窗口，即使拥有窗口的线程被挂起也会最小化。在从其他线程最小化窗口时才使用这个参数。</summary>
		SW_FORCEMINIMIZE = 11,
		/// <summary></summary>
		SW_MAX = 11,
	}

	/// <summary>
	/// 进程间消息结构
	/// </summary>
	public struct WindowMessageType
	{
		/// <summary>
		/// 数据
		/// </summary>
		public IntPtr dwData;
		/// <summary>
		/// 数据长度
		/// </summary>
		public int cbData;
		/// <summary>
		/// 数据二进制内容
		/// </summary>
		[System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)]
		public string lpData;
	}//struct
}
