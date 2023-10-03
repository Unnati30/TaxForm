using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Home
{
    public partial class userlogin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //Response.Write("<script>alert ('Button Click');</script>");

            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("Select * from Employee_Credentials where employee_id='"+TextBox1.Text.Trim()+ "' AND password='"+TextBox3.Text.Trim()+ "' ;", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Response.Write("<script>alert('Login Successful');</script>");
                        Session["employee_id"] = dr.GetValue(0).ToString();
                        Session["employee_name"] = dr.GetValue(1).ToString();
                        Session["role"] = "employee";  
                        
                        if(TextBox1.Text.Trim() == "A1011" && TextBox3.Text.Trim()=="SR@123")
                        {
                            Session["role"] = "admin";
                            Response.Redirect("home.aspx");
                        }
                        else
                        {
                            
                            Response.Redirect("home.aspx");
                        }

                        
                    }
                    

                }
                else
                {
                    Response.Write("<script>alert ('Invalid Credentials');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert ('" + ex.Message + "');</script>");
            }
        }
    }
}