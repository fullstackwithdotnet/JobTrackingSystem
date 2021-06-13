<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Resources.aspx.cs" Inherits="JobTrackingSystem.Resources" MasterPageFile="Site.Master" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Resources</h1>
    <p>
        <asp:HyperLink NavigateUrl="AddResource.aspx" runat="server">New Resource</asp:HyperLink>
    </p>
    <table class="table">
        <thead>
            <tr>
                <th>First Name</th>
                <th>Last Name</th>
                <th>Father's Name</th>
                <th>DOB</th>
                <th>Address Type</th>
                <th>Address Line 1</th>
                <th>Address Line 2</th>
                <th>City</th>
                <th>Mobile</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="resourcesTable" runat="server">
                <itemtemplate>
                    <tr>
                        <td><%# Eval("FirstName") %></td>
                        <td><%# Eval("LastName") %></td>
                        <td><%# Eval("FatherName") %></td>
                        <td><%# Eval("DOB") %></td>
                        <td><%# Eval("AddressType") %></td>
                        <td><%# Eval("AddressLine1") %></td>
                        <td><%# Eval("AddressLine2") %></td>
                        <td><%# Eval("City") %></td>
                        <td><%# Eval("Mobile") %></td>
                    </tr>
            </itemtemplate>
            </asp:Repeater>
        </tbody>
    </table>


</asp:Content>
