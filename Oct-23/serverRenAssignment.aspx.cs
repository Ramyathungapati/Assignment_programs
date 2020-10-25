using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace serverRenderingAssignment
{
    public partial class serverRenAssignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            textbox1.Focus();
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            string A = "Hai" +"\n" + textbox1.Text + "!Button is working properly";
            Response.Write(A);
        }
    }
}