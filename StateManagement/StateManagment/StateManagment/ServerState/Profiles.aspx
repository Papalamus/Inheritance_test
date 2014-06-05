<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="Profiles.aspx.cs" Inherits="StateManagment.Pages.Profiles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head  runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:TextBox ID="SavedValueTextBox" Enabled="False" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="SavingValueTextBox" Enabled="True" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Send" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
