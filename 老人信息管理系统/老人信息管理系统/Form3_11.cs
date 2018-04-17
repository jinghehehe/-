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
	public partial class Form3_11 : Form
	{
		private SqlDataReader sdr;
		public Form3_11(SqlDataReader sdr)
		{
			InitializeComponent();
			this.sdr = sdr;
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

		private void Form3_11_Load(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
