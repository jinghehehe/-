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
	public partial class Form4_00 : Form
	{
		private SqlDataReader sdr;
		public Form4_00(SqlDataReader sdr)
		{
			InitializeComponent();
			this.sdr = sdr;
			while (sdr.Read())
			{
				String[] row = {sdr.GetValue(0).ToString(), sdr.GetValue(1).ToString(),
				sdr.GetValue(2).ToString(),sdr.GetValue(3).ToString(),
				sdr.GetValue(4).ToString(),sdr.GetValue(5).ToString(), sdr.GetValue(6).ToString(),
				sdr.GetValue(7).ToString()};
				dataGridView1.Rows.Add(row);
			}
		}

		private void Form4_00_Load(object sender, EventArgs e)
		{

		}
	}
}
