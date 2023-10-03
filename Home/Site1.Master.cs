using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Home
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"]==null){
                    LinkButton1.Visible = true;
                    LinkButton2.Visible = false;
                    LinkButton5.Visible = false;
                    LinkButton.Visible = false;
                    LinkButton3.Visible = true;
                    LinkButton6.Visible = false;
                    
                }
                else if (Session["role"].Equals("employee"))
                {
                    LinkButton1.Visible = false;
                    LinkButton2.Visible = true;
                    LinkButton.Visible = true;
                    LinkButton5.Visible = true;                    
                    LinkButton3.Visible = true;
                    LinkButton6.Visible = false;
                }
                else if (Session["role"].Equals("admin"))
                {
                    LinkButton1.Visible = false;
                    LinkButton2.Visible = true;
                    LinkButton2.Visible = true;
                    LinkButton.Visible = true;
                    LinkButton5.Visible = false;
                    LinkButton.Text = "Hello Admin";
                    LinkButton3.Visible = true;
                    LinkButton6.Visible = true;
                }

            }
            catch (Exception ex)
            {
                
            }
            
        }
        
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Session["role"] = null;
            Response.Redirect("home.aspx");
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }
        protected void LinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }
        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("old_or_new.aspx");
        }
        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }
        

    }
}