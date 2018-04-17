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
	public partial class Form2_41 : Form
	{
		private SqlDataReader sdr;

		public Form2_41()
		{
			InitializeComponent();
			String sql = "select * from College1 S";
			Sqlmodel sm = new Sqlmodel(sql);
			SqlDataReader sdr = sm.Search();
			while (sdr.Read())
			{
				String[] row = {sdr.GetValue(0).ToString(), sdr.GetValue(1).ToString(),
				sdr.GetValue(2).ToString(),sdr.GetValue(3).ToString(),
				sdr.GetValue(4).ToString()};
				dataGridView1.Rows.Add(row);
			}
		}

		public Form2_41(SqlDataReader sdr)
		{
			this.sdr = sdr;
			InitializeComponent();
			while (sdr.Read())
			{
				String[] row = {sdr.GetValue(0).ToString(), sdr.GetValue(1).ToString(),
				sdr.GetValue(2).ToString(),sdr.GetValue(3).ToString(),
				sdr.GetValue(4).ToString()};
				dataGridView1.Rows.Add(row);
			}
		}

		private void Form2_41_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			String No = textBox1.Text.Trim();
			//构造sql查询语句
			String sql = "select * from College1 S where S.Stu_no='" + No + "'";
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
				MessageBox.Show("查询失败或你输入的ID并不存在！");
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
