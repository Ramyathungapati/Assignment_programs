using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace radiobuttonAss
{
    public partial class radiobuttonAss : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void radiobutton1_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("This is Asp.net webform");


        }

        protected void Textbox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write("This is Asp.net webform");
        }

        protected void radiobutton3_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("This is Asp.net webform");
        }

        protected void radiobutton2_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("This is Asp.net webform");
        }

        protected void Textbox2_TextChanged(object sender, EventArgs e)
        {
            Response.Write("This is Asp.net webform");
        }

        protected void Textbox3_TextChanged(object sender, EventArgs e)
        {
            Response.Write("This is Asp.net webform");
        }

        protected void rbnRed_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Red_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("This is Asp.net webform");
        }

        protected void Blue_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("This is Asp.net webform");
        }

        protected void Green_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("This is Asp.net webform");
            
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            if (Red.Checked)
            {
                label1.Text = "The color is" + Red.Text;
            }
            else if (Blue.Checked)
            {
                label1.Text = "The color is" + Blue.Text;
            }
            else
            {
                label1.Text = "The color is" + Green.Text;
            }
        }
    }
}
