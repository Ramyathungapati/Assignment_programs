using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryStrings
{
	public partial class Homepage : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string name = Request.QueryString["Textbox1.Text"];
			Response.Write("Hello" + name + "Welcome to Our Website");
		}
	}
}