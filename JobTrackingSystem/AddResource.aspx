<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddResource.aspx.cs" MasterPageFile="Site.Master" Inherits="JobTrackingSystem.AddResource" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Create Resource</h1>
    <div class="row">
        <div class="col-md-4">

            <div class="form-group">
                <label for="txtFName">First Name</label>
                <asp:TextBox CssClass="form-control" ID="txtFName" placeholder="Enter first name" runat="server" />
            </div>
            <div class="form-group">
                <label for="txtLName">Last Name</label>
                <asp:TextBox CssClass="form-control" ID="txtLName" runat="server" />
            </div>
            <div class="form-group">
                <label for="txtFatherName">Father Name</label>
                <asp:TextBox CssClass="form-control" ID="txtFatherName"  runat="server" />
            </div>
            <div class="form-group">
                <label for="dob">DOB</label>
                <asp:TextBox CssClass="form-control" ID="DOB" TextMode="Date" runat="server" />
            </div>
            <div class="form-group">
                <label for="drpAddressType">Address Type</label>
                <asp:DropDownList ID="drpAddressType" runat="server" CssClass="form-control" >  
                    <asp:ListItem Value="">Please Select</asp:ListItem>  
                    <asp:ListItem>Residential</asp:ListItem>  
                    <asp:ListItem>Communication</asp:ListItem>  
                    <asp:ListItem>Permanent</asp:ListItem>
                </asp:DropDownList>  
            </div>
            <div class="form-group">
                <label for="txtAddress1">Address Line 1</label>
                <asp:TextBox CssClass="form-control" ID="txtAddress1"  runat="server" />
            </div>
            <div class="form-group">
                <label for="txtAddress2">Address Line 1</label>
                <asp:TextBox CssClass="form-control" ID="txtAddress2"  runat="server" />
            </div>
            <div class="form-group">
                <label for="txtCity">City</label>
                <asp:TextBox CssClass="form-control" ID="txtCity"  runat="server" />
            </div>
            <div class="form-group">
                <label for="txtMobile">Mobile</label>
                <asp:TextBox CssClass="form-control" ID="txtMobile"  runat="server" />
            </div>

            <asp:Button runat="server" ID="btnAddResource" CssClass="btn btn-primary" OnClick="btnAddResource_OnClick" Text="Add Resource"></asp:Button>

        </div>
    </div>
</asp:Content>
