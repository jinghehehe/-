using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 老人信息管理系统
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		public Form3(string name)
		{
			InitializeComponent();
			Name = name;
		}

		private void 添加病人ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2_11 form = new Form2_11();
			form.Show();
		}

		private void 老人信息一览ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			String sql = "select distinct a.Stu_no,a.Stu_time1,a.Stu_tem1," +
			"b.Stu_li,b.Stu_jin,c.Stu_chu,c.Stu_hua,c.Stu_bei from Subject1 a,Class1 b,Course1 c where a.Stu_no=b.Stu_no and a.Stu_no=c.Stu_no and a.Stu_no='" + Name + "'";
			Sqlmodel sm = new Sqlmodel(sql);
			SqlDataReader sdr = sm.Search();
			if (sdr.HasRows)
			{
				// MessageBox.Show("查询成功！\n");
				/* String str = "";
                 while (sdr.Read())
                 {           
                     str += "***************************"+"\n学号：" + sdr.GetValue(0) + "\n姓名：" + sdr.GetValue(1) + "\n性别：" + sdr.GetValue(2)
                         + "\n出生年月：" + sdr.GetValue(3) + "\n学院号：" + sdr.GetValue(4) + "\n专业号：" + sdr.GetValue(5)
                         + "\n班级号：" + sdr.GetValue(6) + "\n***************************\n";
                 }
                 MessageBox.Show(str);*/
				Form4_00 form = new Form4_00(sdr);
				form.Show();
			}
			else
			{
				MessageBox.Show("查询失败！");
			}
		}

		private void 老人实时信息ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			String sql = "select * from College1 S where S.Stu_no='" + Name + "'";
			Sqlmodel sm = new Sqlmodel(sql);
			SqlDataReader sdr = sm.Search();
			if (sdr.HasRows)
			{
				// MessageBox.Show("查询成功！\n");
				/* String str = "";
                 while (sdr.Read())
                 {           
                     str += "***************************"+"\n学号：" + sdr.GetValue(0) + "\n姓名：" + sdr.GetValue(1) + "\n性别：" + sdr.GetValue(2)
                         + "\n出生年月：" + sdr.GetValue(3) + "\n学院号：" + sdr.GetValue(4) + "\n专业号：" + sdr.GetValue(5)
                         + "\n班级号：" + sdr.GetValue(6) + "\n***************************\n";
                 }
                 MessageBox.Show(str);*/
				Form3_12 form = new Form3_12(sdr);
				form.Show();
			}
			else
			{
				MessageBox.Show("查询失败！");
			}
		}

		private void Form3_Load(object sender, EventArgs e)
		{

		}
	}
}
