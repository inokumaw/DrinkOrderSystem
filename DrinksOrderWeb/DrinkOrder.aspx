<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DrinkOrder.aspx.cs" Inherits="DrinkOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .all {            
            font-family: 微軟正黑體;
        }
        .title {
            font-family: 微軟正黑體;
            font-size: large;
            font-weight: bold;
            background-color: #00FFFF;
        }
        .selection {
            background-color: #66FF66;
            font-family: 微軟正黑體;
        }
    </style>
</head>
<body>
    <form id="form1" class="all" runat="server">
        <div class="title">飲料訂購</div>
        <div>
            選擇店家Menu：<asp:FileUpload ID="FileUpload1" runat="server" Height="22px" />
            <asp:Button ID="btnOpen" runat="server" OnClick="btnOpen_Click" Text="開啟" />
            <br />
            ex: Menu.txt</div>
        <div>
            <br />
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
            <br />
            <br />
        </div>
        <div class="selection">
            <br />
            選擇項目：<strong><asp:Label ID="lblDrinkName" runat="server" Text="未選擇任何項目"></asp:Label>
            </strong>
            <br />
            <br />
            大小：<asp:RadioButtonList ID="rbListSize" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                <asp:ListItem Selected="True" Value="0">大杯</asp:ListItem>
                <asp:ListItem Value="0">中杯</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
            甜度：<asp:RadioButtonList ID="rbListSugar" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                <asp:ListItem Selected="True">正常</asp:ListItem>
                <asp:ListItem>半糖</asp:ListItem>
                <asp:ListItem>少糖</asp:ListItem>
                <asp:ListItem>微糖</asp:ListItem>
                <asp:ListItem>無糖</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
            冰塊：<asp:RadioButtonList ID="rbListIce" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                <asp:ListItem Selected="True">正常</asp:ListItem>
                <asp:ListItem>半冰</asp:ListItem>
                <asp:ListItem>少冰</asp:ListItem>
                <asp:ListItem>微冰</asp:ListItem>
                <asp:ListItem>去冰</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
            數量：<asp:TextBox ID="tbCount" runat="server" Width="100px"></asp:TextBox>
            <br />
            <br />
        </div>
        <div>
            <br />
            <asp:Button ID="btnAddToCart" runat="server" OnClick="btnAddToCart_Click" Text="加入購物車" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" PostBackUrl="~/DrinkCart.aspx" Text="查看購物車" />
        </div>
    </form>
</body>
</html>
