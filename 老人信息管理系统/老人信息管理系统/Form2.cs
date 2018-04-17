using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 老人信息管理系统
{
	public partial class Form2 : Form
	{
		private String name;
		public Form2(String name)
		{
			InitializeComponent();
		//	SoundPlayer sp = new SoundPlayer(老人信息管理系统.Properties.Resources.);
		//	sp.Play();
			this.name = name;
			label1.Text += "\n             医生" + name;
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void 信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void 添加信息ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void 删除信息ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2_12 form = new Form2_12();
			form.Show();
		}

		private void 老人身体指标ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2_31 form = new Form2_31();
			form.Show();
		}

		private void 老人病情ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2_41 form = new Form2_41();
			form.Show();
		}

		private void 老人检测记录ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void 老人位置信息ToolStripMenuItem_Click(object sender, EventArgs e)
		{
		
		}

		private void 老人信息录入ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2_11 form = new Form2_11();
			form.Show();
		}

		private void 老人身体指标录入ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2_21 form = new Form2_21();
			form.Show();
		}

		private void 老人病情记录录入ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2_22 form = new Form2_22();
			form.Show();
		}

		private void 老人病情检测记录ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2_23 form = new Form2_23();
			form.Show();
		}

		private void 老人实时信息录入ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2_24 form = new Form2_24();
			form.Show();
		}
	}
}
