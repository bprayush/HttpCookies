<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HttpCookies.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cookie Homepage</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h1>Cookies (Delicious?)</h1><br/>
                <table>
                    <tr>
                        <th></th>
                        <th></th>
                    </tr>
                    <tr>
                        <td><asp:Label Text="Cookie Name" runat="server"></asp:Label></td>
                        <td><asp:TextBox ID="CookieName" runat="server"></asp:TextBox><br/></td>
                    </tr>
                    <tr>
                        <td><asp:Label Text="User" runat="server"></asp:Label></td>
                        <td><asp:TextBox ID="User" runat="server"></asp:TextBox><br/></td>
                    </tr>
                    <tr>
                        <td><asp:Label Text="Email" runat="server"></asp:Label></td>
                        <td><asp:TextBox ID="Email" runat="server"></asp:TextBox><br/></td>
                    </tr>
                </table>
                <asp:Button ID="AddCookieButton" Text="Add Cookie" OnClick="AddCookie" runat="server"/>
                <asp:Button ID="ReadCookieButton" Text="Read Cookie" OnClick="ReadCookie" runat="server"/>
                <asp:Button ID="DeleteCookieButton" Text="Delete Cookie" OnClick="DeleteCookie" runat="server"/>
            </center>
        </div>
    </form>


    <div>
        <center>
            <h1>Result</h1>
            <table>
                <tr>
                    <th colspan="2">
                        <asp:Label ID="StatusLabel" runat="server" style="color:red; font-size:20px;"></asp:Label>
                    </th>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Label ID="CookieEnabledLabel" runat="server" style="color:blue; font-size:20px;"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="Cookie Name:" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="CookieNameLabel" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="User:" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="CookieUserLabel" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="Email:" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="CookieEmailLabel" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </center>
    </div>


</body>
</html>
