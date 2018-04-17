using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 老人信息管理系统
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)//重置按钮
		{
			textBox3.Text = null;
			textBox4.Text = null;
		}

		private void button2_Click(object sender, EventArgs e)//登录按钮
		{
			//获取账号
			String Id = textBox3.Text.Trim();
			//获取密码
			String PassWord = textBox4.Text.Trim();
			if (Id == "" || PassWord == "")
			{
				MessageBox.Show("请输入登录名或密码");
			}
			else
			{
				String str = "server=DESKTOP-G06BI84;database=StuManage;uid=sa;pwd=123456";
				//构造sql查询语句
				String sql;
				if (radioButton1.Checked)//选中家用
				{
					sql = "select Stu_name from Student1 where Stu_name='" + Id + "' and Stu_no='" + PassWord + "'";
				}
				else//选中医生
				{
					sql = "select Tea_name from Teacher1 where Tea_name='" + Id + "' and Tea_no='" + PassWord + "'";
					
				}
				//构造连接对象
				using (SqlConnection conn = new SqlConnection(str))
				{
					SqlCommand cmd = new SqlCommand(sql, conn);
					//打开数据库连接
					conn.Open();
					//执行查询语句，返回语句的第一行第一列
					Object obj = cmd.ExecuteScalar();
					String name;
					if (obj == null)
					{
						MessageBox.Show("账号或密码错误！", "登录失败");
					}
					else if (radioButton2.Checked)
					{
						name = obj.ToString();
						//登录窗口隐藏
						this.Hide();
						//创建管理界面
						Form2 f = new Form2(name);
						f.Show();
					}
					else
					{
						name = obj.ToString();
						//登录窗口隐藏
						this.Hide();
						//创建管理界面
						Form3 f = new Form3(PassWord);
						f.Show();
					}
				}

			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
