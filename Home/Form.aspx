<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="Home.Form" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-12 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="50" src="Images/Logo.png" />
                                </center>
                                
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>
                                        Central Electronics Limited - Sahibabad
                                    </h3>
                                </center>
                                <center><h4>Tax Registration Form</h4></center>
        
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr></hr>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>
                                    Employee Id
                                        <span class="text-danger">*</span>
                                    </label>
                                    <asp:TextBox CssClass="form-control" ID="id" runat="server" placeholder="Id" TextMode="SingleLine"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rvffullname" runat="server" ControlToValidate="id" InitialValue="" ErrorMessage="Id is required" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                                </div>

                            </div>
                        </div>
                        
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>
                                        Date of Birth: 
                                        <span class="text-danger">*</span>
                                    </label>
                                    <asp:TextBox CssClass="form-control" ID="date" runat="server" placeholder="dd/mm/yyyy" TextMode="Date"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="date" InitialValue="" ErrorMessage="Date of Birth is required" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                        </div>
                        
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>
                                        Full Name
                                        <span class="text-danger">*</span>
                                    </label>
                                    <asp:TextBox CssClass="form-control" ID="fullname" runat="server" placeholder="Name" TextMode="SingleLine"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="fullname" InitialValue="" ErrorMessage="Name is required" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                        </div>
                        
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>
                                        Mobile Number:
                                        <span class="text-danger">*</span>
                                    </label>
                                    <asp:TextBox CssClass="form-control" ID="mobileno" runat="server" placeholder="Mobile No" TextMode="Phone"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="mobileno" InitialValue="" ErrorMessage="Mobile Number is required" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                        </div>
                        
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>
                                        1. Money paid monthly
                                    </label>
                                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control mb-3"></asp:TextBox>
                                     <asp:Button ID="Enter" runat="server" Text="Enter" OnClick="Enter_Click" CssClass="btn btn-secondary" />
                                 
                                </div>
                                <div class="col-md-4" id="additionalColumns" runat="server" visible="false">
                                     <label>House Owner Name</label>
                                     <asp:Textbox ID="Owner" runat="server" CssClass="mb-3"></asp:Textbox>
                                     <lable>PAN No.</lable>
                                     <asp:Textbox ID="PAN" runat="server" CssClass="mb-3"></asp:Textbox>

                                 </div>
                            </div>
                        </div>
                        
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>
                                        2. Premium paid from LIC other than Salary Savings Schemes maturing in 2022-23
                                    </label>
                             
                                </div>
                            </div>
                        </div>
                        
                        <div class="row">
                            <div class="col-md-4">
                                <label>1.1 Policy No.</label>                             
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox211" runat="server" placeholder="Policy No." TextMode="Number"></asp:TextBox>
                                    
                                </div>
                            </div>
                            
                            <div class="col-md-4">
                                <label>1.2 Submission Date</label>                             
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox212" runat="server" placeholder="dd/mm/yyyy" TextMode="Date"></asp:TextBox>
                                    
                                </div>
                            </div>
                            
                            <div class="col-md-4">
                                <label>1.3 Premium Amount</label>                             
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox213" runat="server" placeholder="Amount" TextMode="Number"></asp:TextBox>
                                    
                                </div>
                            </div>
                        </div>
                        
                        <div class="row">
                            <div class="col-md-4">
                                <label>2.1 Policy No.</label>                             
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox221" runat="server" placeholder="Policy No." TextMode="Number"></asp:TextBox>
                                    
                                </div>
                            </div>
                            
                            <div class="col-md-4">
                                <label>2.2 Submission Date</label>                             
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox222" runat="server" placeholder="dd/mm/yyyy" TextMode="Date"></asp:TextBox>
                                    
                                </div>
                            </div>
                            
                            <div class="col-md-4">
                                <label>2.3 Premium Amount</label>                             
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox223" runat="server" placeholder="Amount" TextMode="Number"></asp:TextBox>
                                    
                                </div>
                            </div>
                        </div>
                        
                        <div class="row">
                            <div class="col-md-4">
                                <label>2.1 Policy No.</label>                             
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox231" runat="server" placeholder="Policy No." TextMode="Number"></asp:TextBox>
                                    
                                </div>
                            </div>
                            
                            <div class="col-md-4">
                                <label>2.2 Submission Date</label>                             
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox232" runat="server" placeholder="dd/mm/yyyy" TextMode="Date"></asp:TextBox>
                                    
                                </div>
                            </div>
                            
                            <div class="col-md-4">
                                <label>2.3 Premium Amount</label>                             
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox233" runat="server" placeholder="Amount" TextMode="Number"></asp:TextBox>
                                    
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <label>Grand Total</label>
                                <div class="form-group">                                    
                                    <asp:TextBox CssClass="form-control" ID="TextBox2G" runat="server" placeholder="Amount" TextMode="Number"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>
                                    3. Medical Policy (Exemption under 80D)
                                    </label>
     
                                    </div>
                            </div>
                        </div>
                        

                        <div class="row">
                            <div class="col-md-4">
                                <label>1.1 Policy No.</label>                             
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox311" runat="server" placeholder="Policy No." TextMode="Number"></asp:TextBox>
                                    
                                </div>
                            </div>
                            
                            <div class="col-md-4">
                                <label>1.2 Submission Date</label>                             
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox312" runat="server" placeholder="dd/mm/yyyy" TextMode="Date"></asp:TextBox>
                                    
                                </div>
                            </div>
                            
                            <div class="col-md-4">
                                <label>1.3 Premium Amount</label>                             
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox313" runat="server" placeholder="Amount" TextMode="Number"></asp:TextBox>
                                    
                                </div>
                            </div>
                        </div>
                        
                        <div class="row">
                            <div class="col-md-4">
                                <label>2.1 Policy No.</label>                             
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox321" runat="server" placeholder="Policy No." TextMode="Number"></asp:TextBox>
                                    
                                </div>
                            </div>
                            
                            <div class="col-md-4">
                                <label>2.2 Submission Date</label>                             
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox322" runat="server" placeholder="dd/mm/yyyy" TextMode="Date"></asp:TextBox>
                                    
                                </div>
                            </div>
                            
                            <div class="col-md-4">
                                <label>2.3 Premium Amount</label>                             
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox323" runat="server" placeholder="Amount" TextMode="Number"></asp:TextBox>
                                    
                                </div>
                            </div>
                        </div>
                        
                        <div class="row">
                            <div class="col-md-4">
                                <label>2.1 Policy No.</label>                             
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox331" runat="server" placeholder="Policy No." TextMode="Number"></asp:TextBox>
                                    
                                </div>
                            </div>
                            
                            <div class="col-md-4">
                                <label>2.2 Submission Date</label>                             
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox332" runat="server" placeholder="dd/mm/yyyy" TextMode="Date"></asp:TextBox>
                                    
                                </div>
                            </div>
                            
                            <div class="col-md-4">
                                <label>2.3 Premium Amount</label>                             
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox333" runat="server" placeholder="Amount" TextMode="Number"></asp:TextBox>
                                    
                                </div>
                            </div>
                        </div>
                        
                        
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>
                                        4. Discount on certificate to get exemption under handicapped 80 DD
                                    </label>
                                   
                                     <asp:TextBox CssClass="form-control" ID="Discount" runat="server" placeholder="Discount" TextMode="Number"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                            
                           
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>
                                        5. Reservation test or interest (80E) for higher education. 
                                    </label>
                                     
                                    <asp:TextBox CssClass="form-control" ID="Reservation" runat="server" placeholder="Amount" TextMode="Number"></asp:TextBox>
                                </div>
                                
                               
                                </div>
                          </div>

                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>
                                        6.NPS Plan (80CCD)
                                    </label>
                                        <asp:TextBox CssClass="form-control" ID="NPS" runat="server" placeholder="Amount" TextMode="Number"></asp:TextBox>
                                        </div>
                                </div>
                        </div>
                        
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>
                                        7. 8th Issue National Savings Certificates purchased during 2021-22 (NSC VIII Service) (80C)
                                    </label>
                                         <asp:TextBox CssClass="form-control" ID="SavingsCertificate" runat="server" placeholder="Yes/No" TextMode="SingleLine"></asp:TextBox>
                                        </div>
                                </div>
                        </div>
                        
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>
                                    8. Details of ULIP Subscribers
                                    </label>     
                                    </div>
                            </div>
                        </div>
                        
                        <div class="row">
                            <div class="col-md-4">
                                <label>1.1 Policy No.</label>                             
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox811" runat="server" placeholder="Policy No." TextMode="Number"></asp:TextBox>
                                    
                                </div>
                            </div>
                            
                            <div class="col-md-4">
                                <label>1.2 Submission Date</label>                             
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox812" runat="server" placeholder="dd/mm/yyyy" TextMode="Date"></asp:TextBox>
                                    
                                </div>
                            </div>
                            
                            <div class="col-md-4">
                                <label>1.3 Premium Amount</label>                             
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox813" runat="server" placeholder="Amount" TextMode="Number"></asp:TextBox>
                                    
                                </div>
                            </div>
                        </div>
                        
                        <div class="row">
                            <div class="col-md-4">
                                <label>2.1 Policy No.</label>                             
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox821" runat="server" placeholder="Policy No." TextMode="Number"></asp:TextBox>
                                    
                                </div>
                            </div>
                            
                            <div class="col-md-4">
                                <label>2.2 Submission Date</label>                             
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox822" runat="server" placeholder="dd/mm/yyyy" TextMode="Date"></asp:TextBox>
                                    
                                </div>
                            </div>
                            
                            <div class="col-md-4">
                                <label>2.3 Premium Amount</label>                             
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox823" runat="server" placeholder="Amount" TextMode="Number"></asp:TextBox>
                                    
                                </div>
                            </div>
                        </div>
                        
                        <div class="row">
                            <div class="col-md-4">
                                <label>3.1 Policy No.</label>                             
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox831" runat="server" placeholder="Policy No." TextMode="Number"></asp:TextBox>
                                    
                                </div>
                            </div>
                            
                            <div class="col-md-4">
                                <label>3.2 Submission Date</label>                             
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox832" runat="server" placeholder="dd/mm/yyyy" TextMode="Date"></asp:TextBox>
                                    
                                </div>
                            </div>
                            
                            <div class="col-md-4">
                                <label>3.3 Premium Amount</label>                             
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox833" runat="server" placeholder="Amount" TextMode="Number"></asp:TextBox>
                                    
                                </div>
                            </div>
                        </div>
                        
                        
                       

                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>
                                        9. PPF deposited during the year
                                    </label>
                                        <asp:TextBox CssClass="form-control" ID="PPF" runat="server" placeholder="Amount" TextMode="Number"></asp:TextBox>
                                        </div>
                                </div>
                        </div>
                        
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>
                                        10. Investment in Mutual Funds during the year
                                    </label>
                                        <asp:TextBox CssClass="form-control" ID="mutualfunds" runat="server" placeholder="Amount" TextMode="Number"></asp:TextBox>
                                        </div>
                                </div>
                        </div>
                        
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>
                                        11. Investment in Corporate Bonds like ICICI, IDBI, etc.
                                    </label>
                                        <asp:TextBox CssClass="form-control" ID="corporatebonds" runat="server" placeholder="Amount" TextMode="Number"></asp:TextBox>
                                        </div>
                                </div>
                        </div>
                        
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>
                                        12. Full repayment of loan/investment during the previous year in respect of house construction/purchase
                                    </label>
                                        <asp:TextBox CssClass="form-control" ID="houseloan" runat="server" placeholder="Yes/No" TextMode="SingleLine"></asp:TextBox>
                                        </div>
                                </div>
                        </div>
                        
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <h6>No exemption applicable on purchase of land,improvement of house, repairs.</h6>
                                    <label>
                                        i) Property Address
                                    </label>
                                        <asp:TextBox CssClass="form-control" ID="houseloan1" runat="server" placeholder="Address" TextMode="MultiLine"></asp:TextBox>
                                    
                                    <label>
                                        ii) Amount of loan/investment repaid in full during the year.
                                    </label>
                                        <asp:TextBox CssClass="form-control" ID="houseloan2" runat="server" placeholder="Amount" TextMode="Number"></asp:TextBox>
                                    <h6>(Only Principal to be indicated on the basis of letter issued by the lending agency.)</h6>
                                    
                                    <label>
                                        iii) Lending Agency Name
                                    </label>
                                        <asp:TextBox CssClass="form-control" ID="houseloan3" runat="server" placeholder="Name" TextMode="SingleLine"></asp:TextBox>
                                    
                                    <label>
                                        iv) DDA/DGA/U.P. Housing Develeopment.
                                        </label>
                                        <asp:TextBox CssClass="form-control" ID="houseloan4" runat="server" placeholder="Name" TextMode="SingleLine"></asp:TextBox>
                                    <h6>(Purchased from(Write Name)</h6>
                                     
                                    <label>
                                        v) Construction Completion Certificate/Possession Date
                                        </label>
                                        <asp:TextBox CssClass="form-control" ID="houseloan5" runat="server" placeholder="dd/mm/yyyy" TextMode="Date"></asp:TextBox>
                                    
                                    <label>
                                        vi) Purpose of loan as indicated by HDFC/LIC/Bank
                                        </label>
                                        <asp:TextBox CssClass="form-control" ID="houseloan6" runat="server" placeholder="Purpose" TextMode="MultiLine"></asp:TextBox>
                                    
                                    
                                        </div>
                                </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>
                                        13. Interest payment on building construction loan in case of self use (Submit Form 12C)
                                    </label>
                                        <asp:TextBox CssClass="form-control" ID="constructionloan" runat="server" placeholder="Interest Rate" TextMode="Number"></asp:TextBox>
                                        </div>
                                </div>
                        </div>
                        
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>
                                        14. Tuition fees paid on children's education
                                    </label>
                                        </div>
                                </div>
                        </div>
                        
                        <div class="row">
                            <div class="col-md-6">
                                <label>Class</label>
                                <div class="form-group">
                                     <asp:TextBox CssClass="form-control" ID="childclass1" runat="server" placeholder="Class" TextMode="Number"></asp:TextBox>
                                        </div>
                                </div>
                            
                            <div class="col-md-6">
                                <label>Amount of Money</label>
                                <div class="form-group">
                                     <asp:TextBox CssClass="form-control" ID="childamt1" runat="server" placeholder="Amount" TextMode="Number"></asp:TextBox>
                                        </div>
                                </div>
                        </div>
                        
                        <div class="row">
                            <div class="col-md-6">
                                <label>Class</label>
                                <div class="form-group">
                                     <asp:TextBox CssClass="form-control" ID="childclass2" runat="server" placeholder="Class" TextMode="Number"></asp:TextBox>
                                        </div>
                                </div>
                            
                            <div class="col-md-6">
                                <label>Amount of Money</label>
                                <div class="form-group">
                                     <asp:TextBox CssClass="form-control" ID="childamt2" runat="server" placeholder="Amount" TextMode="Number"></asp:TextBox>
                                        </div>
                                </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>
                                        Grand Total
                                    </label>
                                    <asp:TextBox CssClass="form-control" ID="grandtotal" runat="server" placeholder="Amount" TextMode="Number"></asp:TextBox>
                                    </div>
                                </div>
                        </div>
                        
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>
                                        15. Full address of employer other than spouse,if any
                                    </label>
                                    <asp:TextBox CssClass="form-control" ID="employer" runat="server" placeholder="Address" TextMode="MultiLine"></asp:TextBox>
                                    </div>
                                </div>
                        </div>
                        
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>
                                        16. Any other savings details.
                                    </label>
                                    <asp:TextBox CssClass="form-control" ID="anyother" runat="server" placeholder="Address" TextMode="MultiLine"></asp:TextBox>
                                    </div>
                                </div>
                        </div>
                        
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>
                                        Announcement:
                                    </label>
                                    
                                    </div>
                                </div>
                        </div>
                        
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <asp:CheckBox ID="CheckBox1" runat="server" />
                                    I hereby declare that the particulars given above are true and correct.
                                    </div>
                                </div>
                        </div>                         
                           
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <asp:CheckBox ID="CheckBox2" runat="server" />
                                     I further declare that I have not transferred/sold the house property as per section 80C5.
                                    </div>
                                </div>
                        </div> 
                        
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <asp:CheckBox ID="CheckBox3" runat="server" />
                                    I further declare and understand that I shall be liable to any penal action under the Income Tax Act for any mis-declararion or mis-representation of relevant facts and that the above savings have not been made by any other person.
                                    
                                    </div>
                                </div>
                        </div>  
                       
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <asp:CheckBox ID="CheckBox4" runat="server" />
                                    The above PAN No. is Correct.
                                    </div>
                                </div>
                        </div>  
                        
                        <br />
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <center>
                                    
                                    <asp:Button CssClass="btn btn-success btn-block" ID="SubmitForm" runat="server" Text="Submit Form" OnClick="SubmitForm_Click" />
                                   </center>
                                    </div>
                                </div>
                        </div>


                </div>
            </div>
                      
                <a href="userlogin.aspx"><< Back to Login </a>
                <br><br>
        </div>

    </div>
</div>

</asp:Content>
                        

