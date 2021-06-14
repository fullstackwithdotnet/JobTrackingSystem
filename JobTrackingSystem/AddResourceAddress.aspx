<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddResourceAddress.aspx.cs" MasterPageFile="Site.Master" Inherits="JobTrackingSystem.AddResourceAddress" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="page-breadcrumb" style="margin-top: -20px">
        <div class="row">
            <div class="col-12 d-flex no-block align-items-center">
                <h4 class="page-title">Form Basic</h4>
                <div class="ml-auto text-right">
                    <nav aria-label="breadcrumb">
                        <ol class="breadcrumb">
                            <li class="breadcrumb-item"><a href="#">Home</a></li>
                            <li class="breadcrumb-item active" aria-current="page">Add Resource Address</li>
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
                            <label for="drpAddressType" class="col-sm-3 text-right control-label col-form-label">Address Type</label>
                            <div class="col-sm-9">
                                <asp:DropDownList CssClass="form-control" ID="drpAddressType" runat="server" >
                                    <asp:ListItem Text="Residential" Value="Residential"></asp:ListItem>
                                    <asp:ListItem Text="Communication" Value="Communication"></asp:ListItem>
                                    <asp:ListItem Text="Permanent" Value="Permanent"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="txtAdd1" class="col-sm-3 text-right control-label col-form-label">Address Line 1 * </label>
                            <div class="col-sm-9">
                                <asp:TextBox CssClass="form-control" ID="txtAdd1" runat="server" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAdd1" ForeColor="Red" ErrorMessage="Enter Address Line 1" ValidationGroup="g1" Width="125px"
                                                            Font-Bold="True"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="txtAdd2" class="col-sm-3 text-right control-label col-form-label">Address Line 2 * </label>
                            <div class="col-sm-9">
                                <asp:TextBox CssClass="form-control" ID="txtAdd2" runat="server" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAdd2" ForeColor="Red" ErrorMessage="Enter Address Line 2" ValidationGroup="g1" Width="125px"
                                                            Font-Bold="True"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="txtCity" class="col-sm-3 text-right control-label col-form-label">City</label>
                            <div class="col-sm-9">
                                <asp:TextBox CssClass="form-control" ID="txtCity" runat="server" />
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="txtState" class="col-sm-3 text-right control-label col-form-label">State</label>
                            <div class="col-sm-9">
                                <asp:TextBox CssClass="form-control" ID="txtState" runat="server" />
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="txtZip" class="col-sm-3 text-right control-label col-form-label">Zip</label>
                            <div class="col-sm-9">
                                <asp:TextBox  CssClass="form-control" ID="txtZip" runat="server" />
                                
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="txtPin" class="col-sm-3 text-right control-label col-form-label">PIN</label>
                            <div class="col-sm-9">
                                <asp:TextBox  CssClass="form-control" ID="txtPin" runat="server" />
                                
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="txtCountry" class="col-sm-3 text-right control-label col-form-label">Country</label>
                            <div class="col-sm-9">
                                <asp:TextBox  CssClass="form-control" ID="txtCountry" runat="server" />
                               
                            </div>
                        </div>
                       
                    </div>
                    <div class="border-top">
                        <div class="card-body">
                            <asp:Button runat="server" ValidationGroup="g1" ID="btnAddResourceAddresAndContinue" CssClass="btn btn-primary" OnClick="btnAddResourceAddresAndContinue_OnClick" Text="Add Address And Continue"></asp:Button>
                            <asp:Button runat="server" ValidationGroup="g1" ID="btnAddResourceAddresAndAddMore" CssClass="btn btn-primary" OnClick="btnAddResourceAddresAndAddMore_OnClick" Text="Add Another Address"></asp:Button>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </form>
</asp:Content>