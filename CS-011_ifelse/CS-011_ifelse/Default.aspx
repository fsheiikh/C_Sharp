<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_011_ifelse.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        IS
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;Equal to
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        ?<br />
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Are You Cool?" />
        <br />
        <br />
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Food" Text="Pizza" />
        <br />
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Food" Text="Salad" />
        <br />
        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="Food" Text="Burger" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
