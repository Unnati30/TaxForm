using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Drawing;

namespace Home
{
    public partial class adminlogin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Go_Click(object sender, EventArgs e)
        {
            getEmployeeById();
        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            deleteMemberById();
        }
        protected void Update_Click(object sender, EventArgs e)
        {
            updateCredentials();
        }

        bool checkIfMemberExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from Form_Credentials where id ='" + id.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
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

        void getEmployeeById()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("Select * from Form_Credentials where id='" + id.Text.Trim() + "' ;", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        date.Text = dr.GetValue(1).ToString();
                        fullname.Text = dr.GetValue(2).ToString();
                        mobileno.Text = dr.GetValue(3).ToString();
                        TextBox1.Text = dr.GetValue(4).ToString();
                        Owner.Text = dr.GetValue(5).ToString();
                        PAN.Text = dr.GetValue(6).ToString();
                        TextBox211.Text = dr.GetValue(7).ToString();
                        TextBox212.Text = dr.GetValue(8).ToString();
                        TextBox213.Text = dr.GetValue(9).ToString();
                        TextBox221.Text = dr.GetValue(10).ToString();
                        TextBox222.Text = dr.GetValue(11).ToString();
                        TextBox223.Text = dr.GetValue(12).ToString();
                        TextBox231.Text = dr.GetValue(13).ToString();
                        TextBox232.Text = dr.GetValue(14).ToString();
                        TextBox233.Text = dr.GetValue(15).ToString();
                        TextBox2G.Text = dr.GetValue(16).ToString();
                        TextBox311.Text = dr.GetValue(17).ToString();
                        TextBox312.Text = dr.GetValue(18).ToString();
                        TextBox313.Text = dr.GetValue(19).ToString();
                        TextBox321.Text = dr.GetValue(20).ToString();
                        TextBox322.Text = dr.GetValue(21).ToString();
                        TextBox323.Text = dr.GetValue(22).ToString();
                        TextBox331.Text = dr.GetValue(23).ToString();
                        TextBox332.Text = dr.GetValue(24).ToString();
                        TextBox333.Text = dr.GetValue(25).ToString();
                        Discount.Text = dr.GetValue(26).ToString();
                        Reservation.Text = dr.GetValue(27).ToString();
                        NPS.Text = dr.GetValue(28).ToString();
                        SavingsCertificate.Text = dr.GetValue(29).ToString();
                        TextBox811.Text = dr.GetValue(30).ToString();
                        TextBox812.Text = dr.GetValue(31).ToString();
                        TextBox813.Text = dr.GetValue(32).ToString();
                        TextBox821.Text = dr.GetValue(33).ToString();
                        TextBox822.Text = dr.GetValue(34).ToString();
                        TextBox823.Text = dr.GetValue(35).ToString();
                        TextBox831.Text = dr.GetValue(36).ToString();
                        TextBox832.Text = dr.GetValue(37).ToString();
                        TextBox833.Text = dr.GetValue(38).ToString();
                        PPF.Text = dr.GetValue(39).ToString();
                        mutualfunds.Text = dr.GetValue(40).ToString();
                        corporatebonds.Text = dr.GetValue(41).ToString();
                        houseloan.Text = dr.GetValue(42).ToString();
                        houseloan1.Text = dr.GetValue(43).ToString();
                        houseloan2.Text = dr.GetValue(44).ToString();
                        houseloan3.Text = dr.GetValue(45).ToString();
                        houseloan4.Text = dr.GetValue(46).ToString();
                        houseloan5.Text = dr.GetValue(47).ToString();
                        houseloan6.Text = dr.GetValue(48).ToString();
                        constructionloan.Text = dr.GetValue(49).ToString();
                        childclass1.Text = dr.GetValue(50).ToString();
                        childamt1.Text = dr.GetValue(51).ToString();
                        childclass2.Text = dr.GetValue(52).ToString();
                        childamt2.Text = dr.GetValue(53).ToString();
                        grandtotal.Text = dr.GetValue(54).ToString();
                        employer.Text = dr.GetValue(55).ToString();
                        anyother.Text = dr.GetValue(56).ToString();

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

        void deleteMemberById()
        {
            if (checkIfMemberExists())
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand cmd = new SqlCommand("Delete from Form_Credentials where id='" + id.Text.Trim() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script> alert('Form of Employee Deleted Successfully.');</script>");
                    clearForm();
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
             
            }
            else
            {
                Response.Write("<script> alert('Invalid Member Id');</script>");
            }
            
        }

        void clearForm()
        {
            id.Text = "";
            date.Text = "";
            fullname.Text = "";
            mobileno.Text = "";
            TextBox1.Text = "";
            Owner.Text = "";
            PAN.Text = "";
            TextBox211.Text = "";
            TextBox212.Text = "";
            TextBox213.Text = "";
            TextBox221.Text = "";
            TextBox222.Text = "";
            TextBox223.Text = "";
            TextBox231.Text = "";
            TextBox232.Text = "";
            TextBox233.Text = "";
            TextBox2G.Text = "";
            TextBox311.Text = "";
            TextBox312.Text = "";
            TextBox313.Text = "";
            TextBox321.Text = "";
            TextBox322.Text = "";
            TextBox323.Text = "";
            TextBox331.Text = "";
            TextBox332.Text = "";
            TextBox333.Text = "";
            Discount.Text = "";
            Reservation.Text = "";
            NPS.Text = "";
            SavingsCertificate.Text = "";
            TextBox811.Text = "";
            TextBox812.Text = "";
            TextBox813.Text = "";
            TextBox821.Text = "";
            TextBox822.Text = "";
            TextBox823.Text = "";
            TextBox831.Text = "";
            TextBox832.Text = "";
            TextBox833.Text = "";
            PPF.Text = "";
            mutualfunds.Text = "";
            corporatebonds.Text = "";
            houseloan.Text = "";
            houseloan1.Text = "";
            houseloan2.Text = "";
            houseloan3.Text = "";
            houseloan4.Text = "";
            houseloan5.Text = "";
            houseloan6.Text = "";
            constructionloan.Text = "";
            childclass1.Text = "";
            childamt1.Text = "";
            childclass2.Text = "";
            childamt2.Text = "";
            grandtotal.Text = "";
            employer.Text = "";
            anyother.Text = "";

        }
        
        void updateCredentials()
        {
            if (checkIfMemberExists())
            {
                try
                {
                    
                    SqlConnection con = new SqlConnection(strcon);

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    
                    SqlCommand cmd = new SqlCommand("UPDATE Form_Credentials SET Date_Of_Birth=@Date_Of_Birth,Name=@Name,Mobile_no=@Mobile_no,TextBox1=@TextBox1,Owner=@Owner,Pan=@Pan,TextBox211=@TextBox211,TextBox212=@TextBox212,TextBox213=@TextBox213,TextBox221=@TextBox221,TextBox222=@TextBox222,TextBox223=@TextBox223,TextBox231=@TextBox231,TextBox232=@TextBox232,TextBox233=@TextBox233,TextBox2G=@TextBox2G,TextBox311=@TextBox311,TextBox312=@TextBox312,TextBox313=@TextBox313,TextBox321=@TextBox321,TextBox322=@TextBox322,TextBox323=@TextBox323,TextBox331=@TextBox331,TextBox332=@TextBox332,TextBox333=@TextBox333,Discount=@Discount,Reservation=@Reservation,NPS=@NPS,SavingsCertificate=@SavingsCertificate,TextBox811=@TextBox811,TextBox812=@TextBox812,TextBox813=@TextBox813,TextBox821=@TextBox821,TextBox822=@TextBox822,TextBox823=@TextBox823,TextBox831=@TextBox831,TextBox832=@TextBox832,TextBox833=@TextBox833,PPF=@PPF,mutualfunds=@mutualfunds,corporatefunds=@corporatefunds,houseloan=@houseloan,houseloan1=@houseloan1,houseloan2=@houseloan2,houseloan3=@houseloan3,houseloan4=@houseloan4,houseloan5=@houseloan5,houseloan6=@houseloan6,constructionloan=@constructionloan,childclass1=@childclass1,childamt1=@childamt1,childclass2=@childclass2,childamt2=@childamt2,grandtotal=@grandtotal,employer=@employer,anyother=@anyother where id='" + id.Text.Trim() + "' ;", con);

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
                    Response.Write("<script>alert('Form Updated Successfully');</script>");
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Invalid Employee Credentials');</script>");
            }

        }


    }
}



