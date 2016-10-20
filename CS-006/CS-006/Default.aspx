<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_006.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
            font-weight: normal;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1 class="auto-style1">H1</h1>
    
    </div>
        <h2 class="auto-style1">H2</h2>
        <h3 class="auto-style1">H3</h3>
        <h4 class="auto-style1">H4</h4>
        <h5 class="auto-style1">H5</h5>
        <h6 class="auto-style1">H6</h6>
        <p>
            We are using colors</p>
        <p>
            Add hyperlink</p>
        <p>
            Another
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://nba.com" Target="_self">HyperLink</asp:HyperLink>
        </p>

    <img src="http://www.iconarchive.com/download/i27110/ph03nyx/super-mario/Retro-Mario-2.ico">
        <asp:Image ID="Image1" runat="server" />
    </form>

    </body>
</html>
