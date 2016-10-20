<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_012_ChallengeRadio.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Your Note taking Preferences<br />
        <br />
        <asp:RadioButton ID="RadioPencil" runat="server" GroupName="stuff" Text="Pencil" />
        <br />
        <asp:RadioButton ID="RadioPen" runat="server" GroupName="stuff" Text="Pen" />
        <br />
        <asp:RadioButton ID="RadioPhone" runat="server" GroupName="stuff" Text="Phone" />
        <br />
        <asp:RadioButton ID="RadioTablet" runat="server" GroupName="stuff" Text="Tablet" />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <br />
        <br />
        <asp:Image ID="Image1" runat="server" ImageUrl="http://www.nstuffmusic.com/App_Themes/Skin_1/images/google-plus-logo.png" />
        <br />
        
    
    </div>
        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
