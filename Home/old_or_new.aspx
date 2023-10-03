<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="old_or_new.aspx.cs" Inherits="Home.old_or_new" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>
                                        Select Income tax option
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
                                
                            </div>
                        </div>
                        
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    
                                </div>
                            </div>
                        </div> 
                        
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    
                                </div>
                                
                                <div class="form-group">
                                    <asp:Button class="btn btn-primary btn-block btn-lg" ID="Button1" runat="server" Text="Old" OnClick="Old" />
                                </div>
                                
                                <div class="form-group">

                                    <asp:Button class="btn btn-info btn-block btn-lg" ID="Button2" runat="server" Text="New" OnClick="New" />
                                </div>

                                
                            </div>
                    </div>
                        
                </div>
            </div>

                <a href="userlogin.aspx"><< Back </a>
                <br><br>
        </div>

    </div>
</div>

</asp:Content>
