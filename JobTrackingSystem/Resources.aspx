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
                <th>Mother's Name</th>
                <th>Gender</th>
                <th>DOB</th>
                <th>Photo</th>
                
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="resourcesTable" runat="server">
                <itemtemplate>
                    <tr>
                        <td><%# Eval("FirstName") %></td>
                        <td><%# Eval("LastName") %></td>
                        <td><%# Eval("FathersName") %></td>
                        <td><%# Eval("MothersName") %></td>
                        <td><%# Eval("Gender") %></td>
                        <td><%# Eval("DOB") %></td>
                        <td><%# Eval("Photo") %></td>
                        <td><asp:HyperLink runat="server" Text="Edit"></asp:HyperLink></td>
                    </tr>
            </itemtemplate>
            </asp:Repeater>
        </tbody>
    </table>


</asp:Content>
