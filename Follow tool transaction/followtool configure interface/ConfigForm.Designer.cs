namespace SureWin
{
	partial class ConfigForm
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

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.consoleTree = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.outputRootContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmNewOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.inputRootContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmNewInput = new System.Windows.Forms.ToolStripMenuItem();
            this.outputContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmDeleteOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.pairContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmDeletePair = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStart = new System.Windows.Forms.Button();
            this.inputContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmDeleteInput = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.outputRootContextMenu.SuspendLayout();
            this.inputRootContextMenu.SuspendLayout();
            this.outputContextMenu.SuspendLayout();
            this.pairContextMenu.SuspendLayout();
            this.inputContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(416, 490);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确定(&D)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(497, 490);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // consoleTree
            // 
            this.consoleTree.AllowDrop = true;
            this.consoleTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleTree.ImageIndex = 0;
            this.consoleTree.ImageList = this.imageList;
            this.consoleTree.Location = new System.Drawing.Point(0, 0);
            this.consoleTree.Name = "consoleTree";
            this.consoleTree.SelectedImageIndex = 0;
            this.consoleTree.Size = new System.Drawing.Size(180, 468);
            this.consoleTree.TabIndex = 0;
            this.consoleTree.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.consoleTree_ItemDrag);
            this.consoleTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.consoleTree_AfterSelect);
            this.consoleTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.consoleTree_NodeMouseClick);
            this.consoleTree.DragDrop += new System.Windows.Forms.DragEventHandler(this.consoleTree_DragDrop);
            this.consoleTree.DragEnter += new System.Windows.Forms.DragEventHandler(this.consoleTree_DragEnter);
            this.consoleTree.KeyUp += new System.Windows.Forms.KeyEventHandler(this.consoleTree_KeyUp);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "sysIcon");
            this.imageList.Images.SetKeyName(1, "inIcon");
            this.imageList.Images.SetKeyName(2, "outIcon");
            this.imageList.Images.SetKeyName(3, "inUser");
            this.imageList.Images.SetKeyName(4, "outUser");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.consoleTree);
            this.splitContainer1.Size = new System.Drawing.Size(560, 468);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.TabIndex = 0;
            // 
            // outputRootContextMenu
            // 
            this.outputRootContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmNewOutput});
            this.outputRootContextMenu.Name = "userConfigContextMenu";
            this.outputRootContextMenu.Size = new System.Drawing.Size(167, 26);
            // 
            // cmNewOutput
            // 
            this.cmNewOutput.Name = "cmNewOutput";
            this.cmNewOutput.Size = new System.Drawing.Size(166, 22);
            this.cmNewOutput.Text = "新建输出账户(&N)";
            this.cmNewOutput.Click += new System.EventHandler(this.cmNewOutput_Click);
            // 
            // inputRootContextMenu
            // 
            this.inputRootContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmNewInput});
            this.inputRootContextMenu.Name = "outputContextMenu";
            this.inputRootContextMenu.Size = new System.Drawing.Size(167, 26);
            // 
            // cmNewInput
            // 
            this.cmNewInput.Name = "cmNewInput";
            this.cmNewInput.Size = new System.Drawing.Size(166, 22);
            this.cmNewInput.Text = "新建输入账户(&N)";
            this.cmNewInput.Click += new System.EventHandler(this.cmNewInput_Click);
            // 
            // outputContextMenu
            // 
            this.outputContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmDeleteOutput});
            this.outputContextMenu.Name = "userContextMenu";
            this.outputContextMenu.Size = new System.Drawing.Size(118, 26);
            // 
            // cmDeleteOutput
            // 
            this.cmDeleteOutput.Name = "cmDeleteOutput";
            this.cmDeleteOutput.Size = new System.Drawing.Size(117, 22);
            this.cmDeleteOutput.Text = "删除(&D)";
            this.cmDeleteOutput.Click += new System.EventHandler(this.cmDelete_Click);
            // 
            // pairContextMenu
            // 
            this.pairContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmDeletePair});
            this.pairContextMenu.Name = "pairContextMenu";
            this.pairContextMenu.Size = new System.Drawing.Size(118, 26);
            // 
            // cmDeletePair
            // 
            this.cmDeletePair.Name = "cmDeletePair";
            this.cmDeletePair.Size = new System.Drawing.Size(117, 22);
            this.cmDeletePair.Text = "删除(&D)";
            this.cmDeletePair.Click += new System.EventHandler(this.cmDelete_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(335, 490);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "启动(&S)";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // inputContextMenu
            // 
            this.inputContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmDeleteInput});
            this.inputContextMenu.Name = "userContextMenu";
            this.inputContextMenu.Size = new System.Drawing.Size(118, 26);
            // 
            // cmDeleteInput
            // 
            this.cmDeleteInput.Name = "cmDeleteInput";
            this.cmDeleteInput.Size = new System.Drawing.Size(117, 22);
            this.cmDeleteInput.Text = "删除(&D)";
            this.cmDeleteInput.Click += new System.EventHandler(this.cmDeleteInput_Click);
            // 
            // ConfigForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(584, 521);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(560, 280);
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配置跟单工具参数";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.outputRootContextMenu.ResumeLayout(false);
            this.inputRootContextMenu.ResumeLayout(false);
            this.outputContextMenu.ResumeLayout(false);
            this.pairContextMenu.ResumeLayout(false);
            this.inputContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TreeView consoleTree;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ContextMenuStrip outputRootContextMenu;
		private System.Windows.Forms.ToolStripMenuItem cmNewOutput;
		private System.Windows.Forms.ContextMenuStrip inputRootContextMenu;
		private System.Windows.Forms.ToolStripMenuItem cmNewInput;
		private System.Windows.Forms.ContextMenuStrip outputContextMenu;
		private System.Windows.Forms.ToolStripMenuItem cmDeleteOutput;
		private System.Windows.Forms.ContextMenuStrip pairContextMenu;
		private System.Windows.Forms.ToolStripMenuItem cmDeletePair;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.ContextMenuStrip inputContextMenu;
		private System.Windows.Forms.ToolStripMenuItem cmDeleteInput;
	}
}

