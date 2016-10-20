<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_022_MultiDimensionalArrays.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        From :<br />
        <br />
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="first" Text="Chicago" />
        <br />
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="first" Text="New York" />
        <br />
        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="first" Text="London" />
        <br />
        <br />
        To:<br />
        <br />
        <asp:RadioButton ID="RadioButton4" runat="server" GroupName="second" OnCheckedChanged="RadioButton4_CheckedChanged" Text="Chicago" />
        <br />
        <asp:RadioButton ID="RadioButton5" runat="server" GroupName="second" Text="New York" />
        <br />
        <asp:RadioButton ID="RadioButton6" runat="server" GroupName="second" Text="London" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="OK" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
