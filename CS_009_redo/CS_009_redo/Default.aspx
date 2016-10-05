<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_009_redo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <!-- Compiled and minified CSS -->
     <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.7/css/materialize.min.css">

     <!-- Compiled and minified JavaScript -->
     <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.7/js/materialize.min.js"></script>
</head>
<body>
    <div class="container">
        <form id="form1" runat="server">
        <div class="input-field col s6">
    
            <h3><asp:Label ID="Label2" runat="server" Text="Simple Calculator"></asp:Label></h3>
    
        </div>
            <p>
    
            <asp:TextBox ID="TextBox1" runat="server"  cssClass="input-field col s6"></asp:TextBox>
    
            </p>
            <p>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </p>
            <p>
          
            </p>
             <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" cssClass="waves-effect waves-light btn"/>
                <asp:Button ID="Button3" runat="server" Text="Subtract" OnClick="Button3_Click" cssClass="waves-effect green btn" />
                <asp:Button ID="Button4" runat="server" Text="Multiply" OnClick="Button4_Click" cssClass="waves-effect red btn"/>
                <asp:Button ID="Button2" runat="server" Text="Divide" OnClick="Button2_Click" cssClass="waves-effect orange btn" />
        </form>
    </div>
    <p>
           
    
            </p>
    <p>
    
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </p>
</body>
</html>
