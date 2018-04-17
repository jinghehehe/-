using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 老人信息管理系统
{
	public partial class Form2_11 : Form
	{
		public Form2_11()
		{
			InitializeComponent();
		}

		private void Form2_11_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			String Stu_no = textBox1.Text.Trim();
			String Stu_name = textBox2.Text.Trim();
			String Stu_sex = textBox3.Text.Trim();
			String Stu_birth = textBox2.Text.Trim();
			String Stu_age = textBox4.Text.Trim();
			//构造sql查询语句
			String sql = "insert into Student1 values('" + Stu_no + "','" + Stu_name + "','" + Stu_sex + "','" + Stu_age + "','"
				+ Stu_birth + "')";
			Sqlmodel sm = new Sqlmodel(sql);
			if (sm.Add())
			{
				MessageBox.Show("录入成功！");
			}
			else
			{
				MessageBox.Show("录入失败！");
			}
		}
	}
}
