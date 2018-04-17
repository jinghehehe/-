namespace 老人信息管理系统
{
	partial class Form3
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.添加病人ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.老人信息一览ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.老人实时信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.信息管理ToolStripMenuItem,
            this.信息查询ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1114, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 信息管理ToolStripMenuItem
			// 
			this.信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加病人ToolStripMenuItem});
			this.信息管理ToolStripMenuItem.Name = "信息管理ToolStripMenuItem";
			this.信息管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
			this.信息管理ToolStripMenuItem.Text = "信息管理";
			// 
			// 添加病人ToolStripMenuItem
			// 
			this.添加病人ToolStripMenuItem.Name = "添加病人ToolStripMenuItem";
			this.添加病人ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
			this.添加病人ToolStripMenuItem.Text = "添加病人";
			this.添加病人ToolStripMenuItem.Click += new System.EventHandler(this.添加病人ToolStripMenuItem_Click);
			// 
			// 信息查询ToolStripMenuItem
			// 
			this.信息查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.老人信息一览ToolStripMenuItem,
            this.老人实时信息ToolStripMenuItem});
			this.信息查询ToolStripMenuItem.Name = "信息查询ToolStripMenuItem";
			this.信息查询ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
			this.信息查询ToolStripMenuItem.Text = "信息查询";
			// 
			// 老人信息一览ToolStripMenuItem
			// 
			this.老人信息一览ToolStripMenuItem.Name = "老人信息一览ToolStripMenuItem";
			this.老人信息一览ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
			this.老人信息一览ToolStripMenuItem.Text = "老人信息一览";
			this.老人信息一览ToolStripMenuItem.Click += new System.EventHandler(this.老人信息一览ToolStripMenuItem_Click);
			// 
			// 老人实时信息ToolStripMenuItem
			// 
			this.老人实时信息ToolStripMenuItem.Name = "老人实时信息ToolStripMenuItem";
			this.老人实时信息ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
			this.老人实时信息ToolStripMenuItem.Text = "老人实时信息";
			this.老人实时信息ToolStripMenuItem.Click += new System.EventHandler(this.老人实时信息ToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("楷体", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(271, 85);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(641, 38);
			this.label1.TabIndex = 1;
			this.label1.Text = "欢迎来到老人健康安全信息管理系统";
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::老人信息管理系统.Properties.Resources._4;
			this.ClientSize = new System.Drawing.Size(1114, 714);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form3";
			this.Text = "Form3";
			this.Load += new System.EventHandler(this.Form3_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 信息管理ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 添加病人ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 信息查询ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 老人信息一览ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 老人实时信息ToolStripMenuItem;
		private System.Windows.Forms.Label label1;
	}
}