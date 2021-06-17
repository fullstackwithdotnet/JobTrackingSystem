<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddResourceEducation.aspx.cs" MasterPageFile="Site.Master" Inherits="JobTrackingSystem.AddResourceEducation" %>


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
            <asp:TextBox CssClass="form-control" ID="txtEducationId" Visible="False" runat="server" />
            <asp:TextBox CssClass="form-control" ID="txtResourceId" Visible="False" runat="server" />
            <div class="col-md-12">
                <div class="card">
                    <div class="card-body">
                        <h4 class="card-title">Education Info</h4>

                        <div class="form-group row">
                            <label for="txtType" class="col-sm-3 text-right control-label col-form-label">Type</label>
                            <div class="col-sm-9">
                                <asp:TextBox CssClass="form-control" ID="txtType" runat="server" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtType" ForeColor="Red" ErrorMessage="Enter Type" ValidationGroup="g1" Width="125px"
                                    Font-Bold="True"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="txtInstitute" class="col-sm-3 text-right control-label col-form-label">Institute</label>
                            <div class="col-sm-9">
                                <asp:TextBox CssClass="form-control" ID="txtInstitute" runat="server" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtInstitute" ForeColor="Red" ErrorMessage="Enter Address Line 2" ValidationGroup="g1" Width="125px"
                                    Font-Bold="True"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="txtUniversity" class="col-sm-3 text-right control-label col-form-label">University</label>
                            <div class="col-sm-9">
                                <asp:TextBox CssClass="form-control" ID="txtUniversity" runat="server" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtUniversity" ForeColor="Red" ErrorMessage="Enter Address Line 2" ValidationGroup="g1" Width="125px"
                                    Font-Bold="True"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="txtPassingYear" class="col-sm-3 text-right control-label col-form-label">Passing Year</label>
                            <div class="col-sm-9">
                                <asp:TextBox CssClass="form-control" ID="txtPassingYear" runat="server" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPassingYear" ForeColor="Red" ErrorMessage="Enter Address Line 2" ValidationGroup="g1" Width="125px"
                                    Font-Bold="True"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="txtPercentage" class="col-sm-3 text-right control-label col-form-label">Percentage</label>
                            <div class="col-sm-9">
                                <asp:TextBox CssClass="form-control" ID="txtPercentage" runat="server" />

                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="txtGrade" class="col-sm-3 text-right control-label col-form-label">Grade</label>
                            <div class="col-sm-9">
                                <asp:TextBox CssClass="form-control" ID="txtGrade" runat="server" />

                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="updlCertificate" class="col-sm-3 text-right control-label col-form-label">Certificate</label>
                            <div class="col-sm-9">
                                <asp:FileUpload CssClass="form-control" ID="updlCertificate" runat="server" />
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="upldMarkSheet" class="col-sm-3 text-right control-label col-form-label">Mark Sheet</label>
                            <div class="col-sm-9">
                                <asp:FileUpload CssClass="form-control" ID="upldMarkSheet" runat="server" />
                            </div>
                        </div>



                    </div>
                    <div class="border-top">
                        <div class="card-body">
                            <asp:Button runat="server" ValidationGroup="g1" ID="btnAddResourceEducationAndContinue" CssClass="btn btn-primary" OnClick="btnAddResourceEducationAndContinue_OnClick" Text="Add Education And Continue"></asp:Button>
                            <asp:Button runat="server" ValidationGroup="g1" ID="btnAddResourceEducationAndAddMore" CssClass="btn btn-info" OnClick="btnAddResourceEducationAndAddMore_OnClick" Text="Add Another Education"></asp:Button>
                            <asp:Button runat="server" ID="btnCancel" CssClass="btn btn-secondary" OnClick="btnCancel_OnClick" Text="Cancel"></asp:Button>


                        </div>
                    </div>
                </div>

            </div>
        </div>
    </form>
</asp:Content>
