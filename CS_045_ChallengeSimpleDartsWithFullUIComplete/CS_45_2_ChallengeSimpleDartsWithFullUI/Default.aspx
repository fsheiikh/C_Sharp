<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_45_2_ChallengeSimpleDartsWithFullUI.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="StyleSheet1.css">
    <title></title>
         <!-- Latest compiled and minified CSS -->
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

        <!-- Optional theme -->
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">

        <!-- Latest compiled and minified JavaScript -->
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
    <style>
        .player1 {
            width: 250px;
            height: 200px;
            border: 1px solid black;
            display: inline-block;
            vertical-align: top;
        }

        .player2 {
            width: 250px;
            height: 200px;
            border: 1px solid black;
            display: inline-block;
            vertical-align: top;
        }

        

       


    </style>
</head>
<body>
    <div class="conatiner">
        <div class="well">
            <form id="form1" runat="server">
            <div>
    
            </div>
                
                
                <div class="player1 well">
                    <asp:Button ID="Player1Throw" runat="server" OnClick="Player1Throw_Click" Text="Player 1 Dart Throw" cssClass="btn btn-success"/></br>
                    <h4><asp:Label ID="playerOneTotalLabel" runat="server"></asp:Label></h4></br>
                    <h4> Player 1 Turns Left:
                    <asp:Label ID="P1TurnsLabel" runat="server" Text="15"></asp:Label></h4></br>

                </div>
                
                
                
                <div class="player2 well">
                    <asp:Button ID="Player2Throw" runat="server" OnClick="Player2Throw_Click" Text="Player 2 Dart Throw" cssClass="btn btn-info"/></br>
                    <h4><asp:Label ID="playerTwoTotalLabel" runat="server"></asp:Label></h4></br>
                    <h4>Player 2 Turns Left: 
                    <asp:Label ID="P2TurnsLabel" runat="server" Text="15"></asp:Label></h4></br>

                </div>
                
  
                <p style="margin-top: 19px">
                    <h3>Scored:
                    <asp:Label ID="currentThrowLabel" runat="server"></asp:Label></h3>
                    <h3>Bonus :
                    <asp:Label ID="BonusLabel" runat="server"></h3></asp:Label>
                    <h3><asp:Label ID="WinnerLabel" runat="server"></h3></asp:Label>
                </p>
               
            
	        <div id="DIV_10">
		        <div id="DIV_11" runat="server">
		        </div>
		        <div id="DIV_12" runat="server">
			        11
		
		        </div>
		        <div id="DIV_13" runat="server">
			        14
		        </div>
		        <div id="DIV_14" runat="server">
			        9
		        </div>
		        <div id="DIV_15" runat="server">
			        12
		        </div>
		        <div id="DIV_16" runat="server">
			        5
		        </div>
		        <div id="DIV_17" runat="server">
			        20
		        </div>
		        <div id="DIV_18" runat="server">
			        1
		        </div>
		        <div id="DIV_19" runat="server">
			        18
		        </div>
		        <div id="DIV_20" runat="server">
			        4
		        </div>
		        <div id="DIV_21" runat="server">
			        13
		        </div>
		        <div id="DIV_22" runat="server">
			        6
		        </div>
		        <div id="DIV_23" runat="server">
			        8
		        </div>
		        <div id="DIV_24" runat="server">
			        16
		        </div>
		        <div id="DIV_25" runat="server">
			        7
		        </div>
		        <div id="DIV_26" runat="server">
			        19
		        </div>
		        <div id="DIV_27" runat="server">
			        3
		        </div>
		        <div id="DIV_28" runat="server">
			        17
		        </div>
		        <div id="DIV_29" runat="server">
			        2
		        </div>
		        <div id="DIV_30" runat="server">
			        15
		        </div>
		        <div id="DIV_31" runat="server">
			        10
		        </div>
		        <div id="DIV_32">
			         <b id="B_33"><span id="SPAN_34"></span></b> <b id="B_35"><span id="SPAN_36"></span></b> <b id="B_37"><span id="SPAN_38"></span></b> <b id="B_39"><span id="SPAN_40"></span></b> <b id="B_41"><span id="SPAN_42"></span></b> <b id="B_43"><span id="SPAN_44"></span></b> <b id="B_45"><span id="SPAN_46"></span></b> <b id="B_47"><span id="SPAN_48"></span></b> <b id="B_49"><span id="SPAN_50"></span></b> <b id="B_51"><span id="SPAN_52"></span></b>
		        </div>
		        <div id="DIV_53">
			         <b id="B_54"><span id="SPAN_55"></span></b> <b id="B_56"><span id="SPAN_57"></span></b> <b id="B_58"><span id="SPAN_59"></span></b> <b id="B_60"><span id="SPAN_61"></span></b> <b id="B_62"><span id="SPAN_63"></span></b> <b id="B_64"><span id="SPAN_65"></span></b> <b id="B_66"><span id="SPAN_67"></span></b> <b id="B_68"><span id="SPAN_69"></span></b> <b id="B_70"><span id="SPAN_71"></span></b> <b id="B_72"><span id="SPAN_73"></span></b>
		        </div>
		        <div id="DIV_74">
			         <b id="B_75"><span id="SPAN_76"></span></b> <b id="B_77"><span id="SPAN_78"></span></b> <b id="B_79"><span id="SPAN_80"></span></b> <b id="B_81"><span id="SPAN_82"></span></b> <b id="B_83"><span id="SPAN_84"></span></b> <b id="B_85"><span id="SPAN_86"></span></b> <b id="B_87"><span id="SPAN_88"></span></b> <b id="B_89"><span id="SPAN_90"></span></b> <b id="B_91"><span id="SPAN_92"></span></b> <b id="B_93"><span id="SPAN_94"></span></b>
		        </div>
		        <div id="DIV_95">
			         <b id="B_96"><span id="SPAN_97"></span></b> <b id="B_98"><span id="SPAN_99"></span></b> <b id="B_100"><span id="SPAN_101"></span></b> <b id="B_102"><span id="SPAN_103"></span></b> <b id="B_104"><span id="SPAN_105"></span></b> <b id="B_106"><span id="SPAN_107"></span></b> <b id="B_108"><span id="SPAN_109"></span></b> <b id="B_110"><span id="SPAN_111"></span></b> <b id="B_112"><span id="SPAN_113"></span></b> <b id="B_114"><span id="SPAN_115"></span></b>
		        </div>
		        <div id="DIV_116" runat="server">
		        </div>
		        <div id="DIV_117" runat="server">
		        </div>
		        <div id="DIV_118">
			        <b id="B_119"></b><b id="B_120"></b><b id="B_121"></b><b id="B_122"></b><b id="B_123"></b><b id="B_124"></b><b id="B_125"></b><b id="B_126"></b><b id="B_127"></b><b id="B_128"></b><b id="B_129"></b><b id="B_130"></b><b id="B_131"></b><b id="B_132"></b><b id="B_133"></b><b id="B_134"></b><b id="B_135"></b><b id="B_136"></b><b id="B_137"></b><b id="B_138"></b>
		        </div>
	        </div>
            </form>
        
    </div>
    
    
	
	
	


</body>
</html>
