<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_034_ChallengePostageCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Postal Calculator<br />
        <br />
        Width:
        <asp:TextBox ID="Width" runat="server" AutoPostBack="True"></asp:TextBox>
        <br />
        Height:
        <asp:TextBox ID="Height" runat="server" AutoPostBack="True"></asp:TextBox>
        <br />
        Length:
        <asp:TextBox ID="Length" runat="server" AutoPostBack="True"></asp:TextBox>
        <br />
        <br />
        <asp:RadioButton ID="Ground" runat="server" AutoPostBack="True" GroupName="1" OnCheckedChanged="Calculate" Text="Ground" />
        <br />
        <asp:RadioButton ID="Air" runat="server" AutoPostBack="True" GroupName="1" OnCheckedChanged="Calculate" Text="Air" />
        <br />
        <asp:RadioButton ID="NextDay" runat="server" AutoPostBack="True" GroupName="1" OnCheckedChanged="Calculate" Text="Next Day" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
