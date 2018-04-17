using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace 老人信息管理系统
{
	class Sqlmodel
	{
		private String sql;
		private SqlCommand cmd;
		private SqlConnection conn;
		public Sqlmodel(String sql)
		{
			this.sql = sql;
			//数据库名称
			String str = "server=DESKTOP-G06BI84;database=StuManage;uid=sa;pwd=123456";
			conn = new SqlConnection(str);
			cmd = new SqlCommand(sql, conn);
		}
		//查询功能并返回数据集
		public SqlDataReader Search()
		{
			SqlDataAdapter sda = new SqlDataAdapter();//定义一个数据适配器
			sda.SelectCommand = cmd;//定义数据适配器的操作指令
			DataSet ds = new DataSet();//定义一个数据集
			conn.Open();//打开数据库进行连接
			sda.Fill(ds, "ds");//填充数据集
			SqlDataReader sdr = cmd.ExecuteReader();
			//conn.Close();//关闭数据库连接
			return sdr;
		}
		//添加功能
		public Boolean Add()
		{
			bool b = false;
			try
			{
				conn.Open();
				int n = cmd.ExecuteNonQuery();
				if (n != 0)
					b = true;
				conn.Close();
			}
			catch (Exception e)
			{
				Console.Write("{0} Exception caught.", e);
			}
			return b;
		}
		//删除功能
		public Boolean Delete()
		{
			bool b = false;
			try
			{
				conn.Open();
				int n = cmd.ExecuteNonQuery();
				if (n != 0)
					b = true;
				conn.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine("{0} Exception caught.", e);
			}
			return b;
		}
		//修改功能
		public Boolean Update()
		{
			bool b = false;
			try
			{
				conn.Open();
				int n = cmd.ExecuteNonQuery();
				if (n != 0)
					b = true;
				conn.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine("{0} Exception caught.", e);
			}
			return b;
		}
	}
}
