<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResourceAddressList.aspx.cs" MasterPageFile="Site.Master" Inherits="JobTrackingSystem.ResourceAddressList" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="page-breadcrumb" style="margin-top: -20px">
        <div class="row">
            <div class="col-12 d-flex no-block align-items-center">
                <h4 class="page-title">Address List</h4>
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
            <div class="col-md-12">
                <div class="card">
                    <div class="card-body">
                        <h4 class="card-title">Address List</h4>
                        <div class="row">
                            <asp:Repeater ID="resourcesAddresses" runat="server">
                                <ItemTemplate>
                                    <div class="col-md-4">
                                        <label>Address Type: </label> <label><%# Eval("AddressType") %></label><br />
                                        <label>Address Line 1: </label> <label><%# Eval("AddressLine1") %></label><br />
                                        <label>Address Line 2: </label> <label><%# Eval("AddressLine2") %></label><br />
                                        <label>City: </label> <label><%# Eval("City") %></label><br />
                                        <label>State: </label> <label><%# Eval("State") %></label><br />
                                        <label>PinCode: </label> <label><%# Eval("PinCode") %></label><br />
                                        <label>Country: </label> <label><%# Eval("Country") %></label><br />
                                        <asp:HyperLink ID="linkEditAddress" runat="server" NavigateUrl='<%# $"~/AddResourceAddress.aspx?resourceId={HttpUtility.UrlEncode(Eval("ResourceId").ToString())}&addressId={HttpUtility.UrlEncode(Eval("Id").ToString())}" %>'
                                                       Text="Edit" />
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                            
                        </div>

                    </div>
                    <div class="border-top">
                        <div class="card-body">
                            <asp:Button runat="server" ID="btnCancel" CssClass="btn btn-secondary" OnClick="btnCancel_OnClick" Text="Cancel"></asp:Button>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </form>
</asp:Content>
