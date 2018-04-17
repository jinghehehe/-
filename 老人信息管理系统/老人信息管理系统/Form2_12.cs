using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 老人信息管理系统
{
	public partial class Form2_12 : Form
	{
		public Form2_12()
		{
			InitializeComponent();
		}

		private void Form2_12_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			String No = textBox1.Text.Trim();
			//构造sql查询语句
			String sql = "delete from Student1 where Stu_no='" + No + "'";
			Sqlmodel sm = new Sqlmodel(sql);
			if (sm.Delete())
			{
				MessageBox.Show("删除成功！");
			}
			else
			{
				MessageBox.Show("删除失败或你输入的学号并不存在！");
			}
		}
	}
}
