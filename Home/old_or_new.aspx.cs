using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Home
{
    public partial class old_or_new : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Old(object sender, EventArgs e)
        {
            Response.Redirect("form.aspx");
        }
        protected void New(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}