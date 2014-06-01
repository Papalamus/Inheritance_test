<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestForm.aspx.cs" Inherits="TestApp.TestForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <Custom:TextWithCaptionControl ID="tbTest" runat="server" Separator=","
             Position="Top" DefaultText="ShowSomethingToUs" TextCaption="Text" />
    </div>
    </form>
</body>
</html>
