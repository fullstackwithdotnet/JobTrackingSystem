<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddResourceSocial.aspx.cs" MasterPageFile="Site.Master" Inherits="JobTrackingSystem.AddResourceSocial" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="page-breadcrumb" style="margin-top: -20px">
        <div class="row">
            <div class="col-12 d-flex no-block align-items-center">
                <h4 class="page-title">Form Basic</h4>
                <div class="ml-auto text-right">
                    <nav aria-label="breadcrumb">
                        <ol class="breadcrumb">
                            <li class="breadcrumb-item"><a href="#">Home</a></li>
                            <li class="breadcrumb-item active" aria-current="page">Add Resource Socials</li>
                        </ol>
                    </nav>
                </div>
            </div>
        </div>
    </div>
    <form class="form-horizontal mt-3" runat="server">
        <asp:ScriptManager runat="server">
            <Scripts>
                <%--Framework Scripts--%>
                <asp:ScriptReference Name="MsAjaxBundle" />
                <asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />
                <asp:ScriptReference Name="WebUIValidation.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebUIValidation.js" />
                <%--Site Scripts--%>
            </Scripts>
        </asp:ScriptManager>
        <div class="row">
            <asp:TextBox CssClass="form-control" ID="txtResourceId" Visible="False" runat="server" />
            <div class="col-md-12">
                <div class="card">
                    <div class="card-body">
                        <h4 class="card-title">Personal Info</h4>
                        
                        <div class="form-group row">
                            <label for="txtMobile" class="col-sm-3 text-right control-label col-form-label">Mobile * </label>
                            <div class="col-sm-9">
                                <asp:TextBox CssClass="form-control" ID="txtMobile" runat="server" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtMobile" ForeColor="Red" ErrorMessage="Enter Address Line 1" ValidationGroup="g1" Width="125px"
                                                            Font-Bold="True"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="txtAltMobile" class="col-sm-3 text-right control-label col-form-label">Alt Mobile </label>
                            <div class="col-sm-9">
                                <asp:TextBox CssClass="form-control" ID="txtAltMobile" runat="server" />
                                
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="txtEmail" class="col-sm-3 text-right control-label col-form-label">Email</label>
                            <div class="col-sm-9">
                                <asp:TextBox CssClass="form-control" ID="txtEmail" runat="server" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEmail" ForeColor="Red" ErrorMessage="Enter Address Line 2" ValidationGroup="g1" Width="125px"
                                                            Font-Bold="True"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="txtWhatsApp" class="col-sm-3 text-right control-label col-form-label">WhatsApp</label>
                            <div class="col-sm-9">
                                <asp:TextBox CssClass="form-control" ID="txtWhatsApp" runat="server" />
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="txtFacebook" class="col-sm-3 text-right control-label col-form-label">Facebook</label>
                            <div class="col-sm-9">
                                <asp:TextBox  CssClass="form-control" ID="txtFacebook" runat="server" />
                                
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="txtInstagram" class="col-sm-3 text-right control-label col-form-label">Instagram</label>
                            <div class="col-sm-9">
                                <asp:TextBox  CssClass="form-control" ID="txtInstagram" runat="server" />
                                
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="txtTwitter" class="col-sm-3 text-right control-label col-form-label">Twitter</label>
                            <div class="col-sm-9">
                                <asp:TextBox  CssClass="form-control" ID="txtTwitter" runat="server" />
                               
                            </div>
                        </div>
                       
                    </div>
                    <div class="border-top">
                        <div class="card-body">
                            <asp:Button runat="server" ValidationGroup="g1" ID="btnAddResourceSocialAndContinue" CssClass="btn btn-primary" OnClick="btnAddResourceSocialAndContinue_OnClick" Text="Add Contact Details And Finish"></asp:Button>
                            <asp:Button runat="server" ID="btnCancel" CssClass="btn btn-secondary" OnClick="btnCancel_OnClick" Text="Cancel"></asp:Button>

                        </div>
                    </div>
                </div>

            </div>
        </div>
    </form>
</asp:Content>