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
	public partial class Form2_31 : Form
	{
		private SqlDataReader sdr;

		public Form2_31()
		{
			InitializeComponent();
			String sql = "select distinct a.Stu_no,a.Stu_time1,b.Stu_li,a.Stu_tem2,a.Stu_tem3,a.Stu_tem4,a.Stu_tem5,a.Stu_tem6,a.Stu_tem7," +
				"a.Stu_tem8,a.Stu_tem9,a.Stu_tem1,b.Stu_guo,b.Stu_jin,c.Stu_chu,c.Stu_hua,c.Stu_bei from Subject1 a,Class1 b,Course1 c where a.Stu_no=b.Stu_no and a.Stu_no=c.Stu_no";
			Sqlmodel sm = new Sqlmodel(sql);
			SqlDataReader sdr = sm.Search();
			while (sdr.Read())
			{
			String[] row = {sdr.GetValue(0).ToString(), sdr.GetValue(1).ToString(),
				sdr.GetValue(2).ToString(),sdr.GetValue(3).ToString(),
				sdr.GetValue(4).ToString(),sdr.GetValue(5).ToString(), sdr.GetValue(6).ToString(),
				sdr.GetValue(7).ToString(),sdr.GetValue(8).ToString(),
				sdr.GetValue(9).ToString(),sdr.GetValue(10).ToString(), sdr.GetValue(11).ToString(),
				sdr.GetValue(12).ToString(),sdr.GetValue(13).ToString(),
				sdr.GetValue(14).ToString(),sdr.GetValue(15).ToString(),sdr.GetValue(16).ToString()};
				dataGridView1.Rows.Add(row);
			}
		}

		public Form2_31(SqlDataReader sdr)
		{
			this.sdr = sdr;
			InitializeComponent();
			while (sdr.Read())
			{
				String[] row = {sdr.GetValue(0).ToString(), sdr.GetValue(1).ToString(),
				sdr.GetValue(2).ToString(),sdr.GetValue(3).ToString(),
				sdr.GetValue(4).ToString(),sdr.GetValue(5).ToString(), sdr.GetValue(6).ToString(),
				sdr.GetValue(7).ToString(),sdr.GetValue(8).ToString(),
				sdr.GetValue(9).ToString(),sdr.GetValue(10).ToString(), sdr.GetValue(11).ToString(),
				sdr.GetValue(12).ToString(),sdr.GetValue(13).ToString(),
				sdr.GetValue(14).ToString(),sdr.GetValue(15).ToString(),sdr.GetValue(16).ToString()};
				dataGridView1.Rows.Add(row);
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			String No = textBox1.Text.Trim();
			//构造sql查询语句
			String sql = "select distinct a.Stu_no,a.Stu_time1,b.Stu_li,a.Stu_tem2,a.Stu_tem3,a.Stu_tem4,a.Stu_tem5,a.Stu_tem6,a.Stu_tem7," +
				"a.Stu_tem8,a.Stu_tem9,a.Stu_tem1,b.Stu_guo,b.Stu_jin,c.Stu_chu,c.Stu_hua,c.Stu_bei from Subject1 a,Class1 b,Course1 c where a.Stu_no=b.Stu_no and a.Stu_no=c.Stu_no and a.Stu_no='" + No + "'";
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
				Form3_11 form = new Form3_11(sdr);
				form.Show();
			}
			else
			{
				MessageBox.Show("查询失败或你输入的ID并不存在！");
			}
		}

		private void Form2_31_Load(object sender, EventArgs e)
		{

		}
	}
}
