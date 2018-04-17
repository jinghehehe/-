namespace 老人信息管理系统
{
	partial class Form2
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
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.添加信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.老人信息录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.老人指标录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.删除信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.信息录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.老人身体指标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.老人病情ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.老人身体指标录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.老人病情记录录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.老人病情检测记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.老人实时信息录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("楷体", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.ForeColor = System.Drawing.Color.GreenYellow;
			this.label1.Location = new System.Drawing.Point(285, 68);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(641, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "欢迎来到老人健康安全信息管理系统";
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.信息管理ToolStripMenuItem,
            this.信息录入ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1074, 28);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 信息管理ToolStripMenuItem
			// 
			this.信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加信息ToolStripMenuItem,
            this.删除信息ToolStripMenuItem});
			this.信息管理ToolStripMenuItem.Name = "信息管理ToolStripMenuItem";
			this.信息管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
			this.信息管理ToolStripMenuItem.Text = "信息管理";
			this.信息管理ToolStripMenuItem.Click += new System.EventHandler(this.信息管理ToolStripMenuItem_Click);
			// 
			// 添加信息ToolStripMenuItem
			// 
			this.添加信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.老人信息录入ToolStripMenuItem,
            this.老人指标录入ToolStripMenuItem});
			this.添加信息ToolStripMenuItem.Name = "添加信息ToolStripMenuItem";
			this.添加信息ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.添加信息ToolStripMenuItem.Text = "添加病人";
			this.添加信息ToolStripMenuItem.Click += new System.EventHandler(this.添加信息ToolStripMenuItem_Click);
			// 
			// 老人信息录入ToolStripMenuItem
			// 
			this.老人信息录入ToolStripMenuItem.Name = "老人信息录入ToolStripMenuItem";
			this.老人信息录入ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.老人信息录入ToolStripMenuItem.Text = "老人信息录入";
			this.老人信息录入ToolStripMenuItem.Click += new System.EventHandler(this.老人信息录入ToolStripMenuItem_Click);
			// 
			// 老人指标录入ToolStripMenuItem
			// 
			this.老人指标录入ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.老人身体指标录入ToolStripMenuItem,
            this.老人病情记录录入ToolStripMenuItem,
            this.老人病情检测记录ToolStripMenuItem,
            this.老人实时信息录入ToolStripMenuItem});
			this.老人指标录入ToolStripMenuItem.Name = "老人指标录入ToolStripMenuItem";
			this.老人指标录入ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.老人指标录入ToolStripMenuItem.Text = "老人指标录入";
			// 
			// 删除信息ToolStripMenuItem
			// 
			this.删除信息ToolStripMenuItem.Name = "删除信息ToolStripMenuItem";
			this.删除信息ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.删除信息ToolStripMenuItem.Text = "删除病人";
			this.删除信息ToolStripMenuItem.Click += new System.EventHandler(this.删除信息ToolStripMenuItem_Click);
			// 
			// 信息录入ToolStripMenuItem
			// 
			this.信息录入ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.老人身体指标ToolStripMenuItem,
            this.老人病情ToolStripMenuItem});
			this.信息录入ToolStripMenuItem.Name = "信息录入ToolStripMenuItem";
			this.信息录入ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
			this.信息录入ToolStripMenuItem.Text = "信息查询";
			// 
			// 老人身体指标ToolStripMenuItem
			// 
			this.老人身体指标ToolStripMenuItem.Name = "老人身体指标ToolStripMenuItem";
			this.老人身体指标ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.老人身体指标ToolStripMenuItem.Text = "老人信息一览";
			this.老人身体指标ToolStripMenuItem.Click += new System.EventHandler(this.老人身体指标ToolStripMenuItem_Click);
			// 
			// 老人病情ToolStripMenuItem
			// 
			this.老人病情ToolStripMenuItem.Name = "老人病情ToolStripMenuItem";
			this.老人病情ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.老人病情ToolStripMenuItem.Text = "老人实时信息";
			this.老人病情ToolStripMenuItem.Click += new System.EventHandler(this.老人病情ToolStripMenuItem_Click);
			// 
			// 老人身体指标录入ToolStripMenuItem
			// 
			this.老人身体指标录入ToolStripMenuItem.Name = "老人身体指标录入ToolStripMenuItem";
			this.老人身体指标录入ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
			this.老人身体指标录入ToolStripMenuItem.Text = "老人身体指标录入";
			this.老人身体指标录入ToolStripMenuItem.Click += new System.EventHandler(this.老人身体指标录入ToolStripMenuItem_Click);
			// 
			// 老人病情记录录入ToolStripMenuItem
			// 
			this.老人病情记录录入ToolStripMenuItem.Name = "老人病情记录录入ToolStripMenuItem";
			this.老人病情记录录入ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
			this.老人病情记录录入ToolStripMenuItem.Text = "老人病情记录录入";
			this.老人病情记录录入ToolStripMenuItem.Click += new System.EventHandler(this.老人病情记录录入ToolStripMenuItem_Click);
			// 
			// 老人病情检测记录ToolStripMenuItem
			// 
			this.老人病情检测记录ToolStripMenuItem.Name = "老人病情检测记录ToolStripMenuItem";
			this.老人病情检测记录ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
			this.老人病情检测记录ToolStripMenuItem.Text = "老人病情检测记录";
			this.老人病情检测记录ToolStripMenuItem.Click += new System.EventHandler(this.老人病情检测记录ToolStripMenuItem_Click);
			// 
			// 老人实时信息录入ToolStripMenuItem
			// 
			this.老人实时信息录入ToolStripMenuItem.Name = "老人实时信息录入ToolStripMenuItem";
			this.老人实时信息录入ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
			this.老人实时信息录入ToolStripMenuItem.Text = "老人实时信息录入";
			this.老人实时信息录入ToolStripMenuItem.Click += new System.EventHandler(this.老人实时信息录入ToolStripMenuItem_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 27F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::老人信息管理系统.Properties.Resources.IMG_1799_20180319_190744_;
			this.ClientSize = new System.Drawing.Size(1074, 651);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("楷体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.Name = "Form2";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 信息管理ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 添加信息ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 删除信息ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 信息录入ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 老人身体指标ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 老人病情ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 老人信息录入ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 老人指标录入ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 老人身体指标录入ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 老人病情记录录入ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 老人病情检测记录ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 老人实时信息录入ToolStripMenuItem;
	}
}