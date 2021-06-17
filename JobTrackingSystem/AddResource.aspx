<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddResource.aspx.cs" MasterPageFile="Site.Master" Inherits="JobTrackingSystem.AddResource" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="page-breadcrumb" style="margin-top: -20px">
        <div class="row">
            <div class="col-12 d-flex no-block align-items-center">
                <h4 class="page-title">Add Resource</h4>
                <div class="ml-auto text-right">
                    <nav aria-label="breadcrumb">
                        <ol class="breadcrumb">
                            <li class="breadcrumb-item"><a href="#">Home</a></li>
                            <li class="breadcrumb-item active" aria-current="page">Add Resource</li>
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
                            <label for="txtFName" class="col-sm-3 text-right control-label col-form-label">First Name *</label>
                            <div class="col-sm-9">
                                <asp:TextBox CssClass="form-control" ID="txtFName" runat="server" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtFName" ForeColor="Red" ErrorMessage="Enter First Name" ValidationGroup="g1" Width="125px"
                                                            Font-Bold="True"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="txtLName" class="col-sm-3 text-right control-label col-form-label">Last Name * </label>
                            <div class="col-sm-9">
                                <asp:TextBox CssClass="form-control" ID="txtLName" runat="server" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLName" ForeColor="Red" ErrorMessage="Enter Last Name" ValidationGroup="g1" Width="125px"
                                                            Font-Bold="True"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="txtFatherName" class="col-sm-3 text-right control-label col-form-label">Father's Name</label>
                            <div class="col-sm-9">
                                <asp:TextBox CssClass="form-control" ID="txtFatherName" runat="server" />
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="txtMotherName" class="col-sm-3 text-right control-label col-form-label">Mother's Name</label>
                            <div class="col-sm-9">
                                <asp:TextBox CssClass="form-control" ID="txtMotherName" runat="server" />
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="drpGender" class="col-sm-3 text-right control-label col-form-label">Gender</label>
                            <div class="col-sm-9">
                                <asp:DropDownList CssClass="form-control" ID="drpGender" runat="server" >
                                    <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                                    <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="txtDOB" class="col-sm-3 text-right control-label col-form-label">Birth Date *</label>
                            <div class="col-sm-9">
                                <asp:TextBox TextMode="Date" CssClass="form-control" ID="txtDOB" runat="server" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtDOB" ForeColor="Red" ErrorMessage="Enter DOB" ValidationGroup="g1" Width="125px"
                                                            Font-Bold="True"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="photoUpload" class="col-sm-3 text-right control-label col-form-label">Photo *</label>
                            <div class="col-sm-9">
                                <asp:FileUpload  CssClass="form-control" ID="photoUpload" runat="server"  />
                                <asp:Image ID="imagePhoto" runat="server" Width="300" Height="200"  />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="photoUpload" ForeColor="Red" ErrorMessage="Please upload photo" ValidationGroup="g1" Width="125px"
                                                            Font-Bold="True"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                       
                    </div>
                    <div class="border-top">
                        <div class="card-body">
                            <asp:Button runat="server" ValidationGroup="g1" ID="btnAddResource" CssClass="btn btn-primary" OnClick="btnAddResource_OnClick" Text="Add Resource And Continue"></asp:Button>
                            <asp:Button runat="server" ValidationGroup="g1" ID="btnCancel" CssClass="btn btn-secondary" OnClick="btnCancel_OnClick" Text="Cancel"></asp:Button>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </form>
</asp:Content>
