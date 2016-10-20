<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_028_SimpleHelpers.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Convert to cups</div>
        <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True"></asp:TextBox>
        <br />
        <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" Text="Cups" GroupName="1" OnCheckedChanged="CalculateCups" />
        <br />
        <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" Text="Pints" GroupName="1" OnCheckedChanged="CalculateCups" />
        <br />
        <asp:RadioButton ID="RadioButton3" runat="server" AutoPostBack="True" Text="Quarts" GroupName="1" OnCheckedChanged="CalculateCups" />
        <br />
        <asp:RadioButton ID="RadioButton4" runat="server" AutoPostBack="True" Text="Gallons" GroupName="1" OnCheckedChanged="CalculateCups" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
    </form>
</body>
</html>
