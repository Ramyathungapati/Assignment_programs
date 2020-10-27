using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPCookies
{
	public partial class WebFormCookie : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			//setting Expiry Date & time of the cookies
			Response.Cookies["computer"].Expires = DateTime.Now.AddDays(-1);
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			Label2.Text = "";

			//__________ADDING COOKIES_____________//
			if (Iphone.Checked)
				Response.Cookies["computer"]["Iphone"] = "You have checked for iphone and cookie triggered";
			if (Samsung.Checked)
				Response.Cookies["computer"]["Samsung"] = "You have checked for Samsung and cookie triggered";
			if (Vivo.Checked)
				Response.Cookies["computer"]["Vivo"] = "You have checked for Vivo and cookie triggered";
			if (Asus.Checked)
				Response.Cookies["computer"]["Asus"] = "You have checked for Asus and cookie triggered";
			if (Redmi.Checked)
				Response.Cookies["computer"]["Redmi"] = "You have checked for Redmi and cookie triggered";
			if (Realme.Checked)
				Response.Cookies["computer"]["Realme"] = "You have checked for Realme and cookie triggered";
			if (Oneplus.Checked)
				Response.Cookies["computer"]["Oneplus"] = "You have checked for Oneplus and cookie triggered";
			if (Sony.Checked)
				Response.Cookies["computer"]["Sony"] = "You have checked for Sony and cookie triggered";
			if (Oppo.Checked)
				Response.Cookies["computer"]["Oppo"] = "You have checked for Oppo and cookie triggered";
			if (Lenovo.Checked)
				Response.Cookies["computer"]["Lenovo"] = "You have checked for Lenovo and cookie triggered";


			//_____________FETCHING COOKIE_________________//
			if (Request.Cookies["computer"].Values.ToString() != null)
			{
				if (Request.Cookies["computer"]["Iphone"] != null)
					Label2.Text = Label2.Text + Request.Cookies["computer"]["Iphone"] + " " + " ";
				if (Request.Cookies["computer"]["Samsung"] != null)
					Label2.Text = Label2.Text + Request.Cookies["computer"]["Samsung"] + " " + " ";
				if (Request.Cookies["computer"]["Vivo"] != null)
					Label2.Text = Label2.Text + Request.Cookies["computer"]["Vivo"] + " " + " ";
				if (Request.Cookies["computer"]["Asus"] != null)
					Label2.Text = Label2.Text + Request.Cookies["computer"]["Asus"] + " " + " ";
				if (Request.Cookies["computer"]["Redmi"] != null)
					Label2.Text = Label2.Text + Request.Cookies["computer"]["Redmi"] + " " + " ";
				if (Request.Cookies["computer"]["Realme"] != null)
					Label2.Text = Label2.Text + Request.Cookies["computer"]["Realme"] + " " + " ";
				if (Request.Cookies["computer"]["Oneplus"] != null)
					Label2.Text = Label2.Text + Request.Cookies["computer"]["Oneplus"] + " " + " ";
				if (Request.Cookies["computer"]["Sony"] != null)
					Label2.Text = Label2.Text + Request.Cookies["computer"]["Sony"] + " " + " ";
				if (Request.Cookies["computer"]["Oppo"] != null)
					Label2.Text = Label2.Text + Request.Cookies["computer"]["Oppo"] + " " + " ";
				if (Request.Cookies["computer"]["Lenovo"] != null)
					Label2.Text = Label2.Text + Request.Cookies["computer"]["Lenovo"] + " " + " ";

			}
			else
			{
				Label2.Text = "please select your choice";
				Response.Cookies["computer"].Expires = DateTime.Now.AddDays(-1);
			}

		}

	}
}