<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_013_PapaBobsChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: xx-large;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: x-large;
        }
        .auto-style3 {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <strong>
        <asp:Image ID="Image1" runat="server" CssClass="auto-style1" ImageUrl="~/PapaBob.png" />
        </strong><span class="auto-style1"><strong>Papa Bob&#39;s Pizza and Software</strong></span></div>
        <asp:RadioButton ID="Radio_10" runat="server" Checked="True" GroupName="size" Text="Baby Bob Size(10&quot;) - $10" />
        <br />
        <asp:RadioButton ID="Radio_13" runat="server" GroupName="size" Text="Mama Bob Size(13&quot;) - $13" />
        <br />
        <asp:RadioButton ID="Radio_16" runat="server" GroupName="size" Text="Papa Bob Size (16&quot;) - $16" />
        <br />
        <br />
        <asp:RadioButton ID="Radio_thin" runat="server" Checked="True" GroupName="crust" Text="Thin Crust" />
        <br />
        <asp:RadioButton ID="Radio_deep" runat="server" GroupName="crust" Text="Deep Dish" />
        <br />
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Pepperoni(+$1.50)" />
        <br />
        <asp:CheckBox ID="CheckBox2" runat="server" Text="Onions(+$0.75)" />
        <br />
        <asp:CheckBox ID="CheckBox3" runat="server" Text="Green Peppers($0.50)" />
        <br />
        <asp:CheckBox ID="CheckBox4" runat="server" Text="Red Peppers(+$0.75)" />
        <br />
        <asp:CheckBox ID="CheckBox5" runat="server" Text="Anchovies(+$2)" />
        <br />
        <br />
        <span class="auto-style2"><strong>Papa Bob&#39;s <span class="auto-style3">Special Deal<br />
        <br />
        </span></strong><span class="auto-style3">
        <asp:Label ID="Label2" runat="server" style="font-size: medium; font-family: 'Times New Roman', Times, serif; color: #000000">Save $2.00 when you add Pepperoni, Green Peppers and Anchovies OR Pepperoni, Red Peppeers and Onions to your pizza.</asp:Label>
        <br />
        </span></span>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Purchase" />
        <br />
        <br />
        Total: <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
    </form>
</body>
</html>
