using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

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

            if (t1=="ger"&&t2=="123")
            {
                Session["user"] = t1;
                Response.Redirect("Main.aspx");
            }

        }
    }
}