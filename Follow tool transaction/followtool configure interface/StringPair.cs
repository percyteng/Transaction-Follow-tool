using System;

namespace SureWin
{
	/// <summary>
	/// 字符串对
	/// </summary>
	class StringPair
	{
		/// <summary>
		/// 键
		/// </summary>
		public string Name { get; private set; }

		/// <summary>
		/// 值
		/// </summary>
		public string Value { get; private set; }

		/// <summary>
		/// 构造一个新实例
		/// </summary>
		/// <param name="Name">键</param>
		/// <param name="Value">值</param>
		public StringPair(string Name, string Value)
		{
			this.Name = Name;
			this.Value = Value;
		}
	}//class
}
