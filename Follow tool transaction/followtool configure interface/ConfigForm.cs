using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SureWin
{
	using Auth;

	public partial class ConfigForm : Form
	{
		//系统配置节点
		private TreeNode systemConfigNode;
		//输入用户配置节点
		private TreeNode inputNode;
		//输出用户配置节点
		private TreeNode outputNode;

		/// <summary>
		/// 获取输入账户数量
		/// </summary>
		public int InputCount
		{
			get { return this.inputNode.Nodes.Count; }
		}

		/// <summary>
		/// 获取输出账户数量
		/// </summary>
		public int OutputCount
		{
			get { return this.outputNode.Nodes.Count; }
		}

		/// <summary>
		/// 配对的数量
		/// </summary>
		public int PairsCount
		{
			get
			{
				int count = 0;
				foreach (TreeNode node in this.outputNode.Nodes)
					count += node.Nodes.Count;
				return count;
			}
		}

		/// <summary>
		/// 构造一个新实例
		/// </summary>
		public ConfigForm()
		{
			this.InitializeComponent();

			this.systemConfigNode = new TreeNode("系统配置");
			this.systemConfigNode.Name = "系统配置";
			{
				SystemConfigPanel panel = new SystemConfigPanel();
				this.SetConfigPanel(panel);
				this.systemConfigNode.Tag = panel;
			}
			this.consoleTree.Nodes.Add(systemConfigNode);

			this.inputNode = new TreeNode("输入用户配置");
			this.inputNode.Name = "输入用户配置";
			this.inputNode.ContextMenuStrip = this.inputRootContextMenu;
			this.inputNode.SelectedImageKey =
			this.inputNode.ImageKey = "inUser";
			this.consoleTree.Nodes.Add(this.inputNode);

			this.outputNode = new TreeNode("输出用户配置");
			this.outputNode.Name = "输出用户配置";
			this.outputNode.ContextMenuStrip = this.outputRootContextMenu;
			this.outputNode.SelectedImageKey =
			this.outputNode.ImageKey = "outUser";
			this.consoleTree.Nodes.Add(this.outputNode);
		}

		/// <summary>
		/// 窗体载入时该方法被调用
		/// </summary>
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			try
			{
				this.ReadConfig();
				this.BeginInvoke(new MethodInvoker(this.CheckAuth));
			}
			catch (Exception exp)
			{
				MessageBox.Show(this, "配置读取失败，" + exp.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		/// <summary>
		/// 检查授权
		/// </summary>
		private void CheckAuth()
		{
			try
			{
				AuthClient.CheckAuth(new Guid("{D0324D16-A83E-44AC-9392-DE391D110C98}"), "跟单工具1.0", true);
			}
			catch (OperationCanceledException)
			{
				return;
			}
			catch (AuthException)
			{
				return;
			}
			catch (Exception exp)
			{
				MessageBox.Show("进行授权操作时发生错误，" + exp.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
		}

		/// <summary>
		/// 重新读取配置
		/// </summary>
		public void ReadConfig()
		{
			this.inputNode.Nodes.Clear();
			this.outputNode.Nodes.Clear();

			int count;

			count = int.Parse(ProcessUtility.GetPrivateProfileString("TraderIn", "Count", "0", Program.ConfigFile));
			for (int i = 0; i < count; i++)
			{
				TreeNode node = this.CreateInput("-");
				((InputConfigPanel)node.Tag).ReadConfig(i);
			}

			count = int.Parse(ProcessUtility.GetPrivateProfileString("TraderOut", "Count", "0", Program.ConfigFile));
			for (int i = 0; i < count; i++)
			{
				TreeNode node = this.CreateOutput("-");
				((OutputConfigPanel)node.Tag).ReadConfig(i);
			}

			count = int.Parse(ProcessUtility.GetPrivateProfileString("RelationShip", "Count", "0", Program.ConfigFile));
			for (int i = 0; i < count; i++)
			{
				string si = (i + 1).ToString();
				TreeNode outNode = this.outputNode.Nodes[PairConfigPanel.GetProfile("Out_" + si, "")];
				if (outNode == null)
					continue;
				TreeNode inNode = this.inputNode.Nodes[PairConfigPanel.GetProfile("In_" + si, "")];
				if (inNode == null)
					continue;
				TreeNode node = this.CreatePair(inNode, outNode);
				((PairConfigPanel)node.Tag).ReadConfig(i);
			}
		}

		/// <summary>
		/// 通用设置配置面板
		/// </summary>
		private void SetConfigPanel(UserControl panel)
		{
			panel.Dock = DockStyle.Fill;
			panel.BorderStyle = BorderStyle.FixedSingle;
			panel.BackColor = Color.White;
		}

		/// <summary>
		/// 当节点被单击时
		/// </summary>
		private void consoleTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
				this.consoleTree.SelectedNode = e.Node;
		}

		/// <summary>
		/// 选择节点时该方法被触发
		/// </summary>
        private void consoleTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.Collapse || e.Action == TreeViewAction.Expand)
                return;

            UserControl uc = e.Node.Tag as UserControl;
            if (uc != null)
            {
                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(uc);
            }
        }

		/// <summary>
		/// 新建输出账户
		/// </summary>
		private void cmNewOutput_Click(object sender, EventArgs e)
		{
			this.CreateOutput("<新输出用户>");
		}

		/// <summary>
		/// 创建输出用户
		/// </summary>
		/// <param name="Name">输出用户名</param>
		public TreeNode CreateOutput(string Name)
		{
			OutputConfigPanel panel = new OutputConfigPanel();
			this.SetConfigPanel(panel);
			TreeNode node = new TreeNode("<新输出用户>");
			panel.Node = node;
			node.ContextMenuStrip = this.outputContextMenu;
			node.Tag = panel;
			node.ImageKey =
			node.SelectedImageKey = "outIcon";
			this.outputNode.Nodes.Add(node);
			this.consoleTree.SelectedNode = node;
			return node;
		}

		/// <summary>
		/// 新建输入账户
		/// </summary>
		private void cmNewInput_Click(object sender, EventArgs e)
		{
			this.CreateInput("<新输入用户>");
		}

		/// <summary>
		/// 创建输入用户
		/// </summary>
		/// <param name="Name">输入用户名</param>
		public TreeNode CreateInput(string Name)
		{
			InputConfigPanel panel = new InputConfigPanel();
			this.SetConfigPanel(panel);
			TreeNode node = new TreeNode(Name);
			panel.Node = node;
			node.ContextMenuStrip = this.inputContextMenu;
			node.Tag = panel;
			node.ImageKey =
			node.SelectedImageKey = "inIcon";
			this.inputNode.Nodes.Add(node);
			this.consoleTree.SelectedNode = node;
			return node;
		}

		/// <summary>
		/// 删除用户
		/// </summary>
		private void cmDelete_Click(object sender, EventArgs e)
		{
			TreeNode node = this.consoleTree.SelectedNode;
			node.Remove();
			((UserControl)node.Tag).Dispose();
		}

		/// <summary>
		/// 删除输入用户
		/// </summary>
		private void cmDeleteInput_Click(object sender, EventArgs e)
		{
			TreeNode inNode = this.consoleTree.SelectedNode;
			foreach (TreeNode outNode in this.outputNode.Nodes)
			{
				outNode.Nodes.RemoveByKey(inNode.Text);
			}
			inNode.Remove();
			((IDisposable)inNode.Tag).Dispose();
		}

		//开始拖动项目
		private void consoleTree_ItemDrag(object sender, ItemDragEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				TreeNode moveNode = e.Item as TreeNode;
				if (moveNode != null && moveNode.Tag is InputConfigPanel)
				{
					this.DoDragDrop(e.Item, DragDropEffects.Move);
				}
			}
		}

		//拖动进入
		void consoleTree_DragEnter(object sender, DragEventArgs e)
		{
			TreeNode moveNode = e.Data.GetData("System.Windows.Forms.TreeNode") as TreeNode;
			if (moveNode != null)
			{
				e.Effect = DragDropEffects.Move;
				return;
			}
			e.Effect = DragDropEffects.None;
		}

		//结束拖动
		void consoleTree_DragDrop(object sender, DragEventArgs e)
		{
			TreeNode moveNode = e.Data.GetData("System.Windows.Forms.TreeNode") as TreeNode;
			if (moveNode != null)
			{
				TreeNode targetNode = consoleTree.GetNodeAt(consoleTree.PointToClient(new Point(e.X, e.Y)));
				if (targetNode != null)
				{
					if (targetNode.Tag is OutputConfigPanel)
					{
						DragNodeEnter(moveNode, targetNode);
					}
					else if (targetNode.Tag is PairConfigPanel)
					{
						DragNodeEnter(moveNode, targetNode.Parent);
					}
				}
			}
		}

		//新建拖动节点,如果已存在则不新建
		private void DragNodeEnter(TreeNode moveNode, TreeNode targetNode)
		{
			if (targetNode.Nodes.ContainsKey(moveNode.Text))
				return;
			this.CreatePair(moveNode, targetNode);
		}

		/// <summary>
		/// 创建配对节点
		/// </summary>
		/// <param name="inNode">输入节点</param>
		/// <param name="outNode">输出节点</param>
		public TreeNode CreatePair(TreeNode inNode, TreeNode outNode)
		{
			TreeNode pairNode = outNode.Nodes.Add(inNode.Text);
			PairConfigPanel panel = new PairConfigPanel((OutputConfigPanel)outNode.Tag, (InputConfigPanel)inNode.Tag);
			panel.UserName = inNode.Text;
			panel.Node = pairNode;
			pairNode.Tag = panel;
			pairNode.Name = inNode.Text;
			pairNode.ContextMenuStrip = pairContextMenu;
			pairNode.ImageKey =
			pairNode.SelectedImageKey = "inIcon";
			this.SetConfigPanel(panel);
			this.consoleTree.SelectedNode = pairNode;
			return pairNode;
		}

		/// <summary>
		/// 处理用户按键
		/// </summary>
		private void consoleTree_KeyUp(object sender, KeyEventArgs e)
		{
			TreeNode node = this.consoleTree.SelectedNode;
			if (node == null)
				return;

			switch (e.KeyCode)
			{
				case Keys.Delete:
					if (node.Tag is InputConfigPanel)
					{
						this.cmDeleteInput_Click(this, EventArgs.Empty);
						e.Handled = true;
					}
					else if (node.Tag is OutputConfigPanel)
					{
						this.cmDelete_Click(this, EventArgs.Empty);
						e.Handled = true;
					}
					else if (node.Tag is PairConfigPanel)
					{
						this.cmDelete_Click(this, EventArgs.Empty);
						e.Handled = true;
					}
					return;
			}
		}

		/// <summary>
		/// “取消”按钮按下时
		/// </summary>
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// 保存配置
		/// </summary>
		private void SaveConfig()
		{
			if (this.OutputCount < 1)
				throw new InvalidOperationException("请至少配置一个输出账户！");

			foreach (TreeNode oNode in this.outputNode.Nodes)
			{
				if (oNode.Nodes.ContainsKey(oNode.Name))
					throw new InvalidOperationException("输出用户“" + oNode.Name + "”下关联了一个相同的输入用户！");
			}

			StreamWriter writer = null;
			try
			{
				writer = new StreamWriter(Program.ConfigFile, false, Encoding.Default);
				int index;

				writer.WriteLine("[TraderIn]");
				writer.WriteLine("Count={0}", this.InputCount.ToString());
				index = 0;
				foreach (TreeNode iNode in this.inputNode.Nodes)
				{
					((InputConfigPanel)iNode.Tag).WriteConfig(index, writer);
					index++;
				}

				writer.WriteLine();
				writer.WriteLine("[TraderOut]");
				writer.WriteLine("Count={0}", this.OutputCount.ToString());
				index = 0;
				foreach (TreeNode oNode in this.outputNode.Nodes)
				{
					((OutputConfigPanel)oNode.Tag).WriteConfig(index, writer);
					index++;
				}

				writer.WriteLine();
				writer.WriteLine("[RelationShip]");
				writer.WriteLine("Count={0}", this.PairsCount.ToString());
				index = 0;
				foreach (TreeNode oNode in this.outputNode.Nodes)
				{
					foreach (TreeNode pNode in oNode.Nodes)
					{
						string si = (index + 1).ToString();
						PairConfigPanel ip = (PairConfigPanel)pNode.Tag;
						ip.WriteConfig(index, writer);
						index++;
					}
				}

				writer.WriteLine();
				this.DialogResult = DialogResult.OK;
			}
			finally
			{
				if (writer != null)
					writer.Dispose();
			}
		}

		/// <summary>
		/// “确定”按钮按下时
		/// </summary>
		private void btnOK_Click(object sender, EventArgs e)
		{
			try
			{
				this.SaveConfig();
				this.DialogResult = DialogResult.OK;
                MessageBox.Show("保存成功！");
			}
			catch (InvalidOperationException exp)
			{
				MessageBox.Show(this, exp.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception exp)
			{
				MessageBox.Show(this, "保存配置时发生错误，" + exp.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// “启动”按钮按下时
		/// </summary>
		private void btnStart_Click(object sender, EventArgs e)
		{
			try
			{
				this.SaveConfig();
				this.DialogResult = DialogResult.OK;
				this.Close();
				System.Diagnostics.Process.Start(Path.Combine(Application.StartupPath, "FollowTool.exe"));
			}
			catch (InvalidOperationException exp)
			{
				MessageBox.Show(this, exp.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception exp)
			{
				MessageBox.Show(this, "启动程序时发生错误，" + exp.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void ConfigForm_Load(object sender, EventArgs e)
        {

        }
	}//class
}
