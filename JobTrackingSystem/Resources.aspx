<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Resources.aspx.cs" Inherits="JobTrackingSystem.Resources" MasterPageFile="Site.Master" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Resources</h1>
    <p>
        <asp:HyperLink NavigateUrl="AddResource.aspx" runat="server">New Resource</asp:HyperLink>
    </p>
    <form runat="server">
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
                    <th></th>
                    <th></th>

                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="resourcesTable" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("FirstName") %></td>
                            <td><%# Eval("LastName") %></td>
                            <td><%# Eval("FathersName") %></td>
                            <td><%# Eval("MothersName") %></td>
                            <td><%# Eval("Gender") %></td>
                            <td><%# Eval("DOB") %></td>
                            <td>
                                <img width="80" height="80" src="/Images/<%# Eval("Photo") %>" /></td>
                            <td>
                                <asp:HyperLink ID="linkEditResource" runat="server" NavigateUrl='<%# string.Format("~/AddResource.aspx?resourceId={0}", HttpUtility.UrlEncode(Eval("Id").ToString())) %>'
                                    Text="Edit" />
                            </td>

                            <td>
                            <asp:LinkButton ID="linkDelete" CausesValidation="false" runat="server" OnCommand="linkDelete_OnCommand" CommandArgument='<%#Eval("Id").ToString()%>'
                                OnClientClick="return confirm('Do you really want to delete ?');"> Delete </asp:LinkButton>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </form>
</asp:Content>
