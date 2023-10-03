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
    public partial class Form : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Enter_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(TextBox1.Text, out value))
            {
                if (value > 8300)
                {
                    additionalColumns.Visible = true;

                }
                else
                {
                    additionalColumns.Visible = false;
                }


            }
        }
        
        protected void SubmitForm_Click(object sender, EventArgs e)
        {
            if (checkid())
            {
                Response.Write("<script>alert('Form already submitted with this id');</script>");
            }
            else
            {
                Form_details();
            }
            
        }

        //user-defined functions
        bool checkid()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("select * from Form_Credentials where Id='" + id.Text.Trim() + "'; ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if(dt.Rows.Count >= 1) 
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }

        void Form_details()
        {
            //Response.Write("<script>alert('Testing');</script>");
            try
            {
                SqlConnection con = new SqlConnection(strcon);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("insert into Form_Credentials (Id,Date_Of_Birth,Name,Mobile_no,TextBox1,Owner,Pan,TextBox211,TextBox212,TextBox213,TextBox221,TextBox222,TextBox223,TextBox231,TextBox232,TextBox233,TextBox2G,TextBox311,TextBox312,TextBox313,TextBox321,TextBox322,TextBox323,TextBox331,TextBox332,TextBox333,Discount,Reservation,NPS,SavingsCertificate,TextBox811,TextBox812,TextBox813,TextBox821,TextBox822,TextBox823,TextBox831,TextBox832,TextBox833,PPF,mutualfunds,corporatefunds,houseloan,houseloan1,houseloan2,houseloan3,houseloan4,houseloan5,houseloan6,constructionloan,childclass1,childamt1,childclass2,childamt2,grandtotal,employer,anyother) values (@Id,@Date_Of_Birth,@Name,@Mobile_no,@TextBox1,@Owner,@Pan,@TextBox211,@TextBox212,@TextBox213,@TextBox221,@TextBox222,@TextBox223,@TextBox231,@TextBox232,@TextBox233,@TextBox2G,@TextBox311,@TextBox312,@TextBox313,@TextBox321,@TextBox322,@TextBox323,@TextBox331,@TextBox332,@TextBox333,@Discount,@Reservation,@NPS,@SavingsCertificate,@TextBox811,@TextBox812,@TextBox813,@TextBox821,@TextBox822,@TextBox823,@TextBox831,@TextBox832,@TextBox833,@PPF,@mutualfunds,@corporatefunds,@houseloan,@houseloan1,@houseloan2,@houseloan3,@houseloan4,@houseloan5,@houseloan6,@constructionloan,@childclass1,@childamt1,@childclass2,@childamt2,@grandtotal,@employer,@anyother) ", con);

                cmd.Parameters.AddWithValue("Id", id.Text.Trim());
                cmd.Parameters.AddWithValue("Date_Of_Birth", date.Text.Trim());
                cmd.Parameters.AddWithValue("Name", fullname.Text.Trim());
                cmd.Parameters.AddWithValue("Mobile_no", mobileno.Text.Trim());
                cmd.Parameters.AddWithValue("TextBox1", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("Owner", Owner.Text.Trim());
                cmd.Parameters.AddWithValue("Pan", PAN.Text.Trim());
                cmd.Parameters.AddWithValue("TextBox211", TextBox211.Text.Trim());
                cmd.Parameters.AddWithValue("TextBox212", TextBox212.Text.Trim());
                cmd.Parameters.AddWithValue("TextBox213", TextBox213.Text.Trim());
                cmd.Parameters.AddWithValue("TextBox221", TextBox221.Text.Trim());
                cmd.Parameters.AddWithValue("TextBox222", TextBox222.Text.Trim());
                cmd.Parameters.AddWithValue("TextBox223", TextBox223.Text.Trim());
                cmd.Parameters.AddWithValue("TextBox231", TextBox231.Text.Trim());
                cmd.Parameters.AddWithValue("TextBox232", TextBox232.Text.Trim());
                cmd.Parameters.AddWithValue("TextBox233", TextBox233.Text.Trim());
                cmd.Parameters.AddWithValue("TextBox2G", TextBox2G.Text.Trim());
                cmd.Parameters.AddWithValue("TextBox311", TextBox311.Text.Trim());
                cmd.Parameters.AddWithValue("TextBox312", TextBox312.Text.Trim());
                cmd.Parameters.AddWithValue("TextBox313", TextBox313.Text.Trim());
                cmd.Parameters.AddWithValue("TextBox321", TextBox321.Text.Trim());
                cmd.Parameters.AddWithValue("TextBox322", TextBox322.Text.Trim());
                cmd.Parameters.AddWithValue("TextBox323", TextBox323.Text.Trim());
                cmd.Parameters.AddWithValue("TextBox331", TextBox331.Text.Trim());
                cmd.Parameters.AddWithValue("TextBox332", TextBox332.Text.Trim());
                cmd.Parameters.AddWithValue("TextBox333", TextBox333.Text.Trim());
                cmd.Parameters.AddWithValue("Discount", Discount.Text.Trim());
                cmd.Parameters.AddWithValue("Reservation", Reservation.Text.Trim());
                cmd.Parameters.AddWithValue("NPS", NPS.Text.Trim());
                cmd.Parameters.AddWithValue("SavingsCertificate", SavingsCertificate.Text.Trim());
                cmd.Parameters.AddWithValue("TextBox811", TextBox811.Text.Trim());
                cmd.Parameters.AddWithValue("TextBox812", TextBox812.Text.Trim());
                cmd.Parameters.AddWithValue("TextBox813", TextBox813.Text.Trim());
                cmd.Parameters.AddWithValue("TextBox821", TextBox821.Text.Trim());
                cmd.Parameters.AddWithValue("TextBox822", TextBox822.Text.Trim());
                cmd.Parameters.AddWithValue("TextBox823", TextBox823.Text.Trim());
                cmd.Parameters.AddWithValue("TextBox831", TextBox831.Text.Trim());
                cmd.Parameters.AddWithValue("TextBox832", TextBox832.Text.Trim());
                cmd.Parameters.AddWithValue("TextBox833", TextBox833.Text.Trim());
                cmd.Parameters.AddWithValue("PPF", PPF.Text.Trim());
                cmd.Parameters.AddWithValue("mutualfunds", mutualfunds.Text.Trim());
                cmd.Parameters.AddWithValue("corporatefunds", corporatebonds.Text.Trim());
                cmd.Parameters.AddWithValue("houseloan", houseloan.Text.Trim());
                cmd.Parameters.AddWithValue("houseloan1", houseloan1.Text.Trim());
                cmd.Parameters.AddWithValue("houseloan2", houseloan2.Text.Trim());
                cmd.Parameters.AddWithValue("houseloan3", houseloan3.Text.Trim());
                cmd.Parameters.AddWithValue("houseloan4", houseloan4.Text.Trim());
                cmd.Parameters.AddWithValue("houseloan5", houseloan5.Text.Trim());
                cmd.Parameters.AddWithValue("houseloan6", houseloan6.Text.Trim());
                cmd.Parameters.AddWithValue("constructionloan", constructionloan.Text.Trim());
                cmd.Parameters.AddWithValue("childclass1", childclass1.Text.Trim());
                cmd.Parameters.AddWithValue("childamt1", childamt1.Text.Trim());
                cmd.Parameters.AddWithValue("childclass2", childclass2.Text.Trim());
                cmd.Parameters.AddWithValue("childamt2", childamt2.Text.Trim());
                cmd.Parameters.AddWithValue("grandtotal", grandtotal.Text.Trim());
                cmd.Parameters.AddWithValue("employer", employer.Text.Trim());
                cmd.Parameters.AddWithValue("anyother", anyother.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Form Submitted Successfully');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}