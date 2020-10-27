using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace datalistass
{
	public partial class datalistass : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			DataTable Table = new DataTable();
			Table.Columns.Add("Fname");
			Table.Columns.Add("Lname");
			Table.Columns.Add("Designation");
			Table.Columns.Add("Location");
			Table.Columns.Add("Country");

			Table.Rows.Add(1, "RAMYA", "Engineer", "Hyderabad", "India");
			Table.Rows.Add(2, "Abhi", "Fresher", "Badrachalam", "India");
			Table.Rows.Add(3, "Rahul", "HR", "Palvancha", "India");
			Table.Rows.Add(4, "Sowmya", "Tranier", "Chennai", "India");
			Table.Rows.Add(5, "Chintu", "AE", "Delhi", "India");
			Table.Rows.Add(6, "Nandu", "Assistant", "Khammam", "India");
			Table.Rows.Add(7, "bhanu", "Teamllead", "pune","India");
			Table.Rows.Add(8, "mamatha", "HR", "Bangalore", "India");
			Table.Rows.Add(9, "supriya", "student", "Oooty", "India");
			Table.Rows.Add(10, "shiva", "Fresher", "haryana", "India");

			datalist1.DataSource = Table;
			datalist1.DataBind();
		}
	}
}