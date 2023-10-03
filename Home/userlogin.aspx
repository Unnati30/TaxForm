<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="userlogin.aspx.cs" Inherits="Home.userlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="150px" src="Images/generaluser.png" />
                                </center>
                                
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>
                                        Employee Login
                                    </h3>
                                </center>
        
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
                                        Employee ID
                                    </label>
                                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Employee ID"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>
                                        Employee Name
                                    </label>
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Employee Name"></asp:TextBox>
                                </div>
                            </div>
                        </div> 
                        
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>
                                        Password
                                    </label>
                                    <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                                </div>
                                
                                <div class="form-group">
                                    <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                                </div>

                                
                            </div>
                    </div>
                        
                </div>
            </div>

                <a href="Home.aspx"><< Back to Home </a>
                <br><br>
        </div>

    </div>
</div>

</asp:Content>
