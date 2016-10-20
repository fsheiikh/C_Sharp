<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_051_MegaChallengeWar.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
            <!-- Latest compiled and minified CSS -->
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

        <!-- Optional theme -->
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">

        <!-- Latest compiled and minified JavaScript -->
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
    <title></title>
    <style>
        .right {
            width: 250px;
            float: right;
            border: 1px solid gray;
            vertical-align: top;
            display: inline-block;
        }
        .left {
            width: 250px;
            float: left;
            border: 1px solid gray;
            vertical-align: top;
            display: inline-block;
        }
        
        .center {
            width: 200px;
            height: 339px;
            margin-left: 10%;
            display: inline-block;
            vertical-align: top;
            
        }
        .center2 {
            width: 200px;
            height: 339px;
            display: inline-block;
            
            vertical-align: top;
        }

        .buttons {
            display: block;
            padding: 10px;
            width: 900px;
            margin: 0 auto;
        }

        .bottom {
            border: 1px solid black;
            width: 40%;
            margin: 0px auto;
            
        }

        .right img, .left img {
            width: 50px;
            height: 70px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container well">
            <div class="">

               <div class="buttons well">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Get First Card from Each Deck" cssClass="btn btn-success"/>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Calculate / Start War" cssClass="btn btn-danger"/>
                    <asp:Button ID="Button3" runat="server" Text="Shuffle" OnClick="Button3_Click" cssClass="btn btn-info"/>
               </div>

               <div class="left well">
                   <h5>Player 1 Deck</h5>
                    <asp:Label ID="Label1" runat="server"></asp:Label>
               </div>


                <div class="right well">
                    <h5>Player 2 Deck</h5>
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </div>
            
            
                <div class="center well">
                    <h4>Cards At Play: </h4><hr>
                     <asp:Label ID="Label3" runat="server"></asp:Label>
                    <asp:Image ID="Image1" runat="server" />
                    <asp:Image ID="Image2" runat="server" />
                </div>

                <div class="center2 well">
                    <h4>Cards At Stake:</h4><hr>
                     <asp:Label ID="Label4" runat="server"></asp:Label>
                 </div>

                
                <div class="bottom">
                    <asp:Label ID="Label5" runat="server"></asp:Label>
                </div>
             
                </div>

                
           

               


        
      
    
    </div>
   </form>
</body>
</html>
