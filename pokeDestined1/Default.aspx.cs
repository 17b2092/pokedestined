using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pokeDestined1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1(object sender, EventArgs e)
        {
            string t1 = e1.Text;
            string t2 = p1.Text;
            if (t1.Equals("ger") && t2.Equals("123"))
            {
                Response.Redirect("Main.aspx");
                Session["user"] = t1;
            }
        }
    }
}