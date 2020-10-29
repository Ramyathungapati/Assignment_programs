using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DataGridAssigmnt
{
	public partial class DataGrid_assignment : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			using (SqlConnection connect = new SqlConnection("server=DESKTOP-NOQ9PCB\\MSSQLSERVER01;database=DxcTraining; integrated security=true"))
			{
				SqlDataAdapter sda = new SqlDataAdapter("select * from student1", connect);
				DataSet ds = new DataSet();
				sda.Fill(ds);
				DataGrid1.DataSource = ds;
				DataGrid1.DataBind();

				SqlDataAdapter sda1 = new SqlDataAdapter("select * from Employee2", connect);
				DataSet ds1 = new DataSet();
				sda1.Fill(ds1);
				DataGrid2.DataSource = ds1;
				DataGrid2.DataBind();

				SqlDataAdapter sda2 = new SqlDataAdapter("select * from IndianCricketTeam", connect);
				DataSet ds2 = new DataSet();
				sda2.Fill(ds2);
				DataGrid3.DataSource = ds2;
				DataGrid3.DataBind();

				SqlDataAdapter sda3 = new SqlDataAdapter("select * from IndianRailwaySystem1 ", connect);
				DataSet ds3 = new DataSet();
				sda3.Fill(ds3);
				DataGrid4.DataSource = ds3;
				DataGrid4.DataBind();

				SqlDataAdapter sda4 = new SqlDataAdapter("select * from BankTable", connect);
				DataSet ds4 = new DataSet();
				sda4.Fill(ds4);
				DataGrid5.DataSource = ds4;
				DataGrid5.DataBind();
			}
		}
	}
}