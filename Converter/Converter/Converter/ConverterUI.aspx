<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConverterUI.aspx.cs" Inherits="Converter.Converter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 126px;
        }
        .auto-style3 {
            width: 128px;
        }
        .auto-style4 {
            width: 120px;
        }
        .auto-style5 {
            width: 126px;
            height: 40px;
        }
        .auto-style6 {
            width: 120px;
            height: 40px;
        }
        .auto-style7 {
            width: 128px;
            height: 40px;
        }
        .auto-style8 {
            height: 40px;
        }
        .auto-style9 {
            width: 126px;
            height: 41px;
        }
        .auto-style10 {
            width: 120px;
            height: 41px;
        }
        .auto-style11 {
            width: 128px;
            height: 41px;
        }
        .auto-style12 {
            height: 41px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">Исходная валюта </td>
                <td class="auto-style6">
                    <asp:DropDownList ID="DropDownList1" runat="server" onselectedindexchanged="ChangeCourse" 
        AutoPostBack="True" AppendDataBoundItems="true"  Width="122px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style7">курс к доллару</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Сумма</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7"></td>
                <td class="auto-style8"></td>
            </tr>
            <tr>
                <td class="auto-style9">Целевая валюта</td>
                <td class="auto-style10">
                    <asp:DropDownList ID="DropDownList2" runat="server" onselectedindexchanged="ChangeCourse" 
        AutoPostBack="True" AppendDataBoundItems="true" Width="122px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style11">курс к доллару</td>
                <td class="auto-style12">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Расчитать" Width="133px" />
                </td>
                <td class="auto-style4">
                    <asp:Label ID="result" runat="server"></asp:Label>
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
