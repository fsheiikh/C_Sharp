<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_034_ChallengeCasino.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <!--  http://www.colorzilla.com/gradient-editor/ -->
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">

    <!-- Latest compiled and minified JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
    <style type="text/css">
        /*http://www.colorzilla.com/gradient-editor/*/
        body {background:-webkit-linear-gradient(top, rgba(245,246,246,1) 0%,rgba(219,220,226,1) 21%,rgba(184,186,198,1) 49%,rgba(221,223,227,1) 80%,rgba(245,246,246,1) 100%);}
        .images {margin: 20px;
                background: -webkit-linear-gradient(top, #4c4c4c 0%,#595959 12%,#666666 25%,#474747 39%,#2c2c2c 50%,#000000 51%,#111111 60%,#2b2b2b 76%,#1c1c1c 91%,#131313 100%);
                padding: 40px;
                border-radius: 10px; }
        .first {margin-left: 20%}
        .img-shadow {
            padding: 20px;
            border-radius: 20px;
            background: -webkit-linear-gradient(top, rgba(242,246,248,1) 0%,rgba(216,225,231,1) 50%,rgba(181,198,208,1) 51%,rgba(224,239,249,1) 100%)}
        img{margin-left: 10px;}
        .info {width: 500px;
            margin: 0 auto;
            text-align: center;}
        .small {width: 50px;
                height: 50px;}
        .smallimage {width: 300px;
                    margin: 0 auto}
        .red {color: red}
        .green {color: green}
        .black {color: black;}
    </style>
</head>
<body>
    <div class="container">
    <form id="form1" runat="server">
    <div>
    
    </div>
    <div class="images">
        <asp:Image ID="Image1" runat="server" ImageUrl="Seven.png" CssClass="first img-shadow" />
        <asp:Image ID="Image2" runat="server" ImageUrl="HorseShoe.png" CssClass="img-shadow"/>
        <asp:Image ID="Image3" runat="server" ImageUrl="Seven.png" CssClass="img-shadow"/>
      
    </div>
    <div class="info">
        <br />
        <br />
        <label>Your Bet:</label>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Place Bet" CssClass="btn btn-warning"/>
        <br />
        <h3><asp:Label ID="Label2" runat="server"></asp:Label></h3>
        <br />
        <br />
        <h3>Player&#39;s Money: $<asp:Label ID="Label1" runat="server" Text="100"></asp:Label></h3>
        <br />
        <br />
        <div class="well smallimage"><img src="Cherry.png" class="small"> - x2</div><br />
        <div class="well smallimage"><img src="Cherry.png" class="small"><img src="Cherry.png" class="small"> - x3</div><br />
        <div class="well smallimage"><img src="Cherry.png" class="small"><img src="Cherry.png" class="small"><img src="Cherry.png" class="small"> -  x4</div><br />
        <div class="well smallimage"><img src="Seven.png" class="small"><img src="Seven.png" class="small"><img src="Seven.png" class="small"> - x100</div><br />
        <div class="well smallimage"><img src="Bar.png" class="small"> - Nothing</div></form>
        </div>
    </div>
</body>
</html>
